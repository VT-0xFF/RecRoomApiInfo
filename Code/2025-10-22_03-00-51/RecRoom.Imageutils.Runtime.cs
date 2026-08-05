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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8549BA0", Offset = "0x85481A0", VA = "0x188549BA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x85485D0", Offset = "0x8546BD0", VA = "0x1885485D0")]
		public CubeMapGenerator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KKNTHYUPXVI
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
			public bool PIZZLTSLGBV
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x854A3F0", Offset = "0x85489F0", VA = "0x18854A3F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x854A4E0", Offset = "0x8548AE0", VA = "0x18854A4E0")]
			public Resolution(uint x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
			public Resolution(uint x, uint y)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x854A400", Offset = "0x8548A00", VA = "0x18854A400")]
			public static Resolution Reduce(Resolution[] options, Resolution originalResolution, int times)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class AMUNXIZRZLU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Resolution GMIZDPJFQUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private Resolution? XQRARBZGLBU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public uint JTNYNMZLJWI
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x8548270", Offset = "0x8546870", VA = "0x188548270")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Resolution MDLWBFFSQTM
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x8548280", Offset = "0x8546880", VA = "0x188548280")]
				get
				{
					return default(Resolution);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xFEBC90", Offset = "0xFEA290", VA = "0x180FEBC90")]
			public AMUNXIZRZLU(Resolution a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85480F0", Offset = "0x85466F0", VA = "0x1885480F0")]
			private static Resolution DMLIQDFJYSW(Resolution a, DeviceMemoryTier b)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class ZWGSTSEWIHB
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Resolution ZLDEHUJVVJL;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Resolution WXAJEZHUFDP;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Resolution ZZMZZENBPJJ;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Resolution SPKNVKHUDVB;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Resolution ABYMPNSIFES;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Resolution STIXOEWVBJV;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			internal static readonly Resolution[] HHEDDENZNMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class UHQKMIAKDBZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Resolution ZLDEHUJVVJL;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Resolution WXAJEZHUFDP;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Resolution ZZMZZENBPJJ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Resolution SPKNVKHUDVB;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Resolution ABYMPNSIFES;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Resolution STIXOEWVBJV;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			internal static readonly Resolution[] HHEDDENZNMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class NEYEHSENQAH
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Resolution ZLDEHUJVVJL;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Resolution WXAJEZHUFDP;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Resolution ZZMZZENBPJJ;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Resolution SPKNVKHUDVB;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Resolution ABYMPNSIFES;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Resolution STIXOEWVBJV;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			internal static readonly Resolution[] HHEDDENZNMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class TICWJRYRAFF
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Resolution ZLDEHUJVVJL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Resolution WXAJEZHUFDP;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Resolution ZZMZZENBPJJ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Resolution SPKNVKHUDVB;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Resolution ABYMPNSIFES;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Resolution STIXOEWVBJV;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			internal static readonly Resolution[] HHEDDENZNMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class OLBOBPHZOAS
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Resolution LUTYHRZLVGH;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Resolution RJMNZFYRNEC;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Resolution FKFCBGEZUHR;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Resolution GGQPHYTWKWC;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Resolution EGODDPEEFVE;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Resolution ZLDEHUJVVJL;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Resolution WXAJEZHUFDP;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Resolution ZZMZZENBPJJ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Resolution SPKNVKHUDVB;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Resolution ABYMPNSIFES;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Resolution STIXOEWVBJV;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			internal static readonly Resolution[] HHEDDENZNMH;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8549C20", Offset = "0x8548220", VA = "0x188549C20")]
			public static Resolution CZGOJQBRIMJ(uint a)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Resolution LARUUIYAVNW;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class TZASPMDXJWT
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x854AEA0", Offset = "0x85494A0", VA = "0x18854AEA0")]
		public static bool JVUIIVPNGCT(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x854AC00", Offset = "0x8549200", VA = "0x18854AC00")]
		public static bool GGXXHPWOZAC(byte[] a, [Out] int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x854AE10", Offset = "0x8549410", VA = "0x18854AE10")]
		private static int IWZNNFUOBVF(byte[] a, int b, [Out] ushort c)
		{
			return default(int);
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
		private class QYQRHAOPXKC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string NCYYWAFKAWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D GSRNUFNSHIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public TextureMemory MMPOHUSWWWY;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x854A100", Offset = "0x8548700", VA = "0x18854A100")]
			public QYQRHAOPXKC(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D32D10", Offset = "0x1D31310", VA = "0x181D32D10")]
			public QYQRHAOPXKC(string a, Texture2D b, TextureMemory c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x854A0C0", Offset = "0x85486C0", VA = "0x18854A0C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GLDZIWPLILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public ManagedTexture CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextureMemory TPWONZHPLGM;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GLDZIWPLILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85485F0", Offset = "0x8546BF0", VA = "0x1885485F0")]
			internal void DWAJUHDYYGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZQYIBSVYBOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int ZGCNXCUCEVX;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZQYIBSVYBOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x854BBB0", Offset = "0x854A1B0", VA = "0x18854BBB0")]
			internal EncodedImage VWPRWCPCQCE(Texture2D a)
			{
				return default(EncodedImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class VBAUPCBRIZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture ZMLQQVJPWKR;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public VBAUPCBRIZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x854BAF0", Offset = "0x854A0F0", VA = "0x18854BAF0")]
			internal void EGRKEAFVRBR()
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
		private NDLOPTUCVYP<Texture2D> XRFRJGSGZNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private QYQRHAOPXKC IFFODOJWOTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NDLOPTUCVYP<EncodedImage> ZZPQHDPGYKX;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NDLOPTUCVYP<EncodedImage> VXLIEVEENNZ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private QYQRHAOPXKC TPVASGNQTPY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x85492F0", Offset = "0x85478F0", VA = "0x1885492F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85498E0", Offset = "0x8547EE0", VA = "0x1885498E0")]
		public ManagedTexture(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8549940", Offset = "0x8547F40", VA = "0x188549940")]
		public ManagedTexture(string name, bool usePalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85490D0", Offset = "0x85476D0", VA = "0x1885490D0")]
		public void QMGXEZQYPPB(RenderTexture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8548B30", Offset = "0x8547130", VA = "0x188548B30")]
		public NDLOPTUCVYP<Texture2D> CFEBYGKGXPK(TextureMemory a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8549110", Offset = "0x8547710", VA = "0x188549110")]
		public NDLOPTUCVYP<EncodedImage> SNLURHZVRPU(bool a = false, int b = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8548E00", Offset = "0x8547400", VA = "0x188548E00")]
		public NDLOPTUCVYP<EncodedImage> DBWPKHVLQBA(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8549390", Offset = "0x8547990", VA = "0x188549390")]
		private static NDLOPTUCVYP<Texture2D> ZKFKCFFKICT(string a, RenderTexture b, Texture2D c, bool d, TextureMemory e = TextureMemory.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8548A90", Offset = "0x8547090", VA = "0x188548A90")]
		public void BHBIYJJBVZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85490C0", Offset = "0x85476C0", VA = "0x1885490C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8549290", Offset = "0x8547890", VA = "0x188549290")]
		[CompilerGenerated]
		private NDLOPTUCVYP<byte[]> WZZBXVJRYDP(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class AAKOZRQTEGI
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct RRTexturePlugin
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x854A2F0", Offset = "0x85488F0", VA = "0x18854A2F0")]
			public unsafe static extern void SubmitPngForCompression(void* pngdata, void* dst, bool mipmap, bool bgr, bool etc2ordxt, [Out] int width, [Out] int height, [Out] bool rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public byte[] QGVXPYEEESQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public bool BKBBRJLOPEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool OOYMXJNBIVR;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x854A150", Offset = "0x8548750", VA = "0x18854A150")]
			internal void RRUVKXYUTAO(NativeArray<byte> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action<NativeArray<byte>> QSSRKPMEOBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public NativeArray<byte> OSEGVSGXZET;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x854BB70", Offset = "0x854A170", VA = "0x18854BB70")]
			internal void KRNGDSPLTQW()
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
			[Cpp2IlInjected.Address(RVA = "0x854AEE0", Offset = "0x85494E0", VA = "0x18854AEE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x854B0F0", Offset = "0x85496F0", VA = "0x18854B0F0", Slot = "5")]
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
			private XMEHEWGCGRP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Texture2D <outputTexture>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x854B160", Offset = "0x8549760", VA = "0x18854B160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x854B7F0", Offset = "0x8549DF0", VA = "0x18854B7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly bool IEJIEHCNYPK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public static bool STPETDUZNHI(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8547D90", Offset = "0x8546390", VA = "0x188547D90")]
		[AsyncStateMachine(typeof(<Compress>d__4))]
		public static Task<Texture2D> DQAAQQXLKYE(byte[] a, bool b = false, bool c = false, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8547ED0", Offset = "0x85464D0", VA = "0x188547ED0")]
		[AsyncStateMachine(typeof(<RunCompressionJob>d__5))]
		private static Task<Texture2D> OTTPOUJYVVO(int a, int b, bool c, bool d, bool e, Action<NativeArray<byte>> compressionAction, CancellationToken f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8548020", Offset = "0x8546620", VA = "0x188548020")]
		private static TextureFormat VHSCAOKSIBR(bool a)
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
	internal static class TFXKOKIXIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x854A9D0", Offset = "0x8548FD0", VA = "0x18854A9D0")]
		public static bool XGUOSNSLXWX(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x854A6F0", Offset = "0x8548CF0", VA = "0x18854A6F0")]
		public static void TGMOBBPQAQS(byte[] a, [Out] int b, [Out] int c, [Out] PNGFormat d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x854A4F0", Offset = "0x8548AF0", VA = "0x18854A4F0")]
		private static uint AKNFBOGIQWB(byte[] a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x854A590", Offset = "0x8548B90", VA = "0x18854A590")]
		private static ulong SMKCCCOFNNQ(byte[] a, int b)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class JNCMPFJCSOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8548630", Offset = "0x8546C30", VA = "0x188548630")]
		public static RenderTexture URHOJHCMYZV(int a, int b, int c, Camera d, RenderTextureMemoryless e = RenderTextureMemoryless.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8548870", Offset = "0x8546E70", VA = "0x188548870")]
		public static void XXEOHVWCJKG(RenderTexture a)
		{
		}
	}
}
namespace RecRoom.Utils.Image.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class HSQTARBAUES<a> : IDisposable where a : notnull, IEquatable<a>
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
			[Cpp2IlInjected.Address(RVA = "0x1B252B0", Offset = "0x1B238B0", VA = "0x181B252B0")]
			public ImageIdAndLoadOptions(a key, TextureLoadOptions loadOptions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x51EA8F0", Offset = "0x51E8EF0", VA = "0x1851EA8F0", Slot = "4")]
			public bool Equals(HSQTARBAUES<a>.ImageIdAndLoadOptions other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x51EA750", Offset = "0x51E8D50", VA = "0x1851EA750", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x51EAC40", Offset = "0x51E9240", VA = "0x1851EAC40", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x51EAEE0", Offset = "0x51E94E0", VA = "0x1851EAEE0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F89A50", Offset = "0x3F88050", VA = "0x183F89A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3F89F00", Offset = "0x3F88500", VA = "0x183F89F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class PMCLZVAKTMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public VKOWOQQTYXQ<Task<Texture2D>> XTXVOXCZFRB;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PMCLZVAKTMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5C86730", Offset = "0x5C84D30", VA = "0x185C86730")]
			internal void IHXGSRGWFSG()
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
			public HSQTARBAUES<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5004230", Offset = "0x5002830", VA = "0x185004230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5004870", Offset = "0x5002E70", VA = "0x185004870", Slot = "5")]
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
			public HSQTARBAUES<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x51F9600", Offset = "0x51F7C00", VA = "0x1851F9600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x51F9E20", Offset = "0x51F8420", VA = "0x1851F9E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int MBNLDLLJDZF = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly SemaphoreSlim RKDAUUGVWTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Func<a, CancellationToken, Task<byte[]>>? KHUWUITMOVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? HYMJZPGQOPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<a, string>? WQXTKIDUEVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly NCYAISNNWQN<ImageIdAndLoadOptions, Texture2D> TDOZHZNTKCR;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5125E10", Offset = "0x5124410", VA = "0x185125E10")]
		public HSQTARBAUES(Func<a, CancellationToken, Task<byte[]>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5125C40", Offset = "0x5124240", VA = "0x185125C40")]
		public HSQTARBAUES(Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5125AD0", Offset = "0x51240D0", VA = "0x185125AD0")]
		private HSQTARBAUES(Func<a, CancellationToken, Task<byte[]>>? getImageFunc, Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? getTextureFunc, Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51245E0", Offset = "0x5122BE0", VA = "0x1851245E0")]
		public XJCVXUISJRI<Texture2D> MPKFVNXTCYQ(a a, TextureLoadOptions b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5124350", Offset = "0x5122950", VA = "0x185124350")]
		public void KASOJRTSMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5124270", Offset = "0x5122870", VA = "0x185124270", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5125570", Offset = "0x5123B70", VA = "0x185125570")]
		[AsyncStateMachine(typeof(HSQTARBAUES<>.<CreateTexture>d__13))]
		private Task<Texture2D> YAQZYWNQRFR(ImageIdAndLoadOptions a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5124E80", Offset = "0x5123480", VA = "0x185124E80")]
		[AsyncStateMachine(typeof(HSQTARBAUES<>.<LoadTexture>d__14))]
		private Task<Texture2D> XPAOUZQNMST(byte[] a, TextureLoadOptions b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x51243E0", Offset = "0x51229E0", VA = "0x1851243E0")]
		private void LADJGXINAJT(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5123E30", Offset = "0x5122430", VA = "0x185123E30")]
		private bool BJHYXOBQZYW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5124B40", Offset = "0x5123140", VA = "0x185124B40")]
		private void OQKAGBAZDGO(byte[] a, [Out] int b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5124320", Offset = "0x5122920", VA = "0x185124320")]
		private bool FLSRFWOUGVS(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5124040", Offset = "0x5122640", VA = "0x185124040")]
		[AsyncStateMachine(typeof(HSQTARBAUES<>.<<GetOrAdd>g__DelayDispose|9_1>d))]
		[CompilerGenerated]
		internal static Task CEYYDRXUMTI(IDisposable a)
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
