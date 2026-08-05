using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Async;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A10360", Offset = "0x9A0ED60", VA = "0x189A10360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DBE0", Offset = "0x9A0C5E0", VA = "0x189A0DBE0")]
		public CubeMapGenerator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class LAZBDIFWBMA
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Resolution
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public uint x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public uint y;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool AMZHVDCQJPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x9A10950", Offset = "0x9A0F350", VA = "0x189A10950")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A10A40", Offset = "0x9A0F440", VA = "0x189A10A40")]
			public Resolution(uint x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
			public Resolution(uint x, uint y)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9A10960", Offset = "0x9A0F360", VA = "0x189A10960")]
			public static Resolution Reduce(Resolution[] options, Resolution originalResolution, int times)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class NEEYZLXUNKQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Resolution NVCVUFEVALT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private Resolution? SXGOGWCSGOY;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public uint TTVPRIWOGRA
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x9A0FE80", Offset = "0x9A0E880", VA = "0x189A0FE80")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Resolution MFBJLZBNAJK
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x9A0FE90", Offset = "0x9A0E890", VA = "0x189A0FE90")]
				get
				{
					return default(Resolution);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xF99920", Offset = "0xF98320", VA = "0x180F99920")]
			public NEEYZLXUNKQ(Resolution a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A101E0", Offset = "0x9A0EBE0", VA = "0x189A101E0")]
			private static Resolution RDMQVXIDOYA(Resolution a, DeviceMemoryTier b)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class QUYPPMOUFDL
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Resolution ZDCFECDHGRZ;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Resolution WOZKBHBFQMD;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Resolution WNOQHNFGCEN;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Resolution AJIGHLISPUB;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Resolution AJGYRIGIOJG;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Resolution QBECHGBZFYV;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			internal static readonly Resolution[] VMUNPRUPKCZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class IWJDUANWAMV
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Resolution ZDCFECDHGRZ;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Resolution WOZKBHBFQMD;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Resolution WNOQHNFGCEN;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Resolution AJIGHLISPUB;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Resolution AJGYRIGIOJG;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Resolution QBECHGBZFYV;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			internal static readonly Resolution[] VMUNPRUPKCZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class DZXJZYDJYMF
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Resolution ZDCFECDHGRZ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Resolution WOZKBHBFQMD;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Resolution WNOQHNFGCEN;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Resolution AJIGHLISPUB;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Resolution AJGYRIGIOJG;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Resolution QBECHGBZFYV;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			internal static readonly Resolution[] VMUNPRUPKCZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class ECQJAHYCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Resolution ZDCFECDHGRZ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Resolution WOZKBHBFQMD;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Resolution WNOQHNFGCEN;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Resolution AJIGHLISPUB;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Resolution AJGYRIGIOJG;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Resolution QBECHGBZFYV;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			internal static readonly Resolution[] VMUNPRUPKCZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class FIEHBCQSVMQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Resolution TOUSJNYCODD;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Resolution DVZXWZSTDKA;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Resolution MJTRZSKXJSF;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Resolution DBPKVHJMYEQ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Resolution YSOOYBUKTIM;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Resolution ZDCFECDHGRZ;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Resolution WOZKBHBFQMD;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Resolution WNOQHNFGCEN;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Resolution AJIGHLISPUB;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Resolution AJGYRIGIOJG;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Resolution QBECHGBZFYV;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			internal static readonly Resolution[] VMUNPRUPKCZ;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E5A0", Offset = "0x9A0CFA0", VA = "0x189A0E5A0")]
			public static Resolution PHISLPLFHLN(uint a)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Resolution IYBZUEOTVKG;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class OFPDLPJYCZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A10420", Offset = "0x9A0EE20", VA = "0x189A10420")]
		private static bool JRWGZROZGMS(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A103E0", Offset = "0x9A0EDE0", VA = "0x189A103E0")]
		public static bool EINCBGKNMDH(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A10440", Offset = "0x9A0EE40", VA = "0x189A10440")]
		public static bool OBHKQKZMHUM(byte[] a, [Out] int b, [Out] int c)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum TextureMemory : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class ZESPMJYCMHC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string AJEKOIXQXIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D DIFIWBLKGPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public TextureMemory BJSEUQPRSHU;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9A11C70", Offset = "0x9A10670", VA = "0x189A11C70")]
			public ZESPMJYCMHC(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D5B910", Offset = "0x1D5A310", VA = "0x181D5B910")]
			public ZESPMJYCMHC(string a, Texture2D b, TextureMemory c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A11C30", Offset = "0x9A10630", VA = "0x189A11C30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BXAAERVMRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public ManagedTexture TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextureMemory MEAAJAUGKTE;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXAAERVMRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0DBA0", Offset = "0x9A0C5A0", VA = "0x189A0DBA0")]
			internal void CQYZUAZVOSQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EAFIVIHKRYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int DGNGFRSOASH;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EAFIVIHKRYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E340", Offset = "0x9A0CD40", VA = "0x189A0E340")]
			internal EncodedImage OVSWXFVINPI(Texture2D a)
			{
				return default(EncodedImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class HSXXEZIOVPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture TSWOXHVMIDZ;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HSXXEZIOVPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9A0EA90", Offset = "0x9A0D490", VA = "0x189A0EA90")]
			internal void RCRWQZOZIXT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private AUAMWGBNBSF<Texture2D> WSBTXUTDBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ZESPMJYCMHC ZRDZJRBHKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private AUAMWGBNBSF<EncodedImage> VKMAZPSFYSV;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AUAMWGBNBSF<EncodedImage> SYYCOCQRRGF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private ZESPMJYCMHC IOZZQNIXJHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9A0FD10", Offset = "0x9A0E710", VA = "0x189A0FD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FDB0", Offset = "0x9A0E7B0", VA = "0x189A0FDB0")]
		public ManagedTexture(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FE10", Offset = "0x9A0E810", VA = "0x189A0FE10")]
		public ManagedTexture(string name, bool usePalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F9F0", Offset = "0x9A0E3F0", VA = "0x189A0F9F0")]
		public void UCZGNTOYYHX(RenderTexture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FA30", Offset = "0x9A0E430", VA = "0x189A0FA30")]
		public AUAMWGBNBSF<Texture2D> WGTIIHRPWOK(TextureMemory a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F800", Offset = "0x9A0E200", VA = "0x189A0F800")]
		public AUAMWGBNBSF<EncodedImage> QYNLGPECGUA(bool a = false, int b = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A0EFD0", Offset = "0x9A0D9D0", VA = "0x189A0EFD0")]
		public AUAMWGBNBSF<EncodedImage> DZTRHCGAROM(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F2B0", Offset = "0x9A0DCB0", VA = "0x189A0F2B0")]
		private static AUAMWGBNBSF<Texture2D> LRFZIODYPBT(string a, RenderTexture b, Texture2D c, bool d, TextureMemory e = TextureMemory.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A0EF30", Offset = "0x9A0D930", VA = "0x189A0EF30")]
		public void DVFNXEHBVRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F2A0", Offset = "0x9A0DCA0", VA = "0x189A0F2A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F990", Offset = "0x9A0E390", VA = "0x189A0F990")]
		[CompilerGenerated]
		private AUAMWGBNBSF<byte[]> TONSQXUDAPV(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XRJULPIMRRE
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct RRTexturePlugin
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9A10850", Offset = "0x9A0F250", VA = "0x189A10850")]
			public unsafe static extern void SubmitPngForCompression(void* pngdata, void* dst, bool mipmap, bool bgr, bool etc2ordxt, [Out] int width, [Out] int height, [Out] bool rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public byte[] BYZYODVIEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public bool FVJAOGHWMBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool LGLQLHPTHMV;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9A11710", Offset = "0x9A10110", VA = "0x189A11710")]
			internal void ORYYFJPNUSY(NativeArray<byte> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action<NativeArray<byte>> ACPCVVKASIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public NativeArray<byte> GJGCXRLLFJH;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0ED30", Offset = "0x9A0D730", VA = "0x189A0ED30")]
			internal void RWVWUNMUPHK()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <Compress>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public byte[] imageBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public bool generateMipMaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool makeTextureReadable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9A10CF0", Offset = "0x9A0F6F0", VA = "0x189A10CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9A10F00", Offset = "0x9A0F900", VA = "0x189A10F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <RunCompressionJob>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action<NativeArray<byte>> compressionAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool hasAlpha;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int width;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int height;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool generateMipMaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public bool makeTextureReadable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private JJCJYPIOSDN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Texture2D <outputTexture>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9A10F70", Offset = "0x9A0F970", VA = "0x189A10F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9A11600", Offset = "0x9A10000", VA = "0x189A11600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly bool MPKPALKRILY;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		public static bool CHAFXTFXSUA(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A11AA0", Offset = "0x9A104A0", VA = "0x189A11AA0")]
		[AsyncStateMachine(typeof(<Compress>d__4))]
		public static Task<Texture2D> VTTFQVGVQMW(byte[] a, bool b = false, bool c = false, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A11950", Offset = "0x9A10350", VA = "0x189A11950")]
		[AsyncStateMachine(typeof(<RunCompressionJob>d__5))]
		private static Task<Texture2D> KWRWSAULGSK(int a, int b, bool c, bool d, bool e, Action<NativeArray<byte>> compressionAction, CancellationToken f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A118B0", Offset = "0x9A102B0", VA = "0x189A118B0")]
		private static TextureFormat HKUSRJVRHHP(bool a)
		{
			return default(TextureFormat);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal enum PNGFormat
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		RGB,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		BGR,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		ABGR
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class DAPSPDAHOQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E040", Offset = "0x9A0CA40", VA = "0x189A0E040")]
		public static bool OVKJWZNNAMN(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DD60", Offset = "0x9A0C760", VA = "0x189A0DD60")]
		public static void NXSELJBZTMY(byte[] a, [Out] int b, [Out] int c, [Out] PNGFormat d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E080", Offset = "0x9A0CA80", VA = "0x189A0E080")]
		private static uint TJVZPLVVSTZ(byte[] a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DC00", Offset = "0x9A0C600", VA = "0x189A0DC00")]
		private static ulong LHROSUVTISQ(byte[] a, int b)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class SIBEPKZSWWK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A10AB0", Offset = "0x9A0F4B0", VA = "0x189A10AB0")]
		public static RenderTexture HJAOUANXBRT(int a, int b, int c, Camera d, RenderTextureMemoryless e = RenderTextureMemoryless.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A10A50", Offset = "0x9A0F450", VA = "0x189A10A50")]
		public static void FFVPSPRTDWQ(RenderTexture a)
		{
		}
	}
}
namespace RecRoom.Utils.Image.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class QRMOELISXUY<a> : IDisposable where a : notnull, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private readonly struct ImageIdAndLoadOptions : IEquatable<ImageIdAndLoadOptions>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public readonly a ImageId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public readonly TextureLoadOptions LoadOptions;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1B2BE00", Offset = "0x1B2A800", VA = "0x181B2BE00")]
			public ImageIdAndLoadOptions(a key, TextureLoadOptions loadOptions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x660FC10", Offset = "0x660E610", VA = "0x18660FC10", Slot = "4")]
			public bool Equals(QRMOELISXUY<a>.ImageIdAndLoadOptions other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x66102B0", Offset = "0x660ECB0", VA = "0x1866102B0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66103C0", Offset = "0x660EDC0", VA = "0x1866103C0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66108E0", Offset = "0x660F2E0", VA = "0x1866108E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__DelayDispose|9_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public IDisposable disposable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x420AE60", Offset = "0x4209860", VA = "0x18420AE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x420B100", Offset = "0x4209B00", VA = "0x18420B100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public WOBDLJWTCZK<Task<Texture2D>> BAFXCPQIVYB;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x76556F0", Offset = "0x76540F0", VA = "0x1876556F0")]
			internal void XJCMFTGCKAY()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <CreateTexture>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ImageIdAndLoadOptions cacheKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public QRMOELISXUY<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private a <imageId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TextureLoadOptions <textureLoadOptions>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<byte[]> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x657BD60", Offset = "0x657A760", VA = "0x18657BD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x657C470", Offset = "0x657AE70", VA = "0x18657C470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <LoadTexture>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public TextureLoadOptions textureLoadOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public QRMOELISXUY<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public byte[] imageBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool <generateMipMaps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private bool <makeTextureReadable>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private bool <usePointFiltering>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private bool <useClampWrapMode>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <width>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private int <height>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69D36C0", Offset = "0x69D20C0", VA = "0x1869D36C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69D4E60", Offset = "0x69D3860", VA = "0x1869D4E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int VEHZISWGNNL = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly SemaphoreSlim FIGYQMWOFBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Func<a, CancellationToken, Task<byte[]>>? KJOASPKPDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? XUZPTWVWYYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<a, string>? PPHWHMGTGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly QBYHGFRJKPV<ImageIdAndLoadOptions, Texture2D> VNGFGRCZGEP;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7606E20", Offset = "0x7605820", VA = "0x187606E20")]
		public QRMOELISXUY(Func<a, CancellationToken, Task<byte[]>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7606E50", Offset = "0x7605850", VA = "0x187606E50")]
		public QRMOELISXUY(Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7606B90", Offset = "0x7605590", VA = "0x187606B90")]
		private QRMOELISXUY(Func<a, CancellationToken, Task<byte[]>>? getImageFunc, Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? getTextureFunc, Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7606190", Offset = "0x7604B90", VA = "0x187606190")]
		public ZTZZICZDYWU<Texture2D> ATNWJINOSGO(a a, TextureLoadOptions b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76068F0", Offset = "0x76052F0", VA = "0x1876068F0")]
		public void OQGXGKTVUAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76065F0", Offset = "0x7604FF0", VA = "0x1876065F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7606950", Offset = "0x7605350", VA = "0x187606950")]
		[AsyncStateMachine(typeof(QRMOELISXUY<>.<CreateTexture>d__13))]
		private Task<Texture2D> TUYPYRQFPQZ(ImageIdAndLoadOptions a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7606490", Offset = "0x7604E90", VA = "0x187606490")]
		[AsyncStateMachine(typeof(QRMOELISXUY<>.<LoadTexture>d__14))]
		private Task<Texture2D> DMVGTVQJAKF(byte[] a, TextureLoadOptions b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7606940", Offset = "0x7605340", VA = "0x187606940")]
		private void SVQVITJEMHV(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76068E0", Offset = "0x76052E0", VA = "0x1876068E0")]
		private bool OEFBWHZXUDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76066D0", Offset = "0x76050D0", VA = "0x1876066D0")]
		private void FMGRYHQTLFK(byte[] a, [Out] int b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x76067C0", Offset = "0x76051C0", VA = "0x1876067C0")]
		private bool ICEPWKNZBGC(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x76067F0", Offset = "0x76051F0", VA = "0x1876067F0")]
		[AsyncStateMachine(typeof(QRMOELISXUY<>.<<GetOrAdd>g__DelayDispose|9_1>d))]
		[CompilerGenerated]
		internal static Task JGKEEVRFTIY(IDisposable a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Flags]
	public enum TextureLoadOptions : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NoMipMaps = 1,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		MakeTextureReadable = 2,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		CompressTexture = 4,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		UseNearestTextureFiltering = 8,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		UseClampWrapMode = 0x10
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
