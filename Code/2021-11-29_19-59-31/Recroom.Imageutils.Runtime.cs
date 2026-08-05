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
		[Cpp2IlInjected.Address(RVA = "0x3D86D50", Offset = "0x3D85750", VA = "0x183D86D50")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IPOAAKOBKDA
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
public interface CAKCGKPOAGL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IPOAAKOBKDA CAFMGAOCLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HEDKJHDPGHC
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
			[Cpp2IlInjected.Address(RVA = "0x3D899C0", Offset = "0x3D883C0", VA = "0x183D899C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D899B0", Offset = "0x3D883B0", VA = "0x183D899B0")]
		public Resolution(uint IDCEIHIONGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x556C70", Offset = "0x555670", VA = "0x180556C70")]
		public Resolution(uint IDCEIHIONGP, uint ADCOBJDHEMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D89860", Offset = "0x3D88260", VA = "0x183D89860")]
		public static Resolution EODNKJCMNFG(Resolution[] IJHCPFFMEON, Resolution DGLNMNBLHJE, int BJBBPOABHOB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class EFHPBAJDMLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution PJFKFJHBGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? IPFKCAAHDOG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint IDCEIHIONGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3D86D90", Offset = "0x3D85790", VA = "0x183D86D90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ADCOBJDHEMO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3D86DA0", Offset = "0x3D857A0", VA = "0x183D86DA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution JFBGBGIMIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D86F90", Offset = "0x3D85990", VA = "0x183D86F90")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x766270", Offset = "0x764C70", VA = "0x180766270")]
		public EFHPBAJDMLG(Resolution PJFKFJHBGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D86DC0", Offset = "0x3D857C0", VA = "0x183D86DC0")]
		private static Resolution LCJODIOGJMB(Resolution IPFKCAAHDOG, IPOAAKOBKDA KBCNJKGAIAI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IJNKFJMMLKE
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LAMKCMAPEEN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution EEMKBPIEGCE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OJLLAMPHIAP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution AKKLJJCMANF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LONGJJIPJMD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FPDABMLBIHK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] PHHOHDNHKDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CPBGOLLPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BBGAIDBNEMO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DANNCKHFINP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BPNNIOEEIPO;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution LCCHAGPOCID;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GKLMAHABBNM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] PHHOHDNHKDM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D869C0", Offset = "0x3D853C0", VA = "0x183D869C0")]
		public static Resolution LCIDLMEEDCE(uint PPHCJMNFGGD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NENGKPEABMD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D87190", Offset = "0x3D85B90", VA = "0x183D87190")]
	public static bool PCELIMMLKNH(uint GPGFECCPLLG)
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
		public enum ILJGCEAOGMM : byte
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
		private class AFAOPAEIEHC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string AKEPBHBNAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D BMLKKHPEEBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ILJGCEAOGMM FNJNCOMOCJH;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3D86980", Offset = "0x3D85380", VA = "0x183D86980")]
			public AFAOPAEIEHC(string AKEPBHBNAIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9AA120", Offset = "0x9A8B20", VA = "0x1809AA120")]
			public AFAOPAEIEHC(string AKEPBHBNAIA, Texture2D CMHFAEBNEJD, ILJGCEAOGMM JKMAMOMKPNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3D86950", Offset = "0x3D85350", VA = "0x183D86950", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MHNPBLNPHBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ILJGCEAOGMM textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public MHNPBLNPHBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3D87810", Offset = "0x3D86210", VA = "0x183D87810")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DLBGNFKLAED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public DLBGNFKLAED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D86D70", Offset = "0x3D85770", VA = "0x183D86D70")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NPJKCIJEALP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public NPJKCIJEALP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3D897E0", Offset = "0x3D881E0", VA = "0x183D897E0")]
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
		private global::GDHDNGFJPDI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private AFAOPAEIEHC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GDHDNGFJPDI<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GDHDNGFJPDI<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x451180", Offset = "0x44FB80", VA = "0x180451180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x429CF0", Offset = "0x4286F0", VA = "0x180429CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4507D0", Offset = "0x44F1D0", VA = "0x1804507D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private AFAOPAEIEHC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3D88720", Offset = "0x3D87120", VA = "0x183D88720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D886D0", Offset = "0x3D870D0", VA = "0x183D886D0")]
		public ManagedTexture(string AKEPBHBNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D88680", Offset = "0x3D87080", VA = "0x183D88680")]
		public ManagedTexture(string AKEPBHBNAIA, bool PJGLJAHOKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D87CB0", Offset = "0x3D866B0", VA = "0x183D87CB0")]
		public void FDILKFENFHL(RenderTexture INHCAPKLLBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D87ED0", Offset = "0x3D868D0", VA = "0x183D87ED0")]
		public global::GDHDNGFJPDI<byte[]> LIFHNNCLCEO(bool FPKJCNHJKCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D885D0", Offset = "0x3D86FD0", VA = "0x183D885D0")]
		public Texture2D PMHLHHDAMAH(ILJGCEAOGMM JKMAMOMKPNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D87850", Offset = "0x3D86250", VA = "0x183D87850")]
		public global::GDHDNGFJPDI<Texture2D> AFLCONIMEHN(ILJGCEAOGMM JKMAMOMKPNH, bool CFHNBBMMKMF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D87D30", Offset = "0x3D86730", VA = "0x183D87D30")]
		public global::GDHDNGFJPDI<byte[]> LFJCFKNFOFK(bool CFHNBBMMKMF = false, int FCGFGKFMIHI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D87B40", Offset = "0x3D86540", VA = "0x183D87B40")]
		public global::GDHDNGFJPDI<byte[]> EBICKBPOFLN(bool CFHNBBMMKMF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D88100", Offset = "0x3D86B00", VA = "0x183D88100")]
		private static global::GDHDNGFJPDI<Texture2D> OMEAJGBCKMB(string AKEPBHBNAIA, RenderTexture INHCAPKLLBE, ref Texture2D EDOFANANCBA, bool CFHNBBMMKMF, ILJGCEAOGMM FFHFKDFBNEC = ILJGCEAOGMM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D87AD0", Offset = "0x3D864D0", VA = "0x183D87AD0")]
		public void GDIDCAJMINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D87AD0", Offset = "0x3D864D0", VA = "0x183D87AD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D88060", Offset = "0x3D86A60", VA = "0x183D88060")]
		[CompilerGenerated]
		private global::GDHDNGFJPDI<byte[]> MHOLOIGAMEA(Texture2D AHGCFEJNILC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KFEHENNNMIN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D87630", Offset = "0x3D86030", VA = "0x183D87630")]
	public static RenderTexture BDKCFANNIMP(int PPHCJMNFGGD, int COLKENGHHHE, int LAOBEMNJLOH, Camera HEAMAKELOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D877A0", Offset = "0x3D861A0", VA = "0x183D877A0")]
	public static void CDDEFMNGJEG(RenderTexture INHCAPKLLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFOIAFEHIJM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LHHJOCICMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FACNBLLEKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OBELOGBIDAN;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC15EC0", Offset = "0xC148C0", VA = "0x180C15EC0")]
		public LHHJOCICMLF(int ECPFACPLOJI, int HIHCHEKBDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum KGEKGHCBELE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] JNMJMHICOHO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BMEGDIFEHJO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int EBPKCMGAIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float OFNKHKBLHCA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float IDMLOOPJLAD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int COJHAKCENLD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int DKLJBBBKCFC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex GDIFMBFFEPO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D89420", Offset = "0x3D87E20", VA = "0x183D89420")]
	public static void LHEAENLMMIM(Texture2D EPAEOJMHEIK, int PEAPBKPDHGN, int LHADNCFABML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D88A70", Offset = "0x3D87470", VA = "0x183D88A70")]
	private static void GLCBMJFGCMN(Texture2D EPAEOJMHEIK, int PEAPBKPDHGN, int LHADNCFABML, KGEKGHCBELE HHHGFONACDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D88F00", Offset = "0x3D87900", VA = "0x183D88F00")]
	public static void JHKPAOHFNON(object AEFCLOMAMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D88890", Offset = "0x3D87290", VA = "0x183D88890")]
	public static void BDBBAELPOIH(object AEFCLOMAMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D89440", Offset = "0x3D87E40", VA = "0x183D89440")]
	private static Color MLCKGAHHMPF(int IDCEIHIONGP, int ADCOBJDHEMO, float OFNKHKBLHCA, float IDMLOOPJLAD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D89600", Offset = "0x3D88000", VA = "0x183D89600")]
	public static void NKFPNJCDJFE(object AEFCLOMAMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D887A0", Offset = "0x3D871A0", VA = "0x183D887A0")]
	private static Color AHGLDIJFKLD(Color JJJDCHEOJCE, Color NPBNLKDMMGA, float MDAEJMIAMDO)
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
