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
	public class KHR_animation_pointer : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object UEBKBXENPZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string REQXFUKSFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string YDLODEQGXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public XLZIAVEJYKT YLGFHRMPAYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer GIHZMBXUBIM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x705EED0", Offset = "0x705DAD0", VA = "0x18705EED0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x705EE20", Offset = "0x705DA20", VA = "0x18705EE20", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ATATFNFNLRU
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 SYUITOMUAEF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 AKCFSWIWCVO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion UYPFLZHIKGM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool WXGLRZVWTFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7050FF0", Offset = "0x704FBF0", VA = "0x187050FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7050A50", Offset = "0x704F650", VA = "0x187050A50")]
		public static void NNXPJCEXJYI(this BLLWWIMDBED a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70511B0", Offset = "0x704FDB0", VA = "0x1870511B0")]
		public static void PFKGWIXKWQC(this BLLWWIMDBED a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70501C0", Offset = "0x704EDC0", VA = "0x1870501C0")]
		public static void KXSUVKGURLP(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x704FCE0", Offset = "0x704E8E0", VA = "0x18704FCE0")]
		public static GLTF.Math.Vector4 ICEMMPNPSWP(this BCSVALIDCKC a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7052FA0", Offset = "0x7051BA0", VA = "0x187052FA0")]
		public static UnityEngine.Quaternion ZOLEYTGFHNM(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7052E70", Offset = "0x7051A70", VA = "0x187052E70")]
		public static UnityEngine.Quaternion ZOLEYTGFHNM(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70516B0", Offset = "0x70502B0", VA = "0x1870516B0")]
		public static GLTF.Math.Quaternion PQKVVBRTXKG(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7052C50", Offset = "0x7051850", VA = "0x187052C50")]
		public static Matrix4x4 YTEBCUBEJRH(this BCSVALIDCKC a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7052810", Offset = "0x7051410", VA = "0x187052810")]
		public static Matrix4x4 YTEBCUBEJRH(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70522C0", Offset = "0x7050EC0", VA = "0x1870522C0")]
		public static BCSVALIDCKC XXZYYZQHQIR(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7052050", Offset = "0x7050C50", VA = "0x187052050")]
		public static UnityEngine.Vector3 WNUZLCQGKWU(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7051F70", Offset = "0x7050B70", VA = "0x187051F70")]
		public static UnityEngine.Vector3 WNUZLCQGKWU(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7051080", Offset = "0x704FC80", VA = "0x187051080")]
		public static GLTF.Math.Vector3 NVRIOPXJLHS(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7052170", Offset = "0x7050D70", VA = "0x187052170")]
		public static GLTF.Math.Vector3 WQBWGFMTJQZ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		public static GLTF.Math.Vector4 JHZRQXYKJBE(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7051B50", Offset = "0x7050750", VA = "0x187051B50")]
		public static Matrix4x4 TMTAVPPNGRW(this BCSVALIDCKC a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70518E0", Offset = "0x70504E0", VA = "0x1870518E0")]
		public static Matrix4x4 TMTAVPPNGRW(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7050880", Offset = "0x704F480", VA = "0x187050880")]
		public static BCSVALIDCKC MJEBBHDWXXS(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70517F0", Offset = "0x70503F0", VA = "0x1870517F0")]
		public static UnityEngine.Vector2 TIQLFTQRELG(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70517F0", Offset = "0x70503F0", VA = "0x1870517F0")]
		public static UnityEngine.Vector2 TIQLFTQRELG(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7051810", Offset = "0x7050410", VA = "0x187051810")]
		public static void TIQLFTQRELG(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7050730", Offset = "0x704F330", VA = "0x187050730")]
		public static UnityEngine.Vector3 LWOIIXYRCKN(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B190", Offset = "0x1A59D90", VA = "0x181A5B190")]
		public static UnityEngine.Vector3 LWOIIXYRCKN(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7050790", Offset = "0x704F390", VA = "0x187050790")]
		public static void LWOIIXYRCKN(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		public static UnityEngine.Vector4 IMIYTYQKZRI(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		public static UnityEngine.Vector4 IMIYTYQKZRI(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x704FF00", Offset = "0x704EB00", VA = "0x18704FF00")]
		public static UnityEngine.Vector4[] IMIYTYQKZRI(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7050000", Offset = "0x704EC00", VA = "0x187050000")]
		public static void IMIYTYQKZRI(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7052630", Offset = "0x7051230", VA = "0x187052630")]
		public static UnityEngine.Color YAYGPBVGXFS(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70526D0", Offset = "0x70512D0", VA = "0x1870526D0")]
		public static void YAYGPBVGXFS(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7052630", Offset = "0x7051230", VA = "0x187052630")]
		public static UnityEngine.Color YAYGPBVGXFS(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		public static UnityEngine.Color XOPWQKRARHV(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70521B0", Offset = "0x7050DB0", VA = "0x1870521B0")]
		public static void XOPWQKRARHV(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		public static UnityEngine.Color XOPWQKRARHV(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7052600", Offset = "0x7051200", VA = "0x187052600")]
		public static GLTF.Math.Color YAMWEHFVGRP(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x704F8C0", Offset = "0x704E4C0", VA = "0x18704F8C0")]
		public static GLTF.Math.Color EVIQUSLACDC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x704FC60", Offset = "0x704E860", VA = "0x18704FC60")]
		public static GLTF.Math.Color IAELFJXGDHQ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x704F940", Offset = "0x704E540", VA = "0x18704F940")]
		public static UnityEngine.Color[] GJTLNNMOPQH(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x704F840", Offset = "0x704E440", VA = "0x18704F840")]
		public static int[] BRMXKMAEKNM(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7050110", Offset = "0x704ED10", VA = "0x187050110")]
		public static UnityEngine.Vector2[] KKRYIFKEJFD(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x704FA60", Offset = "0x704E660", VA = "0x18704FA60")]
		public static void HRRNVKVRTTE(RWGTRHNJMXE a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7051E10", Offset = "0x7050A10", VA = "0x187051E10")]
		public static UnityEngine.Vector3[] WNKXCDGYUYO(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7050590", Offset = "0x704F190", VA = "0x187050590")]
		public static UnityEngine.Vector4[] LPTPZASRKVZ(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x704FBF0", Offset = "0x704E7F0", VA = "0x18704FBF0")]
		public static void HUBLQIHKAMO(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x704FBC0", Offset = "0x704E7C0", VA = "0x18704FBC0")]
		public static UnityEngine.Quaternion HSYRELUJFBK(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RWGTRHNJMXE
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MJWREBQWBGJ MJWREBQWBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray WPBAMMYJWYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7067490", Offset = "0x7066090", VA = "0x187067490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> TXTZDRJIOGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBC3FC0", Offset = "0xBC2BC0", VA = "0x180BC3FC0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCBEE30", Offset = "0xCBDA30", VA = "0x180CBEE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint TGMCCBEQITO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA3860", Offset = "0xAA2460", VA = "0x180AA3860")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3D40", Offset = "0xAA2940", VA = "0x180AA3D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70674A0", Offset = "0x70660A0", VA = "0x1870674A0")]
		public RWGTRHNJMXE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7057EC0", Offset = "0x7056AC0", VA = "0x187057EC0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7057F20", Offset = "0x7056B20", VA = "0x187057F20")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QHMIUCPJJYT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CYOJYCIJLVK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> CCXDQPQYQVY;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CYOJYCIJLVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7055D00", Offset = "0x7054900", VA = "0x187055D00")]
			internal int? NOVQYWAQLUL(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7055D80", Offset = "0x7054980", VA = "0x187055D80")]
			internal int? OAMJWRMPFKG(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7055C30", Offset = "0x7054830", VA = "0x187055C30")]
			internal bool AUMHRWFHGMS(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7066610", Offset = "0x7065210", VA = "0x187066610")]
		private static void TYFXHOOMPPW(NumericArray a, RWGTRHNJMXE b, RWGTRHNJMXE c, RWGTRHNJMXE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7064BA0", Offset = "0x70637A0", VA = "0x187064BA0")]
		public static void ITWMAQCVNCF(Dictionary<string, RWGTRHNJMXE> a, Dictionary<string, (RWGTRHNJMXE sparseIndices, RWGTRHNJMXE sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7066B80", Offset = "0x7065780", VA = "0x187066B80")]
		public static void YCWWMXDEIFH(Dictionary<string, RWGTRHNJMXE> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7066070", Offset = "0x7064C70", VA = "0x187066070")]
		public static void PZICRMJOYJU(RWGTRHNJMXE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7064610", Offset = "0x7063210", VA = "0x187064610")]
		public static void HLZJYOAGYVS(Dictionary<string, List<RWGTRHNJMXE>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7065F40", Offset = "0x7064B40", VA = "0x187065F40")]
		private static void OPWZMZLJWZO(RWGTRHNJMXE a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7065E80", Offset = "0x7064A80", VA = "0x187065E80")]
		internal static void OPWZMZLJWZO(LRPOVVMIRJS a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7066170", Offset = "0x7064D70", VA = "0x187066170")]
		public static SXJHZCBZTKC REOUHUFSJQE(IEnumerable<SXJHZCBZTKC> a)
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
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2DEBBC0", Offset = "0x2DEA7C0", VA = "0x182DEBBC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2DEBBD0", Offset = "0x2DEA7D0", VA = "0x182DEBBD0")]
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
	public class DWHCJAWSYTX
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint IJRQEYHUSZA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint VGANIQRROVW;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint XMKXXPYUUVU;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7056AE0", Offset = "0x70556E0", VA = "0x187056AE0")]
		public static void FWCQOYWLMWA(Stream a, [Out] NJKZJMRMPCW b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7056EA0", Offset = "0x7055AA0", VA = "0x187056EA0")]
		public static ChunkInfo OLMIASWWEWA(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7057490", Offset = "0x7056090", VA = "0x187057490")]
		public static GLBHeader ZVIUMWIYVEA(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7057130", Offset = "0x7055D30", VA = "0x187057130")]
		public static bool UENDXXNCADQ(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7056D30", Offset = "0x7055930", VA = "0x187056D30")]
		public static ChunkInfo NAQYWTUKVKD(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x70571F0", Offset = "0x7055DF0", VA = "0x1870571F0")]
		private static void UQIWAJTSQNX(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7056CA0", Offset = "0x70558A0", VA = "0x187056CA0")]
		private static uint IYTURQMUTVS(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WOBAGJVCJMH
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
		public PathElement HCXWPNIVUHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA2D20", Offset = "0xAA1920", VA = "0x180AA2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int GYQTBABAQUV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB0BC00", Offset = "0xB0A800", VA = "0x180B0BC00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB0BB30", Offset = "0xB0A730", VA = "0x180B0BB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string WUOKAJGANWS
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool INOURMEROAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA988B0", Offset = "0xA974B0", VA = "0x180A988B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA98890", Offset = "0xA97490", VA = "0x180A98890")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public WOBAGJVCJMH UHYCFEFPEUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA98380", Offset = "0xA96F80", VA = "0x180A98380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70692A0", Offset = "0x7067EA0", VA = "0x1870692A0")]
		public string TCHBEOTTNQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7069280", Offset = "0x7067E80", VA = "0x187069280")]
		public WOBAGJVCJMH RKTEKEARKOJ(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x70696F0", Offset = "0x70682F0", VA = "0x1870696F0")]
		private WOBAGJVCJMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7069540", Offset = "0x7068140", VA = "0x187069540")]
		public WOBAGJVCJMH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3FFDD20", Offset = "0x3FFC920", VA = "0x183FFDD20")]
		[CompilerGenerated]
		internal static string TJBLDXXIWST(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7069500", Offset = "0x7068100", VA = "0x187069500")]
		[CompilerGenerated]
		internal static bool WFQJQKLWOOC([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7069320", Offset = "0x7067F20", VA = "0x187069320")]
		[CompilerGenerated]
		internal static WOBAGJVCJMH ULWONVLXDVS(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class YIHIVPDFRRO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7069EE0", Offset = "0x7068AE0", VA = "0x187069EE0")]
		public static int[] WQVWONFPMDM(this NJKZJMRMPCW a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7069D90", Offset = "0x7068990", VA = "0x187069D90")]
		public static int[] SUWTRHSDBKM(this NJKZJMRMPCW a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LLKFCDDRAWA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7063370", Offset = "0x7061F70", VA = "0x187063370")]
		public static uint SJRGNRBTOPZ(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream JSTWGNDGYZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long QOYZFREAXEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long AZJLOHTTELF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7067B70", Offset = "0x7066770", VA = "0x187067B70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7067BB0", Offset = "0x70667B0", VA = "0x187067BB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7067BB0", Offset = "0x70667B0", VA = "0x187067BB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7067BD0", Offset = "0x70667D0", VA = "0x187067BD0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7067BF0", Offset = "0x70667F0", VA = "0x187067BF0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7067C10", Offset = "0x7066810", VA = "0x187067C10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7067900", Offset = "0x7066500", VA = "0x187067900")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7067750", Offset = "0x7066350", VA = "0x187067750", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7067820", Offset = "0x7066420", VA = "0x187067820", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7067880", Offset = "0x7066480", VA = "0x187067880", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7067790", Offset = "0x7066390", VA = "0x187067790", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x70678C0", Offset = "0x70664C0", VA = "0x1870678C0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70676C0", Offset = "0x70662C0", VA = "0x1870676C0")]
		private void DLADGJGDZEW()
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
		public static Color AJJPFSXWVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7055E20", Offset = "0x7054A20", VA = "0x187055E20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color IWRKONRBBRC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7055E10", Offset = "0x7054A10", VA = "0x187055E10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color NEWOOHKFMAI
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7055F90", Offset = "0x7054B90", VA = "0x187055F90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE340", VA = "0x182AFF740")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEE0", Offset = "0x2B5AAE0", VA = "0x182B5BEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28D39D0", Offset = "0x28D25D0", VA = "0x1828D39D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2250", Offset = "0x2FE0E50", VA = "0x182FE2250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFE0", Offset = "0x11FDBE0", VA = "0x1811FEFE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFF0", Offset = "0x11FDBF0", VA = "0x1811FEFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28956E0", Offset = "0x28942E0", VA = "0x1828956E0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7055E40", Offset = "0x7054A40", VA = "0x187055E40", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7055EF0", Offset = "0x7054AF0", VA = "0x187055EF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7055FB0", Offset = "0x7054BB0", VA = "0x187055FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7056060", Offset = "0x7054C60", VA = "0x187056060")]
		public static bool QHJSFCGIZAO(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BCSVALIDCKC : IEquatable<BCSVALIDCKC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly BCSVALIDCKC DVCGDVAOOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] OMNDFVBZUID;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float IOXTNOFIKZC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x70540B0", Offset = "0x7052CB0", VA = "0x1870540B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7053CC0", Offset = "0x70528C0", VA = "0x187053CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ONGQZGTVUPB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7053F30", Offset = "0x7052B30", VA = "0x187053F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7053780", Offset = "0x7052380", VA = "0x187053780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float UNPJQDPDFOK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7053DE0", Offset = "0x70529E0", VA = "0x187053DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7054050", Offset = "0x7052C50", VA = "0x187054050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ASKTSEQKFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x70538A0", Offset = "0x70524A0", VA = "0x1870538A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7053ED0", Offset = "0x7052AD0", VA = "0x187053ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float IPNOFINANHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x70540E0", Offset = "0x7052CE0", VA = "0x1870540E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7053CF0", Offset = "0x70528F0", VA = "0x187053CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ONLXWNNTEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7053F90", Offset = "0x7052B90", VA = "0x187053F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x70537E0", Offset = "0x70523E0", VA = "0x1870537E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float UNKCSWVFWDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7053D80", Offset = "0x7052980", VA = "0x187053D80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7053FF0", Offset = "0x7052BF0", VA = "0x187053FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float ARUZAKISCVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7053870", Offset = "0x7052470", VA = "0x187053870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7053EA0", Offset = "0x7052AA0", VA = "0x187053EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float IPIHIBTDDVU
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7054110", Offset = "0x7052D10", VA = "0x187054110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7053D20", Offset = "0x7052920", VA = "0x187053D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ONRETUHQNLT
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7053F60", Offset = "0x7052B60", VA = "0x187053F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x70537B0", Offset = "0x70523B0", VA = "0x1870537B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float UNEVVQBIMRS
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7053DB0", Offset = "0x70529B0", VA = "0x187053DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7054020", Offset = "0x7052C20", VA = "0x187054020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float ASAFXRCPMGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7053840", Offset = "0x7052440", VA = "0x187053840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7053E70", Offset = "0x7052A70", VA = "0x187053E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float IOHYVTXQIRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7054080", Offset = "0x7052C80", VA = "0x187054080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7053D50", Offset = "0x7052950", VA = "0x187053D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float OMGIMYYIZKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7053F00", Offset = "0x7052B00", VA = "0x187053F00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7053810", Offset = "0x7052410", VA = "0x187053810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float UMZOYJHLDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7053E10", Offset = "0x7052A10", VA = "0x187053E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7053FC0", Offset = "0x7052BC0", VA = "0x187053FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float ARKLFWUXJYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x70538D0", Offset = "0x70524D0", VA = "0x1870538D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7053E40", Offset = "0x7052A40", VA = "0x187053E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7054220", Offset = "0x7052E20", VA = "0x187054220")]
		public BCSVALIDCKC(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7053A00", Offset = "0x7052600", VA = "0x187053A00", Slot = "4")]
		public bool Equals(BCSVALIDCKC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7053900", Offset = "0x7052500", VA = "0x187053900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDCF880", Offset = "0xDCE480", VA = "0x180DCF880", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE340", VA = "0x182AFF740")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEE0", Offset = "0x2B5AAE0", VA = "0x182B5BEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x28D39D0", Offset = "0x28D25D0", VA = "0x1828D39D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2250", Offset = "0x2FE0E50", VA = "0x182FE2250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFE0", Offset = "0x11FDBE0", VA = "0x1811FEFE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFF0", Offset = "0x11FDBF0", VA = "0x1811FEFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7067400", Offset = "0x7066000", VA = "0x187067400")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7067060", Offset = "0x7065C60", VA = "0x187067060", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7067180", Offset = "0x7065D80", VA = "0x187067180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7067230", Offset = "0x7065E30", VA = "0x187067230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7067310", Offset = "0x7065F10", VA = "0x187067310")]
		public static bool QHJSFCGIZAO(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE340", VA = "0x182AFF740")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEE0", Offset = "0x2B5AAE0", VA = "0x182B5BEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD47580", Offset = "0xD46180", VA = "0x180D47580")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70681D0", Offset = "0x7066DD0", VA = "0x1870681D0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7067FE0", Offset = "0x7066BE0", VA = "0x187067FE0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7068040", Offset = "0x7066C40", VA = "0x187068040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7068120", Offset = "0x7066D20", VA = "0x187068120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7068170", Offset = "0x7066D70", VA = "0x187068170")]
		public static bool QHJSFCGIZAO(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE340", VA = "0x182AFF740")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEE0", Offset = "0x2B5AAE0", VA = "0x182B5BEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28D39D0", Offset = "0x28D25D0", VA = "0x1828D39D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2250", Offset = "0x2FE0E50", VA = "0x182FE2250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7068590", Offset = "0x7067190", VA = "0x187068590")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x70681F0", Offset = "0x7066DF0", VA = "0x1870681F0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x70682D0", Offset = "0x7066ED0", VA = "0x1870682D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7068390", Offset = "0x7066F90", VA = "0x187068390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7068440", Offset = "0x7067040", VA = "0x187068440")]
		public static bool QHJSFCGIZAO(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE340", VA = "0x182AFF740")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BEE0", Offset = "0x2B5AAE0", VA = "0x182B5BEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x28D39D0", Offset = "0x28D25D0", VA = "0x1828D39D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2250", Offset = "0x2FE0E50", VA = "0x182FE2250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFE0", Offset = "0x11FDBE0", VA = "0x1811FEFE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x11FEFF0", Offset = "0x11FDBF0", VA = "0x1811FEFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28956E0", Offset = "0x28942E0", VA = "0x1828956E0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7055E40", Offset = "0x7054A40", VA = "0x187055E40", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7068610", Offset = "0x7067210", VA = "0x187068610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7055FB0", Offset = "0x7054BB0", VA = "0x187055FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class PEEIAECNGVG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7064590", Offset = "0x7063190", VA = "0x187064590")]
		public static void DDKORCBWBER(this JObject a, string b, LVHYOCETPXM c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LLKFCDDRAWA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7064110", Offset = "0x7062D10", VA = "0x187064110")]
		public static List<string> ZFLLOULAIUC(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7062C00", Offset = "0x7061800", VA = "0x187062C00")]
		public static List<double> OSLWPAQEQOW(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x70634C0", Offset = "0x70620C0", VA = "0x1870634C0")]
		public static List<int> SNCSVLALUAZ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37880D0", Offset = "0x3786CD0", VA = "0x1837880D0")]
		public static List<a> QRALLFAVBST<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7063960", Offset = "0x7062560", VA = "0x187063960")]
		public static LVHYOCETPXM UFGWCMGYZYF(this JToken a, NJKZJMRMPCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7063230", Offset = "0x7061E30", VA = "0x187063230")]
		public static int RVTLUZIEGMH(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7062800", Offset = "0x7061400", VA = "0x187062800")]
		public static double JJHMKAAQDAP(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7063680", Offset = "0x7062280", VA = "0x187063680")]
		public static GLTF.Math.Color SPYUTUOOKAI(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7063EA0", Offset = "0x7062AA0", VA = "0x187063EA0")]
		public static GLTF.Math.Color WHRPVMXEXPH(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7063C00", Offset = "0x7062800", VA = "0x187063C00")]
		public static GLTF.Math.Color VMVDNARORRD(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7062940", Offset = "0x7061540", VA = "0x187062940")]
		public static GLTF.Math.Vector3 KUNQLVDPAMV(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7063020", Offset = "0x7061C20", VA = "0x187063020")]
		public static GLTF.Math.Vector2 PLHYZLGLCYN(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7062DC0", Offset = "0x70619C0", VA = "0x187062DC0")]
		public static GLTF.Math.Vector3 PLCSCEMNTNE(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70624F0", Offset = "0x70610F0", VA = "0x1870624F0")]
		public static GLTF.Math.Quaternion BTLUXZPVRPV(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3787AC0", Offset = "0x37866C0", VA = "0x183787AC0")]
		public static Dictionary<string, b> MDDVJNRIJIL<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3787770", Offset = "0x3786370", VA = "0x183787770")]
		public static c KJCNJELYBKH<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LRPOVVMIRJS bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x70578D0", Offset = "0x70564D0", VA = "0x1870578D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7057850", Offset = "0x7056450", VA = "0x187057850", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ZERDYKKJPVJ : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x706AA20", Offset = "0x7069620", VA = "0x18706AA20")]
		public ZERDYKKJPVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x706A950", Offset = "0x7069550", VA = "0x18706A950", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, MJWREBQWBGJ> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7057710", Offset = "0x7056310", VA = "0x187057710", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70577D0", Offset = "0x70563D0", VA = "0x1870577D0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class WRJNDHXCMMZ : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public NJKZJMRMPCW CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader VTJMKFLAXCI;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7057AF0", Offset = "0x70566F0", VA = "0x187057AF0")]
			internal MJWREBQWBGJ OFKNKLNAZQS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7069C20", Offset = "0x7068820", VA = "0x187069C20")]
		public WRJNDHXCMMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7069A90", Offset = "0x7068690", VA = "0x187069A90", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NZSWVWQSFVL YACMTVFMAVA;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public EXT_texture_exr(NZSWVWQSFVL source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7057920", Offset = "0x7056520", VA = "0x187057920", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7057990", Offset = "0x7056590", VA = "0x187057990", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class VUGECQUPXLO : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7067F90", Offset = "0x7066B90", VA = "0x187067F90")]
		public VUGECQUPXLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7067E70", Offset = "0x7066A70", VA = "0x187067E70", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
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
	public class AudioEmitterId : PBEMSQLQDPC<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x70534A0", Offset = "0x70520A0", VA = "0x1870534A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7053460", Offset = "0x7052060", VA = "0x187053460")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : PBEMSQLQDPC<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7053630", Offset = "0x7052230", VA = "0x187053630", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70535F0", Offset = "0x70521F0", VA = "0x1870535F0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : PBEMSQLQDPC<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7053310", Offset = "0x7051F10", VA = "0x187053310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70532D0", Offset = "0x7051ED0", VA = "0x1870532D0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70531F0", Offset = "0x7051DF0", VA = "0x1870531F0")]
		public static AudioDataId Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x705EB40", Offset = "0x705D740", VA = "0x18705EB40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x705E740", Offset = "0x705D340", VA = "0x18705E740", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x705E7B0", Offset = "0x705D3B0", VA = "0x18705E7B0")]
		public static KHR_SceneAudioEmittersRef Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x705EDA0", Offset = "0x705D9A0", VA = "0x18705EDA0")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x705E710", Offset = "0x705D310", VA = "0x18705E710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x705E5F0", Offset = "0x705D1F0", VA = "0x18705E5F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x705E3E0", Offset = "0x705CFE0", VA = "0x18705E3E0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x705E450", Offset = "0x705D050", VA = "0x18705E450")]
		public static KHR_NodeAudioEmitterRef Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class WACQQHEPWBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string EYVTIILVQLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? BRQCISCUQTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? PQNRBAIJWVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? SJDMXASMGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? JVUMMGZSJNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? ESQZRZATUNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? IBVPLFZXWZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? KDJFCBXGYLQ;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x70686B0", Offset = "0x70672B0", VA = "0x1870686B0")]
		public JObject DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7068920", Offset = "0x7067520", VA = "0x187068920")]
		public static WACQQHEPWBH Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public WACQQHEPWBH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : FIRPRGZIJCU
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
		public WACQQHEPWBH positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x705D530", Offset = "0x705C130", VA = "0x18705D530", Slot = "5")]
		public virtual JObject DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x705D8D0", Offset = "0x705C4D0", VA = "0x18705D8D0")]
		public static KHR_AudioEmitter Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x705DDD0", Offset = "0x705C9D0", VA = "0x18705DDD0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : FIRPRGZIJCU
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
		[Cpp2IlInjected.Address(RVA = "0x705DE50", Offset = "0x705CA50", VA = "0x18705DE50")]
		public JObject DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x705E080", Offset = "0x705CC80", VA = "0x18705E080")]
		public static KHR_AudioSource Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x705D190", Offset = "0x705BD90", VA = "0x18705D190")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JARJHZOCART bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x705D1A0", Offset = "0x705BDA0", VA = "0x18705D1A0")]
		public JObject DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x705D2D0", Offset = "0x705BED0", VA = "0x18705D2D0")]
		public static KHR_AudioData Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x705D190", Offset = "0x705BD90", VA = "0x18705D190")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : JRZEQPOWTYP
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
		[Cpp2IlInjected.Address(RVA = "0x705F060", Offset = "0x705DC60", VA = "0x18705F060", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x705EFD0", Offset = "0x705DBD0", VA = "0x18705EFD0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x705F790", Offset = "0x705E390", VA = "0x18705F790")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class CBJNYPXGIGY : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7055BE0", Offset = "0x70547E0", VA = "0x187055BE0")]
		public CBJNYPXGIGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7055020", Offset = "0x7053C20", VA = "0x187055020", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JARJHZOCART bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x705F960", Offset = "0x705E560", VA = "0x18705F960", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x705F8A0", Offset = "0x705E4A0", VA = "0x18705F8A0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x705F9B0", Offset = "0x705E5B0", VA = "0x18705F9B0")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class WGUXUNNXFRY : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader VTJMKFLAXCI;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7057A80", Offset = "0x7056680", VA = "0x187057A80")]
			internal int OFKNKLNAZQS()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7069230", Offset = "0x7067E30", VA = "0x187069230")]
		public WGUXUNNXFRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7069020", Offset = "0x7067C20", VA = "0x187069020", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LVHYOCETPXM anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x705FAB0", Offset = "0x705E6B0", VA = "0x18705FAB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x705FA30", Offset = "0x705E630", VA = "0x18705FA30", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class DQRCTYINZWF : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7056A90", Offset = "0x7055690", VA = "0x187056A90")]
		public DQRCTYINZWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x70568E0", Offset = "0x70554E0", VA = "0x1870568E0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LVHYOCETPXM clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public LVHYOCETPXM clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public LVHYOCETPXM clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x705FD60", Offset = "0x705E960", VA = "0x18705FD60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x705FCC0", Offset = "0x705E8C0", VA = "0x18705FCC0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class NOQPFMLMIIT : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7064540", Offset = "0x7063140", VA = "0x187064540")]
		public NOQPFMLMIIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x70642C0", Offset = "0x7062EC0", VA = "0x1870642C0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x70600C0", Offset = "0x705ECC0", VA = "0x1870600C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7060050", Offset = "0x705EC50", VA = "0x187060050", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class XKSRBBKLOHR : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7069D40", Offset = "0x7068940", VA = "0x187069D40")]
		public XKSRBBKLOHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7069C70", Offset = "0x7068870", VA = "0x187069C70", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : VQHHWQVMKSL, JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float TXQSBJKKUZL;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x70603A0", Offset = "0x705EFA0", VA = "0x1870603A0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x70603F0", Offset = "0x705EFF0", VA = "0x1870603F0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, NJKZJMRMPCW root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70601E0", Offset = "0x705EDE0", VA = "0x1870601E0", Slot = "6")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7060280", Offset = "0x705EE80", VA = "0x187060280", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class IXZAEIVVXRW : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x70587C0", Offset = "0x70573C0", VA = "0x1870587C0")]
		public IXZAEIVVXRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x70586C0", Offset = "0x70572C0", VA = "0x1870586C0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x70604C0", Offset = "0x705F0C0", VA = "0x1870604C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7060460", Offset = "0x705F060", VA = "0x187060460", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7060610", Offset = "0x705F210", VA = "0x187060610")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class BFYWWJEDIRR : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x70545A0", Offset = "0x70531A0", VA = "0x1870545A0")]
		public BFYWWJEDIRR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x70544D0", Offset = "0x70530D0", VA = "0x1870544D0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LVHYOCETPXM iridescenceTexture;

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
		public LVHYOCETPXM iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70606C0", Offset = "0x705F2C0", VA = "0x1870606C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7060620", Offset = "0x705F220", VA = "0x187060620", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7060A80", Offset = "0x705F680", VA = "0x187060A80")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class WONFYTWAQHT : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7069A40", Offset = "0x7068640", VA = "0x187069A40")]
		public WONFYTWAQHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7069750", Offset = "0x7068350", VA = "0x187069750", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class BJZVBDZPUVK : JRZEQPOWTYP
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 AJHXCUCDKQU;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double VZJLFICMSFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color GASITBZJVOQ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color IOUAOERAGZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LVHYOCETPXM PHMWQHGVVLM;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly LVHYOCETPXM BSYNLMCSIFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 UPLNWALAFUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double JSGZDVLPMXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LVHYOCETPXM NCYGGHGWPBF;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly LVHYOCETPXM RECXUJOBXMT;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7054F20", Offset = "0x7053B20", VA = "0x187054F20")]
		public BJZVBDZPUVK(GLTF.Math.Color a, LVHYOCETPXM b, GLTF.Math.Vector3 c, double d, LVHYOCETPXM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70545F0", Offset = "0x70531F0", VA = "0x1870545F0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70547B0", Offset = "0x70533B0", VA = "0x1870547B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class IVWEQBARINI : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7058670", Offset = "0x7057270", VA = "0x187058670")]
		public IVWEQBARINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7058310", Offset = "0x7056F10", VA = "0x187058310", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LVHYOCETPXM sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LVHYOCETPXM sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7060B70", Offset = "0x705F770", VA = "0x187060B70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7060AA0", Offset = "0x705F6A0", VA = "0x187060AA0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7061080", Offset = "0x705FC80", VA = "0x187061080")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class YMDYBPUKMHO : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x706A3E0", Offset = "0x7068FE0", VA = "0x18706A3E0")]
		public YMDYBPUKMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x706A180", Offset = "0x7068D80", VA = "0x18706A180", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LVHYOCETPXM specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LVHYOCETPXM specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70611C0", Offset = "0x705FDC0", VA = "0x1870611C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x70610F0", Offset = "0x705FCF0", VA = "0x1870610F0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x70616E0", Offset = "0x70602E0", VA = "0x1870616E0")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ZJCRZGDBVRO : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x706ADE0", Offset = "0x70699E0", VA = "0x18706ADE0")]
		public ZJCRZGDBVRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x706ABC0", Offset = "0x70697C0", VA = "0x18706ABC0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LVHYOCETPXM transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x70617D0", Offset = "0x70603D0", VA = "0x1870617D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7061750", Offset = "0x7060350", VA = "0x187061750", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ADQHAKMYVZL : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x704F7F0", Offset = "0x704E3F0", VA = "0x18704F7F0")]
		public ADQHAKMYVZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x704F6B0", Offset = "0x704E2B0", VA = "0x18704F6B0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class YTSHQEKHKTA : VQHHWQVMKSL, JRZEQPOWTYP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x706A900", Offset = "0x7069500", VA = "0x18706A900")]
		public YTSHQEKHKTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x706A890", Offset = "0x7069490", VA = "0x18706A890")]
		public YTSHQEKHKTA(YTSHQEKHKTA a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x706A690", Offset = "0x7069290", VA = "0x18706A690", Slot = "6")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x706A730", Offset = "0x7069330", VA = "0x18706A730", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x706A7C0", Offset = "0x70693C0", VA = "0x18706A7C0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class EKIGCPQIYJG : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x70576C0", Offset = "0x70562C0", VA = "0x1870576C0")]
		public EKIGCPQIYJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7057640", Offset = "0x7056240", VA = "0x187057640", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LVHYOCETPXM thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70619F0", Offset = "0x70605F0", VA = "0x1870619F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7061960", Offset = "0x7060560", VA = "0x187061960", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7061F20", Offset = "0x7060B20", VA = "0x187061F20")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class YSNHYZMSFXR : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x706A640", Offset = "0x7069240", VA = "0x18706A640")]
		public YSNHYZMSFXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x706A430", Offset = "0x7069030", VA = "0x18706A430", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7061FA0", Offset = "0x7060BA0", VA = "0x187061FA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7061F40", Offset = "0x7060B40", VA = "0x187061F40", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF0FC80", Offset = "0xF0E880", VA = "0x180F0FC80")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class GOYIBJTHFNX : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7058190", Offset = "0x7056D90", VA = "0x187058190")]
		public GOYIBJTHFNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x70580B0", Offset = "0x7056CB0", VA = "0x1870580B0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7062110", Offset = "0x7060D10", VA = "0x187062110", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x70620B0", Offset = "0x7060CB0", VA = "0x1870620B0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF0FC80", Offset = "0xF0E880", VA = "0x180F0FC80")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class GOSFYINDRWP : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7058060", Offset = "0x7056C60", VA = "0x187058060")]
		public GOSFYINDRWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7057F80", Offset = "0x7056B80", VA = "0x187057F80", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7062280", Offset = "0x7060E80", VA = "0x187062280", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7062220", Offset = "0x7060E20", VA = "0x187062220", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF0FC80", Offset = "0xF0E880", VA = "0x180F0FC80")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ICBYPFZOXUV : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x70582C0", Offset = "0x7056EC0", VA = "0x1870582C0")]
		public ICBYPFZOXUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x70581E0", Offset = "0x7056DE0", VA = "0x1870581E0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NZSWVWQSFVL source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public KHR_texture_basisu(NZSWVWQSFVL source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7062390", Offset = "0x7060F90", VA = "0x187062390", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7062400", Offset = "0x7061000", VA = "0x187062400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class VHMESPUJVUX : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7067E20", Offset = "0x7066A20", VA = "0x187067E20")]
		public VHMESPUJVUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7067CC0", Offset = "0x70668C0", VA = "0x187067CC0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class DNMFUSHNSDG : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 TGMCCBEQITO;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 UIRKCBOSFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double AWDLCCGDDQF;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double ODYNLNLMSSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 JWUOPNQQOOD;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 AZJMXGXNIQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? EECMVDZCCSZ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int MHQFBCARVPB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7056860", Offset = "0x7055460", VA = "0x187056860")]
		public DNMFUSHNSDG(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7056110", Offset = "0x7054D10", VA = "0x187056110", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x70561F0", Offset = "0x7054DF0", VA = "0x1870561F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class GDGXHOTPBGK : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7057E70", Offset = "0x7056A70", VA = "0x187057E70")]
		public GDGXHOTPBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7057BA0", Offset = "0x70567A0", VA = "0x187057BA0", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SRXSDENXERQ : JRZEQPOWTYP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> QSBNTKISPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public SRXSDENXERQ(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70674D0", Offset = "0x70660D0", VA = "0x1870674D0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7067540", Offset = "0x7066140", VA = "0x187067540", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7067630", Offset = "0x7066230", VA = "0x187067630")]
		public List<double> UMHNXLOFHTU(BLLWWIMDBED a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ZHIGKIBRKEM : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x706AB70", Offset = "0x7069770", VA = "0x18706AB70")]
		public ZHIGKIBRKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x706AA70", Offset = "0x7069670", VA = "0x18706AA70", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class JIHZXFMJKOY : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JARJHZOCART LRPOVVMIRJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint IGUAAYYDPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType EZPUZMZQUVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool XOYDSXATJFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint PAZVGVVRFWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType XSYNALKQIRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> EJMUKQAYMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> CQPPHSXXBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TMRNNGNMPIQ NCIEVPYOMJB;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x705D190", Offset = "0x705BD90", VA = "0x18705D190")]
		public JIHZXFMJKOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7059A70", Offset = "0x7058670", VA = "0x187059A70")]
		public static JIHZXFMJKOY Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x70590B0", Offset = "0x7057CB0", VA = "0x1870590B0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x705A490", Offset = "0x7059090", VA = "0x18705A490")]
		private unsafe static sbyte VDVGDDPKXJX(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x705A730", Offset = "0x7059330", VA = "0x18705A730")]
		private unsafe static float2 FMWZJFBJMDX(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x705C490", Offset = "0x705B090", VA = "0x18705C490")]
		private unsafe static float3 SMYCVZSDDZC(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x705A430", Offset = "0x7059030", VA = "0x18705A430")]
		private unsafe static float4 EZXPRHBOOBN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x705AA40", Offset = "0x7059640", VA = "0x18705AA40")]
		private unsafe static float4x4 HAOEJAGNUPF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x705A490", Offset = "0x7059090", VA = "0x18705A490")]
		private unsafe static byte FCRXKKYZTAK(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x705CE10", Offset = "0x705BA10", VA = "0x18705CE10")]
		private unsafe static float2 WRRGUVLRRMQ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x705BD60", Offset = "0x705A960", VA = "0x18705BD60")]
		private unsafe static float3 QMHJKRKXXTP(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x705BAE0", Offset = "0x705A6E0", VA = "0x18705BAE0")]
		private unsafe static float4 NEQMOAMVGBU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x705BB40", Offset = "0x705A740", VA = "0x18705BB40")]
		private unsafe static float4x4 NPIVSBAIPJM(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7058D30", Offset = "0x7057930", VA = "0x187058D30")]
		private unsafe static short DFCWBSYWXPJ(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x705BCE0", Offset = "0x705A8E0", VA = "0x18705BCE0")]
		private unsafe static float2 PMPXLCEVDIP(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x705CD60", Offset = "0x705B960", VA = "0x18705CD60")]
		private unsafe static float3 WAUUGIXIZQC(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x705CDB0", Offset = "0x705B9B0", VA = "0x18705CDB0")]
		private unsafe static float4 WREMBSYNGFX(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x705B820", Offset = "0x705A420", VA = "0x18705B820")]
		private unsafe static float4x4 MDBMIZNJCYN(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7058D30", Offset = "0x7057930", VA = "0x187058D30")]
		private unsafe static ushort UYGHCZAPCGS(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x705C070", Offset = "0x705AC70", VA = "0x18705C070")]
		private unsafe static float2 RJBICMMRWQU(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x705BDB0", Offset = "0x705A9B0", VA = "0x18705BDB0")]
		private unsafe static float3 QSOADUTVAGN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7059F30", Offset = "0x7058B30", VA = "0x187059F30")]
		private unsafe static float4x4 EPITZIPLFVE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7059ED0", Offset = "0x7058AD0", VA = "0x187059ED0")]
		private unsafe static float4 EBKBVMGRJPM(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x705AD00", Offset = "0x7059900", VA = "0x18705AD00")]
		private unsafe static uint HRVXGNWTLJZ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7058D30", Offset = "0x7057930", VA = "0x187058D30")]
		private unsafe static ushort ZLUJYWAGZBY(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x705A0D0", Offset = "0x7058CD0", VA = "0x18705A0D0")]
		private unsafe static float ETBURKJVGCH(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x705CE40", Offset = "0x705BA40", VA = "0x18705CE40")]
		private unsafe static float2 XPLMDAVHHUX(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x705AD10", Offset = "0x7059910", VA = "0x18705AD10")]
		private unsafe static float3 IOSQXIOCLPE(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x705CE60", Offset = "0x705BA60", VA = "0x18705CE60")]
		private unsafe static float4 XVTWMHPZHQV(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x705C4E0", Offset = "0x705B0E0", VA = "0x18705C4E0")]
		private unsafe static float4x4 TQZLPMGLEBL(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x705CE60", Offset = "0x705BA60", VA = "0x18705CE60")]
		private unsafe static float4 ZUODYMLCDVO(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x705D160", Offset = "0x705BD60", VA = "0x18705D160")]
		private unsafe static float4 ZUODYMLCDVO(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x705B2E0", Offset = "0x7059EE0", VA = "0x18705B2E0")]
		public static float3[] JVWIVJSLZFX(JIHZXFMJKOY a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x705B510", Offset = "0x705A110", VA = "0x18705B510")]
		public static float3[] LGODRESNJIZ(JIHZXFMJKOY a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x705C320", Offset = "0x705AF20", VA = "0x18705C320")]
		public static uint[] SBIGYPPIKQE(JIHZXFMJKOY a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x705ABE0", Offset = "0x70597E0", VA = "0x18705ABE0")]
		internal static void HHVEFQYLFYF(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x705C8A0", Offset = "0x705B4A0", VA = "0x18705C8A0")]
		public uint[] UYDJDPRSIQA(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x705BE00", Offset = "0x705AA00", VA = "0x18705BE00")]
		public float[] RFHCVGHRUXW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x705A4A0", Offset = "0x70590A0", VA = "0x18705A4A0")]
		public float2[] FIPYCFLLVBG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x70597C0", Offset = "0x70583C0", VA = "0x1870597C0")]
		public float2[] DXATWNDQJEG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x705C0A0", Offset = "0x705ACA0", VA = "0x18705C0A0")]
		public float3[] SAISTRBKFRT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x705A0E0", Offset = "0x7058CE0", VA = "0x18705A0E0")]
		public float3[] EUPOLVFFEXD(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x705CAF0", Offset = "0x705B6F0", VA = "0x18705CAF0")]
		public float4[] VPFWDOKWBRU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7058D40", Offset = "0x7057940", VA = "0x187058D40")]
		public float4[] DISMLOYYSRQ(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x705C510", Offset = "0x705B110", VA = "0x18705C510")]
		public float4[] TWMDPLNLBWL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7058810", Offset = "0x7057410", VA = "0x187058810")]
		public float3[] AEFVUMYCRWW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x705D050", Offset = "0x705BC50", VA = "0x18705D050")]
		public float3[] YZWYQWYGSIJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7058C60", Offset = "0x7057860", VA = "0x187058C60")]
		public float4[] CZLWNYRAZUR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x705BD10", Offset = "0x705A910", VA = "0x18705BD10")]
		public uint[] QGTTFYNUFBW(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x705AD30", Offset = "0x7059930", VA = "0x18705AD30")]
		public float4x4[] JKZDSJHREOX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7058920", Offset = "0x7057520", VA = "0x187058920")]
		private unsafe static float4 CNQLYVHTHIH(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7058AE0", Offset = "0x70576E0", VA = "0x187058AE0")]
		private unsafe static float4 CNQLYVHTHIH(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x705A760", Offset = "0x7059360", VA = "0x18705A760")]
		private unsafe static float4x4 FMZCUWHQDVG(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x705CE90", Offset = "0x705BA90", VA = "0x18705CE90")]
		private unsafe static float4 YRIQSCJILHO(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x705A8D0", Offset = "0x70594D0", VA = "0x18705A8D0")]
		private unsafe static float3 GXXRYLCEJCX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7059690", Offset = "0x7058290", VA = "0x187059690")]
		private unsafe static float2 DQENRSDNSSO(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x705B9C0", Offset = "0x705A5C0", VA = "0x18705B9C0")]
		private unsafe static uint MSOOTLQCTZV(void* a, uint b, GLTFComponentType c)
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
	public static class IDOYYEVOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7070AD0", Offset = "0x706F6D0", VA = "0x187070AD0")]
		public static int QKJBMFCBYUZ(this GLTFAccessorAttributeType a)
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
	public class TMRNNGNMPIQ : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int PAZVGVVRFWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public XHBBUVVKRLH JTSLWINZEWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CKRFMCAYMUK VDKQYNIMLMZ;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x707AC20", Offset = "0x7079820", VA = "0x18707AC20")]
		public TMRNNGNMPIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x707A950", Offset = "0x7079550", VA = "0x18707A950")]
		public static TMRNNGNMPIQ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x707A820", Offset = "0x7079420", VA = "0x18707A820", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class XHBBUVVKRLH : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JARJHZOCART LRPOVVMIRJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int IGUAAYYDPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType EZPUZMZQUVQ;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x707E100", Offset = "0x707CD00", VA = "0x18707E100")]
		public XHBBUVVKRLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x707DE20", Offset = "0x707CA20", VA = "0x18707DE20")]
		public static XHBBUVVKRLH Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x707DCE0", Offset = "0x707C8E0", VA = "0x18707DCE0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class CKRFMCAYMUK : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JARJHZOCART LRPOVVMIRJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int IGUAAYYDPQG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x706CD50", Offset = "0x706B950", VA = "0x18706CD50")]
		public CKRFMCAYMUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x706CAD0", Offset = "0x706B6D0", VA = "0x18706CAD0")]
		public static CKRFMCAYMUK Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x706C9D0", Offset = "0x706B5D0", VA = "0x18706C9D0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class GKFPXYJSXOG : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public HLVLBMIQWGU XSXKDTKTSIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public XLZIAVEJYKT FPMHARYHOHE;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x70705F0", Offset = "0x706F1F0", VA = "0x1870705F0")]
		public GKFPXYJSXOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7070400", Offset = "0x706F000", VA = "0x187070400")]
		public static GKFPXYJSXOG Deserialize(NJKZJMRMPCW root, JsonReader reader, EKVSINUVMVW anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7070300", Offset = "0x706EF00", VA = "0x187070300", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class XLZIAVEJYKT : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public SXJHZCBZTKC BLLWWIMDBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string JVRXXTWNEEQ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x707E270", Offset = "0x707CE70", VA = "0x18707E270")]
		public static XLZIAVEJYKT Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x707E4D0", Offset = "0x707D0D0", VA = "0x18707E4D0")]
		public XLZIAVEJYKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x707E150", Offset = "0x707CD50", VA = "0x18707E150", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
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
	public class YEXJKTRJFXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(YEXJKTRJFXC data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] MDGPPCHRFNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type AEUOIJFCRSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] MQKQWDRUZHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion ZRJIWEJXOJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string DOUIMYQTWQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string VGGIULYZLXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public RWGTRHNJMXE JXDIYGXZFRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string KWDCGTDRBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string DLBDVIOCHXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public RWGTRHNJMXE NOCNIRGONYX;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x707FF50", Offset = "0x707EB50", VA = "0x18707FF50")]
		public YEXJKTRJFXC()
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
	public class SGIUPYTAZBP : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MJWREBQWBGJ QRKOUFISJYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType EGIUCWZIEDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MJWREBQWBGJ NBOHIDDFKSW;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7079AF0", Offset = "0x70786F0", VA = "0x187079AF0")]
		public SGIUPYTAZBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x70798D0", Offset = "0x70784D0", VA = "0x1870798D0")]
		public static SGIUPYTAZBP Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7079760", Offset = "0x7078360", VA = "0x187079760", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class KKPIUQEBTNL : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string RIZRPZLASIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string UNOTXPFPMRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string JGSZJOSCNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string VQSHLBJFGUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> VINIRSTUJUP;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7072FB0", Offset = "0x7071BB0", VA = "0x187072FB0")]
		public KKPIUQEBTNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x70728E0", Offset = "0x70714E0", VA = "0x1870728E0")]
		public static KKPIUQEBTNL Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x70724C0", Offset = "0x70710C0", VA = "0x1870724C0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7072FA0", Offset = "0x7071BA0", VA = "0x187072FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7072C00", Offset = "0x7071800", VA = "0x187072C00")]
		public string HVAHHEZFAAT(bool a)
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
	public class LRPOVVMIRJS : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public QESBXDYIRKA TXLEKYLYBCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint IGUAAYYDPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint BDAXKIAQOHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint NFRKNSAXEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget FPMHARYHOHE;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public LRPOVVMIRJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7073260", Offset = "0x7071E60", VA = "0x187073260")]
		public static LRPOVVMIRJS Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7073050", Offset = "0x7071C50", VA = "0x187073050", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class EWHJMCHHHQS : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double WCPFIBLIONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double KSMLCODEALT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double CDADNLPBXAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double QKJYQQGMNNT;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x706DEF0", Offset = "0x706CAF0", VA = "0x18706DEF0")]
		public EWHJMCHHHQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x706DB70", Offset = "0x706C770", VA = "0x18706DB70")]
		public static EWHJMCHHHQS Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x706DA00", Offset = "0x706C600", VA = "0x18706DA00", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class YSLTZOWSCDM : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double DOLDCPUAXRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double UKYGMFYWEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double CDADNLPBXAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double QKJYQQGMNNT;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x70804F0", Offset = "0x707F0F0", VA = "0x1870804F0")]
		public YSLTZOWSCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7080180", Offset = "0x707ED80", VA = "0x187080180")]
		public static YSLTZOWSCDM Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x707FFF0", Offset = "0x707EBF0", VA = "0x18707FFF0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class EKVSINUVMVW : FIRPRGZIJCU
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public NJKZJMRMPCW CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader VTJMKFLAXCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public EKVSINUVMVW IRVHPDZTUPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<GKFPXYJSXOG> HUVVFXMGSVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<SGIUPYTAZBP> HVBCDEGECGV;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x706F1B0", Offset = "0x706DDB0", VA = "0x18706F1B0")]
			internal GKFPXYJSXOG OFKNKLNAZQS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x706F1D0", Offset = "0x706DDD0", VA = "0x18706F1D0")]
			internal SGIUPYTAZBP OFPUHSGYJCB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<GKFPXYJSXOG> SQESKJOSDVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<SGIUPYTAZBP> VCUKSLDQAAS;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x706D550", Offset = "0x706C150", VA = "0x18706D550")]
		public static EKVSINUVMVW Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x706D910", Offset = "0x706C510", VA = "0x18706D910")]
		public EKVSINUVMVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x706D1B0", Offset = "0x706BDB0", VA = "0x18706D1B0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class JSNBLVGSPUY : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string ANXUSJGFIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint BDAXKIAQOHX;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public JSNBLVGSPUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7071810", Offset = "0x7070410", VA = "0x187071810")]
		public static JSNBLVGSPUY Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x70716C0", Offset = "0x70702C0", VA = "0x1870716C0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class WSMVQBSDTHH : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public EWHJMCHHHQS BVROOEEZQNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public YSLTZOWSCDM RQKRQHBIEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType XSYNALKQIRF;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public WSMVQBSDTHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x707DB10", Offset = "0x707C710", VA = "0x18707DB10")]
		public static WSMVQBSDTHH Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x707D940", Offset = "0x707C540", VA = "0x18707D940", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
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
	public class FIRPRGZIJCU : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string XPPEXRAPNHC;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public FIRPRGZIJCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x706E810", Offset = "0x706D410", VA = "0x18706E810")]
		public FIRPRGZIJCU(FIRPRGZIJCU a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x706E720", Offset = "0x706D320", VA = "0x18706E720")]
		public new void WHFRNYJADJM(NJKZJMRMPCW a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x706E690", Offset = "0x706D290", VA = "0x18706E690", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class PBEMSQLQDPC<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int HSLXDBEEAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NJKZJMRMPCW TEDROYGXZDB;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected PBEMSQLQDPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x59BE8F0", Offset = "0x59BD4F0", VA = "0x1859BE8F0")]
		public PBEMSQLQDPC(PBEMSQLQDPC<a> a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x59BE8C0", Offset = "0x59BD4C0", VA = "0x1859BE8C0")]
		public void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class MJWREBQWBGJ : PBEMSQLQDPC<JIHZXFMJKOY>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override JIHZXFMJKOY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7073D00", Offset = "0x7072900", VA = "0x187073D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7073C60", Offset = "0x7072860", VA = "0x187073C60")]
		public MJWREBQWBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7073CA0", Offset = "0x70728A0", VA = "0x187073CA0")]
		public MJWREBQWBGJ(MJWREBQWBGJ a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7073B80", Offset = "0x7072780", VA = "0x187073B80")]
		public static MJWREBQWBGJ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class QESBXDYIRKA : PBEMSQLQDPC<JSNBLVGSPUY>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override JSNBLVGSPUY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7078A20", Offset = "0x7077620", VA = "0x187078A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x70789E0", Offset = "0x70775E0", VA = "0x1870789E0")]
		public QESBXDYIRKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7078900", Offset = "0x7077500", VA = "0x187078900")]
		public static QESBXDYIRKA Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JARJHZOCART : PBEMSQLQDPC<LRPOVVMIRJS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override LRPOVVMIRJS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7070C50", Offset = "0x706F850", VA = "0x187070C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7070C10", Offset = "0x706F810", VA = "0x187070C10")]
		public JARJHZOCART()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7070B30", Offset = "0x706F730", VA = "0x187070B30")]
		public static JARJHZOCART Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MGMXBIREJSN : PBEMSQLQDPC<WSMVQBSDTHH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override WSMVQBSDTHH Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7073B20", Offset = "0x7072720", VA = "0x187073B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7073AE0", Offset = "0x70726E0", VA = "0x187073AE0")]
		public MGMXBIREJSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7073A00", Offset = "0x7072600", VA = "0x187073A00")]
		public static MGMXBIREJSN Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NZSWVWQSFVL : PBEMSQLQDPC<NTEHFKYQDFZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NTEHFKYQDFZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7078550", Offset = "0x7077150", VA = "0x187078550", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7078510", Offset = "0x7077110", VA = "0x187078510")]
		public NZSWVWQSFVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7078430", Offset = "0x7077030", VA = "0x187078430")]
		public static NZSWVWQSFVL Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class GDIOHXNITKD : PBEMSQLQDPC<WLVRMNKCGFN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override WLVRMNKCGFN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x706F360", Offset = "0x706DF60", VA = "0x18706F360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x706F320", Offset = "0x706DF20", VA = "0x18706F320")]
		public GDIOHXNITKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x706F2C0", Offset = "0x706DEC0", VA = "0x18706F2C0")]
		public GDIOHXNITKD(GDIOHXNITKD a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x706F1E0", Offset = "0x706DDE0", VA = "0x18706F1E0")]
		public static GDIOHXNITKD Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class RQFWSQDAFLV : PBEMSQLQDPC<JPGHIFSLCXV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override JPGHIFSLCXV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7078E20", Offset = "0x7077A20", VA = "0x187078E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7078DE0", Offset = "0x70779E0", VA = "0x187078DE0")]
		public RQFWSQDAFLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7078D00", Offset = "0x7077900", VA = "0x187078D00")]
		public static RQFWSQDAFLV Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SXJHZCBZTKC : PBEMSQLQDPC<BLLWWIMDBED>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BLLWWIMDBED Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x7079ED0", Offset = "0x7078AD0", VA = "0x187079ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7079E90", Offset = "0x7078A90", VA = "0x187079E90")]
		public SXJHZCBZTKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7079B40", Offset = "0x7078740", VA = "0x187079B40")]
		public static SXJHZCBZTKC Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7079C20", Offset = "0x7078820", VA = "0x187079C20")]
		public static List<SXJHZCBZTKC> QRALLFAVBST(NJKZJMRMPCW a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class AYRGKVCQXGI : PBEMSQLQDPC<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x706AF50", Offset = "0x7069B50", VA = "0x18706AF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x706AF10", Offset = "0x7069B10", VA = "0x18706AF10")]
		public AYRGKVCQXGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x706AE30", Offset = "0x7069A30", VA = "0x18706AE30")]
		public static AYRGKVCQXGI Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HLVLBMIQWGU : PBEMSQLQDPC<SGIUPYTAZBP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public EKVSINUVMVW EKVSINUVMVW;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override SGIUPYTAZBP Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7070780", Offset = "0x706F380", VA = "0x187070780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7070740", Offset = "0x706F340", VA = "0x187070740")]
		public HLVLBMIQWGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7070640", Offset = "0x706F240", VA = "0x187070640")]
		public static HLVLBMIQWGU Deserialize(NJKZJMRMPCW root, EKVSINUVMVW anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ZTNEJPCLAXS : PBEMSQLQDPC<FKETVGOGDPQ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FKETVGOGDPQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7080B80", Offset = "0x707F780", VA = "0x187080B80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7080B40", Offset = "0x707F740", VA = "0x187080B40")]
		public ZTNEJPCLAXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7080A60", Offset = "0x707F660", VA = "0x187080A60")]
		public static ZTNEJPCLAXS Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZVMBVJIMRRV : PBEMSQLQDPC<MNXMFUPWIMW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override MNXMFUPWIMW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7080D00", Offset = "0x707F900", VA = "0x187080D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7080CC0", Offset = "0x707F8C0", VA = "0x187080CC0")]
		public ZVMBVJIMRRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7080BE0", Offset = "0x707F7E0", VA = "0x187080BE0")]
		public static ZVMBVJIMRRV Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class EXSABCRSSZJ : PBEMSQLQDPC<CHYSZXENJAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override CHYSZXENJAJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x706E0C0", Offset = "0x706CCC0", VA = "0x18706E0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x706E080", Offset = "0x706CC80", VA = "0x18706E080")]
		public EXSABCRSSZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x706E020", Offset = "0x706CC20", VA = "0x18706E020")]
		public EXSABCRSSZJ(EXSABCRSSZJ a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x706DF40", Offset = "0x706CB40", VA = "0x18706DF40")]
		public static EXSABCRSSZJ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class JHTGFIUHXMI : PBEMSQLQDPC<RNCEHZXFPIC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override RNCEHZXFPIC Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7070CF0", Offset = "0x706F8F0", VA = "0x187070CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7070CB0", Offset = "0x706F8B0", VA = "0x187070CB0")]
		public JHTGFIUHXMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class NTEHFKYQDFZ : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string ANXUSJGFIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string CKETIUOEKNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JARJHZOCART LRPOVVMIRJS;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public NTEHFKYQDFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7077CB0", Offset = "0x70768B0", VA = "0x187077CB0")]
		public static NTEHFKYQDFZ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7077AE0", Offset = "0x70766E0", VA = "0x187077AE0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class WLVRMNKCGFN : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public SBUCOZALMMK SBUCOZALMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public FILJPPSXREH HXHYVHTWJDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public TMCDCIGBIKD ZKAFNKBRHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public DRAEXBSNXID RLOYRSXZRWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public LVHYOCETPXM ZDBSDOENERV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color EEWAJBIDLVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode DJIXPLNMTYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double VXAKXWFNBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool BGMGVPAAHFJ;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x707D8D0", Offset = "0x707C4D0", VA = "0x18707D8D0")]
		public WLVRMNKCGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x707D3C0", Offset = "0x707BFC0", VA = "0x18707D3C0")]
		public static WLVRMNKCGFN Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x707CF60", Offset = "0x707BB60", VA = "0x18707CF60", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
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
	public class JPGHIFSLCXV : FIRPRGZIJCU
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public NJKZJMRMPCW CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader VTJMKFLAXCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<XPURJMPHSUP> HUVVFXMGSVM;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x707A460", Offset = "0x7079060", VA = "0x18707A460")]
			internal XPURJMPHSUP OFKNKLNAZQS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<XPURJMPHSUP> RVOIOMLFNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> WNZJMOONLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> PFZFENNHBUS;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public JPGHIFSLCXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7071300", Offset = "0x706FF00", VA = "0x187071300")]
		public static JPGHIFSLCXV Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7070D50", Offset = "0x706F950", VA = "0x187070D50", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class VQHHWQVMKSL
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, IMQJUZHOSDI> WNKENLSMEWS;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static UXAXNUOLOXP FAEWTPHFKXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, JRZEQPOWTYP> BNGQVLLIQGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken EOZYNFKNAAA;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x707C000", Offset = "0x707AC00", VA = "0x18707C000")]
		public static IMQJUZHOSDI USKSQBDNEVP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x707B720", Offset = "0x707A320", VA = "0x18707B720")]
		public static JRZEQPOWTYP OVKYBBFALSB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public VQHHWQVMKSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x707CC70", Offset = "0x707B870", VA = "0x18707CC70")]
		public VQHHWQVMKSL(VQHHWQVMKSL a, [Optional] NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x707C190", Offset = "0x707AD90", VA = "0x18707C190")]
		public void WHFRNYJADJM(NJKZJMRMPCW a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x707BEB0", Offset = "0x707AAB0", VA = "0x18707BEB0")]
		public void TBJEAUWNEVJ(string a, JRZEQPOWTYP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x707B570", Offset = "0x707A170", VA = "0x18707B570")]
		private void MFQCBRQBNEB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x707B810", Offset = "0x707A410", VA = "0x18707B810")]
		private void RKIXNQVYNZN(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x707B660", Offset = "0x707A260", VA = "0x18707B660")]
		private void MOYJJLTBZRL(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x707B8D0", Offset = "0x707A4D0", VA = "0x18707B8D0")]
		internal static Dictionary<string, JRZEQPOWTYP> SOFHWIUILRC(NJKZJMRMPCW a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x707B1F0", Offset = "0x7079DF0", VA = "0x18707B1F0", Slot = "4")]
		public virtual void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class NJKZJMRMPCW : VQHHWQVMKSL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class HSAGEGZXRUB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public NJKZJMRMPCW CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader DVSLSKDNEYO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<JIHZXFMJKOY> HUVVFXMGSVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<EKVSINUVMVW> HVBCDEGECGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<JSNBLVGSPUY> HULHLJYLZYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<LRPOVVMIRJS> HUQOIQSJJKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<WSMVQBSDTHH> HVQWUYNWEOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<NTEHFKYQDFZ> HVWDSFHTOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<WLVRMNKCGFN> HVGJALABLSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<JPGHIFSLCXV> HVLPXRTYVDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<BLLWWIMDBED> HWLYJZPLQIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> HWRFHGJIZTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<FKETVGOGDPQ> RZSQDFIPJDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<MNXMFUPWIMW> RZNJFYORZRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<CHYSZXENJAJ> SADDXSWKBZT;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HSAGEGZXRUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7070800", Offset = "0x706F400", VA = "0x187070800")]
			internal JIHZXFMJKOY OFKNKLNAZQS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7070810", Offset = "0x706F410", VA = "0x187070810")]
			internal EKVSINUVMVW OFPUHSGYJCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x70707E0", Offset = "0x706F3E0", VA = "0x1870707E0")]
			internal JSNBLVGSPUY OEZZPXZGGUA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x70707F0", Offset = "0x706F3F0", VA = "0x1870707F0")]
			internal LRPOVVMIRJS OFFGNETDQFJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7070840", Offset = "0x706F440", VA = "0x187070840")]
			internal WSMVQBSDTHH OGFOZMOQLKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7070850", Offset = "0x706F450", VA = "0x187070850")]
			internal NTEHFKYQDFZ OGKVWTINUVL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7070820", Offset = "0x706F420", VA = "0x187070820")]
			internal WLVRMNKCGFN OFVBEZAVSNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7070830", Offset = "0x706F430", VA = "0x187070830")]
			internal JPGHIFSLCXV OGAICFUTBYT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7070860", Offset = "0x706F460", VA = "0x187070860")]
			internal BLLWWIMDBED OHAQONQFXDM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7070870", Offset = "0x706F470", VA = "0x187070870")]
			internal Sampler OHFXLUKDGOV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7070890", Offset = "0x706F490", VA = "0x187070890")]
			internal FKETVGOGDPQ XKQBMIMZQRJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7070880", Offset = "0x706F480", VA = "0x187070880")]
			internal MNXMFUPWIMW XKKUPBTCHGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7070A10", Offset = "0x706F610", VA = "0x187070A10")]
			internal CHYSZXENJAJ XLAPGWAUJOB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> HITQJVFNCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> YOEMQMGVSDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<JIHZXFMJKOY> ZVLJQPIBUFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<EKVSINUVMVW> JYQSCWRHGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KKPIUQEBTNL KKPIUQEBTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<JSNBLVGSPUY> JSRXKLCTWBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<LRPOVVMIRJS> INZKNNOSTXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<WSMVQBSDTHH> LRECLJRPZGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<NTEHFKYQDFZ> LHSILGDDFWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<WLVRMNKCGFN> UDYBBELKMXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<JPGHIFSLCXV> MFGFXLQUDHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<BLLWWIMDBED> TUXAYVBVYKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> VCUKSLDQAAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ZTNEJPCLAXS XRVZBTGFTOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<FKETVGOGDPQ> CZFLIKAZPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<MNXMFUPWIMW> QBWDFXPPISL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<CHYSZXENJAJ> ZOBBAWJIMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<RNCEHZXFPIC> TADGQUPUXCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool UENDXXNCADQ;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7076F20", Offset = "0x7075B20", VA = "0x187076F20")]
		public NJKZJMRMPCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7076E80", Offset = "0x7075A80", VA = "0x187076E80")]
		public FKETVGOGDPQ VWKMUUHKWMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7076030", Offset = "0x7074C30", VA = "0x187076030")]
		public static NJKZJMRMPCW Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7074480", Offset = "0x7073080", VA = "0x187074480")]
		public void DKWNNTIDYNZ(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class FKETVGOGDPQ : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<SXJHZCBZTKC> TUXAYVBVYKA;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public FKETVGOGDPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x706EB00", Offset = "0x706D700", VA = "0x18706EB00")]
		public static FKETVGOGDPQ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x706E890", Offset = "0x706D490", VA = "0x18706E890", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class CHYSZXENJAJ : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AYRGKVCQXGI XSXKDTKTSIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NZSWVWQSFVL KBDGUUKJAKG;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public CHYSZXENJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x706C800", Offset = "0x706B400", VA = "0x18706C800")]
		public static CHYSZXENJAJ Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x706C690", Offset = "0x706B290", VA = "0x18706C690", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class XWBCATXWJVI : RNCEHZXFPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public XWBCATXWJVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x706C630", Offset = "0x706B230", VA = "0x18706C630", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class RNCEHZXFPIC : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string PKSXUEZIQDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color BUYVREBZWDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string TYTIIADQMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float MUCGZSUQVOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float JVUHMUMIJQY;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public RNCEHZXFPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7078A80", Offset = "0x7077680", VA = "0x187078A80", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class BTQWXFKHLVS : RNCEHZXFPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x706C640", Offset = "0x706B240", VA = "0x18706C640")]
		public BTQWXFKHLVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x706C630", Offset = "0x706B230", VA = "0x18706C630", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class PUHZLQXILDM : RNCEHZXFPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float DCCWEONIFRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float XAATKBIRPUA;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x70788B0", Offset = "0x70774B0", VA = "0x1870788B0")]
		public PUHZLQXILDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x70785B0", Offset = "0x70771B0", VA = "0x1870785B0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface DYSWZJJSVHX
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QAVQZQATPCW(NJKZJMRMPCW a, WOBAGJVCJMH b, [Out] YEXJKTRJFXC c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface JRZEQPOWTYP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JRZEQPOWTYP Clone(NJKZJMRMPCW root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class IMQJUZHOSDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string EESNQROZCFB;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected IMQJUZHOSDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class HZSAEVZHOTP : JRZEQPOWTYP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty QSRGDYKZHZK
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7070A20", Offset = "0x706F620", VA = "0x187070A20", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public HZSAEVZHOTP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class UXAXNUOLOXP : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x707B180", Offset = "0x7079D80", VA = "0x18707B180", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UXAXNUOLOXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class FILJPPSXREH : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color NFKKGDQSDTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public LVHYOCETPXM IKRXNAUALNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color ALKLVSSWZMC;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x706E620", Offset = "0x706D220", VA = "0x18706E620")]
		public FILJPPSXREH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x706E380", Offset = "0x706CF80", VA = "0x18706E380")]
		public static FILJPPSXREH Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x706E120", Offset = "0x706CD20", VA = "0x18706E120", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class TMCDCIGBIKD : LVHYOCETPXM
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string GMYUKIPQVQD = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double JWUOPNQQOOD;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x706D150", Offset = "0x706BD50", VA = "0x18706D150")]
		public TMCDCIGBIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x707A530", Offset = "0x7079130", VA = "0x18707A530")]
		public new static TMCDCIGBIKD Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x707A470", Offset = "0x7079070", VA = "0x18707A470", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class DRAEXBSNXID : LVHYOCETPXM
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string DNEBNXDYYZY = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double LHLSHBVBIYK;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x706D150", Offset = "0x706BD50", VA = "0x18706D150")]
		public DRAEXBSNXID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x706CE60", Offset = "0x706BA60", VA = "0x18706CE60")]
		public new static DRAEXBSNXID Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x706CDA0", Offset = "0x706B9A0", VA = "0x18706CDA0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class SBUCOZALMMK : VQHHWQVMKSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color OUOKYEDUQNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public LVHYOCETPXM KIVKIJBSNQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double RHBAFTQUEXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double LHSEEHTXDWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LVHYOCETPXM ELTQOBCILET;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7079480", Offset = "0x7078080", VA = "0x187079480")]
		public SBUCOZALMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7079110", Offset = "0x7077D10", VA = "0x187079110")]
		public static SBUCOZALMMK Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7078E80", Offset = "0x7077A80", VA = "0x187078E80", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class XPURJMPHSUP : VQHHWQVMKSL
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class NLQFCTBILOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader VTJMKFLAXCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public NJKZJMRMPCW CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<MJWREBQWBGJ> HUVVFXMGSVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<MJWREBQWBGJ> HULHLJYLZYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, MJWREBQWBGJ>> HVBCDEGECGV;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NLQFCTBILOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7077960", Offset = "0x7076560", VA = "0x187077960")]
			internal MJWREBQWBGJ OFKNKLNAZQS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7077A30", Offset = "0x7076630", VA = "0x187077A30")]
			internal Dictionary<string, MJWREBQWBGJ> OFPUHSGYJCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7077890", Offset = "0x7076490", VA = "0x187077890")]
			internal MJWREBQWBGJ OEZZPXZGGUA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, MJWREBQWBGJ> CJHPAYAAGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public MJWREBQWBGJ JTSLWINZEWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GDIOHXNITKD ZZRIAUJAGUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode PAYWYTKPJTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, MJWREBQWBGJ>> LOESHGRXYJJ;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x707FEB0", Offset = "0x707EAB0", VA = "0x18707FEB0")]
		public XPURJMPHSUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x707F810", Offset = "0x707E410", VA = "0x18707F810")]
		public XPURJMPHSUP(XPURJMPHSUP a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x707F3A0", Offset = "0x707DFA0", VA = "0x18707F3A0")]
		public static int[] MGVUWQEJKIF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x707EB80", Offset = "0x707D780", VA = "0x18707EB80")]
		public static int[] DOPQCJSFCXV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x707F130", Offset = "0x707DD30", VA = "0x18707F130")]
		public static int[] KNTGLQYEJYV(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x707F440", Offset = "0x707E040", VA = "0x18707F440")]
		public static int[] MQXLQKCEAPR(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x707F2F0", Offset = "0x707DEF0", VA = "0x18707F2F0")]
		public static int[] MGAHGXGXJPU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x707F7A0", Offset = "0x707E3A0", VA = "0x18707F7A0")]
		public static int[] VPDTUDFFIWL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x707F680", Offset = "0x707E280", VA = "0x18707F680")]
		public static int[] OFRLGYJRDBN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x707E520", Offset = "0x707D120", VA = "0x18707E520")]
		public static int[] DDOPTTJUHEA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x707F710", Offset = "0x707E310", VA = "0x18707F710")]
		public static int[] UUBOAXAWLRS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x707ECE0", Offset = "0x707D8E0", VA = "0x18707ECE0")]
		public static XPURJMPHSUP Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x707E590", Offset = "0x707D190", VA = "0x18707E590", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class YWUNJPSFOOC
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] EECMVDZCCSZ;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] FJMIRNGGFGW;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] NOJZGEHZCNR;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] UOIRLKLMWDT;
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
	public class BLLWWIMDBED : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool UWLHVCSPLDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MGMXBIREJSN HIIDNTJNDXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<SXJHZCBZTKC> QSJZUDKWBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public ZVMBVJIMRRV MNXMFUPWIMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public BCSVALIDCKC OURLLYCULQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public RQFWSQDAFLV NJRRYTJUMYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion AWDLCCGDDQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 JWUOPNQQOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 IGLJZTFKGDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> WNZJMOONLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public JHTGFIUHXMI YDQUCFRGCER;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x706C4F0", Offset = "0x706B0F0", VA = "0x18706C4F0")]
		public BLLWWIMDBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x706BBB0", Offset = "0x706A7B0", VA = "0x18706BBB0")]
		public static BLLWWIMDBED Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x706AFB0", Offset = "0x7069BB0", VA = "0x18706AFB0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode TBCTZHECOMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode EEZLTODPTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode TCOKFKIBUXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode TCJDIDOELLX;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x707A3F0", Offset = "0x7078FF0", VA = "0x18707A3F0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x707A120", Offset = "0x7078D20", VA = "0x18707A120")]
		public static Sampler Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7079F30", Offset = "0x7078B30", VA = "0x187079F30", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
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
	public class MNXMFUPWIMW : FIRPRGZIJCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public MJWREBQWBGJ JJLEVBGVMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public SXJHZCBZTKC QPOXBBNPWNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<SXJHZCBZTKC> HDLGFACLUXQ;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x70743D0", Offset = "0x7072FD0", VA = "0x1870743D0")]
		public MNXMFUPWIMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7074070", Offset = "0x7072C70", VA = "0x187074070")]
		public static MNXMFUPWIMW Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7073D60", Offset = "0x7072960", VA = "0x187073D60", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class LVHYOCETPXM : VQHHWQVMKSL
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string DACYIEAWMEF = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string UXBMAGVBKFT = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public EXSABCRSSZJ QXRFMZXOYOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int EECMVDZCCSZ;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x70738C0", Offset = "0x70724C0", VA = "0x1870738C0")]
		public LVHYOCETPXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7073910", Offset = "0x7072510", VA = "0x187073910")]
		public LVHYOCETPXM(LVHYOCETPXM a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7073570", Offset = "0x7072170", VA = "0x187073570")]
		public static LVHYOCETPXM Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7073510", Offset = "0x7072110", VA = "0x187073510", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x70737F0", Offset = "0x70723F0", VA = "0x1870737F0")]
		public void QPZFZLACQNY(JsonWriter a)
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
	public class NZBVBPIGAMX
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double RVJIHOSNHVR;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double ULVXQKPDGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double TNCUCNCJAEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double HVFOVGVKPMY;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x70783B0", Offset = "0x7076FB0", VA = "0x1870783B0")]
		public NZBVBPIGAMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7078100", Offset = "0x7076D00", VA = "0x187078100")]
		public static NZBVBPIGAMX Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7077EF0", Offset = "0x7076AF0", VA = "0x187077EF0")]
		public void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class JWSDVRAXQNF : FIRPRGZIJCU
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color MKRGDBNQVZO;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double QYNQCKVETJE;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double CHOCJQKOCJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType XSYNALKQIRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color FJMIRNGGFGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double SXJFHEWLABS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double ZTRSRNIYEGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NZBVBPIGAMX NZBVBPIGAMX;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x70722D0", Offset = "0x7070ED0", VA = "0x1870722D0")]
		public JWSDVRAXQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7072390", Offset = "0x7070F90", VA = "0x187072390")]
		public JWSDVRAXQNF(JWSDVRAXQNF a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7071E60", Offset = "0x7070A60", VA = "0x187071E60")]
		public static JWSDVRAXQNF Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7071D40", Offset = "0x7070940", VA = "0x187071D40")]
		public static JWSDVRAXQNF Deserialize(NJKZJMRMPCW root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x70719E0", Offset = "0x70705E0", VA = "0x1870719E0", Slot = "4")]
		public override void DKWNNTIDYNZ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class NKKCNOOANPX : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<RNCEHZXFPIC> RHSSZJTDTFA;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public NKKCNOOANPX(IList<RNCEHZXFPIC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7076FE0", Offset = "0x7075BE0", VA = "0x187076FE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7076F70", Offset = "0x7075B70", VA = "0x187076F70", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class GHUDOAEAILD : JRZEQPOWTYP, DYSWZJJSVHX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<JWSDVRAXQNF> TADGQUPUXCW;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7070280", Offset = "0x706EE80", VA = "0x187070280")]
		public GHUDOAEAILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x706F3C0", Offset = "0x706DFC0", VA = "0x18706F3C0", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7070190", Offset = "0x706ED90", VA = "0x187070190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x706FAF0", Offset = "0x706E6F0", VA = "0x18706FAF0")]
		private static string[] JSOWDPSVMQZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x706F650", Offset = "0x706E250", VA = "0x18706F650")]
		private static YEXJKTRJFXC.ImportValuesConversion EEOIKYMDDAN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x706FDA0", Offset = "0x706E9A0", VA = "0x18706FDA0", Slot = "6")]
		public bool QAVQZQATPCW(NJKZJMRMPCW a, WOBAGJVCJMH b, [Out] YEXJKTRJFXC c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class SELUSYUAABI : PBEMSQLQDPC<JWSDVRAXQNF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override JWSDVRAXQNF Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x7079610", Offset = "0x7078210", VA = "0x187079610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x70795D0", Offset = "0x70781D0", VA = "0x1870795D0")]
		public SELUSYUAABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x70794F0", Offset = "0x70780F0", VA = "0x1870794F0")]
		public static SELUSYUAABI Deserialize(NJKZJMRMPCW root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class ZDDTOWGSYND : JRZEQPOWTYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public SELUSYUAABI JHTGFIUHXMI;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public ZDDTOWGSYND(SELUSYUAABI a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x70809A0", Offset = "0x707F5A0", VA = "0x1870809A0")]
		public ZDDTOWGSYND(int a, NJKZJMRMPCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7080820", Offset = "0x707F420", VA = "0x187080820", Slot = "5")]
		public JRZEQPOWTYP Clone(NJKZJMRMPCW root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x70808A0", Offset = "0x707F4A0", VA = "0x1870808A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class FWEOAMOYNOA : IMQJUZHOSDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x706F160", Offset = "0x706DD60", VA = "0x18706F160")]
		public FWEOAMOYNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x706EC80", Offset = "0x706D880", VA = "0x18706EC80", Slot = "4")]
		public override JRZEQPOWTYP Deserialize(NJKZJMRMPCW root, JProperty extensionToken)
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
