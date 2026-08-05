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
		[Cpp2IlInjected.Address(RVA = "0x4D8D430", Offset = "0x4D8C830", VA = "0x184D8D430")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum COEAMEMCGPO
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
public interface DHJNGELJFEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	COEAMEMCGPO CKNNIEGBMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NKFPADEBGBH
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
			[Cpp2IlInjected.Address(RVA = "0x4D901B0", Offset = "0x4D8F5B0", VA = "0x184D901B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D901A0", Offset = "0x4D8F5A0", VA = "0x184D901A0")]
		public Resolution(uint JEPLLBBBDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x708110", Offset = "0x707510", VA = "0x180708110")]
		public Resolution(uint JEPLLBBBDFO, uint BDJKNLLCOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D90050", Offset = "0x4D8F450", VA = "0x184D90050")]
		public static Resolution FNBKKFNINMD(Resolution[] GNJPEHAMCGM, Resolution BKBFMCEPEJP, int KOPCDGBDPHJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JDJPCELOLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution KGGPLKJADPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? HHKOJIIIFHA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JEPLLBBBDFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E580", Offset = "0x4D8D980", VA = "0x184D8E580")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint BDJKNLLCOBO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E760", Offset = "0x4D8DB60", VA = "0x184D8E760")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution MKEPOFKLGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E780", Offset = "0x4D8DB80", VA = "0x184D8E780")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xECD970", Offset = "0xECCD70", VA = "0x180ECD970")]
		public JDJPCELOLDD(Resolution KGGPLKJADPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E590", Offset = "0x4D8D990", VA = "0x184D8E590")]
		private static Resolution IMKEADPMFOL(Resolution HHKOJIIIFHA, COEAMEMCGPO DAEECHCLHHD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NEEBAOCAEEK
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LKMEGJBKBBP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OLFIAOCDGFN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ANFKOEIEGIA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DEFBPIPJHKB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JEMEPJILIAG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CBHKGBKIILG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] CFPPLIPECEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PLBACBFFECG
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OMBOJLOPMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution AFCKLIJOCGL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BKADFMKEBAO;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NBAKMLGMENN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution DABBCHKAGPE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] CFPPLIPECEM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FCB0", Offset = "0x4D8F0B0", VA = "0x184D8FCB0")]
		public static Resolution MDMLKFFNELK(uint PGJMBKLMNBH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution AJPMOGBNBCJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D8FA70", Offset = "0x4D8EE70", VA = "0x184D8FA70")]
	public static bool FPMBDKBKBEP(uint DKKKKHBOGOG)
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
		public enum PHENOMOBIBD : byte
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
		private class KONKECHCDEG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string AFIDHHDMHNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LCDCHBMEBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PHENOMOBIBD MOFOEHPEKID;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E9E0", Offset = "0x4D8DDE0", VA = "0x184D8E9E0")]
			public KONKECHCDEG(string AFIDHHDMHNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8C3290", Offset = "0x8C2690", VA = "0x1808C3290")]
			public KONKECHCDEG(string AFIDHHDMHNB, Texture2D BCGEPGAJLGB, PHENOMOBIBD JNCIMGALNKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E9A0", Offset = "0x4D8DDA0", VA = "0x184D8E9A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ECMDBPBJCPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PHENOMOBIBD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public ECMDBPBJCPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D450", Offset = "0x4D8C850", VA = "0x184D8D450")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JHMEEHBIKBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public JHMEEHBIKBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E980", Offset = "0x4D8DD80", VA = "0x184D8E980")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IOBKMLKMEIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public IOBKMLKMEIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E4F0", Offset = "0x4D8D8F0", VA = "0x184D8E4F0")]
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
		private global::OIKEDAHIDPO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KONKECHCDEG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::OIKEDAHIDPO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::OIKEDAHIDPO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x57D7B0", Offset = "0x57CBB0", VA = "0x18057D7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KONKECHCDEG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F760", Offset = "0x4D8EB60", VA = "0x184D8F760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F6B0", Offset = "0x4D8EAB0", VA = "0x184D8F6B0")]
		public ManagedTexture(string AFIDHHDMHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F700", Offset = "0x4D8EB00", VA = "0x184D8F700")]
		public ManagedTexture(string AFIDHHDMHNB, bool FCFPHOKDMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F680", Offset = "0x4D8EA80", VA = "0x184D8F680")]
		public void NLEKBOMKNLK(RenderTexture LPFBNIKMKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F660", Offset = "0x4D8EA60", VA = "0x184D8F660")]
		public global::OIKEDAHIDPO<byte[]> IDLGOKKAGFD(bool EPMLILILGLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EAF0", Offset = "0x4D8DEF0", VA = "0x184D8EAF0")]
		public global::OIKEDAHIDPO<Texture2D> CPKPCPKELKI(PHENOMOBIBD JNCIMGALNKK, bool HKAMFLLKLGG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EF20", Offset = "0x4D8E320", VA = "0x184D8EF20")]
		public global::OIKEDAHIDPO<byte[]> EKGBMEHJLKN(bool HKAMFLLKLGG = false, int FBKAEGJPAIM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8ED80", Offset = "0x4D8E180", VA = "0x184D8ED80")]
		public global::OIKEDAHIDPO<byte[]> DBILHMPHMEF(bool HKAMFLLKLGG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F0D0", Offset = "0x4D8E4D0", VA = "0x184D8F0D0")]
		private static global::OIKEDAHIDPO<Texture2D> FHKJNHFGAFF(string AFIDHHDMHNB, RenderTexture LPFBNIKMKHL, ref Texture2D DHCGFAFIJEK, bool HKAMFLLKLGG, PHENOMOBIBD EACJOEOHOEI = PHENOMOBIBD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EA30", Offset = "0x4D8DE30", VA = "0x184D8EA30")]
		public void BNECBFFFNFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EF10", Offset = "0x4D8E310", VA = "0x184D8EF10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F5C0", Offset = "0x4D8E9C0", VA = "0x184D8F5C0")]
		[CompilerGenerated]
		private global::OIKEDAHIDPO<byte[]> GHHOAKLNGPH(Texture2D PPAMGLFMBGK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AMBPABGDHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D2C0", Offset = "0x4D8C6C0", VA = "0x184D8D2C0")]
	public static RenderTexture MJMLODDPJIG(int PGJMBKLMNBH, int FBPGHOCBINA, int BDNGLGIDOEC, Camera ODFLFEENJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D250", Offset = "0x4D8C650", VA = "0x184D8D250")]
	public static void MFHDEKEDMCC(RenderTexture LPFBNIKMKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GEKHJHIJLNN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BPDOMDFGNOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int KAGIKHONMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int MEEFFGBBAJM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EB350", Offset = "0x5EA750", VA = "0x1805EB350")]
		public BPDOMDFGNOE(int FBDAAAJCJMJ, int OCJJHJBGOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum GMIJEBAIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] IOBHMAAKMNE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] PMIGENHNDOM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int OKFCFKIHJCI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float GKEOEKKELBE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float KODIOFOAING;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EBBLPJIBJIB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int FCCJPKIJEHK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex IJGALIILEEC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D490", Offset = "0x4D8C890", VA = "0x184D8D490")]
	public static void FHDJPMFNLEN(Texture2D CJLKBGAJBAM, int OALHBKHFPDA, int PHKIHGGLKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D850", Offset = "0x4D8CC50", VA = "0x184D8D850")]
	private static void IGJBAJNPKNN(Texture2D CJLKBGAJBAM, int OALHBKHFPDA, int PHKIHGGLKCA, GMIJEBAIFJO PHHPNEPFEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DFD0", Offset = "0x4D8D3D0", VA = "0x184D8DFD0")]
	public static void PIGECENLMHJ(object CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D670", Offset = "0x4D8CA70", VA = "0x184D8D670")]
	public static void HEMMKMNMNEM(object CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D4B0", Offset = "0x4D8C8B0", VA = "0x184D8D4B0")]
	private static Color GKMKPEFMOHP(int JEPLLBBBDFO, int BDJKNLLCOBO, float GKEOEKKELBE, float KODIOFOAING)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DDF0", Offset = "0x4D8D1F0", VA = "0x184D8DDF0")]
	public static void PBGGBADPJKM(object CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DD00", Offset = "0x4D8D100", VA = "0x184D8DD00")]
	private static Color ONBNMNJLHHM(Color FBOKEEMFBJL, Color AKPJGNCODAA, float MGNFAPLJAOB)
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
