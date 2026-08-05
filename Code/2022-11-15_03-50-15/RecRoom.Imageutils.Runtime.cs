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
		[Cpp2IlInjected.Address(RVA = "0x6025F70", Offset = "0x6024970", VA = "0x186025F70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MCPIPMAAFJP
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
public interface AIBGFKPJDDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MCPIPMAAFJP MACNPMAIGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MDPPENMHEMB
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
			[Cpp2IlInjected.Address(RVA = "0x6027B90", Offset = "0x6026590", VA = "0x186027B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6027B80", Offset = "0x6026580", VA = "0x186027B80")]
		public Resolution(uint GKGDNAPOGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
		public Resolution(uint GKGDNAPOGPF, uint JLKLDCLDEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6027A90", Offset = "0x6026490", VA = "0x186027A90")]
		public static Resolution CLNADAGOCDD(Resolution[] EGFLOGJCPJP, Resolution EMLOOMFJNPE, int CFDJMJFPOLO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AMAJJICAFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution INGJNHGMDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? NFKACFCAHIM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GKGDNAPOGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6025D10", Offset = "0x6024710", VA = "0x186025D10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JLKLDCLDEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6025D20", Offset = "0x6024720", VA = "0x186025D20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OCBAEKAOLAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6025B30", Offset = "0x6024530", VA = "0x186025B30")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCC57C0", Offset = "0xCC41C0", VA = "0x180CC57C0")]
		public AMAJJICAFDG(Resolution INGJNHGMDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6025D40", Offset = "0x6024740", VA = "0x186025D40")]
		private static Resolution HMFFCJJOMHF(Resolution NFKACFCAHIM, MCPIPMAAFJP HKJDJKIPNBN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MMLLCEKCION
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BJBGJJIHBPH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BCNDMKFGAEB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution FONNOIHKCKI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GHNJLJKFPBG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution MDMCALIMGHC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DMJBCKGFLIO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KPFECFDKBLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PMNILJHJIKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution FCEOKFPADLA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JEFNGCAOLDJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BLKLNCDCDMD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution GOMNOKJDJLB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution MOKHNBOCKEA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KPFECFDKBLK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60276D0", Offset = "0x60260D0", VA = "0x1860276D0")]
		public static Resolution NPKCBMNCJEN(uint KAJKGOBCCGF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DKEIKAIJDDK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60261F0", Offset = "0x6024BF0", VA = "0x1860261F0")]
	public static bool ELNMHIFEDMI(uint IHACBDNFIBF)
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
		public enum ENNFBPFGMAJ : byte
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
		private class BBLIMHIHGMA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string KKJOOAJGLJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D ILALMILKMLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ENNFBPFGMAJ AONNCALHNLM;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6025F20", Offset = "0x6024920", VA = "0x186025F20")]
			public BBLIMHIHGMA(string KKJOOAJGLJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x290C070", Offset = "0x290AA70", VA = "0x18290C070")]
			public BBLIMHIHGMA(string KKJOOAJGLJI, Texture2D JFDNJJOJFNO, ENNFBPFGMAJ BALOAMABAGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6025EE0", Offset = "0x60248E0", VA = "0x186025EE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KOIGFPFNAAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ENNFBPFGMAJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public KOIGFPFNAAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x60261B0", Offset = "0x6024BB0", VA = "0x1860261B0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MNAJLFOGLIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public MNAJLFOGLIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60266D0", Offset = "0x60250D0", VA = "0x1860266D0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NDCGGCKDCHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public NDCGGCKDCHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6027640", Offset = "0x6026040", VA = "0x186027640")]
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
		private global::LFIHKJLGIGB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BBLIMHIHGMA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::LFIHKJLGIGB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::LFIHKJLGIGB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB30", Offset = "0x7DA530", VA = "0x1807DBB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BBLIMHIHGMA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x60275A0", Offset = "0x6025FA0", VA = "0x1860275A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6027550", Offset = "0x6025F50", VA = "0x186027550")]
		public ManagedTexture(string KKJOOAJGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60274F0", Offset = "0x6025EF0", VA = "0x1860274F0")]
		public ManagedTexture(string KKJOOAJGLJI, bool NHPLMNAKODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6026BA0", Offset = "0x60255A0", VA = "0x186026BA0")]
		public void LAKKGMCAMPF(RenderTexture CLJDNKIKEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60268F0", Offset = "0x60252F0", VA = "0x1860268F0")]
		public global::LFIHKJLGIGB<byte[]> BGGAKIEOCPB(bool JHKOFAPBBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6026BD0", Offset = "0x60255D0", VA = "0x186026BD0")]
		public global::LFIHKJLGIGB<Texture2D> LJKGBMEEDKA(ENNFBPFGMAJ BALOAMABAGO, bool GKFKCMMLKOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60266F0", Offset = "0x60250F0", VA = "0x1860266F0")]
		public global::LFIHKJLGIGB<byte[]> BDILDPPPKME(bool GKFKCMMLKOE = false, int BKEJOHOKIHK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6026910", Offset = "0x6025310", VA = "0x186026910")]
		public global::LFIHKJLGIGB<byte[]> BKPNHJPINHA(bool GKFKCMMLKOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6026F70", Offset = "0x6025970", VA = "0x186026F70")]
		private static global::LFIHKJLGIGB<Texture2D> NNNEHPPAHHA(string KKJOOAJGLJI, RenderTexture CLJDNKIKEPN, ref Texture2D JMFHCDFHIKI, bool GKFKCMMLKOE, ENNFBPFGMAJ OKJLGLEAIKJ = ENNFBPFGMAJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6026AE0", Offset = "0x60254E0", VA = "0x186026AE0")]
		public void EGGGJGAJCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6026AD0", Offset = "0x60254D0", VA = "0x186026AD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6026EC0", Offset = "0x60258C0", VA = "0x186026EC0")]
		[CompilerGenerated]
		private global::LFIHKJLGIGB<byte[]> LNLOOBLHALO(Texture2D LLJIFBLCIGO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JDABPBEGPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6026000", Offset = "0x6024A00", VA = "0x186026000")]
	public static RenderTexture PDNMPDMOJEJ(int KAJKGOBCCGF, int FOAFPMPLOCB, int MFAINABGBEA, Camera PFMKIPKLGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6025F90", Offset = "0x6024990", VA = "0x186025F90")]
	public static void OMMLLJDPFGJ(RenderTexture CLJDNKIKEPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ADLIEABEHKE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PGEKCFEENKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int NJEPHEABALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int AFPKKIJINFE;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1ECF680", Offset = "0x1ECE080", VA = "0x181ECF680")]
		public PGEKCFEENKN(int PDJOEIGEFKI, int OIBINBJMLDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum EIKDPPJNAJE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] IPHOKPPLICK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] AMCBFBKOGEI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int HMBPKDIMEHE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JKHBKHAMHJO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float MBLHODEJHMF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int PGDLPDHFOBG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KFPIKFGJPCC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex IJPMEAJKIJD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6024D20", Offset = "0x6023720", VA = "0x186024D20")]
	public static void KHLKMIJIJIG(Texture2D JAFHDJHNAGK, int JMKDJCJNBIA, int NOOHJMMJFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60252A0", Offset = "0x6023CA0", VA = "0x1860252A0")]
	private static void NCHOHJANBDH(Texture2D JAFHDJHNAGK, int JMKDJCJNBIA, int NOOHJMMJFMF, EIKDPPJNAJE PBDKDHHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6024E20", Offset = "0x6023820", VA = "0x186024E20")]
	public static void KLKEAMIOOMC(object PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6025790", Offset = "0x6024190", VA = "0x186025790")]
	public static void OCNKALHMHIL(object PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6024B80", Offset = "0x6023580", VA = "0x186024B80")]
	private static Color BIDCJACIKIF(int GKGDNAPOGPF, int JLKLDCLDEEL, float JKHBKHAMHJO, float MBLHODEJHMF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6025960", Offset = "0x6024360", VA = "0x186025960")]
	public static void PFPNHOMIJPG(object PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6024D40", Offset = "0x6023740", VA = "0x186024D40")]
	private static Color KKOOFNNDNGP(Color BILOGEHHHBL, Color HKNJEMCBDAN, float NKJMIDIDBOE)
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
