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
		[Cpp2IlInjected.Address(RVA = "0x46E9ED0", Offset = "0x46E8CD0", VA = "0x1846E9ED0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PLMJHMPAPIN
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
public interface FCIDHLKJOPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PLMJHMPAPIN OPKOALEPHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PAHEKNFAACH
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
			[Cpp2IlInjected.Address(RVA = "0x46EC9A0", Offset = "0x46EB7A0", VA = "0x1846EC9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46EC990", Offset = "0x46EB790", VA = "0x1846EC990")]
		public Resolution(uint EDNAGLDPNGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FFBD0", Offset = "0x5FE9D0", VA = "0x1805FFBD0")]
		public Resolution(uint EDNAGLDPNGD, uint HJDKKMBJJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x46EC840", Offset = "0x46EB640", VA = "0x1846EC840")]
		public static Resolution HKHIPPINOFN(Resolution[] PGIHFCDPNFF, Resolution CLKDFBMNOBP, int HKLBBNCPMHI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CMNPBKLAHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution AJEIJECLEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? BDONFPDIOOG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint EDNAGLDPNGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x46E9AF0", Offset = "0x46E88F0", VA = "0x1846E9AF0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HJDKKMBJJBB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x46E9AD0", Offset = "0x46E88D0", VA = "0x1846E9AD0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FDJEAKGLIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x46E9B00", Offset = "0x46E8900", VA = "0x1846E9B00")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC380", Offset = "0x1DFB180", VA = "0x181DFC380")]
		public CMNPBKLAHAD(Resolution AJEIJECLEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x46E9D00", Offset = "0x46E8B00", VA = "0x1846E9D00")]
		private static Resolution PHGNHGEBHHD(Resolution BDONFPDIOOG, PLMJHMPAPIN FIMGAPHMKHE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GLGPMIMKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FBAKHBPPMBG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution HCCKPJGNCFO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution HFBGDFMKNDE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution ILCHMMEDIOK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HMAHEGEFEKO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HOOMJFENHDH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] CICEEFCOJIN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OGNNKDIKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BDLDEEHCPND;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FKMOEODCPOF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CJFGCNJCOAD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JBIEPFDNCBH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution LFDHKKAPDPM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] CICEEFCOJIN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x46EC040", Offset = "0x46EAE40", VA = "0x1846EC040")]
		public static Resolution JHFFEAOLFFK(uint JMAKKLHKKNM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NNOKPLCHHGL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x46EC420", Offset = "0x46EB220", VA = "0x1846EC420")]
	public static bool EEEENHGKJKN(uint LCONGDGPGJN)
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
		public enum NEJFPNELIGI : byte
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
		private class LBEALCKKFNF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string PEFIPPNHHCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D JFEDMANNNEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NEJFPNELIGI GJECKAGIFJJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x46EB200", Offset = "0x46EA000", VA = "0x1846EB200")]
			public LBEALCKKFNF(string PEFIPPNHHCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7C97E0", Offset = "0x7C85E0", VA = "0x1807C97E0")]
			public LBEALCKKFNF(string PEFIPPNHHCC, Texture2D HMMECBOPDPC, NEJFPNELIGI JPNNHPKNEMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x46EB1C0", Offset = "0x46E9FC0", VA = "0x1846EB1C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OKGKIFAGFGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NEJFPNELIGI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public OKGKIFAGFGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x46EC3E0", Offset = "0x46EB1E0", VA = "0x1846EC3E0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NMBNLILBJGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public NMBNLILBJGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x46EC020", Offset = "0x46EAE20", VA = "0x1846EC020")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BHFANBKLGFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public BHFANBKLGFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x46E9A40", Offset = "0x46E8840", VA = "0x1846E9A40")]
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
		private global::DIPKCKEGDMM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LBEALCKKFNF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DIPKCKEGDMM<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DIPKCKEGDMM<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5147B0", Offset = "0x5135B0", VA = "0x1805147B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LBEALCKKFNF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x46EBF80", Offset = "0x46EAD80", VA = "0x1846EBF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x46EBF30", Offset = "0x46EAD30", VA = "0x1846EBF30")]
		public ManagedTexture(string PEFIPPNHHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x46EBED0", Offset = "0x46EACD0", VA = "0x1846EBED0")]
		public ManagedTexture(string PEFIPPNHHCC, bool LHPEBDFOGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46EB8F0", Offset = "0x46EA6F0", VA = "0x1846EB8F0")]
		public void IPBKHJCLAPA(RenderTexture BNGFKKLDMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46EB920", Offset = "0x46EA720", VA = "0x1846EB920")]
		public global::DIPKCKEGDMM<byte[]> IPMFAFPGHDG(bool GFMDMINAOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46EB660", Offset = "0x46EA460", VA = "0x1846EB660")]
		public global::DIPKCKEGDMM<Texture2D> IJMMEGHGCGA(NEJFPNELIGI JPNNHPKNEMK, bool FNFIOFAMMCO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x46EB320", Offset = "0x46EA120", VA = "0x1846EB320")]
		public global::DIPKCKEGDMM<byte[]> GOPGIJILHHK(bool FNFIOFAMMCO = false, int KODPAOLLNAJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x46EB4D0", Offset = "0x46EA2D0", VA = "0x1846EB4D0")]
		public global::DIPKCKEGDMM<byte[]> IFLFIJLFFPJ(bool FNFIOFAMMCO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x46EB940", Offset = "0x46EA740", VA = "0x1846EB940")]
		private static global::DIPKCKEGDMM<Texture2D> MNGMCIDPNLB(string PEFIPPNHHCC, RenderTexture BNGFKKLDMMO, ref Texture2D BDIDMGOGKJN, bool FNFIOFAMMCO, NEJFPNELIGI OOCNLHJBOAI = NEJFPNELIGI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x46EB260", Offset = "0x46EA060", VA = "0x1846EB260")]
		public void GNBPMAGLACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x46EB250", Offset = "0x46EA050", VA = "0x1846EB250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46EBE30", Offset = "0x46EAC30", VA = "0x1846EBE30")]
		[CompilerGenerated]
		private global::DIPKCKEGDMM<byte[]> OBBGPFOBAGA(Texture2D CKLMBPGIOAI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PEAAJJIOBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46EC6D0", Offset = "0x46EB4D0", VA = "0x1846EC6D0")]
	public static RenderTexture HIJPDAAHKBE(int JMAKKLHKKNM, int NAHDLKIEPKI, int CLAMJJFEMKM, Camera MNCEHOOLENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46EC660", Offset = "0x46EB460", VA = "0x1846EC660")]
	public static void AECCOHDHDJG(RenderTexture BNGFKKLDMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IMFBAJCIEMK
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OHMPEKPOHAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int KLECEBFFJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int LNIPNLFCLMK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA02B60", Offset = "0xA01960", VA = "0x180A02B60")]
		public OHMPEKPOHAL(int LCIGAPLCBHD, int KCOCMOEHLHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum KFDFPJFBMIK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] BPPCCKIAACM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] AKJNLKFDAAD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JBAGFJNJFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float GCONCOJHKPA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float GNJIKMEEFMH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MAPJLOMPAKD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KFOHBNKAJHO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex KJBMKDOOMOF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46EA860", Offset = "0x46E9660", VA = "0x1846EA860")]
	public static void INMOAJFGIOK(Texture2D IMGONIFHLLH, int GBNJAPNOFJL, int ICGFJBPAPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46EAD10", Offset = "0x46E9B10", VA = "0x1846EAD10")]
	private static void KHPPBOEGEPC(Texture2D IMGONIFHLLH, int GBNJAPNOFJL, int ICGFJBPAPPE, KFDFPJFBMIK KHNAOLFADNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46EA340", Offset = "0x46E9140", VA = "0x1846EA340")]
	public static void HMHDOEBJLGO(object OBJNDDPFMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46EA970", Offset = "0x46E9770", VA = "0x1846EA970")]
	public static void JLKFGNDIDCI(object OBJNDDPFMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46EAB50", Offset = "0x46E9950", VA = "0x1846EAB50")]
	private static Color JNCGKOBFICE(int EDNAGLDPNGD, int HJDKKMBJJBB, float GCONCOJHKPA, float GNJIKMEEFMH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46EA160", Offset = "0x46E8F60", VA = "0x1846EA160")]
	public static void HHKBACNFHHN(object OBJNDDPFMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46EA880", Offset = "0x46E9680", VA = "0x1846EA880")]
	private static Color JKPMAAOLIEC(Color DGOFFGGLONO, Color FKJEDHONLKP, float LNPFAODMJGO)
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
