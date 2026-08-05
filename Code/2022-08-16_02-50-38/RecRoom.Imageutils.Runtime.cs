using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x58113A0", Offset = "0x580FFA0", VA = "0x1858113A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OEFFELGFIPD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CHCOJIOOOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OEFFELGFIPD HNJAHPBDFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PEBLHEBJGNM
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5814270", Offset = "0x5812E70", VA = "0x185814270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5814260", Offset = "0x5812E60", VA = "0x185814260")]
		public Resolution(uint FPNCCNLMGCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76DD30", Offset = "0x76C930", VA = "0x18076DD30")]
		public Resolution(uint FPNCCNLMGCF, uint JNKDBNBEKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5814110", Offset = "0x5812D10", VA = "0x185814110")]
		public static Resolution KCBGINILOKG(Resolution[] OMJPDNJBEEJ, Resolution KEGFKIMDHGM, int HLDAINIOIMJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FFGOFNPHGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution PMKDFNELMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? IDPKGIGAOFA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FPNCCNLMGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x58113C0", Offset = "0x580FFC0", VA = "0x1858113C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JNKDBNBEKBO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x58115D0", Offset = "0x58101D0", VA = "0x1858115D0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HMGFPHDPGHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x58113D0", Offset = "0x580FFD0", VA = "0x1858113D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x149D8C0", Offset = "0x149C4C0", VA = "0x18149D8C0")]
		public FFGOFNPHGFB(Resolution PMKDFNELMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58115F0", Offset = "0x58101F0", VA = "0x1858115F0")]
		private static Resolution PPCEEFJHNGI(Resolution IDPKGIGAOFA, OEFFELGFIPD BHLGMEIOEKB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PNIINGONIKL
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CBKBBGGHHNI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OAKBPBHLFEG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KDEBLGALPKE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DCFHFGHNAPC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CJDBKBFJCLA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BKICNPFPHNH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] IPOOMKIPHNG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HPADEJCELPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KLEIJIJKNOG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution POGODGDHIDC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution PACOKIPMOKA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MLOFEAPEDFB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution HDKCCEBPINK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] IPOOMKIPHNG;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x58117C0", Offset = "0x58103C0", VA = "0x1858117C0")]
		public static Resolution KMNNFKMCAKD(uint OMHAPPIIDLM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NBFPMMHONKF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5813C60", Offset = "0x5812860", VA = "0x185813C60")]
	public static bool PCFPAGKALAC(uint CLEHMLAHEPL)
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
		public enum PCJPCFOCJIA : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class CCNAPDJOKHN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string AMDKCMALAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FOBNMCBAAGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PCJPCFOCJIA OLCCKPCKFDD;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5811350", Offset = "0x580FF50", VA = "0x185811350")]
			public CCNAPDJOKHN(string AMDKCMALAFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x937160", Offset = "0x935D60", VA = "0x180937160")]
			public CCNAPDJOKHN(string AMDKCMALAFD, Texture2D POPEJKIMBHK, PCJPCFOCJIA BHFJMAFANEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5811310", Offset = "0x580FF10", VA = "0x185811310", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IGJOHFHPJLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PCJPCFOCJIA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public IGJOHFHPJLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5811B60", Offset = "0x5810760", VA = "0x185811B60")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MBOCCOGPDEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public MBOCCOGPDEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5811E10", Offset = "0x5810A10", VA = "0x185811E10")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JPKAJPNFACH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public JPKAJPNFACH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5811D80", Offset = "0x5810980", VA = "0x185811D80")]
			internal void <RenderTextureToTexture2D>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private global::OEKDNOIOMEB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CCNAPDJOKHN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::OEKDNOIOMEB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::OEKDNOIOMEB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x60F7B0", Offset = "0x60E3B0", VA = "0x18060F7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CCNAPDJOKHN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5813BC0", Offset = "0x58127C0", VA = "0x185813BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5813B10", Offset = "0x5812710", VA = "0x185813B10")]
		public ManagedTexture(string AMDKCMALAFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5813B60", Offset = "0x5812760", VA = "0x185813B60")]
		public ManagedTexture(string AMDKCMALAFD, bool KAIPCFOIBHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5813AE0", Offset = "0x58126E0", VA = "0x185813AE0")]
		public void PGAIKGMOHKM(RenderTexture IACMDDLPFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5813AC0", Offset = "0x58126C0", VA = "0x185813AC0")]
		public global::OEKDNOIOMEB<byte[]> OLLKHCNBKNI(bool JIBHINKHPIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5813680", Offset = "0x5812280", VA = "0x185813680")]
		public global::OEKDNOIOMEB<Texture2D> NGCNEMLMJPL(PCJPCFOCJIA BHFJMAFANEE, bool OMFHKJHDLOF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5813910", Offset = "0x5812510", VA = "0x185813910")]
		public global::OEKDNOIOMEB<byte[]> NHKMBMGJGLA(bool OMFHKJHDLOF = false, int DGGLNCONPHP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5812F30", Offset = "0x5811B30", VA = "0x185812F30")]
		public global::OEKDNOIOMEB<byte[]> BOLAJFIOLBD(bool OMFHKJHDLOF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x58130D0", Offset = "0x5811CD0", VA = "0x1858130D0")]
		private static global::OEKDNOIOMEB<Texture2D> JKKPBCNFJJA(string AMDKCMALAFD, RenderTexture IACMDDLPFPA, ref Texture2D AEOLFJFEDEM, bool OMFHKJHDLOF, PCJPCFOCJIA DNDKLDAPMOD = PCJPCFOCJIA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x58135C0", Offset = "0x58121C0", VA = "0x1858135C0")]
		public void JNKBKMOFFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58130C0", Offset = "0x5811CC0", VA = "0x1858130C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5812E90", Offset = "0x5811A90", VA = "0x185812E90")]
		[CompilerGenerated]
		private global::OEKDNOIOMEB<byte[]> ACOKKDDFBLJ(Texture2D FEJLEIMMOGE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JCGNGBEHCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5811BA0", Offset = "0x58107A0", VA = "0x185811BA0")]
	public static RenderTexture BLDKOEENCGD(int OMHAPPIIDLM, int HPMPKHBFKPL, int HGCNCFEGBHG, Camera BIHFDDDEMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5811D10", Offset = "0x5810910", VA = "0x185811D10")]
	public static void DAOLCMBKDLN(RenderTexture IACMDDLPFPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MJJBCFDBEFC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HAFNAGPACCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DJHHNCHEKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int HDGDBPHDMPI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67D350", Offset = "0x67BF50", VA = "0x18067D350")]
		public HAFNAGPACCL(int IPOFGLEPCDG, int NDHKDNBHBLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum PLCNDBOPNDI
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] NEOAKDDJEEN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] NIFGLNPNJFD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int EPICGAFMOJC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float NLCJHDKCDCD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float MIFLNFGEHKL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int BBJCHOJDGGC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PGGBJDLBOHM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JIBFLIKKPHO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5812C90", Offset = "0x5811890", VA = "0x185812C90")]
	public static void KPCGLGJCNNI(Texture2D PKKDBCGOOOM, int PLDBMNIPJHA, int CDONCFDAGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x58127E0", Offset = "0x58113E0", VA = "0x1858127E0")]
	private static void HDPDJHELAND(Texture2D PKKDBCGOOOM, int PLDBMNIPJHA, int CDONCFDAGOK, PLCNDBOPNDI BKELFKBKEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5811E30", Offset = "0x5810A30", VA = "0x185811E30")]
	public static void AALNGFIGEEK(object HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5812CB0", Offset = "0x58118B0", VA = "0x185812CB0")]
	public static void OJGFEIHHNCP(object HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5812440", Offset = "0x5811040", VA = "0x185812440")]
	private static Color EKMJDCDHCLL(int FPNCCNLMGCF, int JNKDBNBEKBO, float NLCJHDKCDCD, float MIFLNFGEHKL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5812600", Offset = "0x5811200", VA = "0x185812600")]
	public static void GCGMNKNPJEE(object HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5812350", Offset = "0x5810F50", VA = "0x185812350")]
	private static Color EGDKIBIANEC(Color FJGAGNMLLEL, Color FLDKOKHODFC, float PDMPLJICJLE)
	{
		return default(Color);
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
