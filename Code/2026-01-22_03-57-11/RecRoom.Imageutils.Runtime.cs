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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8341E30", Offset = "0x8340630", VA = "0x188341E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x8340180", Offset = "0x833E980", VA = "0x188340180")]
		public CubeMapGenerator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WWMZZPLXHLL
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
			public bool IHUGWWHOTVK
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x8342E50", Offset = "0x8341650", VA = "0x188342E50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8342E60", Offset = "0x8341660", VA = "0x188342E60")]
			public Resolution(uint x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
			public Resolution(uint x, uint y)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8342D70", Offset = "0x8341570", VA = "0x188342D70")]
			public static Resolution Reduce(Resolution[] options, Resolution originalResolution, int times)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class OVEACDTGOJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Resolution SCLRBCBOTYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private Resolution? QJIGQJBQCPD;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public uint UGTQOXEKXPX
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x83428D0", Offset = "0x83410D0", VA = "0x1883428D0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Resolution MYZRIKADJNT
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x8342400", Offset = "0x8340C00", VA = "0x188342400")]
				get
				{
					return default(Resolution);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCFCD50", Offset = "0xCFB550", VA = "0x180CFCD50")]
			public OVEACDTGOJH(Resolution a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8342750", Offset = "0x8340F50", VA = "0x188342750")]
			private static Resolution EYUBOEQFKFV(Resolution a, DeviceMemoryTier b)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class WPBIERNHKUE
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Resolution SZTETXQRQEY;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Resolution QLQJRCOPZZC;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Resolution AKZIMKUVING;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Resolution COGHDZJBECU;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Resolution ZWIIMJVEJOB;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Resolution YEMMYNMESSM;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			internal static readonly Resolution[] RGUUGQACPQK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class PSXHUTVPQYM
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Resolution SZTETXQRQEY;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Resolution QLQJRCOPZZC;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Resolution AKZIMKUVING;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Resolution COGHDZJBECU;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Resolution ZWIIMJVEJOB;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Resolution YEMMYNMESSM;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			internal static readonly Resolution[] RGUUGQACPQK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class OKQRRMAKBUA
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Resolution SZTETXQRQEY;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Resolution QLQJRCOPZZC;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Resolution AKZIMKUVING;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Resolution COGHDZJBECU;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Resolution ZWIIMJVEJOB;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Resolution YEMMYNMESSM;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			internal static readonly Resolution[] RGUUGQACPQK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class MWXFAWCLNLW
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Resolution SZTETXQRQEY;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Resolution QLQJRCOPZZC;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Resolution AKZIMKUVING;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Resolution COGHDZJBECU;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Resolution ZWIIMJVEJOB;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Resolution YEMMYNMESSM;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			internal static readonly Resolution[] RGUUGQACPQK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class CVIIKKLHTGX
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Resolution JSKQXEVFKZM;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Resolution BHVJWPYWBGH;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Resolution OYABSDJUBRC;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Resolution PFPKJHETLRX;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Resolution LCDBIYHXBXH;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Resolution SZTETXQRQEY;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Resolution QLQJRCOPZZC;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Resolution AKZIMKUVING;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Resolution COGHDZJBECU;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Resolution ZWIIMJVEJOB;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Resolution YEMMYNMESSM;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			internal static readonly Resolution[] RGUUGQACPQK;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x833FCE0", Offset = "0x833E4E0", VA = "0x18833FCE0")]
			public static Resolution VYYFPACIDOS(uint a)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Resolution AKGOOIMQBXR;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class FRWPJZZHMLY
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83403D0", Offset = "0x833EBD0", VA = "0x1883403D0")]
		private static bool ZYTPVMMGFQV(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83401A0", Offset = "0x833E9A0", VA = "0x1883401A0")]
		public static bool HUXOXOMFPZA(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83401E0", Offset = "0x833E9E0", VA = "0x1883401E0")]
		public static bool JNZFNAXEZJP(byte[] a, [Out] int b, [Out] int c)
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
		private class GTBYBVSJYDJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string IGPTJUXWXQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D KWJSZNPHYGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public TextureMemory HRPODDACWUV;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8340950", Offset = "0x833F150", VA = "0x188340950")]
			public GTBYBVSJYDJ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1A64B30", Offset = "0x1A63330", VA = "0x181A64B30")]
			public GTBYBVSJYDJ(string a, Texture2D b, TextureMemory c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8340910", Offset = "0x833F110", VA = "0x188340910", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class VXXICVGINJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public ManagedTexture BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextureMemory OISRVZEOIAV;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VXXICVGINJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83438D0", Offset = "0x83420D0", VA = "0x1883438D0")]
			internal void KSCLOCFDCYT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NAFFDINEDQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int URJXXVDRRRK;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAFFDINEDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8341DF0", Offset = "0x83405F0", VA = "0x188341DF0")]
			internal EncodedImage SLQROTHCNIJ(Texture2D a)
			{
				return default(EncodedImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class IAMATHSKNJS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture SMHDJPFJFFG;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IAMATHSKNJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83409A0", Offset = "0x833F1A0", VA = "0x1883409A0")]
			internal void NNKAERRLSFW()
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
		private JIREGIBPOUE<Texture2D> HCJTRFYMUGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private GTBYBVSJYDJ WSRTTLZVYSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JIREGIBPOUE<EncodedImage> PKYXUMPZEHA;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JIREGIBPOUE<EncodedImage> GJCNMJGQFZY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private GTBYBVSJYDJ QYIWGFPEXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x83417B0", Offset = "0x833FFB0", VA = "0x1883417B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8341D20", Offset = "0x8340520", VA = "0x188341D20")]
		public ManagedTexture(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8341D80", Offset = "0x8340580", VA = "0x188341D80")]
		public ManagedTexture(string name, bool usePalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8341770", Offset = "0x833FF70", VA = "0x188341770")]
		public void OAWSCBPMJWA(RenderTexture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8341A40", Offset = "0x8340240", VA = "0x188341A40")]
		public JIREGIBPOUE<Texture2D> ZQUPLKLFFHX(TextureMemory a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83418B0", Offset = "0x83400B0", VA = "0x1883418B0")]
		public JIREGIBPOUE<EncodedImage> YOSFDLKMQBV(bool a = false, int b = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8340EB0", Offset = "0x833F6B0", VA = "0x188340EB0")]
		public JIREGIBPOUE<EncodedImage> BULVSRNVENF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8341170", Offset = "0x833F970", VA = "0x188341170")]
		private static JIREGIBPOUE<Texture2D> CQRRJCFDRJW(string a, RenderTexture b, Texture2D c, bool d, TextureMemory e = TextureMemory.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83416D0", Offset = "0x833FED0", VA = "0x1883416D0")]
		public void EJCHNGDHWBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83416C0", Offset = "0x833FEC0", VA = "0x1883416C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8341850", Offset = "0x8340050", VA = "0x188341850")]
		[CompilerGenerated]
		private JIREGIBPOUE<byte[]> UMVMYAVXUDA(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OBJMRPSAEID
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct RRTexturePlugin
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8342C70", Offset = "0x8341470", VA = "0x188342C70")]
			public unsafe static extern void SubmitPngForCompression(void* pngdata, void* dst, bool mipmap, bool bgr, bool etc2ordxt, [Out] int width, [Out] int height, [Out] bool rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class OVYXGTZWSNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public byte[] PLRFAKOSVVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public bool HHCIHZTMNVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool QPAZWKTPEVI;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVYXGTZWSNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83428E0", Offset = "0x83410E0", VA = "0x1883428E0")]
			internal void OHQAXGTBKTP(NativeArray<byte> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class TPKTMYRKYMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action<NativeArray<byte>> SWPYNLJACKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public NativeArray<byte> VYYWRRBAREU;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TPKTMYRKYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8342E70", Offset = "0x8341670", VA = "0x188342E70")]
			internal void HGYWPGNDEEL()
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
			[Cpp2IlInjected.Address(RVA = "0x8342EB0", Offset = "0x83416B0", VA = "0x188342EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83430C0", Offset = "0x83418C0", VA = "0x1883430C0", Slot = "5")]
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
			private TPKTMYRKYMC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Texture2D <outputTexture>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8343130", Offset = "0x8341930", VA = "0x188343130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83437C0", Offset = "0x8341FC0", VA = "0x1883437C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly bool NLBMRJOFITR;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
		public static bool BVNOKLBTLVV(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8342000", Offset = "0x8340800", VA = "0x188342000")]
		[AsyncStateMachine(typeof(<Compress>d__4))]
		public static Task<Texture2D> KUSANZCFKBF(byte[] a, bool b = false, bool c = false, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8341EB0", Offset = "0x83406B0", VA = "0x188341EB0")]
		[AsyncStateMachine(typeof(<RunCompressionJob>d__5))]
		private static Task<Texture2D> IGJECHBPRHH(int a, int b, bool c, bool d, bool e, Action<NativeArray<byte>> compressionAction, CancellationToken f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8342140", Offset = "0x8340940", VA = "0x188342140")]
		private static TextureFormat TILQNVGGGVO(bool a)
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
	internal static class FZBAFGQYWZI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8340770", Offset = "0x833EF70", VA = "0x188340770")]
		public static bool VVNVEORIYGO(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83403F0", Offset = "0x833EBF0", VA = "0x1883403F0")]
		public static void HCLDPDJNRQZ(byte[] a, [Out] int b, [Out] int c, [Out] PNGFormat d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83406D0", Offset = "0x833EED0", VA = "0x1883406D0")]
		private static uint QIGVSNZDBJW(byte[] a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83407B0", Offset = "0x833EFB0", VA = "0x1883407B0")]
		private static ulong YETVNXOBHFN(byte[] a, int b)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class IVPVLIJINLZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8340A80", Offset = "0x833F280", VA = "0x188340A80")]
		public static RenderTexture WROKHABRCPC(int a, int b, int c, Camera d, RenderTextureMemoryless e = RenderTextureMemoryless.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8340A20", Offset = "0x833F220", VA = "0x188340A20")]
		public static void RCGHMEOVWWH(RenderTexture a)
		{
		}
	}
}
namespace RecRoom.Utils.Image.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class YQCYFGKNFTT<a> : IDisposable where a : notnull, IEquatable<a>
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
			[Cpp2IlInjected.Address(RVA = "0x185F380", Offset = "0x185DB80", VA = "0x18185F380")]
			public ImageIdAndLoadOptions(a key, TextureLoadOptions loadOptions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5016B20", Offset = "0x5015320", VA = "0x185016B20", Slot = "4")]
			public bool Equals(YQCYFGKNFTT<a>.ImageIdAndLoadOptions other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5016DE0", Offset = "0x50155E0", VA = "0x185016DE0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5017410", Offset = "0x5015C10", VA = "0x185017410", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5017860", Offset = "0x5016060", VA = "0x185017860", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CD6450", Offset = "0x3CD4C50", VA = "0x183CD6450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3CD66F0", Offset = "0x3CD4EF0", VA = "0x183CD66F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JZDWTNUPEWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public TKNYLEQDEVP<Task<Texture2D>> NPCCZMVOFRE;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JZDWTNUPEWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x50DE380", Offset = "0x50DCB80", VA = "0x1850DE380")]
			internal void MOGYQYDIQZD()
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
			public YQCYFGKNFTT<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x4E4BCC0", Offset = "0x4E4A4C0", VA = "0x184E4BCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4E4C290", Offset = "0x4E4AA90", VA = "0x184E4C290", Slot = "5")]
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
			public YQCYFGKNFTT<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5085BD0", Offset = "0x50843D0", VA = "0x185085BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5086B80", Offset = "0x5085380", VA = "0x185086B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int HSUTKYHOZGQ = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly SemaphoreSlim VUMUOSFORRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Func<a, CancellationToken, Task<byte[]>>? OUCKZLESGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? QHIIJXAWSAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<a, string>? WQDDKAPLWWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly RQTGVJMXRHY<ImageIdAndLoadOptions, Texture2D> ROBKRGXJWVE;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C0D0", Offset = "0x3E5A8D0", VA = "0x183E5C0D0")]
		public YQCYFGKNFTT(Func<a, CancellationToken, Task<byte[]>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E5BEA0", Offset = "0x3E5A6A0", VA = "0x183E5BEA0")]
		public YQCYFGKNFTT(Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C100", Offset = "0x3E5A900", VA = "0x183E5C100")]
		private YQCYFGKNFTT(Func<a, CancellationToken, Task<byte[]>>? getImageFunc, Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? getTextureFunc, Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B0A0", Offset = "0x3E598A0", VA = "0x183E5B0A0")]
		public XTMHCAFEIFZ<Texture2D> SJVFVALFKHJ(a a, TextureLoadOptions b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A450", Offset = "0x3E58C50", VA = "0x183E5A450")]
		public void GUZCFSWKYTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A310", Offset = "0x3E58B10", VA = "0x183E5A310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B690", Offset = "0x3E59E90", VA = "0x183E5B690")]
		[AsyncStateMachine(typeof(YQCYFGKNFTT<>.<CreateTexture>d__13))]
		private Task<Texture2D> TBZITPUUNNE(ImageIdAndLoadOptions a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A7A0", Offset = "0x3E58FA0", VA = "0x183E5A7A0")]
		[AsyncStateMachine(typeof(YQCYFGKNFTT<>.<LoadTexture>d__14))]
		private Task<Texture2D> HBUFGQDJASO(byte[] a, TextureLoadOptions b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E5ABF0", Offset = "0x3E593F0", VA = "0x183E5ABF0")]
		private void SFKMQTSGYAS(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B7E0", Offset = "0x3E59FE0", VA = "0x183E5B7E0")]
		private bool UVYDRKIHJVR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B7F0", Offset = "0x3E59FF0", VA = "0x183E5B7F0")]
		private void VGAYVJTUHNV(byte[] a, [Out] int b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A230", Offset = "0x3E58A30", VA = "0x183E5A230")]
		private bool CSYHYOKDOXF(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A900", Offset = "0x3E59100", VA = "0x183E5A900")]
		[AsyncStateMachine(typeof(YQCYFGKNFTT<>.<<GetOrAdd>g__DelayDispose|9_1>d))]
		[CompilerGenerated]
		internal static Task IOSRLOXEZKD(IDisposable a)
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
