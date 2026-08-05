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
		[Cpp2IlInjected.Address(RVA = "0x5E10040", Offset = "0x5E0F040", VA = "0x185E10040")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E12C00", Offset = "0x5E11C00", VA = "0x185E12C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E12BF0", Offset = "0x5E11BF0", VA = "0x185E12BF0")]
		public Resolution(uint ODLLFOGPPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
		public Resolution(uint ODLLFOGPPIE, uint GJCOJHOFJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E12B00", Offset = "0x5E11B00", VA = "0x185E12B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E10B60", Offset = "0x5E0FB60", VA = "0x185E10B60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GJCOJHOFJLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E10960", Offset = "0x5E0F960", VA = "0x185E10960")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution CJEGKEAOCAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E10980", Offset = "0x5E0F980", VA = "0x185E10980")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1218CD0", Offset = "0x1217CD0", VA = "0x181218CD0")]
		public ILGDLLOCMLC(Resolution FNPLIOEKIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E107C0", Offset = "0x5E0F7C0", VA = "0x185E107C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E0FC80", Offset = "0x5E0EC80", VA = "0x185E0FC80")]
		public static Resolution MGBKCIIMPAK(uint BHAMBKDMALL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution MNANGIIEMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E10340", Offset = "0x5E0F340", VA = "0x185E10340")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E11B60", Offset = "0x5E10B60", VA = "0x185E11B60")]
			public MMFEJCICOJN(string FOGNBJMCDMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x650750", Offset = "0x64F750", VA = "0x180650750")]
			public MMFEJCICOJN(string FOGNBJMCDMG, Texture2D EJPBFKOIJKE, HAFHDEFJNBM BDDDNHADBME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E11B20", Offset = "0x5E10B20", VA = "0x185E11B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public EMALHAHHGPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E10060", Offset = "0x5E0F060", VA = "0x185E10060")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public FLOCDEKGGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E10320", Offset = "0x5E0F320", VA = "0x185E10320")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public AHFJGLELNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E0FBF0", Offset = "0x5E0EBF0", VA = "0x185E0FBF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MMFEJCICOJN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E12A60", Offset = "0x5E11A60", VA = "0x185E12A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E12A10", Offset = "0x5E11A10", VA = "0x185E12A10")]
		public ManagedTexture(string FOGNBJMCDMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E129B0", Offset = "0x5E119B0", VA = "0x185E129B0")]
		public ManagedTexture(string FOGNBJMCDMG, bool INLFLKDLHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E12690", Offset = "0x5E11690", VA = "0x185E12690")]
		public void KHOKHPFKEIB(RenderTexture ODOFOGGBBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E120F0", Offset = "0x5E110F0", VA = "0x185E120F0")]
		public global::AGDEEHNAPKP<byte[]> ICAKKBFIAEJ(bool MKNEBMMIDCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E126C0", Offset = "0x5E116C0", VA = "0x185E126C0")]
		public global::AGDEEHNAPKP<Texture2D> PBPHOHDCFHP(HAFHDEFJNBM BDDDNHADBME, bool PDJICNCHDAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E11E40", Offset = "0x5E10E40", VA = "0x185E11E40")]
		public global::AGDEEHNAPKP<byte[]> EFIBMIKHLLJ(bool PDJICNCHDAD = false, int CMMMNIJPOKP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E11C70", Offset = "0x5E10C70", VA = "0x185E11C70")]
		public global::AGDEEHNAPKP<byte[]> CMKPDHBHPJH(bool PDJICNCHDAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E12110", Offset = "0x5E11110", VA = "0x185E12110")]
		private static global::AGDEEHNAPKP<Texture2D> IJLDAHOLGLM(string FOGNBJMCDMG, RenderTexture ODOFOGGBBAF, ref Texture2D FMEOCGCLKFD, bool PDJICNCHDAD, HAFHDEFJNBM KOHNAPBADNI = HAFHDEFJNBM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E11BB0", Offset = "0x5E10BB0", VA = "0x185E11BB0")]
		public void CEFICCEBPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E11E30", Offset = "0x5E10E30", VA = "0x185E11E30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E12040", Offset = "0x5E11040", VA = "0x185E12040")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E10610", Offset = "0x5E0F610", VA = "0x185E10610")]
	public static RenderTexture JICPFBLPFIL(int BHAMBKDMALL, int PEJBJHOOMHE, int FOCIGJDPHHB, Camera MIOPMJGGEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E105A0", Offset = "0x5E0F5A0", VA = "0x185E105A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8C9D70", VA = "0x1808CAD70")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E11440", Offset = "0x5E10440", VA = "0x185E11440")]
	public static void GABBFHGDPFL(Texture2D EOAPCNKMEII, int PPKBBALEJKP, int BGNFAKGNIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E11460", Offset = "0x5E10460", VA = "0x185E11460")]
	private static void GJAFNMLLOFN(Texture2D EOAPCNKMEII, int PPKBBALEJKP, int BGNFAKGNIFM, LLABINLHAIM KLICPGCIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E10DF0", Offset = "0x5E0FDF0", VA = "0x185E10DF0")]
	public static void DCIDHHEGNLD(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E11270", Offset = "0x5E10270", VA = "0x185E11270")]
	public static void DFMCCDJPDEJ(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E10B70", Offset = "0x5E0FB70", VA = "0x185E10B70")]
	private static Color BBADDKEBKHO(int ODLLFOGPPIE, int GJCOJHOFJLD, float PKGHMOBKEEI, float CBAALKDOFLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E11950", Offset = "0x5E10950", VA = "0x185E11950")]
	public static void OFGPOAHADCJ(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E10D10", Offset = "0x5E0FD10", VA = "0x185E10D10")]
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
