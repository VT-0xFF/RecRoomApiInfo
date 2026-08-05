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
		[Cpp2IlInjected.Address(RVA = "0x64693C0", Offset = "0x64685C0", VA = "0x1864693C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x646C0C0", Offset = "0x646B2C0", VA = "0x18646C0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x646C0B0", Offset = "0x646B2B0", VA = "0x18646C0B0")]
		public Resolution(uint BIAIPPDLOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
		public Resolution(uint BIAIPPDLOMD, uint ECJDGGJBGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x646BFC0", Offset = "0x646B1C0", VA = "0x18646BFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6469CD0", Offset = "0x6468ED0", VA = "0x186469CD0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ECJDGGJBGPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6469CE0", Offset = "0x6468EE0", VA = "0x186469CE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EAHEBDJKKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6469AF0", Offset = "0x6468CF0", VA = "0x186469AF0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1141670", Offset = "0x1140870", VA = "0x181141670")]
		public JIHLHBKFJNM(Resolution OPNPGMKLMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6469D00", Offset = "0x6468F00", VA = "0x186469D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6469420", Offset = "0x6468620", VA = "0x186469420")]
		public static Resolution NDBPGJEPPCL(uint HMEFMFINFBK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution OKJMINHADEG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6469160", Offset = "0x6468360", VA = "0x186469160")]
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
			[Cpp2IlInjected.Address(RVA = "0x6469110", Offset = "0x6468310", VA = "0x186469110")]
			public BKPFPPEJMKB(string IGHJIHNAPBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6CD750", Offset = "0x6CC950", VA = "0x1806CD750")]
			public BKPFPPEJMKB(string IGHJIHNAPBA, Texture2D IGCBGLPMGJK, EEDFHMLKCHI PKFLBCPJJHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64690D0", Offset = "0x64682D0", VA = "0x1864690D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public DIDOBLDFFHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64693E0", Offset = "0x64685E0", VA = "0x1864693E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public AKPEFIPPANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x64690B0", Offset = "0x64682B0", VA = "0x1864690B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public GDFFCMMGGGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64697E0", Offset = "0x64689E0", VA = "0x1864697E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CB250", Offset = "0x6CA450", VA = "0x1806CB250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BKPFPPEJMKB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x646AF70", Offset = "0x646A170", VA = "0x18646AF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x646AF20", Offset = "0x646A120", VA = "0x18646AF20")]
		public ManagedTexture(string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x646AEC0", Offset = "0x646A0C0", VA = "0x18646AEC0")]
		public ManagedTexture(string IGHJIHNAPBA, bool GBOKGPADMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x646A650", Offset = "0x6469850", VA = "0x18646A650")]
		public void EANEKPOPCPP(RenderTexture PBCNPEOJNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x646ACA0", Offset = "0x6469EA0", VA = "0x18646ACA0")]
		public global::HCPIAAEIKCB<byte[]> LDJHIEGFDJM(bool HOPBGKGFIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x646A7F0", Offset = "0x64699F0", VA = "0x18646A7F0")]
		public global::HCPIAAEIKCB<Texture2D> GBEGLHFNBEP(EEDFHMLKCHI PKFLBCPJJHM, bool HFHEBGCCDJJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x646ACC0", Offset = "0x6469EC0", VA = "0x18646ACC0")]
		public global::HCPIAAEIKCB<byte[]> OALNCPMACAD(bool HFHEBGCCDJJ = false, int MIJNPLOJEAF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x646AAE0", Offset = "0x6469CE0", VA = "0x18646AAE0")]
		public global::HCPIAAEIKCB<byte[]> HINPFKMJCIL(bool HFHEBGCCDJJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x646A0C0", Offset = "0x64692C0", VA = "0x18646A0C0")]
		private static global::HCPIAAEIKCB<Texture2D> AKOGEEMAAKG(string IGHJIHNAPBA, RenderTexture PBCNPEOJNIM, ref Texture2D EKJFPMBPKHC, bool HFHEBGCCDJJ, EEDFHMLKCHI BDFPNALGDCN = EEDFHMLKCHI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x646A730", Offset = "0x6469930", VA = "0x18646A730")]
		public void FOGIKHHEBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x646A640", Offset = "0x6469840", VA = "0x18646A640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x646A680", Offset = "0x6469880", VA = "0x18646A680")]
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
	[Cpp2IlInjected.Address(RVA = "0x6469F10", Offset = "0x6469110", VA = "0x186469F10")]
	public static RenderTexture OFDCPLIHAKK(int HMEFMFINFBK, int OELIKJHOPLF, int ELMCLGINMHD, Camera GBPPCIDHBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6469EA0", Offset = "0x64690A0", VA = "0x186469EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A920", Offset = "0x899B20", VA = "0x18089A920")]
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
	[Cpp2IlInjected.Address(RVA = "0x646BB20", Offset = "0x646AD20", VA = "0x18646BB20")]
	public static void MIMDHBLNEFK(Texture2D ADABKEGIMMN, int PDBEFCCHJGO, int IPNOFBMFCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x646B010", Offset = "0x646A210", VA = "0x18646B010")]
	private static void AKGCJBMIIIN(Texture2D ADABKEGIMMN, int PDBEFCCHJGO, int IPNOFBMFCGI, FCKPCKPJDCF MFCNHFGGLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x646BB40", Offset = "0x646AD40", VA = "0x18646BB40")]
	public static void PDOBACBOPIO(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x646B950", Offset = "0x646AB50", VA = "0x18646B950")]
	public static void HBLMOIIDGOE(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x646B7B0", Offset = "0x646A9B0", VA = "0x18646B7B0")]
	private static Color GIECJMANDKH(int BIAIPPDLOMD, int ECJDGGJBGPG, float ILPNNBIPMEK, float GGCIPGFMKMK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x646B5E0", Offset = "0x646A7E0", VA = "0x18646B5E0")]
	public static void FKBDIOLDLBN(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x646B500", Offset = "0x646A700", VA = "0x18646B500")]
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
