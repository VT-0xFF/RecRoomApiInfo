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
	public class KHR_animation_pointer : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object KHMIBROEHYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string RTRQCNKALUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string KLSEKEDSFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public DPIOZUENGTA WVOEKNHZYBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer BKGDNUJRDUV;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7085C50", Offset = "0x7085050", VA = "0x187085C50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7085BA0", Offset = "0x7084FA0", VA = "0x187085BA0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class UMCATIIQJTB
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 JBCAYBDJKBG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 TTKKSMMVMFV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion XQGIQNYNNRJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool YXDAAZWNIJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7093F70", Offset = "0x7093370", VA = "0x187093F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7095060", Offset = "0x7094460", VA = "0x187095060")]
		public static void ZUGSCKUQFET(this TDRUPTSJFYC a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7094030", Offset = "0x7093430", VA = "0x187094030")]
		public static void SYYCKIPYRVT(this TDRUPTSJFYC a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7093BA0", Offset = "0x7092FA0", VA = "0x187093BA0")]
		public static void RMSVUYYCERS(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7092AB0", Offset = "0x7091EB0", VA = "0x187092AB0")]
		public static GLTF.Math.Vector4 JAJZEQNGQIE(this PVDHHZPWCMN a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7092780", Offset = "0x7091B80", VA = "0x187092780")]
		public static UnityEngine.Quaternion HUIRIWCDMJZ(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7092900", Offset = "0x7091D00", VA = "0x187092900")]
		public static UnityEngine.Quaternion HUIRIWCDMJZ(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7094F20", Offset = "0x7094320", VA = "0x187094F20")]
		public static GLTF.Math.Quaternion XXQVQNYVXOZ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7093200", Offset = "0x7092600", VA = "0x187093200")]
		public static Matrix4x4 KSESDBEFCPM(this PVDHHZPWCMN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7092DC0", Offset = "0x70921C0", VA = "0x187092DC0")]
		public static Matrix4x4 KSESDBEFCPM(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7094BE0", Offset = "0x7093FE0", VA = "0x187094BE0")]
		public static PVDHHZPWCMN VQDCJHYAQRG(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7092590", Offset = "0x7091990", VA = "0x187092590")]
		public static UnityEngine.Vector3 FQSMJZOALVB(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70926B0", Offset = "0x7091AB0", VA = "0x1870926B0")]
		public static UnityEngine.Vector3 FQSMJZOALVB(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70923A0", Offset = "0x70917A0", VA = "0x1870923A0")]
		public static GLTF.Math.Vector3 DIXNDMHCYSJ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70924D0", Offset = "0x70918D0", VA = "0x1870924D0")]
		public static GLTF.Math.Vector3 DSZYGUWYVSA(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10868B0", Offset = "0x1085CB0", VA = "0x1810868B0")]
		public static GLTF.Math.Vector4 DTLLANCXMYP(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7094530", Offset = "0x7093930", VA = "0x187094530")]
		public static Matrix4x4 TKHGOPVJIJV(this PVDHHZPWCMN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70947F0", Offset = "0x7093BF0", VA = "0x1870947F0")]
		public static Matrix4x4 TKHGOPVJIJV(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7091DE0", Offset = "0x70911E0", VA = "0x187091DE0")]
		public static PVDHHZPWCMN AGOKFJQKKQB(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7092DA0", Offset = "0x70921A0", VA = "0x187092DA0")]
		public static UnityEngine.Vector2 JSXMYITLAVJ(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7092DA0", Offset = "0x70921A0", VA = "0x187092DA0")]
		public static UnityEngine.Vector2 JSXMYITLAVJ(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7092CD0", Offset = "0x70920D0", VA = "0x187092CD0")]
		public static void JSXMYITLAVJ(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7094A90", Offset = "0x7093E90", VA = "0x187094A90")]
		public static UnityEngine.Vector3 UXIBELXWKPY(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA06B0", Offset = "0x1A9FAB0", VA = "0x181AA06B0")]
		public static UnityEngine.Vector3 UXIBELXWKPY(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7094AF0", Offset = "0x7093EF0", VA = "0x187094AF0")]
		public static void UXIBELXWKPY(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10868B0", Offset = "0x1085CB0", VA = "0x1810868B0")]
		public static UnityEngine.Vector4 OQEKSRBYWKF(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10868B0", Offset = "0x1085CB0", VA = "0x1810868B0")]
		public static UnityEngine.Vector4 OQEKSRBYWKF(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7093940", Offset = "0x7092D40", VA = "0x187093940")]
		public static UnityEngine.Vector4[] OQEKSRBYWKF(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7093830", Offset = "0x7092C30", VA = "0x187093830")]
		public static void OQEKSRBYWKF(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7092030", Offset = "0x7091430", VA = "0x187092030")]
		public static UnityEngine.Color CFJLZFBOJGL(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70920D0", Offset = "0x70914D0", VA = "0x1870920D0")]
		public static void CFJLZFBOJGL(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7092030", Offset = "0x7091430", VA = "0x187092030")]
		public static UnityEngine.Color CFJLZFBOJGL(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x10868B0", Offset = "0x1085CB0", VA = "0x1810868B0")]
		public static UnityEngine.Color NVHVARWTGTI(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7093580", Offset = "0x7092980", VA = "0x187093580")]
		public static void NVHVARWTGTI(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10868B0", Offset = "0x1085CB0", VA = "0x1810868B0")]
		public static UnityEngine.Color NVHVARWTGTI(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7094000", Offset = "0x7093400", VA = "0x187094000")]
		public static GLTF.Math.Color SREQLMPGQLW(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7092A30", Offset = "0x7091E30", VA = "0x187092A30")]
		public static GLTF.Math.Color HXSYTMGQKVR(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7091FB0", Offset = "0x70913B0", VA = "0x187091FB0")]
		public static GLTF.Math.Color ASPXSQBIOMD(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7092280", Offset = "0x7091680", VA = "0x187092280")]
		public static UnityEngine.Color[] CZHMXVLZLAG(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7092510", Offset = "0x7091910", VA = "0x187092510")]
		public static int[] DWYNOXQWXIV(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7091D30", Offset = "0x7091130", VA = "0x187091D30")]
		public static UnityEngine.Vector2[] AADMOIOTFGW(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7093A40", Offset = "0x7092E40", VA = "0x187093A40")]
		public static void PMQKTYWYUMR(MORBBRKLNFX a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7093420", Offset = "0x7092820", VA = "0x187093420")]
		public static UnityEngine.Vector3[] NOPXXOLVANF(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7093690", Offset = "0x7092A90", VA = "0x187093690")]
		public static UnityEngine.Vector4[] OEVMVBVONLU(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7092210", Offset = "0x7091610", VA = "0x187092210")]
		public static void CJHROQECQSF(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7094A60", Offset = "0x7093E60", VA = "0x187094A60")]
		public static UnityEngine.Quaternion UNYDSWXSZNP(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MORBBRKLNFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ZEVJADLYGLG ZEVJADLYGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray VOMYZJJOMSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x708C1A0", Offset = "0x708B5A0", VA = "0x18708C1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> LBDGZMPWRMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBFA8A0", Offset = "0xBF9CA0", VA = "0x180BFA8A0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF2570", Offset = "0xCF1970", VA = "0x180CF2570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint NPIUMFXISMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA9DC0", Offset = "0xAA91C0", VA = "0x180AA9DC0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AC0", Offset = "0xAA8EC0", VA = "0x180AA9AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x708C1B0", Offset = "0x708B5B0", VA = "0x18708C1B0")]
		public MORBBRKLNFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x707D9B0", Offset = "0x707CDB0", VA = "0x18707D9B0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x707DA10", Offset = "0x707CE10", VA = "0x18707DA10")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KNXHMXLPVJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class WBUSACGRBMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> UMBRWJOUVOR;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public WBUSACGRBMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7096B10", Offset = "0x7095F10", VA = "0x187096B10")]
			internal int? FYXYXCVQCWO(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7096A80", Offset = "0x7095E80", VA = "0x187096A80")]
			internal int? DNRFEGTFGEZ(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7096B90", Offset = "0x7095F90", VA = "0x187096B90")]
			internal bool WJLMKTXZCLT(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7089250", Offset = "0x7088650", VA = "0x187089250")]
		private static void EYIJMJWKFQN(NumericArray a, MORBBRKLNFX b, MORBBRKLNFX c, MORBBRKLNFX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70897C0", Offset = "0x7088BC0", VA = "0x1870897C0")]
		public static void GCMOSNZTJPM(Dictionary<string, MORBBRKLNFX> a, Dictionary<string, (MORBBRKLNFX sparseIndices, MORBBRKLNFX sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x708B300", Offset = "0x708A700", VA = "0x18708B300")]
		public static void KGOEYOEYQNU(Dictionary<string, MORBBRKLNFX> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x708B200", Offset = "0x708A600", VA = "0x18708B200")]
		public static void JMNMDOCALLX(MORBBRKLNFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x708AC70", Offset = "0x708A070", VA = "0x18708AC70")]
		public static void JIVNOMOMQEZ(Dictionary<string, List<MORBBRKLNFX>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x708AB40", Offset = "0x7089F40", VA = "0x18708AB40")]
		private static void HDKQDOGYIVL(MORBBRKLNFX a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x708AA80", Offset = "0x7089E80", VA = "0x18708AA80")]
		internal static void HDKQDOGYIVL(UGGVBKPYRYB a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x708B7E0", Offset = "0x708ABE0", VA = "0x18708B7E0")]
		public static EUFSUYWPBXB OHTFRIPXRCN(IEnumerable<EUFSUYWPBXB> a)
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
			[Cpp2IlInjected.Address(RVA = "0xC9E6F0", Offset = "0xC9DAF0", VA = "0x180C9E6F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2DF82B0", Offset = "0x2DF76B0", VA = "0x182DF82B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2DF82C0", Offset = "0x2DF76C0", VA = "0x182DF82C0")]
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
	public class JPXYTDOCWXO
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint APOAKXWFRWN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint DYTVLHXFTHN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint FGUIDRMTEMP;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7083A70", Offset = "0x7082E70", VA = "0x187083A70")]
		public static void TTDGAPQVUUT(Stream a, [Out] WWOZGFPEXAT b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7083750", Offset = "0x7082B50", VA = "0x187083750")]
		public static ChunkInfo KBQECGBMMYX(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7083C30", Offset = "0x7083030", VA = "0x187083C30")]
		public static GLBHeader YSFOHIYYCAZ(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x70833F0", Offset = "0x70827F0", VA = "0x1870833F0")]
		public static bool HVRRCJBDDIJ(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7083280", Offset = "0x7082680", VA = "0x187083280")]
		public static ChunkInfo AFQSHRNPUQS(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x70834B0", Offset = "0x70828B0", VA = "0x1870834B0")]
		private static void IGMKASIDKEY(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x70839E0", Offset = "0x7082DE0", VA = "0x1870839E0")]
		private static uint ROCWZMOFUFZ(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BUVFBYLBULO
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
		public PathElement MWOQZRVLHVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5C90", Offset = "0xAA5090", VA = "0x180AA5C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int RAJNLHVHZCG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB2FE10", Offset = "0xB2F210", VA = "0x180B2FE10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB2FE20", Offset = "0xB2F220", VA = "0x180B2FE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string WMGQBEGPZUN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IXKAAUMFSNW
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE730", Offset = "0xAADB30", VA = "0x180AAE730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAE890", Offset = "0xAADC90", VA = "0x180AAE890")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BUVFBYLBULO QKRTCIBLIHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x707C260", Offset = "0x707B660", VA = "0x18707C260")]
		public string LJYTHFZDQKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x707C4C0", Offset = "0x707B8C0", VA = "0x18707C4C0")]
		public BUVFBYLBULO QLFUFNCLSYI(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x707C4E0", Offset = "0x707B8E0", VA = "0x18707C4E0")]
		private BUVFBYLBULO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x707C540", Offset = "0x707B940", VA = "0x18707C540")]
		public BUVFBYLBULO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4063F30", Offset = "0x4063330", VA = "0x184063F30")]
		[CompilerGenerated]
		internal static string WUPPGCCHHGM(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x707C220", Offset = "0x707B620", VA = "0x18707C220")]
		[CompilerGenerated]
		internal static bool BIDKLQXRZUL([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x707C2E0", Offset = "0x707B6E0", VA = "0x18707C2E0")]
		[CompilerGenerated]
		internal static BUVFBYLBULO QBPAHFBSBSF(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MYORWENTSDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x708C330", Offset = "0x708B730", VA = "0x18708C330")]
		public static int[] JEJVIRIKOPX(this WWOZGFPEXAT a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x708C1E0", Offset = "0x708B5E0", VA = "0x18708C1E0")]
		public static int[] FTYBUCHZMID(this WWOZGFPEXAT a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class NXFNMJFTTCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x708D6D0", Offset = "0x708CAD0", VA = "0x18708D6D0")]
		public static uint RLWXXPCQKBM(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream JNTXXAGMNVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long CABJFZIDKAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long IJQPLBOTVEQ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7090F80", Offset = "0x7090380", VA = "0x187090F80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7090FC0", Offset = "0x70903C0", VA = "0x187090FC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7090FC0", Offset = "0x70903C0", VA = "0x187090FC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7090FE0", Offset = "0x70903E0", VA = "0x187090FE0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7091000", Offset = "0x7090400", VA = "0x187091000", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7091020", Offset = "0x7090420", VA = "0x187091020", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7090D10", Offset = "0x7090110", VA = "0x187090D10")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7090B60", Offset = "0x708FF60", VA = "0x187090B60", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7090C30", Offset = "0x7090030", VA = "0x187090C30", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7090C90", Offset = "0x7090090", VA = "0x187090C90", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7090BA0", Offset = "0x708FFA0", VA = "0x187090BA0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7090CD0", Offset = "0x70900D0", VA = "0x187090CD0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7090AD0", Offset = "0x708FED0", VA = "0x187090AD0")]
		private void BMSSQYDHCQN()
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
		public static Color TBIHHJTITQB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x707D140", Offset = "0x707C540", VA = "0x18707D140")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color NXDZEMJTXTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x707D080", Offset = "0x707C480", VA = "0x18707D080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color ZPJIXYUVMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x707D160", Offset = "0x707C560", VA = "0x18707D160")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C820", VA = "0x182B2D420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC20", Offset = "0x2B6E020", VA = "0x182B6EC20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC30", Offset = "0x2B6E030", VA = "0x182B6EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD10", Offset = "0x28EA110", VA = "0x1828EAD10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2FEB2E0", Offset = "0x2FEA6E0", VA = "0x182FEB2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1246D40", Offset = "0x1246140", VA = "0x181246D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1246D50", Offset = "0x1246150", VA = "0x181246D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28AC580", VA = "0x1828AD180")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x707CE80", Offset = "0x707C280", VA = "0x18707CE80", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x707CF30", Offset = "0x707C330", VA = "0x18707CF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x707CFD0", Offset = "0x707C3D0", VA = "0x18707CFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x707D090", Offset = "0x707C490", VA = "0x18707D090")]
		public static bool IMKWXPVUUOB(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PVDHHZPWCMN : IEquatable<PVDHHZPWCMN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly PVDHHZPWCMN SUUGMWEDNZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] GOHFDUWPKYA;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DEIMTUUEYXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x708EE50", Offset = "0x708E250", VA = "0x18708EE50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x708EF40", Offset = "0x708E340", VA = "0x18708EF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float XFZPICFRPHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x708EFD0", Offset = "0x708E3D0", VA = "0x18708EFD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x708F0C0", Offset = "0x708E4C0", VA = "0x18708F0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float QFSYDXLJSLT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x708F1B0", Offset = "0x708E5B0", VA = "0x18708F1B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x708E8E0", Offset = "0x708DCE0", VA = "0x18708E8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float IIKWTMUWAWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x708EDF0", Offset = "0x708E1F0", VA = "0x18708EDF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x708ED60", Offset = "0x708E160", VA = "0x18708ED60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float DENTRBOCIIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x708EEB0", Offset = "0x708E2B0", VA = "0x18708EEB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x708EFA0", Offset = "0x708E3A0", VA = "0x18708EFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float XGPJZWNJRPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x708F000", Offset = "0x708E400", VA = "0x18708F000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x708F0F0", Offset = "0x708E4F0", VA = "0x18708F0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float QFDDMDDRQDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x708F180", Offset = "0x708E580", VA = "0x18708F180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x708E8B0", Offset = "0x708DCB0", VA = "0x18708E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float IIFPWGAYRLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x708ED90", Offset = "0x708E190", VA = "0x18708ED90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x708ED00", Offset = "0x708E100", VA = "0x18708ED00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float DETAOIHZRUB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x708EE80", Offset = "0x708E280", VA = "0x18708EE80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x708EF70", Offset = "0x708E370", VA = "0x18708EF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float XGKDCPTMIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x708F030", Offset = "0x708E430", VA = "0x18708F030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x708F120", Offset = "0x708E520", VA = "0x18708F120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float QFIKJJXOZPB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x708F150", Offset = "0x708E550", VA = "0x18708F150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x708E880", Offset = "0x708DC80", VA = "0x18708E880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float IIAIYZHBIAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x708EDC0", Offset = "0x708E1C0", VA = "0x18708EDC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x708ED30", Offset = "0x708E130", VA = "0x18708ED30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float DDIEHMYSDSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x708EEE0", Offset = "0x708E2E0", VA = "0x18708EEE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x708EF10", Offset = "0x708E310", VA = "0x18708EF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float XFJUQHXZMZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x708F060", Offset = "0x708E460", VA = "0x18708F060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x708F090", Offset = "0x708E490", VA = "0x18708F090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float QGISVRTBUTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x708F1E0", Offset = "0x708E5E0", VA = "0x18708F1E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x708E850", Offset = "0x708DC50", VA = "0x18708E850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float IJLFFUQIWBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x708EE20", Offset = "0x708E220", VA = "0x18708EE20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x708ECD0", Offset = "0x708E0D0", VA = "0x18708ECD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x708F2E0", Offset = "0x708E6E0", VA = "0x18708F2E0")]
		public PVDHHZPWCMN(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x708EA10", Offset = "0x708DE10", VA = "0x18708EA10", Slot = "4")]
		public bool Equals(PVDHHZPWCMN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x708E910", Offset = "0x708DD10", VA = "0x18708E910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE01960", Offset = "0xE00D60", VA = "0x180E01960", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C820", VA = "0x182B2D420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC20", Offset = "0x2B6E020", VA = "0x182B6EC20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC30", Offset = "0x2B6E030", VA = "0x182B6EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD10", Offset = "0x28EA110", VA = "0x1828EAD10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2FEB2E0", Offset = "0x2FEA6E0", VA = "0x182FEB2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1246D40", Offset = "0x1246140", VA = "0x181246D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1246D50", Offset = "0x1246150", VA = "0x181246D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x708FC00", Offset = "0x708F000", VA = "0x18708FC00")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x708F870", Offset = "0x708EC70", VA = "0x18708F870", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x708F990", Offset = "0x708ED90", VA = "0x18708F990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x708FA40", Offset = "0x708EE40", VA = "0x18708FA40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x708FB20", Offset = "0x708EF20", VA = "0x18708FB20")]
		public static bool IMKWXPVUUOB(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C820", VA = "0x182B2D420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC20", Offset = "0x2B6E020", VA = "0x182B6EC20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC30", Offset = "0x2B6E030", VA = "0x182B6EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD6D900", Offset = "0xD6CD00", VA = "0x180D6D900")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70965B0", Offset = "0x70959B0", VA = "0x1870965B0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x70963C0", Offset = "0x70957C0", VA = "0x1870963C0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7096420", Offset = "0x7095820", VA = "0x187096420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7096500", Offset = "0x7095900", VA = "0x187096500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7096550", Offset = "0x7095950", VA = "0x187096550")]
		public static bool IMKWXPVUUOB(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C820", VA = "0x182B2D420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC20", Offset = "0x2B6E020", VA = "0x182B6EC20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC30", Offset = "0x2B6E030", VA = "0x182B6EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD10", Offset = "0x28EA110", VA = "0x1828EAD10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2FEB2E0", Offset = "0x2FEA6E0", VA = "0x182FEB2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7096960", Offset = "0x7095D60", VA = "0x187096960")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x70965D0", Offset = "0x70959D0", VA = "0x1870965D0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x70966B0", Offset = "0x7095AB0", VA = "0x1870966B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7096770", Offset = "0x7095B70", VA = "0x187096770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7096820", Offset = "0x7095C20", VA = "0x187096820")]
		public static bool IMKWXPVUUOB(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C820", VA = "0x182B2D420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC20", Offset = "0x2B6E020", VA = "0x182B6EC20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B6EC30", Offset = "0x2B6E030", VA = "0x182B6EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD10", Offset = "0x28EA110", VA = "0x1828EAD10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FEB2E0", Offset = "0x2FEA6E0", VA = "0x182FEB2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1246D40", Offset = "0x1246140", VA = "0x181246D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1246D50", Offset = "0x1246150", VA = "0x181246D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28AC580", VA = "0x1828AD180")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x707CE80", Offset = "0x707C280", VA = "0x18707CE80", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x70969E0", Offset = "0x7095DE0", VA = "0x1870969E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x707CFD0", Offset = "0x707C3D0", VA = "0x18707CFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class KSBUPBYSNQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x708BC70", Offset = "0x708B070", VA = "0x18708BC70")]
		public static void XJNFZBDMWXO(this JObject a, string b, QVJVKMAODSV c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class NXFNMJFTTCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x708E190", Offset = "0x708D590", VA = "0x18708E190")]
		public static List<string> XVVKINYDRYP(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x708DA90", Offset = "0x708CE90", VA = "0x18708DA90")]
		public static List<double> SKDGEQOKAEX(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x708D230", Offset = "0x708C630", VA = "0x18708D230")]
		public static List<int> OBSKTLQXCZI(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x387DC60", Offset = "0x387D060", VA = "0x18387DC60")]
		public static List<a> EUSKWLRPLRI<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x708DEF0", Offset = "0x708D2F0", VA = "0x18708DEF0")]
		public static QVJVKMAODSV URMZRNLWJEM(this JToken a, WWOZGFPEXAT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x708D0F0", Offset = "0x708C4F0", VA = "0x18708D0F0")]
		public static int LNMSQBYNFYO(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x708C880", Offset = "0x708BC80", VA = "0x18708C880")]
		public static double IXFFFLXBILO(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x708D3F0", Offset = "0x708C7F0", VA = "0x18708D3F0")]
		public static GLTF.Math.Color RKJXAYRJLPF(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x708D820", Offset = "0x708CC20", VA = "0x18708D820")]
		public static GLTF.Math.Color RSZUTAYQWYE(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x708DC50", Offset = "0x708D050", VA = "0x18708DC50")]
		public static GLTF.Math.Color SQVRGXRIWTW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x708CE30", Offset = "0x708C230", VA = "0x18708CE30")]
		public static GLTF.Math.Vector3 KNMFPMTRBGS(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x708C9C0", Offset = "0x708BDC0", VA = "0x18708C9C0")]
		public static GLTF.Math.Vector2 JFGQFKWTAOI(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x708CBD0", Offset = "0x708BFD0", VA = "0x18708CBD0")]
		public static GLTF.Math.Vector3 JFLXCRQQJZR(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x708E340", Offset = "0x708D740", VA = "0x18708E340")]
		public static GLTF.Math.Quaternion YENUZGXHCTA(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x387D650", Offset = "0x387CA50", VA = "0x18387D650")]
		public static Dictionary<string, b> CEFFRXVZNOC<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x387DFB0", Offset = "0x387D3B0", VA = "0x18387DFB0")]
		public static c KYEKCQDKCDU<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public UGGVBKPYRYB bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x707D340", Offset = "0x707C740", VA = "0x18707D340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x707D2C0", Offset = "0x707C6C0", VA = "0x18707D2C0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class FOWNGOZWKUY : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x707D5C0", Offset = "0x707C9C0", VA = "0x18707D5C0")]
		public FOWNGOZWKUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x707D4F0", Offset = "0x707C8F0", VA = "0x18707D4F0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, ZEVJADLYGLG> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x707D180", Offset = "0x707C580", VA = "0x18707D180", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x707D240", Offset = "0x707C640", VA = "0x18707D240")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class JLLVHEIEKOC : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class VKMWSMJNIRA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public WWOZGFPEXAT BRWFJBTAWNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader BNWHYMKNWQN;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VKMWSMJNIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x70962A0", Offset = "0x70956A0", VA = "0x1870962A0")]
			internal ZEVJADLYGLG TVZHDKFKICF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7083230", Offset = "0x7082630", VA = "0x187083230")]
		public JLLVHEIEKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x70830A0", Offset = "0x70824A0", VA = "0x1870830A0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LRSJFEZVPBM MWVUWEOJOXZ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public EXT_texture_exr(LRSJFEZVPBM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x707D390", Offset = "0x707C790", VA = "0x18707D390", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x707D400", Offset = "0x707C800", VA = "0x18707D400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HILHADQTTVR : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x707DDF0", Offset = "0x707D1F0", VA = "0x18707DDF0")]
		public HILHADQTTVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x707DCD0", Offset = "0x707D0D0", VA = "0x18707DCD0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
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
	public class AudioEmitterId : BIQNACOUGNX<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x707BC80", Offset = "0x707B080", VA = "0x18707BC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x707BC40", Offset = "0x707B040", VA = "0x18707BC40")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : BIQNACOUGNX<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x707BE10", Offset = "0x707B210", VA = "0x18707BE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x707BDD0", Offset = "0x707B1D0", VA = "0x18707BDD0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : BIQNACOUGNX<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x707BAF0", Offset = "0x707AEF0", VA = "0x18707BAF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x707BAB0", Offset = "0x707AEB0", VA = "0x18707BAB0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x707B9D0", Offset = "0x707ADD0", VA = "0x18707B9D0")]
		public static AudioDataId Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70858C0", Offset = "0x7084CC0", VA = "0x1870858C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x70854C0", Offset = "0x70848C0", VA = "0x1870854C0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7085530", Offset = "0x7084930", VA = "0x187085530")]
		public static KHR_SceneAudioEmittersRef Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7085B20", Offset = "0x7084F20", VA = "0x187085B20")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7085490", Offset = "0x7084890", VA = "0x187085490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7085370", Offset = "0x7084770", VA = "0x187085370", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7085160", Offset = "0x7084560", VA = "0x187085160", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70851D0", Offset = "0x70845D0", VA = "0x1870851D0")]
		public static KHR_NodeAudioEmitterRef Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SDRSIETWAKS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string PAGPSBUYNYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? IHIAVZXRCBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? HLKVLLAPJRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? KLFDQKAFMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? GAFMDMUMGTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? XDRFFMPCXSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? MRYYPHVDGFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? UKRXXDHIWRD;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7090390", Offset = "0x708F790", VA = "0x187090390")]
		public JObject MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x708FC90", Offset = "0x708F090", VA = "0x18708FC90")]
		public static SDRSIETWAKS Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SDRSIETWAKS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : TKQQPTPBYXB
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
		public SDRSIETWAKS positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x70847B0", Offset = "0x7083BB0", VA = "0x1870847B0", Slot = "5")]
		public virtual JObject MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70842B0", Offset = "0x70836B0", VA = "0x1870842B0")]
		public static KHR_AudioEmitter Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7084B50", Offset = "0x7083F50", VA = "0x187084B50")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : TKQQPTPBYXB
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
		[Cpp2IlInjected.Address(RVA = "0x7084F30", Offset = "0x7084330", VA = "0x187084F30")]
		public JObject MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7084BD0", Offset = "0x7083FD0", VA = "0x187084BD0")]
		public static KHR_AudioSource Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x70827C0", Offset = "0x7081BC0", VA = "0x1870827C0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BTPWJCLGVLO bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7084180", Offset = "0x7083580", VA = "0x187084180")]
		public JObject MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7083F20", Offset = "0x7083320", VA = "0x187083F20")]
		public static KHR_AudioData Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x70827C0", Offset = "0x7081BC0", VA = "0x1870827C0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : DWUVLGQZHBQ
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
		[Cpp2IlInjected.Address(RVA = "0x7085DE0", Offset = "0x70851E0", VA = "0x187085DE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7085D50", Offset = "0x7085150", VA = "0x187085D50", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7086510", Offset = "0x7085910", VA = "0x187086510")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class UWTBLHNRFLH : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7096250", Offset = "0x7095650", VA = "0x187096250")]
		public UWTBLHNRFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x70956B0", Offset = "0x7094AB0", VA = "0x1870956B0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BTPWJCLGVLO bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x70866E0", Offset = "0x7085AE0", VA = "0x1870866E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7086620", Offset = "0x7085A20", VA = "0x187086620", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7086730", Offset = "0x7085B30", VA = "0x187086730")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class TOJYLUNOACP : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class VKMWSMJNIRA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader BNWHYMKNWQN;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VKMWSMJNIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7096350", Offset = "0x7095750", VA = "0x187096350")]
			internal int TVZHDKFKICF()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7091270", Offset = "0x7090670", VA = "0x187091270")]
		public TOJYLUNOACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7091060", Offset = "0x7090460", VA = "0x187091060", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public QVJVKMAODSV anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7086830", Offset = "0x7085C30", VA = "0x187086830", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x70867B0", Offset = "0x7085BB0", VA = "0x1870867B0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class OLOAJUCESJC : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x708E800", Offset = "0x708DC00", VA = "0x18708E800")]
		public OLOAJUCESJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x708E650", Offset = "0x708DA50", VA = "0x18708E650", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public QVJVKMAODSV clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public QVJVKMAODSV clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public QVJVKMAODSV clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7086AE0", Offset = "0x7085EE0", VA = "0x187086AE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7086A40", Offset = "0x7085E40", VA = "0x187086A40", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class FRSFTWWSFZC : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x707D890", Offset = "0x707CC90", VA = "0x18707D890")]
		public FRSFTWWSFZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x707D610", Offset = "0x707CA10", VA = "0x18707D610", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7086E40", Offset = "0x7086240", VA = "0x187086E40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7086DD0", Offset = "0x70861D0", VA = "0x187086DD0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class JDNJUOTPTBI : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7083050", Offset = "0x7082450", VA = "0x187083050")]
		public JDNJUOTPTBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7082F80", Offset = "0x7082380", VA = "0x187082F80", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : HXBBRIFRWVY, DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float MMJRDIJKSCU;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7087120", Offset = "0x7086520", VA = "0x187087120")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7087170", Offset = "0x7086570", VA = "0x187087170")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, WWOZGFPEXAT root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7086F60", Offset = "0x7086360", VA = "0x187086F60", Slot = "6")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7087000", Offset = "0x7086400", VA = "0x187087000", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class KBXTCDTQTMH : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7083ED0", Offset = "0x70832D0", VA = "0x187083ED0")]
		public KBXTCDTQTMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7083DD0", Offset = "0x70831D0", VA = "0x187083DD0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7087240", Offset = "0x7086640", VA = "0x187087240", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x70871E0", Offset = "0x70865E0", VA = "0x1870871E0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7087390", Offset = "0x7086790", VA = "0x187087390")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class XHXPZPEKSXC : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7096D30", Offset = "0x7096130", VA = "0x187096D30")]
		public XHXPZPEKSXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7096C60", Offset = "0x7096060", VA = "0x187096C60", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public QVJVKMAODSV iridescenceTexture;

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
		public QVJVKMAODSV iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7087440", Offset = "0x7086840", VA = "0x187087440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x70873A0", Offset = "0x70867A0", VA = "0x1870873A0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7087800", Offset = "0x7086C00", VA = "0x187087800")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class CTWFWGWJISC : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x707CB10", Offset = "0x707BF10", VA = "0x18707CB10")]
		public CTWFWGWJISC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x707C820", Offset = "0x707BC20", VA = "0x18707C820", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class TWWVQFEXYUR : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 BORZHWODDMD;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double YLGLXQVXBHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color MPVUZPOTQBR;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color SHKGKHSZWFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public QVJVKMAODSV SJGBUDINCXV;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly QVJVKMAODSV YBLIVCPNDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 KOYSRXBIWIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double JJVOKDHGSSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public QVJVKMAODSV DFVSPDKVIMY;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly QVJVKMAODSV OAILUDLGVKA;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7091BD0", Offset = "0x7090FD0", VA = "0x187091BD0")]
		public TWWVQFEXYUR(GLTF.Math.Color a, QVJVKMAODSV b, GLTF.Math.Vector3 c, double d, QVJVKMAODSV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70912C0", Offset = "0x70906C0", VA = "0x1870912C0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7091470", Offset = "0x7090870", VA = "0x187091470", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SHOAVCBZOER : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7090A80", Offset = "0x708FE80", VA = "0x187090A80")]
		public SHOAVCBZOER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7090730", Offset = "0x708FB30", VA = "0x187090730", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public QVJVKMAODSV sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public QVJVKMAODSV sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70878F0", Offset = "0x7086CF0", VA = "0x1870878F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7087820", Offset = "0x7086C20", VA = "0x187087820", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7087E00", Offset = "0x7087200", VA = "0x187087E00")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class NIWXQCAUIAD : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x708C830", Offset = "0x708BC30", VA = "0x18708C830")]
		public NIWXQCAUIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x708C5D0", Offset = "0x708B9D0", VA = "0x18708C5D0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public QVJVKMAODSV specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public QVJVKMAODSV specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7087F30", Offset = "0x7087330", VA = "0x187087F30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7087E60", Offset = "0x7087260", VA = "0x187087E60", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7088440", Offset = "0x7087840", VA = "0x187088440")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class MKPLCQMLWXD : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x708C150", Offset = "0x708B550", VA = "0x18708C150")]
		public MKPLCQMLWXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x708BEE0", Offset = "0x708B2E0", VA = "0x18708BEE0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public QVJVKMAODSV transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7088530", Offset = "0x7087930", VA = "0x187088530", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x70884B0", Offset = "0x70878B0", VA = "0x1870884B0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class YTWCTBLFPVO : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7096EC0", Offset = "0x70962C0", VA = "0x187096EC0")]
		public YTWCTBLFPVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7096D80", Offset = "0x7096180", VA = "0x187096D80", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class BFTMMAHGPKJ : HXBBRIFRWVY, DWUVLGQZHBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x707C1D0", Offset = "0x707B5D0", VA = "0x18707C1D0")]
		public BFTMMAHGPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x707C160", Offset = "0x707B560", VA = "0x18707C160")]
		public BFTMMAHGPKJ(BFTMMAHGPKJ a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x707BF60", Offset = "0x707B360", VA = "0x18707BF60", Slot = "6")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x707C000", Offset = "0x707B400", VA = "0x18707C000", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x707C090", Offset = "0x707B490", VA = "0x18707C090", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class GJEAANJQNMV : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x707D960", Offset = "0x707CD60", VA = "0x18707D960")]
		public GJEAANJQNMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x707D8E0", Offset = "0x707CCE0", VA = "0x18707D8E0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public QVJVKMAODSV thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7088750", Offset = "0x7087B50", VA = "0x187088750", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70886C0", Offset = "0x7087AC0", VA = "0x1870886C0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7088C80", Offset = "0x7088080", VA = "0x187088C80")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class HBBPVDZCAVI : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x707DC80", Offset = "0x707D080", VA = "0x18707DC80")]
		public HBBPVDZCAVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x707DA70", Offset = "0x707CE70", VA = "0x18707DA70", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7088D00", Offset = "0x7088100", VA = "0x187088D00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7088CA0", Offset = "0x70880A0", VA = "0x187088CA0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF42200", Offset = "0xF41600", VA = "0x180F42200")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class CNPXKATHBWO : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x707C7D0", Offset = "0x707BBD0", VA = "0x18707C7D0")]
		public CNPXKATHBWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x707C6F0", Offset = "0x707BAF0", VA = "0x18707C6F0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7088E70", Offset = "0x7088270", VA = "0x187088E70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7088E10", Offset = "0x7088210", VA = "0x187088E10", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF42200", Offset = "0xF41600", VA = "0x180F42200")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class SFBXMFODFHU : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x70906E0", Offset = "0x708FAE0", VA = "0x1870906E0")]
		public SFBXMFODFHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7090600", Offset = "0x708FA00", VA = "0x187090600", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7088FE0", Offset = "0x70883E0", VA = "0x187088FE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7088F80", Offset = "0x7088380", VA = "0x187088F80", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF42200", Offset = "0xF41600", VA = "0x180F42200")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class QJNLMLRNQVE : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x708F820", Offset = "0x708EC20", VA = "0x18708F820")]
		public QJNLMLRNQVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x708F740", Offset = "0x708EB40", VA = "0x18708F740", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LRSJFEZVPBM source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public KHR_texture_basisu(LRSJFEZVPBM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x70890F0", Offset = "0x70884F0", VA = "0x1870890F0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7089160", Offset = "0x7088560", VA = "0x187089160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class PVVXRSPKUQS : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x708F6F0", Offset = "0x708EAF0", VA = "0x18708F6F0")]
		public PVVXRSPKUQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x708F590", Offset = "0x708E990", VA = "0x18708F590", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class IQRPNIKJAWV : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 NPIUMFXISMF;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 KKSABFMECPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double BMLZZYLQLSQ;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double NKOYXAWPLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ALBYNQGLLDW;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 SXCNOJPLADY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? DAQNOJTATOE;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int ZPFMNRVNCRA;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7082F00", Offset = "0x7082300", VA = "0x187082F00")]
		public IQRPNIKJAWV(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x70827D0", Offset = "0x7081BD0", VA = "0x1870827D0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x70828B0", Offset = "0x7081CB0", VA = "0x1870828B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class CZXQEVRSFBT : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x707CE30", Offset = "0x707C230", VA = "0x18707CE30")]
		public CZXQEVRSFBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x707CB60", Offset = "0x707BF60", VA = "0x18707CB60", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class LSPKEOGTCPX : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> NXLZIWTFKQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public LSPKEOGTCPX(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x708BCF0", Offset = "0x708B0F0", VA = "0x18708BCF0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x708BDF0", Offset = "0x708B1F0", VA = "0x18708BDF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x708BD60", Offset = "0x708B160", VA = "0x18708BD60")]
		public List<double> MGOUFXTLWDF(TDRUPTSJFYC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ZZAISDREHEB : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7097010", Offset = "0x7096410", VA = "0x187097010")]
		public ZZAISDREHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7096F10", Offset = "0x7096310", VA = "0x187096F10", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class IOYCSNRGVDH : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BTPWJCLGVLO UGGVBKPYRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint LGMUIHUGGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType JTCDEOEKBCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool HEDRZNSZWTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint RUUQZBEMWUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType FHKJLFTGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> QSXRDCAVQMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> OTNZJWLAPRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PFPLAUGKLTH KMETGJRINAC;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x70827C0", Offset = "0x7081BC0", VA = "0x1870827C0")]
		public IOYCSNRGVDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x707E540", Offset = "0x707D940", VA = "0x18707E540")]
		public static IOYCSNRGVDH Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x707FBF0", Offset = "0x707EFF0", VA = "0x18707FBF0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x707F150", Offset = "0x707E550", VA = "0x18707F150")]
		private unsafe static sbyte LKYDSPGMAIM(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x707F420", Offset = "0x707E820", VA = "0x18707F420")]
		private unsafe static float2 IBAWXUTKFDI(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x70814D0", Offset = "0x70808D0", VA = "0x1870814D0")]
		private unsafe static float3 QEBPUYXOEBN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x70812D0", Offset = "0x70806D0", VA = "0x1870812D0")]
		private unsafe static float4 POCGLJMFDIE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x707E9D0", Offset = "0x707DDD0", VA = "0x18707E9D0")]
		private unsafe static float4x4 EHIFTCSLRUY(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x707F150", Offset = "0x707E550", VA = "0x18707F150")]
		private unsafe static byte GICBLNIOVCF(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7080E60", Offset = "0x7080260", VA = "0x187080E60")]
		private unsafe static float2 OGHIFLUUPQR(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x707F5D0", Offset = "0x707E9D0", VA = "0x18707F5D0")]
		private unsafe static float3 IQEPMWIYHSA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x707F450", Offset = "0x707E850", VA = "0x18707F450")]
		private unsafe static float4 IBTKHJHWGWL(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7080CC0", Offset = "0x70800C0", VA = "0x187080CC0")]
		private unsafe static float4x4 OFDNYIUKHUP(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x707FBE0", Offset = "0x707EFE0", VA = "0x18707FBE0")]
		private unsafe static short OVFPIRVFEOM(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x707E9A0", Offset = "0x707DDA0", VA = "0x18707E9A0")]
		private unsafe static float2 ECJDDANJBKW(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x707F160", Offset = "0x707E560", VA = "0x18707F160")]
		private unsafe static float3 GIZTJCCLPMH(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x707E0D0", Offset = "0x707D4D0", VA = "0x18707E0D0")]
		private unsafe static float4 BRNNDUSBJGE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x707E3A0", Offset = "0x707D7A0", VA = "0x18707E3A0")]
		private unsafe static float4x4 DKTJDILXIZW(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x707FBE0", Offset = "0x707EFE0", VA = "0x18707FBE0")]
		private unsafe static ushort XOGZQDGSYVJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7081C00", Offset = "0x7081000", VA = "0x187081C00")]
		private unsafe static float2 TNIWVMXUERZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7080FA0", Offset = "0x70803A0", VA = "0x187080FA0")]
		private unsafe static float3 OJRTNEHMDHE(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7081330", Offset = "0x7080730", VA = "0x187081330")]
		private unsafe static float4x4 PVMEQSLIQUF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x70824C0", Offset = "0x70818C0", VA = "0x1870824C0")]
		private unsafe static float4 XJIEKDWCBVD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x70818E0", Offset = "0x7080CE0", VA = "0x1870818E0")]
		private unsafe static uint SHGCNLWVGLM(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x707FBE0", Offset = "0x707EFE0", VA = "0x18707FBE0")]
		private unsafe static ushort LWDODMBHWAP(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7081EE0", Offset = "0x70812E0", VA = "0x187081EE0")]
		private unsafe static float UXQVCJDITDS(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x707F620", Offset = "0x707EA20", VA = "0x18707F620")]
		private unsafe static float2 JAZMJYLXTYG(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x70818C0", Offset = "0x7080CC0", VA = "0x1870818C0")]
		private unsafe static float3 RUOBNKFEGLR(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7081520", Offset = "0x7080920", VA = "0x187081520")]
		private unsafe static float4 UBCVNKRTZCI(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x707F120", Offset = "0x707E520", VA = "0x18707F120")]
		private unsafe static float4x4 FUDESASIQSI(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7081520", Offset = "0x7080920", VA = "0x187081520")]
		private unsafe static float4 QTBEOJQTPAP(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7081550", Offset = "0x7080950", VA = "0x187081550")]
		private unsafe static float4 QTBEOJQTPAP(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x707F640", Offset = "0x707EA40", VA = "0x18707F640")]
		public static float3[] JLKIGHNBERI(IOYCSNRGVDH a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x70818F0", Offset = "0x7080CF0", VA = "0x1870818F0")]
		public static float3[] STJVRTHWGKO(IOYCSNRGVDH a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7082520", Offset = "0x7081920", VA = "0x187082520")]
		public static uint[] XMUMTDYESTZ(IOYCSNRGVDH a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x707F4B0", Offset = "0x707E8B0", VA = "0x18707F4B0")]
		internal static void IPPWKFQZAHG(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7080A70", Offset = "0x707FE70", VA = "0x187080A70")]
		public uint[] OARSVNOZZCD(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x707E130", Offset = "0x707D530", VA = "0x18707E130")]
		public float[] DIOXWKECPRT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x707DE40", Offset = "0x707D240", VA = "0x18707DE40")]
		public float2[] BBORIAPWBYP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7081C30", Offset = "0x7081030", VA = "0x187081C30")]
		public float2[] TVZXVYRMKOJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x70807F0", Offset = "0x707FBF0", VA = "0x1870807F0")]
		public float3[] NZNMHAXBKAW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7082000", Offset = "0x7081400", VA = "0x187082000")]
		public float3[] VYJNXFHPNHE(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x707F1B0", Offset = "0x707E5B0", VA = "0x18707F1B0")]
		public float4[] GZRWMVNFLEB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x707F870", Offset = "0x707EC70", VA = "0x18707F870")]
		public float4[] JTPORWWQBJP(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7080390", Offset = "0x707F790", VA = "0x187080390")]
		public float4[] NIGSSEQOHRU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7081EF0", Offset = "0x70812F0", VA = "0x187081EF0")]
		public float3[] VIIEAAEOHCB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7080E90", Offset = "0x7080290", VA = "0x187080E90")]
		public float3[] OJEMOHLXMLI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7080720", Offset = "0x707FB20", VA = "0x187080720")]
		public float4[] NYWHXFCNQZS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7082350", Offset = "0x7081750", VA = "0x187082350")]
		public uint[] WICJXPYQMYH(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x707EB70", Offset = "0x707DF70", VA = "0x18707EB70")]
		public float4x4[] EMMWEBAPPAG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7081580", Offset = "0x7080980", VA = "0x187081580")]
		private unsafe static float4 RQHITIVEJSY(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7081740", Offset = "0x7080B40", VA = "0x187081740")]
		private unsafe static float4 RQHITIVEJSY(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7081160", Offset = "0x7080560", VA = "0x187081160")]
		private unsafe static float4x4 PGXNJSZPOEJ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70801D0", Offset = "0x707F5D0", VA = "0x1870801D0")]
		private unsafe static float4 MNSQSXSPVRP(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7080FF0", Offset = "0x70803F0", VA = "0x187080FF0")]
		private unsafe static float3 PATMJDFPJZE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7082690", Offset = "0x7081A90", VA = "0x187082690")]
		private unsafe static float2 YWLEVPGMILJ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x70823A0", Offset = "0x70817A0", VA = "0x1870823A0")]
		private unsafe static uint XDQUEMIVTKC(void* a, uint b, GLTFComponentType c)
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
	public static class GQZZZLOONYO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x709B370", Offset = "0x709A770", VA = "0x18709B370")]
		public static int BGAGGUVVZQM(this GLTFAccessorAttributeType a)
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
	public class PFPLAUGKLTH : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int RUUQZBEMWUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GPVDMAQBSMG QAEFMREUQVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GFPOCJPAQIX JYXVAPOMOYQ;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x70A1610", Offset = "0x70A0A10", VA = "0x1870A1610")]
		public PFPLAUGKLTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70A1210", Offset = "0x70A0610", VA = "0x1870A1210")]
		public static PFPLAUGKLTH Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x70A14E0", Offset = "0x70A08E0", VA = "0x1870A14E0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class GPVDMAQBSMG : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BTPWJCLGVLO UGGVBKPYRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int LGMUIHUGGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType JTCDEOEKBCR;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x709B320", Offset = "0x709A720", VA = "0x18709B320")]
		public GPVDMAQBSMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x709AF00", Offset = "0x709A300", VA = "0x18709AF00")]
		public static GPVDMAQBSMG Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x709B1E0", Offset = "0x709A5E0", VA = "0x18709B1E0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class GFPOCJPAQIX : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public BTPWJCLGVLO UGGVBKPYRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int LGMUIHUGGLF;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x709AEB0", Offset = "0x709A2B0", VA = "0x18709AEB0")]
		public GFPOCJPAQIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x709AB30", Offset = "0x7099F30", VA = "0x18709AB30")]
		public static GFPOCJPAQIX Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x709ADB0", Offset = "0x709A1B0", VA = "0x18709ADB0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class IWEDIQWOEKH : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AJGPZCLHLPT GZIATBJUXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public DPIOZUENGTA ZOBXWVHJMPF;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x709E2A0", Offset = "0x709D6A0", VA = "0x18709E2A0")]
		public IWEDIQWOEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x709DFB0", Offset = "0x709D3B0", VA = "0x18709DFB0")]
		public static IWEDIQWOEKH Deserialize(WWOZGFPEXAT root, JsonReader reader, ZSLIFJUDOKH anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x709E1A0", Offset = "0x709D5A0", VA = "0x18709E1A0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class DPIOZUENGTA : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public EUFSUYWPBXB TDRUPTSJFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string YTLUPOXLYLL;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x70998F0", Offset = "0x7098CF0", VA = "0x1870998F0")]
		public static DPIOZUENGTA Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7099C70", Offset = "0x7099070", VA = "0x187099C70")]
		public DPIOZUENGTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7099B50", Offset = "0x7098F50", VA = "0x187099B50", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
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
	public class UTGSDXUYMZX
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(UTGSDXUYMZX data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] SXBAXTOWWSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type EDCZJIYRTYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] QYMXUDMDBRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion BBVCASNPYYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string MENNBNHQGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string WZDMHBCHJUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public MORBBRKLNFX MQWOEPZYPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string VIFUJCOESID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string SYFLGAPLGVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public MORBBRKLNFX MOUUXMDRYAM;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x70A6F10", Offset = "0x70A6310", VA = "0x1870A6F10")]
		public UTGSDXUYMZX()
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
	public class APMMAHPEUIA : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ZEVJADLYGLG FSFDLIPATDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType NLHTKBWKYIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ZEVJADLYGLG FDMRQOXHRLJ;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7098660", Offset = "0x7097A60", VA = "0x187098660")]
		public APMMAHPEUIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x70982D0", Offset = "0x70976D0", VA = "0x1870982D0")]
		public static APMMAHPEUIA Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x70984F0", Offset = "0x70978F0", VA = "0x1870984F0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class AHSKDRIKEKS : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string UBHOVQXDMTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string PZISFNIIRBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string YUTHJPFLKHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string JCPBVUXMVRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> OYTBADVTJJQ;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7098090", Offset = "0x7097490", VA = "0x187098090")]
		public AHSKDRIKEKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x70975A0", Offset = "0x70969A0", VA = "0x1870975A0")]
		public static AHSKDRIKEKS Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7097C60", Offset = "0x7097060", VA = "0x187097C60", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7098080", Offset = "0x7097480", VA = "0x187098080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x70978C0", Offset = "0x7096CC0", VA = "0x1870978C0")]
		public string MEHLBYWTUHU(bool a)
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
	public class UGGVBKPYRYB : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DUUOZHJTTXH FPARKZESKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint LGMUIHUGGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint GIKIDHSVOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint YXCDRDVPJXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget ZOBXWVHJMPF;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public UGGVBKPYRYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x70A6A50", Offset = "0x70A5E50", VA = "0x1870A6A50")]
		public static UGGVBKPYRYB Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x70A6D00", Offset = "0x70A6100", VA = "0x1870A6D00", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class AAXIPMADSDJ : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double UUSQLBJPILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double ETUIWVWZOVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double KQRPVMDAZKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double THDBSZBRZHI;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7097550", Offset = "0x7096950", VA = "0x187097550")]
		public AAXIPMADSDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7097060", Offset = "0x7096460", VA = "0x187097060")]
		public static AAXIPMADSDJ Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x70973E0", Offset = "0x70967E0", VA = "0x1870973E0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class CZUMJUAUFMF : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double LAHKUVYVEZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double YRPPECNJVIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double KQRPVMDAZKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double THDBSZBRZHI;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7099450", Offset = "0x7098850", VA = "0x187099450")]
		public CZUMJUAUFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7098F50", Offset = "0x7098350", VA = "0x187098F50")]
		public static CZUMJUAUFMF Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x70992C0", Offset = "0x70986C0", VA = "0x1870992C0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZSLIFJUDOKH : TKQQPTPBYXB
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class VKMWSMJNIRA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public WWOZGFPEXAT BRWFJBTAWNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader BNWHYMKNWQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public ZSLIFJUDOKH VRSILGLQHWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<IWEDIQWOEKH> LVRYNBIKHVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<APMMAHPEUIA> LVMRPUOMYKQ;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VKMWSMJNIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x70A7030", Offset = "0x70A6430", VA = "0x1870A7030")]
			internal IWEDIQWOEKH TVZHDKFKICF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x70A7020", Offset = "0x70A6420", VA = "0x1870A7020")]
			internal APMMAHPEUIA TVUAGDLMYQW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<IWEDIQWOEKH> TLFVYDBSTNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<APMMAHPEUIA> NUDPYIXVNRB;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x70AC640", Offset = "0x70ABA40", VA = "0x1870AC640")]
		public static ZSLIFJUDOKH Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x70ACDA0", Offset = "0x70AC1A0", VA = "0x1870ACDA0")]
		public ZSLIFJUDOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x70ACA00", Offset = "0x70ABE00", VA = "0x1870ACA00", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class TOWIEUSSEIJ : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string UMAFCUWXGDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint GIKIDHSVOLG;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public TOWIEUSSEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x70A6220", Offset = "0x70A5620", VA = "0x1870A6220")]
		public static TOWIEUSSEIJ Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x70A63F0", Offset = "0x70A57F0", VA = "0x1870A63F0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class IMYORYACKAM : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AAXIPMADSDJ HUJKDMOBDNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CZUMJUAUFMF CZOZTNSYVOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType FHKJLFTGJNM;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public IMYORYACKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x709D9D0", Offset = "0x709CDD0", VA = "0x18709D9D0")]
		public static IMYORYACKAM Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x709DBA0", Offset = "0x709CFA0", VA = "0x18709DBA0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
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
	public class TKQQPTPBYXB : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string OVNHSEVRRUV;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public TKQQPTPBYXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x70A61A0", Offset = "0x70A55A0", VA = "0x1870A61A0")]
		public TKQQPTPBYXB(TKQQPTPBYXB a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x70A6020", Offset = "0x70A5420", VA = "0x1870A6020")]
		public new void BJTAPXCDWMV(WWOZGFPEXAT a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x70A6110", Offset = "0x70A5510", VA = "0x1870A6110", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class BIQNACOUGNX<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int KVDFRQPXLVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public WWOZGFPEXAT TMZYFPRTZJQ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected BIQNACOUGNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6DACCF0", Offset = "0x6DAC0F0", VA = "0x186DACCF0")]
		public BIQNACOUGNX(BIQNACOUGNX<a> a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6DACCC0", Offset = "0x6DAC0C0", VA = "0x186DACCC0")]
		public void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ZEVJADLYGLG : BIQNACOUGNX<IOYCSNRGVDH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override IOYCSNRGVDH Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x70AC5E0", Offset = "0x70AB9E0", VA = "0x1870AC5E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x70AC5A0", Offset = "0x70AB9A0", VA = "0x1870AC5A0")]
		public ZEVJADLYGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x70AC540", Offset = "0x70AB940", VA = "0x1870AC540")]
		public ZEVJADLYGLG(ZEVJADLYGLG a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x70AC460", Offset = "0x70AB860", VA = "0x1870AC460")]
		public static ZEVJADLYGLG Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DUUOZHJTTXH : BIQNACOUGNX<TOWIEUSSEIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override TOWIEUSSEIJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7099DE0", Offset = "0x70991E0", VA = "0x187099DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7099DA0", Offset = "0x70991A0", VA = "0x187099DA0")]
		public DUUOZHJTTXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7099CC0", Offset = "0x70990C0", VA = "0x187099CC0")]
		public static DUUOZHJTTXH Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class BTPWJCLGVLO : BIQNACOUGNX<UGGVBKPYRYB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override UGGVBKPYRYB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7098EF0", Offset = "0x70982F0", VA = "0x187098EF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7098EB0", Offset = "0x70982B0", VA = "0x187098EB0")]
		public BTPWJCLGVLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7098DD0", Offset = "0x70981D0", VA = "0x187098DD0")]
		public static BTPWJCLGVLO Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class QHIYIRZNDBG : BIQNACOUGNX<IMYORYACKAM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override IMYORYACKAM Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x70A31B0", Offset = "0x70A25B0", VA = "0x1870A31B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x70A3170", Offset = "0x70A2570", VA = "0x1870A3170")]
		public QHIYIRZNDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x70A3090", Offset = "0x70A2490", VA = "0x1870A3090")]
		public static QHIYIRZNDBG Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class LRSJFEZVPBM : BIQNACOUGNX<JOTAXGUVNME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override JOTAXGUVNME Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x709ED70", Offset = "0x709E170", VA = "0x18709ED70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x709ED30", Offset = "0x709E130", VA = "0x18709ED30")]
		public LRSJFEZVPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x709EC50", Offset = "0x709E050", VA = "0x18709EC50")]
		public static LRSJFEZVPBM Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class FXFRWFGRKIK : BIQNACOUGNX<SATUANLWUCW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override SATUANLWUCW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x709AAD0", Offset = "0x7099ED0", VA = "0x18709AAD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x709AA90", Offset = "0x7099E90", VA = "0x18709AA90")]
		public FXFRWFGRKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x709AA30", Offset = "0x7099E30", VA = "0x18709AA30")]
		public FXFRWFGRKIK(FXFRWFGRKIK a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x709A950", Offset = "0x7099D50", VA = "0x18709A950")]
		public static FXFRWFGRKIK Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class OISGFKOYRJI : BIQNACOUGNX<XDMLLHZTHCO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override XDMLLHZTHCO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x70A0620", Offset = "0x709FA20", VA = "0x1870A0620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x70A05E0", Offset = "0x709F9E0", VA = "0x1870A05E0")]
		public OISGFKOYRJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x70A0500", Offset = "0x709F900", VA = "0x1870A0500")]
		public static OISGFKOYRJI Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class EUFSUYWPBXB : BIQNACOUGNX<TDRUPTSJFYC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override TDRUPTSJFYC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x709A8F0", Offset = "0x7099CF0", VA = "0x18709A8F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x709A8B0", Offset = "0x7099CB0", VA = "0x18709A8B0")]
		public EUFSUYWPBXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x709A560", Offset = "0x7099960", VA = "0x18709A560")]
		public static EUFSUYWPBXB Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x709A640", Offset = "0x7099A40", VA = "0x18709A640")]
		public static List<EUFSUYWPBXB> EUSKWLRPLRI(WWOZGFPEXAT a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SAONQTVMLJN : BIQNACOUGNX<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x70A3A60", Offset = "0x70A2E60", VA = "0x1870A3A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x70A3A20", Offset = "0x70A2E20", VA = "0x1870A3A20")]
		public SAONQTVMLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x70A3940", Offset = "0x70A2D40", VA = "0x1870A3940")]
		public static SAONQTVMLJN Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class AJGPZCLHLPT : BIQNACOUGNX<APMMAHPEUIA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ZSLIFJUDOKH ZSLIFJUDOKH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override APMMAHPEUIA Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7098270", Offset = "0x7097670", VA = "0x187098270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7098230", Offset = "0x7097630", VA = "0x187098230")]
		public AJGPZCLHLPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7098130", Offset = "0x7097530", VA = "0x187098130")]
		public static AJGPZCLHLPT Deserialize(WWOZGFPEXAT root, ZSLIFJUDOKH anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class YLEVAYZTNYD : BIQNACOUGNX<DKOKDRZOXIV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override DKOKDRZOXIV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x70ABA50", Offset = "0x70AAE50", VA = "0x1870ABA50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x70ABA10", Offset = "0x70AAE10", VA = "0x1870ABA10")]
		public YLEVAYZTNYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x70AB930", Offset = "0x70AAD30", VA = "0x1870AB930")]
		public static YLEVAYZTNYD Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class MEQKEOLXPVE : BIQNACOUGNX<EHNRKEZVUYP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override EHNRKEZVUYP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x709EEF0", Offset = "0x709E2F0", VA = "0x18709EEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x709EEB0", Offset = "0x709E2B0", VA = "0x18709EEB0")]
		public MEQKEOLXPVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x709EDD0", Offset = "0x709E1D0", VA = "0x18709EDD0")]
		public static MEQKEOLXPVE Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class MGLFWNMVGRG : BIQNACOUGNX<ILVOIGRROTU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override ILVOIGRROTU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x709F0D0", Offset = "0x709E4D0", VA = "0x18709F0D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x709F030", Offset = "0x709E430", VA = "0x18709F030")]
		public MGLFWNMVGRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x709F070", Offset = "0x709E470", VA = "0x18709F070")]
		public MGLFWNMVGRG(MGLFWNMVGRG a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x709EF50", Offset = "0x709E350", VA = "0x18709EF50")]
		public static MGLFWNMVGRG Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class YRQLJLJEHRF : BIQNACOUGNX<NQUQUSMUGND>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NQUQUSMUGND Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x70ABAF0", Offset = "0x70AAEF0", VA = "0x1870ABAF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x70ABAB0", Offset = "0x70AAEB0", VA = "0x1870ABAB0")]
		public YRQLJLJEHRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class JOTAXGUVNME : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string UMAFCUWXGDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string EDUXHBDZLQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public BTPWJCLGVLO UGGVBKPYRYB;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public JOTAXGUVNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x709E2F0", Offset = "0x709D6F0", VA = "0x18709E2F0")]
		public static JOTAXGUVNME Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x709E530", Offset = "0x709D930", VA = "0x18709E530", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class SATUANLWUCW : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ARMURINYIUX ARMURINYIUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IFFVOHGYRDU DTJDGIJAGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public MGMIXQPVMGI AJGTEZPYDLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OUQRFOSTZAK MKXAEIMKZIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public QVJVKMAODSV NOOQFLDSAAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color NSYPEXBOPVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode LNKWBFHAWSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double BASKJYFCUHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool RWJVCQLYXAU;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x70A4430", Offset = "0x70A3830", VA = "0x1870A4430")]
		public SATUANLWUCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x70A3AC0", Offset = "0x70A2EC0", VA = "0x1870A3AC0")]
		public static SATUANLWUCW Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x70A3FD0", Offset = "0x70A33D0", VA = "0x1870A3FD0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
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
	public class XDMLLHZTHCO : TKQQPTPBYXB
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class KTYJSXNJOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public WWOZGFPEXAT BRWFJBTAWNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader BNWHYMKNWQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<QGYFAGXCXBC> LVRYNBIKHVZ;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTYJSXNJOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x709E700", Offset = "0x709DB00", VA = "0x18709E700")]
			internal QGYFAGXCXBC TVZHDKFKICF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<QGYFAGXCXBC> KSTYHBDDYMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> OUHXCOCZJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> OBAGJABAOPD;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public XDMLLHZTHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x70AAFC0", Offset = "0x70AA3C0", VA = "0x1870AAFC0")]
		public static XDMLLHZTHCO Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x70AB380", Offset = "0x70AA780", VA = "0x1870AB380", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class HXBBRIFRWVY
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, YIMZCLHZLHV> FKNLYSNZVRB;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static VAAMGOXTLTE YECPXRCOCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, DWUVLGQZHBQ> AOXSVWFXYXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken HXRJEXONKCV;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x709C180", Offset = "0x709B580", VA = "0x18709C180")]
		public static YIMZCLHZLHV TQOALHOLGRA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x709B680", Offset = "0x709AA80", VA = "0x18709B680")]
		public static DWUVLGQZHBQ IQRVJXUWOLG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public HXBBRIFRWVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x709CE30", Offset = "0x709C230", VA = "0x18709CE30")]
		public HXBBRIFRWVY(HXBBRIFRWVY a, [Optional] WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x709B3D0", Offset = "0x709A7D0", VA = "0x18709B3D0")]
		public void BJTAPXCDWMV(WWOZGFPEXAT a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x709C400", Offset = "0x709B800", VA = "0x18709C400")]
		public void WRCVNDXCRNA(string a, DWUVLGQZHBQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x709C310", Offset = "0x709B710", VA = "0x18709C310")]
		private void VNHMIBBRHDE(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x709C550", Offset = "0x709B950", VA = "0x18709C550")]
		private void XTRBCFLSDKG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x709C0C0", Offset = "0x709B4C0", VA = "0x18709C0C0")]
		private void MRRLELXWLEO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x709BAF0", Offset = "0x709AEF0", VA = "0x18709BAF0")]
		internal static Dictionary<string, DWUVLGQZHBQ> MRBZYOEJOLJ(WWOZGFPEXAT a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x709B770", Offset = "0x709AB70", VA = "0x18709B770", Slot = "4")]
		public virtual void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WWOZGFPEXAT : HXBBRIFRWVY
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class RIOAGJYRBFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public WWOZGFPEXAT BRWFJBTAWNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader HBUQDHMSBOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<IOYCSNRGVDH> LVRYNBIKHVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<ZSLIFJUDOKH> LVMRPUOMYKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<TOWIEUSSEIJ> LWCMHOWFASR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<UGGVBKPYRYB> LVXFKICHRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<IMYORYACKAM> LUWWYAGUWCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<JOTAXGUVNME> LURQATMXMRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<SATUANLWUCW> LVHKSNUPOZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<XDMLLHZTHCO> LVCDVHASFNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<TDRUPTSJFYC> LUBVIZFFKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> LTWOLSLIAXW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<DKOKDRZOXIV> SEFAYQHBXVW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<EHNRKEZVUYP> SEKHVXAZHHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<ILVOIGRROTU> SEPOTDUWQSO;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public RIOAGJYRBFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x70A38D0", Offset = "0x70A2CD0", VA = "0x1870A38D0")]
			internal IOYCSNRGVDH TVZHDKFKICF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x70A38C0", Offset = "0x70A2CC0", VA = "0x1870A38C0")]
			internal ZSLIFJUDOKH TVUAGDLMYQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x70A38B0", Offset = "0x70A2CB0", VA = "0x1870A38B0")]
			internal TOWIEUSSEIJ TVOTIWRPPFN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x70A38A0", Offset = "0x70A2CA0", VA = "0x1870A38A0")]
			internal UGGVBKPYRYB TVJMLPXSFUE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x70A3910", Offset = "0x70A2D10", VA = "0x1870A3910")]
			internal IMYORYACKAM TWUISLGZTVP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x70A3900", Offset = "0x70A2D00", VA = "0x1870A3900")]
			internal JOTAXGUVNME TWPBVENCKKG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x70A38F0", Offset = "0x70A2CF0", VA = "0x1870A38F0")]
			internal SATUANLWUCW TWJUXXTFAYX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x70A38E0", Offset = "0x70A2CE0", VA = "0x1870A38E0")]
			internal XDMLLHZTHCO TWEOAQZHRNO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x70A3930", Offset = "0x70A2D30", VA = "0x1870A3930")]
			internal TDRUPTSJFYC TXPKHMIPFOZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x70A3920", Offset = "0x70A2D20", VA = "0x1870A3920")]
			internal Sampler TXKDKFORWDQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x70A3710", Offset = "0x70A2B10", VA = "0x1870A3710")]
			internal DKOKDRZOXIV PGJPXFMSMBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x70A3890", Offset = "0x70A2C90", VA = "0x1870A3890")]
			internal EHNRKEZVUYP PGOWUMGPVMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x70A3700", Offset = "0x70A2B00", VA = "0x1870A3700")]
			internal ILVOIGRROTU PFZCCRYXTEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> NREIDJSZMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> EGISAUFNAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<IOYCSNRGVDH> XELGSMINLUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<ZSLIFJUDOKH> PJWEUMWRJWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AHSKDRIKEKS AHSKDRIKEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<TOWIEUSSEIJ> AJCMSOVAWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<UGGVBKPYRYB> LXCHKMEYKZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<IMYORYACKAM> NCBSYEMCHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<JOTAXGUVNME> AAEDNKUDLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<SATUANLWUCW> JCVYLFNPLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<XDMLLHZTHCO> BJYTGYSMZDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<TDRUPTSJFYC> TZVRERSFBYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> NUDPYIXVNRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public YLEVAYZTNYD VNLFNPBCVJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<DKOKDRZOXIV> PDENDQUVJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<EHNRKEZVUYP> ZLDMAKEUGCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<ILVOIGRROTU> HZHHSAEVRAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<NQUQUSMUGND> OYKYAYRNQYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool HVRRCJBDDIJ;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x70AAF70", Offset = "0x70AA370", VA = "0x1870AAF70")]
		public WWOZGFPEXAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x70AAED0", Offset = "0x70AA2D0", VA = "0x1870AAED0")]
		public DKOKDRZOXIV WLKXZWPAYYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x70A84E0", Offset = "0x70A78E0", VA = "0x1870A84E0")]
		public static WWOZGFPEXAT Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x70A9330", Offset = "0x70A8730", VA = "0x1870A9330")]
		public void MFMKHXDBDDO(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class DKOKDRZOXIV : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<EUFSUYWPBXB> TZVRERSFBYL;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public DKOKDRZOXIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x70994B0", Offset = "0x70988B0", VA = "0x1870994B0")]
		public static DKOKDRZOXIV Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7099630", Offset = "0x7098A30", VA = "0x187099630", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ILVOIGRROTU : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public SAONQTVMLJN GZIATBJUXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public LRSJFEZVPBM DHEOWMNQXCP;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public ILVOIGRROTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x709D690", Offset = "0x709CA90", VA = "0x18709D690")]
		public static ILVOIGRROTU Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x709D860", Offset = "0x709CC60", VA = "0x18709D860", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class WRKCVXAMZTZ : NQUQUSMUGND
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public WRKCVXAMZTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x709E710", Offset = "0x709DB10", VA = "0x18709E710", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class NQUQUSMUGND : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string PSRZIJBMARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color FWTMXIMOZMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string TWRGICASDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float ZNRYGKLDIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float DYZPDPRCSLZ;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public NQUQUSMUGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70A0280", Offset = "0x709F680", VA = "0x1870A0280", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class KVUOTDVOPFX : NQUQUSMUGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x70998A0", Offset = "0x7098CA0", VA = "0x1870998A0")]
		public KVUOTDVOPFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x709E710", Offset = "0x709DB10", VA = "0x18709E710", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class WCXGHMFTOFT : NQUQUSMUGND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float CAOCPTVDXUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float GPRJLIDZJUB;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x70A75A0", Offset = "0x70A69A0", VA = "0x1870A75A0")]
		public WCXGHMFTOFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x70A72A0", Offset = "0x70A66A0", VA = "0x1870A72A0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface YIZOBDSRSKQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EWVYNIIIYXF(WWOZGFPEXAT a, BUVFBYLBULO b, [Out] UTGSDXUYMZX c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface DWUVLGQZHBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DWUVLGQZHBQ Clone(WWOZGFPEXAT root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class YIMZCLHZLHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string KMINRBGPYIA;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected YIMZCLHZLHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class ARQCKSIKDEE : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty KZLXDVSDRFN
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7098D20", Offset = "0x7098120", VA = "0x187098D20", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ARQCKSIKDEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class VAAMGOXTLTE : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x70A6FB0", Offset = "0x70A63B0", VA = "0x1870A6FB0", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public VAAMGOXTLTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class IFFVOHGYRDU : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color IZEWAUZQIQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public QVJVKMAODSV LGOVJIFRPKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color IREXBTGMJFN;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x709D620", Offset = "0x709CA20", VA = "0x18709D620")]
		public IFFVOHGYRDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x709D120", Offset = "0x709C520", VA = "0x18709D120")]
		public static IFFVOHGYRDU Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x709D3C0", Offset = "0x709C7C0", VA = "0x18709D3C0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class MGMIXQPVMGI : QVJVKMAODSV
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string FHUQMUFYVWI = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ALBYNQGLLDW;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x709F4E0", Offset = "0x709E8E0", VA = "0x18709F4E0")]
		public MGMIXQPVMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x709F130", Offset = "0x709E530", VA = "0x18709F130")]
		public new static MGMIXQPVMGI Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x709F420", Offset = "0x709E820", VA = "0x18709F420", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class OUQRFOSTZAK : QVJVKMAODSV
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string PWGHOHPWHCD = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double DHCDFUCBKQD;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x709F4E0", Offset = "0x709E8E0", VA = "0x18709F4E0")]
		public OUQRFOSTZAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x70A0E60", Offset = "0x70A0260", VA = "0x1870A0E60")]
		public new static OUQRFOSTZAK Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x70A1150", Offset = "0x70A0550", VA = "0x1870A1150", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ARMURINYIUX : HXBBRIFRWVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color VEESIAYHSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public QVJVKMAODSV SBPJRICOFWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double JXRRCISVRMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double LYBXIQFAKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public QVJVKMAODSV TXZDNBDUFJY;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7098CB0", Offset = "0x70980B0", VA = "0x187098CB0")]
		public ARMURINYIUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x70986B0", Offset = "0x7097AB0", VA = "0x1870986B0")]
		public static ARMURINYIUX Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7098A20", Offset = "0x7097E20", VA = "0x187098A20", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class QGYFAGXCXBC : HXBBRIFRWVY
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class VLMGFEXHLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader BNWHYMKNWQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public WWOZGFPEXAT BRWFJBTAWNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<ZEVJADLYGLG> LVRYNBIKHVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<ZEVJADLYGLG> LWCMHOWFASR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, ZEVJADLYGLG>> LVMRPUOMYKQ;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VLMGFEXHLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x70A71D0", Offset = "0x70A65D0", VA = "0x1870A71D0")]
			internal ZEVJADLYGLG TVZHDKFKICF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x70A7120", Offset = "0x70A6520", VA = "0x1870A7120")]
			internal Dictionary<string, ZEVJADLYGLG> TVUAGDLMYQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x70A7050", Offset = "0x70A6450", VA = "0x1870A7050")]
			internal ZEVJADLYGLG TVOTIWRPPFN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, ZEVJADLYGLG> CBHYALZUWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ZEVJADLYGLG QAEFMREUQVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FXFRWFGRKIK ERVJOMXJXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode OBBIKPCYHUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, ZEVJADLYGLG>> BGYWSGITCHK;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x70A2950", Offset = "0x70A1D50", VA = "0x1870A2950")]
		public QGYFAGXCXBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x70A29F0", Offset = "0x70A1DF0", VA = "0x1870A29F0")]
		public QGYFAGXCXBC(QGYFAGXCXBC a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x70A28B0", Offset = "0x70A1CB0", VA = "0x1870A28B0")]
		public static int[] ZKUUYOWLMQK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x70A1AB0", Offset = "0x70A0EB0", VA = "0x1870A1AB0")]
		public static int[] FHMKPBAZIAO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x70A1C10", Offset = "0x70A1010", VA = "0x1870A1C10")]
		public static int[] FSVIRJFHDCQ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x70A2670", Offset = "0x70A1A70", VA = "0x1870A2670")]
		public static int[] TFVHMBBOBJG(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x70A1DD0", Offset = "0x70A11D0", VA = "0x1870A1DD0")]
		public static int[] KHMZVFSJVXR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x70A2570", Offset = "0x70A1970", VA = "0x1870A2570")]
		public static int[] ROZNYJMQBVQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x70A24E0", Offset = "0x70A18E0", VA = "0x1870A24E0")]
		public static int[] QYCMFJHEIOQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x70A2470", Offset = "0x70A1870", VA = "0x1870A2470")]
		public static int[] PNXVKZDJLPF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x70A25E0", Offset = "0x70A19E0", VA = "0x1870A25E0")]
		public static int[] RUPYITCDHPD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x70A1660", Offset = "0x70A0A60", VA = "0x1870A1660")]
		public static QGYFAGXCXBC Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x70A1E80", Offset = "0x70A1280", VA = "0x1870A1E80", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class OTPWKRXMHZJ
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] DAQNOJTATOE;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] IREMFHUMQQF;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] VDEFKRQPURY;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] GFJQHGJCUVM;
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
	public class TDRUPTSJFYC : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool KRQWRCESWXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public QHIYIRZNDBG WGYMVXACXVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<EUFSUYWPBXB> RUHBADOSRLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MEQKEOLXPVE EHNRKEZVUYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PVDHHZPWCMN QBKOXYORKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public OISGFKOYRJI WTLRLNZKNCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion BMLZZYLQLSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ALBYNQGLLDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 FXMDNIRAWZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> OUHXCOCZJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public YRQLJLJEHRF JSVOMTAIKMW;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x70A5EF0", Offset = "0x70A52F0", VA = "0x1870A5EF0")]
		public TDRUPTSJFYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x70A49D0", Offset = "0x70A3DD0", VA = "0x1870A49D0")]
		public static TDRUPTSJFYC Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x70A5300", Offset = "0x70A4700", VA = "0x1870A5300", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode BAOWTIAPKZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode RUWYMWJYMWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode GATVTLSKNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode GAEBBRKSLGO;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x70A4960", Offset = "0x70A3D60", VA = "0x1870A4960")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x70A44A0", Offset = "0x70A38A0", VA = "0x1870A44A0")]
		public static Sampler Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x70A4770", Offset = "0x70A3B70", VA = "0x1870A4770", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
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
	public class EHNRKEZVUYP : TKQQPTPBYXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ZEVJADLYGLG OFINWGUILBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public EUFSUYWPBXB UHJUIZLQXLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<EUFSUYWPBXB> EAJOFYCJYHZ;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x709A4B0", Offset = "0x70998B0", VA = "0x18709A4B0")]
		public EHNRKEZVUYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7099E40", Offset = "0x7099240", VA = "0x187099E40")]
		public static EHNRKEZVUYP Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x709A1A0", Offset = "0x70995A0", VA = "0x18709A1A0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class QVJVKMAODSV : HXBBRIFRWVY
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string FZEUFSYFPFA = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string UNUIPWAGEQM = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public MGLFWNMVGRG BCMCGOYSEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int DAQNOJTATOE;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x70A35C0", Offset = "0x70A29C0", VA = "0x1870A35C0")]
		public QVJVKMAODSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x70A3610", Offset = "0x70A2A10", VA = "0x1870A3610")]
		public QVJVKMAODSV(QVJVKMAODSV a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x70A3210", Offset = "0x70A2610", VA = "0x1870A3210")]
		public static QVJVKMAODSV Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x70A3490", Offset = "0x70A2890", VA = "0x1870A3490", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x70A34F0", Offset = "0x70A28F0", VA = "0x1870A34F0")]
		public void POIPQZRUEBL(JsonWriter a)
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
	public class OMQHEQKQGRQ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double TZEGVXUMDVC;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double TBDVHMJHXRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double SXPTFZXOTBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double EKMFUQMITZP;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x70A0B20", Offset = "0x709FF20", VA = "0x1870A0B20")]
		public OMQHEQKQGRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x70A0680", Offset = "0x709FA80", VA = "0x1870A0680")]
		public static OMQHEQKQGRQ Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70A08C0", Offset = "0x709FCC0", VA = "0x1870A08C0")]
		public void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class NKENEVSXINK : TKQQPTPBYXB
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color HXVCJSARDIP;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double DVAXEOEBJIB;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double QDXSDNLXGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType FHKJLFTGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color IREMFHUMQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double QBAEBFQWOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double BHQSEXQAYZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public OMQHEQKQGRQ OMQHEQKQGRQ;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x70A01C0", Offset = "0x709F5C0", VA = "0x1870A01C0")]
		public NKENEVSXINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x70A00A0", Offset = "0x709F4A0", VA = "0x1870A00A0")]
		public NKENEVSXINK(NKENEVSXINK a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x709F7B0", Offset = "0x709EBB0", VA = "0x18709F7B0")]
		public static NKENEVSXINK Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x709FBA0", Offset = "0x709EFA0", VA = "0x18709FBA0")]
		public static NKENEVSXINK Deserialize(WWOZGFPEXAT root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x709FCC0", Offset = "0x709F0C0", VA = "0x18709FCC0", Slot = "4")]
		public override void MFMKHXDBDDO(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class YXTLTCTLLOK : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<NQUQUSMUGND> LIZTFRQTEIH;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public YXTLTCTLLOK(IList<NQUQUSMUGND> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x70ABBC0", Offset = "0x70AAFC0", VA = "0x1870ABBC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x70ABB50", Offset = "0x70AAF50", VA = "0x1870ABB50", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class WVYZQVTBDHQ : DWUVLGQZHBQ, YIZOBDSRSKQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<NKENEVSXINK> OYKYAYRNQYX;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70A8460", Offset = "0x70A7860", VA = "0x1870A8460")]
		public WVYZQVTBDHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x70A75F0", Offset = "0x70A69F0", VA = "0x1870A75F0", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x70A7F10", Offset = "0x70A7310", VA = "0x1870A7F10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x70A7C60", Offset = "0x70A7060", VA = "0x1870A7C60")]
		private static string[] PYRZBBJZROI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x70A8000", Offset = "0x70A7400", VA = "0x1870A8000")]
		private static UTGSDXUYMZX.ImportValuesConversion XITETGKCYUW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x70A7870", Offset = "0x70A6C70", VA = "0x1870A7870", Slot = "6")]
		public bool EWVYNIIIYXF(WWOZGFPEXAT a, BUVFBYLBULO b, [Out] UTGSDXUYMZX c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class MURHYUAGYBP : BIQNACOUGNX<NKENEVSXINK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NKENEVSXINK Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x709F660", Offset = "0x709EA60", VA = "0x18709F660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x709F620", Offset = "0x709EA20", VA = "0x18709F620")]
		public MURHYUAGYBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x709F540", Offset = "0x709E940", VA = "0x18709F540")]
		public static MURHYUAGYBP Deserialize(WWOZGFPEXAT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class INMDVGMUQKO : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public MURHYUAGYBP YRQLJLJEHRF;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public INMDVGMUQKO(MURHYUAGYBP a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x709DEF0", Offset = "0x709D2F0", VA = "0x18709DEF0")]
		public INMDVGMUQKO(int a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x709DD70", Offset = "0x709D170", VA = "0x18709DD70", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x709DDF0", Offset = "0x709D1F0", VA = "0x18709DDF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class LMXZJBDNNMP : YIMZCLHZLHV
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x709EC00", Offset = "0x709E000", VA = "0x18709EC00")]
		public LMXZJBDNNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x709E720", Offset = "0x709DB20", VA = "0x18709E720", Slot = "4")]
		public override DWUVLGQZHBQ Deserialize(WWOZGFPEXAT root, JProperty extensionToken)
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
