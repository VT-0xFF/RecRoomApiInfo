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
		[Cpp2IlInjected.Address(RVA = "0x6075E70", Offset = "0x6075270", VA = "0x186075E70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DOEDHJPDEML
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
public interface GNDIPKBGEIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DOEDHJPDEML DKGCGFPOGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NJGEEPDHDOI
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
			[Cpp2IlInjected.Address(RVA = "0x6078E80", Offset = "0x6078280", VA = "0x186078E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6078E70", Offset = "0x6078270", VA = "0x186078E70")]
		public Resolution(uint BCJCIOLMPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
		public Resolution(uint BCJCIOLMPPL, uint OIPENDMCMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6078D80", Offset = "0x6078180", VA = "0x186078D80")]
		public static Resolution BPHINFJMILJ(Resolution[] GBMKHELIDIF, Resolution KGFPIIHKFID, int DCJFGAJGLPA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NCJFAKFDKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution LAIHBDGGECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GGPGPODDIMA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint BCJCIOLMPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6078870", Offset = "0x6077C70", VA = "0x186078870")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint OIPENDMCMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60786B0", Offset = "0x6077AB0", VA = "0x1860786B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution CFBOJBOBLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x60784D0", Offset = "0x60778D0", VA = "0x1860784D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xFF51C0", Offset = "0xFF45C0", VA = "0x180FF51C0")]
		public NCJFAKFDKDA(Resolution LAIHBDGGECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60786D0", Offset = "0x6077AD0", VA = "0x1860786D0")]
		private static Resolution GIDBDDOFMAK(Resolution GGPGPODDIMA, DOEDHJPDEML JJBILGBKMJJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OBBEPHOPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution ADFCBLMONMF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution LFOHNPLENFF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ECLLJMDALEB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution JHIFOKMNHMB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FOCNKJOBMPF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NEBAJFHFIHB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] EFEPGGOGOLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EACIDCALAHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ADOMIECODNH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JBPGOJBOPGK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IFPFMHKBKHA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution KHDDKOFKDPO;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution EHLEHNCMKFM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] EFEPGGOGOLJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6075E90", Offset = "0x6075290", VA = "0x186075E90")]
		public static Resolution GNFJAECEEBN(uint HGELIJGMFCF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution GGEMGCNPAIA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6078880", Offset = "0x6077C80", VA = "0x186078880")]
	public static bool DIJBHOIDDLL(uint JAIICCOOOLF)
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
		public enum KIEINNNJPLG : byte
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
		private class EPKLKNKCLMG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DHKKANIEGMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D MCBMGDOBDIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KIEINNNJPLG FJFELPGBJAC;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6076290", Offset = "0x6075690", VA = "0x186076290")]
			public EPKLKNKCLMG(string DHKKANIEGMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67E750", Offset = "0x67DB50", VA = "0x18067E750")]
			public EPKLKNKCLMG(string DHKKANIEGMN, Texture2D IMDBAPGJGAJ, KIEINNNJPLG KGMIPALNAMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6076250", Offset = "0x6075650", VA = "0x186076250", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KCIHJPFEMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KIEINNNJPLG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public KCIHJPFEMBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6076590", Offset = "0x6075990", VA = "0x186076590")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OBFGMDIDPOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public OBFGMDIDPOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6078D60", Offset = "0x6078160", VA = "0x186078D60")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JJHPBEMJDDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public JJHPBEMJDDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6076500", Offset = "0x6075900", VA = "0x186076500")]
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
		private global::JENPMPFICOP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EPKLKNKCLMG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::JENPMPFICOP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::JENPMPFICOP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67C250", Offset = "0x67B650", VA = "0x18067C250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EPKLKNKCLMG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6078430", Offset = "0x6077830", VA = "0x186078430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60783E0", Offset = "0x60777E0", VA = "0x1860783E0")]
		public ManagedTexture(string DHKKANIEGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6078380", Offset = "0x6077780", VA = "0x186078380")]
		public ManagedTexture(string DHKKANIEGMN, bool NBDABAOMDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6078060", Offset = "0x6077460", VA = "0x186078060")]
		public void OGJNAOIKEKL(RenderTexture GHHBMJDAPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6077580", Offset = "0x6076980", VA = "0x186077580")]
		public global::JENPMPFICOP<byte[]> CBIGBAFOKGD(bool ABDBMBCFJGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6078090", Offset = "0x6077490", VA = "0x186078090")]
		public global::JENPMPFICOP<Texture2D> PCHCIFANBCK(KIEINNNJPLG KGMIPALNAMG, bool INBNBCJDELK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6077720", Offset = "0x6076B20", VA = "0x186077720")]
		public global::JENPMPFICOP<byte[]> KKLIDODCJMG(bool INBNBCJDELK = false, int FOBEIJLIMGH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6077920", Offset = "0x6076D20", VA = "0x186077920")]
		public global::JENPMPFICOP<byte[]> LELFNCEMBMB(bool INBNBCJDELK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6077AE0", Offset = "0x6076EE0", VA = "0x186077AE0")]
		private static global::JENPMPFICOP<Texture2D> LNCCOOAGCFG(string DHKKANIEGMN, RenderTexture GHHBMJDAPIB, ref Texture2D HHBDLAKACDF, bool INBNBCJDELK, KIEINNNJPLG MABNCCFNFFB = KIEINNNJPLG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6077660", Offset = "0x6076A60", VA = "0x186077660")]
		public void ECKEDBCCGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6077650", Offset = "0x6076A50", VA = "0x186077650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60775A0", Offset = "0x60769A0", VA = "0x1860775A0")]
		[CompilerGenerated]
		private global::JENPMPFICOP<byte[]> CDJHPMONPAD(Texture2D HCFLBJHLIBP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HFNGKEMHPLC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6076350", Offset = "0x6075750", VA = "0x186076350")]
	public static RenderTexture EPFNFDJKLDD(int HGELIJGMFCF, int INLFDHDPLNM, int FGINFGKNAGK, Camera PAJHIMKHGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60762E0", Offset = "0x60756E0", VA = "0x1860762E0")]
	public static void ECEMFCKMEDP(RenderTexture GHHBMJDAPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MKHMIDLEAIB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JBFENFKNIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int BKLFOLNGODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int AJIMECHHNCA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2F0", Offset = "0x8DD6F0", VA = "0x1808DE2F0")]
		public JBFENFKNIEK(int JLNFONKAKOG, int PNJNNEOHMAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum KOJDHKKJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GNDJHANINKN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] DMAHLEHCFDF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int NBBEJJDNGHM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float AIHDNNBLDEA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float EKIMHMPAMNE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int KAGPGMMMHGL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int JNDIAKDFKCK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex EBDBEBKKKCO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6077390", Offset = "0x6076790", VA = "0x186077390")]
	public static void OPNPBBJFPFH(Texture2D HGENBGABKJC, int JMDHDELJCBF, int ADIFDBOPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60765D0", Offset = "0x60759D0", VA = "0x1860765D0")]
	private static void CNMPJBPGHPO(Texture2D HGENBGABKJC, int JMDHDELJCBF, int ADIFDBOPFCA, KOJDHKKJNPG ABOMHDGKLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6076F10", Offset = "0x6076310", VA = "0x186076F10")]
	public static void OGMMGHCNIOE(object JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6076C60", Offset = "0x6076060", VA = "0x186076C60")]
	public static void DDLFONEBBMH(object JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6076AC0", Offset = "0x6075EC0", VA = "0x186076AC0")]
	private static Color DCBJMNNCCOC(int BCJCIOLMPPL, int OIPENDMCMEH, float AIHDNNBLDEA, float EKIMHMPAMNE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60773B0", Offset = "0x60767B0", VA = "0x1860773B0")]
	public static void PFGDDMENKIN(object JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6076E30", Offset = "0x6076230", VA = "0x186076E30")]
	private static Color EMIAIGHLECE(Color EMGHBDJCJIP, Color DHLGFHNBOGJ, float IGDJJEECDAF)
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
