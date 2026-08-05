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
	public class KHR_animation_pointer : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object XAHDPYQKACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string QEITGKNYHET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string YODSDRFNMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public HQYCXRYQMTF IPELUBCYSNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer WBOMIKRCRLK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71B7FF0", Offset = "0x71B69F0", VA = "0x1871B7FF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F40", Offset = "0x71B6940", VA = "0x1871B7F40", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class WOWVLKCYMRE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 HNRAJFUKGAZ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 FKAKPRVQRJG;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion DPCELNZYAAM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AQHOXKQQFJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x71C7BD0", Offset = "0x71C65D0", VA = "0x1871C7BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71C68C0", Offset = "0x71C52C0", VA = "0x1871C68C0")]
		public static void OTICMVWVZMM(this BERLEXGGYBZ a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71C54E0", Offset = "0x71C3EE0", VA = "0x1871C54E0")]
		public static void HJOUNPBPSJU(this BERLEXGGYBZ a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71C74B0", Offset = "0x71C5EB0", VA = "0x1871C74B0")]
		public static void RVDYOUKAWMN(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71C52C0", Offset = "0x71C3CC0", VA = "0x1871C52C0")]
		public static GLTF.Math.Vector4 HBWIJDMWSAH(this GJOSHKOMLSK a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71C64E0", Offset = "0x71C4EE0", VA = "0x1871C64E0")]
		public static UnityEngine.Quaternion MTTGYZGMDVA(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71C63B0", Offset = "0x71C4DB0", VA = "0x1871C63B0")]
		public static UnityEngine.Quaternion MTTGYZGMDVA(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71C59E0", Offset = "0x71C43E0", VA = "0x1871C59E0")]
		public static GLTF.Math.Quaternion ICESFVANQTU(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71C80A0", Offset = "0x71C6AA0", VA = "0x1871C80A0")]
		public static Matrix4x4 XVVSIOENEOV(this GJOSHKOMLSK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71C7C60", Offset = "0x71C6660", VA = "0x1871C7C60")]
		public static Matrix4x4 XVVSIOENEOV(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71C6070", Offset = "0x71C4A70", VA = "0x1871C6070")]
		public static GJOSHKOMLSK LXCOZKNJDVH(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71C4DC0", Offset = "0x71C37C0", VA = "0x1871C4DC0")]
		public static UnityEngine.Vector3 AMCEMRIRETG(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71C4CF0", Offset = "0x71C36F0", VA = "0x1871C4CF0")]
		public static UnityEngine.Vector3 AMCEMRIRETG(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71C5F40", Offset = "0x71C4940", VA = "0x1871C5F40")]
		public static GLTF.Math.Vector3 LHNUDROWBRC(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71C7B90", Offset = "0x71C6590", VA = "0x1871C7B90")]
		public static GLTF.Math.Vector3 WUXROBYCUPD(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		public static GLTF.Math.Vector4 DINUQFGTYTY(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71C6F80", Offset = "0x71C5980", VA = "0x1871C6F80")]
		public static Matrix4x4 QVXIONLYUMM(this GJOSHKOMLSK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71C7240", Offset = "0x71C5C40", VA = "0x1871C7240")]
		public static Matrix4x4 QVXIONLYUMM(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71C5D70", Offset = "0x71C4770", VA = "0x1871C5D70")]
		public static GJOSHKOMLSK KCNRZTBHAPK(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71C4C00", Offset = "0x71C3600", VA = "0x1871C4C00")]
		public static UnityEngine.Vector2 AJAGCXQHTYM(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71C4C00", Offset = "0x71C3600", VA = "0x1871C4C00")]
		public static UnityEngine.Vector2 AJAGCXQHTYM(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71C4C20", Offset = "0x71C3620", VA = "0x1871C4C20")]
		public static void AJAGCXQHTYM(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71C6660", Offset = "0x71C5060", VA = "0x1871C6660")]
		public static UnityEngine.Vector3 MYCLKFQVPPL(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3CF0", Offset = "0x1AB26F0", VA = "0x181AB3CF0")]
		public static UnityEngine.Vector3 MYCLKFQVPPL(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71C66C0", Offset = "0x71C50C0", VA = "0x1871C66C0")]
		public static void MYCLKFQVPPL(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		public static UnityEngine.Vector4 AGJWJUGGLEO(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		public static UnityEngine.Vector4 AGJWJUGGLEO(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71C4B00", Offset = "0x71C3500", VA = "0x1871C4B00")]
		public static UnityEngine.Vector4[] AGJWJUGGLEO(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71C49F0", Offset = "0x71C33F0", VA = "0x1871C49F0")]
		public static void AGJWJUGGLEO(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71C5C60", Offset = "0x71C4660", VA = "0x1871C5C60")]
		public static UnityEngine.Color IUMUJDSIOYU(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71C5B20", Offset = "0x71C4520", VA = "0x1871C5B20")]
		public static void IUMUJDSIOYU(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71C5C60", Offset = "0x71C4660", VA = "0x1871C5C60")]
		public static UnityEngine.Color IUMUJDSIOYU(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		public static UnityEngine.Color OJWBPDZYIJJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71C67B0", Offset = "0x71C51B0", VA = "0x1871C67B0")]
		public static void OJWBPDZYIJJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		public static UnityEngine.Color OJWBPDZYIJJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71C4F60", Offset = "0x71C3960", VA = "0x1871C4F60")]
		public static GLTF.Math.Color DQLGQZUIIYV(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71C4EE0", Offset = "0x71C38E0", VA = "0x1871C4EE0")]
		public static GLTF.Math.Color DDZQTONPWME(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71C7880", Offset = "0x71C6280", VA = "0x1871C7880")]
		public static GLTF.Math.Color SLEPFBDQUXI(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71C6E60", Offset = "0x71C5860", VA = "0x1871C6E60")]
		public static UnityEngine.Color[] PKOQQDEYBHN(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71C7900", Offset = "0x71C6300", VA = "0x1871C7900")]
		public static int[] SYKERWNHFDY(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71C7AE0", Offset = "0x71C64E0", VA = "0x1871C7AE0")]
		public static UnityEngine.Vector2[] WHWLSIJIRWF(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71C7980", Offset = "0x71C6380", VA = "0x1871C7980")]
		public static void TFSVEFVOPIO(KGQVNKKAGMO a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71C5130", Offset = "0x71C3B30", VA = "0x1871C5130")]
		public static UnityEngine.Vector3[] EIVIKPPKPGK(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71C4F90", Offset = "0x71C3990", VA = "0x1871C4F90")]
		public static UnityEngine.Vector4[] ECCUFXSLAQH(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71C5D00", Offset = "0x71C4700", VA = "0x1871C5D00")]
		public static void JPBKSRMHRGK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71C5290", Offset = "0x71C3C90", VA = "0x1871C5290")]
		public static UnityEngine.Quaternion GBTSRCXJNPK(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class KGQVNKKAGMO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ANNHZWNIYUF ANNHZWNIYUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray PXAAYOADKCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71B6270", Offset = "0x71B4C70", VA = "0x1871B6270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> YUIOKUDNLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC02990", Offset = "0xC01390", VA = "0x180C02990")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCE3FC0", Offset = "0xCE29C0", VA = "0x180CE3FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint VBOLXXOSKHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71B6280", Offset = "0x71B4C80", VA = "0x1871B6280")]
		public KGQVNKKAGMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71B4D40", Offset = "0x71B3740", VA = "0x1871B4D40")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71B4DA0", Offset = "0x71B37A0", VA = "0x1871B4DA0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PPQYYJGWTWT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DIZMVRSPJNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> JLTENBHIPPU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public DIZMVRSPJNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71B36E0", Offset = "0x71B20E0", VA = "0x1871B36E0")]
			internal int? EGMVOELMANJ(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x71B3830", Offset = "0x71B2230", VA = "0x1871B3830")]
			internal int? OITZPOBBOHU(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x71B3760", Offset = "0x71B2160", VA = "0x1871B3760")]
			internal bool EYEDNYXVCRE(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71BE1D0", Offset = "0x71BCBD0", VA = "0x1871BE1D0")]
		private static void AIPKCUKLWWY(NumericArray a, KGQVNKKAGMO b, KGQVNKKAGMO c, KGQVNKKAGMO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71BEF10", Offset = "0x71BD910", VA = "0x1871BEF10")]
		public static void WZQHISURUYR(Dictionary<string, KGQVNKKAGMO> a, Dictionary<string, (KGQVNKKAGMO sparseIndices, KGQVNKKAGMO sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71BEA30", Offset = "0x71BD430", VA = "0x1871BEA30")]
		public static void VAYDBOVWUGB(Dictionary<string, KGQVNKKAGMO> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71BE930", Offset = "0x71BD330", VA = "0x1871BE930")]
		public static void OOGEUGUWXCS(KGQVNKKAGMO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71BDC40", Offset = "0x71BC640", VA = "0x1871BDC40")]
		public static void AEGIVYAQTJS(Dictionary<string, List<KGQVNKKAGMO>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71BE740", Offset = "0x71BD140", VA = "0x1871BE740")]
		private static void HHVETCLEAWI(KGQVNKKAGMO a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71BE870", Offset = "0x71BD270", VA = "0x1871BE870")]
		internal static void HHVETCLEAWI(TJHKYMCWPRO a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71C01D0", Offset = "0x71BEBD0", VA = "0x1871C01D0")]
		public static YQPLXVVAQMG XUGZSPPUVGU(IEnumerable<YQPLXVVAQMG> a)
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
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2E081B0", Offset = "0x2E06BB0", VA = "0x182E081B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2E081C0", Offset = "0x2E06BC0", VA = "0x182E081C0")]
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
	public class CPGGTILCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint LTWRWJMEOTY;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint AZRUIAVKYDO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint FGXOVKJRBOS;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71B2890", Offset = "0x71B1290", VA = "0x1871B2890")]
		public static void BSYUOOVVTXG(Stream a, [Out] WTVTOFLEGQC b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71B2F80", Offset = "0x71B1980", VA = "0x1871B2F80")]
		public static ChunkInfo WRPHUIDOWJG(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71B2A50", Offset = "0x71B1450", VA = "0x1871B2A50")]
		public static GLBHeader CLGMGPIMXJC(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71B2C20", Offset = "0x71B1620", VA = "0x1871B2C20")]
		public static bool GJWRJOPXXPI(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71B3210", Offset = "0x71B1C10", VA = "0x1871B3210")]
		public static ChunkInfo XLELHSSOMNV(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71B2CE0", Offset = "0x71B16E0", VA = "0x1871B2CE0")]
		private static void RHKYIMSZNLD(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71B2B90", Offset = "0x71B1590", VA = "0x1871B2B90")]
		private static uint DNTBNLPSBWE(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LOINOQVCLTV
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
		public PathElement XMZALPOMTCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int SPLEGEZJYLT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EIWXHIUAGUG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JWLVWZGMDSD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LOINOQVCLTV WSORJLAEAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x71BB800", Offset = "0x71BA200", VA = "0x1871BB800")]
		public string LZQCYMWUOTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71BB880", Offset = "0x71BA280", VA = "0x1871BB880")]
		public LOINOQVCLTV TAFEYQTRBBL(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71BB8A0", Offset = "0x71BA2A0", VA = "0x1871BB8A0")]
		private LOINOQVCLTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71BB900", Offset = "0x71BA300", VA = "0x1871BB900")]
		public LOINOQVCLTV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x405A020", Offset = "0x4058A20", VA = "0x18405A020")]
		[CompilerGenerated]
		internal static string JKFDRBGTWWP(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71BB7C0", Offset = "0x71BA1C0", VA = "0x1871BB7C0")]
		[CompilerGenerated]
		internal static bool CKZBUNJFEXE([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71BB5E0", Offset = "0x71B9FE0", VA = "0x1871BB5E0")]
		[CompilerGenerated]
		internal static LOINOQVCLTV BYMHCHMWJTC(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GQVMKDFFPRK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x71B4E00", Offset = "0x71B3800", VA = "0x1871B4E00")]
		public static int[] OEZGLRHPNJI(this WTVTOFLEGQC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x71B50A0", Offset = "0x71B3AA0", VA = "0x1871B50A0")]
		public static int[] PHITLKWAKYA(this WTVTOFLEGQC a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class TXLLBXGILNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x71C27D0", Offset = "0x71C11D0", VA = "0x1871C27D0")]
		public static uint KBPZIHIYBCT(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream XTWFYIWZQQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long OMMZNTXLCFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long NSLCHFYACDB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71C15A0", Offset = "0x71BFFA0", VA = "0x1871C15A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFFE0", VA = "0x1871C15E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFFE0", VA = "0x1871C15E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x71C1600", Offset = "0x71C0000", VA = "0x1871C1600", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x71C1620", Offset = "0x71C0020", VA = "0x1871C1620", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x71C1640", Offset = "0x71C0040", VA = "0x1871C1640", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71C1330", Offset = "0x71BFD30", VA = "0x1871C1330")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71C10F0", Offset = "0x71BFAF0", VA = "0x1871C10F0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71C1250", Offset = "0x71BFC50", VA = "0x1871C1250", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71C12B0", Offset = "0x71BFCB0", VA = "0x1871C12B0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71C11C0", Offset = "0x71BFBC0", VA = "0x1871C11C0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71C12F0", Offset = "0x71BFCF0", VA = "0x1871C12F0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71C1130", Offset = "0x71BFB30", VA = "0x1871C1130")]
		private void GDDXGWUATUC()
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
		public static Color BUENQVHMETM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x71B33E0", Offset = "0x71B1DE0", VA = "0x1871B33E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color LXUIIRCMVYY
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x71B36B0", Offset = "0x71B20B0", VA = "0x1871B36B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color HNOVSDBTMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x71B36C0", Offset = "0x71B20C0", VA = "0x1871B36C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B36630", Offset = "0x2B35030", VA = "0x182B36630")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B785B0", Offset = "0x2B76FB0", VA = "0x182B785B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B76FC0", VA = "0x182B785C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28F7F00", Offset = "0x28F6900", VA = "0x1828F7F00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCAE0", Offset = "0x2FFB4E0", VA = "0x182FFCAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x125E4A0", Offset = "0x125CEA0", VA = "0x18125E4A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x125E4B0", Offset = "0x125CEB0", VA = "0x18125E4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2D0", Offset = "0x28B8CD0", VA = "0x1828BA2D0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71B3400", Offset = "0x71B1E00", VA = "0x1871B3400", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71B34B0", Offset = "0x71B1EB0", VA = "0x1871B34B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71B3550", Offset = "0x71B1F50", VA = "0x1871B3550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71B3600", Offset = "0x71B2000", VA = "0x1871B3600")]
		public static bool IDTAQAUODHM(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class GJOSHKOMLSK : IEquatable<GJOSHKOMLSK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly GJOSHKOMLSK EWUYWGQBOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] DUPFDYAVVDF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float QZWIGPAWVCI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x71B4600", Offset = "0x71B3000", VA = "0x1871B4600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x71B4570", Offset = "0x71B2F70", VA = "0x1871B4570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float XERSIQCDURJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x71B40C0", Offset = "0x71B2AC0", VA = "0x1871B40C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x71B4030", Offset = "0x71B2A30", VA = "0x1871B4030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float EEYJMUWLRNA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x71B4990", Offset = "0x71B3390", VA = "0x1871B4990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x71B48A0", Offset = "0x71B32A0", VA = "0x1871B48A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MCGKXFMZJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x71B4810", Offset = "0x71B3210", VA = "0x1871B4810")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x71B4720", Offset = "0x71B3120", VA = "0x1871B4720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float RAMCYJIOXKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x71B4630", Offset = "0x71B3030", VA = "0x1871B4630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x71B45A0", Offset = "0x71B2FA0", VA = "0x1871B45A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float XEWZFWWBECS
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x71B4120", Offset = "0x71B2B20", VA = "0x1871B4120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x71B4090", Offset = "0x71B2A90", VA = "0x1871B4090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EETCPOCOIBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x71B4930", Offset = "0x71B3330", VA = "0x1871B4930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x71B4840", Offset = "0x71B3240", VA = "0x1871B4840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MBQQFLFHGUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x71B47E0", Offset = "0x71B31E0", VA = "0x1871B47E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x71B46F0", Offset = "0x71B30F0", VA = "0x1871B46F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float RAGWBCORNZA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x71B4660", Offset = "0x71B3060", VA = "0x1871B4660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x71B45D0", Offset = "0x71B2FD0", VA = "0x1871B45D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float XFCGDDPYNOB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x71B40F0", Offset = "0x71B2AF0", VA = "0x1871B40F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x71B4060", Offset = "0x71B2A60", VA = "0x1871B4060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float EENVSHIQYQI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x71B4960", Offset = "0x71B3360", VA = "0x1871B4960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x71B4870", Offset = "0x71B3270", VA = "0x1871B4870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float MBVXCRZEQFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x71B47B0", Offset = "0x71B31B0", VA = "0x1871B47B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x71B46C0", Offset = "0x71B30C0", VA = "0x1871B46C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float RAWQSWWJQHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x71B4690", Offset = "0x71B3090", VA = "0x1871B4690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x71B4540", Offset = "0x71B2F40", VA = "0x1871B4540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float XFHNAKJVWZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x71B4150", Offset = "0x71B2B50", VA = "0x1871B4150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x71B4000", Offset = "0x71B2A00", VA = "0x1871B4000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float EFYRZCRYMRT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x71B4900", Offset = "0x71B3300", VA = "0x1871B4900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x71B48D0", Offset = "0x71B32D0", VA = "0x1871B48D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float MCWFOZURLKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x71B4780", Offset = "0x71B3180", VA = "0x1871B4780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x71B4750", Offset = "0x71B3150", VA = "0x1871B4750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71B4A90", Offset = "0x71B3490", VA = "0x1871B4A90")]
		public GJOSHKOMLSK(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71B4280", Offset = "0x71B2C80", VA = "0x1871B4280", Slot = "4")]
		public bool Equals(GJOSHKOMLSK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x71B4180", Offset = "0x71B2B80", VA = "0x1871B4180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE13FE0", Offset = "0xE129E0", VA = "0x180E13FE0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B36630", Offset = "0x2B35030", VA = "0x182B36630")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B785B0", Offset = "0x2B76FB0", VA = "0x182B785B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B76FC0", VA = "0x182B785C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x28F7F00", Offset = "0x28F6900", VA = "0x1828F7F00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCAE0", Offset = "0x2FFB4E0", VA = "0x182FFCAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x125E4A0", Offset = "0x125CEA0", VA = "0x18125E4A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x125E4B0", Offset = "0x125CEB0", VA = "0x18125E4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71C0B10", Offset = "0x71BF510", VA = "0x1871C0B10")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71C0780", Offset = "0x71BF180", VA = "0x1871C0780", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71C08A0", Offset = "0x71BF2A0", VA = "0x1871C08A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71C0950", Offset = "0x71BF350", VA = "0x1871C0950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71C0A30", Offset = "0x71BF430", VA = "0x1871C0A30")]
		public static bool IDTAQAUODHM(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B36630", Offset = "0x2B35030", VA = "0x182B36630")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B785B0", Offset = "0x2B76FB0", VA = "0x182B785B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B76FC0", VA = "0x182B785C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD90410", Offset = "0xD8EE10", VA = "0x180D90410")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71C4520", Offset = "0x71C2F20", VA = "0x1871C4520")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x71C4330", Offset = "0x71C2D30", VA = "0x1871C4330", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71C4390", Offset = "0x71C2D90", VA = "0x1871C4390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71C4470", Offset = "0x71C2E70", VA = "0x1871C4470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x71C44C0", Offset = "0x71C2EC0", VA = "0x1871C44C0")]
		public static bool IDTAQAUODHM(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B36630", Offset = "0x2B35030", VA = "0x182B36630")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B785B0", Offset = "0x2B76FB0", VA = "0x182B785B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B76FC0", VA = "0x182B785C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28F7F00", Offset = "0x28F6900", VA = "0x1828F7F00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCAE0", Offset = "0x2FFB4E0", VA = "0x182FFCAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x71C48D0", Offset = "0x71C32D0", VA = "0x1871C48D0")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71C4540", Offset = "0x71C2F40", VA = "0x1871C4540", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x71C4620", Offset = "0x71C3020", VA = "0x1871C4620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x71C46E0", Offset = "0x71C30E0", VA = "0x1871C46E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x71C4790", Offset = "0x71C3190", VA = "0x1871C4790")]
		public static bool IDTAQAUODHM(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B36630", Offset = "0x2B35030", VA = "0x182B36630")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B785B0", Offset = "0x2B76FB0", VA = "0x182B785B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B76FC0", VA = "0x182B785C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x28F7F00", Offset = "0x28F6900", VA = "0x1828F7F00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCAE0", Offset = "0x2FFB4E0", VA = "0x182FFCAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x125E4A0", Offset = "0x125CEA0", VA = "0x18125E4A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x125E4B0", Offset = "0x125CEB0", VA = "0x18125E4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2D0", Offset = "0x28B8CD0", VA = "0x1828BA2D0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x71B3400", Offset = "0x71B1E00", VA = "0x1871B3400", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x71C4950", Offset = "0x71C3350", VA = "0x1871C4950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x71B3550", Offset = "0x71B1F50", VA = "0x1871B3550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class KDBVYCBULZG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x71B61F0", Offset = "0x71B4BF0", VA = "0x1871B61F0")]
		public static void MYFDMCHHSNH(this JObject a, string b, USWQQWDREUK c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TXLLBXGILNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x71C31D0", Offset = "0x71C1BD0", VA = "0x1871C31D0")]
		public static List<string> VHYBTXXGZCW(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x71C3380", Offset = "0x71C1D80", VA = "0x1871C3380")]
		public static List<double> WIANHWZKMBM(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x71C2920", Offset = "0x71C1320", VA = "0x1871C2920")]
		public static List<int> OELHGWYANEZ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A841E0", Offset = "0x3A82BE0", VA = "0x183A841E0")]
		public static List<a> QQJXUNEPPNJ<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x71C2530", Offset = "0x71C0F30", VA = "0x1871C2530")]
		public static USWQQWDREUK JTNSBVBXIUV(this JToken a, WTVTOFLEGQC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x71C3090", Offset = "0x71C1A90", VA = "0x1871C3090")]
		public static int UMPCPVOYRGL(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x71C1EA0", Offset = "0x71C08A0", VA = "0x1871C1EA0")]
		public static double EHERIWMHWLR(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x71C2250", Offset = "0x71C0C50", VA = "0x1871C2250")]
		public static GLTF.Math.Color JEHWMEWDSBK(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x71C1FE0", Offset = "0x71C09E0", VA = "0x1871C1FE0")]
		public static GLTF.Math.Color GGZKHMBHWSR(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x71C2DF0", Offset = "0x71C17F0", VA = "0x1871C2DF0")]
		public static GLTF.Math.Color RQBKSJLWFSF(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71C1BE0", Offset = "0x71C05E0", VA = "0x1871C1BE0")]
		public static GLTF.Math.Vector3 DTPDPEWUTVL(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x71C37A0", Offset = "0x71C21A0", VA = "0x1871C37A0")]
		public static GLTF.Math.Vector2 WNYQFCOUDFD(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x71C3540", Offset = "0x71C1F40", VA = "0x1871C3540")]
		public static GLTF.Math.Vector3 WNTJHVUWTTU(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x71C2AE0", Offset = "0x71C14E0", VA = "0x1871C2AE0")]
		public static GLTF.Math.Quaternion OYNBPYTJILN(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A83BD0", Offset = "0x3A825D0", VA = "0x183A83BD0")]
		public static Dictionary<string, b> EXTNJRHBEWX<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A83880", Offset = "0x3A82280", VA = "0x183A83880")]
		public static c EIWTSLUZMHV<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TJHKYMCWPRO bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x71B3E50", Offset = "0x71B2850", VA = "0x1871B3E50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x71B3DD0", Offset = "0x71B27D0", VA = "0x1871B3DD0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TUPREFBUZKT : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A20", Offset = "0x71C0420", VA = "0x1871C1A20")]
		public TUPREFBUZKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x71C1950", Offset = "0x71C0350", VA = "0x1871C1950", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, ANNHZWNIYUF> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x71B3C90", Offset = "0x71B2690", VA = "0x1871B3C90", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x71B3D50", Offset = "0x71B2750", VA = "0x1871B3D50")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class VNPXHIRUUXP : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x71B51F0", Offset = "0x71B3BF0", VA = "0x1871B51F0")]
			internal ANNHZWNIYUF WEJZBBRRCBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x71C42E0", Offset = "0x71C2CE0", VA = "0x1871C42E0")]
		public VNPXHIRUUXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x71C4150", Offset = "0x71C2B50", VA = "0x1871C4150", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NTSIBZNILIJ MTREVSOVOFE;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public EXT_texture_exr(NTSIBZNILIJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x71B3EA0", Offset = "0x71B28A0", VA = "0x1871B3EA0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x71B3F10", Offset = "0x71B2910", VA = "0x1871B3F10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TWIVDZXMBAA : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x71C1B90", Offset = "0x71C0590", VA = "0x1871C1B90")]
		public TWIVDZXMBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A70", Offset = "0x71C0470", VA = "0x1871C1A70", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
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
	public class AudioEmitterId : GNNRONQTKJO<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x71B25B0", Offset = "0x71B0FB0", VA = "0x1871B25B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x71B2570", Offset = "0x71B0F70", VA = "0x1871B2570")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : GNNRONQTKJO<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x71B2740", Offset = "0x71B1140", VA = "0x1871B2740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x71B2700", Offset = "0x71B1100", VA = "0x1871B2700")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : GNNRONQTKJO<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x71B2420", Offset = "0x71B0E20", VA = "0x1871B2420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x71B23E0", Offset = "0x71B0DE0", VA = "0x1871B23E0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x71B2300", Offset = "0x71B0D00", VA = "0x1871B2300")]
		public static AudioDataId Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x71B7C60", Offset = "0x71B6660", VA = "0x1871B7C60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x71B7860", Offset = "0x71B6260", VA = "0x1871B7860", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x71B78D0", Offset = "0x71B62D0", VA = "0x1871B78D0")]
		public static KHR_SceneAudioEmittersRef Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7EC0", Offset = "0x71B68C0", VA = "0x1871B7EC0")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x71B7830", Offset = "0x71B6230", VA = "0x1871B7830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x71B7710", Offset = "0x71B6110", VA = "0x1871B7710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x71B7500", Offset = "0x71B5F00", VA = "0x1871B7500", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x71B7570", Offset = "0x71B5F70", VA = "0x1871B7570")]
		public static KHR_NodeAudioEmitterRef Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AJVHPMLPDBX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string GLZOIILYFLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? ZOQNGDLAHZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? DSVZARHOFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? WVCKJJOYRCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? PWRIMJMWLUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? DFLVKCRFRHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? SLEJQGMSZVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? FYVIHPTIDVM;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71B2090", Offset = "0x71B0A90", VA = "0x1871B2090")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x71B1990", Offset = "0x71B0390", VA = "0x1871B1990")]
		public static AJVHPMLPDBX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AJVHPMLPDBX()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : HFPGWNSLYPC
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
		public AJVHPMLPDBX positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x71B6B50", Offset = "0x71B5550", VA = "0x1871B6B50", Slot = "5")]
		public virtual JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x71B6650", Offset = "0x71B5050", VA = "0x1871B6650")]
		public static KHR_AudioEmitter Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x71B6EF0", Offset = "0x71B58F0", VA = "0x1871B6EF0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : HFPGWNSLYPC
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
		[Cpp2IlInjected.Address(RVA = "0x71B72D0", Offset = "0x71B5CD0", VA = "0x1871B72D0")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x71B6F70", Offset = "0x71B5970", VA = "0x1871B6F70")]
		public static KHR_AudioSource Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x71B6640", Offset = "0x71B5040", VA = "0x1871B6640")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JDSZTARAOKN bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6510", Offset = "0x71B4F10", VA = "0x1871B6510")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x71B62B0", Offset = "0x71B4CB0", VA = "0x1871B62B0")]
		public static KHR_AudioData Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x71B6640", Offset = "0x71B5040", VA = "0x1871B6640")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : RCVNBXYDJZR
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
		[Cpp2IlInjected.Address(RVA = "0x71B8180", Offset = "0x71B6B80", VA = "0x1871B8180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x71B80F0", Offset = "0x71B6AF0", VA = "0x1871B80F0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x71B88B0", Offset = "0x71B72B0", VA = "0x1871B88B0")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class LOKWANARRJC : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x71BC680", Offset = "0x71BB080", VA = "0x1871BC680")]
		public LOKWANARRJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x71BBAB0", Offset = "0x71BA4B0", VA = "0x1871BBAB0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JDSZTARAOKN bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x71B8A80", Offset = "0x71B7480", VA = "0x1871B8A80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x71B89C0", Offset = "0x71B73C0", VA = "0x1871B89C0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x71B8AD0", Offset = "0x71B74D0", VA = "0x1871B8AD0")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class OZISQSKMTBU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x71B52A0", Offset = "0x71B3CA0", VA = "0x1871B52A0")]
			internal int WEJZBBRRCBI()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x71BD930", Offset = "0x71BC330", VA = "0x1871BD930")]
		public OZISQSKMTBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x71BD720", Offset = "0x71BC120", VA = "0x1871BD720", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public USWQQWDREUK anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x71B8BD0", Offset = "0x71B75D0", VA = "0x1871B8BD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x71B8B50", Offset = "0x71B7550", VA = "0x1871B8B50", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SNPPSAWRKCV : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x71C10A0", Offset = "0x71BFAA0", VA = "0x1871C10A0")]
		public SNPPSAWRKCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x71C0EF0", Offset = "0x71BF8F0", VA = "0x1871C0EF0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public USWQQWDREUK clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public USWQQWDREUK clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public USWQQWDREUK clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x71B8E80", Offset = "0x71B7880", VA = "0x1871B8E80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x71B8DE0", Offset = "0x71B77E0", VA = "0x1871B8DE0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class THHNTBJJTAT : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x71C1900", Offset = "0x71C0300", VA = "0x1871C1900")]
		public THHNTBJJTAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x71C1680", Offset = "0x71C0080", VA = "0x1871C1680", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x71B91E0", Offset = "0x71B7BE0", VA = "0x1871B91E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x71B9170", Offset = "0x71B7B70", VA = "0x1871B9170", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class QPYJDVIWDOL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x71C0730", Offset = "0x71BF130", VA = "0x1871C0730")]
		public QPYJDVIWDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x71C0660", Offset = "0x71BF060", VA = "0x1871C0660", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : CKARNJIAQHV, RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float WITYPIMDKWN;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x71B94C0", Offset = "0x71B7EC0", VA = "0x1871B94C0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x71B9510", Offset = "0x71B7F10", VA = "0x1871B9510")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, WTVTOFLEGQC root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x71B9300", Offset = "0x71B7D00", VA = "0x1871B9300", Slot = "6")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x71B93A0", Offset = "0x71B7DA0", VA = "0x1871B93A0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class UPAUZLJOJUM : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x71C3B20", Offset = "0x71C2520", VA = "0x1871C3B20")]
		public UPAUZLJOJUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x71C3A20", Offset = "0x71C2420", VA = "0x1871C3A20", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x71B95E0", Offset = "0x71B7FE0", VA = "0x1871B95E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x71B9580", Offset = "0x71B7F80", VA = "0x1871B9580", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x71B9730", Offset = "0x71B8130", VA = "0x1871B9730")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ECBBXILVOXJ : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x71B3990", Offset = "0x71B2390", VA = "0x1871B3990")]
		public ECBBXILVOXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71B38C0", Offset = "0x71B22C0", VA = "0x1871B38C0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public USWQQWDREUK iridescenceTexture;

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
		public USWQQWDREUK iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x71B97E0", Offset = "0x71B81E0", VA = "0x1871B97E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x71B9740", Offset = "0x71B8140", VA = "0x1871B9740", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x71B9BA0", Offset = "0x71B85A0", VA = "0x1871B9BA0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AJEWTXETRTL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x71B1940", Offset = "0x71B0340", VA = "0x1871B1940")]
		public AJEWTXETRTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x71B1650", Offset = "0x71B0050", VA = "0x1871B1650", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class MSHAEGPIMOE : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 IOFGZVPUYPS;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double EVZHLQVQDUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color KJQSFYKRQCA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color WJQTIHDOCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public USWQQWDREUK ECQUMYOIXSS;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly USWQQWDREUK XJRYAZZCSOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 EJSMMTJHVDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double OEMJNEUXFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public USWQQWDREUK SKXSQTIMKJV;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly USWQQWDREUK MUJCTONVVLZ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x71BD160", Offset = "0x71BBB60", VA = "0x1871BD160")]
		public MSHAEGPIMOE(GLTF.Math.Color a, USWQQWDREUK b, GLTF.Math.Vector3 c, double d, USWQQWDREUK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x71BC860", Offset = "0x71BB260", VA = "0x1871BC860", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x71BCA10", Offset = "0x71BB410", VA = "0x1871BCA10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class ONQUVHQSFCG : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x71BD6D0", Offset = "0x71BC0D0", VA = "0x1871BD6D0")]
		public ONQUVHQSFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x71BD380", Offset = "0x71BBD80", VA = "0x1871BD380", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public USWQQWDREUK sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public USWQQWDREUK sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x71B9C90", Offset = "0x71B8690", VA = "0x1871B9C90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x71B9BC0", Offset = "0x71B85C0", VA = "0x1871B9BC0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x71BA1A0", Offset = "0x71B8BA0", VA = "0x1871BA1A0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class EGSVCUHVEDK : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x71B3C40", Offset = "0x71B2640", VA = "0x1871B3C40")]
		public EGSVCUHVEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x71B39E0", Offset = "0x71B23E0", VA = "0x1871B39E0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public USWQQWDREUK specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public USWQQWDREUK specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x71BA2D0", Offset = "0x71B8CD0", VA = "0x1871BA2D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x71BA200", Offset = "0x71B8C00", VA = "0x1871BA200", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x71BA7E0", Offset = "0x71B91E0", VA = "0x1871BA7E0")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class PMXNSVTVIWU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x71BDBF0", Offset = "0x71BC5F0", VA = "0x1871BDBF0")]
		public PMXNSVTVIWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x71BD980", Offset = "0x71BC380", VA = "0x1871BD980", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public USWQQWDREUK transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x71BA8D0", Offset = "0x71B92D0", VA = "0x1871BA8D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x71BA850", Offset = "0x71B9250", VA = "0x1871BA850", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class MPUUZMDPCNL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x71BC810", Offset = "0x71BB210", VA = "0x1871BC810")]
		public MPUUZMDPCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x71BC6D0", Offset = "0x71BB0D0", VA = "0x1871BC6D0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class UWKEYAGVSUC : CKARNJIAQHV, RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x71C4090", Offset = "0x71C2A90", VA = "0x1871C4090")]
		public UWKEYAGVSUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x71C40E0", Offset = "0x71C2AE0", VA = "0x1871C40E0")]
		public UWKEYAGVSUC(UWKEYAGVSUC a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x71C3E90", Offset = "0x71C2890", VA = "0x1871C3E90", Slot = "6")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x71C3F30", Offset = "0x71C2930", VA = "0x1871C3F30", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x71C3FC0", Offset = "0x71C29C0", VA = "0x1871C3FC0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RUPUYIWTKJS : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x71C0D50", Offset = "0x71BF750", VA = "0x1871C0D50")]
		public RUPUYIWTKJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x71C0CD0", Offset = "0x71BF6D0", VA = "0x1871C0CD0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public USWQQWDREUK thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x71BAAF0", Offset = "0x71B94F0", VA = "0x1871BAAF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x71BAA60", Offset = "0x71B9460", VA = "0x1871BAA60", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x71BB010", Offset = "0x71B9A10", VA = "0x1871BB010")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ILDQYGARYCL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x71B58C0", Offset = "0x71B42C0", VA = "0x1871B58C0")]
		public ILDQYGARYCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x71B56B0", Offset = "0x71B40B0", VA = "0x1871B56B0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x71BB090", Offset = "0x71B9A90", VA = "0x1871BB090", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x71BB030", Offset = "0x71B9A30", VA = "0x1871BB030", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF54E60", Offset = "0xF53860", VA = "0x180F54E60")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class IMRKWMEIWWN : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x71B59F0", Offset = "0x71B43F0", VA = "0x1871B59F0")]
		public IMRKWMEIWWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x71B5910", Offset = "0x71B4310", VA = "0x1871B5910", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x71BB200", Offset = "0x71B9C00", VA = "0x1871BB200", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x71BB1A0", Offset = "0x71B9BA0", VA = "0x1871BB1A0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF54E60", Offset = "0xF53860", VA = "0x180F54E60")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class OMHKMSWSAGH : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x71BD330", Offset = "0x71BBD30", VA = "0x1871BD330")]
		public OMHKMSWSAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x71BD250", Offset = "0x71BBC50", VA = "0x1871BD250", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x71BB370", Offset = "0x71B9D70", VA = "0x1871BB370", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x71BB310", Offset = "0x71B9D10", VA = "0x1871BB310", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF54E60", Offset = "0xF53860", VA = "0x180F54E60")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RHLVMJMCHZP : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x71C0C80", Offset = "0x71BF680", VA = "0x1871C0C80")]
		public RHLVMJMCHZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x71C0BA0", Offset = "0x71BF5A0", VA = "0x1871C0BA0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NTSIBZNILIJ source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public KHR_texture_basisu(NTSIBZNILIJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x71BB480", Offset = "0x71B9E80", VA = "0x1871BB480", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x71BB4F0", Offset = "0x71B9EF0", VA = "0x1871BB4F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class HEXBUIIZRET : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x71B5470", Offset = "0x71B3E70", VA = "0x1871B5470")]
		public HEXBUIIZRET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x71B5310", Offset = "0x71B3D10", VA = "0x1871B5310", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class JDONLAFOJHG : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 VBOLXXOSKHS;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 GJMMAMZEVSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double UWXJAJSPRJH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double UJMEYWIBWUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 BDFPJJLKDEX;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 HAIKHHUVGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int ATZPHHEDTRB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x71B6170", Offset = "0x71B4B70", VA = "0x1871B6170")]
		public JDONLAFOJHG(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x71B5A40", Offset = "0x71B4440", VA = "0x1871B5A40", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x71B5B20", Offset = "0x71B4520", VA = "0x1871B5B20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class UTSOIUVDZFA : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x71C3E40", Offset = "0x71C2840", VA = "0x1871C3E40")]
		public UTSOIUVDZFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x71C3B70", Offset = "0x71C2570", VA = "0x1871C3B70", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class IDZXXQPYFYK : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> FRMRNGNXGRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public IDZXXQPYFYK(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x71B54C0", Offset = "0x71B3EC0", VA = "0x1871B54C0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x71B5530", Offset = "0x71B3F30", VA = "0x1871B5530", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x71B5620", Offset = "0x71B4020", VA = "0x1871B5620")]
		public List<double> ZJSOKTZTXEO(BERLEXGGYBZ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class SEFFXSILBQE : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x71C0EA0", Offset = "0x71BF8A0", VA = "0x1871C0EA0")]
		public SEFFXSILBQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x71C0DA0", Offset = "0x71BF7A0", VA = "0x1871C0DA0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class XWLGDPDBHBS : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType WZXSMDVDZGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool YKWJQUPRVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint QYQDPJWWJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType BFJYMHQJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> NXPNZDBXDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> LZVZJZPGZWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public DAPTVCNOKYI SWBXMRZGRPF;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x71B6640", Offset = "0x71B5040", VA = "0x1871B6640")]
		public XWLGDPDBHBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x71C8A80", Offset = "0x71C7480", VA = "0x1871C8A80")]
		public static XWLGDPDBHBS Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x71C9510", Offset = "0x71C7F10", VA = "0x1871C9510", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x71C91E0", Offset = "0x71C7BE0", VA = "0x1871C91E0")]
		private unsafe static sbyte IQIURRBPYCN(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x71C94B0", Offset = "0x71C7EB0", VA = "0x1871C94B0")]
		private unsafe static float2 JQMZPDMSDIF(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x71CBCB0", Offset = "0x71CA6B0", VA = "0x1871CBCB0")]
		private unsafe static float3 TIIPEDKGBJG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x71CCA50", Offset = "0x71CB450", VA = "0x1871CCA50")]
		private unsafe static float4 YWGKJYIEDNN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x71C8610", Offset = "0x71C7010", VA = "0x1871C8610")]
		private unsafe static float4x4 APTXBMQYRTV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x71C91E0", Offset = "0x71C7BE0", VA = "0x1871C91E0")]
		private unsafe static byte GCTKJTRAWZI(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x71C91F0", Offset = "0x71C7BF0", VA = "0x1871C91F0")]
		private unsafe static float2 IAQAPUAREHK(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x71CCCA0", Offset = "0x71CB6A0", VA = "0x1871CCCA0")]
		private unsafe static float3 ZIWECHIZJUB(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x71C89D0", Offset = "0x71C73D0", VA = "0x1871C89D0")]
		private unsafe static float4 BVWZSMVYYBQ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x71CCAB0", Offset = "0x71CB4B0", VA = "0x1871CCAB0")]
		private unsafe static float4x4 ZDMLOSZYXHE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x71C8370", Offset = "0x71C6D70", VA = "0x1871C8370")]
		private unsafe static short BUYFXHNVXHF(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x71C89A0", Offset = "0x71C73A0", VA = "0x1871C89A0")]
		private unsafe static float2 BTBPXYNOEUX(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x71C8A30", Offset = "0x71C7430", VA = "0x1871C8A30")]
		private unsafe static float3 DUIGITXPHMG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x71C9AF0", Offset = "0x71C84F0", VA = "0x1871C9AF0")]
		private unsafe static float4 JYVBTMSGPGV(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x71CBF60", Offset = "0x71CA960", VA = "0x1871CBF60")]
		private unsafe static float4x4 UALLLNTMXUV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x71C8370", Offset = "0x71C6D70", VA = "0x1871C8370")]
		private unsafe static ushort DTAZHZYENBE(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x71C9EA0", Offset = "0x71C88A0", VA = "0x1871C9EA0")]
		private unsafe static float2 KVBWFOGBGDS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x71C8950", Offset = "0x71C7350", VA = "0x1871C8950")]
		private unsafe static float3 BSYAICJSYMF(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x71C87B0", Offset = "0x71C71B0", VA = "0x1871C87B0")]
		private unsafe static float4x4 BNHJOKIRCGS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x71CBD10", Offset = "0x71CA710", VA = "0x1871CBD10")]
		private unsafe static float4 TPXKPZPKKHE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x71CBD00", Offset = "0x71CA700", VA = "0x1871CBD00")]
		private unsafe static uint TODAGZABUCP(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x71C8370", Offset = "0x71C6D70", VA = "0x1871C8370")]
		private unsafe static ushort AGIBUIIVUSW(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x71C9B50", Offset = "0x71C8550", VA = "0x1871C9B50")]
		private unsafe static float KKTUDXFXPDN(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x71CA250", Offset = "0x71C8C50", VA = "0x1871CA250")]
		private unsafe static float2 MFMXLBWMZIL(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x71C8380", Offset = "0x71C6D80", VA = "0x1871C8380")]
		private unsafe static float3 AIRUOSUARWS(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x71C94E0", Offset = "0x71C7EE0", VA = "0x1871C94E0")]
		private unsafe static float4 JVLUASVCKBL(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x71CBF30", Offset = "0x71CA930", VA = "0x1871CBF30")]
		private unsafe static float4x4 TTIJIVCMCOF(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x71C94E0", Offset = "0x71C7EE0", VA = "0x1871C94E0")]
		private unsafe static float4 SVUFTEODTYE(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x71CBB10", Offset = "0x71CA510", VA = "0x1871CBB10")]
		private unsafe static float4 SVUFTEODTYE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x71C8FB0", Offset = "0x71C79B0", VA = "0x1871C8FB0")]
		public static float3[] FLJZWVOWOBP(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x71CB000", Offset = "0x71C9A00", VA = "0x1871CB000")]
		public static float3[] OLSUOTHGVDP(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71CA500", Offset = "0x71C8F00", VA = "0x1871CA500")]
		public static uint[] NFDKITXRICE(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x71C9390", Offset = "0x71C7D90", VA = "0x1871C9390")]
		internal static void IOPFSHQTTEJ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71CC6F0", Offset = "0x71CB0F0", VA = "0x1871CC6F0")]
		public uint[] XDMFQJCYDTS(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x71C83A0", Offset = "0x71C6DA0", VA = "0x1871C83A0")]
		public float[] ANEESZDDRKQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x71CA270", Offset = "0x71C8C70", VA = "0x1871CA270")]
		public float2[] MYMQRRUBDSI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x71CA670", Offset = "0x71C9070", VA = "0x1871CA670")]
		public float2[] NMKKLMEKCGK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x71CC470", Offset = "0x71CAE70", VA = "0x1871CC470")]
		public float3[] VOHJOSFLSSB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x71CB310", Offset = "0x71C9D10", VA = "0x1871CB310")]
		public float3[] PIMPSXHZFNH(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x71C9FE0", Offset = "0x71C89E0", VA = "0x1871C9FE0")]
		public float4[] LTDOYXIZFAS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x71CC100", Offset = "0x71CAB00", VA = "0x1871CC100")]
		public float4[] VJZIJAISJAK(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x71CB660", Offset = "0x71CA060", VA = "0x1871CB660")]
		public float4[] RPOECOPDKGL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x71CC940", Offset = "0x71CB340", VA = "0x1871CC940")]
		public float3[] YSGMQYYSQFY(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x71C9ED0", Offset = "0x71C88D0", VA = "0x1871C9ED0")]
		public float3[] LQVSESNGYBL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x71C8EE0", Offset = "0x71C78E0", VA = "0x1871C8EE0")]
		public float4[] ESYOCFARXPP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x71CCC50", Offset = "0x71CB650", VA = "0x1871CCC50")]
		public uint[] ZDNKUZZGJOA(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x71CAA50", Offset = "0x71C9450", VA = "0x1871CAA50")]
		public float4x4[] NQWRRBVEHWP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x71C9CE0", Offset = "0x71C86E0", VA = "0x1871C9CE0")]
		private unsafe static float4 KONWXRNTXVB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x71C9B60", Offset = "0x71C8560", VA = "0x1871C9B60")]
		private unsafe static float4 KONWXRNTXVB(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x71CBB40", Offset = "0x71CA540", VA = "0x1871CBB40")]
		private unsafe static float4x4 TEEGRSMIJGQ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x71CBD70", Offset = "0x71CA770", VA = "0x1871CBD70")]
		private unsafe static float4 TTHMFFTHPTS(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x71C9220", Offset = "0x71C7C20", VA = "0x1871C9220")]
		private unsafe static float3 IGWZHPRADMX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x71CA920", Offset = "0x71C9320", VA = "0x1871CA920")]
		private unsafe static float2 NPWTEYKDRBY(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x71CB9F0", Offset = "0x71CA3F0", VA = "0x1871CB9F0")]
		private unsafe static uint SVSHAMYCJAT(void* a, uint b, GLTFComponentType c)
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
	public static class UULKYIFPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x71DB390", Offset = "0x71D9D90", VA = "0x1871DB390")]
		public static int QTRWYHKYLIR(this GLTFAccessorAttributeType a)
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
	public class DAPTVCNOKYI : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int QYQDPJWWJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GJMJQNTARVX KQGGERXYISM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public RGKKFTNVFHE IFFINMZNWHT;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x71D2360", Offset = "0x71D0D60", VA = "0x1871D2360")]
		public DAPTVCNOKYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x71D1F60", Offset = "0x71D0960", VA = "0x1871D1F60")]
		public static DAPTVCNOKYI Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x71D2230", Offset = "0x71D0C30", VA = "0x1871D2230", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class GJMJQNTARVX : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType WZXSMDVDZGG;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x71D3BD0", Offset = "0x71D25D0", VA = "0x1871D3BD0")]
		public GJMJQNTARVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x71D37B0", Offset = "0x71D21B0", VA = "0x1871D37B0")]
		public static GJMJQNTARVX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x71D3A90", Offset = "0x71D2490", VA = "0x1871D3A90", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RGKKFTNVFHE : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int FXFSJMAWPWG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x71D9060", Offset = "0x71D7A60", VA = "0x1871D9060")]
		public RGKKFTNVFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x71D8CE0", Offset = "0x71D76E0", VA = "0x1871D8CE0")]
		public static RGKKFTNVFHE Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x71D8F60", Offset = "0x71D7960", VA = "0x1871D8F60", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class CPFJIWONMQK : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public DXCFNBUOULO LTVNKOBTVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HQYCXRYQMTF FMLWCFPZQDQ;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x71D1640", Offset = "0x71D0040", VA = "0x1871D1640")]
		public CPFJIWONMQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x71D1350", Offset = "0x71CFD50", VA = "0x1871D1350")]
		public static CPFJIWONMQK Deserialize(WTVTOFLEGQC root, JsonReader reader, ZCPNPFGNFZG anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x71D1540", Offset = "0x71CFF40", VA = "0x1871D1540", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class HQYCXRYQMTF : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public YQPLXVVAQMG BERLEXGGYBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string MVXIJBZHFMA;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x71D4C90", Offset = "0x71D3690", VA = "0x1871D4C90")]
		public static HQYCXRYQMTF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x71D5010", Offset = "0x71D3A10", VA = "0x1871D5010")]
		public HQYCXRYQMTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x71D4EF0", Offset = "0x71D38F0", VA = "0x1871D4EF0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class WCSOTBUVZFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(WCSOTBUVZFK data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] KLGNLILHXHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type HAGNYPPDNHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] ZEEBWSKVCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion REHWCCOBGTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string XOEIZQBEYKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string SQMBZWDGOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KGQVNKKAGMO RGFWIVHUIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string UIOMTOHHCYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string SNPGAOYLCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public KGQVNKKAGMO UOACOKTJWPJ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x71DB400", Offset = "0x71D9E00", VA = "0x1871DB400")]
		public WCSOTBUVZFK()
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
	public class YFTAWGGGKEJ : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ANNHZWNIYUF UHXHDUMBWIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType NJBYTDFXEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ANNHZWNIYUF ZYBPMWZTKGC;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x71E1410", Offset = "0x71DFE10", VA = "0x1871E1410")]
		public YFTAWGGGKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x71E1080", Offset = "0x71DFA80", VA = "0x1871E1080")]
		public static YFTAWGGGKEJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x71E12A0", Offset = "0x71DFCA0", VA = "0x1871E12A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class JPKUYULHDWV : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string GDOCZGMZOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string HRMIJOUGJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string VJOLSNEECRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string ZAJBTWXWCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> POBHOAOSRYT;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x71D63B0", Offset = "0x71D4DB0", VA = "0x1871D63B0")]
		public JPKUYULHDWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x71D58C0", Offset = "0x71D42C0", VA = "0x1871D58C0")]
		public static JPKUYULHDWV Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x71D5F80", Offset = "0x71D4980", VA = "0x1871D5F80", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x71D63A0", Offset = "0x71D4DA0", VA = "0x1871D63A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x71D5BE0", Offset = "0x71D45E0", VA = "0x1871D5BE0")]
		public string HMFSIWGYSAH(bool a)
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
	public class TJHKYMCWPRO : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CPXGVJRXHMQ VDPSBGBFOKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint CQXJGQSHELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint NRLMPURQNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget FMLWCFPZQDQ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public TJHKYMCWPRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x71DA4D0", Offset = "0x71D8ED0", VA = "0x1871DA4D0")]
		public static TJHKYMCWPRO Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x71DA780", Offset = "0x71D9180", VA = "0x1871DA780", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class AVQGGELEYFQ : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double RZCQKGGXOQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double SVCQCWTZGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double INEWDPWMMYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double INLOYGXHPZP;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x71CD3C0", Offset = "0x71CBDC0", VA = "0x1871CD3C0")]
		public AVQGGELEYFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x71CCED0", Offset = "0x71CB8D0", VA = "0x1871CCED0")]
		public static AVQGGELEYFQ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x71CD250", Offset = "0x71CBC50", VA = "0x1871CD250", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class IADQMNXRALY : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double GPKSPYDRSFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double YRZQVKVZZFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double INEWDPWMMYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double INLOYGXHPZP;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x71D5560", Offset = "0x71D3F60", VA = "0x1871D5560")]
		public IADQMNXRALY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x71D5060", Offset = "0x71D3A60", VA = "0x1871D5060")]
		public static IADQMNXRALY Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x71D53D0", Offset = "0x71D3DD0", VA = "0x1871D53D0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZCPNPFGNFZG : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public ZCPNPFGNFZG OXCQLHQOXJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<CPFJIWONMQK> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<YFTAWGGGKEJ> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x71D3E60", Offset = "0x71D2860", VA = "0x1871D3E60")]
			internal CPFJIWONMQK WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x71D3E80", Offset = "0x71D2880", VA = "0x1871D3E80")]
			internal YFTAWGGGKEJ WEPFYILOLMR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<CPFJIWONMQK> HVHPBAHNQDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<YFTAWGGGKEJ> EKXUXTNWQZM;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x71E22E0", Offset = "0x71E0CE0", VA = "0x1871E22E0")]
		public static ZCPNPFGNFZG Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x71E2A40", Offset = "0x71E1440", VA = "0x1871E2A40")]
		public ZCPNPFGNFZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x71E26A0", Offset = "0x71E10A0", VA = "0x1871E26A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BBDSDFOIDBC : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string UEFVNAGPVOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint CQXJGQSHELD;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public BBDSDFOIDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x71CD410", Offset = "0x71CBE10", VA = "0x1871CD410")]
		public static BBDSDFOIDBC Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x71CD5E0", Offset = "0x71CBFE0", VA = "0x1871CD5E0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class PJNTLMSRGVL : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AVQGGELEYFQ PYVOOMWGZXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public IADQMNXRALY EBLOBFLPJVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType BFJYMHQJKIL;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public PJNTLMSRGVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x71D8560", Offset = "0x71D6F60", VA = "0x1871D8560")]
		public static PJNTLMSRGVL Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x71D8730", Offset = "0x71D7130", VA = "0x1871D8730", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class HFPGWNSLYPC : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string NRBYPZADYJW;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public HFPGWNSLYPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x71D4010", Offset = "0x71D2A10", VA = "0x1871D4010")]
		public HFPGWNSLYPC(HFPGWNSLYPC a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x71D3E90", Offset = "0x71D2890", VA = "0x1871D3E90")]
		public new void DZIBRYOGCXI(WTVTOFLEGQC a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x71D3F80", Offset = "0x71D2980", VA = "0x1871D3F80", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class GNNRONQTKJO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int CXQIBDZHUDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public WTVTOFLEGQC XQVYPEOBNLV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected GNNRONQTKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EFA0", Offset = "0x4E3D9A0", VA = "0x184E3EFA0")]
		public GNNRONQTKJO(GNNRONQTKJO<a> a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EF70", Offset = "0x4E3D970", VA = "0x184E3EF70")]
		public void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ANNHZWNIYUF : GNNRONQTKJO<XWLGDPDBHBS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override XWLGDPDBHBS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x71CCE70", Offset = "0x71CB870", VA = "0x1871CCE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x71CCDD0", Offset = "0x71CB7D0", VA = "0x1871CCDD0")]
		public ANNHZWNIYUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x71CCE10", Offset = "0x71CB810", VA = "0x1871CCE10")]
		public ANNHZWNIYUF(ANNHZWNIYUF a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x71CCCF0", Offset = "0x71CB6F0", VA = "0x1871CCCF0")]
		public static ANNHZWNIYUF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class CPXGVJRXHMQ : GNNRONQTKJO<BBDSDFOIDBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override BBDSDFOIDBC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x71D17B0", Offset = "0x71D01B0", VA = "0x1871D17B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x71D1770", Offset = "0x71D0170", VA = "0x1871D1770")]
		public CPXGVJRXHMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x71D1690", Offset = "0x71D0090", VA = "0x1871D1690")]
		public static CPXGVJRXHMQ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JDSZTARAOKN : GNNRONQTKJO<TJHKYMCWPRO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override TJHKYMCWPRO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x71D5860", Offset = "0x71D4260", VA = "0x1871D5860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x71D5820", Offset = "0x71D4220", VA = "0x1871D5820")]
		public JDSZTARAOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x71D5740", Offset = "0x71D4140", VA = "0x1871D5740")]
		public static JDSZTARAOKN Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CAHKCJZXWON : GNNRONQTKJO<PJNTLMSRGVL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override PJNTLMSRGVL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x71CF420", Offset = "0x71CDE20", VA = "0x1871CF420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x71CF3E0", Offset = "0x71CDDE0", VA = "0x1871CF3E0")]
		public CAHKCJZXWON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x71CF300", Offset = "0x71CDD00", VA = "0x1871CF300")]
		public static CAHKCJZXWON Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NTSIBZNILIJ : GNNRONQTKJO<NNQENYBDRHR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NNQENYBDRHR Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x71D7870", Offset = "0x71D6270", VA = "0x1871D7870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x71D7830", Offset = "0x71D6230", VA = "0x1871D7830")]
		public NTSIBZNILIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x71D7750", Offset = "0x71D6150", VA = "0x1871D7750")]
		public static NTSIBZNILIJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class HOWNCWMIGVN : GNNRONQTKJO<OFRYBPDMWCH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override OFRYBPDMWCH Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x71D4B80", Offset = "0x71D3580", VA = "0x1871D4B80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x71D4B40", Offset = "0x71D3540", VA = "0x1871D4B40")]
		public HOWNCWMIGVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x71D4AE0", Offset = "0x71D34E0", VA = "0x1871D4AE0")]
		public HOWNCWMIGVN(HOWNCWMIGVN a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x71D4A00", Offset = "0x71D3400", VA = "0x1871D4A00")]
		public static HOWNCWMIGVN Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class JDSRIUAAMBB : GNNRONQTKJO<HMCQBNAUHVJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override HMCQBNAUHVJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x71D56E0", Offset = "0x71D40E0", VA = "0x1871D56E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x71D56A0", Offset = "0x71D40A0", VA = "0x1871D56A0")]
		public JDSRIUAAMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x71D55C0", Offset = "0x71D3FC0", VA = "0x1871D55C0")]
		public static JDSRIUAAMBB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YQPLXVVAQMG : GNNRONQTKJO<BERLEXGGYBZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BERLEXGGYBZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x71E17F0", Offset = "0x71E01F0", VA = "0x1871E17F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x71E17B0", Offset = "0x71E01B0", VA = "0x1871E17B0")]
		public YQPLXVVAQMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x71E1460", Offset = "0x71DFE60", VA = "0x1871E1460")]
		public static YQPLXVVAQMG Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x71E1540", Offset = "0x71DFF40", VA = "0x1871E1540")]
		public static List<YQPLXVVAQMG> QQJXUNEPPNJ(WTVTOFLEGQC a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CLUJQPIEVOU : GNNRONQTKJO<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x71D12F0", Offset = "0x71CFCF0", VA = "0x1871D12F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x71D12B0", Offset = "0x71CFCB0", VA = "0x1871D12B0")]
		public CLUJQPIEVOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x71D11D0", Offset = "0x71CFBD0", VA = "0x1871D11D0")]
		public static CLUJQPIEVOU Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class DXCFNBUOULO : GNNRONQTKJO<YFTAWGGGKEJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ZCPNPFGNFZG ZCPNPFGNFZG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override YFTAWGGGKEJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x71D2A80", Offset = "0x71D1480", VA = "0x1871D2A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x71D2A40", Offset = "0x71D1440", VA = "0x1871D2A40")]
		public DXCFNBUOULO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x71D2940", Offset = "0x71D1340", VA = "0x1871D2940")]
		public static DXCFNBUOULO Deserialize(WTVTOFLEGQC root, ZCPNPFGNFZG anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class DAWXZYRRAUE : GNNRONQTKJO<FHGUWOJFITY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FHGUWOJFITY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x71D24D0", Offset = "0x71D0ED0", VA = "0x1871D24D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x71D2490", Offset = "0x71D0E90", VA = "0x1871D2490")]
		public DAWXZYRRAUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x71D23B0", Offset = "0x71D0DB0", VA = "0x1871D23B0")]
		public static DAWXZYRRAUE Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZBLVNRGSJCX : GNNRONQTKJO<XLGFUPUXDAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override XLGFUPUXDAO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x71E2280", Offset = "0x71E0C80", VA = "0x1871E2280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x71E2240", Offset = "0x71E0C40", VA = "0x1871E2240")]
		public ZBLVNRGSJCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x71E2160", Offset = "0x71E0B60", VA = "0x1871E2160")]
		public static ZBLVNRGSJCX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class CUEDZTDBNVB : GNNRONQTKJO<RAWOIEBXRSB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override RAWOIEBXRSB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x71D1F00", Offset = "0x71D0900", VA = "0x1871D1F00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x71D1E60", Offset = "0x71D0860", VA = "0x1871D1E60")]
		public CUEDZTDBNVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x71D1EA0", Offset = "0x71D08A0", VA = "0x1871D1EA0")]
		public CUEDZTDBNVB(CUEDZTDBNVB a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x71D1D80", Offset = "0x71D0780", VA = "0x1871D1D80")]
		public static CUEDZTDBNVB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RAICXMWOJTG : GNNRONQTKJO<WGTBIMSOTQG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override WGTBIMSOTQG Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x71D8940", Offset = "0x71D7340", VA = "0x1871D8940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x71D8900", Offset = "0x71D7300", VA = "0x1871D8900")]
		public RAICXMWOJTG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class NNQENYBDRHR : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string UEFVNAGPVOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string JVVMBRIXGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public NNQENYBDRHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x71D7340", Offset = "0x71D5D40", VA = "0x1871D7340")]
		public static NNQENYBDRHR Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x71D7580", Offset = "0x71D5F80", VA = "0x1871D7580", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class OFRYBPDMWCH : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public FWINARFTNES FWINARFTNES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public CTRATNJFWMP SSHIYFOBPUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KPEFKKJMQLF FAMLFUDUFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public DKWTFROCKWH KWWDJKXRBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public USWQQWDREUK AXDZLCKHOVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color LRYBHNQNDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode GGJTCONIJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double OTKURKCCJZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool GKXCEMDFEYT;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x71D82B0", Offset = "0x71D6CB0", VA = "0x1871D82B0")]
		public OFRYBPDMWCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x71D7940", Offset = "0x71D6340", VA = "0x1871D7940")]
		public static OFRYBPDMWCH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x71D7E50", Offset = "0x71D6850", VA = "0x1871D7E50", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class HMCQBNAUHVJ : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class KITBCUMOFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<XABKJXLEVAH> VRMPKGMRFAW;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x71D67A0", Offset = "0x71D51A0", VA = "0x1871D67A0")]
			internal XABKJXLEVAH WEJZBBRRCBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<XABKJXLEVAH> LJNPRVWIJSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> LWNBWRIRQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> OLIOLAMDZFU;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public HMCQBNAUHVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x71D4090", Offset = "0x71D2A90", VA = "0x1871D4090")]
		public static HMCQBNAUHVJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x71D4450", Offset = "0x71D2E50", VA = "0x1871D4450", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, VSCXGXQDKGW> YNXNCQZEWQS;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static NWFRFHMVRQF TEMAKWMPXFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, RCVNBXYDJZR> SMHHCVOUHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken FKQVHRIUKWQ;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x71CF570", Offset = "0x71CDF70", VA = "0x1871CF570")]
		public static VSCXGXQDKGW CEQDQMUMZQJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71CFDF0", Offset = "0x71CE7F0", VA = "0x1871CFDF0")]
		public static RCVNBXYDJZR THQAOWFVIAF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CKARNJIAQHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x71D0EE0", Offset = "0x71CF8E0", VA = "0x1871D0EE0")]
		public CKARNJIAQHV(CKARNJIAQHV a, [Optional] WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x71CF700", Offset = "0x71CE100", VA = "0x1871CF700")]
		public void DZIBRYOGCXI(WTVTOFLEGQC a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x71CFEE0", Offset = "0x71CE8E0", VA = "0x1871CFEE0")]
		public void VCBEHYYXWRV(string a, RCVNBXYDJZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x71CF480", Offset = "0x71CDE80", VA = "0x1871CF480")]
		private void BBRJBZSTQAB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x71D0030", Offset = "0x71CEA30", VA = "0x1871D0030")]
		private void YEEWOPQMUAP(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x71CF9B0", Offset = "0x71CE3B0", VA = "0x1871CF9B0")]
		private void FXMHBBLBDJX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x71D00F0", Offset = "0x71CEAF0", VA = "0x1871D00F0")]
		internal static Dictionary<string, RCVNBXYDJZR> ZQDUEYZAKGQ(WTVTOFLEGQC a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x71CFA70", Offset = "0x71CE470", VA = "0x1871CFA70", Slot = "4")]
		public virtual void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WTVTOFLEGQC : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class PDQLYVSWNTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader QEHVIILMBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<XWLGDPDBHBS> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<ZCPNPFGNFZG> VRRWHNGOOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<BBDSDFOIDBC> VRCBPSYWMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<TJHKYMCWPRO> VRHIMZSTVPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<PJNTLMSRGVL> VQRNVFLBTHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<NNQENYBDRHR> VQWUSMEZCSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<OFRYBPDMWCH> VQHAARXHAKU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<HMCQBNAUHVJ> VQMGXYREJWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<BERLEXGGYBZ> VTCSOIPWCNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> VTHZLPJTLYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<FHGUWOJFITY> TSXUNNPOWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<XLGFUPUXDAO> TSSNQGVRNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<RAWOIEBXRSB> TTIIIBDJPWF;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PDQLYVSWNTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x71D8520", Offset = "0x71D6F20", VA = "0x1871D8520")]
			internal XWLGDPDBHBS WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x71D8530", Offset = "0x71D6F30", VA = "0x1871D8530")]
			internal ZCPNPFGNFZG WEPFYILOLMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x71D8500", Offset = "0x71D6F00", VA = "0x1871D8500")]
			internal BBDSDFOIDBC WDZLGODWJEQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x71D8510", Offset = "0x71D6F10", VA = "0x1871D8510")]
			internal TJHKYMCWPRO WEESDUXTSPZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x71D84E0", Offset = "0x71D6EE0", VA = "0x1871D84E0")]
			internal PJNTLMSRGVL WDOXMAQBQHY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x71D84F0", Offset = "0x71D6EF0", VA = "0x1871D84F0")]
			internal NNQENYBDRHR WDUEJHJYZTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x71D84C0", Offset = "0x71D6EC0", VA = "0x1871D84C0")]
			internal OFRYBPDMWCH WDEJRNCGXLG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x71D84D0", Offset = "0x71D6ED0", VA = "0x1871D84D0")]
			internal HMCQBNAUHVJ WDJQOTWEGWP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x71D8540", Offset = "0x71D6F40", VA = "0x1871D8540")]
			internal BERLEXGGYBZ WGACFDUVZOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x71D8550", Offset = "0x71D6F50", VA = "0x1871D8550")]
			internal Sampler WGFJCKOTIZL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x71D8330", Offset = "0x71D6D30", VA = "0x1871D8330")]
			internal FHGUWOJFITY PGKPQJQWYUH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x71D8320", Offset = "0x71D6D20", VA = "0x1871D8320")]
			internal XLGFUPUXDAO PGFITCWZPIY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x71D84B0", Offset = "0x71D6EB0", VA = "0x1871D84B0")]
			internal RAWOIEBXRSB PGVDKXERRQZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> DJLXAZPZHPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> OCRKTCWKXJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<XWLGDPDBHBS> TJPNRDNBVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<ZCPNPFGNFZG> TIFFEQERPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JPKUYULHDWV JPKUYULHDWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<BBDSDFOIDBC> BAQTJTHQDQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<TJHKYMCWPRO> QXCXSTFEAAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<PJNTLMSRGVL> ZTGENRNXQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<NNQENYBDRHR> KCRQZHWTMZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<OFRYBPDMWCH> LCIPWPXQTOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<HMCQBNAUHVJ> OVPIOUMUXAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<BERLEXGGYBZ> NCMPODZQHQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> EKXUXTNWQZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DAWXZYRRAUE FPNDOERVAQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<FHGUWOJFITY> WUTSDPUJQTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<XLGFUPUXDAO> QYOWTHXDQGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<RAWOIEBXRSB> NLYLLOQQUJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<WGTBIMSOTQG> HZOTJZKBPVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool GJWRJOPXXPI;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x71DE400", Offset = "0x71DCE00", VA = "0x1871DE400")]
		public WTVTOFLEGQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x71DE360", Offset = "0x71DCD60", VA = "0x1871DE360")]
		public FHGUWOJFITY MZPHVRNIGUG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x71DB970", Offset = "0x71DA370", VA = "0x1871DB970")]
		public static WTVTOFLEGQC Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x71DC7C0", Offset = "0x71DB1C0", VA = "0x1871DC7C0")]
		public void JVPEYACKYLR(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class FHGUWOJFITY : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<YQPLXVVAQMG> NCMPODZQHQE;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public FHGUWOJFITY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x71D2AE0", Offset = "0x71D14E0", VA = "0x1871D2AE0")]
		public static FHGUWOJFITY Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x71D2C60", Offset = "0x71D1660", VA = "0x1871D2C60", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class RAWOIEBXRSB : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public CLUJQPIEVOU LTVNKOBTVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NTSIBZNILIJ QJCJQZPQAVU;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public RAWOIEBXRSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x71D89A0", Offset = "0x71D73A0", VA = "0x1871D89A0")]
		public static RAWOIEBXRSB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x71D8B70", Offset = "0x71D7570", VA = "0x1871D8B70", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class WBLFFZFWJGC : WGTBIMSOTQG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public WBLFFZFWJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x71DB3F0", Offset = "0x71D9DF0", VA = "0x1871DB3F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class WGTBIMSOTQG : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string PLLGHUJCWXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color QUVGLXTQQBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string PUQVJDXVEJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float OZINGJZNDBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float WUERTKWCAJO;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public WGTBIMSOTQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x71DB4A0", Offset = "0x71D9EA0", VA = "0x1871DB4A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class XBKEZTJIOZS : WGTBIMSOTQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x71CD730", Offset = "0x71CC130", VA = "0x1871CD730")]
		public XBKEZTJIOZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x71DB3F0", Offset = "0x71D9DF0", VA = "0x1871DB3F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class KDRACVVUETU : WGTBIMSOTQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float LNVRDIYIZVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float GGJYWGCDJBK;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x71D6750", Offset = "0x71D5150", VA = "0x1871D6750")]
		public KDRACVVUETU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x71D6450", Offset = "0x71D4E50", VA = "0x1871D6450", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface PQVZAMBMGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NLMJFGQKUKW(WTVTOFLEGQC a, LOINOQVCLTV b, [Out] WCSOTBUVZFK c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RCVNBXYDJZR Clone(WTVTOFLEGQC root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class VSCXGXQDKGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string IBOKXSJRGOT;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected VSCXGXQDKGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class HPHVODZZMGF : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty OCDZUKXDEOY
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x71D4BE0", Offset = "0x71D35E0", VA = "0x1871D4BE0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public HPHVODZZMGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NWFRFHMVRQF : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x71D78D0", Offset = "0x71D62D0", VA = "0x1871D78D0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public NWFRFHMVRQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class CTRATNJFWMP : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color TQPVNSBBBBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public USWQQWDREUK GTCJONQEPKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color INBUPDKZCJY;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x71D1D10", Offset = "0x71D0710", VA = "0x1871D1D10")]
		public CTRATNJFWMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x71D1810", Offset = "0x71D0210", VA = "0x1871D1810")]
		public static CTRATNJFWMP Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x71D1AB0", Offset = "0x71D04B0", VA = "0x1871D1AB0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class KPEFKKJMQLF : USWQQWDREUK
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string VLEMHPOHMML = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double BDFPJJLKDEX;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x71D28E0", Offset = "0x71D12E0", VA = "0x1871D28E0")]
		public KPEFKKJMQLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x71D6CD0", Offset = "0x71D56D0", VA = "0x1871D6CD0")]
		public new static KPEFKKJMQLF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x71D6FC0", Offset = "0x71D59C0", VA = "0x1871D6FC0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class DKWTFROCKWH : USWQQWDREUK
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string KVIFJPFQJOW = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double GNGHIRCOPUC;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x71D28E0", Offset = "0x71D12E0", VA = "0x1871D28E0")]
		public DKWTFROCKWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x71D2530", Offset = "0x71D0F30", VA = "0x1871D2530")]
		public new static DKWTFROCKWH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x71D2820", Offset = "0x71D1220", VA = "0x1871D2820", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class FWINARFTNES : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color RNOGLQKPKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public USWQQWDREUK ZJNYPCYNDRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double JAGFIGDMXAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double XLRLEPGUVIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public USWQQWDREUK BFEIEVXINDZ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x71D3740", Offset = "0x71D2140", VA = "0x1871D3740")]
		public FWINARFTNES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x71D3140", Offset = "0x71D1B40", VA = "0x1871D3140")]
		public static FWINARFTNES Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x71D34B0", Offset = "0x71D1EB0", VA = "0x1871D34B0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class XABKJXLEVAH : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class WKDHTAWVSFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<ANNHZWNIYUF> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<ANNHZWNIYUF> VRCBPSYWMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, ANNHZWNIYUF>> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x71DB7F0", Offset = "0x71DA1F0", VA = "0x1871DB7F0")]
			internal ANNHZWNIYUF WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x71DB8C0", Offset = "0x71DA2C0", VA = "0x1871DB8C0")]
			internal Dictionary<string, ANNHZWNIYUF> WEPFYILOLMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x71DB720", Offset = "0x71DA120", VA = "0x1871DB720")]
			internal ANNHZWNIYUF WDZLGODWJEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, ANNHZWNIYUF> HBWHKAHLKTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ANNHZWNIYUF KQGGERXYISM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HOWNCWMIGVN AZNSACCNCRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode FZFJHADPKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, ANNHZWNIYUF>> NDZKUQJMMTR;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x71DFDF0", Offset = "0x71DE7F0", VA = "0x1871DFDF0")]
		public XABKJXLEVAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x71DF750", Offset = "0x71DE150", VA = "0x1871DF750")]
		public XABKJXLEVAH(XABKJXLEVAH a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x71DF6B0", Offset = "0x71DE0B0", VA = "0x1871DF6B0")]
		public static int[] WVDHWSKKNYN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x71DF550", Offset = "0x71DDF50", VA = "0x1871DF550")]
		public static int[] TTNWZWWZJTN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x71DE450", Offset = "0x71DCE50", VA = "0x1871DE450")]
		public static int[] AUVNZHGPOKB(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x71DEAD0", Offset = "0x71DD4D0", VA = "0x1871DEAD0")]
		public static int[] ESOAEDBLHEX(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x71DED20", Offset = "0x71DD720", VA = "0x1871DED20")]
		public static int[] HYQFROZTQPM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x71DF3C0", Offset = "0x71DDDC0", VA = "0x1871DF3C0")]
		public static int[] LQNZIAYCFEH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x71DF4C0", Offset = "0x71DDEC0", VA = "0x1871DF4C0")]
		public static int[] TBLZQIVFHBJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x71DE610", Offset = "0x71DD010", VA = "0x1871DE610")]
		public static int[] BZGROGRKMSE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x71DF430", Offset = "0x71DDE30", VA = "0x1871DF430")]
		public static int[] PTQLAHNJWUM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x71DE680", Offset = "0x71DD080", VA = "0x1871DE680")]
		public static XABKJXLEVAH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x71DEDD0", Offset = "0x71DD7D0", VA = "0x1871DEDD0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class NBOJUSYUWJY
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] CWTSHUVBTEG;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] WBYRYOMEFUT;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] RBAYUQYANRX;
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
	public class BERLEXGGYBZ : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool WNCVVQMZBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public CAHKCJZXWON PEXYIXMHTZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<YQPLXVVAQMG> BZMLJUYVXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public ZBLVNRGSJCX XLGFUPUXDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GJOSHKOMLSK INCBTZHUHNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public JDSRIUAAMBB FVOMDDIMNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion UWXJAJSPRJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 BDFPJJLKDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 MHXTLMOCDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> LWNBWRIRQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public RAICXMWOJTG PUZVIUSYZHD;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x71CECA0", Offset = "0x71CD6A0", VA = "0x1871CECA0")]
		public BERLEXGGYBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x71CD780", Offset = "0x71CC180", VA = "0x1871CD780")]
		public static BERLEXGGYBZ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x71CE0B0", Offset = "0x71CCAB0", VA = "0x1871CE0B0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode YIENRBEXEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode EVSIHFHVWMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode PYEDUYPWIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode PZPABTZDWZL;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x71DA460", Offset = "0x71D8E60", VA = "0x1871DA460")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x71D9FA0", Offset = "0x71D89A0", VA = "0x1871D9FA0")]
		public static Sampler Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x71DA270", Offset = "0x71D8C70", VA = "0x1871DA270", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class XLGFUPUXDAO : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ANNHZWNIYUF OYVDLNRGLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public YQPLXVVAQMG DKQHTEFTGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<YQPLXVVAQMG> URYKBCOLWJI;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x71E0FD0", Offset = "0x71DF9D0", VA = "0x1871E0FD0")]
		public XLGFUPUXDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x71E0960", Offset = "0x71DF360", VA = "0x1871E0960")]
		public static XLGFUPUXDAO Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x71E0CC0", Offset = "0x71DF6C0", VA = "0x1871E0CC0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class USWQQWDREUK : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string LWYYUJEWECV = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string UQKVEJAOGJH = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CUEDZTDBNVB NMPLFXDGBRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x71DB250", Offset = "0x71D9C50", VA = "0x1871DB250")]
		public USWQQWDREUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x71DB2A0", Offset = "0x71D9CA0", VA = "0x1871DB2A0")]
		public USWQQWDREUK(USWQQWDREUK a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x71DAEA0", Offset = "0x71D98A0", VA = "0x1871DAEA0")]
		public static USWQQWDREUK Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x71DB1F0", Offset = "0x71D9BF0", VA = "0x1871DB1F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x71DB120", Offset = "0x71D9B20", VA = "0x1871DB120")]
		public void JOWAYVDJKAW(JsonWriter a)
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
	public class KLWDLWUFTGL
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double MKUSZLZIBUP;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double NCTKNPUDWRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double ECOBVQJIRSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double ZJQGJLFIXTG;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x71D6C50", Offset = "0x71D5650", VA = "0x1871D6C50")]
		public KLWDLWUFTGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x71D67B0", Offset = "0x71D51B0", VA = "0x1871D67B0")]
		public static KLWDLWUFTGL Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x71D69F0", Offset = "0x71D53F0", VA = "0x1871D69F0")]
		public void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class XBVKPANKNTB : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color GNIPHGWGXYE;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double IAKLBQOAQPI;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double KPKYHSAZJWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType BFJYMHQJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color CWTSHUVBTEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double EMFLHOXHDEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double RRIYTCZYDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KLWDLWUFTGL KLWDLWUFTGL;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x71E08A0", Offset = "0x71DF2A0", VA = "0x1871E08A0")]
		public XBVKPANKNTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x71E0780", Offset = "0x71DF180", VA = "0x1871E0780")]
		public XBVKPANKNTB(XBVKPANKNTB a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x71DFFB0", Offset = "0x71DE9B0", VA = "0x1871DFFB0")]
		public static XBVKPANKNTB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x71DFE90", Offset = "0x71DE890", VA = "0x1871DFE90")]
		public static XBVKPANKNTB Deserialize(WTVTOFLEGQC root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x71E03A0", Offset = "0x71DEDA0", VA = "0x1871E03A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class YRBLNUHACVL : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<WGTBIMSOTQG> YWXOWZGGVXQ;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public YRBLNUHACVL(IList<WGTBIMSOTQG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x71E18C0", Offset = "0x71E02C0", VA = "0x1871E18C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x71E1850", Offset = "0x71E0250", VA = "0x1871E1850", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class RZZVEXPXDIJ : RCVNBXYDJZR, PQVZAMBMGMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<XBVKPANKNTB> HZOTJZKBPVE;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x71D9F20", Offset = "0x71D8920", VA = "0x1871D9F20")]
		public RZZVEXPXDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x71D9510", Offset = "0x71D7F10", VA = "0x1871D9510", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x71D9E30", Offset = "0x71D8830", VA = "0x1871D9E30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x71D9790", Offset = "0x71D8190", VA = "0x1871D9790")]
		private static string[] GHZYGTDFOCR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x71D90B0", Offset = "0x71D7AB0", VA = "0x1871D90B0")]
		private static WCSOTBUVZFK.ImportValuesConversion AKJBZEHFVTT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x71D9A40", Offset = "0x71D8440", VA = "0x1871D9A40", Slot = "6")]
		public bool NLMJFGQKUKW(WTVTOFLEGQC a, LOINOQVCLTV b, [Out] WCSOTBUVZFK c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class FKZOWAHGAGS : GNNRONQTKJO<XBVKPANKNTB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override XBVKPANKNTB Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x71D2FF0", Offset = "0x71D19F0", VA = "0x1871D2FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x71D2FB0", Offset = "0x71D19B0", VA = "0x1871D2FB0")]
		public FKZOWAHGAGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x71D2ED0", Offset = "0x71D18D0", VA = "0x1871D2ED0")]
		public static FKZOWAHGAGS Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class GJVIHVQJRLH : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public FKZOWAHGAGS RAICXMWOJTG;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public GJVIHVQJRLH(FKZOWAHGAGS a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x71D3DA0", Offset = "0x71D27A0", VA = "0x1871D3DA0")]
		public GJVIHVQJRLH(int a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x71D3C20", Offset = "0x71D2620", VA = "0x1871D3C20", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x71D3CA0", Offset = "0x71D26A0", VA = "0x1871D3CA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class BTEURAZEXOU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x71CF2B0", Offset = "0x71CDCB0", VA = "0x1871CF2B0")]
		public BTEURAZEXOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x71CEDD0", Offset = "0x71CD7D0", VA = "0x1871CEDD0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
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
