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
		[Cpp2IlInjected.Address(RVA = "0x666EE80", Offset = "0x666DE80", VA = "0x18666EE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671E90", Offset = "0x6670E90", VA = "0x186671E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6671E80", Offset = "0x6670E80", VA = "0x186671E80")]
		public Resolution(uint PMEDGJGANML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
		public Resolution(uint PMEDGJGANML, uint NIPKEFBPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6671D90", Offset = "0x6670D90", VA = "0x186671D90")]
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
			[Cpp2IlInjected.Address(RVA = "0x666F2C0", Offset = "0x666E2C0", VA = "0x18666F2C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint NIPKEFBPNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x666F2A0", Offset = "0x666E2A0", VA = "0x18666F2A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution LEHHBNHODBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x666F470", Offset = "0x666E470", VA = "0x18666F470")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12F96F0", Offset = "0x12F86F0", VA = "0x1812F96F0")]
		public JGPFOLFIAMG(Resolution FDEBJJMFFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x666F2D0", Offset = "0x666E2D0", VA = "0x18666F2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x666F870", Offset = "0x666E870", VA = "0x18666F870")]
		public static Resolution CGFLABJOPHO(uint FGOOGGEJGJK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution EKACCKKKJGL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6670BE0", Offset = "0x666FBE0", VA = "0x186670BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x666F160", Offset = "0x666E160", VA = "0x18666F160")]
			public FLCBOBEPNOJ(string GOENAEMJAON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E5750", Offset = "0x6E4750", VA = "0x1806E5750")]
			public FLCBOBEPNOJ(string GOENAEMJAON, Texture2D IPAMFLJFLGJ, LBOPMOLDIIF ICHGCBDENNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x666F120", Offset = "0x666E120", VA = "0x18666F120", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public GPHIANGDGKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x666F1B0", Offset = "0x666E1B0", VA = "0x18666F1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public IPGAENNLHEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x666F280", Offset = "0x666E280", VA = "0x18666F280")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public HLIGEBPBGON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x666F1F0", Offset = "0x666E1F0", VA = "0x18666F1F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FLCBOBEPNOJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6671CF0", Offset = "0x6670CF0", VA = "0x186671CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6671CA0", Offset = "0x6670CA0", VA = "0x186671CA0")]
		public ManagedTexture(string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6671C40", Offset = "0x6670C40", VA = "0x186671C40")]
		public ManagedTexture(string GOENAEMJAON, bool FPEAOIGKPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66712F0", Offset = "0x66702F0", VA = "0x1866712F0")]
		public void DINIGDONJCG(RenderTexture ABNJIEHNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6671530", Offset = "0x6670530", VA = "0x186671530")]
		public global::MLDKKGKEACN<byte[]> JPAOPCLPDDI(bool EAJDHMENBPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6670E40", Offset = "0x666FE40", VA = "0x186670E40")]
		public global::MLDKKGKEACN<Texture2D> BOMGFKJDGNN(LBOPMOLDIIF ICHGCBDENNE, bool MAAINBMJGAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6671330", Offset = "0x6670330", VA = "0x186671330")]
		public global::MLDKKGKEACN<byte[]> EEJDDCCIAEG(bool MAAINBMJGAG = false, int AEKKPALLOKO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6671130", Offset = "0x6670130", VA = "0x186671130")]
		public global::MLDKKGKEACN<byte[]> CFFHIKFNHGD(bool MAAINBMJGAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66716C0", Offset = "0x66706C0", VA = "0x1866716C0")]
		private static global::MLDKKGKEACN<Texture2D> OEPODBCNLBG(string GOENAEMJAON, RenderTexture ABNJIEHNDCN, ref Texture2D MBPOAGBEHAH, bool MAAINBMJGAG, LBOPMOLDIIF CLHFBNDCJDK = LBOPMOLDIIF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6671550", Offset = "0x6670550", VA = "0x186671550")]
		public void KNILMFPJGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6671320", Offset = "0x6670320", VA = "0x186671320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6671610", Offset = "0x6670610", VA = "0x186671610")]
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
	[Cpp2IlInjected.Address(RVA = "0x666F650", Offset = "0x666E650", VA = "0x18666F650")]
	public static RenderTexture NCPBGGBILMM(int FGOOGGEJGJK, int NJKNCDKEMEE, int AKCCLLANEEA, Camera GCBFALHAFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x666F800", Offset = "0x666E800", VA = "0x18666F800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B18E0", VA = "0x1808B28E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6670770", Offset = "0x666F770", VA = "0x186670770")]
	public static void HBCLBPBKIIC(Texture2D GFGHFFAGHDI, int MAGGGLLPPKM, int PCGJHLPLIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6670280", Offset = "0x666F280", VA = "0x186670280")]
	private static void FAGNGBKCBAB(Texture2D GFGHFFAGHDI, int MAGGGLLPPKM, int PCGJHLPLIFG, LBDDMFLFICI FENHPMNPJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x666FE00", Offset = "0x666EE00", VA = "0x18666FE00")]
	public static void CCIFOOCOKNG(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6670790", Offset = "0x666F790", VA = "0x186670790")]
	public static void IJGGEAOIDNA(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6670A40", Offset = "0x666FA40", VA = "0x186670A40")]
	private static Color OAMIIEEPFNO(int PMEDGJGANML, int NIPKEFBPNPH, float BHCHKAJBJPJ, float PBPIIKJKINH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x666FC30", Offset = "0x666EC30", VA = "0x18666FC30")]
	public static void BGINFENKOGD(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6670960", Offset = "0x666F960", VA = "0x186670960")]
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
