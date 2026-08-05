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
		[Cpp2IlInjected.Address(RVA = "0x6474180", Offset = "0x6473580", VA = "0x186474180")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AFNONDFGAMD
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
public interface IJBDHLMMFCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AFNONDFGAMD HMDPLJGJDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class COLGLJHOBOI
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
			[Cpp2IlInjected.Address(RVA = "0x6476E80", Offset = "0x6476280", VA = "0x186476E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6476E70", Offset = "0x6476270", VA = "0x186476E70")]
		public Resolution(uint BIAIPPDLOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
		public Resolution(uint BIAIPPDLOMD, uint ECJDGGJBGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6476D80", Offset = "0x6476180", VA = "0x186476D80")]
		public static Resolution IBLIGFEKIBE(Resolution[] OCHMMOCEMAN, Resolution BEHMGCCHAJD, int EELEBBCNCLC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JIHLHBKFJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution OPNPGMKLMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? KKLCKFOHOPG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint BIAIPPDLOMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6474A90", Offset = "0x6473E90", VA = "0x186474A90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ECJDGGJBGPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6474AA0", Offset = "0x6473EA0", VA = "0x186474AA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EAHEBDJKKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x64748B0", Offset = "0x6473CB0", VA = "0x1864748B0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x172EB60", Offset = "0x172DF60", VA = "0x18172EB60")]
		public JIHLHBKFJNM(Resolution OPNPGMKLMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6474AC0", Offset = "0x6473EC0", VA = "0x186474AC0")]
		private static Resolution KEMJAFONNKJ(Resolution KKLCKFOHOPG, AFNONDFGAMD HKDFEOCPDBI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JGDPFDFCGKO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution NOPKGDFOJDD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IEOBBPLMMLH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PHDAHPJEMAK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution MPDKMKBIICK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution MBEPONBPFHG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution GMOCJHFJEFJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] FAMGGLHBCFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FKIAGFCKIIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MCLAFOGFJDP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution HKCGKNGOGPG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LFDOHMODNGF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution IJGNLNFDLFF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FEPJIMKPMIK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] FAMGGLHBCFC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64741E0", Offset = "0x64735E0", VA = "0x1864741E0")]
		public static Resolution NDBPGJEPPCL(uint HMEFMFINFBK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution OKJMINHADEG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6473F20", Offset = "0x6473320", VA = "0x186473F20")]
	public static bool JFEIGCOMGDK(uint ACAKHBNOKKC)
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
		public enum EEDFHMLKCHI : byte
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
		private class BKPFPPEJMKB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string IGHJIHNAPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HOHBMPGOINA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EEDFHMLKCHI KBOLOJDJENE;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6473ED0", Offset = "0x64732D0", VA = "0x186473ED0")]
			public BKPFPPEJMKB(string IGHJIHNAPBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x785B70", Offset = "0x784F70", VA = "0x180785B70")]
			public BKPFPPEJMKB(string IGHJIHNAPBA, Texture2D IGCBGLPMGJK, EEDFHMLKCHI PKFLBCPJJHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6473E90", Offset = "0x6473290", VA = "0x186473E90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DIDOBLDFFHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public EEDFHMLKCHI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DIDOBLDFFHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64741A0", Offset = "0x64735A0", VA = "0x1864741A0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AKPEFIPPANG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public AKPEFIPPANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6473E70", Offset = "0x6473270", VA = "0x186473E70")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GDFFCMMGGGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public GDFFCMMGGGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64745A0", Offset = "0x64739A0", VA = "0x1864745A0")]
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
		private global::HCPIAAEIKCB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BKPFPPEJMKB _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HCPIAAEIKCB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HCPIAAEIKCB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BKPFPPEJMKB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6475D30", Offset = "0x6475130", VA = "0x186475D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6475CE0", Offset = "0x64750E0", VA = "0x186475CE0")]
		public ManagedTexture(string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6475C80", Offset = "0x6475080", VA = "0x186475C80")]
		public ManagedTexture(string IGHJIHNAPBA, bool GBOKGPADMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6475410", Offset = "0x6474810", VA = "0x186475410")]
		public void EANEKPOPCPP(RenderTexture PBCNPEOJNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6475A60", Offset = "0x6474E60", VA = "0x186475A60")]
		public global::HCPIAAEIKCB<byte[]> LDJHIEGFDJM(bool HOPBGKGFIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64755B0", Offset = "0x64749B0", VA = "0x1864755B0")]
		public global::HCPIAAEIKCB<Texture2D> GBEGLHFNBEP(EEDFHMLKCHI PKFLBCPJJHM, bool HFHEBGCCDJJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6475A80", Offset = "0x6474E80", VA = "0x186475A80")]
		public global::HCPIAAEIKCB<byte[]> OALNCPMACAD(bool HFHEBGCCDJJ = false, int MIJNPLOJEAF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64758A0", Offset = "0x6474CA0", VA = "0x1864758A0")]
		public global::HCPIAAEIKCB<byte[]> HINPFKMJCIL(bool HFHEBGCCDJJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6474E80", Offset = "0x6474280", VA = "0x186474E80")]
		private static global::HCPIAAEIKCB<Texture2D> AKOGEEMAAKG(string IGHJIHNAPBA, RenderTexture PBCNPEOJNIM, ref Texture2D EKJFPMBPKHC, bool HFHEBGCCDJJ, EEDFHMLKCHI BDFPNALGDCN = EEDFHMLKCHI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x64754F0", Offset = "0x64748F0", VA = "0x1864754F0")]
		public void FOGIKHHEBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6475400", Offset = "0x6474800", VA = "0x186475400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6475440", Offset = "0x6474840", VA = "0x186475440")]
		[CompilerGenerated]
		private global::HCPIAAEIKCB<byte[]> FCCBLADDCHA(Texture2D MGGPMFPNONL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LKMBLJFHMCO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6474CD0", Offset = "0x64740D0", VA = "0x186474CD0")]
	public static RenderTexture OFDCPLIHAKK(int HMEFMFINFBK, int OELIKJHOPLF, int ELMCLGINMHD, Camera GBPPCIDHBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6474C60", Offset = "0x6474060", VA = "0x186474C60")]
	public static void ECJHPOCGNAJ(RenderTexture PBCNPEOJNIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OJADJGALDBL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DNDODHBJEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int IDCHKLCNMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int HEGLMOCOEGO;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDC7750", Offset = "0xDC6B50", VA = "0x180DC7750")]
		public DNDODHBJEBB(int CKNAFFDCOPO, int LBPJAILMLKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum FCKPCKPJDCF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] OBDNCCPCDMG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] GJMPOEEPFNO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int ONCKMLEEMNO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float ILPNNBIPMEK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float GGCIPGFMKMK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int GIBONENAHMM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int OGMMADNCBCP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex CHFOGFBKFAA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64768E0", Offset = "0x6475CE0", VA = "0x1864768E0")]
	public static void MIMDHBLNEFK(Texture2D ADABKEGIMMN, int PDBEFCCHJGO, int IPNOFBMFCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6475DD0", Offset = "0x64751D0", VA = "0x186475DD0")]
	private static void AKGCJBMIIIN(Texture2D ADABKEGIMMN, int PDBEFCCHJGO, int IPNOFBMFCGI, FCKPCKPJDCF MFCNHFGGLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6476900", Offset = "0x6475D00", VA = "0x186476900")]
	public static void PDOBACBOPIO(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6476710", Offset = "0x6475B10", VA = "0x186476710")]
	public static void HBLMOIIDGOE(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6476570", Offset = "0x6475970", VA = "0x186476570")]
	private static Color GIECJMANDKH(int BIAIPPDLOMD, int ECJDGGJBGPG, float ILPNNBIPMEK, float GGCIPGFMKMK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x64763A0", Offset = "0x64757A0", VA = "0x1864763A0")]
	public static void FKBDIOLDLBN(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x64762C0", Offset = "0x64756C0", VA = "0x1864762C0")]
	private static Color EADKCCDMGCG(Color HNFLCEDENHM, Color PCBEJBOJOLG, float JFBPNBNBHOE)
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
