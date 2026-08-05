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
	public class KHR_animation_pointer : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object JWNVFDRRDVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string VSIGUBORNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string GCWKIIAADGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public YRJANQSRFQN RWQQEPVZPVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer FESIBFOFHDA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7500E50", Offset = "0x74FFE50", VA = "0x187500E50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7500DA0", Offset = "0x74FFDA0", VA = "0x187500DA0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class FIXVPIQQLYE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 OLPVQECBJQP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 VQWBSVOGDRE;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion IEFWDFATAVI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool YXQATNSHKVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x74FB2C0", Offset = "0x74FA2C0", VA = "0x1874FB2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74F99B0", Offset = "0x74F89B0", VA = "0x1874F99B0")]
		public static void KELCFOASUMK(this MOXNPQACASF a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74FBAC0", Offset = "0x74FAAC0", VA = "0x1874FBAC0")]
		public static void XYLIUQUYIOU(this MOXNPQACASF a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74F8B10", Offset = "0x74F7B10", VA = "0x1874F8B10")]
		public static void CPMVWVQKLIT(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74F9000", Offset = "0x74F8000", VA = "0x1874F9000")]
		public static GLTF.Math.Vector4 FLDAPUSOQXT(this KQQQCUNKXVC a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74FB800", Offset = "0x74FA800", VA = "0x1874FB800")]
		public static UnityEngine.Quaternion XSLCAKQDUZO(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74FB990", Offset = "0x74FA990", VA = "0x1874FB990")]
		public static UnityEngine.Quaternion XSLCAKQDUZO(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74F89D0", Offset = "0x74F79D0", VA = "0x1874F89D0")]
		public static GLTF.Math.Quaternion CFRSLVGHCKY(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74FAB30", Offset = "0x74F9B30", VA = "0x1874FAB30")]
		public static Matrix4x4 NWBNQTNEEZB(this KQQQCUNKXVC a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74FA6F0", Offset = "0x74F96F0", VA = "0x1874FA6F0")]
		public static Matrix4x4 NWBNQTNEEZB(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74F9670", Offset = "0x74F8670", VA = "0x1874F9670")]
		public static KQQQCUNKXVC JRJAJENCZZR(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74F9550", Offset = "0x74F8550", VA = "0x1874F9550")]
		public static UnityEngine.Vector3 JHZRBVMSIGC(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74F9470", Offset = "0x74F8470", VA = "0x1874F9470")]
		public static UnityEngine.Vector3 JHZRBVMSIGC(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74F88A0", Offset = "0x74F78A0", VA = "0x1874F88A0")]
		public static GLTF.Math.Vector3 BGRDCAXKWBA(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74F9220", Offset = "0x74F8220", VA = "0x1874F9220")]
		public static GLTF.Math.Vector3 GHSNAJLGXRR(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x142F570", Offset = "0x142E570", VA = "0x18142F570")]
		public static GLTF.Math.Vector4 GHHAGRFIGLC(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74FA2D0", Offset = "0x74F92D0", VA = "0x1874FA2D0")]
		public static Matrix4x4 KQTACADOVIO(this KQQQCUNKXVC a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74FA060", Offset = "0x74F9060", VA = "0x1874FA060")]
		public static Matrix4x4 KQTACADOVIO(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74FB0F0", Offset = "0x74FA0F0", VA = "0x1874FB0F0")]
		public static KQQQCUNKXVC SAJUJKTHHGW(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74F8F10", Offset = "0x74F7F10", VA = "0x1874F8F10")]
		public static UnityEngine.Vector2 EJFZZCRZKGK(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74F8F10", Offset = "0x74F7F10", VA = "0x1874F8F10")]
		public static UnityEngine.Vector2 EJFZZCRZKGK(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74F8F30", Offset = "0x74F7F30", VA = "0x1874F8F30")]
		public static void EJFZZCRZKGK(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74FBFC0", Offset = "0x74FAFC0", VA = "0x1874FBFC0")]
		public static UnityEngine.Vector3 YFWDSWLOXOL(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFCD0", Offset = "0x1DEECD0", VA = "0x181DEFCD0")]
		public static UnityEngine.Vector3 YFWDSWLOXOL(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74FC020", Offset = "0x74FB020", VA = "0x1874FC020")]
		public static void YFWDSWLOXOL(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x142F570", Offset = "0x142E570", VA = "0x18142F570")]
		public static UnityEngine.Vector4 INOUEUFIIME(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x142F570", Offset = "0x142E570", VA = "0x18142F570")]
		public static UnityEngine.Vector4 INOUEUFIIME(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74F9260", Offset = "0x74F8260", VA = "0x1874F9260")]
		public static UnityEngine.Vector4[] INOUEUFIIME(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74F9360", Offset = "0x74F8360", VA = "0x1874F9360")]
		public static void INOUEUFIIME(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74FB6E0", Offset = "0x74FA6E0", VA = "0x1874FB6E0")]
		public static UnityEngine.Color VURHFBFFIPA(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74FB5A0", Offset = "0x74FA5A0", VA = "0x1874FB5A0")]
		public static void VURHFBFFIPA(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74FB6E0", Offset = "0x74FA6E0", VA = "0x1874FB6E0")]
		public static UnityEngine.Color VURHFBFFIPA(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x142F570", Offset = "0x142E570", VA = "0x18142F570")]
		public static UnityEngine.Color KHSXQRGLAAJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74F9F50", Offset = "0x74F8F50", VA = "0x1874F9F50")]
		public static void KHSXQRGLAAJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x142F570", Offset = "0x142E570", VA = "0x18142F570")]
		public static UnityEngine.Color KHSXQRGLAAJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74F8EE0", Offset = "0x74F7EE0", VA = "0x1874F8EE0")]
		public static GLTF.Math.Color DTTOJHNYMZV(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74FC110", Offset = "0x74FB110", VA = "0x1874FC110")]
		public static GLTF.Math.Color ZOBNRXKTHVM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74FB3C0", Offset = "0x74FA3C0", VA = "0x1874FB3C0")]
		public static GLTF.Math.Color UXSGDCYITLK(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74FAD50", Offset = "0x74F9D50", VA = "0x1874FAD50")]
		public static UnityEngine.Color[] QYKISOUGSAR(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74FB780", Offset = "0x74FA780", VA = "0x1874FB780")]
		public static int[] VUTJOKBALRO(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x74FB040", Offset = "0x74FA040", VA = "0x1874FB040")]
		public static UnityEngine.Vector2[] RXGULZRINPR(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74FB440", Offset = "0x74FA440", VA = "0x1874FB440")]
		public static void UYNYDHIJKQA(RHGDTUJDSNW a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74FA590", Offset = "0x74F9590", VA = "0x1874FA590")]
		public static UnityEngine.Vector3[] LVNPEJLBIZO(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74FAEA0", Offset = "0x74F9EA0", VA = "0x1874FAEA0")]
		public static UnityEngine.Vector4[] RXDKXHSLMKR(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74FB350", Offset = "0x74FA350", VA = "0x1874FB350")]
		public static void USXXMLTTKWE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74FAE70", Offset = "0x74F9E70", VA = "0x1874FAE70")]
		public static UnityEngine.Quaternion ROGNLAPQIYO(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RHGDTUJDSNW
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BLQUYAAIOUL BLQUYAAIOUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray SHBQQZPVEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7507360", Offset = "0x7506360", VA = "0x187507360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> BPUOMYFMFPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF99640", Offset = "0xF98640", VA = "0x180F99640")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x105DB10", Offset = "0x105CB10", VA = "0x18105DB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint KEZYADECSKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7507370", Offset = "0x7506370", VA = "0x187507370")]
		public RHGDTUJDSNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x74FC250", Offset = "0x74FB250", VA = "0x1874FC250")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74FC2B0", Offset = "0x74FB2B0", VA = "0x1874FC2B0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BMXYNEBFRDT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MSGQKBNXUFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> ERGXCXXAZCI;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MSGQKBNXUFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x75058D0", Offset = "0x75048D0", VA = "0x1875058D0")]
			internal int? KEAKJACOREJ(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7505840", Offset = "0x7504840", VA = "0x187505840")]
			internal int? AHOAOUMJHCA(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7505950", Offset = "0x7504950", VA = "0x187505950")]
			internal bool WTFUVYEQIQE(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74F6650", Offset = "0x74F5650", VA = "0x1874F6650")]
		private static void VSMFBLKFENE(NumericArray a, RHGDTUJDSNW b, RHGDTUJDSNW c, RHGDTUJDSNW d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74F4BE0", Offset = "0x74F3BE0", VA = "0x1874F4BE0")]
		public static void MLAVJOGRQVN(Dictionary<string, RHGDTUJDSNW> a, Dictionary<string, (RHGDTUJDSNW sparseIndices, RHGDTUJDSNW sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74F4700", Offset = "0x74F3700", VA = "0x1874F4700")]
		public static void BYQMJWLYKHZ(Dictionary<string, RHGDTUJDSNW> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74F5EC0", Offset = "0x74F4EC0", VA = "0x1874F5EC0")]
		public static void QBMIROFHZYI(RHGDTUJDSNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74F6BC0", Offset = "0x74F5BC0", VA = "0x1874F6BC0")]
		public static void YLHWEFXAXAG(Dictionary<string, List<RHGDTUJDSNW>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74F6080", Offset = "0x74F5080", VA = "0x1874F6080")]
		private static void SQQNZLKEBIC(RHGDTUJDSNW a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74F5FC0", Offset = "0x74F4FC0", VA = "0x1874F5FC0")]
		internal static void SQQNZLKEBIC(JKQJMUODNSS a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74F61B0", Offset = "0x74F51B0", VA = "0x1874F61B0")]
		public static IPJZZZPIFAI VHNKNAQPLBY(IEnumerable<IPJZZZPIFAI> a)
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
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30BACC0", Offset = "0x30B9CC0", VA = "0x1830BACC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30BACD0", Offset = "0x30B9CD0", VA = "0x1830BACD0")]
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
	public class TWPQRRCGCNZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint GKFAJUADNOY;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint MMQKORDJCTY;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint XRJJMRPNSSE;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75083A0", Offset = "0x75073A0", VA = "0x1875083A0")]
		public static void GBUXIHZAUAK(Stream a, [Out] MOZQYZBZKKQ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7508760", Offset = "0x7507760", VA = "0x187508760")]
		public static ChunkInfo TVJDRBFLWYO(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7508AB0", Offset = "0x7507AB0", VA = "0x187508AB0")]
		public static GLBHeader YTLQPSYFINI(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x75089F0", Offset = "0x75079F0", VA = "0x1875089F0")]
		public static bool WBSZFGZGWHK(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7508560", Offset = "0x7507560", VA = "0x187508560")]
		public static ChunkInfo GCNGYPIVBHD(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7508100", Offset = "0x7507100", VA = "0x187508100")]
		private static void DRYDCMFCNHF(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x75086D0", Offset = "0x75076D0", VA = "0x1875086D0")]
		private static uint NUJMGNZKNUS(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SIFLWCPVBWN
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
		public PathElement XNXFEPEWJTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int KFKEAEYJQEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC5B060", Offset = "0xC5A060", VA = "0x180C5B060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC5B070", Offset = "0xC5A070", VA = "0x180C5B070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string UXABMAXECEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FOZJQVUVBAR
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BC0", Offset = "0xAD7BC0", VA = "0x180AD8BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BB0", Offset = "0xAD7BB0", VA = "0x180AD8BB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public SIFLWCPVBWN WTOHPGEZPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7507530", Offset = "0x7506530", VA = "0x187507530")]
		public string GEZXHVKFCDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75075B0", Offset = "0x75065B0", VA = "0x1875075B0")]
		public SIFLWCPVBWN RWPYMHXPGCP(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75077B0", Offset = "0x75067B0", VA = "0x1875077B0")]
		private SIFLWCPVBWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7507810", Offset = "0x7506810", VA = "0x187507810")]
		public SIFLWCPVBWN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x44314D0", Offset = "0x44304D0", VA = "0x1844314D0")]
		[CompilerGenerated]
		internal static string GAQHKLMBFEJ(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75074F0", Offset = "0x75064F0", VA = "0x1875074F0")]
		[CompilerGenerated]
		internal static bool DHARICRALDS([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75075D0", Offset = "0x75065D0", VA = "0x1875075D0")]
		[CompilerGenerated]
		internal static SIFLWCPVBWN VATYWULCHJE(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class BGZVJAAPHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74F4460", Offset = "0x74F3460", VA = "0x1874F4460")]
		public static int[] ROIXTXZMBOQ(this MOZQYZBZKKQ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x74F4310", Offset = "0x74F3310", VA = "0x1874F4310")]
		public static int[] PEWCWADJFYK(this MOZQYZBZKKQ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class IVSOIFBKFGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x74FE480", Offset = "0x74FD480", VA = "0x1874FE480")]
		public static uint YCINZDRLHQB(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream KJXEEHYBHTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long VUHKDOPOVUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long JRFHXJQBPRH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7507E70", Offset = "0x7506E70", VA = "0x187507E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7507EB0", Offset = "0x7506EB0", VA = "0x187507EB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7507EB0", Offset = "0x7506EB0", VA = "0x187507EB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7507ED0", Offset = "0x7506ED0", VA = "0x187507ED0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7507EF0", Offset = "0x7506EF0", VA = "0x187507EF0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7507F10", Offset = "0x7506F10", VA = "0x187507F10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7507C00", Offset = "0x7506C00", VA = "0x187507C00")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7507A50", Offset = "0x7506A50", VA = "0x187507A50", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7507B20", Offset = "0x7506B20", VA = "0x187507B20", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7507B80", Offset = "0x7506B80", VA = "0x187507B80", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7507A90", Offset = "0x7506A90", VA = "0x187507A90", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7507BC0", Offset = "0x7506BC0", VA = "0x187507BC0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75079C0", Offset = "0x75069C0", VA = "0x1875079C0")]
		private void FQFEUDSNRTW()
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
		public static Color ZZVUSYWZIAY
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x74F7420", Offset = "0x74F6420", VA = "0x1874F7420")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color HOGQUBTSVYS
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x74F7440", Offset = "0x74F6440", VA = "0x1874F7440")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color XJAJWUUNSRY
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x74F7350", Offset = "0x74F6350", VA = "0x1874F7350")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD11B0", VA = "0x182DD21B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E28160", Offset = "0x2E27160", VA = "0x182E28160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6990", VA = "0x182BA7990")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32AFBE0", Offset = "0x32AEBE0", VA = "0x1832AFBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF60", Offset = "0x15CCF60", VA = "0x1815CDF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF70", Offset = "0x15CCF70", VA = "0x1815CDF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B693F0", Offset = "0x2B683F0", VA = "0x182B693F0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74F7150", Offset = "0x74F6150", VA = "0x1874F7150", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74F7200", Offset = "0x74F6200", VA = "0x1874F7200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74F72A0", Offset = "0x74F62A0", VA = "0x1874F72A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74F7370", Offset = "0x74F6370", VA = "0x1874F7370")]
		public static bool JSVUWZZXHQQ(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KQQQCUNKXVC : IEquatable<KQQQCUNKXVC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly KQQQCUNKXVC NXZRPVOFPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] YUALOQNVTOB;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float LOIURMAAASG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7504B80", Offset = "0x7503B80", VA = "0x187504B80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7504A90", Offset = "0x7503A90", VA = "0x187504A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float SIYAUJJDTIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7504610", Offset = "0x7503610", VA = "0x187504610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7504580", Offset = "0x7503580", VA = "0x187504580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float YJGTLGELEHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7504DF0", Offset = "0x7503DF0", VA = "0x187504DF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7504D60", Offset = "0x7503D60", VA = "0x187504D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float DLJIFTYIEXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7504CA0", Offset = "0x7503CA0", VA = "0x187504CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7504BB0", Offset = "0x7503BB0", VA = "0x187504BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LODNUFGCRGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7504B20", Offset = "0x7503B20", VA = "0x187504B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7504A30", Offset = "0x7503A30", VA = "0x187504A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float SIIGCPBLRAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x75045E0", Offset = "0x75035E0", VA = "0x1875045E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7504550", Offset = "0x7503550", VA = "0x187504550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float YJWODAMDGPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7504E20", Offset = "0x7503E20", VA = "0x187504E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7504D90", Offset = "0x7503D90", VA = "0x187504D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DLOPDASFOIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7504D00", Offset = "0x7503D00", VA = "0x187504D00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7504C10", Offset = "0x7503C10", VA = "0x187504C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float LNYGWYMFHVO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7504B50", Offset = "0x7503B50", VA = "0x187504B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7504A60", Offset = "0x7503A60", VA = "0x187504A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float SINMZVVJALN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x75045B0", Offset = "0x75035B0", VA = "0x1875045B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7504520", Offset = "0x7503520", VA = "0x187504520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float YJRHFTSFXEG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7504E50", Offset = "0x7503E50", VA = "0x187504E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7504DC0", Offset = "0x7503DC0", VA = "0x187504DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float DLTWAHMCXUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7504CD0", Offset = "0x7503CD0", VA = "0x187504CD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7504BE0", Offset = "0x7503BE0", VA = "0x187504BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float LNSZZRSHYKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7504AF0", Offset = "0x7503AF0", VA = "0x187504AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7504AC0", Offset = "0x7503AC0", VA = "0x187504AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float SJNVMDQVVQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7504640", Offset = "0x7503640", VA = "0x187504640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x75044F0", Offset = "0x75034F0", VA = "0x1875044F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float YIQYTLWTBZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7504E80", Offset = "0x7503E80", VA = "0x187504E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7504D30", Offset = "0x7503D30", VA = "0x187504D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float DLZCXOGAHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7504C70", Offset = "0x7503C70", VA = "0x187504C70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7504C40", Offset = "0x7503C40", VA = "0x187504C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7504F90", Offset = "0x7503F90", VA = "0x187504F90")]
		public KQQQCUNKXVC(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7504770", Offset = "0x7503770", VA = "0x187504770", Slot = "4")]
		public bool Equals(KQQQCUNKXVC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7504670", Offset = "0x7503670", VA = "0x187504670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1187DA0", Offset = "0x1186DA0", VA = "0x181187DA0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD11B0", VA = "0x182DD21B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E28160", Offset = "0x2E27160", VA = "0x182E28160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6990", VA = "0x182BA7990")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32AFBE0", Offset = "0x32AEBE0", VA = "0x1832AFBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF60", Offset = "0x15CCF60", VA = "0x1815CDF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF70", Offset = "0x15CCF70", VA = "0x1815CDF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75072D0", Offset = "0x75062D0", VA = "0x1875072D0")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7506F30", Offset = "0x7505F30", VA = "0x187506F30", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7507050", Offset = "0x7506050", VA = "0x187507050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7507100", Offset = "0x7506100", VA = "0x187507100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75071E0", Offset = "0x75061E0", VA = "0x1875071E0")]
		public static bool JSVUWZZXHQQ(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD11B0", VA = "0x182DD21B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E28160", Offset = "0x2E27160", VA = "0x182E28160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x111BFD0", Offset = "0x111AFD0", VA = "0x18111BFD0")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7509300", Offset = "0x7508300", VA = "0x187509300")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7509110", Offset = "0x7508110", VA = "0x187509110", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7509170", Offset = "0x7508170", VA = "0x187509170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7509250", Offset = "0x7508250", VA = "0x187509250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x75092A0", Offset = "0x75082A0", VA = "0x1875092A0")]
		public static bool JSVUWZZXHQQ(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD11B0", VA = "0x182DD21B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E28160", Offset = "0x2E27160", VA = "0x182E28160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6990", VA = "0x182BA7990")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32AFBE0", Offset = "0x32AEBE0", VA = "0x1832AFBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x75096C0", Offset = "0x75086C0", VA = "0x1875096C0")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7509320", Offset = "0x7508320", VA = "0x187509320", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7509400", Offset = "0x7508400", VA = "0x187509400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75094C0", Offset = "0x75084C0", VA = "0x1875094C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7509570", Offset = "0x7508570", VA = "0x187509570")]
		public static bool JSVUWZZXHQQ(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD11B0", VA = "0x182DD21B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E28160", Offset = "0x2E27160", VA = "0x182E28160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6990", VA = "0x182BA7990")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32AFBE0", Offset = "0x32AEBE0", VA = "0x1832AFBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF60", Offset = "0x15CCF60", VA = "0x1815CDF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x15CDF70", Offset = "0x15CCF70", VA = "0x1815CDF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B693F0", Offset = "0x2B683F0", VA = "0x182B693F0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74F7150", Offset = "0x74F6150", VA = "0x1874F7150", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7509740", Offset = "0x7508740", VA = "0x187509740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74F72A0", Offset = "0x74F62A0", VA = "0x1874F72A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class KPIAHQJOWDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7504470", Offset = "0x7503470", VA = "0x187504470")]
		public static void NHQRLPBGICP(this JObject a, string b, ZPUEGAGUGTG c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IVSOIFBKFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74FE890", Offset = "0x74FD890", VA = "0x1874FE890")]
		public static List<string> YSKCUCHUZKM(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74FEA40", Offset = "0x74FDA40", VA = "0x1874FEA40")]
		public static List<double> ZFOFZPZSLZO(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74FD140", Offset = "0x74FC140", VA = "0x1874FD140")]
		public static List<int> BAVTMJGKADN(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x39F7F00", Offset = "0x39F6F00", VA = "0x1839F7F00")]
		public static List<a> UZNGZXMDJGV<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74FDF70", Offset = "0x74FCF70", VA = "0x1874FDF70")]
		public static ZPUEGAGUGTG NYLOQBSTAMX(this JToken a, MOZQYZBZKKQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x74FDE30", Offset = "0x74FCE30", VA = "0x1874FDE30")]
		public static int NFFDMGIGABL(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74FD770", Offset = "0x74FC770", VA = "0x1874FD770")]
		public static double KGKAVZGHBFD(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74FD8B0", Offset = "0x74FC8B0", VA = "0x1874FD8B0")]
		public static GLTF.Math.Color LOPFNZIEVMW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74FE210", Offset = "0x74FD210", VA = "0x1874FE210")]
		public static GLTF.Math.Color SQMJGXIYRKL(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74FDB90", Offset = "0x74FCB90", VA = "0x1874FDB90")]
		public static GLTF.Math.Color MREEPUTYIEP(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74FE5D0", Offset = "0x74FD5D0", VA = "0x1874FE5D0")]
		public static GLTF.Math.Vector3 YLNBRTFIMJV(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74FD560", Offset = "0x74FC560", VA = "0x1874FD560")]
		public static GLTF.Math.Vector2 GPUVPJXKTRF(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74FD300", Offset = "0x74FC300", VA = "0x1874FD300")]
		public static GLTF.Math.Vector3 GPPOSDDNKFW(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x74FCE30", Offset = "0x74FBE30", VA = "0x1874FCE30")]
		public static GLTF.Math.Quaternion ARCMRLEVVDH(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x39F76C0", Offset = "0x39F66C0", VA = "0x1839F76C0")]
		public static Dictionary<string, b> DMVVQGBGIXD<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x39F7BE0", Offset = "0x39F6BE0", VA = "0x1839F7BE0")]
		public static c DPBYAYESMYJ<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JKQJMUODNSS bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x74F86F0", Offset = "0x74F76F0", VA = "0x1874F86F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74F8670", Offset = "0x74F7670", VA = "0x1874F8670", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class NTIYRHKDOLH : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7505D50", Offset = "0x7504D50", VA = "0x187505D50")]
		public NTIYRHKDOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7505C80", Offset = "0x7504C80", VA = "0x187505C80", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, BLQUYAAIOUL> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74F8530", Offset = "0x74F7530", VA = "0x1874F8530", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x74F85F0", Offset = "0x74F75F0", VA = "0x1874F85F0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DHELJNDZROH : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public MOZQYZBZKKQ IMODBVGEZXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader DJFGVFNMDCK;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7509C00", Offset = "0x7508C00", VA = "0x187509C00")]
			internal BLQUYAAIOUL DRHGHTQLISU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74F75E0", Offset = "0x74F65E0", VA = "0x1874F75E0")]
		public DHELJNDZROH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x74F7450", Offset = "0x74F6450", VA = "0x1874F7450", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DGDLHCPUAJR KNTGPYDTBZG;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public EXT_texture_exr(DGDLHCPUAJR source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x74F8740", Offset = "0x74F7740", VA = "0x1874F8740", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x74F87B0", Offset = "0x74F77B0", VA = "0x1874F87B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class USDETXTIGXQ : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75090C0", Offset = "0x75080C0", VA = "0x1875090C0")]
		public USDETXTIGXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7508FA0", Offset = "0x7507FA0", VA = "0x187508FA0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
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
	public class AudioEmitterId : JDGTKXFDKRE<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x74F4030", Offset = "0x74F3030", VA = "0x1874F4030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x74F3FF0", Offset = "0x74F2FF0", VA = "0x1874F3FF0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : JDGTKXFDKRE<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x74F41C0", Offset = "0x74F31C0", VA = "0x1874F41C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x74F4180", Offset = "0x74F3180", VA = "0x1874F4180")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : JDGTKXFDKRE<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x74F3EA0", Offset = "0x74F2EA0", VA = "0x1874F3EA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74F3E60", Offset = "0x74F2E60", VA = "0x1874F3E60")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D80", Offset = "0x74F2D80", VA = "0x1874F3D80")]
		public static AudioDataId Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7500AC0", Offset = "0x74FFAC0", VA = "0x187500AC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75006C0", Offset = "0x74FF6C0", VA = "0x1875006C0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7500730", Offset = "0x74FF730", VA = "0x187500730")]
		public static KHR_SceneAudioEmittersRef Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7500D20", Offset = "0x74FFD20", VA = "0x187500D20")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7500690", Offset = "0x74FF690", VA = "0x187500690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7500570", Offset = "0x74FF570", VA = "0x187500570", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7500360", Offset = "0x74FF360", VA = "0x187500360", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75003D0", Offset = "0x74FF3D0", VA = "0x1875003D0")]
		public static KHR_NodeAudioEmitterRef Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DVZEMGDXHDR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JFNUOWCEURY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? SWGPJMTUXJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? ZDYIRATVXCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? BJQKTWTIGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? YSXLQSNXDLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? DOAQANICDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? SEYEWXADBUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? GQKHIEJJPWA;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x74F7FA0", Offset = "0x74F6FA0", VA = "0x1874F7FA0")]
		public JObject LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x74F78A0", Offset = "0x74F68A0", VA = "0x1874F78A0")]
		public static DVZEMGDXHDR Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public DVZEMGDXHDR()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : NSTIEONZZXM
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
		public DVZEMGDXHDR positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74FF9B0", Offset = "0x74FE9B0", VA = "0x1874FF9B0", Slot = "5")]
		public virtual JObject LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74FF4B0", Offset = "0x74FE4B0", VA = "0x1874FF4B0")]
		public static KHR_AudioEmitter Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x74FFD50", Offset = "0x74FED50", VA = "0x1874FFD50")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : NSTIEONZZXM
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
		[Cpp2IlInjected.Address(RVA = "0x7500130", Offset = "0x74FF130", VA = "0x187500130")]
		public JObject LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x74FFDD0", Offset = "0x74FEDD0", VA = "0x1874FFDD0")]
		public static KHR_AudioSource Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D70", Offset = "0x74F2D70", VA = "0x1874F3D70")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DZZAUNMRAHB bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x74FF380", Offset = "0x74FE380", VA = "0x1874FF380")]
		public JObject LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x74FF120", Offset = "0x74FE120", VA = "0x1874FF120")]
		public static KHR_AudioData Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D70", Offset = "0x74F2D70", VA = "0x1874F3D70")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : GTTEDQZKNAR
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
		[Cpp2IlInjected.Address(RVA = "0x7500FE0", Offset = "0x74FFFE0", VA = "0x187500FE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7500F50", Offset = "0x74FFF50", VA = "0x187500F50", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7501710", Offset = "0x7500710", VA = "0x187501710")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class YXMUVBZDLSO : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x750A860", Offset = "0x7509860", VA = "0x18750A860")]
		public YXMUVBZDLSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7509CB0", Offset = "0x7508CB0", VA = "0x187509CB0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DZZAUNMRAHB bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x75018E0", Offset = "0x75008E0", VA = "0x1875018E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7501820", Offset = "0x7500820", VA = "0x187501820", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7501930", Offset = "0x7500930", VA = "0x187501930")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class NOALJIHULEQ : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader DJFGVFNMDCK;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7509B90", Offset = "0x7508B90", VA = "0x187509B90")]
			internal int DRHGHTQLISU()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7505C30", Offset = "0x7504C30", VA = "0x187505C30")]
		public NOALJIHULEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7505A20", Offset = "0x7504A20", VA = "0x187505A20", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ZPUEGAGUGTG anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7501A30", Offset = "0x7500A30", VA = "0x187501A30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75019B0", Offset = "0x75009B0", VA = "0x1875019B0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class IUPCPMEEHUT : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x74FCDE0", Offset = "0x74FBDE0", VA = "0x1874FCDE0")]
		public IUPCPMEEHUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x74FCC30", Offset = "0x74FBC30", VA = "0x1874FCC30", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ZPUEGAGUGTG clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ZPUEGAGUGTG clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ZPUEGAGUGTG clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7501CE0", Offset = "0x7500CE0", VA = "0x187501CE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7501C40", Offset = "0x7500C40", VA = "0x187501C40", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class UNSVFYJBEHH : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7508F50", Offset = "0x7507F50", VA = "0x187508F50")]
		public UNSVFYJBEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7508CD0", Offset = "0x7507CD0", VA = "0x187508CD0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7502040", Offset = "0x7501040", VA = "0x187502040", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7501FD0", Offset = "0x7500FD0", VA = "0x187501FD0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class AQGANGJAKQR : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x74EF3A0", Offset = "0x74EE3A0", VA = "0x1874EF3A0")]
		public AQGANGJAKQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x74EF2D0", Offset = "0x74EE2D0", VA = "0x1874EF2D0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : NGNZGIMIYEN, GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float WHRDEJFCDEH;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7502390", Offset = "0x7501390", VA = "0x187502390")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7502320", Offset = "0x7501320", VA = "0x187502320")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, MOZQYZBZKKQ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7502160", Offset = "0x7501160", VA = "0x187502160", Slot = "6")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7502200", Offset = "0x7501200", VA = "0x187502200", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class RPZHINSHXJA : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x75074A0", Offset = "0x75064A0", VA = "0x1875074A0")]
		public RPZHINSHXJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x75073A0", Offset = "0x75063A0", VA = "0x1875073A0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7502440", Offset = "0x7501440", VA = "0x187502440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x75023E0", Offset = "0x75013E0", VA = "0x1875023E0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7502590", Offset = "0x7501590", VA = "0x187502590")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class QEMQVLBQSKJ : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7506C80", Offset = "0x7505C80", VA = "0x187506C80")]
		public QEMQVLBQSKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7506BB0", Offset = "0x7505BB0", VA = "0x187506BB0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ZPUEGAGUGTG iridescenceTexture;

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
		public ZPUEGAGUGTG iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7502640", Offset = "0x7501640", VA = "0x187502640", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75025A0", Offset = "0x75015A0", VA = "0x1875025A0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7502A00", Offset = "0x7501A00", VA = "0x187502A00")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class LVZNNIOQTPF : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x75057F0", Offset = "0x75047F0", VA = "0x1875057F0")]
		public LVZNNIOQTPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7505500", Offset = "0x7504500", VA = "0x187505500", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class OLQSJVXNIHI : GTTEDQZKNAR
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 OZGKYJYQMNM;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double QMBBWEUUXOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color TDBHBELRVIG;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color FBFWIPPXDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public ZPUEGAGUGTG LEWBBSAPBVK;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly ZPUEGAGUGTG YARWLTYKEBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 UAIFDFTBAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double XZNAEGDOAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ZPUEGAGUGTG LVJVBBYOPDT;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly ZPUEGAGUGTG NETQHKYCNPH;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x75066D0", Offset = "0x75056D0", VA = "0x1875066D0")]
		public OLQSJVXNIHI(GLTF.Math.Color a, ZPUEGAGUGTG b, GLTF.Math.Vector3 c, double d, ZPUEGAGUGTG e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7505DA0", Offset = "0x7504DA0", VA = "0x187505DA0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7505F60", Offset = "0x7504F60", VA = "0x187505F60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class XCTVEYRQEAI : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7509B40", Offset = "0x7508B40", VA = "0x187509B40")]
		public XCTVEYRQEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x75097E0", Offset = "0x75087E0", VA = "0x1875097E0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ZPUEGAGUGTG sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ZPUEGAGUGTG sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7502AF0", Offset = "0x7501AF0", VA = "0x187502AF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7502A20", Offset = "0x7501A20", VA = "0x187502A20", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7503000", Offset = "0x7502000", VA = "0x187503000")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class QAXTNEITRUS : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7506B60", Offset = "0x7505B60", VA = "0x187506B60")]
		public QAXTNEITRUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7506900", Offset = "0x7505900", VA = "0x187506900", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ZPUEGAGUGTG specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ZPUEGAGUGTG specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7503140", Offset = "0x7502140", VA = "0x187503140", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7503070", Offset = "0x7502070", VA = "0x187503070", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7503660", Offset = "0x7502660", VA = "0x187503660")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class DLFVYRINEQG : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x74F7850", Offset = "0x74F6850", VA = "0x1874F7850")]
		public DLFVYRINEQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x74F7630", Offset = "0x74F6630", VA = "0x1874F7630", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ZPUEGAGUGTG transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7503750", Offset = "0x7502750", VA = "0x187503750", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x75036D0", Offset = "0x75026D0", VA = "0x1875036D0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ZQCYZGKRMRR : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x750A9F0", Offset = "0x75099F0", VA = "0x18750A9F0")]
		public ZQCYZGKRMRR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x750A8B0", Offset = "0x75098B0", VA = "0x18750A8B0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class JTNJQKQSKKI : NGNZGIMIYEN, GTTEDQZKNAR
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x74FEE70", Offset = "0x74FDE70", VA = "0x1874FEE70")]
		public JTNJQKQSKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x74FEE00", Offset = "0x74FDE00", VA = "0x1874FEE00")]
		public JTNJQKQSKKI(JTNJQKQSKKI a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74FEC00", Offset = "0x74FDC00", VA = "0x1874FEC00", Slot = "6")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x74FECA0", Offset = "0x74FDCA0", VA = "0x1874FECA0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74FED30", Offset = "0x74FDD30", VA = "0x1874FED30", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class KWFLIYGGLDY : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x75052C0", Offset = "0x75042C0", VA = "0x1875052C0")]
		public KWFLIYGGLDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7505240", Offset = "0x7504240", VA = "0x187505240", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ZPUEGAGUGTG thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7503970", Offset = "0x7502970", VA = "0x187503970", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x75038E0", Offset = "0x75028E0", VA = "0x1875038E0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7503EA0", Offset = "0x7502EA0", VA = "0x187503EA0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class KESRJSRECNH : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x74FF0D0", Offset = "0x74FE0D0", VA = "0x1874FF0D0")]
		public KESRJSRECNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x74FEEC0", Offset = "0x74FDEC0", VA = "0x1874FEEC0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7503F20", Offset = "0x7502F20", VA = "0x187503F20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7503EC0", Offset = "0x7502EC0", VA = "0x187503EC0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12E1650", Offset = "0x12E0650", VA = "0x1812E1650")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class PECNFOMXPQD : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x75068B0", Offset = "0x75058B0", VA = "0x1875068B0")]
		public PECNFOMXPQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x75067D0", Offset = "0x75057D0", VA = "0x1875067D0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7504090", Offset = "0x7503090", VA = "0x187504090", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7504030", Offset = "0x7503030", VA = "0x187504030", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12E1650", Offset = "0x12E0650", VA = "0x1812E1650")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class QSDDROJOMMB : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7506EE0", Offset = "0x7505EE0", VA = "0x187506EE0")]
		public QSDDROJOMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7506E00", Offset = "0x7505E00", VA = "0x187506E00", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7504200", Offset = "0x7503200", VA = "0x187504200", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75041A0", Offset = "0x75031A0", VA = "0x1875041A0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12E1650", Offset = "0x12E0650", VA = "0x1812E1650")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class QKFCDLLARXV : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7506DB0", Offset = "0x7505DB0", VA = "0x187506DB0")]
		public QKFCDLLARXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7506CD0", Offset = "0x7505CD0", VA = "0x187506CD0", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DGDLHCPUAJR source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public KHR_texture_basisu(DGDLHCPUAJR source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7504310", Offset = "0x7503310", VA = "0x187504310", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7504380", Offset = "0x7503380", VA = "0x187504380", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class TFBVKYOWRSR : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x75080B0", Offset = "0x75070B0", VA = "0x1875080B0")]
		public TFBVKYOWRSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7507F50", Offset = "0x7506F50", VA = "0x187507F50", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class IHMVYYEBBTA : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 KEZYADECSKC;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 TIWFOFGWWGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double FHLSGNVNLMH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double YQYWEYQYVCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 XJDRLPXJKUN;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 HBFSLVFAVCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? IOQOVZZFYZF;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int UQXPIMVHEQN;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x74FCBB0", Offset = "0x74FBBB0", VA = "0x1874FCBB0")]
		public IHMVYYEBBTA(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x74FC460", Offset = "0x74FB460", VA = "0x1874FC460", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x74FC540", Offset = "0x74FB540", VA = "0x1874FC540", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DZMOUZZDLCU : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x74F84E0", Offset = "0x74F74E0", VA = "0x1874F84E0")]
		public DZMOUZZDLCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x74F8210", Offset = "0x74F7210", VA = "0x1874F8210", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class LOJLWPRDTZS : GTTEDQZKNAR
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> RXBPZUOOMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public LOJLWPRDTZS(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7505310", Offset = "0x7504310", VA = "0x187505310", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7505410", Offset = "0x7504410", VA = "0x187505410", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7505380", Offset = "0x7504380", VA = "0x187505380")]
		public List<double> NRBVELXDWGA(MOXNPQACASF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GSHEUQXIHAS : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x74FC410", Offset = "0x74FB410", VA = "0x1874FC410")]
		public GSHEUQXIHAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x74FC310", Offset = "0x74FB310", VA = "0x1874FC310", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ATGEJOFAUJM : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DZZAUNMRAHB JKQJMUODNSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint TSFXNZCODXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType ULEUMRANCWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool ROVOFBHHGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint ZRHYXWVKFWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType OVCFCLRZRCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> ORACTLMULMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> QOTRIOZKOVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public HSIERDOBGCO WFTFYTLFMYR;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D70", Offset = "0x74F2D70", VA = "0x1874F3D70")]
		public ATGEJOFAUJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCE0", Offset = "0x74EECE0", VA = "0x1874EFCE0")]
		public static ATGEJOFAUJM Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x74F1170", Offset = "0x74F0170", VA = "0x1874F1170", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x74F34F0", Offset = "0x74F24F0", VA = "0x1874F34F0")]
		private unsafe static sbyte UUJFGYMCRCL(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x74F2DF0", Offset = "0x74F1DF0", VA = "0x1874F2DF0")]
		private unsafe static float2 QRHYPDYTCXF(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x74F2810", Offset = "0x74F1810", VA = "0x1874F2810")]
		private unsafe static float3 PFAMPFCMADQ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x74F2980", Offset = "0x74F1980", VA = "0x1874F2980")]
		private unsafe static float4 PUHPOJUOMMJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x74F1D80", Offset = "0x74F0D80", VA = "0x1874F1D80")]
		private unsafe static float4x4 MTQGKEHKPXD(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x74F34F0", Offset = "0x74F24F0", VA = "0x1874F34F0")]
		private unsafe static byte XWAMPWIFTQM(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74F3810", Offset = "0x74F2810", VA = "0x1874F3810")]
		private unsafe static float2 WPNQHCTEAHQ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x74F1000", Offset = "0x74F0000", VA = "0x1874F1000")]
		private unsafe static float3 IGZKTANUDEP(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x74F2F30", Offset = "0x74F1F30", VA = "0x1874F2F30")]
		private unsafe static float4 RGDGJJLALLS(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x74F2670", Offset = "0x74F1670", VA = "0x1874F2670")]
		private unsafe static float4x4 OURDBOWVBSI(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCD0", Offset = "0x74EECD0", VA = "0x1874EFCD0")]
		private unsafe static short UGHRSSAJHVP(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x74F3C20", Offset = "0x74F2C20", VA = "0x1874F3C20")]
		private unsafe static float2 YYDOIPLGXIJ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74F0FB0", Offset = "0x74EFFB0", VA = "0x1874F0FB0")]
		private unsafe static float3 HPXKWCCYRVS(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x74F1F50", Offset = "0x74F0F50", VA = "0x1874F1F50")]
		private unsafe static float4 ODWPNOAIXLN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x74F3500", Offset = "0x74F2500", VA = "0x1874F3500")]
		private unsafe static float4x4 VJWPOMRBZDR(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCD0", Offset = "0x74EECD0", VA = "0x1874EFCD0")]
		private unsafe static ushort DVUKSJTOBKU(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x74F05F0", Offset = "0x74EF5F0", VA = "0x1874F05F0")]
		private unsafe static float2 FQMRXKWCJIG(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x74F34A0", Offset = "0x74F24A0", VA = "0x1874F34A0")]
		private unsafe static float3 TNSXASSNYWT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x74F0620", Offset = "0x74EF620", VA = "0x1874F0620")]
		private unsafe static float4x4 GHZJHCZBZIQ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x74F19E0", Offset = "0x74F09E0", VA = "0x1874F19E0")]
		private unsafe static float4 MHBUKOKLYTC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x74F1F40", Offset = "0x74F0F40", VA = "0x1874F1F40")]
		private unsafe static uint NYQDGDQXDPT(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCD0", Offset = "0x74EECD0", VA = "0x1874EFCD0")]
		private unsafe static ushort LNFCTIEZOBW(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x74EFAD0", Offset = "0x74EEAD0", VA = "0x1874EFAD0")]
		private unsafe static float BMEDBVHCTPH(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x74F1F20", Offset = "0x74F0F20", VA = "0x1874F1F20")]
		private unsafe static float2 NTDBHKIFSIB(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D20", Offset = "0x74F2D20", VA = "0x1874F3D20")]
		private unsafe static float3 ZNSCLNTLMEU(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74F29E0", Offset = "0x74F19E0", VA = "0x1874F29E0")]
		private unsafe static float4 PXYHFHXTRXZ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCA0", Offset = "0x74EECA0", VA = "0x1874EFCA0")]
		private unsafe static float4x4 CYAMPVBJPXN(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x74F29E0", Offset = "0x74F19E0", VA = "0x1874F29E0")]
		private unsafe static float4 ZXJBQWCENNE(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D40", Offset = "0x74F2D40", VA = "0x1874F3D40")]
		private unsafe static float4 ZXJBQWCENNE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x74F0140", Offset = "0x74EF140", VA = "0x1874F0140")]
		public static float3[] EYFCFARIWMX(ATGEJOFAUJM a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x74F07C0", Offset = "0x74EF7C0", VA = "0x1874F07C0")]
		public static float3[] GSVACUJZVMT(ATGEJOFAUJM a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x74F36A0", Offset = "0x74F26A0", VA = "0x1874F36A0")]
		public static uint[] WDKSLNAXJJQ(ATGEJOFAUJM a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x74F2860", Offset = "0x74F1860", VA = "0x1874F2860")]
		internal static void PSIHCVUFYDV(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x74F2FE0", Offset = "0x74F1FE0", VA = "0x1874F2FE0")]
		public uint[] SCQSGTAAKMO(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x74F2A10", Offset = "0x74F1A10", VA = "0x1874F2A10")]
		public float[] QAODLPSLIVA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x74F1750", Offset = "0x74F0750", VA = "0x1874F1750")]
		public float2[] LUEEBRETJRM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x74F3970", Offset = "0x74F2970", VA = "0x1874F3970")]
		public float2[] YTDYKCKEHAA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x74F0370", Offset = "0x74EF370", VA = "0x1874F0370")]
		public float3[] FIVYBWXGZVJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x74EF780", Offset = "0x74EE780", VA = "0x1874EF780")]
		public float3[] ASOLDFDVVAT(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x74F3230", Offset = "0x74F2230", VA = "0x1874F3230")]
		public float4[] SGFABKXDTGM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x74F0C40", Offset = "0x74EFC40", VA = "0x1874F0C40")]
		public float4[] HDWPDLIMHWM(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x74EF3F0", Offset = "0x74EE3F0", VA = "0x1874EF3F0")]
		public float4[] AHPUHUTRHSZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x74F1FB0", Offset = "0x74F0FB0", VA = "0x1874F1FB0")]
		public float3[] OIKYXWZKRGQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x74F2E20", Offset = "0x74F1E20", VA = "0x1874F2E20")]
		public float3[] QWRLUPHEGNF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x74F3C50", Offset = "0x74F2C50", VA = "0x1874F3C50")]
		public float4[] ZFXZJFNWSBF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x74F2F90", Offset = "0x74F1F90", VA = "0x1874F2F90")]
		public uint[] RHQSQEQXRNI(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x74F20C0", Offset = "0x74F10C0", VA = "0x1874F20C0")]
		public float4x4[] OIQBFGTUTZP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x74F1BC0", Offset = "0x74F0BC0", VA = "0x1874F1BC0")]
		private unsafe static float4 MHDMOHSOXRP(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x74F1A40", Offset = "0x74F0A40", VA = "0x1874F1A40")]
		private unsafe static float4 MHDMOHSOXRP(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x74F2C80", Offset = "0x74F1C80", VA = "0x1874F2C80")]
		private unsafe static float4x4 QKAFBQNRYWW(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x74EFAE0", Offset = "0x74EEAE0", VA = "0x1874EFAE0")]
		private unsafe static float4 CIKTRSEVEJU(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x74F0AD0", Offset = "0x74EFAD0", VA = "0x1874F0AD0")]
		private unsafe static float3 HBGNGNAOANX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x74F3840", Offset = "0x74F2840", VA = "0x1874F3840")]
		private unsafe static float2 WZAJTYWRPNW(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x74F1050", Offset = "0x74F0050", VA = "0x1874F1050")]
		private unsafe static uint KYSVSKXBPZL(void* a, uint b, GLTFComponentType c)
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
	public static class SPGQPIFNXFR
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x751B4C0", Offset = "0x751A4C0", VA = "0x18751B4C0")]
		public static int WBGVKVMKLGL(this GLTFAccessorAttributeType a)
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
	public class HSIERDOBGCO : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int ZRHYXWVKFWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public LNQWBFQOQKT PQLRKEAAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public PUIIWAJPVCY BOMWOVJOYKD;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x750FBE0", Offset = "0x750EBE0", VA = "0x18750FBE0")]
		public HSIERDOBGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x750F7E0", Offset = "0x750E7E0", VA = "0x18750F7E0")]
		public static HSIERDOBGCO Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x750FAB0", Offset = "0x750EAB0", VA = "0x18750FAB0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class LNQWBFQOQKT : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public DZZAUNMRAHB JKQJMUODNSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int TSFXNZCODXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType ULEUMRANCWI;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x75135F0", Offset = "0x75125F0", VA = "0x1875135F0")]
		public LNQWBFQOQKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x75131D0", Offset = "0x75121D0", VA = "0x1875131D0")]
		public static LNQWBFQOQKT Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x75134B0", Offset = "0x75124B0", VA = "0x1875134B0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PUIIWAJPVCY : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public DZZAUNMRAHB JKQJMUODNSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int TSFXNZCODXG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x751ACB0", Offset = "0x7519CB0", VA = "0x18751ACB0")]
		public PUIIWAJPVCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x751A930", Offset = "0x7519930", VA = "0x18751A930")]
		public static PUIIWAJPVCY Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x751ABB0", Offset = "0x7519BB0", VA = "0x18751ABB0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class JNBPDQMBCWU : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public JJRBSGTAHJI AIRAFZFBPVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public YRJANQSRFQN DFCLBQLXJKE;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7511DA0", Offset = "0x7510DA0", VA = "0x187511DA0")]
		public JNBPDQMBCWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7511AB0", Offset = "0x7510AB0", VA = "0x187511AB0")]
		public static JNBPDQMBCWU Deserialize(MOZQYZBZKKQ root, JsonReader reader, HTEIGPDOTWK anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7511CA0", Offset = "0x7510CA0", VA = "0x187511CA0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class YRJANQSRFQN : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public IPJZZZPIFAI MOXNPQACASF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string PVGXCHIFMGG;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x751FF40", Offset = "0x751EF40", VA = "0x18751FF40")]
		public static YRJANQSRFQN Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x75202C0", Offset = "0x751F2C0", VA = "0x1875202C0")]
		public YRJANQSRFQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x75201A0", Offset = "0x751F1A0", VA = "0x1875201A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
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
	public class ADLWXCNEQIW
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(ADLWXCNEQIW data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] TUYQCENTKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type RIUVWNGESZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] GRDBJVSENNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion VUQXNLWCIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string JTLLRXIJOPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string CDQTUZQMYRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public RHGDTUJDSNW PAWRICMTVCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string RUFBHXYZCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string EFWJJCKPUHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public RHGDTUJDSNW UEPTVWCDVER;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x750AA40", Offset = "0x7509A40", VA = "0x18750AA40")]
		public ADLWXCNEQIW()
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
	public class GGFWTLQDIET : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public BLQUYAAIOUL KXYGLTPUJSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType NXZWQFKSNEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public BLQUYAAIOUL IXBOMFRBVKY;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x750F610", Offset = "0x750E610", VA = "0x18750F610")]
		public GGFWTLQDIET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x750F280", Offset = "0x750E280", VA = "0x18750F280")]
		public static GGFWTLQDIET Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x750F4A0", Offset = "0x750E4A0", VA = "0x18750F4A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CSZYMVQIEEH : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string OMUJOKFWTZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string YKIKVSBJNWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string JEPOXRPVYOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string GQWBCJQTDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> PZBLKXJZTQZ;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x750CB50", Offset = "0x750BB50", VA = "0x18750CB50")]
		public CSZYMVQIEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x750C060", Offset = "0x750B060", VA = "0x18750C060")]
		public static CSZYMVQIEEH Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x750C380", Offset = "0x750B380", VA = "0x18750C380", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x750C7A0", Offset = "0x750B7A0", VA = "0x18750C7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x750C7B0", Offset = "0x750B7B0", VA = "0x18750C7B0")]
		public string UPPJSRUCQIJ(bool a)
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
	public class JKQJMUODNSS : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public MQXPVRLTSKG HBCLKCMHZPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint TSFXNZCODXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint PHGWHWEXPZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint OCNLQNSWBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget DFCLBQLXJKE;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public JKQJMUODNSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x75115F0", Offset = "0x75105F0", VA = "0x1875115F0")]
		public static JKQJMUODNSS Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x75118A0", Offset = "0x75108A0", VA = "0x1875118A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class JPRSLHLPZIE : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double SMSZRSDRXKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double FTZEQJRTEGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double LERJYQIPZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double MWEIFLDRWLN;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x75122E0", Offset = "0x75112E0", VA = "0x1875122E0")]
		public JPRSLHLPZIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7511DF0", Offset = "0x7510DF0", VA = "0x187511DF0")]
		public static JPRSLHLPZIE Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7512170", Offset = "0x7511170", VA = "0x187512170", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class CJHYHAILGDK : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double OTSABSWHTHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double PDEWNXHLTIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double LERJYQIPZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double MWEIFLDRWLN;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x750C000", Offset = "0x750B000", VA = "0x18750C000")]
		public CJHYHAILGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x750BB00", Offset = "0x750AB00", VA = "0x18750BB00")]
		public static CJHYHAILGDK Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x750BE70", Offset = "0x750AE70", VA = "0x18750BE70", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class HTEIGPDOTWK : NSTIEONZZXM
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public MOZQYZBZKKQ IMODBVGEZXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader DJFGVFNMDCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public HTEIGPDOTWK BOCBJBCQXFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<JNBPDQMBCWU> RTOYDAIMEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<GGFWTLQDIET> RTUFAHCJNRR;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x751F5A0", Offset = "0x751E5A0", VA = "0x18751F5A0")]
			internal JNBPDQMBCWU DRHGHTQLISU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x751F5C0", Offset = "0x751E5C0", VA = "0x18751F5C0")]
			internal GGFWTLQDIET DRMNFAKISED()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<JNBPDQMBCWU> QKQHGEMAULT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<GGFWTLQDIET> WMJSDIYQQCE;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x750FC30", Offset = "0x750EC30", VA = "0x18750FC30")]
		public static HTEIGPDOTWK Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7510390", Offset = "0x750F390", VA = "0x187510390")]
		public HTEIGPDOTWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x750FFF0", Offset = "0x750EFF0", VA = "0x18750FFF0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class IVRCGGDAILQ : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string DJGOIOAUZYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint PHGWHWEXPZV;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public IVRCGGDAILQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7510EA0", Offset = "0x750FEA0", VA = "0x187510EA0")]
		public static IVRCGGDAILQ Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7511070", Offset = "0x7510070", VA = "0x187511070", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LTVKRAMTCOX : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public JPRSLHLPZIE IAJEEEHPHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CJHYHAILGDK IZPSBFPWPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType OVCFCLRZRCZ;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public LTVKRAMTCOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7513640", Offset = "0x7512640", VA = "0x187513640")]
		public static LTVKRAMTCOX Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7513810", Offset = "0x7512810", VA = "0x187513810", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
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
	public class NSTIEONZZXM : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string LQPFQGKUSJI;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public NSTIEONZZXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x751A720", Offset = "0x7519720", VA = "0x18751A720")]
		public NSTIEONZZXM(NSTIEONZZXM a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x751A630", Offset = "0x7519630", VA = "0x18751A630")]
		public new void SDMWWRTVEZG(MOZQYZBZKKQ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x751A5A0", Offset = "0x75195A0", VA = "0x18751A5A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class JDGTKXFDKRE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int HGJTEJGBOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public MOZQYZBZKKQ BMMCJSHXUWV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected JDGTKXFDKRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x540D500", Offset = "0x540C500", VA = "0x18540D500")]
		public JDGTKXFDKRE(JDGTKXFDKRE<a> a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x540D4D0", Offset = "0x540C4D0", VA = "0x18540D4D0")]
		public void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BLQUYAAIOUL : JDGTKXFDKRE<ATGEJOFAUJM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override ATGEJOFAUJM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x750AC60", Offset = "0x7509C60", VA = "0x18750AC60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x750AC20", Offset = "0x7509C20", VA = "0x18750AC20")]
		public BLQUYAAIOUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x750ABC0", Offset = "0x7509BC0", VA = "0x18750ABC0")]
		public BLQUYAAIOUL(BLQUYAAIOUL a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x750AAE0", Offset = "0x7509AE0", VA = "0x18750AAE0")]
		public static BLQUYAAIOUL Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class MQXPVRLTSKG : JDGTKXFDKRE<IVRCGGDAILQ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override IVRCGGDAILQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7517C70", Offset = "0x7516C70", VA = "0x187517C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7517C30", Offset = "0x7516C30", VA = "0x187517C30")]
		public MQXPVRLTSKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7517B50", Offset = "0x7516B50", VA = "0x187517B50")]
		public static MQXPVRLTSKG Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class DZZAUNMRAHB : JDGTKXFDKRE<JKQJMUODNSS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override JKQJMUODNSS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x750E7A0", Offset = "0x750D7A0", VA = "0x18750E7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x750E760", Offset = "0x750D760", VA = "0x18750E760")]
		public DZZAUNMRAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x750E680", Offset = "0x750D680", VA = "0x18750E680")]
		public static DZZAUNMRAHB Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class GOQMVWLRDOX : JDGTKXFDKRE<LTVKRAMTCOX>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override LTVKRAMTCOX Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x750F780", Offset = "0x750E780", VA = "0x18750F780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x750F740", Offset = "0x750E740", VA = "0x18750F740")]
		public GOQMVWLRDOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x750F660", Offset = "0x750E660", VA = "0x18750F660")]
		public static GOQMVWLRDOX Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class DGDLHCPUAJR : JDGTKXFDKRE<KQEXAOENPQN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override KQEXAOENPQN Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x750DFB0", Offset = "0x750CFB0", VA = "0x18750DFB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x750DF70", Offset = "0x750CF70", VA = "0x18750DF70")]
		public DGDLHCPUAJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x750DE90", Offset = "0x750CE90", VA = "0x18750DE90")]
		public static DGDLHCPUAJR Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class VNXIBTGIWAJ : JDGTKXFDKRE<UGAHMAFKMCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override UGAHMAFKMCJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x751EA70", Offset = "0x751DA70", VA = "0x18751EA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x751E9D0", Offset = "0x751D9D0", VA = "0x18751E9D0")]
		public VNXIBTGIWAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x751EA10", Offset = "0x751DA10", VA = "0x18751EA10")]
		public VNXIBTGIWAJ(VNXIBTGIWAJ a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x751E8F0", Offset = "0x751D8F0", VA = "0x18751E8F0")]
		public static VNXIBTGIWAJ Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class LCENASXJWVT : JDGTKXFDKRE<YHHKUCNSGIB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override YHHKUCNSGIB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7513170", Offset = "0x7512170", VA = "0x187513170", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7513130", Offset = "0x7512130", VA = "0x187513130")]
		public LCENASXJWVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7513050", Offset = "0x7512050", VA = "0x187513050")]
		public static LCENASXJWVT Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class IPJZZZPIFAI : JDGTKXFDKRE<MOXNPQACASF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override MOXNPQACASF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x7510A30", Offset = "0x750FA30", VA = "0x187510A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x75109F0", Offset = "0x750F9F0", VA = "0x1875109F0")]
		public IPJZZZPIFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x75106A0", Offset = "0x750F6A0", VA = "0x1875106A0")]
		public static IPJZZZPIFAI Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7510780", Offset = "0x750F780", VA = "0x187510780")]
		public static List<IPJZZZPIFAI> UZNGZXMDJGV(MOZQYZBZKKQ a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class PFLKDBSRIGS : JDGTKXFDKRE<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x751A8D0", Offset = "0x75198D0", VA = "0x18751A8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x751A890", Offset = "0x7519890", VA = "0x18751A890")]
		public PFLKDBSRIGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x751A7B0", Offset = "0x75197B0", VA = "0x18751A7B0")]
		public static PFLKDBSRIGS Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class JJRBSGTAHJI : JDGTKXFDKRE<GGFWTLQDIET>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HTEIGPDOTWK HTEIGPDOTWK;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override GGFWTLQDIET Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7511590", Offset = "0x7510590", VA = "0x187511590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7511550", Offset = "0x7510550", VA = "0x187511550")]
		public JJRBSGTAHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7511450", Offset = "0x7510450", VA = "0x187511450")]
		public static JJRBSGTAHJI Deserialize(MOZQYZBZKKQ root, HTEIGPDOTWK anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class YVLXLCMNZJM : JDGTKXFDKRE<KVAVSUMBJVO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override KVAVSUMBJVO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7520430", Offset = "0x751F430", VA = "0x187520430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x75203F0", Offset = "0x751F3F0", VA = "0x1875203F0")]
		public YVLXLCMNZJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7520310", Offset = "0x751F310", VA = "0x187520310")]
		public static YVLXLCMNZJM Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class IHUVPZHBRWJ : JDGTKXFDKRE<WAKTGHTIKDG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override WAKTGHTIKDG Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x75105A0", Offset = "0x750F5A0", VA = "0x1875105A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7510560", Offset = "0x750F560", VA = "0x187510560")]
		public IHUVPZHBRWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7510480", Offset = "0x750F480", VA = "0x187510480")]
		public static IHUVPZHBRWJ Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KLBACZMTWPX : JDGTKXFDKRE<JUDCZOMTPJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override JUDCZOMTPJB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x75127F0", Offset = "0x75117F0", VA = "0x1875127F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7512750", Offset = "0x7511750", VA = "0x187512750")]
		public KLBACZMTWPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7512790", Offset = "0x7511790", VA = "0x187512790")]
		public KLBACZMTWPX(KLBACZMTWPX a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7512670", Offset = "0x7511670", VA = "0x187512670")]
		public static KLBACZMTWPX Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class IOQFWUBIHHE : JDGTKXFDKRE<RBCMMPBQGNO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override RBCMMPBQGNO Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7510640", Offset = "0x750F640", VA = "0x187510640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7510600", Offset = "0x750F600", VA = "0x187510600")]
		public IOQFWUBIHHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class KQEXAOENPQN : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string DJGOIOAUZYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string KNJDJSDBHDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public DZZAUNMRAHB JKQJMUODNSS;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public KQEXAOENPQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7512850", Offset = "0x7511850", VA = "0x187512850")]
		public static KQEXAOENPQN Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7512A90", Offset = "0x7511A90", VA = "0x187512A90", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class UGAHMAFKMCJ : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public DKOALYVJJAU DKOALYVJJAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public UREEUWSFXON GFIRASDRZWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public WLGQBRRTNGR BOUGZEFSGZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ITHOHNEKTGR PDXMEHJXVVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public ZPUEGAGUGTG NXTDFJRRAUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color TOACHJDRLWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode AGWPJABIBWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double VIVKYJGXCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool WOFORJBGRQF;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x751C8D0", Offset = "0x751B8D0", VA = "0x18751C8D0")]
		public UGAHMAFKMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x751BF60", Offset = "0x751AF60", VA = "0x18751BF60")]
		public static UGAHMAFKMCJ Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x751C470", Offset = "0x751B470", VA = "0x18751C470", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
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
	public class YHHKUCNSGIB : NSTIEONZZXM
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class DABAUKZQTLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public MOZQYZBZKKQ IMODBVGEZXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader DJFGVFNMDCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<VJLNTTRABTH> RTOYDAIMEGI;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DABAUKZQTLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x750DE80", Offset = "0x750CE80", VA = "0x18750DE80")]
			internal VJLNTTRABTH DRHGHTQLISU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<VJLNTTRABTH> XEEAGCNSXWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> KRPQFGZUIYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> MGPLZMVLMSI;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public YHHKUCNSGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x751F5D0", Offset = "0x751E5D0", VA = "0x18751F5D0")]
		public static YHHKUCNSGIB Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x751F990", Offset = "0x751E990", VA = "0x18751F990", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class NGNZGIMIYEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, QFEMSMGESEA> BNOVEAMBVZG;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static CAKEXKEXBDF SKYBDPUHQAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, GTTEDQZKNAR> RGOLBGNHQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken LUGRENTZEWW;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x75186E0", Offset = "0x75176E0", VA = "0x1875186E0")]
		public static QFEMSMGESEA HTVXDSNZAWL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7517F20", Offset = "0x7516F20", VA = "0x187517F20")]
		public static GTTEDQZKNAR CWOALOAPNHJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public NGNZGIMIYEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x75199A0", Offset = "0x75189A0", VA = "0x1875199A0")]
		public NGNZGIMIYEN(NGNZGIMIYEN a, [Optional] MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7518BF0", Offset = "0x7517BF0", VA = "0x187518BF0")]
		public void SDMWWRTVEZG(MOZQYZBZKKQ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7518F60", Offset = "0x7517F60", VA = "0x187518F60")]
		public void UCIRQQYVNQJ(string a, GTTEDQZKNAR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x75185F0", Offset = "0x75175F0", VA = "0x1875185F0")]
		private void GSNYNAZWKIX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7518EA0", Offset = "0x7517EA0", VA = "0x187518EA0")]
		private void SZIULZLCAFL(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x75190B0", Offset = "0x75180B0", VA = "0x1875190B0")]
		private void WVBNMZMSFQT(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7518010", Offset = "0x7517010", VA = "0x187518010")]
		internal static Dictionary<string, GTTEDQZKNAR> FFQMUNHRUZU(MOZQYZBZKKQ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7518870", Offset = "0x7517870", VA = "0x187518870", Slot = "4")]
		public virtual void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class MOZQYZBZKKQ : NGNZGIMIYEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class JJOXKGWUTXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public MOZQYZBZKKQ IMODBVGEZXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader NPSRWLCBHHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<ATGEJOFAUJM> RTOYDAIMEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<HTEIGPDOTWK> RTUFAHCJNRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<IVRCGGDAILQ> RTZLXNWGXDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<JKQJMUODNSS> RUESUUQEGOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<LTVKRAMTCOX> RSTWNZGWSMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<KQEXAOENPQN> RSZDLGAUBYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<UGAHMAFKMCJ> RTEKIMURLJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<YHHKUCNSGIB> RTJRFTOOUUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<MOXNPQACASF> RRYUYYFHGTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> RSEBWEZEQEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<KVAVSUMBJVO> KKRILUIYHER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<WAKTGHTIKDG> KKMBONPAXTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<JUDCZOMTPJB> KKGURGVDOHZ;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JJOXKGWUTXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7511210", Offset = "0x7510210", VA = "0x187511210")]
			internal ATGEJOFAUJM DRHGHTQLISU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7511220", Offset = "0x7510220", VA = "0x187511220")]
			internal HTEIGPDOTWK DRMNFAKISED()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7511230", Offset = "0x7510230", VA = "0x187511230")]
			internal IVRCGGDAILQ DRRUCHEGBPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7511240", Offset = "0x7510240", VA = "0x187511240")]
			internal JKQJMUODNSS DRXAZNYDLAV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7511250", Offset = "0x7510250", VA = "0x187511250")]
			internal LTVKRAMTCOX DSCHWUSAUME()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7511260", Offset = "0x7510260", VA = "0x187511260")]
			internal KQEXAOENPQN DSHOUBLYDXN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7511270", Offset = "0x7510270", VA = "0x187511270")]
			internal UGAHMAFKMCJ DSMVRIFVNIW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7511280", Offset = "0x7510280", VA = "0x187511280")]
			internal YHHKUCNSGIB DSSCOOZSWUF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7511290", Offset = "0x7510290", VA = "0x187511290")]
			internal MOXNPQACASF DSXJLVTQGFO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x75112A0", Offset = "0x75102A0", VA = "0x1875112A0")]
			internal Sampler DTCQJCNNPQX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x75112D0", Offset = "0x75102D0", VA = "0x1875112D0")]
			internal KVAVSUMBJVO ZEBEYZDOWSN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x75112C0", Offset = "0x75102C0", VA = "0x1875112C0")]
			internal WAKTGHTIKDG ZDVYBSJRNHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x75112B0", Offset = "0x75102B0", VA = "0x1875112B0")]
			internal JUDCZOMTPJB ZDQRELPUDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> MRDAWFENMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> WIBIIWNHYNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<ATGEJOFAUJM> IVQAZDRXMQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<HTEIGPDOTWK> SFENBWYTKZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CSZYMVQIEEH CSZYMVQIEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<IVRCGGDAILQ> WJYQWYUQCTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<JKQJMUODNSS> MAYVGGPTIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<LTVKRAMTCOX> NHAYLBDSSZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<KQEXAOENPQN> JHZRCLMIBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<UGAHMAFKMCJ> ZAYXWYFEYRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<YHHKUCNSGIB> YHWVTZWSEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<MOXNPQACASF> RMVOWLZGZCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> WMJSDIYQQCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public YVLXLCMNZJM GRMUHKEVXNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<KVAVSUMBJVO> ZWSWWGJJZZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<WAKTGHTIKDG> CMHUYFLLRDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<JUDCZOMTPJB> QUYPOSHAQGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<RBCMMPBQGNO> ZUCJQQATDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool WBSZFGZGWHK;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7517B00", Offset = "0x7516B00", VA = "0x187517B00")]
		public MOZQYZBZKKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7517A60", Offset = "0x7516A60", VA = "0x187517A60")]
		public KVAVSUMBJVO YHLOWKDSNLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7515060", Offset = "0x7514060", VA = "0x187515060")]
		public static MOZQYZBZKKQ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7515EB0", Offset = "0x7514EB0", VA = "0x187515EB0")]
		public void LDGVYQLXUAF(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class KVAVSUMBJVO : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<IPJZZZPIFAI> RMVOWLZGZCW;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public KVAVSUMBJVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7512C60", Offset = "0x7511C60", VA = "0x187512C60")]
		public static KVAVSUMBJVO Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7512DE0", Offset = "0x7511DE0", VA = "0x187512DE0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class JUDCZOMTPJB : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public PFLKDBSRIGS AIRAFZFBPVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public DGDLHCPUAJR FWHGXTHPYLW;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public JUDCZOMTPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7512330", Offset = "0x7511330", VA = "0x187512330")]
		public static JUDCZOMTPJB Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7512500", Offset = "0x7511500", VA = "0x187512500", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class SCIZJACLBFW : RBCMMPBQGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public SCIZJACLBFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x751A7A0", Offset = "0x75197A0", VA = "0x18751A7A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class RBCMMPBQGNO : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string UQNDIZHCVCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color VTENJVPYWZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string DCVVHWLTKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float DGDCMRFQFQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float ORVSCVPQRMC;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public RBCMMPBQGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x751AD00", Offset = "0x7519D00", VA = "0x18751AD00", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class PEQJYHGRJUK : RBCMMPBQGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x75111C0", Offset = "0x75101C0", VA = "0x1875111C0")]
		public PEQJYHGRJUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x751A7A0", Offset = "0x75197A0", VA = "0x18751A7A0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class CXPLIEBVBSA : RBCMMPBQGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float NKHRWHUJORV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float XTQAETBQCHM;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x750CEF0", Offset = "0x750BEF0", VA = "0x18750CEF0")]
		public CXPLIEBVBSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x750CBF0", Offset = "0x750BBF0", VA = "0x18750CBF0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface YZESYBWZEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VRDDJPHYNXW(MOZQYZBZKKQ a, SIFLWCPVBWN b, [Out] ADLWXCNEQIW c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface GTTEDQZKNAR
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GTTEDQZKNAR Clone(MOZQYZBZKKQ root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class QFEMSMGESEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string VKMHFFMUZPD;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected QFEMSMGESEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class BMEHWSOCEVB : GTTEDQZKNAR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty FDLNYLCSXZY
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x750ACC0", Offset = "0x7509CC0", VA = "0x18750ACC0", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BMEHWSOCEVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class CAKEXKEXBDF : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x750BA90", Offset = "0x750AA90", VA = "0x18750BA90", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CAKEXKEXBDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class UREEUWSFXON : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color GZEPGGCLMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ZPUEGAGUGTG OELIWOVXMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color BPGKAIGVAOA;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x751CE40", Offset = "0x751BE40", VA = "0x18751CE40")]
		public UREEUWSFXON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x751C940", Offset = "0x751B940", VA = "0x18751C940")]
		public static UREEUWSFXON Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x751CBE0", Offset = "0x751BBE0", VA = "0x18751CBE0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class WLGQBRRTNGR : ZPUEGAGUGTG
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string KBIHNYJGGDP = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double XJDRLPXJKUN;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7510E40", Offset = "0x750FE40", VA = "0x187510E40")]
		public WLGQBRRTNGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x751F1F0", Offset = "0x751E1F0", VA = "0x18751F1F0")]
		public new static WLGQBRRTNGR Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x751F4E0", Offset = "0x751E4E0", VA = "0x18751F4E0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ITHOHNEKTGR : ZPUEGAGUGTG
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string QNHBRZPJPMY = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double UOXCNPKJLKM;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7510E40", Offset = "0x750FE40", VA = "0x187510E40")]
		public ITHOHNEKTGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7510A90", Offset = "0x750FA90", VA = "0x187510A90")]
		public new static ITHOHNEKTGR Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7510D80", Offset = "0x750FD80", VA = "0x187510D80", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class DKOALYVJJAU : NGNZGIMIYEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color HFEOXBZGOWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public ZPUEGAGUGTG WMQVLHSKGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double LHTYSQRIQRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double ZZFLEQQLLCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public ZPUEGAGUGTG NIHRXZGWWIZ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x750E610", Offset = "0x750D610", VA = "0x18750E610")]
		public DKOALYVJJAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x750E010", Offset = "0x750D010", VA = "0x18750E010")]
		public static DKOALYVJJAU Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x750E380", Offset = "0x750D380", VA = "0x18750E380", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class VJLNTTRABTH : NGNZGIMIYEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class NFXTCRZLHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader DJFGVFNMDCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public MOZQYZBZKKQ IMODBVGEZXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<BLQUYAAIOUL> RTOYDAIMEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<BLQUYAAIOUL> RTZLXNWGXDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, BLQUYAAIOUL>> RTUFAHCJNRR;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NFXTCRZLHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7517CD0", Offset = "0x7516CD0", VA = "0x187517CD0")]
			internal BLQUYAAIOUL DRHGHTQLISU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7517DA0", Offset = "0x7516DA0", VA = "0x187517DA0")]
			internal Dictionary<string, BLQUYAAIOUL> DRMNFAKISED()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7517E50", Offset = "0x7516E50", VA = "0x187517E50")]
			internal BLQUYAAIOUL DRRUCHEGBPM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, BLQUYAAIOUL> OYLBVHHTLTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public BLQUYAAIOUL PQLRKEAAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public VNXIBTGIWAJ RYWLXOHWOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode EBHZNDTKXHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, BLQUYAAIOUL>> ZFLFKBYJYIN;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x751E1B0", Offset = "0x751D1B0", VA = "0x18751E1B0")]
		public VJLNTTRABTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x751E250", Offset = "0x751D250", VA = "0x18751E250")]
		public VJLNTTRABTH(VJLNTTRABTH a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x751DDA0", Offset = "0x751CDA0", VA = "0x18751DDA0")]
		public static int[] MQJDJRVGDAL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x751D400", Offset = "0x751C400", VA = "0x18751D400")]
		public static int[] GCJESAPXWIR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x751DFF0", Offset = "0x751CFF0", VA = "0x18751DFF0")]
		public static int[] YFLLQGGWKHF(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x751D560", Offset = "0x751C560", VA = "0x18751D560")]
		public static int[] KPNAJILRRJT(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x751DE40", Offset = "0x751CE40", VA = "0x18751DE40")]
		public static int[] NCUCDXJUVMI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x751CEB0", Offset = "0x751BEB0", VA = "0x18751CEB0")]
		public static int[] ARQTINTIQIZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x751CF20", Offset = "0x751BF20", VA = "0x18751CF20")]
		public static int[] CWWMTHRKCJT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x751DEF0", Offset = "0x751CEF0", VA = "0x18751DEF0")]
		public static int[] SZWKQPIACXM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x751DF60", Offset = "0x751CF60", VA = "0x18751DF60")]
		public static int[] XAEOGIRCMSG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x751CFB0", Offset = "0x751BFB0", VA = "0x18751CFB0")]
		public static VJLNTTRABTH Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x751D7B0", Offset = "0x751C7B0", VA = "0x18751D7B0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class FLJZMTSOOPW
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] IOQOVZZFYZF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] LRBYOOMORPK;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] FQPZDLEXKVT;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] CKYMSUYQENB;
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
	public class MOXNPQACASF : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool OZYBSQQTHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GOQMVWLRDOX TMGJMASXOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<IPJZZZPIFAI> MJPURCLPGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public IHUVPZHBRWJ WAKTGHTIKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public KQQQCUNKXVC YDIVSHBLHYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public LCENASXJWVT QEBAODMDIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion FHLSGNVNLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 XJDRLPXJKUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 WILERQXVJIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> KRPQFGZUIYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public IOQFWUBIHHE WBZWMMPUZZN;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7514F20", Offset = "0x7513F20", VA = "0x187514F20")]
		public MOXNPQACASF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x75139E0", Offset = "0x75129E0", VA = "0x1875139E0")]
		public static MOXNPQACASF Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7514320", Offset = "0x7513320", VA = "0x187514320", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode PVQOTOXQFZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode WOYSUHODLSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode MISWXJMBJYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode MJIRPDTTMGT;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x751B9E0", Offset = "0x751A9E0", VA = "0x18751B9E0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x751B520", Offset = "0x751A520", VA = "0x18751B520")]
		public static Sampler Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x751B7F0", Offset = "0x751A7F0", VA = "0x18751B7F0", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
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
	public class WAKTGHTIKDG : NSTIEONZZXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BLQUYAAIOUL FJPGLJPQKQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public IPJZZZPIFAI OYPBZDQAHTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<IPJZZZPIFAI> YOYCWENPCHK;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x751F140", Offset = "0x751E140", VA = "0x18751F140")]
		public WAKTGHTIKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x751EAD0", Offset = "0x751DAD0", VA = "0x18751EAD0")]
		public static WAKTGHTIKDG Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x751EE30", Offset = "0x751DE30", VA = "0x18751EE30", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class ZPUEGAGUGTG : NGNZGIMIYEN
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string KIJNCNZFPVB = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string VFRBZVDZKTZ = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public KLBACZMTWPX EYRVWTAEZEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int IOQOVZZFYZF;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7520930", Offset = "0x751F930", VA = "0x187520930")]
		public ZPUEGAGUGTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7520840", Offset = "0x751F840", VA = "0x187520840")]
		public ZPUEGAGUGTG(ZPUEGAGUGTG a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7520490", Offset = "0x751F490", VA = "0x187520490")]
		public static ZPUEGAGUGTG Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7520710", Offset = "0x751F710", VA = "0x187520710", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7520770", Offset = "0x751F770", VA = "0x187520770")]
		public void TRISHYEJEBC(JsonWriter a)
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
	public class EWSCVILCIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double IQKLUGUIWTT;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double XVFPGEZDCWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double FDGUZMJGIRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double HGFPVKXBTPQ;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x750EF30", Offset = "0x750DF30", VA = "0x18750EF30")]
		public EWSCVILCIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x750EA70", Offset = "0x750DA70", VA = "0x18750EA70")]
		public static EWSCVILCIAJ Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x750ECC0", Offset = "0x750DCC0", VA = "0x18750ECC0")]
		public void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class BQHURJANTQV : NSTIEONZZXM
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color HCEATKTOECO;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double AABJCXTZBSE;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double NQTSIXVBQFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType OVCFCLRZRCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color LRBYOOMORPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double YQUZYGAUAXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double BSSQFHLAYSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public EWSCVILCIAJ EWSCVILCIAJ;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x750B660", Offset = "0x750A660", VA = "0x18750B660")]
		public BQHURJANTQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x750B720", Offset = "0x750A720", VA = "0x18750B720")]
		public BQHURJANTQV(BQHURJANTQV a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x750AE90", Offset = "0x7509E90", VA = "0x18750AE90")]
		public static BQHURJANTQV Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x750AD70", Offset = "0x7509D70", VA = "0x18750AD70")]
		public static BQHURJANTQV Deserialize(MOZQYZBZKKQ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x750B280", Offset = "0x750A280", VA = "0x18750B280", Slot = "4")]
		public override void LDGVYQLXUAF(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class NSAFOFOADPV : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<RBCMMPBQGNO> ZORZFXXPVRS;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public NSAFOFOADPV(IList<RBCMMPBQGNO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7519D00", Offset = "0x7518D00", VA = "0x187519D00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7519C90", Offset = "0x7518C90", VA = "0x187519C90", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class CZDJSBQHZIP : GTTEDQZKNAR, YZESYBWZEFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<BQHURJANTQV> ZUCJQQATDGI;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x750DE00", Offset = "0x750CE00", VA = "0x18750DE00")]
		public CZDJSBQHZIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x750CF40", Offset = "0x750BF40", VA = "0x18750CF40", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x750D670", Offset = "0x750C670", VA = "0x18750D670", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x750DB50", Offset = "0x750CB50", VA = "0x18750DB50")]
		private static string[] ZLPGKIKBKPV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x750D1D0", Offset = "0x750C1D0", VA = "0x18750D1D0")]
		private static ADLWXCNEQIW.ImportValuesConversion OHWTIINRWGX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x750D760", Offset = "0x750C760", VA = "0x18750D760", Slot = "6")]
		public bool VRDDJPHYNXW(MOZQYZBZKKQ a, SIFLWCPVBWN b, [Out] ADLWXCNEQIW c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class ENYSBIUFEFS : JDGTKXFDKRE<BQHURJANTQV>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override BQHURJANTQV Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x750E920", Offset = "0x750D920", VA = "0x18750E920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x750E8E0", Offset = "0x750D8E0", VA = "0x18750E8E0")]
		public ENYSBIUFEFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x750E800", Offset = "0x750D800", VA = "0x18750E800")]
		public static ENYSBIUFEFS Deserialize(MOZQYZBZKKQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class BQUIORBOLZZ : GTTEDQZKNAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public ENYSBIUFEFS IOQFWUBIHHE;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public BQUIORBOLZZ(ENYSBIUFEFS a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x750B9D0", Offset = "0x750A9D0", VA = "0x18750B9D0")]
		public BQUIORBOLZZ(int a, MOZQYZBZKKQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x750B850", Offset = "0x750A850", VA = "0x18750B850", Slot = "5")]
		public GTTEDQZKNAR Clone(MOZQYZBZKKQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x750B8D0", Offset = "0x750A8D0", VA = "0x18750B8D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class SMSYHSXOOIW : QFEMSMGESEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x751B470", Offset = "0x751A470", VA = "0x18751B470")]
		public SMSYHSXOOIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x751AF80", Offset = "0x7519F80", VA = "0x18751AF80", Slot = "4")]
		public override GTTEDQZKNAR Deserialize(MOZQYZBZKKQ root, JProperty extensionToken)
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
