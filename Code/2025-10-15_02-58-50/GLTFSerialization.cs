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
	public class KHR_animation_pointer : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object PRSOAKFKUSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string XSVALUUVDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string HMCJLWVXEBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public EYAOZSPNWCD FPGXDCFFFOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer WPYBEXGYPBS;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x727A340", Offset = "0x7279140", VA = "0x18727A340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x727A290", Offset = "0x7279090", VA = "0x18727A290", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ALYEZXZUSAS
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 ZITCMEMMXXD;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 MYOEOJIGARW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion VRQMCCDZDJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool SVXQTCVUWEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x726FB10", Offset = "0x726E910", VA = "0x18726FB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x726F2C0", Offset = "0x726E0C0", VA = "0x18726F2C0")]
		public static void QIRXNUSVXPS(this ITZFJUYYDSP a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x726DAD0", Offset = "0x726C8D0", VA = "0x18726DAD0")]
		public static void CNIFORHSSXU(this ITZFJUYYDSP a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x726ED50", Offset = "0x726DB50", VA = "0x18726ED50")]
		public static void MHTMGNYSAQJ(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x726E870", Offset = "0x726D670", VA = "0x18726E870")]
		public static GLTF.Math.Vector4 LPLUAOMNWJJ(this UTLIDXBRNWW a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x726EA90", Offset = "0x726D890", VA = "0x18726EA90")]
		public static UnityEngine.Quaternion LZNWTDJXBMG(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x726EC20", Offset = "0x726DA20", VA = "0x18726EC20")]
		public static UnityEngine.Quaternion LZNWTDJXBMG(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x726E730", Offset = "0x726D530", VA = "0x18726E730")]
		public static GLTF.Math.Quaternion KUSARPWHAUG(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7270610", Offset = "0x726F410", VA = "0x187270610")]
		public static Matrix4x4 XXEJFELWIHX(this UTLIDXBRNWW a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72701D0", Offset = "0x726EFD0", VA = "0x1872701D0")]
		public static Matrix4x4 XXEJFELWIHX(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x726E080", Offset = "0x726CE80", VA = "0x18726E080")]
		public static UTLIDXBRNWW GFRBIPMOYBX(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x726D730", Offset = "0x726C530", VA = "0x18726D730")]
		public static UnityEngine.Vector3 AFNDBKZWZAM(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x726D650", Offset = "0x726C450", VA = "0x18726D650")]
		public static UnityEngine.Vector3 AFNDBKZWZAM(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7270DA0", Offset = "0x726FBA0", VA = "0x187270DA0")]
		public static GLTF.Math.Vector3 ZELOQOSEIMM(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7270830", Offset = "0x726F630", VA = "0x187270830")]
		public static GLTF.Math.Vector3 YHTTMOWEMWB(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		public static GLTF.Math.Vector4 GBVEJQVAITM(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7270870", Offset = "0x726F670", VA = "0x187270870")]
		public static Matrix4x4 YWQADWWSIUA(this UTLIDXBRNWW a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7270B30", Offset = "0x726F930", VA = "0x187270B30")]
		public static Matrix4x4 YWQADWWSIUA(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x726E560", Offset = "0x726D360", VA = "0x18726E560")]
		public static UTLIDXBRNWW KNXHLUOOMJC(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x726F1F0", Offset = "0x726DFF0", VA = "0x18726F1F0")]
		public static UnityEngine.Vector2 MSWMZLHZXDC(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x726F1F0", Offset = "0x726DFF0", VA = "0x18726F1F0")]
		public static UnityEngine.Vector2 MSWMZLHZXDC(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x726F120", Offset = "0x726DF20", VA = "0x18726F120")]
		public static void MSWMZLHZXDC(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x726FAB0", Offset = "0x726E8B0", VA = "0x18726FAB0")]
		public static UnityEngine.Vector3 RHLTQHYCJWZ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D814A0", Offset = "0x1D802A0", VA = "0x181D814A0")]
		public static UnityEngine.Vector3 RHLTQHYCJWZ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x726F9C0", Offset = "0x726E7C0", VA = "0x18726F9C0")]
		public static void RHLTQHYCJWZ(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		public static UnityEngine.Vector4 XVBWSLGTOBU(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		public static UnityEngine.Vector4 XVBWSLGTOBU(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x726FFC0", Offset = "0x726EDC0", VA = "0x18726FFC0")]
		public static UnityEngine.Vector4[] XVBWSLGTOBU(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72700C0", Offset = "0x726EEC0", VA = "0x1872700C0")]
		public static void XVBWSLGTOBU(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x726FC20", Offset = "0x726EA20", VA = "0x18726FC20")]
		public static UnityEngine.Color TUUIHNWIHUU(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x726FCC0", Offset = "0x726EAC0", VA = "0x18726FCC0")]
		public static void TUUIHNWIHUU(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x726FC20", Offset = "0x726EA20", VA = "0x18726FC20")]
		public static UnityEngine.Color TUUIHNWIHUU(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		public static UnityEngine.Color VZWNOZOMNYD(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x726FE30", Offset = "0x726EC30", VA = "0x18726FE30")]
		public static void VZWNOZOMNYD(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		public static UnityEngine.Color VZWNOZOMNYD(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x726FE00", Offset = "0x726EC00", VA = "0x18726FE00")]
		public static GLTF.Math.Color VNGIMXOXJOJ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x726FF40", Offset = "0x726ED40", VA = "0x18726FF40")]
		public static GLTF.Math.Color XANQDGGGKBO(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x726F210", Offset = "0x726E010", VA = "0x18726F210")]
		public static GLTF.Math.Color NBLREXBMAFY(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x726D9B0", Offset = "0x726C7B0", VA = "0x18726D9B0")]
		public static UnityEngine.Color[] BGKZDSELYGH(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x726FBA0", Offset = "0x726E9A0", VA = "0x18726FBA0")]
		public static int[] THVUNMULOLQ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x726DFD0", Offset = "0x726CDD0", VA = "0x18726DFD0")]
		public static UnityEngine.Vector2[] DVKOVCNASON(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x726F860", Offset = "0x726E660", VA = "0x18726F860")]
		public static void QZNILZCLRWG(FFHDXILDGBA a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x726D850", Offset = "0x726C650", VA = "0x18726D850")]
		public static UnityEngine.Vector3[] AJCCPYDAOBU(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x726E3C0", Offset = "0x726D1C0", VA = "0x18726E3C0")]
		public static UnityEngine.Vector4[] HVJXIWLNOPN(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7270ED0", Offset = "0x726FCD0", VA = "0x187270ED0")]
		public static void ZVYKYHESHTU(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x726F290", Offset = "0x726E090", VA = "0x18726F290")]
		public static UnityEngine.Quaternion OMUISXTGBIE(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FFHDXILDGBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NMUUAPMAXVD NMUUAPMAXVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray AIFXDUURDSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7272D00", Offset = "0x7271B00", VA = "0x187272D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> MHTJXENVNER
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF29BE0", Offset = "0xF289E0", VA = "0x180F29BE0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1001590", Offset = "0x1000390", VA = "0x181001590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint GNCKKMJXGSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA4060", Offset = "0xAA2E60", VA = "0x180AA4060")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA48B0", Offset = "0xAA36B0", VA = "0x180AA48B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7272D10", Offset = "0x7271B10", VA = "0x187272D10")]
		public FFHDXILDGBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7272D40", Offset = "0x7271B40", VA = "0x187272D40")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7272DA0", Offset = "0x7271BA0", VA = "0x187272DA0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TABZPVBDSQX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XYFZVVXMOLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> QGXUMDDBHAO;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public XYFZVVXMOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7287550", Offset = "0x7286350", VA = "0x187287550")]
			internal int? VKDVCXQKWOD(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72873F0", Offset = "0x72861F0", VA = "0x1872873F0")]
			internal int? IDGMLAUBDCW(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7287480", Offset = "0x7286280", VA = "0x187287480")]
			internal bool OJMWHCDKVWC(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7282CE0", Offset = "0x7281AE0", VA = "0x187282CE0")]
		private static void IEJWSHUNXEE(NumericArray a, FFHDXILDGBA b, FFHDXILDGBA c, FFHDXILDGBA d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7283EC0", Offset = "0x7282CC0", VA = "0x187283EC0")]
		public static void ZNBWWXWDHFH(Dictionary<string, FFHDXILDGBA> a, Dictionary<string, (FFHDXILDGBA sparseIndices, FFHDXILDGBA sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72836F0", Offset = "0x72824F0", VA = "0x1872836F0")]
		public static void MHSCGSYTXUF(Dictionary<string, FFHDXILDGBA> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7283BD0", Offset = "0x72829D0", VA = "0x187283BD0")]
		public static void NMJYLDJBPWW(FFHDXILDGBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7282750", Offset = "0x7281550", VA = "0x187282750")]
		public static void BFXEDRCDFCM(Dictionary<string, List<FFHDXILDGBA>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7283CD0", Offset = "0x7282AD0", VA = "0x187283CD0")]
		private static void UYELPQZYTDW(FFHDXILDGBA a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7283E00", Offset = "0x7282C00", VA = "0x187283E00")]
		internal static void UYELPQZYTDW(MXBDDHKZXEM a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7283250", Offset = "0x7282050", VA = "0x187283250")]
		public static ZFFKPKWELUO IQXLUBXAODK(IEnumerable<ZFFKPKWELUO> a)
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
			[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3054F60", Offset = "0x3053D60", VA = "0x183054F60")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3054F70", Offset = "0x3053D70", VA = "0x183054F70")]
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
	public class BAPZQTPFZFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint HETELYUZAVQ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint OHZYCDCLMHC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint PASMUWQFRKO;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7271590", Offset = "0x7270390", VA = "0x187271590")]
		public static void DJQQOGBOPIA(Stream a, [Out] JEGPMPFQLBY b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7271750", Offset = "0x7270550", VA = "0x187271750")]
		public static ChunkInfo DVYFMIJBNFG(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72719E0", Offset = "0x72707E0", VA = "0x1872719E0")]
		public static GLBHeader JPSXJXXKBMI(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7271B20", Offset = "0x7270920", VA = "0x187271B20")]
		public static bool LVLIPYIWKUW(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7271C70", Offset = "0x7270A70", VA = "0x187271C70")]
		public static ChunkInfo RTKCPOOPLEH(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7271DE0", Offset = "0x7270BE0", VA = "0x187271DE0")]
		private static void YGXRQWJEZWB(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7271BE0", Offset = "0x72709E0", VA = "0x187271BE0")]
		private static uint ORBLJSREPFK(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UNKMCRGDQXN
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
		public PathElement REPKSRLNRUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int VEJGVBBERIR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", VA = "0x180C1BCE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC1BCF0", Offset = "0xC1AAF0", VA = "0x180C1BCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XMDJGZBCEIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MTNTUPABAXR
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA0940", Offset = "0xA9F740", VA = "0x180AA0940")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UNKMCRGDQXN JQZLVZTLCEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA0570", Offset = "0xA9F370", VA = "0x180AA0570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7285550", Offset = "0x7284350", VA = "0x187285550")]
		public string AHXGNAASPIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72857B0", Offset = "0x72845B0", VA = "0x1872857B0")]
		public UNKMCRGDQXN HARFWVYPLCV(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7285810", Offset = "0x7284610", VA = "0x187285810")]
		private UNKMCRGDQXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7285870", Offset = "0x7284670", VA = "0x187285870")]
		public UNKMCRGDQXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4322D50", Offset = "0x4321B50", VA = "0x184322D50")]
		[CompilerGenerated]
		internal static string ZIKDTWAPVED(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72857D0", Offset = "0x72845D0", VA = "0x1872857D0")]
		[CompilerGenerated]
		internal static bool QNOSOLRIOYG([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72855D0", Offset = "0x72843D0", VA = "0x1872855D0")]
		[CompilerGenerated]
		internal static UNKMCRGDQXN CXFVHCSEYOU(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RPSOLWRTUPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7281870", Offset = "0x7280670", VA = "0x187281870")]
		public static int[] JNPVGJJISJY(this JEGPMPFQLBY a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7281B10", Offset = "0x7280910", VA = "0x187281B10")]
		public static int[] MYIDSRJKZBW(this JEGPMPFQLBY a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LVROLMQOIXW
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x727F680", Offset = "0x727E480", VA = "0x18727F680")]
		public static uint MVGZBTFFZFJ(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream XSFNVMWRCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long MUKXRJQSBUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long JLTCEANNGCP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7282670", Offset = "0x7281470", VA = "0x187282670", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72826B0", Offset = "0x72814B0", VA = "0x1872826B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72826B0", Offset = "0x72814B0", VA = "0x1872826B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x72826D0", Offset = "0x72814D0", VA = "0x1872826D0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x72826F0", Offset = "0x72814F0", VA = "0x1872826F0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7282710", Offset = "0x7281510", VA = "0x187282710", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7282400", Offset = "0x7281200", VA = "0x187282400")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7282250", Offset = "0x7281050", VA = "0x187282250", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7282320", Offset = "0x7281120", VA = "0x187282320", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7282380", Offset = "0x7281180", VA = "0x187282380", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7282290", Offset = "0x7281090", VA = "0x187282290", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72823C0", Offset = "0x72811C0", VA = "0x1872823C0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72821C0", Offset = "0x7280FC0", VA = "0x1872821C0")]
		private void DLMTJRWJEMC()
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
		public static Color LBGEFETXVOO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7272520", Offset = "0x7271320", VA = "0x187272520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color VNAPMBQBOJW
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7272460", Offset = "0x7271260", VA = "0x187272460")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color ORCOPBUMTUE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7272240", Offset = "0x7271040", VA = "0x187272240")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2D70290", Offset = "0x2D6F090", VA = "0x182D70290")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AF0", Offset = "0x2DC48F0", VA = "0x182DC5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B443D0", VA = "0x182B455D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32534F0", Offset = "0x32522F0", VA = "0x1832534F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1569AA0", Offset = "0x15688A0", VA = "0x181569AA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1569AB0", Offset = "0x15688B0", VA = "0x181569AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B07690", Offset = "0x2B06490", VA = "0x182B07690")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7272260", Offset = "0x7271060", VA = "0x187272260", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7272310", Offset = "0x7271110", VA = "0x187272310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72723B0", Offset = "0x72711B0", VA = "0x1872723B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7272470", Offset = "0x7271270", VA = "0x187272470")]
		public static bool VVLYKZHTTRM(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class UTLIDXBRNWW : IEquatable<UTLIDXBRNWW>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly UTLIDXBRNWW RWLXPFUVUQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] QIMHKEETSYT;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float XHFEZHPVSUE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7286350", Offset = "0x7285150", VA = "0x187286350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7285A20", Offset = "0x7284820", VA = "0x187285A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CMCQOASCGMX
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x72861D0", Offset = "0x7284FD0", VA = "0x1872861D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7286260", Offset = "0x7285060", VA = "0x187286260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float JMJHSFMKDIO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7286080", Offset = "0x7284E80", VA = "0x187286080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7286170", Offset = "0x7284F70", VA = "0x187286170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float PKSFDYAXMYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7285B40", Offset = "0x7284940", VA = "0x187285B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7285FF0", Offset = "0x7284DF0", VA = "0x187285FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float XHUZRBXNVCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7286380", Offset = "0x7285180", VA = "0x187286380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7285A50", Offset = "0x7284850", VA = "0x187285A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CMHXLHLZPYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7286230", Offset = "0x7285030", VA = "0x187286230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x72862C0", Offset = "0x72850C0", VA = "0x1872862C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMEAUYSMTXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7286020", Offset = "0x7284E20", VA = "0x187286020")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7286110", Offset = "0x7284F10", VA = "0x187286110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PKCKMDTFKQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7285B10", Offset = "0x7284910", VA = "0x187285B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7285FC0", Offset = "0x7284DC0", VA = "0x187285FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float XHPSTVDQLQW
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x72863B0", Offset = "0x72851B0", VA = "0x1872863B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7285A80", Offset = "0x7284880", VA = "0x187285A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float CMNEIOFWZJP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7286200", Offset = "0x7285000", VA = "0x187286200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7286290", Offset = "0x7285090", VA = "0x187286290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float JLYTXRYPKLW
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7286050", Offset = "0x7284E50", VA = "0x187286050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7286140", Offset = "0x7284F40", VA = "0x187286140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float PKHRJKNCUBV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7285AE0", Offset = "0x72848E0", VA = "0x187285AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7285F90", Offset = "0x7284D90", VA = "0x187285F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float XGPKHNIDQMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7286320", Offset = "0x7285120", VA = "0x187286320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7285AB0", Offset = "0x72848B0", VA = "0x187285AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float CLCIBSWPLIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x72861A0", Offset = "0x7284FA0", VA = "0x1872861A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x72862F0", Offset = "0x72850F0", VA = "0x1872862F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JLTNALESBAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x72860B0", Offset = "0x7284EB0", VA = "0x1872860B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x72860E0", Offset = "0x7284EE0", VA = "0x1872860E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float PJRWRQFKRTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7285B70", Offset = "0x7284970", VA = "0x187285B70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7285F60", Offset = "0x7284D60", VA = "0x187285F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72864C0", Offset = "0x72852C0", VA = "0x1872864C0")]
		public UTLIDXBRNWW(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7285BA0", Offset = "0x72849A0", VA = "0x187285BA0", Slot = "4")]
		public bool Equals(UTLIDXBRNWW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7285E60", Offset = "0x7284C60", VA = "0x187285E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x11272F0", Offset = "0x11260F0", VA = "0x1811272F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D70290", Offset = "0x2D6F090", VA = "0x182D70290")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AF0", Offset = "0x2DC48F0", VA = "0x182DC5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B443D0", VA = "0x182B455D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32534F0", Offset = "0x32522F0", VA = "0x1832534F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1569AA0", Offset = "0x15688A0", VA = "0x181569AA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1569AB0", Offset = "0x15688B0", VA = "0x181569AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7280BC0", Offset = "0x727F9C0", VA = "0x187280BC0")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7280820", Offset = "0x727F620", VA = "0x187280820", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7280940", Offset = "0x727F740", VA = "0x187280940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72809F0", Offset = "0x727F7F0", VA = "0x1872809F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7280AD0", Offset = "0x727F8D0", VA = "0x187280AD0")]
		public static bool VVLYKZHTTRM(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D70290", Offset = "0x2D6F090", VA = "0x182D70290")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AF0", Offset = "0x2DC48F0", VA = "0x182DC5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1097CD0", Offset = "0x1096AD0", VA = "0x181097CD0")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7286960", Offset = "0x7285760", VA = "0x187286960")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7286770", Offset = "0x7285570", VA = "0x187286770", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72867D0", Offset = "0x72855D0", VA = "0x1872867D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72868B0", Offset = "0x72856B0", VA = "0x1872868B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7286900", Offset = "0x7285700", VA = "0x187286900")]
		public static bool VVLYKZHTTRM(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D70290", Offset = "0x2D6F090", VA = "0x182D70290")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AF0", Offset = "0x2DC48F0", VA = "0x182DC5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B443D0", VA = "0x182B455D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32534F0", Offset = "0x32522F0", VA = "0x1832534F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7286D20", Offset = "0x7285B20", VA = "0x187286D20")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7286980", Offset = "0x7285780", VA = "0x187286980", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7286A60", Offset = "0x7285860", VA = "0x187286A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7286B20", Offset = "0x7285920", VA = "0x187286B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7286BD0", Offset = "0x72859D0", VA = "0x187286BD0")]
		public static bool VVLYKZHTTRM(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D70290", Offset = "0x2D6F090", VA = "0x182D70290")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AF0", Offset = "0x2DC48F0", VA = "0x182DC5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B443D0", VA = "0x182B455D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32534F0", Offset = "0x32522F0", VA = "0x1832534F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1569AA0", Offset = "0x15688A0", VA = "0x181569AA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1569AB0", Offset = "0x15688B0", VA = "0x181569AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B07690", Offset = "0x2B06490", VA = "0x182B07690")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7272260", Offset = "0x7271060", VA = "0x187272260", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7286DA0", Offset = "0x7285BA0", VA = "0x187286DA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x72723B0", Offset = "0x72711B0", VA = "0x1872723B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class UMEYVPEFLZC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x72854D0", Offset = "0x72842D0", VA = "0x1872854D0")]
		public static void GNJKLYGHNTL(this JObject a, string b, DXDKBQXSLAC c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LVROLMQOIXW
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x727F1F0", Offset = "0x727DFF0", VA = "0x18727F1F0")]
		public static List<string> LKKYGLBIYIC(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x727E7C0", Offset = "0x727D5C0", VA = "0x18727E7C0")]
		public static List<double> BOUWFFJQTJE(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x727E390", Offset = "0x727D190", VA = "0x18727E390")]
		public static List<int> ALBTEUDPUQB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x39C3590", Offset = "0x39C2390", VA = "0x1839C3590")]
		public static List<a> CCMJTEXEHHZ<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x727F7D0", Offset = "0x727E5D0", VA = "0x18727F7D0")]
		public static DXDKBQXSLAC OVCZEXKIQMZ(this JToken a, JEGPMPFQLBY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x727EC40", Offset = "0x727DA40", VA = "0x18727EC40")]
		public static int DNSFCMBRKYP(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7280030", Offset = "0x727EE30", VA = "0x187280030")]
		public static double XXUALBDNFST(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x727F3A0", Offset = "0x727E1A0", VA = "0x18727F3A0")]
		public static GLTF.Math.Color MCMKZBVWSTS(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x727E550", Offset = "0x727D350", VA = "0x18727E550")]
		public static GLTF.Math.Color BBKYHKNEDGZ(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x727FD90", Offset = "0x727EB90", VA = "0x18727FD90")]
		public static GLTF.Math.Color QTUETKEMNLH(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x727E980", Offset = "0x727D780", VA = "0x18727E980")]
		public static GLTF.Math.Vector3 DKBYKSMJTFH(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x727EFE0", Offset = "0x727DDE0", VA = "0x18727EFE0")]
		public static GLTF.Math.Vector2 GVPLOIURJWN(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x727ED80", Offset = "0x727DB80", VA = "0x18727ED80")]
		public static GLTF.Math.Vector3 GVKERCAUALE(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x727FA80", Offset = "0x727E880", VA = "0x18727FA80")]
		public static GLTF.Math.Quaternion PZZQMUYRWEX(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x39C2F80", Offset = "0x39C1D80", VA = "0x1839C2F80")]
		public static Dictionary<string, b> AFBFKMBEVJZ<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x39C38E0", Offset = "0x39C26E0", VA = "0x1839C38E0")]
		public static c VYDGTZGRKIH<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public MXBDDHKZXEM bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7272A20", Offset = "0x7271820", VA = "0x187272A20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72729A0", Offset = "0x72717A0", VA = "0x1872729A0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AIWDNJQLEPZ : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x726D600", Offset = "0x726C400", VA = "0x18726D600")]
		public AIWDNJQLEPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x726D530", Offset = "0x726C330", VA = "0x18726D530", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, NMUUAPMAXVD> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7272860", Offset = "0x7271660", VA = "0x187272860", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7272920", Offset = "0x7271720", VA = "0x187272920")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SQLEPZASDGB : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public JEGPMPFQLBY DSTQIKJKEHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader JVLHDBRZGEY;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x72803D0", Offset = "0x727F1D0", VA = "0x1872803D0")]
			internal NMUUAPMAXVD QYZNXWGJMLI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7282170", Offset = "0x7280F70", VA = "0x187282170")]
		public SQLEPZASDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7281FE0", Offset = "0x7280DE0", VA = "0x187281FE0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TSECXPZEUJP TWAQIUSAEXE;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public EXT_texture_exr(TSECXPZEUJP source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7272A70", Offset = "0x7271870", VA = "0x187272A70", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7272AE0", Offset = "0x72718E0", VA = "0x187272AE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class KKRCQDIHSMA : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x727DA70", Offset = "0x727C870", VA = "0x18727DA70")]
		public KKRCQDIHSMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x727D950", Offset = "0x727C750", VA = "0x18727D950", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
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
	public class AudioEmitterId : SPBTGZCBRBG<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x72712B0", Offset = "0x72700B0", VA = "0x1872712B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7271270", Offset = "0x7270070", VA = "0x187271270")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : SPBTGZCBRBG<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7271440", Offset = "0x7270240", VA = "0x187271440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7271400", Offset = "0x7270200", VA = "0x187271400")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : SPBTGZCBRBG<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7271120", Offset = "0x726FF20", VA = "0x187271120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x72710E0", Offset = "0x726FEE0", VA = "0x1872710E0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7271000", Offset = "0x726FE00", VA = "0x187271000")]
		public static AudioDataId Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7279FB0", Offset = "0x7278DB0", VA = "0x187279FB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7279BB0", Offset = "0x72789B0", VA = "0x187279BB0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7279C20", Offset = "0x7278A20", VA = "0x187279C20")]
		public static KHR_SceneAudioEmittersRef Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x727A210", Offset = "0x7279010", VA = "0x18727A210")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7279B80", Offset = "0x7278980", VA = "0x187279B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7279A60", Offset = "0x7278860", VA = "0x187279A60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7279850", Offset = "0x7278650", VA = "0x187279850", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72798C0", Offset = "0x72786C0", VA = "0x1872798C0")]
		public static KHR_NodeAudioEmitterRef Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ZOCUMIVPIEZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string DMAQMVSSDWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? VWENRMXRKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? NCVTXIKNGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? AFXIJXXRPTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? AMAJARBVLRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? CWEYLHHZACU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? CHGHIDBBDLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? WRBDJDTFMHY;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7288A30", Offset = "0x7287830", VA = "0x187288A30")]
		public JObject HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7288330", Offset = "0x7287130", VA = "0x187288330")]
		public static ZOCUMIVPIEZ Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZOCUMIVPIEZ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : SMHNIHEYMTG
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
		public ZOCUMIVPIEZ positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7278EA0", Offset = "0x7277CA0", VA = "0x187278EA0", Slot = "5")]
		public virtual JObject HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x72789A0", Offset = "0x72777A0", VA = "0x1872789A0")]
		public static KHR_AudioEmitter Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7279240", Offset = "0x7278040", VA = "0x187279240")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : SMHNIHEYMTG
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
		[Cpp2IlInjected.Address(RVA = "0x7279620", Offset = "0x7278420", VA = "0x187279620")]
		public JObject HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x72792C0", Offset = "0x72780C0", VA = "0x1872792C0")]
		public static KHR_AudioSource Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7277780", Offset = "0x7276580", VA = "0x187277780")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public RYLYSLHLCFT bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7278870", Offset = "0x7277670", VA = "0x187278870")]
		public JObject HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7278610", Offset = "0x7277410", VA = "0x187278610")]
		public static KHR_AudioData Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7277780", Offset = "0x7276580", VA = "0x187277780")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : AHNEHECEPNV
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
		[Cpp2IlInjected.Address(RVA = "0x727A4D0", Offset = "0x72792D0", VA = "0x18727A4D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x727A440", Offset = "0x7279240", VA = "0x18727A440", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x727AC00", Offset = "0x7279A00", VA = "0x18727AC00")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RBKVACUGOKQ : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7281820", Offset = "0x7280620", VA = "0x187281820")]
		public RBKVACUGOKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7280C50", Offset = "0x727FA50", VA = "0x187280C50", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public RYLYSLHLCFT bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x727ADD0", Offset = "0x7279BD0", VA = "0x18727ADD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x727AD10", Offset = "0x7279B10", VA = "0x18727AD10", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x727AE20", Offset = "0x7279C20", VA = "0x18727AE20")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class MQNFNAUNJKG : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader JVLHDBRZGEY;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7280480", Offset = "0x727F280", VA = "0x187280480")]
			internal int QYZNXWGJMLI()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7280380", Offset = "0x727F180", VA = "0x187280380")]
		public MQNFNAUNJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7280170", Offset = "0x727EF70", VA = "0x187280170", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public DXDKBQXSLAC anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x727AF20", Offset = "0x7279D20", VA = "0x18727AF20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x727AEA0", Offset = "0x7279CA0", VA = "0x18727AEA0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class JHSGFKRZKQF : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7277B30", Offset = "0x7276930", VA = "0x187277B30")]
		public JHSGFKRZKQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7277980", Offset = "0x7276780", VA = "0x187277980", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DXDKBQXSLAC clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public DXDKBQXSLAC clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DXDKBQXSLAC clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x727B1D0", Offset = "0x7279FD0", VA = "0x18727B1D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x727B130", Offset = "0x7279F30", VA = "0x18727B130", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class XUFDTCOMRQH : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72873A0", Offset = "0x72861A0", VA = "0x1872873A0")]
		public XUFDTCOMRQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7287120", Offset = "0x7285F20", VA = "0x187287120", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x727B530", Offset = "0x727A330", VA = "0x18727B530", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x727B4C0", Offset = "0x727A2C0", VA = "0x18727B4C0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class KAHGRZSSYZF : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7278410", Offset = "0x7277210", VA = "0x187278410")]
		public KAHGRZSSYZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7278340", Offset = "0x7277140", VA = "0x187278340", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : OEOAPTMWLBZ, AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float WKUYPOCSEFL;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x727B880", Offset = "0x727A680", VA = "0x18727B880")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x727B810", Offset = "0x727A610", VA = "0x18727B810")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, JEGPMPFQLBY root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x727B650", Offset = "0x727A450", VA = "0x18727B650", Slot = "6")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x727B6F0", Offset = "0x727A4F0", VA = "0x18727B6F0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class XPMVCJGCEOQ : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x72870D0", Offset = "0x7285ED0", VA = "0x1872870D0")]
		public XPMVCJGCEOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7286FD0", Offset = "0x7285DD0", VA = "0x187286FD0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x727B930", Offset = "0x727A730", VA = "0x18727B930", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x727B8D0", Offset = "0x727A6D0", VA = "0x18727B8D0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x727BA80", Offset = "0x727A880", VA = "0x18727BA80")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class SJTIJZKLJBF : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7281F90", Offset = "0x7280D90", VA = "0x187281F90")]
		public SJTIJZKLJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7281EC0", Offset = "0x7280CC0", VA = "0x187281EC0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DXDKBQXSLAC iridescenceTexture;

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
		public DXDKBQXSLAC iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x727BB30", Offset = "0x727A930", VA = "0x18727BB30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x727BA90", Offset = "0x727A890", VA = "0x18727BA90", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x727BEF0", Offset = "0x727ACF0", VA = "0x18727BEF0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ZAKJYKWWYQB : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72882E0", Offset = "0x72870E0", VA = "0x1872882E0")]
		public ZAKJYKWWYQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7287FF0", Offset = "0x7286DF0", VA = "0x187287FF0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class XYXLZBXDXII : AHNEHECEPNV
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 KVXCBIACJKU;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double GZEDCSTADXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color XYFSHEUHRCQ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color IILNDQVHVRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DXDKBQXSLAC CYUAELZNEQG;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly DXDKBQXSLAC YSBGSESFZFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 HERRHEWFPKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double KYFLFCJLURI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DXDKBQXSLAC XQNHFFXJQPF;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly DXDKBQXSLAC VAEEUVAYZZZ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7287EF0", Offset = "0x7286CF0", VA = "0x187287EF0")]
		public XYXLZBXDXII(GLTF.Math.Color a, DXDKBQXSLAC b, GLTF.Math.Vector3 c, double d, DXDKBQXSLAC e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72875D0", Offset = "0x72863D0", VA = "0x1872875D0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7287790", Offset = "0x7286590", VA = "0x187287790", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class KSBUKDWIFSC : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x727DE20", Offset = "0x727CC20", VA = "0x18727DE20")]
		public KSBUKDWIFSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x727DAC0", Offset = "0x727C8C0", VA = "0x18727DAC0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DXDKBQXSLAC sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DXDKBQXSLAC sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x727BFE0", Offset = "0x727ADE0", VA = "0x18727BFE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x727BF10", Offset = "0x727AD10", VA = "0x18727BF10", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x727C4F0", Offset = "0x727B2F0", VA = "0x18727C4F0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class LSICCLWLJXK : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x727E340", Offset = "0x727D140", VA = "0x18727E340")]
		public LSICCLWLJXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x727E0E0", Offset = "0x727CEE0", VA = "0x18727E0E0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DXDKBQXSLAC specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DXDKBQXSLAC specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x727C630", Offset = "0x727B430", VA = "0x18727C630", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x727C560", Offset = "0x727B360", VA = "0x18727C560", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x727CB40", Offset = "0x727B940", VA = "0x18727CB40")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class KUMCPLUBELW : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x727E090", Offset = "0x727CE90", VA = "0x18727E090")]
		public KUMCPLUBELW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x727DE70", Offset = "0x727CC70", VA = "0x18727DE70", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DXDKBQXSLAC transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x727CC30", Offset = "0x727BA30", VA = "0x18727CC30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x727CBB0", Offset = "0x727B9B0", VA = "0x18727CBB0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class WZTLKPOCSYJ : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7286F80", Offset = "0x7285D80", VA = "0x187286F80")]
		public WZTLKPOCSYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7286E40", Offset = "0x7285C40", VA = "0x187286E40", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class UAPQVWOPMDQ : OEOAPTMWLBZ, AHNEHECEPNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7285410", Offset = "0x7284210", VA = "0x187285410")]
		public UAPQVWOPMDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7285460", Offset = "0x7284260", VA = "0x187285460")]
		public UAPQVWOPMDQ(UAPQVWOPMDQ a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7285210", Offset = "0x7284010", VA = "0x187285210", Slot = "6")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x72852B0", Offset = "0x72840B0", VA = "0x1872852B0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7285340", Offset = "0x7284140", VA = "0x187285340", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class QJYNYODHMRG : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x72807D0", Offset = "0x727F5D0", VA = "0x1872807D0")]
		public QJYNYODHMRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7280750", Offset = "0x727F550", VA = "0x187280750", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DXDKBQXSLAC thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x727CE50", Offset = "0x727BC50", VA = "0x18727CE50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x727CDC0", Offset = "0x727BBC0", VA = "0x18727CDC0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x727D380", Offset = "0x727C180", VA = "0x18727D380")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class RQDZGNJSFVN : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7281E70", Offset = "0x7280C70", VA = "0x187281E70")]
		public RQDZGNJSFVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7281C60", Offset = "0x7280A60", VA = "0x187281C60", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x727D400", Offset = "0x727C200", VA = "0x18727D400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x727D3A0", Offset = "0x727C1A0", VA = "0x18727D3A0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x127DC30", Offset = "0x127CA30", VA = "0x18127DC30")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class QBNSOBLAQKZ : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7280700", Offset = "0x727F500", VA = "0x187280700")]
		public QBNSOBLAQKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7280620", Offset = "0x727F420", VA = "0x187280620", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x727D570", Offset = "0x727C370", VA = "0x18727D570", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x727D510", Offset = "0x727C310", VA = "0x18727D510", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x127DC30", Offset = "0x127CA30", VA = "0x18127DC30")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class PQQMAYINZQT : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72805D0", Offset = "0x727F3D0", VA = "0x1872805D0")]
		public PQQMAYINZQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72804F0", Offset = "0x727F2F0", VA = "0x1872804F0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x727D6E0", Offset = "0x727C4E0", VA = "0x18727D6E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x727D680", Offset = "0x727C480", VA = "0x18727D680", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x127DC30", Offset = "0x127CA30", VA = "0x18127DC30")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class FEMHMRTNXAN : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7272CB0", Offset = "0x7271AB0", VA = "0x187272CB0")]
		public FEMHMRTNXAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7272BD0", Offset = "0x72719D0", VA = "0x187272BD0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TSECXPZEUJP source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public KHR_texture_basisu(TSECXPZEUJP source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x727D7F0", Offset = "0x727C5F0", VA = "0x18727D7F0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x727D860", Offset = "0x727C660", VA = "0x18727D860", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class KEHPMKXZCLV : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x72785C0", Offset = "0x72773C0", VA = "0x1872785C0")]
		public KEHPMKXZCLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7278460", Offset = "0x7277260", VA = "0x187278460", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class JMMQRSMWCDW : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 GNCKKMJXGSA;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 NEIVDIGEMVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double BSVMTQBEROR;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double NCSKHUIKRXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 XQMDWVHUFRR;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 LWOKXQOFEQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? OLREMYLJRRX;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int VQLPMQNHJOD;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72782C0", Offset = "0x72770C0", VA = "0x1872782C0")]
		public JMMQRSMWCDW(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7277B80", Offset = "0x7276980", VA = "0x187277B80", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7277C60", Offset = "0x7276A60", VA = "0x187277C60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DCAJSNAIXTA : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7272810", Offset = "0x7271610", VA = "0x187272810")]
		public DCAJSNAIXTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7272540", Offset = "0x7271340", VA = "0x187272540", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class JDMWQVCUMTM : AHNEHECEPNV
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> WPPONRDHENZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public JDMWQVCUMTM(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7277790", Offset = "0x7276590", VA = "0x187277790", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7277890", Offset = "0x7276690", VA = "0x187277890", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7277800", Offset = "0x7276600", VA = "0x187277800")]
		public List<double> IJRCTAYCMTQ(ITZFJUYYDSP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class CWLRUCKJAFC : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x72721F0", Offset = "0x7270FF0", VA = "0x1872721F0")]
		public CWLRUCKJAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x72720F0", Offset = "0x7270EF0", VA = "0x1872720F0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GMQLUKDHWUE : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public RYLYSLHLCFT MXBDDHKZXEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint FBFTPVDAAAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType MWSAWQNWXUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool ETBBHXMNNRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint DODEZUTZSIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType QHIGGIBDJUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> ANCTJLIZYNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> CLRJNPXFNPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public VMESERCVBMA OCNMDDDTGBZ;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7277780", Offset = "0x7276580", VA = "0x187277780")]
		public GMQLUKDHWUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x72739C0", Offset = "0x72727C0", VA = "0x1872739C0")]
		public static GMQLUKDHWUE Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7274200", Offset = "0x7273000", VA = "0x187274200", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7273E70", Offset = "0x7272C70", VA = "0x187273E70")]
		private unsafe static sbyte GYKIKWJCFYB(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7276970", Offset = "0x7275770", VA = "0x187276970")]
		private unsafe static float2 UOFENBQWLEB(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7273E20", Offset = "0x7272C20", VA = "0x187273E20")]
		private unsafe static float3 EHOMFZFAATK(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7273210", Offset = "0x7272010", VA = "0x187273210")]
		private unsafe static float4 CANINHPDODJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7274030", Offset = "0x7272E30", VA = "0x187274030")]
		private unsafe static float4x4 GTENEVXVQBZ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7273E70", Offset = "0x7272C70", VA = "0x187273E70")]
		private unsafe static byte EWDGEUYRJBQ(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7275080", Offset = "0x7273E80", VA = "0x187275080")]
		private unsafe static float2 KWIKQXOAFUQ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7275520", Offset = "0x7274320", VA = "0x187275520")]
		private unsafe static float3 NGPOCTAPBGB(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7275350", Offset = "0x7274150", VA = "0x187275350")]
		private unsafe static float4 MQFWHIZKUQG(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7273E80", Offset = "0x7272C80", VA = "0x187273E80")]
		private unsafe static float4x4 FVURAGPCRCS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7272E00", Offset = "0x7271C00", VA = "0x187272E00")]
		private unsafe static short ABUFJATMWRB(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7274DA0", Offset = "0x7273BA0", VA = "0x187274DA0")]
		private unsafe static float2 JGKCSGTVFYP(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7275300", Offset = "0x7274100", VA = "0x187275300")]
		private unsafe static float3 LSJJNILTGEG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72747E0", Offset = "0x72735E0", VA = "0x1872747E0")]
		private unsafe static float4 HSVAPIRQDOJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x72773B0", Offset = "0x72761B0", VA = "0x1872773B0")]
		private unsafe static float4x4 YEJOPRWCBEJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7272E00", Offset = "0x7271C00", VA = "0x187272E00")]
		private unsafe static ushort VRFWLYGIPFI(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7272E40", Offset = "0x7271C40", VA = "0x187272E40")]
		private unsafe static float2 AMODKMAKPWU(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7274D50", Offset = "0x7273B50", VA = "0x187274D50")]
		private unsafe static float3 IMGHUTJFJJD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7275FA0", Offset = "0x7274DA0", VA = "0x187275FA0")]
		private unsafe static float4x4 PVXOXHGKPJE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7276410", Offset = "0x7275210", VA = "0x187276410")]
		private unsafe static float4 QIEPDNGCZYC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7274020", Offset = "0x7272E20", VA = "0x187274020")]
		private unsafe static uint GBSFLWAVALZ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7272E00", Offset = "0x7271C00", VA = "0x187272E00")]
		private unsafe static ushort AEUFOCRQKKC(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x72758D0", Offset = "0x72746D0", VA = "0x1872758D0")]
		private unsafe static float NULDSDFHRNV(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7277000", Offset = "0x7275E00", VA = "0x187277000")]
		private unsafe static float2 VTUXMJFKDBV(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x72758B0", Offset = "0x72746B0", VA = "0x1872758B0")]
		private unsafe static float3 NMZYXHIGSPA(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7272E10", Offset = "0x7271C10", VA = "0x187272E10")]
		private unsafe static float4 AEDXFPVKJGB(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72741D0", Offset = "0x7272FD0", VA = "0x1872741D0")]
		private unsafe static float4x4 HCMHBRFRAEV(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7272E10", Offset = "0x7271C10", VA = "0x187272E10")]
		private unsafe static float4 DUBIGEZBZSE(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7273990", Offset = "0x7272790", VA = "0x187273990")]
		private unsafe static float4 DUBIGEZBZSE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7274B20", Offset = "0x7273920", VA = "0x187274B20")]
		public static float3[] IFLZZZFWAEV(GMQLUKDHWUE a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7276CF0", Offset = "0x7275AF0", VA = "0x187276CF0")]
		public static float3[] VFINNJVOQOB(GMQLUKDHWUE a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7273270", Offset = "0x7272070", VA = "0x187273270")]
		public static uint[] CHVCKKOOSGQ(GMQLUKDHWUE a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7277550", Offset = "0x7276350", VA = "0x187277550")]
		internal static void YNTGFUMZMWF(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72750B0", Offset = "0x7273EB0", VA = "0x1872750B0")]
		public uint[] LQIGAKESZIE(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7272FA0", Offset = "0x7271DA0", VA = "0x187272FA0")]
		public float[] BUFELHJHMIE(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7276470", Offset = "0x7275270", VA = "0x187276470")]
		public float2[] SSTNVCMGQTG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7274DD0", Offset = "0x7273BD0", VA = "0x187274DD0")]
		public float2[] JIJVZWUTOBQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7276190", Offset = "0x7274F90", VA = "0x187276190")]
		public float3[] QABRPGICPCJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72769A0", Offset = "0x72757A0", VA = "0x1872769A0")]
		public float3[] URPXHDWVGNH(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7276700", Offset = "0x7275500", VA = "0x187276700")]
		public float4[] TZDLPLAHIYC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72758E0", Offset = "0x72746E0", VA = "0x1872758E0")]
		public float4[] ORRCILMGGIS(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7277020", Offset = "0x7275E20", VA = "0x187277020")]
		public float4[] XCHNVHOFAEL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7275E90", Offset = "0x7274C90", VA = "0x187275E90")]
		public float3[] PKLMWTYQSAW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7277670", Offset = "0x7276470", VA = "0x187277670")]
		public float3[] YOGBXOMOBSR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7275C50", Offset = "0x7274A50", VA = "0x187275C50")]
		public float4[] PFGIRJGOSLP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7276140", Offset = "0x7274F40", VA = "0x187276140")]
		public uint[] PZIMICYYUEE(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x72733E0", Offset = "0x72721E0", VA = "0x1872733E0")]
		public float4x4[] DDDYUGXBJWL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72756F0", Offset = "0x72744F0", VA = "0x1872756F0")]
		private unsafe static float4 NGUFXSESNEX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7275570", Offset = "0x7274370", VA = "0x187275570")]
		private unsafe static float4 NGUFXSESNEX(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72753B0", Offset = "0x72741B0", VA = "0x1872753B0")]
		private unsafe static float4x4 MUUDPNKWAQM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7274960", Offset = "0x7273760", VA = "0x187274960")]
		private unsafe static float4 ICIAEPJWTDO(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7275D20", Offset = "0x7274B20", VA = "0x187275D20")]
		private unsafe static float3 PIZCUTRYTHF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7272E70", Offset = "0x7271C70", VA = "0x187272E70")]
		private unsafe static float2 BLSXRLVNDSS(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7274840", Offset = "0x7273640", VA = "0x187274840")]
		private unsafe static uint HXBQYMTXKFB(void* a, uint b, GLTFComponentType c)
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
	public static class JXQKPEVZUCZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7293240", Offset = "0x7292040", VA = "0x187293240")]
		public static int FZLEANNPKTD(this GLTFAccessorAttributeType a)
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
	public class VMESERCVBMA : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int DODEZUTZSIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public UORJGOEGWIJ VTFBNNGXLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public UFRMQGGHTNU VCUOKDGPURT;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x729CD40", Offset = "0x729BB40", VA = "0x18729CD40")]
		public VMESERCVBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x729C940", Offset = "0x729B740", VA = "0x18729C940")]
		public static VMESERCVBMA Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x729CC10", Offset = "0x729BA10", VA = "0x18729CC10", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class UORJGOEGWIJ : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public RYLYSLHLCFT MXBDDHKZXEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int FBFTPVDAAAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType MWSAWQNWXUG;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x729C5B0", Offset = "0x729B3B0", VA = "0x18729C5B0")]
		public UORJGOEGWIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x729C190", Offset = "0x729AF90", VA = "0x18729C190")]
		public static UORJGOEGWIJ Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x729C470", Offset = "0x729B270", VA = "0x18729C470", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class UFRMQGGHTNU : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public RYLYSLHLCFT MXBDDHKZXEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int FBFTPVDAAAS;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x729BEF0", Offset = "0x729ACF0", VA = "0x18729BEF0")]
		public UFRMQGGHTNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x729BB70", Offset = "0x729A970", VA = "0x18729BB70")]
		public static UFRMQGGHTNU Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x729BDF0", Offset = "0x729ABF0", VA = "0x18729BDF0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class UEXHOQQDBSG : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public UDURTZUXWGU QJWUYDOCQXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public EYAOZSPNWCD MPMENXEKTUO;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x729BB20", Offset = "0x729A920", VA = "0x18729BB20")]
		public UEXHOQQDBSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x729B830", Offset = "0x729A630", VA = "0x18729B830")]
		public static UEXHOQQDBSG Deserialize(JEGPMPFQLBY root, JsonReader reader, SBMUZBVSHME anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x729BA20", Offset = "0x729A820", VA = "0x18729BA20", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class EYAOZSPNWCD : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public ZFFKPKWELUO ITZFJUYYDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string VTVZRHPQXJS;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x728A9C0", Offset = "0x72897C0", VA = "0x18728A9C0")]
		public static EYAOZSPNWCD Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x728AD40", Offset = "0x7289B40", VA = "0x18728AD40")]
		public EYAOZSPNWCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x728AC20", Offset = "0x7289A20", VA = "0x18728AC20", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
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
	public class IWZSBNLNSDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(IWZSBNLNSDO data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] GXYJJSZYENV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type XVGPZZFLJLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] CCEWECUSMTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion IPNXNEGYYNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string SNNTSGKTUWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string OTSKPPZFATY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public FFHDXILDGBA ZPVDXBOTYOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string AXJRXVLVJQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string UTHBPEIVEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public FFHDXILDGBA LMBAZJSXVTZ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x728DC70", Offset = "0x728CA70", VA = "0x18728DC70")]
		public IWZSBNLNSDO()
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
	public class DLNLAHSCUBL : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NMUUAPMAXVD OJSDLAFKVLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType XNAIMTZVUSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NMUUAPMAXVD TCOECFKWVBE;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7289AC0", Offset = "0x72888C0", VA = "0x187289AC0")]
		public DLNLAHSCUBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7289730", Offset = "0x7288530", VA = "0x187289730")]
		public static DLNLAHSCUBL Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7289950", Offset = "0x7288750", VA = "0x187289950", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class KAPAMLNTHTX : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string SPFYQHVYADW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string CPOKWXRBBEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string SMFKXVOEEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string IFFMXSNHGVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> XWOGDMWSUWX;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7293D90", Offset = "0x7292B90", VA = "0x187293D90")]
		public KAPAMLNTHTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x72932A0", Offset = "0x72920A0", VA = "0x1872932A0")]
		public static KAPAMLNTHTX Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x72935C0", Offset = "0x72923C0", VA = "0x1872935C0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7293D80", Offset = "0x7292B80", VA = "0x187293D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72939E0", Offset = "0x72927E0", VA = "0x1872939E0")]
		public string KOYROKBXKQT(bool a)
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
	public class MXBDDHKZXEM : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PVIVURSNZEM RUOVJUWGDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint FBFTPVDAAAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint WIYJTPMZYLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint SLAXYIUMQUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget MPMENXEKTUO;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public MXBDDHKZXEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7295420", Offset = "0x7294220", VA = "0x187295420")]
		public static MXBDDHKZXEM Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x72956D0", Offset = "0x72944D0", VA = "0x1872956D0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class CGTFWNOKWCC : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double BLGQUYACTIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double FGCEKZRMHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double FPVSXMTXFVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double TEELHNNQAAB;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x72891A0", Offset = "0x7287FA0", VA = "0x1872891A0")]
		public CGTFWNOKWCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7288CB0", Offset = "0x7287AB0", VA = "0x187288CB0")]
		public static CGTFWNOKWCC Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7289030", Offset = "0x7287E30", VA = "0x187289030", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PTDQVGVKDSK : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double ZJYYFYRIKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double FAPFZTRROKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double FPVSXMTXFVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double TEELHNNQAAB;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7297FE0", Offset = "0x7296DE0", VA = "0x187297FE0")]
		public PTDQVGVKDSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7297AE0", Offset = "0x72968E0", VA = "0x187297AE0")]
		public static PTDQVGVKDSK Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7297E50", Offset = "0x7296C50", VA = "0x187297E50", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class SBMUZBVSHME : SMHNIHEYMTG
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public JEGPMPFQLBY DSTQIKJKEHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader JVLHDBRZGEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public SBMUZBVSHME BKRDBLKHTSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<UEXHOQQDBSG> JNYRQJZXYCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<DLNLAHSCUBL> JODYNQTVHNL;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7297830", Offset = "0x7296630", VA = "0x187297830")]
			internal UEXHOQQDBSG QYZNXWGJMLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7297850", Offset = "0x7296650", VA = "0x187297850")]
			internal DLNLAHSCUBL QZEUVDAGVWR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<UEXHOQQDBSG> PNZIPLZDBYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<DLNLAHSCUBL> XDUCOFMJSCG;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7298C90", Offset = "0x7297A90", VA = "0x187298C90")]
		public static SBMUZBVSHME Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x72993F0", Offset = "0x72981F0", VA = "0x1872993F0")]
		public SBMUZBVSHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7299050", Offset = "0x7297E50", VA = "0x187299050", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class YAMSYOBWLZO : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string GJGFOUGGWMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint WIYJTPMZYLH;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public YAMSYOBWLZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x729E4C0", Offset = "0x729D2C0", VA = "0x18729E4C0")]
		public static YAMSYOBWLZO Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x729E690", Offset = "0x729D490", VA = "0x18729E690", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class XUUFJULOTEV : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CGTFWNOKWCC DULPWEFXAKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public PTDQVGVKDSK MMTFEMDWJVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType QHIGGIBDJUD;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public XUUFJULOTEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x729E120", Offset = "0x729CF20", VA = "0x18729E120")]
		public static XUUFJULOTEV Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x729E2F0", Offset = "0x729D0F0", VA = "0x18729E2F0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
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
	public class SMHNIHEYMTG : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string CCOXOANSCWI;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public SMHNIHEYMTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7299F70", Offset = "0x7298D70", VA = "0x187299F70")]
		public SMHNIHEYMTG(SMHNIHEYMTG a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7299E80", Offset = "0x7298C80", VA = "0x187299E80")]
		public new void TZRNPGRICOW(JEGPMPFQLBY a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7299DF0", Offset = "0x7298BF0", VA = "0x187299DF0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class SPBTGZCBRBG<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int WBRSHDLSFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public JEGPMPFQLBY RDIQMDZZHYP;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected SPBTGZCBRBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x60025A0", Offset = "0x60013A0", VA = "0x1860025A0")]
		public SPBTGZCBRBG(SPBTGZCBRBG<a> a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6002570", Offset = "0x6001370", VA = "0x186002570")]
		public void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class NMUUAPMAXVD : SPBTGZCBRBG<GMQLUKDHWUE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override GMQLUKDHWUE Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7295A60", Offset = "0x7294860", VA = "0x187295A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7295A20", Offset = "0x7294820", VA = "0x187295A20")]
		public NMUUAPMAXVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x72959C0", Offset = "0x72947C0", VA = "0x1872959C0")]
		public NMUUAPMAXVD(NMUUAPMAXVD a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x72958E0", Offset = "0x72946E0", VA = "0x1872958E0")]
		public static NMUUAPMAXVD Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class PVIVURSNZEM : SPBTGZCBRBG<YAMSYOBWLZO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override YAMSYOBWLZO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7298160", Offset = "0x7296F60", VA = "0x187298160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7298120", Offset = "0x7296F20", VA = "0x187298120")]
		public PVIVURSNZEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7298040", Offset = "0x7296E40", VA = "0x187298040")]
		public static PVIVURSNZEM Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class RYLYSLHLCFT : SPBTGZCBRBG<MXBDDHKZXEM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override MXBDDHKZXEM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7298C30", Offset = "0x7297A30", VA = "0x187298C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7298BF0", Offset = "0x72979F0", VA = "0x187298BF0")]
		public RYLYSLHLCFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7298B10", Offset = "0x7297910", VA = "0x187298B10")]
		public static RYLYSLHLCFT Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class LYKGRISWJPD : SPBTGZCBRBG<XUUFJULOTEV>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override XUUFJULOTEV Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x72950C0", Offset = "0x7293EC0", VA = "0x1872950C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7295080", Offset = "0x7293E80", VA = "0x187295080")]
		public LYKGRISWJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7294FA0", Offset = "0x7293DA0", VA = "0x187294FA0")]
		public static LYKGRISWJPD Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class TSECXPZEUJP : SPBTGZCBRBG<WRMHZHADUQH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override WRMHZHADUQH Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x729B120", Offset = "0x7299F20", VA = "0x18729B120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x729B0E0", Offset = "0x7299EE0", VA = "0x18729B0E0")]
		public TSECXPZEUJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x729B000", Offset = "0x7299E00", VA = "0x18729B000")]
		public static TSECXPZEUJP Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class JBMWHHJOXTB : SPBTGZCBRBG<LFPGYMTHYUP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override LFPGYMTHYUP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x728DE90", Offset = "0x728CC90", VA = "0x18728DE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x728DE50", Offset = "0x728CC50", VA = "0x18728DE50")]
		public JBMWHHJOXTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x728DDF0", Offset = "0x728CBF0", VA = "0x18728DDF0")]
		public JBMWHHJOXTB(JBMWHHJOXTB a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x728DD10", Offset = "0x728CB10", VA = "0x18728DD10")]
		public static JBMWHHJOXTB Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class MUTJXJIJLNJ : SPBTGZCBRBG<EECTGHVLDRV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override EECTGHVLDRV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x72953C0", Offset = "0x72941C0", VA = "0x1872953C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7295380", Offset = "0x7294180", VA = "0x187295380")]
		public MUTJXJIJLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x72952A0", Offset = "0x72940A0", VA = "0x1872952A0")]
		public static MUTJXJIJLNJ Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ZFFKPKWELUO : SPBTGZCBRBG<ITZFJUYYDSP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ITZFJUYYDSP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x729EB70", Offset = "0x729D970", VA = "0x18729EB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x729EB30", Offset = "0x729D930", VA = "0x18729EB30")]
		public ZFFKPKWELUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x729EA50", Offset = "0x729D850", VA = "0x18729EA50")]
		public static ZFFKPKWELUO Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x729E7E0", Offset = "0x729D5E0", VA = "0x18729E7E0")]
		public static List<ZFFKPKWELUO> CCMJTEXEHHZ(JEGPMPFQLBY a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class RLRGXDMETCI : SPBTGZCBRBG<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7298390", Offset = "0x7297190", VA = "0x187298390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7298350", Offset = "0x7297150", VA = "0x187298350")]
		public RLRGXDMETCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7298270", Offset = "0x7297070", VA = "0x187298270")]
		public static RLRGXDMETCI Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class UDURTZUXWGU : SPBTGZCBRBG<DLNLAHSCUBL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public SBMUZBVSHME SBMUZBVSHME;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override DLNLAHSCUBL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x729B7D0", Offset = "0x729A5D0", VA = "0x18729B7D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x729B790", Offset = "0x729A590", VA = "0x18729B790")]
		public UDURTZUXWGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x729B690", Offset = "0x729A490", VA = "0x18729B690")]
		public static UDURTZUXWGU Deserialize(JEGPMPFQLBY root, SBMUZBVSHME anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class MBNBZIRCBIE : SPBTGZCBRBG<SWPQGJPBGRA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override SWPQGJPBGRA Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7295240", Offset = "0x7294040", VA = "0x187295240", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7295200", Offset = "0x7294000", VA = "0x187295200")]
		public MBNBZIRCBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7295120", Offset = "0x7293F20", VA = "0x187295120")]
		public static MBNBZIRCBIE Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class SMSTVAHXERJ : SPBTGZCBRBG<RSJDRJPKBBI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override RSJDRJPKBBI Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x729A110", Offset = "0x7298F10", VA = "0x18729A110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x729A0D0", Offset = "0x7298ED0", VA = "0x18729A0D0")]
		public SMSTVAHXERJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7299FF0", Offset = "0x7298DF0", VA = "0x187299FF0")]
		public static SMSTVAHXERJ Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class OOCAYDTODPB : SPBTGZCBRBG<VEFCIGNAVSV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override VEFCIGNAVSV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x72979E0", Offset = "0x72967E0", VA = "0x1872979E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72979A0", Offset = "0x72967A0", VA = "0x1872979A0")]
		public OOCAYDTODPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7297940", Offset = "0x7296740", VA = "0x187297940")]
		public OOCAYDTODPB(OOCAYDTODPB a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7297860", Offset = "0x7296660", VA = "0x187297860")]
		public static OOCAYDTODPB Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class PHBLARULNQA : SPBTGZCBRBG<XKBVQIVWIBE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override XKBVQIVWIBE Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7297A80", Offset = "0x7296880", VA = "0x187297A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7297A40", Offset = "0x7296840", VA = "0x187297A40")]
		public PHBLARULNQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class WRMHZHADUQH : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string GJGFOUGGWMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string MKQNDYGGRRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public RYLYSLHLCFT MXBDDHKZXEM;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public WRMHZHADUQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x729D6E0", Offset = "0x729C4E0", VA = "0x18729D6E0")]
		public static WRMHZHADUQH Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x729D920", Offset = "0x729C720", VA = "0x18729D920", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class LFPGYMTHYUP : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public GZCVLCDLAES GZCVLCDLAES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public SVSWUSHVYZB TGRSIECYMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public XQXBXVDXOPB FJPLPIWGBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public VPIDNLHTGEH GGUYYFEMCWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DXDKBQXSLAC IWOFGMEAMGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color VZIXVMREIXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode DMQIKWMOUJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double TDWOVJHBXTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool TKIWGVKZGMX;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7294F20", Offset = "0x7293D20", VA = "0x187294F20")]
		public LFPGYMTHYUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x72945B0", Offset = "0x72933B0", VA = "0x1872945B0")]
		public static LFPGYMTHYUP Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7294AC0", Offset = "0x72938C0", VA = "0x187294AC0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
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
	public class EECTGHVLDRV : SMHNIHEYMTG
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class BLFBRGQSUPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public JEGPMPFQLBY DSTQIKJKEHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader JVLHDBRZGEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<JFFXEQBTROH> JNYRQJZXYCC;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public BLFBRGQSUPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7288CA0", Offset = "0x7287AA0", VA = "0x187288CA0")]
			internal JFFXEQBTROH QYZNXWGJMLI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<JFFXEQBTROH> ANJQXLIWZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> YLLSJGCEVSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> SQQZORYMDVQ;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public EECTGHVLDRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x728A000", Offset = "0x7288E00", VA = "0x18728A000")]
		public static EECTGHVLDRV Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x728A3C0", Offset = "0x72891C0", VA = "0x18728A3C0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class OEOAPTMWLBZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, YYGZPHKJGIG> ILJNMZSZFUC;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IIXWMORVNJX DGWYSJXWMTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, AHNEHECEPNV> WSJQAWZBAXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken FILKDLKQHBK;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7296230", Offset = "0x7295030", VA = "0x187296230")]
		public static YYGZPHKJGIG OZEQMFTGXOJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7295BB0", Offset = "0x72949B0", VA = "0x187295BB0")]
		public static AHNEHECEPNV HHTSCDMTEGF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public OEOAPTMWLBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7297540", Offset = "0x7296340", VA = "0x187297540")]
		public OEOAPTMWLBZ(OEOAPTMWLBZ a, [Optional] JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x72963C0", Offset = "0x72951C0", VA = "0x1872963C0")]
		public void TZRNPGRICOW(JEGPMPFQLBY a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7295CA0", Offset = "0x7294AA0", VA = "0x187295CA0")]
		public void HJKWAYTQXDB(string a, AHNEHECEPNV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7295AC0", Offset = "0x72948C0", VA = "0x187295AC0")]
		private void DKCVEPSUPWV(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7296170", Offset = "0x7294F70", VA = "0x187296170")]
		private void KWFZSUBROGX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7296670", Offset = "0x7295470", VA = "0x187296670")]
		private void VSJBQEKOXTP(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7296730", Offset = "0x7295530", VA = "0x187296730")]
		internal static Dictionary<string, AHNEHECEPNV> XXJTMVSQNOQ(JEGPMPFQLBY a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7295DF0", Offset = "0x7294BF0", VA = "0x187295DF0", Slot = "4")]
		public virtual void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class JEGPMPFQLBY : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class LACTLWAXKYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public JEGPMPFQLBY DSTQIKJKEHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader WOEJMCIQHJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<GMQLUKDHWUE> JNYRQJZXYCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<SBMUZBVSHME> JODYNQTVHNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<YAMSYOBWLZO> JNODVWMDFFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<MXBDDHKZXEM> JNTKTDGAOQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<XUUFJULOTEV> JOTTFLBNJVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<WRMHZHADUQH> JOZACRVKTGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<LFPGYMTHYUP> JOJFKXNSQYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<EECTGHVLDRV> JOOMIEHQAKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<ITZFJUYYDSP> JMIOMHWTAPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> JMNVJOQQKAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<SWPQGJPBGRA> XRCCHAZLCCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<RSJDRJPKBBI> XQWVJUFNSRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<VEFCIGNAVSV> XRMQBONFUZH;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LACTLWAXKYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x72943B0", Offset = "0x72931B0", VA = "0x1872943B0")]
			internal GMQLUKDHWUE QYZNXWGJMLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x72943C0", Offset = "0x72931C0", VA = "0x1872943C0")]
			internal SBMUZBVSHME QZEUVDAGVWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7294390", Offset = "0x7293190", VA = "0x187294390")]
			internal YAMSYOBWLZO QYPADISOTOQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x72943A0", Offset = "0x72931A0", VA = "0x1872943A0")]
			internal MXBDDHKZXEM QYUHAPMMCZZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x72943F0", Offset = "0x72931F0", VA = "0x1872943F0")]
			internal XUUFJULOTEV QZUPMXHYYES()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7294400", Offset = "0x7293200", VA = "0x187294400")]
			internal WRMHZHADUQH QZZWKEBWHQB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x72943D0", Offset = "0x72931D0", VA = "0x1872943D0")]
			internal LFPGYMTHYUP QZKBSJUEFIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x72943E0", Offset = "0x72931E0", VA = "0x1872943E0")]
			internal EECTGHVLDRV QZPIPQOBOTJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7294370", Offset = "0x7293170", VA = "0x187294370")]
			internal ITZFJUYYDSP QXJKTUDEOYO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7294380", Offset = "0x7293180", VA = "0x187294380")]
			internal Sampler QXORRAXBYJX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7294420", Offset = "0x7293220", VA = "0x187294420")]
			internal SWPQGJPBGRA WUMANEVPLXJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7294410", Offset = "0x7293210", VA = "0x187294410")]
			internal RSJDRJPKBBI WUGTPYBSCMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x72945A0", Offset = "0x72933A0", VA = "0x1872945A0")]
			internal VEFCIGNAVSV WUWOHSJKEUB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> DBCPQRMVAGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> VZMEGMXPIIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<GMQLUKDHWUE> AXVSYNLUPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<SBMUZBVSHME> CIGHRSVWNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KAPAMLNTHTX KAPAMLNTHTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<YAMSYOBWLZO> ANRPUQZAYPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<MXBDDHKZXEM> ORIVBTSXKWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<XUUFJULOTEV> GYRSQAQBQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<WRMHZHADUQH> HILOLQADXBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<LFPGYMTHYUP> GHARPFDOHQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<EECTGHVLDRV> WDIMIHFGOSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<ITZFJUYYDSP> AZGHWZTTDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> XDUCOFMJSCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MBNBZIRCBIE CPTAAYQHSZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<SWPQGJPBGRA> XZLEQLFLNEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<RSJDRJPKBBI> VEZOSKVSUWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<VEFCIGNAVSV> NLTCUDPXNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<XKBVQIVWIBE> KUCSTBKOYDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool LVLIPYIWKUW;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7290990", Offset = "0x728F790", VA = "0x187290990")]
		public JEGPMPFQLBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x72908F0", Offset = "0x728F6F0", VA = "0x1872908F0")]
		public SWPQGJPBGRA RDJQMSLKDUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x728DEF0", Offset = "0x728CCF0", VA = "0x18728DEF0")]
		public static JEGPMPFQLBY Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x728ED40", Offset = "0x728DB40", VA = "0x18728ED40")]
		public void HPFTFJWMZQX(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class SWPQGJPBGRA : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<ZFFKPKWELUO> AZGHWZTTDHK;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public SWPQGJPBGRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x729A6E0", Offset = "0x72994E0", VA = "0x18729A6E0")]
		public static SWPQGJPBGRA Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x729A860", Offset = "0x7299660", VA = "0x18729A860", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class VEFCIGNAVSV : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public RLRGXDMETCI QJWUYDOCQXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TSECXPZEUJP HISLEUQOINI;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public VEFCIGNAVSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x729C600", Offset = "0x729B400", VA = "0x18729C600")]
		public static VEFCIGNAVSV Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x729C7D0", Offset = "0x729B5D0", VA = "0x18729C7D0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class LUXRPNHOCXI : XKBVQIVWIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public LUXRPNHOCXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7294F90", Offset = "0x7293D90", VA = "0x187294F90", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class XKBVQIVWIBE : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string NUVHIPTYJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color KCGAXFZOEXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string BZOQAXHJQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float BHETCPJTGGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float KDDGGWRIJUI;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public XKBVQIVWIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x729DAF0", Offset = "0x729C8F0", VA = "0x18729DAF0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class VBXSVYVKTNS : XKBVQIVWIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7289770", VA = "0x18728A970")]
		public VBXSVYVKTNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7294F90", Offset = "0x7293D90", VA = "0x187294F90", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class JVVGRQUHULY : XKBVQIVWIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float BKLYIRHBQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float OVWCECHWJUY;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72931F0", Offset = "0x7291FF0", VA = "0x1872931F0")]
		public JVVGRQUHULY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7292EF0", Offset = "0x7291CF0", VA = "0x187292EF0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface WSWDNOOKWJX
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HVYJRVZIQHQ(JEGPMPFQLBY a, UNKMCRGDQXN b, [Out] IWZSBNLNSDO c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface AHNEHECEPNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AHNEHECEPNV Clone(JEGPMPFQLBY root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class YYGZPHKJGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string ZZMPZIBBTLZ;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected YYGZPHKJGIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class RANUGASSFXL : AHNEHECEPNV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty CBAKQWZNWQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x72981C0", Offset = "0x7296FC0", VA = "0x1872981C0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RANUGASSFXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class IIXWMORVNJX : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x728C580", Offset = "0x728B380", VA = "0x18728C580", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public IIXWMORVNJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SVSWUSHVYZB : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color COXROOUOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public DXDKBQXSLAC NYSDWGLFCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color DZEFELOFSOK;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x729A670", Offset = "0x7299470", VA = "0x18729A670")]
		public SVSWUSHVYZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x729A170", Offset = "0x7298F70", VA = "0x18729A170")]
		public static SVSWUSHVYZB Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x729A410", Offset = "0x7299210", VA = "0x18729A410", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class XQXBXVDXOPB : DXDKBQXSLAC
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string EFNMFDRQNJB = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double XQMDWVHUFRR;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x729D140", Offset = "0x729BF40", VA = "0x18729D140")]
		public XQXBXVDXOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x729DD70", Offset = "0x729CB70", VA = "0x18729DD70")]
		public new static XQXBXVDXOPB Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x729E060", Offset = "0x729CE60", VA = "0x18729E060", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class VPIDNLHTGEH : DXDKBQXSLAC
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string TYWAMFFILCK = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double WEUZUDTJBMG;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x729D140", Offset = "0x729BF40", VA = "0x18729D140")]
		public VPIDNLHTGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x729CD90", Offset = "0x729BB90", VA = "0x18729CD90")]
		public new static VPIDNLHTGEH Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x729D080", Offset = "0x729BE80", VA = "0x18729D080", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class GZCVLCDLAES : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color LQDBWOAGHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public DXDKBQXSLAC VWBRUJENUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double ZVYSACVZKYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double SNSCQESPGVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public DXDKBQXSLAC PUEQWMETWWD;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x728C2D0", Offset = "0x728B0D0", VA = "0x18728C2D0")]
		public GZCVLCDLAES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x728BCD0", Offset = "0x728AAD0", VA = "0x18728BCD0")]
		public static GZCVLCDLAES Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x728C040", Offset = "0x728AE40", VA = "0x18728C040", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class JFFXEQBTROH : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class UHRWADSOIRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader JVLHDBRZGEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public JEGPMPFQLBY DSTQIKJKEHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<NMUUAPMAXVD> JNYRQJZXYCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<NMUUAPMAXVD> JNODVWMDFFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, NMUUAPMAXVD>> JODYNQTVHNL;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UHRWADSOIRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x729C010", Offset = "0x729AE10", VA = "0x18729C010")]
			internal NMUUAPMAXVD QYZNXWGJMLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x729C0E0", Offset = "0x729AEE0", VA = "0x18729C0E0")]
			internal Dictionary<string, NMUUAPMAXVD> QZEUVDAGVWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x729BF40", Offset = "0x729AD40", VA = "0x18729BF40")]
			internal NMUUAPMAXVD QYPADISOTOQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, NMUUAPMAXVD> GLQZLVQSHUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NMUUAPMAXVD VTFBNNGXLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public JBMWHHJOXTB WJLHLFEXSUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode EFYEADXIPJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, NMUUAPMAXVD>> JJPYSBKWORR;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7292370", Offset = "0x7291170", VA = "0x187292370")]
		public JFFXEQBTROH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7291CD0", Offset = "0x7290AD0", VA = "0x187291CD0")]
		public JFFXEQBTROH(JFFXEQBTROH a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7291AF0", Offset = "0x72908F0", VA = "0x187291AF0")]
		public static int[] PPMGFRQIEXX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x72916F0", Offset = "0x72904F0", VA = "0x1872916F0")]
		public static int[] HTHJOEQITHR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x72918C0", Offset = "0x72906C0", VA = "0x1872918C0")]
		public static int[] ORKMXMIGMWV(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7290EC0", Offset = "0x728FCC0", VA = "0x187290EC0")]
		public static int[] HEBBLJGXDNZ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7291C20", Offset = "0x7290A20", VA = "0x187291C20")]
		public static int[] WPKXQIFRVBI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7291850", Offset = "0x7290650", VA = "0x187291850")]
		public static int[] KNBGUJHJVVZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7291B90", Offset = "0x7290990", VA = "0x187291B90")]
		public static int[] PYPGXAZPTFN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7291A80", Offset = "0x7290880", VA = "0x187291A80")]
		public static int[] PNIJZMHPULG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x72909E0", Offset = "0x728F7E0", VA = "0x1872909E0")]
		public static int[] BYQWLLXUGEQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7290A70", Offset = "0x728F870", VA = "0x187290A70")]
		public static JFFXEQBTROH Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7291100", Offset = "0x728FF00", VA = "0x187291100", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class CNZPMGKIJXM
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] OLREMYLJRRX;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] MWRAFFHLWBE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] HGKZZJYCSTF;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] GMPGHTEMVVL;
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
	public class ITZFJUYYDSP : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool TTPXMPEPTAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public LYKGRISWJPD FHNFRVJRCZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<ZFFKPKWELUO> GMWEVQQOKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public SMSTVAHXERJ RSJDRJPKBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public UTLIDXBRNWW IHOSDKCHKFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MUTJXJIJLNJ HAOFMVRAQAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion BSVMTQBEROR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 XQMDWVHUFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 ZVBOMHFYTHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> YLLSJGCEVSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public PHBLARULNQA DLFZIEZSJAF;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x728DB30", Offset = "0x728C930", VA = "0x18728DB30")]
		public ITZFJUYYDSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x728C5F0", Offset = "0x728B3F0", VA = "0x18728C5F0")]
		public static ITZFJUYYDSP Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x728CF30", Offset = "0x728BD30", VA = "0x18728CF30", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode LDJVOBFBEYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode RTNLXVOUCWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode KNDDDZOLNQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode KMXWGSUOEER;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x729AF90", Offset = "0x7299D90", VA = "0x18729AF90")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x729AAD0", Offset = "0x72998D0", VA = "0x18729AAD0")]
		public static Sampler Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x729ADA0", Offset = "0x7299BA0", VA = "0x18729ADA0", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
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
	public class RSJDRJPKBBI : SMHNIHEYMTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NMUUAPMAXVD CRKCWTDAYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public ZFFKPKWELUO RFZAMVCBWIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<ZFFKPKWELUO> KHCYAEDLYWS;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7298A60", Offset = "0x7297860", VA = "0x187298A60")]
		public RSJDRJPKBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x72983F0", Offset = "0x72971F0", VA = "0x1872983F0")]
		public static RSJDRJPKBBI Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7298750", Offset = "0x7297550", VA = "0x187298750", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class DXDKBQXSLAC : OEOAPTMWLBZ
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string XUFXGIRNZKV = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string ZRXBHMTVKXX = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OOCAYDTODPB XYUGDAJCILX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int OLREMYLJRRX;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7289FB0", Offset = "0x7288DB0", VA = "0x187289FB0")]
		public DXDKBQXSLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7289EC0", Offset = "0x7288CC0", VA = "0x187289EC0")]
		public DXDKBQXSLAC(DXDKBQXSLAC a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7289BE0", Offset = "0x72889E0", VA = "0x187289BE0")]
		public static DXDKBQXSLAC Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7289E60", Offset = "0x7288C60", VA = "0x187289E60", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7289B10", Offset = "0x7288910", VA = "0x187289B10")]
		public void DOMQREMZKIS(JsonWriter a)
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
	public class KCKXVZRINGX
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double UBTCDTWZTCX;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double ITMUVYQPXDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double OUYAFHFRDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double UTYAVJTGSGA;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x72942F0", Offset = "0x72930F0", VA = "0x1872942F0")]
		public KCKXVZRINGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7293E30", Offset = "0x7292C30", VA = "0x187293E30")]
		public static KCKXVZRINGX Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7294080", Offset = "0x7292E80", VA = "0x187294080")]
		public void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class JFSWOCZBSDJ : SMHNIHEYMTG
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color BWQZWHJLCNC;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double BEDHTUEWYWG;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double ZVERILQBKXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType QHIGGIBDJUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color MWRAFFHLWBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double FLDATAXDAXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double HADKHETFKSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KCKXVZRINGX KCKXVZRINGX;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7292E30", Offset = "0x7291C30", VA = "0x187292E30")]
		public JFSWOCZBSDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7292D00", Offset = "0x7291B00", VA = "0x187292D00")]
		public JFSWOCZBSDJ(JFSWOCZBSDJ a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7292530", Offset = "0x7291330", VA = "0x187292530")]
		public static JFSWOCZBSDJ Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7292410", Offset = "0x7291210", VA = "0x187292410")]
		public static JFSWOCZBSDJ Deserialize(JEGPMPFQLBY root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7292920", Offset = "0x7291720", VA = "0x187292920", Slot = "4")]
		public override void HPFTFJWMZQX(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class SJEREOQDPMN : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<XKBVQIVWIBE> SMARFGGVGDA;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public SJEREOQDPMN(IList<XKBVQIVWIBE> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7299550", Offset = "0x7298350", VA = "0x187299550", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x72994E0", Offset = "0x72982E0", VA = "0x1872994E0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class FMMGMGLOOOF : AHNEHECEPNV, WSWDNOOKWJX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<JFSWOCZBSDJ> KUCSTBKOYDQ;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x728BC50", Offset = "0x728AA50", VA = "0x18728BC50")]
		public FMMGMGLOOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x728AD90", Offset = "0x7289B90", VA = "0x18728AD90", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x728B6C0", Offset = "0x728A4C0", VA = "0x18728B6C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x728B410", Offset = "0x728A210", VA = "0x18728B410")]
		private static string[] IKGVXRAMVDX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x728B7B0", Offset = "0x728A5B0", VA = "0x18728B7B0")]
		private static IWZSBNLNSDO.ImportValuesConversion VWOSBMEXKIJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x728B020", Offset = "0x7289E20", VA = "0x18728B020", Slot = "6")]
		public bool HVYJRVZIQHQ(JEGPMPFQLBY a, UNKMCRGDQXN b, [Out] IWZSBNLNSDO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class CNOOSLFBOGO : SPBTGZCBRBG<JFSWOCZBSDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override JFSWOCZBSDJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x7289310", Offset = "0x7288110", VA = "0x187289310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x72892D0", Offset = "0x72880D0", VA = "0x1872892D0")]
		public CNOOSLFBOGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x72891F0", Offset = "0x7287FF0", VA = "0x1872891F0")]
		public static CNOOSLFBOGO Deserialize(JEGPMPFQLBY root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class HBVIVRGHPQZ : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public CNOOSLFBOGO PHBLARULNQA;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public HBVIVRGHPQZ(CNOOSLFBOGO a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x728C4C0", Offset = "0x728B2C0", VA = "0x18728C4C0")]
		public HBVIVRGHPQZ(int a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x728C340", Offset = "0x728B140", VA = "0x18728C340", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x728C3C0", Offset = "0x728B1C0", VA = "0x18728C3C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class WKQEDLXBUPK : YYGZPHKJGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x729D690", Offset = "0x729C490", VA = "0x18729D690")]
		public WKQEDLXBUPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x729D1A0", Offset = "0x729BFA0", VA = "0x18729D1A0", Slot = "4")]
		public override AHNEHECEPNV Deserialize(JEGPMPFQLBY root, JProperty extensionToken)
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
