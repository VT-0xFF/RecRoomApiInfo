using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LJIKGCKODMH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C980", Offset = "0x6F4BB80", VA = "0x186F4C980")]
	public static RenderTexture MNCMIOFDJGC(int CEBEKFANDMD, int CPPKAEGLEMG, int NIEBCEEAAGL, Camera PJMJFDBNPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C910", Offset = "0x6F4BB10", VA = "0x186F4C910")]
	public static void KCPKGGJLAOB(RenderTexture CCLKBFGIIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KHEKOHLGPMC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MLMCOPPCJMP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KHEKOHLGPMC CFPMMFCDBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HGLAIGJHIPA
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6F4DC70", Offset = "0x6F4CE70", VA = "0x186F4DC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DC60", Offset = "0x6F4CE60", VA = "0x186F4DC60")]
		public Resolution(uint JPBGAMDOIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
		public Resolution(uint JPBGAMDOIJA, uint IIJHAMIHIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DB70", Offset = "0x6F4CD70", VA = "0x186F4DB70")]
		public static Resolution BCNLOPJLHFI(Resolution[] CPPBBBCKIMF, Resolution PPJADOKLJBF, int FCJHCLKHCBD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BDIPKHMJMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Resolution HGOCOFFHPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Resolution? NNAAMBIPBBJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JPBGAMDOIJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C520", Offset = "0x6F4B720", VA = "0x186F4C520")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint IIJHAMIHIMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C320", Offset = "0x6F4B520", VA = "0x186F4C320")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FDOEGNILLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C340", Offset = "0x6F4B540", VA = "0x186F4C340")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF98640", Offset = "0xF97840", VA = "0x180F98640")]
		public BDIPKHMJMKH(Resolution HGOCOFFHPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C180", Offset = "0x6F4B380", VA = "0x186F4C180")]
		private static Resolution DEHEIIILKAB(Resolution NNAAMBIPBBJ, KHEKOHLGPMC ENPHHILIGLK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BBHOHHOBBFN
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution HNPANAPCIGC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution LHKAGODNMEE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BFPFHBJLAKC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BJJFKMCBEFL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PIKIJMKFDLI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FMOPPBNNFKB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static readonly Resolution[] GHDPPGHPJLD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class AGMODBNBICE
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DEJAJLDJPJP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NFOLDAFMPIF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HPKBFNAFNHI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DJBALALODPJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LIEBNENPLDL;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static readonly Resolution[] GHDPPGHPJLD;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BB20", Offset = "0x6F4AD20", VA = "0x186F4BB20")]
		public static Resolution PHGBCLIOEMG(uint CEBEKFANDMD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Resolution JOLFGCBAOEL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C620", Offset = "0x6F4B820", VA = "0x186F4C620")]
	public static bool MJONFNPBOCI(uint ONDBANNKCON)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[Flags]
		public enum MPFDKNKLKAE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class KDCIAHILOEO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private string JPKENOAMLIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Texture2D NAADNIBECNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public MPFDKNKLKAE EJGODMHNHDN;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C8C0", Offset = "0x6F4BAC0", VA = "0x186F4C8C0")]
			public KDCIAHILOEO(string JPKENOAMLIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2EEE2A0", Offset = "0x2EED4A0", VA = "0x182EEE2A0")]
			public KDCIAHILOEO(string JPKENOAMLIN, Texture2D BNHKLKELIKA, MPFDKNKLKAE EHLECDEHJFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C880", Offset = "0x6F4BA80", VA = "0x186F4C880", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GKMMKFPOBAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MPFDKNKLKAE textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public GKMMKFPOBAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C5E0", Offset = "0x6F4B7E0", VA = "0x186F4C5E0")]
			internal void PHJMEPJIINL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class APLALOCHLEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public APLALOCHLEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F4BEE0", Offset = "0x6F4B0E0", VA = "0x186F4BEE0")]
			internal byte[] BDKINGFIHEJ(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CMOGJHFPKBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public CMOGJHFPKBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C530", Offset = "0x6F4B730", VA = "0x186F4C530")]
			internal void AJCGIKHPLKK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OOMFLHAHLDK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private KDCIAHILOEO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OOMFLHAHLDK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OOMFLHAHLDK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KDCIAHILOEO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F4DAD0", Offset = "0x6F4CCD0", VA = "0x186F4DAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA20", Offset = "0x6F4CC20", VA = "0x186F4DA20")]
		public ManagedTexture(string JPKENOAMLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D960", Offset = "0x6F4CB60", VA = "0x186F4D960")]
		public ManagedTexture(string JPKENOAMLIN, bool JEBKIDJBLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D450", Offset = "0x6F4C650", VA = "0x186F4D450")]
		public void FOPCBOBHCMC(RenderTexture CCLKBFGIIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CB30", Offset = "0x6F4BD30", VA = "0x186F4CB30")]
		public OOMFLHAHLDK<byte[]> BIJDAMOBMLO(bool CGHPKPDMOKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D480", Offset = "0x6F4C680", VA = "0x186F4D480")]
		public OOMFLHAHLDK<Texture2D> IOFHCKKABMH(MPFDKNKLKAE EHLECDEHJFJ, bool BLICOCBDAEJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D760", Offset = "0x6F4C960", VA = "0x186F4D760")]
		public OOMFLHAHLDK<byte[]> KHOIEMAMLKD(bool BLICOCBDAEJ = false, int EPCJNFAFNEB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CB60", Offset = "0x6F4BD60", VA = "0x186F4CB60")]
		public OOMFLHAHLDK<byte[]> CEKDAGLDGAH(bool BLICOCBDAEJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD20", Offset = "0x6F4BF20", VA = "0x186F4CD20")]
		private static OOMFLHAHLDK<Texture2D> CHCPLEFEAGI(string JPKENOAMLIN, RenderTexture CCLKBFGIIGK, ref Texture2D KNCCCKMIMIH, bool BLICOCBDAEJ, MPFDKNKLKAE NIIBGKDFJOD = MPFDKNKLKAE.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D390", Offset = "0x6F4C590", VA = "0x186F4D390")]
		public void EMIDGIOFDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D380", Offset = "0x6F4C580", VA = "0x186F4D380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D2D0", Offset = "0x6F4C4D0", VA = "0x186F4D2D0")]
		[CompilerGenerated]
		private OOMFLHAHLDK<byte[]> CJLOPFEAAGH(Texture2D ILJGMLADNJD)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C5C0", Offset = "0x6F4B7C0", VA = "0x186F4C5C0")]
		public CubeMapGenerator()
		{
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
