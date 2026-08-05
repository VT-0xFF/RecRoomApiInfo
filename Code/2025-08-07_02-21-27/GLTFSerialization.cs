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
	public class KHR_animation_pointer : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object XPGEPRJEKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string KXMHUBYSOIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string UVRDPWPGDUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GEOZCVBEFLD NBWQPMNMHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer TPKUQZVJEMG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7804420", Offset = "0x7803020", VA = "0x187804420", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7804370", Offset = "0x7802F70", VA = "0x187804370", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class PZEGCWOTDJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 VCVYKZJPYPJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 MGHDEGFPVNQ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion FVDRORXOWBU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ARUERGOKNVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x780C4E0", Offset = "0x780B0E0", VA = "0x18780C4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x780BDA0", Offset = "0x780A9A0", VA = "0x18780BDA0")]
		public static void RKCBFXEXDDE(this OINYKCZIBWN a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x780A3D0", Offset = "0x7808FD0", VA = "0x18780A3D0")]
		public static void CXIIDSMAYJS(this OINYKCZIBWN a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x780A8D0", Offset = "0x78094D0", VA = "0x18780A8D0")]
		public static void DCOKVSGRAZR(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7809FA0", Offset = "0x7808BA0", VA = "0x187809FA0")]
		public static GLTF.Math.Vector4 AIIOGFUYUAF(this FWBEJGDGJCE a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x780D4C0", Offset = "0x780C0C0", VA = "0x18780D4C0")]
		public static UnityEngine.Quaternion ZAKJXPVJGGI(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x780D650", Offset = "0x780C250", VA = "0x18780D650")]
		public static UnityEngine.Quaternion ZAKJXPVJGGI(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x780AEC0", Offset = "0x7809AC0", VA = "0x18780AEC0")]
		public static GLTF.Math.Quaternion LEHMGNRQPFS(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x780D080", Offset = "0x780BC80", VA = "0x18780D080")]
		public static Matrix4x4 WMDMSNCVBXF(this FWBEJGDGJCE a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x780CC40", Offset = "0x780B840", VA = "0x18780CC40")]
		public static Matrix4x4 WMDMSNCVBXF(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x780B000", Offset = "0x7809C00", VA = "0x18780B000")]
		public static FWBEJGDGJCE LNDJOBVXLFV(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x780BB20", Offset = "0x780A720", VA = "0x18780BB20")]
		public static UnityEngine.Vector3 QKJRGCXXYOW(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x780BA40", Offset = "0x780A640", VA = "0x18780BA40")]
		public static UnityEngine.Vector3 QKJRGCXXYOW(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x780D2A0", Offset = "0x780BEA0", VA = "0x18780D2A0")]
		public static GLTF.Math.Vector3 WSNIFPYGQBE(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x780B4A0", Offset = "0x780A0A0", VA = "0x18780B4A0")]
		public static GLTF.Math.Vector3 OCAIEHJCQFR(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static GLTF.Math.Vector4 BGTLSMEBOMU(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x780B4E0", Offset = "0x780A0E0", VA = "0x18780B4E0")]
		public static Matrix4x4 ORULHNNZJJY(this FWBEJGDGJCE a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x780B7A0", Offset = "0x780A3A0", VA = "0x18780B7A0")]
		public static Matrix4x4 ORULHNNZJJY(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x780C6C0", Offset = "0x780B2C0", VA = "0x18780C6C0")]
		public static FWBEJGDGJCE UMTNFSMNEKW(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x780C940", Offset = "0x780B540", VA = "0x18780C940")]
		public static UnityEngine.Vector2 VCBDXRKRCBI(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x780C940", Offset = "0x780B540", VA = "0x18780C940")]
		public static UnityEngine.Vector2 VCBDXRKRCBI(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x780C960", Offset = "0x780B560", VA = "0x18780C960")]
		public static void VCBDXRKRCBI(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x780C570", Offset = "0x780B170", VA = "0x18780C570")]
		public static UnityEngine.Vector3 UDXDQHBPANF(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2034550", Offset = "0x2033150", VA = "0x182034550")]
		public static UnityEngine.Vector3 UDXDQHBPANF(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x780C5D0", Offset = "0x780B1D0", VA = "0x18780C5D0")]
		public static void UDXDQHBPANF(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static UnityEngine.Vector4 VERNQUUSKVG(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static UnityEngine.Vector4 VERNQUUSKVG(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x780CB40", Offset = "0x780B740", VA = "0x18780CB40")]
		public static UnityEngine.Vector4[] VERNQUUSKVG(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x780CA30", Offset = "0x780B630", VA = "0x18780CA30")]
		public static void VERNQUUSKVG(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x780A330", Offset = "0x7808F30", VA = "0x18780A330")]
		public static UnityEngine.Color BNOITCFAQNQ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x780A1F0", Offset = "0x7808DF0", VA = "0x18780A1F0")]
		public static void BNOITCFAQNQ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x780A330", Offset = "0x7808F30", VA = "0x18780A330")]
		public static UnityEngine.Color BNOITCFAQNQ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static UnityEngine.Color ZGSYIUGSMQN(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x780D780", Offset = "0x780C380", VA = "0x18780D780")]
		public static void ZGSYIUGSMQN(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static UnityEngine.Color ZGSYIUGSMQN(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x780BA10", Offset = "0x780A610", VA = "0x18780BA10")]
		public static GLTF.Math.Color QBHBMBORPVN(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x780D3D0", Offset = "0x780BFD0", VA = "0x18780D3D0")]
		public static GLTF.Math.Color YIQZTONJWXI(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x780AE40", Offset = "0x7809A40", VA = "0x18780AE40")]
		public static GLTF.Math.Color JMSGBSLCYSE(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x780ACA0", Offset = "0x78098A0", VA = "0x18780ACA0")]
		public static UnityEngine.Color[] ECLXFHWZBMR(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x780ADC0", Offset = "0x78099C0", VA = "0x18780ADC0")]
		public static int[] IFNNYDDBPUM(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x780C890", Offset = "0x780B490", VA = "0x18780C890")]
		public static UnityEngine.Vector2[] UTCXJDFHENV(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x780B340", Offset = "0x7809F40", VA = "0x18780B340")]
		public static void NLKVDXMWFJO(RQPKSVVWTGU a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x780BC40", Offset = "0x780A840", VA = "0x18780BC40")]
		public static UnityEngine.Vector3[] RIONYPOCRMQ(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x780C340", Offset = "0x780AF40", VA = "0x18780C340")]
		public static UnityEngine.Vector4[] SAHIWSBCEDL(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x780D450", Offset = "0x780C050", VA = "0x18780D450")]
		public static void YJUULZDBUKI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x780A1C0", Offset = "0x7808DC0", VA = "0x18780A1C0")]
		public static UnityEngine.Quaternion ASGTBQLXAPU(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RQPKSVVWTGU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LLWPAQBYPVZ LLWPAQBYPVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray ZOLDNFTXWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x780E230", Offset = "0x780CE30", VA = "0x18780E230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> LOWZRINIZTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF343E0", Offset = "0xF32FE0", VA = "0x180F343E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x102C3D0", Offset = "0x102AFD0", VA = "0x18102C3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint TIQLVDZUMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB18830", Offset = "0xB17430", VA = "0x180B18830")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB18820", Offset = "0xB17420", VA = "0x180B18820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x780E240", Offset = "0x780CE40", VA = "0x18780E240")]
		public RQPKSVVWTGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x78023C0", Offset = "0x7800FC0", VA = "0x1878023C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7802420", Offset = "0x7801020", VA = "0x187802420")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class ZJQIVEHHWJX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XOTIXDXNSGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> DAPNEOFUAYU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XOTIXDXNSGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7817FF0", Offset = "0x7816BF0", VA = "0x187817FF0")]
			internal int? ZGUVUGAOIMB(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7817E90", Offset = "0x7816A90", VA = "0x187817E90")]
			internal int? BCJPTBWHJXS(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7817F20", Offset = "0x7816B20", VA = "0x187817F20")]
			internal bool JGNVQCQRXJC(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x781A550", Offset = "0x7819150", VA = "0x18781A550")]
		private static void QNIZUAKSGJQ(NumericArray a, RQPKSVVWTGU b, RQPKSVVWTGU c, RQPKSVVWTGU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7818070", Offset = "0x7816C70", VA = "0x187818070")]
		public static void CWMFWSWAMWX(Dictionary<string, RQPKSVVWTGU> a, Dictionary<string, (RQPKSVVWTGU sparseIndices, RQPKSVVWTGU sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7819BD0", Offset = "0x78187D0", VA = "0x187819BD0")]
		public static void LZAZDMWHLSL(Dictionary<string, RQPKSVVWTGU> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7819540", Offset = "0x7818140", VA = "0x187819540")]
		public static void ETJCSQVBEUA(RQPKSVVWTGU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7819640", Offset = "0x7818240", VA = "0x187819640")]
		public static void EYPZKEJMTAS(Dictionary<string, List<RQPKSVVWTGU>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7819410", Offset = "0x7818010", VA = "0x187819410")]
		private static void EFOKGYLICJY(RQPKSVVWTGU a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7819350", Offset = "0x7817F50", VA = "0x187819350")]
		internal static void EFOKGYLICJY(DYIKJDPCYCK a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x781A0B0", Offset = "0x7818CB0", VA = "0x18781A0B0")]
		public static RKPACBPTHBK OOUMOZLOWIS(IEnumerable<RKPACBPTHBK> a)
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
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x32F76D0", Offset = "0x32F62D0", VA = "0x1832F76D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x32F76E0", Offset = "0x32F62E0", VA = "0x1832F76E0")]
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
	public class FYXUOCPFMAX
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint DVWMGCWGZRG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint AVZZDFXXPFM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint BEENMKXSJGE;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7801860", Offset = "0x7800460", VA = "0x187801860")]
		public static void AYZOEUXBUSC(Stream a, [Out] WHQEVNUVYVG b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7801F80", Offset = "0x7800B80", VA = "0x187801F80")]
		public static ChunkInfo NSJVRMTSMWW(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7802210", Offset = "0x7800E10", VA = "0x187802210")]
		public static GLBHeader YVHIPIJFDGG(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7801A20", Offset = "0x7800620", VA = "0x187801A20")]
		public static bool HQBCFGOVOEM(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7801E10", Offset = "0x7800A10", VA = "0x187801E10")]
		public static ChunkInfo NNXXJRIRUNP(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7801B70", Offset = "0x7800770", VA = "0x187801B70")]
		private static void NAXIAALNPFV(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7801AE0", Offset = "0x78006E0", VA = "0x187801AE0")]
		private static uint HSZLGRPEPAO(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KOBLWLFFCYZ
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
		public PathElement WDASFTRMOFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int DMPVJOPMYMT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC13B00", Offset = "0xC12700", VA = "0x180C13B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string GUDQLJYUMGY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YFTSFAYWIWF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB13A80", Offset = "0xB12680", VA = "0x180B13A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KOBLWLFFCYZ TCLYXZWXUEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7807A80", Offset = "0x7806680", VA = "0x187807A80")]
		public string XSMHBKMVACJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7807CE0", Offset = "0x78068E0", VA = "0x187807CE0")]
		public KOBLWLFFCYZ ZPVSARCITZR(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7807D00", Offset = "0x7806900", VA = "0x187807D00")]
		private KOBLWLFFCYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7807D60", Offset = "0x7806960", VA = "0x187807D60")]
		public KOBLWLFFCYZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4641FA0", Offset = "0x4640BA0", VA = "0x184641FA0")]
		[CompilerGenerated]
		internal static string XSVLSIYXGTT(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7807A40", Offset = "0x7806640", VA = "0x187807A40")]
		[CompilerGenerated]
		internal static bool NHAGUHGIVZS([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7807B00", Offset = "0x7806700", VA = "0x187807B00")]
		[CompilerGenerated]
		internal static KOBLWLFFCYZ YIHESQZBANU(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class NJVRAFOUVIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7808FD0", Offset = "0x7807BD0", VA = "0x187808FD0")]
		public static int[] MNPNQIKSCVK(this WHQEVNUVYVG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7808E80", Offset = "0x7807A80", VA = "0x187808E80")]
		public static int[] LKHXYCXXEVQ(this WHQEVNUVYVG a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class WJOFXNTDYJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7816920", Offset = "0x7815520", VA = "0x187816920")]
		public static uint QUZQAPKVJZD(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream LZDAKQNBGTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long WTWUPMPKWFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long YCTDRJPKPTP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x780ECB0", Offset = "0x780D8B0", VA = "0x18780ECB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x780ECF0", Offset = "0x780D8F0", VA = "0x18780ECF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x780ECF0", Offset = "0x780D8F0", VA = "0x18780ECF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x780ED10", Offset = "0x780D910", VA = "0x18780ED10", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x780ED30", Offset = "0x780D930", VA = "0x18780ED30", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x780ED50", Offset = "0x780D950", VA = "0x18780ED50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x780EA40", Offset = "0x780D640", VA = "0x18780EA40")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x780E800", Offset = "0x780D400", VA = "0x18780E800", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x780E960", Offset = "0x780D560", VA = "0x18780E960", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x780E9C0", Offset = "0x780D5C0", VA = "0x18780E9C0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x780E8D0", Offset = "0x780D4D0", VA = "0x18780E8D0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x780EA00", Offset = "0x780D600", VA = "0x18780EA00", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x780E840", Offset = "0x780D440", VA = "0x18780E840")]
		private void IPKXIYTTZTK()
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
		public static Color ZLFMDTIXPYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x77FFDC0", Offset = "0x77FE9C0", VA = "0x1877FFDC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color RAESVULWHFU
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x77FFDB0", Offset = "0x77FE9B0", VA = "0x1877FFDB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color WSLLSVIMMWK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x77FFFE0", Offset = "0x77FEBE0", VA = "0x1877FFFE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x302C090", Offset = "0x302AC90", VA = "0x18302C090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081C30", VA = "0x183083030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x34F2410", Offset = "0x34F1010", VA = "0x1834F2410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1597B60", Offset = "0x1596760", VA = "0x181597B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1597B70", Offset = "0x1596770", VA = "0x181597B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DC4040", Offset = "0x2DC2C40", VA = "0x182DC4040")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x77FFDE0", Offset = "0x77FE9E0", VA = "0x1877FFDE0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77FFE90", Offset = "0x77FEA90", VA = "0x1877FFE90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x77FFF30", Offset = "0x77FEB30", VA = "0x1877FFF30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7800000", Offset = "0x77FEC00", VA = "0x187800000")]
		public static bool SZMIMWEVICM(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FWBEJGDGJCE : IEquatable<FWBEJGDGJCE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly FWBEJGDGJCE TUPVBLZUFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] CKBBLNFWGAV;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float SQIBCXQABFY
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x78012F0", Offset = "0x77FFEF0", VA = "0x1878012F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x78013E0", Offset = "0x77FFFE0", VA = "0x1878013E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ZRJTWDLXJUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x78011A0", Offset = "0x77FFDA0", VA = "0x1878011A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7801230", Offset = "0x77FFE30", VA = "0x187801230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GLDYJZTLQRO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7801080", Offset = "0x77FFC80", VA = "0x187801080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7800F90", Offset = "0x77FFB90", VA = "0x187800F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MMHSPXQINKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7801410", Offset = "0x7800010", VA = "0x187801410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7800B40", Offset = "0x77FF740", VA = "0x187800B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float SQCUFQWCRUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7801290", Offset = "0x77FFE90", VA = "0x187801290")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7801380", Offset = "0x77FFF80", VA = "0x187801380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZQTZEJEFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7801170", Offset = "0x77FFD70", VA = "0x187801170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7801200", Offset = "0x77FFE00", VA = "0x187801200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GLTTBUBDSZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x78010B0", Offset = "0x77FFCB0", VA = "0x1878010B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7800FC0", Offset = "0x77FFBC0", VA = "0x187800FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MMMZNEKFWVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7801470", Offset = "0x7800070", VA = "0x187801470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7800BA0", Offset = "0x77FF7A0", VA = "0x187800BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float SPXNIKCFIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x78012C0", Offset = "0x77FFEC0", VA = "0x1878012C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x78013B0", Offset = "0x77FFFB0", VA = "0x1878013B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ZQZGBPYCQYH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7801140", Offset = "0x77FFD40", VA = "0x187801140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x78011D0", Offset = "0x77FFDD0", VA = "0x1878011D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float GLOMENHGJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x78010E0", Offset = "0x77FFCE0", VA = "0x1878010E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7800FF0", Offset = "0x77FFBF0", VA = "0x187800FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float MMSGKLEDGGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7801440", Offset = "0x7800040", VA = "0x187801440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7800B70", Offset = "0x77FF770", VA = "0x187800B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float SRIJPFLMWKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7801320", Offset = "0x77FFF20", VA = "0x187801320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7801350", Offset = "0x77FFF50", VA = "0x187801350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float ZQJLJVQKOQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7801110", Offset = "0x77FFD10", VA = "0x187801110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7801260", Offset = "0x77FFE60", VA = "0x187801260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float GMEGWHOYLWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7801050", Offset = "0x77FFC50", VA = "0x187801050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7801020", Offset = "0x77FFC20", VA = "0x187801020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float MLHKDPUVSFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x78014A0", Offset = "0x78000A0", VA = "0x1878014A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7800B10", Offset = "0x77FF710", VA = "0x187800B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78015B0", Offset = "0x78001B0", VA = "0x1878015B0")]
		public FWBEJGDGJCE(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7800BD0", Offset = "0x77FF7D0", VA = "0x187800BD0", Slot = "4")]
		public bool Equals(FWBEJGDGJCE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7800E90", Offset = "0x77FFA90", VA = "0x187800E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x11AFDC0", Offset = "0x11AE9C0", VA = "0x1811AFDC0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x302C090", Offset = "0x302AC90", VA = "0x18302C090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081C30", VA = "0x183083030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x34F2410", Offset = "0x34F1010", VA = "0x1834F2410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1597B60", Offset = "0x1596760", VA = "0x181597B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1597B70", Offset = "0x1596770", VA = "0x181597B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x780E030", Offset = "0x780CC30", VA = "0x18780E030")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x780DC90", Offset = "0x780C890", VA = "0x18780DC90", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x780DDB0", Offset = "0x780C9B0", VA = "0x18780DDB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x780DE60", Offset = "0x780CA60", VA = "0x18780DE60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x780DF40", Offset = "0x780CB40", VA = "0x18780DF40")]
		public static bool SZMIMWEVICM(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x302C090", Offset = "0x302AC90", VA = "0x18302C090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081C30", VA = "0x183083030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1115580", Offset = "0x1114180", VA = "0x181115580")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7815140", Offset = "0x7813D40", VA = "0x187815140")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7814F50", Offset = "0x7813B50", VA = "0x187814F50", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7814FB0", Offset = "0x7813BB0", VA = "0x187814FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7815090", Offset = "0x7813C90", VA = "0x187815090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x78150E0", Offset = "0x7813CE0", VA = "0x1878150E0")]
		public static bool SZMIMWEVICM(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x302C090", Offset = "0x302AC90", VA = "0x18302C090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081C30", VA = "0x183083030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x34F2410", Offset = "0x34F1010", VA = "0x1834F2410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7815500", Offset = "0x7814100", VA = "0x187815500")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7815160", Offset = "0x7813D60", VA = "0x187815160", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7815240", Offset = "0x7813E40", VA = "0x187815240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7815300", Offset = "0x7813F00", VA = "0x187815300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78153B0", Offset = "0x7813FB0", VA = "0x1878153B0")]
		public static bool SZMIMWEVICM(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x302C090", Offset = "0x302AC90", VA = "0x18302C090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081C30", VA = "0x183083030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x34F2410", Offset = "0x34F1010", VA = "0x1834F2410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1597B60", Offset = "0x1596760", VA = "0x181597B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1597B70", Offset = "0x1596770", VA = "0x181597B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DC4040", Offset = "0x2DC2C40", VA = "0x182DC4040")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x77FFDE0", Offset = "0x77FE9E0", VA = "0x1877FFDE0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7815580", Offset = "0x7814180", VA = "0x187815580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x77FFF30", Offset = "0x77FEB30", VA = "0x1877FFF30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CADDXFTGHJQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x77FFB80", Offset = "0x77FE780", VA = "0x1877FFB80")]
		public static void SYJAYMGWMWL(this JObject a, string b, TSHBWHIVAEI c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class WJOFXNTDYJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7816A70", Offset = "0x7815670", VA = "0x187816A70")]
		public static List<string> TZNCLJNMPMM(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7815D50", Offset = "0x7814950", VA = "0x187815D50")]
		public static List<double> HCXAMZOPHVK(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7815F10", Offset = "0x7814B10", VA = "0x187815F10")]
		public static List<int> JMQCZKYTVVJ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x41B9CE0", Offset = "0x41B88E0", VA = "0x1841B9CE0")]
		public static List<a> MMTJRICHTMV<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7816E90", Offset = "0x7815A90", VA = "0x187816E90")]
		public static TSHBWHIVAEI VFCYQWRGYFZ(this JToken a, WHQEVNUVYVG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7815930", Offset = "0x7814530", VA = "0x187815930")]
		public static int CUXYYMRLGOF(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7816370", Offset = "0x7814F70", VA = "0x187816370")]
		public static double PKEBJWHNHTL(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7815A70", Offset = "0x7814670", VA = "0x187815A70")]
		public static GLTF.Math.Color DNDQRTYRISS(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7816C20", Offset = "0x7815820", VA = "0x187816C20")]
		public static GLTF.Math.Color URLOMGMYXFZ(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x78160D0", Offset = "0x7814CD0", VA = "0x1878160D0")]
		public static GLTF.Math.Color MEHOCZIMRNV(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7817140", Offset = "0x7815D40", VA = "0x187817140")]
		public static GLTF.Math.Vector3 ZQNTODMGKSP(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7816710", Offset = "0x7815310", VA = "0x187816710")]
		public static GLTF.Math.Vector2 QGGLMAGUZLF(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x78164B0", Offset = "0x78150B0", VA = "0x1878164B0")]
		public static GLTF.Math.Vector3 QGBEOTMXPZW(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7815620", Offset = "0x7814220", VA = "0x187815620")]
		public static GLTF.Math.Quaternion AMTWRVRZLUZ(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x41A5D60", Offset = "0x41A4960", VA = "0x1841A5D60")]
		public static Dictionary<string, b> BMMIKWQDHEB<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41A6140", Offset = "0x41A4D40", VA = "0x1841A6140")]
		public static c KWGPGFCRBHD<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DYIKJDPCYCK bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7800710", Offset = "0x77FF310", VA = "0x187800710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7800690", Offset = "0x77FF290", VA = "0x187800690", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class UOWXNQDMCSN : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7813E40", Offset = "0x7812A40", VA = "0x187813E40")]
		public UOWXNQDMCSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7813D70", Offset = "0x7812970", VA = "0x187813D70", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, LLWPAQBYPVZ> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7800550", Offset = "0x77FF150", VA = "0x187800550", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7800610", Offset = "0x77FF210", VA = "0x187800610")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OBYEXUHJUTV : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public WHQEVNUVYVG PPGZRRIGXVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader IBUFBOVYLGO;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7807F10", Offset = "0x7806B10", VA = "0x187807F10")]
			internal LLWPAQBYPVZ WFWLZXPKODO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7809E30", Offset = "0x7808A30", VA = "0x187809E30")]
		public OBYEXUHJUTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7809CA0", Offset = "0x78088A0", VA = "0x187809CA0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MAFVURACFRJ FUYJWBLGFUM;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public EXT_texture_exr(MAFVURACFRJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7800760", Offset = "0x77FF360", VA = "0x187800760", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x78007D0", Offset = "0x77FF3D0", VA = "0x1878007D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class RCCVPDNDCVY : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x780E1E0", Offset = "0x780CDE0", VA = "0x18780E1E0")]
		public RCCVPDNDCVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x780E0C0", Offset = "0x780CCC0", VA = "0x18780E0C0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
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
	public class AudioEmitterId : KKTKXGNETQO<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x77FF5F0", Offset = "0x77FE1F0", VA = "0x1877FF5F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x77FF5B0", Offset = "0x77FE1B0", VA = "0x1877FF5B0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : KKTKXGNETQO<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x77FF780", Offset = "0x77FE380", VA = "0x1877FF780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77FF740", Offset = "0x77FE340", VA = "0x1877FF740")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : KKTKXGNETQO<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x77FF460", Offset = "0x77FE060", VA = "0x1877FF460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77FF420", Offset = "0x77FE020", VA = "0x1877FF420")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77FF340", Offset = "0x77FDF40", VA = "0x1877FF340")]
		public static AudioDataId Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7804090", Offset = "0x7802C90", VA = "0x187804090", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7803C90", Offset = "0x7802890", VA = "0x187803C90", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7803D00", Offset = "0x7802900", VA = "0x187803D00")]
		public static KHR_SceneAudioEmittersRef Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x78042F0", Offset = "0x7802EF0", VA = "0x1878042F0")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7803C60", Offset = "0x7802860", VA = "0x187803C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7803B40", Offset = "0x7802740", VA = "0x187803B40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7803930", Offset = "0x7802530", VA = "0x187803930", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x78039A0", Offset = "0x78025A0", VA = "0x1878039A0")]
		public static KHR_NodeAudioEmitterRef Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class MOBPXNTFMWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string BSWFOPYGRRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? EGAMCAIWDRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? YSXFCOFAJIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? XDNKVQEOESO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? YBPALDVETEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? YOXHFZRUPES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? WBOIEDPKURP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? MXOUQIDDBJO;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7808C10", Offset = "0x7807810", VA = "0x187808C10")]
		public JObject Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7808510", Offset = "0x7807110", VA = "0x187808510")]
		public static MOBPXNTFMWL Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MOBPXNTFMWL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : FRLCSFKBVSK
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
		public MOBPXNTFMWL positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7802F80", Offset = "0x7801B80", VA = "0x187802F80", Slot = "5")]
		public virtual JObject Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7802A80", Offset = "0x7801680", VA = "0x187802A80")]
		public static KHR_AudioEmitter Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7803320", Offset = "0x7801F20", VA = "0x187803320")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : FRLCSFKBVSK
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
		[Cpp2IlInjected.Address(RVA = "0x7803700", Offset = "0x7802300", VA = "0x187803700")]
		public JObject Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x78033A0", Offset = "0x7801FA0", VA = "0x1878033A0")]
		public static KHR_AudioSource Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7802A70", Offset = "0x7801670", VA = "0x187802A70")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IDGWKMEFJAX bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7802940", Offset = "0x7801540", VA = "0x187802940")]
		public JObject Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x78026E0", Offset = "0x78012E0", VA = "0x1878026E0")]
		public static KHR_AudioData Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7802A70", Offset = "0x7801670", VA = "0x187802A70")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : FNHEMEFBNEF
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
		[Cpp2IlInjected.Address(RVA = "0x78045B0", Offset = "0x78031B0", VA = "0x1878045B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7804520", Offset = "0x7803120", VA = "0x187804520", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7804CE0", Offset = "0x78038E0", VA = "0x187804CE0")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class VNWIHEXDPPY : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7814F00", Offset = "0x7813B00", VA = "0x187814F00")]
		public VNWIHEXDPPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7814350", Offset = "0x7812F50", VA = "0x187814350", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IDGWKMEFJAX bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7804EB0", Offset = "0x7803AB0", VA = "0x187804EB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7804DF0", Offset = "0x78039F0", VA = "0x187804DF0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7804F00", Offset = "0x7803B00", VA = "0x187804F00")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JUGOVZBQYII : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader IBUFBOVYLGO;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7807FC0", Offset = "0x7806BC0", VA = "0x187807FC0")]
			internal int WFWLZXPKODO()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7802690", Offset = "0x7801290", VA = "0x187802690")]
		public JUGOVZBQYII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7802480", Offset = "0x7801080", VA = "0x187802480", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TSHBWHIVAEI anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7805000", Offset = "0x7803C00", VA = "0x187805000", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7804F80", Offset = "0x7803B80", VA = "0x187804F80", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class EQUIWNETALV : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7800500", Offset = "0x77FF100", VA = "0x187800500")]
		public EQUIWNETALV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7800350", Offset = "0x77FEF50", VA = "0x187800350", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TSHBWHIVAEI clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public TSHBWHIVAEI clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public TSHBWHIVAEI clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x78052B0", Offset = "0x7803EB0", VA = "0x1878052B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7805210", Offset = "0x7803E10", VA = "0x187805210", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class VCYSADFSNSJ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7814300", Offset = "0x7812F00", VA = "0x187814300")]
		public VCYSADFSNSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7814080", Offset = "0x7812C80", VA = "0x187814080", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7805610", Offset = "0x7804210", VA = "0x187805610", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x78055A0", Offset = "0x78041A0", VA = "0x1878055A0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class FBXNJIJBJUJ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7800990", Offset = "0x77FF590", VA = "0x187800990")]
		public FBXNJIJBJUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x78008C0", Offset = "0x77FF4C0", VA = "0x1878008C0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : JSSHJYTNBTX, FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float ZCTHHWBAUPB;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x78058F0", Offset = "0x78044F0", VA = "0x1878058F0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7805940", Offset = "0x7804540", VA = "0x187805940")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, WHQEVNUVYVG root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7805730", Offset = "0x7804330", VA = "0x187805730", Slot = "6")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x78057D0", Offset = "0x78043D0", VA = "0x1878057D0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class EMPXAUKRARI : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7800300", Offset = "0x77FEF00", VA = "0x187800300")]
		public EMPXAUKRARI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7800200", Offset = "0x77FEE00", VA = "0x187800200", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7805A10", Offset = "0x7804610", VA = "0x187805A10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x78059B0", Offset = "0x78045B0", VA = "0x1878059B0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7805B60", Offset = "0x7804760", VA = "0x187805B60")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class PRDHIPENZYN : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7809F50", Offset = "0x7808B50", VA = "0x187809F50")]
		public PRDHIPENZYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7809E80", Offset = "0x7808A80", VA = "0x187809E80", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TSHBWHIVAEI iridescenceTexture;

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
		public TSHBWHIVAEI iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7805C10", Offset = "0x7804810", VA = "0x187805C10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7805B70", Offset = "0x7804770", VA = "0x187805B70", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7805FD0", Offset = "0x7804BD0", VA = "0x187805FD0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class QGWCJRPEBFF : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x780DC40", Offset = "0x780C840", VA = "0x18780DC40")]
		public QGWCJRPEBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x780D950", Offset = "0x780C550", VA = "0x18780D950", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class OAFMBPZLZIO : FNHEMEFBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 DVVGFGXYHXY;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double HTZFPPVGXDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color MAMJHFAOCNU;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color IYWMIDCQNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public TSHBWHIVAEI HOKQFUOIDUI;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly TSHBWHIVAEI LQAIQOGEJRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 JGRNWPUXULN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double ZXNDAPRKSQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TSHBWHIVAEI EKEUOQRVVWZ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly TSHBWHIVAEI URCQJUQKWQF;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7809BA0", Offset = "0x78087A0", VA = "0x187809BA0")]
		public OAFMBPZLZIO(GLTF.Math.Color a, TSHBWHIVAEI b, GLTF.Math.Vector3 c, double d, TSHBWHIVAEI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7809270", Offset = "0x7807E70", VA = "0x187809270", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7809430", Offset = "0x7808030", VA = "0x187809430", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class MIHHAMBYZMA : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7808390", Offset = "0x7806F90", VA = "0x187808390")]
		public MIHHAMBYZMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7808030", Offset = "0x7806C30", VA = "0x187808030", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public TSHBWHIVAEI sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public TSHBWHIVAEI sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x78060C0", Offset = "0x7804CC0", VA = "0x1878060C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7805FF0", Offset = "0x7804BF0", VA = "0x187805FF0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x78065D0", Offset = "0x78051D0", VA = "0x1878065D0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class BWASUUHEKVQ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77FFB30", Offset = "0x77FE730", VA = "0x1877FFB30")]
		public BWASUUHEKVQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x77FF8D0", Offset = "0x77FE4D0", VA = "0x1877FF8D0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public TSHBWHIVAEI specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public TSHBWHIVAEI specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7806710", Offset = "0x7805310", VA = "0x187806710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7806640", Offset = "0x7805240", VA = "0x187806640", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7806C30", Offset = "0x7805830", VA = "0x187806C30")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SRZMNBVCXFM : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x780E7B0", Offset = "0x780D3B0", VA = "0x18780E7B0")]
		public SRZMNBVCXFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x780E590", Offset = "0x780D190", VA = "0x18780E590", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public TSHBWHIVAEI transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7806D20", Offset = "0x7805920", VA = "0x187806D20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7806CA0", Offset = "0x78058A0", VA = "0x187806CA0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class UKGLPUYRRBZ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7813D20", Offset = "0x7812920", VA = "0x187813D20")]
		public UKGLPUYRRBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7813BE0", Offset = "0x78127E0", VA = "0x187813BE0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class WVYIFVTWFCQ : JSSHJYTNBTX, FNHEMEFBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7817600", Offset = "0x7816200", VA = "0x187817600")]
		public WVYIFVTWFCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7817650", Offset = "0x7816250", VA = "0x187817650")]
		public WVYIFVTWFCQ(WVYIFVTWFCQ a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7817400", Offset = "0x7816000", VA = "0x187817400", Slot = "6")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7817570", Offset = "0x7816170", VA = "0x187817570", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x78174A0", Offset = "0x78160A0", VA = "0x1878174A0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class TPUAJZCDOKC : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x78139F0", Offset = "0x78125F0", VA = "0x1878139F0")]
		public TPUAJZCDOKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7813970", Offset = "0x7812570", VA = "0x187813970", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public TSHBWHIVAEI thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7806F40", Offset = "0x7805B40", VA = "0x187806F40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7806EB0", Offset = "0x7805AB0", VA = "0x187806EB0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7807470", Offset = "0x7806070", VA = "0x187807470")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class TNVKFCIGPUR : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7813920", Offset = "0x7812520", VA = "0x187813920")]
		public TNVKFCIGPUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7813710", Offset = "0x7812310", VA = "0x187813710", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x78074F0", Offset = "0x78060F0", VA = "0x1878074F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7807490", Offset = "0x7806090", VA = "0x187807490", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DF740", VA = "0x1812E0B40")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class FGQPEHSXZCL : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7800AC0", Offset = "0x77FF6C0", VA = "0x187800AC0")]
		public FGQPEHSXZCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x78009E0", Offset = "0x77FF5E0", VA = "0x1878009E0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7807660", Offset = "0x7806260", VA = "0x187807660", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7807600", Offset = "0x7806200", VA = "0x187807600", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DF740", VA = "0x1812E0B40")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class MLMWFMHRBEJ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x78084C0", Offset = "0x78070C0", VA = "0x1878084C0")]
		public MLMWFMHRBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x78083E0", Offset = "0x7806FE0", VA = "0x1878083E0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x78077D0", Offset = "0x78063D0", VA = "0x1878077D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7807770", Offset = "0x7806370", VA = "0x187807770", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DF740", VA = "0x1812E0B40")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class TUGAHZQLNDZ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7813B20", Offset = "0x7812720", VA = "0x187813B20")]
		public TUGAHZQLNDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7813A40", Offset = "0x7812640", VA = "0x187813A40", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public MAFVURACFRJ source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public KHR_texture_basisu(MAFVURACFRJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x78078E0", Offset = "0x78064E0", VA = "0x1878078E0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7807950", Offset = "0x7806550", VA = "0x187807950", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CXVDNNDBHPD : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x77FFD60", Offset = "0x77FE960", VA = "0x1877FFD60")]
		public CXVDNNDBHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x77FFC00", Offset = "0x77FE800", VA = "0x1877FFC00", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class XFMRFLZRKLQ : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 TIQLVDZUMDM;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 VGMAFPREOIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double VKXVPHMWDKP;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double TEPSQUQCAKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 FNVHMWLXVDX;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 LDHYUSVKJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? EUEHQOZUJTB;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int VPAFGHWXJFL;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7817E10", Offset = "0x7816A10", VA = "0x187817E10")]
		public XFMRFLZRKLQ(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x78176C0", Offset = "0x78162C0", VA = "0x1878176C0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78177A0", Offset = "0x78163A0", VA = "0x1878177A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class RQVEYAIPBKQ : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x780E540", Offset = "0x780D140", VA = "0x18780E540")]
		public RQVEYAIPBKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x780E270", Offset = "0x780CE70", VA = "0x18780E270", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class UTTOMCMNXUI : FNHEMEFBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> NQLXDAPPFXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public UTTOMCMNXUI(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7813F20", Offset = "0x7812B20", VA = "0x187813F20", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7813F90", Offset = "0x7812B90", VA = "0x187813F90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7813E90", Offset = "0x7812A90", VA = "0x187813E90")]
		public List<double> CRRTXBPTKPC(OINYKCZIBWN a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DZIUDWBCPFU : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x78001B0", Offset = "0x77FEDB0", VA = "0x1878001B0")]
		public DZIUDWBCPFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x78000B0", Offset = "0x77FECB0", VA = "0x1878000B0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class TGBUZDPTTNE : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IDGWKMEFJAX DYIKJDPCYCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint ZZFTKMTXJHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType ZLXFIPLBFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool XKIIBOCNFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint YDGZHCXKSNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType JGVJNZJVVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> FCDOLGFBEWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> DKBKXKDPFSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public RFFJHZFTXPU VCNJYDPFIWB;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7802A70", Offset = "0x7801670", VA = "0x187802A70")]
		public TGBUZDPTTNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x780FAF0", Offset = "0x780E6F0", VA = "0x18780FAF0")]
		public static TGBUZDPTTNE Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7812810", Offset = "0x7811410", VA = "0x187812810", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7810610", Offset = "0x780F210", VA = "0x187810610")]
		private unsafe static sbyte GNCIPHOVNCX(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7810F50", Offset = "0x780FB50", VA = "0x187810F50")]
		private unsafe static float2 KPTFBJNKYEP(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7813540", Offset = "0x7812140", VA = "0x187813540")]
		private unsafe static float3 WSMZYBQZIQC(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7810DC0", Offset = "0x780F9C0", VA = "0x187810DC0")]
		private unsafe static float4 JIDINHDHTTD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7810740", Offset = "0x780F340", VA = "0x187810740")]
		private unsafe static float4x4 IDXOKBDTACF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7810610", Offset = "0x780F210", VA = "0x187810610")]
		private unsafe static byte QDRPVZSSVUY(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7810D90", Offset = "0x780F990", VA = "0x187810D90")]
		private unsafe static float2 JEJXNTWTKBI(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7810320", Offset = "0x780EF20", VA = "0x187810320")]
		private unsafe static float3 FNUPAOEDKGT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x780EDF0", Offset = "0x780D9F0", VA = "0x18780EDF0")]
		private unsafe static float4 AJOJDINKFXW(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7810BA0", Offset = "0x780F7A0", VA = "0x187810BA0")]
		private unsafe static float4x4 IZPKCUSFYXG(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7810F80", Offset = "0x780FB80", VA = "0x187810F80")]
		private unsafe static short SDPUIFHEWGN(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7810370", Offset = "0x780EF70", VA = "0x187810370")]
		private unsafe static float2 FVQTHOUYSWF(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7810620", Offset = "0x780F220", VA = "0x187810620")]
		private unsafe static float3 HOFFRZQPYWI(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x780ED90", Offset = "0x780D990", VA = "0x18780ED90")]
		private unsafe static float4 AHZAEHGBWLF(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7810A00", Offset = "0x780F600", VA = "0x187810A00")]
		private unsafe static float4x4 ISZLZBPNWCL(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7810F80", Offset = "0x780FB80", VA = "0x187810F80")]
		private unsafe static ushort KQNZGGCECMI(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7812520", Offset = "0x7811120", VA = "0x187812520")]
		private unsafe static float2 QTYHXCMFFEK(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7812330", Offset = "0x7810F30", VA = "0x187812330")]
		private unsafe static float3 OHZBCAUHEYT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7812380", Offset = "0x7810F80", VA = "0x187812380")]
		private unsafe static float4x4 ONHNOOGSMWU(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7813590", Offset = "0x7812190", VA = "0x187813590")]
		private unsafe static float4 WXJAXJVJDWE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x780FF50", Offset = "0x780EB50", VA = "0x18780FF50")]
		private unsafe static uint EKUUIKEMAER(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7810F80", Offset = "0x780FB80", VA = "0x187810F80")]
		private unsafe static ushort SCMHQKRQDCE(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x78135F0", Offset = "0x78121F0", VA = "0x1878135F0")]
		private unsafe static float YYCSNPZKVQB(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7810300", Offset = "0x780EF00", VA = "0x187810300")]
		private unsafe static float2 EQVACSMFUJT(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7812060", Offset = "0x7810C60", VA = "0x187812060")]
		private unsafe static float3 NIOWQFDXOXC(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x78120B0", Offset = "0x7810CB0", VA = "0x1878120B0")]
		private unsafe static float4 QZNOFKACHDN(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7812550", Offset = "0x7811150", VA = "0x187812550")]
		private unsafe static float4x4 QWZNMOSCOTF(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x78120B0", Offset = "0x7810CB0", VA = "0x1878120B0")]
		private unsafe static float4 NYBMREIWLLU(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7812080", Offset = "0x7810C80", VA = "0x187812080")]
		private unsafe static float4 NYBMREIWLLU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x78100D0", Offset = "0x780ECD0", VA = "0x1878100D0")]
		public static float3[] EMUIVHBIXUH(TGBUZDPTTNE a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7811D50", Offset = "0x7810950", VA = "0x187811D50")]
		public static float3[] MZGZREZKDRV(TGBUZDPTTNE a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7811300", Offset = "0x780FF00", VA = "0x187811300")]
		public static uint[] MDPJOMUVNBM(TGBUZDPTTNE a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7812F00", Offset = "0x7811B00", VA = "0x187812F00")]
		internal static void UFXTHUAXDWX(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x78120E0", Offset = "0x7810CE0", VA = "0x1878120E0")]
		public uint[] OBIFPWDVMMC(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x78103A0", Offset = "0x780EFA0", VA = "0x1878103A0")]
		public float[] FXOIIVQSWPA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7812580", Offset = "0x7811180", VA = "0x187812580")]
		public float2[] RYSCCDCFEQW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7813020", Offset = "0x7811C20", VA = "0x187813020")]
		public float2[] UGMXVXBCXJK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x780F520", Offset = "0x780E120", VA = "0x18780F520")]
		public float3[] BLEOWEVGYMD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x780F7A0", Offset = "0x780E3A0", VA = "0x18780F7A0")]
		public float3[] CFYLXAWRKCX(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x78132D0", Offset = "0x7811ED0", VA = "0x1878132D0")]
		public float4[] WBBQXEOMQRW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7810F90", Offset = "0x780FB90", VA = "0x187810F90")]
		public float4[] LVUDJHYRTDG(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x780F190", Offset = "0x780DD90", VA = "0x18780F190")]
		public float4[] AXYOLSJFXVX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7813600", Offset = "0x7812200", VA = "0x187813600")]
		public float3[] ZUWZFOOKVAI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7812DF0", Offset = "0x78119F0", VA = "0x187812DF0")]
		public float3[] TCUTYDQVFDB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7810670", Offset = "0x780F270", VA = "0x187810670")]
		public float4[] HTWIACBRHAX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7810D40", Offset = "0x780F940", VA = "0x187810D40")]
		public uint[] JAXKJHPFREW(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7811630", Offset = "0x7810230", VA = "0x187811630")]
		public float4x4[] MNCBJURUVMN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x780EE50", Offset = "0x780DA50", VA = "0x18780EE50")]
		private unsafe static float4 ALEHBOSNZJT(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x780F010", Offset = "0x780DC10", VA = "0x18780F010")]
		private unsafe static float4 ALEHBOSNZJT(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7811BE0", Offset = "0x78107E0", VA = "0x187811BE0")]
		private unsafe static float4x4 MXXKAXSCGWK(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7811470", Offset = "0x7810070", VA = "0x187811470")]
		private unsafe static float4 MENYNBTDLHI(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x780FF60", Offset = "0x780EB60", VA = "0x18780FF60")]
		private unsafe static float3 EMNTCWWQDOV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7810E20", Offset = "0x780FA20", VA = "0x187810E20")]
		private unsafe static float2 JTVZUJPARBC(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x78108E0", Offset = "0x780F4E0", VA = "0x1878108E0")]
		private unsafe static uint IRCHAHYNVGV(void* a, uint b, GLTFComponentType c)
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
	public static class KFJCEKBPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x78216A0", Offset = "0x78202A0", VA = "0x1878216A0")]
		public static int XTRHZYSVTAL(this GLTFAccessorAttributeType a)
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
	public class RFFJHZFTXPU : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int YDGZHCXKSNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ZRAGXMRHRDJ ZHIHIFSTFVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public WOLGTEWFJYI KVNILMMTPXB;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7827E10", Offset = "0x7826A10", VA = "0x187827E10")]
		public RFFJHZFTXPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7827A10", Offset = "0x7826610", VA = "0x187827A10")]
		public static RFFJHZFTXPU Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7827CE0", Offset = "0x78268E0", VA = "0x187827CE0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ZRAGXMRHRDJ : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public IDGWKMEFJAX DYIKJDPCYCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int ZZFTKMTXJHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType ZLXFIPLBFPG;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x78309A0", Offset = "0x782F5A0", VA = "0x1878309A0")]
		public ZRAGXMRHRDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7830580", Offset = "0x782F180", VA = "0x187830580")]
		public static ZRAGXMRHRDJ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7830860", Offset = "0x782F460", VA = "0x187830860", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class WOLGTEWFJYI : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IDGWKMEFJAX DYIKJDPCYCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int ZZFTKMTXJHS;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x782E1F0", Offset = "0x782CDF0", VA = "0x18782E1F0")]
		public WOLGTEWFJYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x782DE70", Offset = "0x782CA70", VA = "0x18782DE70")]
		public static WOLGTEWFJYI Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x782E0F0", Offset = "0x782CCF0", VA = "0x18782E0F0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RPCROPECMHG : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public QYLRFQWWBAW GXZJLMSENZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GEOZCVBEFLD MNOZMKLYXSY;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7828720", Offset = "0x7827320", VA = "0x187828720")]
		public RPCROPECMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7828430", Offset = "0x7827030", VA = "0x187828430")]
		public static RPCROPECMHG Deserialize(WHQEVNUVYVG root, JsonReader reader, FTODWFQFFCG anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7828620", Offset = "0x7827220", VA = "0x187828620", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class GEOZCVBEFLD : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public RKPACBPTHBK OINYKCZIBWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string IGGDTQFVHLU;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x781DDE0", Offset = "0x781C9E0", VA = "0x18781DDE0")]
		public static GEOZCVBEFLD Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x781E160", Offset = "0x781CD60", VA = "0x18781E160")]
		public GEOZCVBEFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x781E040", Offset = "0x781CC40", VA = "0x18781E040", Slot = "4")]
		public override void Serialize(JsonWriter writer)
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
	public class AESYTCTTCPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(AESYTCTTCPM data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] NOAWDVJEIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type NCFCUITBSTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] REBFCYWQETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion ZXHBXCKXVZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string IKBWFYNRHRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string PCMNBWEUUYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public RQPKSVVWTGU FHNISAUXBOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string JCWEDJSVPQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string OHEBRKKIWLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public RQPKSVVWTGU AJGBWKYUKCV;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x781AAC0", Offset = "0x78196C0", VA = "0x18781AAC0")]
		public AESYTCTTCPM()
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
	public class ZEZRWBUPSIX : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public LLWPAQBYPVZ WRZXXCHWOZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType AVAEYREDAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LLWPAQBYPVZ GFSJBHQUMFC;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7830530", Offset = "0x782F130", VA = "0x187830530")]
		public ZEZRWBUPSIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78301A0", Offset = "0x782EDA0", VA = "0x1878301A0")]
		public static ZEZRWBUPSIX Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x78303C0", Offset = "0x782EFC0", VA = "0x1878303C0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CLQCHGIGTMX : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string PPRPRJMCLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string SKVPXCFSXNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string MDWPLBPDAJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string CWPINFBKFKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> TPUKAVRSAIR;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x781BBB0", Offset = "0x781A7B0", VA = "0x18781BBB0")]
		public CLQCHGIGTMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x781B460", Offset = "0x781A060", VA = "0x18781B460")]
		public static CLQCHGIGTMX Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x781B780", Offset = "0x781A380", VA = "0x18781B780", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x781BBA0", Offset = "0x781A7A0", VA = "0x18781BBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x781B0C0", Offset = "0x7819CC0", VA = "0x18781B0C0")]
		public string CCEXGIURFJP(bool a)
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
	public class DYIKJDPCYCK : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public HPBDZEEYLXE HRSTSLJNLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint ZZFTKMTXJHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint PXBRLYOQNBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint EIOPBAKNNZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget MNOZMKLYXSY;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public DYIKJDPCYCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x781C190", Offset = "0x781AD90", VA = "0x18781C190")]
		public static DYIKJDPCYCK Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x781C440", Offset = "0x781B040", VA = "0x18781C440", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class EDZZZWLUAPO : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double XNLTAKJMTFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double ZKWMIXFWTBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double FJLIHWMTGCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double UFFOTGCZSAH;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x781CB90", Offset = "0x781B790", VA = "0x18781CB90")]
		public EDZZZWLUAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x781C6A0", Offset = "0x781B2A0", VA = "0x18781C6A0")]
		public static EDZZZWLUAPO Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x781CA20", Offset = "0x781B620", VA = "0x18781CA20", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class AHJJJLEXRDS : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double VWUUEMESPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double RMMZJOPYMXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double FJLIHWMTGCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double UFFOTGCZSAH;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x781B060", Offset = "0x7819C60", VA = "0x18781B060")]
		public AHJJJLEXRDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x781AB60", Offset = "0x7819760", VA = "0x18781AB60")]
		public static AHJJJLEXRDS Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x781AED0", Offset = "0x7819AD0", VA = "0x18781AED0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class FTODWFQFFCG : FRLCSFKBVSK
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public WHQEVNUVYVG PPGZRRIGXVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader IBUFBOVYLGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public FTODWFQFFCG OHXFAILEMMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<RPCROPECMHG> VNPNSVZAKTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<ZEZRWBUPSIX> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x78220A0", Offset = "0x7820CA0", VA = "0x1878220A0")]
			internal RPCROPECMHG WFWLZXPKODO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x78220C0", Offset = "0x7820CC0", VA = "0x1878220C0")]
			internal ZEZRWBUPSIX WGBSXEJHXOX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<RPCROPECMHG> AFTAEPGFWIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<ZEZRWBUPSIX> APNAQYUVFFG;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x781D590", Offset = "0x781C190", VA = "0x18781D590")]
		public static FTODWFQFFCG Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x781DCF0", Offset = "0x781C8F0", VA = "0x18781DCF0")]
		public FTODWFQFFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x781D950", Offset = "0x781C550", VA = "0x18781D950", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class RUJEEZGUVNM : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string UXOMQGFCCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint PXBRLYOQNBR;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public RUJEEZGUVNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7828770", Offset = "0x7827370", VA = "0x187828770")]
		public static RUJEEZGUVNM Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7828940", Offset = "0x7827540", VA = "0x187828940", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class FBLVUTMUVXN : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public EDZZZWLUAPO LLJEKLOORST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AHJJJLEXRDS BVGOZLJWXWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType JGVJNZJVVLT;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public FBLVUTMUVXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x781CBE0", Offset = "0x781B7E0", VA = "0x18781CBE0")]
		public static FBLVUTMUVXN Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x781CDB0", Offset = "0x781B9B0", VA = "0x18781CDB0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
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
	public class FRLCSFKBVSK : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string QMZMPPIFWAW;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public FRLCSFKBVSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x781D100", Offset = "0x781BD00", VA = "0x18781D100")]
		public FRLCSFKBVSK(FRLCSFKBVSK a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x781CF80", Offset = "0x781BB80", VA = "0x18781CF80")]
		public new void BPAHVTBJSIE(WHQEVNUVYVG a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x781D070", Offset = "0x781BC70", VA = "0x18781D070", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class KKTKXGNETQO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int AXUVQJAOTPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public WHQEVNUVYVG DXAPXCCARDD;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected KKTKXGNETQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x58CB510", Offset = "0x58CA110", VA = "0x1858CB510")]
		public KKTKXGNETQO(KKTKXGNETQO<a> a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x58CB4E0", Offset = "0x58CA0E0", VA = "0x1858CB4E0")]
		public void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LLWPAQBYPVZ : KKTKXGNETQO<TGBUZDPTTNE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override TGBUZDPTTNE Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x78223D0", Offset = "0x7820FD0", VA = "0x1878223D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7822330", Offset = "0x7820F30", VA = "0x187822330")]
		public LLWPAQBYPVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7822370", Offset = "0x7820F70", VA = "0x187822370")]
		public LLWPAQBYPVZ(LLWPAQBYPVZ a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7822250", Offset = "0x7820E50", VA = "0x187822250")]
		public static LLWPAQBYPVZ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class HPBDZEEYLXE : KKTKXGNETQO<RUJEEZGUVNM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override RUJEEZGUVNM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x781E8B0", Offset = "0x781D4B0", VA = "0x18781E8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x781E870", Offset = "0x781D470", VA = "0x18781E870")]
		public HPBDZEEYLXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x781E790", Offset = "0x781D390", VA = "0x18781E790")]
		public static HPBDZEEYLXE Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class IDGWKMEFJAX : KKTKXGNETQO<DYIKJDPCYCK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override DYIKJDPCYCK Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x781EA40", Offset = "0x781D640", VA = "0x18781EA40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x781EA00", Offset = "0x781D600", VA = "0x18781EA00")]
		public IDGWKMEFJAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x781E920", Offset = "0x781D520", VA = "0x18781E920")]
		public static IDGWKMEFJAX Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class RBHZLEUVAXF : KKTKXGNETQO<FBLVUTMUVXN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override FBLVUTMUVXN Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x78279B0", Offset = "0x78265B0", VA = "0x1878279B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7827970", Offset = "0x7826570", VA = "0x187827970")]
		public RBHZLEUVAXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7827890", Offset = "0x7826490", VA = "0x187827890")]
		public static RBHZLEUVAXF Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MAFVURACFRJ : KKTKXGNETQO<PETSCINNNKV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override PETSCINNNKV Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7824080", Offset = "0x7822C80", VA = "0x187824080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7824040", Offset = "0x7822C40", VA = "0x187824040")]
		public MAFVURACFRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7823F60", Offset = "0x7822B60", VA = "0x187823F60")]
		public static MAFVURACFRJ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class RMOJMZHRAPP : KKTKXGNETQO<LVNNDEQXMVX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override LVNNDEQXMVX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x78283D0", Offset = "0x7826FD0", VA = "0x1878283D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7828390", Offset = "0x7826F90", VA = "0x187828390")]
		public RMOJMZHRAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7828330", Offset = "0x7826F30", VA = "0x187828330")]
		public RMOJMZHRAPP(RMOJMZHRAPP a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7828250", Offset = "0x7826E50", VA = "0x187828250")]
		public static RMOJMZHRAPP Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class VROWLOQXPPH : KKTKXGNETQO<UZMMOAOELWF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override UZMMOAOELWF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x782B320", Offset = "0x7829F20", VA = "0x18782B320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x782B2E0", Offset = "0x7829EE0", VA = "0x18782B2E0")]
		public VROWLOQXPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x782B200", Offset = "0x7829E00", VA = "0x18782B200")]
		public static VROWLOQXPPH Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class RKPACBPTHBK : KKTKXGNETQO<OINYKCZIBWN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override OINYKCZIBWN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x78281F0", Offset = "0x7826DF0", VA = "0x1878281F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x78281B0", Offset = "0x7826DB0", VA = "0x1878281B0")]
		public RKPACBPTHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7827E60", Offset = "0x7826A60", VA = "0x187827E60")]
		public static RKPACBPTHBK Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7827F40", Offset = "0x7826B40", VA = "0x187827F40")]
		public static List<RKPACBPTHBK> MMTJRICHTMV(WHQEVNUVYVG a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class MCGXOLVXXBU : KKTKXGNETQO<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7824200", Offset = "0x7822E00", VA = "0x187824200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x78241C0", Offset = "0x7822DC0", VA = "0x1878241C0")]
		public MCGXOLVXXBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x78240E0", Offset = "0x7822CE0", VA = "0x1878240E0")]
		public static MCGXOLVXXBU Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class QYLRFQWWBAW : KKTKXGNETQO<ZEZRWBUPSIX>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public FTODWFQFFCG FTODWFQFFCG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override ZEZRWBUPSIX Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7827830", Offset = "0x7826430", VA = "0x187827830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x78277F0", Offset = "0x78263F0", VA = "0x1878277F0")]
		public QYLRFQWWBAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x78276F0", Offset = "0x78262F0", VA = "0x1878276F0")]
		public static QYLRFQWWBAW Deserialize(WHQEVNUVYVG root, FTODWFQFFCG anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class MYQNFZEXTWO : KKTKXGNETQO<QLUJKLJJEKU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override QLUJKLJJEKU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7824380", Offset = "0x7822F80", VA = "0x187824380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7824340", Offset = "0x7822F40", VA = "0x187824340")]
		public MYQNFZEXTWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7824260", Offset = "0x7822E60", VA = "0x187824260")]
		public static MYQNFZEXTWO Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LJNNKVMTFGN : KKTKXGNETQO<LACOLFOEOKM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override LACOLFOEOKM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x78221F0", Offset = "0x7820DF0", VA = "0x1878221F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x78221B0", Offset = "0x7820DB0", VA = "0x1878221B0")]
		public LJNNKVMTFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x78220D0", Offset = "0x7820CD0", VA = "0x1878220D0")]
		public static LJNNKVMTFGN Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class HARKLWTTYIR : KKTKXGNETQO<JJRTKEYQYZJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override JJRTKEYQYZJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x781E680", Offset = "0x781D280", VA = "0x18781E680", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x781E5E0", Offset = "0x781D1E0", VA = "0x18781E5E0")]
		public HARKLWTTYIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x781E620", Offset = "0x781D220", VA = "0x18781E620")]
		public HARKLWTTYIR(HARKLWTTYIR a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x781E500", Offset = "0x781D100", VA = "0x18781E500")]
		public static HARKLWTTYIR Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class SGKHWIMGWLM : KKTKXGNETQO<KGOXBTCKMVK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KGOXBTCKMVK Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7828AD0", Offset = "0x78276D0", VA = "0x187828AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7828A90", Offset = "0x7827690", VA = "0x187828A90")]
		public SGKHWIMGWLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class PETSCINNNKV : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string UXOMQGFCCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string WYUXADJTHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IDGWKMEFJAX DYIKJDPCYCK;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public PETSCINNNKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7825FA0", Offset = "0x7824BA0", VA = "0x187825FA0")]
		public static PETSCINNNKV Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x78261E0", Offset = "0x7824DE0", VA = "0x1878261E0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class LVNNDEQXMVX : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LXJOSMITJUQ LXJOSMITJUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public UQRQXUBLZHP TNTQNARWNRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public FSIJTAKIVHL IKERDJMMNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TPHWGEUDPEJ GCMJKQSITQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public TSHBWHIVAEI WXVGFIOSLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color ENPUYUBHVSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode KSQGOXACBBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double OGQTJHJIFUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool VACMAFSYLNX;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7822DA0", Offset = "0x78219A0", VA = "0x187822DA0")]
		public LVNNDEQXMVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7822430", Offset = "0x7821030", VA = "0x187822430")]
		public static LVNNDEQXMVX Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7822940", Offset = "0x7821540", VA = "0x187822940", Slot = "4")]
		public override void Serialize(JsonWriter writer)
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
	public class UZMMOAOELWF : FRLCSFKBVSK
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public WHQEVNUVYVG PPGZRRIGXVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader IBUFBOVYLGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<XDBFAYSIXYJ> VNPNSVZAKTC;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x78272F0", Offset = "0x7825EF0", VA = "0x1878272F0")]
			internal XDBFAYSIXYJ WFWLZXPKODO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<XDBFAYSIXYJ> TRNLLSTDZOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> NMRFLPYFMPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> OLLFXORHLKA;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public UZMMOAOELWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x782A890", Offset = "0x7829490", VA = "0x18782A890")]
		public static UZMMOAOELWF Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x782AC50", Offset = "0x7829850", VA = "0x18782AC50", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class JSSHJYTNBTX
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, NMIBRMSMCIU> RHBYVZTCNEE;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static YNQTAKHXBAH YYOFOPDYUDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, FNHEMEFBNEF> OSZUHFNLQDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken RJNOMYVTWXI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7820400", Offset = "0x781F000", VA = "0x187820400")]
		public static NMIBRMSMCIU MTSQKIKLYZZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x78209D0", Offset = "0x781F5D0", VA = "0x1878209D0")]
		public static FNHEMEFBNEF YMGIGCEIUSL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JSSHJYTNBTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x78213B0", Offset = "0x781FFB0", VA = "0x1878213B0")]
		public JSSHJYTNBTX(JSSHJYTNBTX a, [Optional] WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x781F930", Offset = "0x781E530", VA = "0x18781F930")]
		public void BPAHVTBJSIE(WHQEVNUVYVG a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x781FBE0", Offset = "0x781E7E0", VA = "0x18781FBE0")]
		public void BXBDLKQFEPL(string a, FNHEMEFBNEF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7820310", Offset = "0x781EF10", VA = "0x187820310")]
		private void KNNQDSHUUBB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7820AC0", Offset = "0x781F6C0", VA = "0x187820AC0")]
		private void YTADNMYLIBX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7820590", Offset = "0x781F190", VA = "0x187820590")]
		private void QSXCOPSUSED(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x781FD30", Offset = "0x781E930", VA = "0x18781FD30")]
		internal static Dictionary<string, FNHEMEFBNEF> FPJULQMHOHU(WHQEVNUVYVG a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7820650", Offset = "0x781F250", VA = "0x187820650", Slot = "4")]
		public virtual void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WHQEVNUVYVG : JSSHJYTNBTX
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class TZPDHATRBYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public WHQEVNUVYVG PPGZRRIGXVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader IWQOGUOXKDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<TGBUZDPTTNE> VNPNSVZAKTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<FTODWFQFFCG> VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<RUJEEZGUVNM> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<DYIKJDPCYCK> VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<FBLVUTMUVXN> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<PETSCINNNKV> VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<LVNNDEQXMVX> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<UZMMOAOELWF> VPAJZRIHYUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<OINYKCZIBWN> VLZKOTVVNGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> VMERMAPSWRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<QLUJKLJJEKU> BUNEJPNTJYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<LACOLFOEOKM> BUHXMITWANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<JJRTKEYQYZJ> BUCQPBZYRCD;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TZPDHATRBYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7829B00", Offset = "0x7828700", VA = "0x187829B00")]
			internal TGBUZDPTTNE WFWLZXPKODO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7829B10", Offset = "0x7828710", VA = "0x187829B10")]
			internal FTODWFQFFCG WGBSXEJHXOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7829B20", Offset = "0x7828720", VA = "0x187829B20")]
			internal RUJEEZGUVNM WGGZULDFHAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7829B30", Offset = "0x7828730", VA = "0x187829B30")]
			internal DYIKJDPCYCK WGMGRRXCQLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7829AC0", Offset = "0x78286C0", VA = "0x187829AC0")]
			internal FBLVUTMUVXN WFBKKWNVCKE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7829AD0", Offset = "0x78286D0", VA = "0x187829AD0")]
			internal PETSCINNNKV WFGRIDHSLVN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7829AE0", Offset = "0x78286E0", VA = "0x187829AE0")]
			internal LVNNDEQXMVX WFLYFKBPVGW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7829AF0", Offset = "0x78286F0", VA = "0x187829AF0")]
			internal UZMMOAOELWF WFRFCQVNESF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7829AA0", Offset = "0x78286A0", VA = "0x187829AA0")]
			internal OINYKCZIBWN WEGIVVMFQQU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7829AB0", Offset = "0x78286B0", VA = "0x187829AB0")]
			internal Sampler WELPTCGDACD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7829920", Offset = "0x7828520", VA = "0x187829920")]
			internal QLUJKLJJEKU IOOUTSDIBOV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7829910", Offset = "0x7828510", VA = "0x187829910")]
			internal LACOLFOEOKM IOJNWLJKSDM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7829900", Offset = "0x7828500", VA = "0x187829900")]
			internal JJRTKEYQYZJ IOEGZEPNISD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> JOMCUROEGWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> UZNENNLXMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<TGBUZDPTTNE> VZLDDYEFARZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<FTODWFQFFCG> PCMDDSWHQMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CLQCHGIGTMX CLQCHGIGTMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<RUJEEZGUVNM> CHWUEQNNXNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<DYIKJDPCYCK> HBPARBLTAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<FBLVUTMUVXN> SGJRNXATTPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<PETSCINNNKV> UDTSCTNAIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<LVNNDEQXMVX> WHVUTMFVCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<UZMMOAOELWF> OBYQQKRNBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<OINYKCZIBWN> ZEWWYYSKYRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> APNAQYUVFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MYQNFZEXTWO JXHYXMJZFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<QLUJKLJJEKU> OMIRVELGBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<LACOLFOEOKM> AMKFZPPRBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<JJRTKEYQYZJ> VMTSEWKNYBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<KGOXBTCKMVK> TRMMERWDWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool HQBCFGOVOEM;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x782DE20", Offset = "0x782CA20", VA = "0x18782DE20")]
		public WHQEVNUVYVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x782C1D0", Offset = "0x782ADD0", VA = "0x18782C1D0")]
		public QLUJKLJJEKU LAVRUITIJOY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x782B380", Offset = "0x7829F80", VA = "0x18782B380")]
		public static WHQEVNUVYVG Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x782C270", Offset = "0x782AE70", VA = "0x18782C270")]
		public void Serialize(TextWriter textWriter, bool isGLB = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class QLUJKLJJEKU : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<RKPACBPTHBK> ZEWWYYSKYRA;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public QLUJKLJJEKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7827300", Offset = "0x7825F00", VA = "0x187827300")]
		public static QLUJKLJJEKU Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7827480", Offset = "0x7826080", VA = "0x187827480", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class JJRTKEYQYZJ : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public MCGXOLVXXBU GXZJLMSENZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public MAFVURACFRJ JKJORIMASLC;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public JJRTKEYQYZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x781ECE0", Offset = "0x781D8E0", VA = "0x18781ECE0")]
		public static JJRTKEYQYZJ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x781EEB0", Offset = "0x781DAB0", VA = "0x18781EEB0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ICPUJEJTPKY : KGOXBTCKMVK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public ICPUJEJTPKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x781E910", Offset = "0x781D510", VA = "0x18781E910", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class KGOXBTCKMVK : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CFFWKEOMCTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string XWCGKVRHPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float QSGWHVQKLTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float EWQRPURMFHI;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public KGOXBTCKMVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7821700", Offset = "0x7820300", VA = "0x187821700", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class QLAJEFTCYJI : KGOXBTCKMVK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x781C650", Offset = "0x781B250", VA = "0x18781C650")]
		public QLAJEFTCYJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x781E910", Offset = "0x781D510", VA = "0x18781E910", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class GURGADHOGIM : KGOXBTCKMVK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float TVYIKWDAELV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float WKGIMKAVTBY;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x781E4B0", Offset = "0x781D0B0", VA = "0x18781E4B0")]
		public GURGADHOGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x781E1B0", Offset = "0x781CDB0", VA = "0x18781E1B0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface MWDIAHROPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MORTAZNXTXK(WHQEVNUVYVG a, KOBLWLFFCYZ b, [Out] AESYTCTTCPM c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface FNHEMEFBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FNHEMEFBNEF Clone(WHQEVNUVYVG root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class NMIBRMSMCIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string PZCGZHONEVX;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected NMIBRMSMCIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class HHVKMTKNCBN : FNHEMEFBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty JFLHEWGNVDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x781E6E0", Offset = "0x781D2E0", VA = "0x18781E6E0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public HHVKMTKNCBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class YNQTAKHXBAH : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7830130", Offset = "0x782ED30", VA = "0x187830130", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public YNQTAKHXBAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class UQRQXUBLZHP : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color TYQCJVZRXDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TSHBWHIVAEI GGQHAGMMZRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color QVSBBGFEMUI;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x782A820", Offset = "0x7829420", VA = "0x18782A820")]
		public UQRQXUBLZHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x782A320", Offset = "0x7828F20", VA = "0x18782A320")]
		public static UQRQXUBLZHP Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x782A5C0", Offset = "0x78291C0", VA = "0x18782A5C0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class FSIJTAKIVHL : TSHBWHIVAEI
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string KKNZMALLFWJ = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double FNVHMWLXVDX;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x781D530", Offset = "0x781C130", VA = "0x18781D530")]
		public FSIJTAKIVHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x781D180", Offset = "0x781BD80", VA = "0x18781D180")]
		public new static FSIJTAKIVHL Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x781D470", Offset = "0x781C070", VA = "0x18781D470", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class TPHWGEUDPEJ : TSHBWHIVAEI
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string ACQTLDZOCII = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double IFQWPYOHPHW;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x781D530", Offset = "0x781C130", VA = "0x18781D530")]
		public TPHWGEUDPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7829060", Offset = "0x7827C60", VA = "0x187829060")]
		public new static TPHWGEUDPEJ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7829350", Offset = "0x7827F50", VA = "0x187829350", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class LXJOSMITJUQ : JSSHJYTNBTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color FTRDODLOILS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public TSHBWHIVAEI FPMLYZTQPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double DKATWAIPQJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double XRGSUJZKBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public TSHBWHIVAEI VSOOVQNOSDX;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7823EF0", Offset = "0x7822AF0", VA = "0x187823EF0")]
		public LXJOSMITJUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x78238F0", Offset = "0x78224F0", VA = "0x1878238F0")]
		public static LXJOSMITJUQ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7823C60", Offset = "0x7822860", VA = "0x187823C60", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class XDBFAYSIXYJ : JSSHJYTNBTX
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader IBUFBOVYLGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public WHQEVNUVYVG PPGZRRIGXVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<LLWPAQBYPVZ> VNPNSVZAKTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<LLWPAQBYPVZ> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, LLWPAQBYPVZ>> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x782FC70", Offset = "0x782E870", VA = "0x18782FC70")]
			internal LLWPAQBYPVZ WFWLZXPKODO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x782FD40", Offset = "0x782E940", VA = "0x18782FD40")]
			internal Dictionary<string, LLWPAQBYPVZ> WGBSXEJHXOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x782FDF0", Offset = "0x782E9F0", VA = "0x18782FDF0")]
			internal LLWPAQBYPVZ WGGZULDFHAG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, LLWPAQBYPVZ> BBAMPPVWARK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public LLWPAQBYPVZ ZHIHIFSTFVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public RMOJMZHRAPP LANAIIHWVIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode ZPLJYBKEGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, LLWPAQBYPVZ>> VBCNAZABJAF;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x782F530", Offset = "0x782E130", VA = "0x18782F530")]
		public XDBFAYSIXYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x782F5D0", Offset = "0x782E1D0", VA = "0x18782F5D0")]
		public XDBFAYSIXYJ(XDBFAYSIXYJ a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x782EA80", Offset = "0x782D680", VA = "0x18782EA80")]
		public static int[] JESKVLRNPKD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x782F110", Offset = "0x782DD10", VA = "0x18782F110")]
		public static int[] UCGWBVKSMZL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x782F270", Offset = "0x782DE70", VA = "0x18782F270")]
		public static int[] UIUIGCJQNQD(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x782E2B0", Offset = "0x782CEB0", VA = "0x18782E2B0")]
		public static int[] DLESKGVHMZL(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x782E9D0", Offset = "0x782D5D0", VA = "0x18782E9D0")]
		public static int[] GOYSUBYGKHC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x782F4C0", Offset = "0x782E0C0", VA = "0x18782F4C0")]
		public static int[] ZIAAATNGIIV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x782E4F0", Offset = "0x782D0F0", VA = "0x18782E4F0")]
		public static int[] DMWRZHKJTGJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x782E240", Offset = "0x782CE40", VA = "0x18782E240")]
		public static int[] CXZDNKUCYXQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x782F430", Offset = "0x782E030", VA = "0x18782F430")]
		public static int[] XZATWAAXFSO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x782E580", Offset = "0x782D180", VA = "0x18782E580")]
		public static XDBFAYSIXYJ Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x782EB20", Offset = "0x782D720", VA = "0x18782EB20", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class TZZFWVCOWUI
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] EUEHQOZUJTB;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] JJFMUAEDKSU;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] GVQFNHJTMKN;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] AARJHYAKREL;
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
	public class OINYKCZIBWN : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool BLGDNUVCGSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public RBHZLEUVAXF XLMGPXNZESC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<RKPACBPTHBK> GWCWITBPEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LJNNKVMTFGN LACOLFOEOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public FWBEJGDGJCE USRMNAAPPQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public VROWLOQXPPH TZGQPRMHTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion VKXVPHMWDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 FNVHMWLXVDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 MYAODMCJHXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> NMRFLPYFMPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public SGKHWIMGWLM RRCMGGTYVET;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7825E60", Offset = "0x7824A60", VA = "0x187825E60")]
		public OINYKCZIBWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7824920", Offset = "0x7823520", VA = "0x187824920")]
		public static OINYKCZIBWN Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7825260", Offset = "0x7823E60", VA = "0x187825260", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode YFSIQENIJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode NXBSGMULMSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode PAATXPYNEUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode OZALLIDAJPZ;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7828FF0", Offset = "0x7827BF0", VA = "0x187828FF0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7828B30", Offset = "0x7827730", VA = "0x187828B30")]
		public static Sampler Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7828E00", Offset = "0x7827A00", VA = "0x187828E00", Slot = "4")]
		public override void Serialize(JsonWriter writer)
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
	public class LACOLFOEOKM : FRLCSFKBVSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public LLWPAQBYPVZ QPOKKGKEIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public RKPACBPTHBK YRHVDYOWENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<RKPACBPTHBK> KDPMEACQDBW;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7821FF0", Offset = "0x7820BF0", VA = "0x187821FF0")]
		public LACOLFOEOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7821980", Offset = "0x7820580", VA = "0x187821980")]
		public static LACOLFOEOKM Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7821CE0", Offset = "0x78208E0", VA = "0x187821CE0", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class TSHBWHIVAEI : JSSHJYTNBTX
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string OFFRXKWKALN = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string OXGYNCDTPDR = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public HARKLWTTYIR TBYJWOVXLDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int EUEHQOZUJTB;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x78298B0", Offset = "0x78284B0", VA = "0x1878298B0")]
		public TSHBWHIVAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x78297C0", Offset = "0x78283C0", VA = "0x1878297C0")]
		public TSHBWHIVAEI(TSHBWHIVAEI a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x78294E0", Offset = "0x78280E0", VA = "0x1878294E0")]
		public static TSHBWHIVAEI Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7829760", Offset = "0x7828360", VA = "0x187829760", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7829410", Offset = "0x7828010", VA = "0x187829410")]
		public void BWUYNUTYRVC(JsonWriter a)
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
	public class CXJOFDIBJAB
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double IRZPEDCKUAV;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double NINHZLSTJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double GXQHQZPCENR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double CXMZPIBZRSW;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x781C110", Offset = "0x781AD10", VA = "0x18781C110")]
		public CXJOFDIBJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x781BC50", Offset = "0x781A850", VA = "0x18781BC50")]
		public static CXJOFDIBJAB Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x781BEA0", Offset = "0x781AAA0", VA = "0x18781BEA0")]
		public void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class LVXZJMOAOFL : FRLCSFKBVSK
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color FKOMICETFMK;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double NPVQLFNSBJC;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double RKZDXHQATWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType JGVJNZJVVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color JJFMUAEDKSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double UDGYZWTDHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double PPCVZXYQGWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CXJOFDIBJAB CXJOFDIBJAB;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7823700", Offset = "0x7822300", VA = "0x187823700")]
		public LVXZJMOAOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x78237C0", Offset = "0x78223C0", VA = "0x1878237C0")]
		public LVXZJMOAOFL(LVXZJMOAOFL a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7822E10", Offset = "0x7821A10", VA = "0x187822E10")]
		public static LVXZJMOAOFL Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7823200", Offset = "0x7821E00", VA = "0x187823200")]
		public static LVXZJMOAOFL Deserialize(WHQEVNUVYVG root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7823320", Offset = "0x7821F20", VA = "0x187823320", Slot = "4")]
		public override void Serialize(JsonWriter writer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class JMYTWGIIQQT : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<KGOXBTCKMVK> VJWZWCSVACI;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public JMYTWGIIQQT(IList<KGOXBTCKMVK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x781F090", Offset = "0x781DC90", VA = "0x18781F090", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x781F020", Offset = "0x781DC20", VA = "0x18781F020", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class PNVJFWVMLFB : FNHEMEFBNEF, MWDIAHROPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<LVXZJMOAOFL> TRMMERWDWEM;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7827270", Offset = "0x7825E70", VA = "0x187827270")]
		public PNVJFWVMLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7826660", Offset = "0x7825260", VA = "0x187826660", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7827180", Offset = "0x7825D80", VA = "0x187827180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x78263B0", Offset = "0x7824FB0", VA = "0x1878263B0")]
		private static string[] AZWGBWKTCHR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x78268F0", Offset = "0x78254F0", VA = "0x1878268F0")]
		private static AESYTCTTCPM.ImportValuesConversion LIGGGSZUVAD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7826D90", Offset = "0x7825990", VA = "0x187826D90", Slot = "6")]
		public bool MORTAZNXTXK(WHQEVNUVYVG a, KOBLWLFFCYZ b, [Out] AESYTCTTCPM c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class XPVXOMKWQWU : KKTKXGNETQO<LVXZJMOAOFL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override LVXZJMOAOFL Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x782FFE0", Offset = "0x782EBE0", VA = "0x18782FFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x782FFA0", Offset = "0x782EBA0", VA = "0x18782FFA0")]
		public XPVXOMKWQWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x782FEC0", Offset = "0x782EAC0", VA = "0x18782FEC0")]
		public static XPVXOMKWQWU Deserialize(WHQEVNUVYVG root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class IUDJPXFTPWT : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public XPVXOMKWQWU SGKHWIMGWLM;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public IUDJPXFTPWT(XPVXOMKWQWU a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x781EC20", Offset = "0x781D820", VA = "0x18781EC20")]
		public IUDJPXFTPWT(int a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x781EAA0", Offset = "0x781D6A0", VA = "0x18781EAA0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x781EB20", Offset = "0x781D720", VA = "0x18781EB20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class NOJCTUYRVYG : NMIBRMSMCIU
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x78248D0", Offset = "0x78234D0", VA = "0x1878248D0")]
		public NOJCTUYRVYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x78243E0", Offset = "0x7822FE0", VA = "0x1878243E0", Slot = "4")]
		public override FNHEMEFBNEF Deserialize(WHQEVNUVYVG root, JProperty extensionToken)
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
