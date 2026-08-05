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
		[Cpp2IlInjected.Address(RVA = "0x66EDB10", Offset = "0x66ECF10", VA = "0x1866EDB10")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CAOFFPFMHLF
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
public interface CPHPAFALBNL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CAOFFPFMHLF DMOMHMLCBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMLPONPPFKL
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
			[Cpp2IlInjected.Address(RVA = "0x66F0B20", Offset = "0x66EFF20", VA = "0x1866F0B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66F0B10", Offset = "0x66EFF10", VA = "0x1866F0B10")]
		public Resolution(uint PMEDGJGANML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
		public Resolution(uint PMEDGJGANML, uint NIPKEFBPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66F0A20", Offset = "0x66EFE20", VA = "0x1866F0A20")]
		public static Resolution PDHODNEMIHA(Resolution[] PPHOLEMBGPL, Resolution DFODGNOEADC, int CIOAPHIOPAF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JGPFOLFIAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution FDEBJJMFFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PPMMPDEBBFG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PMEDGJGANML
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x66EDF50", Offset = "0x66ED350", VA = "0x1866EDF50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint NIPKEFBPNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x66EDF30", Offset = "0x66ED330", VA = "0x1866EDF30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution LEHHBNHODBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x66EE100", Offset = "0x66ED500", VA = "0x1866EE100")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1356A40", Offset = "0x1355E40", VA = "0x181356A40")]
		public JGPFOLFIAMG(Resolution FDEBJJMFFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66EDF60", Offset = "0x66ED360", VA = "0x1866EDF60")]
		private static Resolution JOICKCGJMPN(Resolution PPMMPDEBBFG, CAOFFPFMHLF BCLPJHAPCAF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DKNOFCMKAMK
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BBJNGCPLOGH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BJLFJNEADBF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OEIGHBKPDFJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FNIHIEKMCBL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution MJLCDHNGBGC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution AAILCMAMNEC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KFMLJHPEDBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MFNFHOBIPON
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PBOGDBLJJLE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution BPPBHMIIMHP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CIHMEJKIGML;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution FMDDNBLDNIE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution LBHFBANAIFP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KFMLJHPEDBP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66EE500", Offset = "0x66ED900", VA = "0x1866EE500")]
		public static Resolution CGFLABJOPHO(uint FGOOGGEJGJK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution EKACCKKKJGL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66EF870", Offset = "0x66EEC70", VA = "0x1866EF870")]
	public static bool HOBEMKJBDKA(uint MNJEGGNIHON)
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
		public enum LBOPMOLDIIF : byte
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
		private class FLCBOBEPNOJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string GOENAEMJAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D AHIAIICFOCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LBOPMOLDIIF AJKLKPDMCKB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66EDDF0", Offset = "0x66ED1F0", VA = "0x1866EDDF0")]
			public FLCBOBEPNOJ(string GOENAEMJAON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E6750", Offset = "0x6E5B50", VA = "0x1806E6750")]
			public FLCBOBEPNOJ(string GOENAEMJAON, Texture2D IPAMFLJFLGJ, LBOPMOLDIIF ICHGCBDENNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66EDDB0", Offset = "0x66ED1B0", VA = "0x1866EDDB0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GPHIANGDGKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LBOPMOLDIIF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public GPHIANGDGKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66EDE40", Offset = "0x66ED240", VA = "0x1866EDE40")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IPGAENNLHEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public IPGAENNLHEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x66EDF10", Offset = "0x66ED310", VA = "0x1866EDF10")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HLIGEBPBGON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public HLIGEBPBGON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x66EDE80", Offset = "0x66ED280", VA = "0x1866EDE80")]
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
		private global::MLDKKGKEACN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FLCBOBEPNOJ _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::MLDKKGKEACN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::MLDKKGKEACN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FLCBOBEPNOJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66F0980", Offset = "0x66EFD80", VA = "0x1866F0980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66F0930", Offset = "0x66EFD30", VA = "0x1866F0930")]
		public ManagedTexture(string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66F08D0", Offset = "0x66EFCD0", VA = "0x1866F08D0")]
		public ManagedTexture(string GOENAEMJAON, bool FPEAOIGKPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66EFF80", Offset = "0x66EF380", VA = "0x1866EFF80")]
		public void DINIGDONJCG(RenderTexture ABNJIEHNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66F01C0", Offset = "0x66EF5C0", VA = "0x1866F01C0")]
		public global::MLDKKGKEACN<byte[]> JPAOPCLPDDI(bool EAJDHMENBPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x66EFAD0", Offset = "0x66EEED0", VA = "0x1866EFAD0")]
		public global::MLDKKGKEACN<Texture2D> BOMGFKJDGNN(LBOPMOLDIIF ICHGCBDENNE, bool MAAINBMJGAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66EFFC0", Offset = "0x66EF3C0", VA = "0x1866EFFC0")]
		public global::MLDKKGKEACN<byte[]> EEJDDCCIAEG(bool MAAINBMJGAG = false, int AEKKPALLOKO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x66EFDC0", Offset = "0x66EF1C0", VA = "0x1866EFDC0")]
		public global::MLDKKGKEACN<byte[]> CFFHIKFNHGD(bool MAAINBMJGAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66F0350", Offset = "0x66EF750", VA = "0x1866F0350")]
		private static global::MLDKKGKEACN<Texture2D> OEPODBCNLBG(string GOENAEMJAON, RenderTexture ABNJIEHNDCN, ref Texture2D MBPOAGBEHAH, bool MAAINBMJGAG, LBOPMOLDIIF CLHFBNDCJDK = LBOPMOLDIIF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66F01E0", Offset = "0x66EF5E0", VA = "0x1866F01E0")]
		public void KNILMFPJGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66EFFB0", Offset = "0x66EF3B0", VA = "0x1866EFFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66F02A0", Offset = "0x66EF6A0", VA = "0x1866F02A0")]
		[CompilerGenerated]
		private global::MLDKKGKEACN<byte[]> MDNAEOKDOBD(Texture2D HPCGNIPONGD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LLCBOBKPHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x66EE2E0", Offset = "0x66ED6E0", VA = "0x1866EE2E0")]
	public static RenderTexture NCPBGGBILMM(int FGOOGGEJGJK, int NJKNCDKEMEE, int AKCCLLANEEA, Camera GCBFALHAFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66EE490", Offset = "0x66ED890", VA = "0x1866EE490")]
	public static void NKIHKPEOBHP(RenderTexture ABNJIEHNDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MGPPENEHONL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BEDPGNDPEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int GODLNPABGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int EICPOANFBCD;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B38E0", Offset = "0x8B2CE0", VA = "0x1808B38E0")]
		public BEDPGNDPEPH(int JBBLMAOAMGB, int CJDLKEIECEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum LBDDMFLFICI
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] AEKALHFEKFH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] KFEOMGKJMMC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int GMOOOEOGNJK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float BHCHKAJBJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float PBPIIKJKINH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OBLPIBGOGNE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PCMKKNFLAKD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex HFGDIBHHKDN;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66EF400", Offset = "0x66EE800", VA = "0x1866EF400")]
	public static void HBCLBPBKIIC(Texture2D GFGHFFAGHDI, int MAGGGLLPPKM, int PCGJHLPLIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66EEF10", Offset = "0x66EE310", VA = "0x1866EEF10")]
	private static void FAGNGBKCBAB(Texture2D GFGHFFAGHDI, int MAGGGLLPPKM, int PCGJHLPLIFG, LBDDMFLFICI FENHPMNPJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66EEA90", Offset = "0x66EDE90", VA = "0x1866EEA90")]
	public static void CCIFOOCOKNG(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x66EF420", Offset = "0x66EE820", VA = "0x1866EF420")]
	public static void IJGGEAOIDNA(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x66EF6D0", Offset = "0x66EEAD0", VA = "0x1866EF6D0")]
	private static Color OAMIIEEPFNO(int PMEDGJGANML, int NIPKEFBPNPH, float BHCHKAJBJPJ, float PBPIIKJKINH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66EE8C0", Offset = "0x66EDCC0", VA = "0x1866EE8C0")]
	public static void BGINFENKOGD(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x66EF5F0", Offset = "0x66EE9F0", VA = "0x1866EF5F0")]
	private static Color LJHFGBMCPHJ(Color NKHOLOLFDJF, Color KJKFICPFLMH, float KPPLMEOMNGF)
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
