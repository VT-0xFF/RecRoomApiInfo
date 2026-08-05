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
		[Cpp2IlInjected.Address(RVA = "0x1E8E420", Offset = "0x1E8CC20", VA = "0x181E8E420")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CDDMLCOPGGH
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
public interface JKOBGGFKIKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CDDMLCOPGGH HJEIHKKIFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GGACMCNNMPG
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
			[Cpp2IlInjected.Address(RVA = "0x1E90FE0", Offset = "0x1E8F7E0", VA = "0x181E90FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E90FD0", Offset = "0x1E8F7D0", VA = "0x181E90FD0")]
		public Resolution(uint ODLLFOGPPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E5420", Offset = "0x7E3C20", VA = "0x1807E5420")]
		public Resolution(uint ODLLFOGPPIE, uint GJCOJHOFJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E90EE0", Offset = "0x1E8F6E0", VA = "0x181E90EE0")]
		public static Resolution EOAOHCDAANM(Resolution[] BAOJAINPKFH, Resolution JDCIPJMCLNE, int MBJKLPKHFJO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ILGDLLOCMLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution FNPLIOEKIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? MEFGPNHDLKG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint ODLLFOGPPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1E8EF40", Offset = "0x1E8D740", VA = "0x181E8EF40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GJCOJHOFJLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E8ED40", Offset = "0x1E8D540", VA = "0x181E8ED40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution CJEGKEAOCAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1E8ED60", Offset = "0x1E8D560", VA = "0x181E8ED60")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1C79C50", Offset = "0x1C78450", VA = "0x181C79C50")]
		public ILGDLLOCMLC(Resolution FNPLIOEKIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E8EBA0", Offset = "0x1E8D3A0", VA = "0x181E8EBA0")]
		private static Resolution CFDBDNDAOAM(Resolution MEFGPNHDLKG, CDDMLCOPGGH ENCHKNMDNFF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FDNOBNKMGGH
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LGKNGLBEENI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DODFLCIKPJC;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BMMLHPBHAMH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution IMLGNODJEDH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CJHHBALJBIG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution GOLOGKGJCFP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MIPDCJDKBLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CBMIFAHBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AHKNEHEDMEP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution MCCAJNHPDDM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CPKPGBACNAN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution GGEMOIGGOGF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FMPBOOLIOHE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MIPDCJDKBLA;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E8E060", Offset = "0x1E8C860", VA = "0x181E8E060")]
		public static Resolution MGBKCIIMPAK(uint BHAMBKDMALL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution MNANGIIEMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E8E720", Offset = "0x1E8CF20", VA = "0x181E8E720")]
	public static bool HCGCIOIAKFD(uint AOJFMDBLAAC)
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
		public enum HAFHDEFJNBM : byte
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
		private class MMFEJCICOJN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string FOGNBJMCDMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EEMPPLHGOCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HAFHDEFJNBM KANFIMKPEJA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E8FF40", Offset = "0x1E8E740", VA = "0x181E8FF40")]
			public MMFEJCICOJN(string FOGNBJMCDMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85E230", Offset = "0x85CA30", VA = "0x18085E230")]
			public MMFEJCICOJN(string FOGNBJMCDMG, Texture2D EJPBFKOIJKE, HAFHDEFJNBM BDDDNHADBME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E8FF00", Offset = "0x1E8E700", VA = "0x181E8FF00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EMALHAHHGPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HAFHDEFJNBM textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public EMALHAHHGPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E8E440", Offset = "0x1E8CC40", VA = "0x181E8E440")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FLOCDEKGGKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public FLOCDEKGGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E8E700", Offset = "0x1E8CF00", VA = "0x181E8E700")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AHFJGLELNJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public AHFJGLELNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E8DFD0", Offset = "0x1E8C7D0", VA = "0x181E8DFD0")]
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
		private global::AGDEEHNAPKP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MMFEJCICOJN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::AGDEEHNAPKP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::AGDEEHNAPKP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F8740", Offset = "0x6F6F40", VA = "0x1806F8740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MMFEJCICOJN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1E90E40", Offset = "0x1E8F640", VA = "0x181E90E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E90DF0", Offset = "0x1E8F5F0", VA = "0x181E90DF0")]
		public ManagedTexture(string FOGNBJMCDMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1E90D90", Offset = "0x1E8F590", VA = "0x181E90D90")]
		public ManagedTexture(string FOGNBJMCDMG, bool INLFLKDLHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E90A70", Offset = "0x1E8F270", VA = "0x181E90A70")]
		public void KHOKHPFKEIB(RenderTexture ODOFOGGBBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E904D0", Offset = "0x1E8ECD0", VA = "0x181E904D0")]
		public global::AGDEEHNAPKP<byte[]> ICAKKBFIAEJ(bool MKNEBMMIDCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E90AA0", Offset = "0x1E8F2A0", VA = "0x181E90AA0")]
		public global::AGDEEHNAPKP<Texture2D> PBPHOHDCFHP(HAFHDEFJNBM BDDDNHADBME, bool PDJICNCHDAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E90220", Offset = "0x1E8EA20", VA = "0x181E90220")]
		public global::AGDEEHNAPKP<byte[]> EFIBMIKHLLJ(bool PDJICNCHDAD = false, int CMMMNIJPOKP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E90050", Offset = "0x1E8E850", VA = "0x181E90050")]
		public global::AGDEEHNAPKP<byte[]> CMKPDHBHPJH(bool PDJICNCHDAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E904F0", Offset = "0x1E8ECF0", VA = "0x181E904F0")]
		private static global::AGDEEHNAPKP<Texture2D> IJLDAHOLGLM(string FOGNBJMCDMG, RenderTexture ODOFOGGBBAF, ref Texture2D FMEOCGCLKFD, bool PDJICNCHDAD, HAFHDEFJNBM KOHNAPBADNI = HAFHDEFJNBM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E8FF90", Offset = "0x1E8E790", VA = "0x181E8FF90")]
		public void CEFICCEBPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E90210", Offset = "0x1E8EA10", VA = "0x181E90210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E90420", Offset = "0x1E8EC20", VA = "0x181E90420")]
		[CompilerGenerated]
		private global::AGDEEHNAPKP<byte[]> HAEIJBHOGPL(Texture2D GMGDFJKIPDB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HMJJPKEDGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E8E9F0", Offset = "0x1E8D1F0", VA = "0x181E8E9F0")]
	public static RenderTexture JICPFBLPFIL(int BHAMBKDMALL, int PEJBJHOOMHE, int FOCIGJDPHHB, Camera MIOPMJGGEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E8E980", Offset = "0x1E8D180", VA = "0x181E8E980")]
	public static void COOLFBDGMML(RenderTexture ODOFOGGBBAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KBAAJNDJHEC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BFOHOHNHAEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int OMKHMNIPPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BDPJJHLGMOK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x929C90", Offset = "0x928490", VA = "0x180929C90")]
		public BFOHOHNHAEC(int OLNLINPGBEI, int GHAPGMJOMOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum LLABINLHAIM
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] KGPIGGHJOGN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] CIKGHNMPPLK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int NOMPHPBFLNE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PKGHMOBKEEI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float CBAALKDOFLP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MOAMPAMPEBF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HBGGDJJGHJE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex BIIFPDJOAIK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E8F820", Offset = "0x1E8E020", VA = "0x181E8F820")]
	public static void GABBFHGDPFL(Texture2D EOAPCNKMEII, int PPKBBALEJKP, int BGNFAKGNIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E8F840", Offset = "0x1E8E040", VA = "0x181E8F840")]
	private static void GJAFNMLLOFN(Texture2D EOAPCNKMEII, int PPKBBALEJKP, int BGNFAKGNIFM, LLABINLHAIM KLICPGCIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E8F1D0", Offset = "0x1E8D9D0", VA = "0x181E8F1D0")]
	public static void DCIDHHEGNLD(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E8F650", Offset = "0x1E8DE50", VA = "0x181E8F650")]
	public static void DFMCCDJPDEJ(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E8EF50", Offset = "0x1E8D750", VA = "0x181E8EF50")]
	private static Color BBADDKEBKHO(int ODLLFOGPPIE, int GJCOJHOFJLD, float PKGHMOBKEEI, float CBAALKDOFLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1E8FD30", Offset = "0x1E8E530", VA = "0x181E8FD30")]
	public static void OFGPOAHADCJ(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E8F0F0", Offset = "0x1E8D8F0", VA = "0x181E8F0F0")]
	private static Color DABDLMGMBEK(Color FMOIFLNEEHL, Color ANCKALICGNG, float CCIMHDCKHOF)
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
