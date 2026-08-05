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
		[Cpp2IlInjected.Address(RVA = "0x43CB190", Offset = "0x43C9D90", VA = "0x1843CB190")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JEHFPBEKDKF
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
public interface KACJIGJPDMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JEHFPBEKDKF DKALBNPAION
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCAFIMCODHF
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
			[Cpp2IlInjected.Address(RVA = "0x43CDD30", Offset = "0x43CC930", VA = "0x1843CDD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43CDD20", Offset = "0x43CC920", VA = "0x1843CDD20")]
		public Resolution(uint OPBDHHKCDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EE670", Offset = "0x5ED270", VA = "0x1805EE670")]
		public Resolution(uint OPBDHHKCDJG, uint LJNMNIILEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43CDBD0", Offset = "0x43CC7D0", VA = "0x1843CDBD0")]
		public static Resolution PEADGKAJNAF(Resolution[] PAFEDBMFKNN, Resolution CCFHFBJBKIC, int BPLBKDJGGCC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CAPKGBNEMHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution HAAGEIGALIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? MAPGHBEENKP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint OPBDHHKCDJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x43CAF60", Offset = "0x43C9B60", VA = "0x1843CAF60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint LJNMNIILEKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x43CB170", Offset = "0x43C9D70", VA = "0x1843CB170")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EMMAAMAHLBI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43CAF70", Offset = "0x43C9B70", VA = "0x1843CAF70")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x26F5820", Offset = "0x26F4420", VA = "0x1826F5820")]
		public CAPKGBNEMHC(Resolution HAAGEIGALIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x43CAD90", Offset = "0x43C9990", VA = "0x1843CAD90")]
		private static Resolution CFNFFFDGOKH(Resolution MAPGHBEENKP, JEHFPBEKDKF IPGENDFELAK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GPPFKAPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BCDFLBICGDH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BHOMCPLNHJK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PDAKCMIKGIA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DNBONIJKNKA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DPLLGPANFMH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HIFEBMNMDGO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] NHMADBMFJOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JOHGFCOIGJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HANBAJNIFDM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution BCPPIICIJCF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution MHLEDCICDED;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution KCHGPEDALNF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution IFAKAONBHGK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] NHMADBMFJOJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43CC8B0", Offset = "0x43CB4B0", VA = "0x1843CC8B0")]
		public static Resolution DHOAEPFFCBG(uint KOKLOKFGLIH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution KKHPCLEHEOH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43CB410", Offset = "0x43CA010", VA = "0x1843CB410")]
	public static bool KLFAIBCOIDB(uint EBPELOPCILP)
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
		public enum DDGCEDICEEL : byte
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
		private class PHLNNAACBOD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LFMIGONHLDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LIMBJDGEKBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DDGCEDICEEL LMIJGIPGIIN;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x43CDB90", Offset = "0x43CC790", VA = "0x1843CDB90")]
			public PHLNNAACBOD(string LFMIGONHLDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x854690", Offset = "0x853290", VA = "0x180854690")]
			public PHLNNAACBOD(string LFMIGONHLDF, Texture2D MHBKNJLENBF, DDGCEDICEEL OINOPNCNDDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x43CDB60", Offset = "0x43CC760", VA = "0x1843CDB60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HHNBELAEHJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DDGCEDICEEL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public HHNBELAEHJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x43CB650", Offset = "0x43CA250", VA = "0x1843CB650")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ALFPHPPGMCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public ALFPHPPGMCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x43CAD70", Offset = "0x43C9970", VA = "0x1843CAD70")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PACBJOALMIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public PACBJOALMIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x43CDAE0", Offset = "0x43CC6E0", VA = "0x1843CDAE0")]
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
		private global::JLPBMLKOEIK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PHLNNAACBOD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::JLPBMLKOEIK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::JLPBMLKOEIK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4EA180", Offset = "0x4E8D80", VA = "0x1804EA180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C18F0", VA = "0x1804C2CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E83D0", VA = "0x1804E97D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PHLNNAACBOD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x43CDA60", Offset = "0x43CC660", VA = "0x1843CDA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43CDA10", Offset = "0x43CC610", VA = "0x1843CDA10")]
		public ManagedTexture(string LFMIGONHLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43CD9C0", Offset = "0x43CC5C0", VA = "0x1843CD9C0")]
		public ManagedTexture(string LFMIGONHLDF, bool OLPDMJOMNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x43CD7D0", Offset = "0x43CC3D0", VA = "0x1843CD7D0")]
		public void LFEOPLKOBMN(RenderTexture JJKOAGAGFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43CD180", Offset = "0x43CBD80", VA = "0x1843CD180")]
		public global::JLPBMLKOEIK<byte[]> FAMNOMNAFMC(bool IBNIEMCNDOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43CD310", Offset = "0x43CBF10", VA = "0x1843CD310")]
		public global::JLPBMLKOEIK<Texture2D> KDKBPEPNPOD(DDGCEDICEEL OINOPNCNDDN, bool JDPJFFMLDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43CD590", Offset = "0x43CC190", VA = "0x1843CD590")]
		public global::JLPBMLKOEIK<byte[]> KNKBHKMJAKA(bool JDPJFFMLDCK = false, int EEFOCKOODLH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43CD850", Offset = "0x43CC450", VA = "0x1843CD850")]
		public global::JLPBMLKOEIK<byte[]> MNKPFFDLMHP(bool JDPJFFMLDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43CCC40", Offset = "0x43CB840", VA = "0x1843CCC40")]
		private static global::JLPBMLKOEIK<Texture2D> DGAGKOECGBH(string LFMIGONHLDF, RenderTexture JJKOAGAGFKP, ref Texture2D APIFNJOIFNC, bool JDPJFFMLDCK, DDGCEDICEEL APNLEODODPB = DDGCEDICEEL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43CD110", Offset = "0x43CBD10", VA = "0x1843CD110")]
		public void GDLJNGIHDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43CD110", Offset = "0x43CBD10", VA = "0x1843CD110", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43CD730", Offset = "0x43CC330", VA = "0x1843CD730")]
		[CompilerGenerated]
		private global::JLPBMLKOEIK<byte[]> LBOBNDFIPOL(Texture2D HILKDHDFPPO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IJEHNNLEKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43CB700", Offset = "0x43CA300", VA = "0x1843CB700")]
	public static RenderTexture HJPIOAEIDBC(int KOKLOKFGLIH, int GIAAKHJAAFN, int LFNDGJEOOEH, Camera IAPNKOBOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43CB690", Offset = "0x43CA290", VA = "0x1843CB690")]
	public static void AHCMBNPLOHH(RenderTexture JJKOAGAGFKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JDNGBIMFFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EIFFJBCHBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int JBKFBJMKKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int JMNFMHIKDDC;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x578D60", Offset = "0x577960", VA = "0x180578D60")]
		public EIFFJBCHBOH(int GCOIHALFCNM, int EMFHNCOFDKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum MIHFKOFDNPE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] HMNBDGHDHGE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] CPKJBJNGJEK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JFFLPOHOIKM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float AKJCNDAHBDA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float FDKPDCPDFOM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int FGKCINODPBH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int CMJOJMLKBMH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JKDNILJOHJC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43CB870", Offset = "0x43CA470", VA = "0x1843CB870")]
	public static void GMJHJKPMJFJ(Texture2D OLJFKOGNMOO, int NNLAPKOCEHH, int DONMCLLBKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43CBD20", Offset = "0x43CA920", VA = "0x1843CBD20")]
	private static void LOAJEJLHMGI(Texture2D OLJFKOGNMOO, int NNLAPKOCEHH, int DONMCLLBKEL, MIHFKOFDNPE OCAPLFGEDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43CC1B0", Offset = "0x43CADB0", VA = "0x1843CC1B0")]
	public static void MOKCOKGHLLE(object JPFPDMFLBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43CBB40", Offset = "0x43CA740", VA = "0x1843CBB40")]
	public static void JGEAABGGJJB(object JPFPDMFLBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43CB980", Offset = "0x43CA580", VA = "0x1843CB980")]
	private static Color HCENFHPGBIK(int OPBDHHKCDJG, int LJNMNIILEKH, float AKJCNDAHBDA, float FDKPDCPDFOM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43CC6D0", Offset = "0x43CB2D0", VA = "0x1843CC6D0")]
	public static void NFBLMHGNHBL(object JPFPDMFLBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43CB890", Offset = "0x43CA490", VA = "0x1843CB890")]
	private static Color HAEGHNJJGHB(Color KFCCOMGCMOL, Color CMCHDJGKEBD, float CKGFDBLPDNJ)
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
