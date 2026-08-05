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
		[Cpp2IlInjected.Address(RVA = "0x4E81420", Offset = "0x4E7FE20", VA = "0x184E81420")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LMECGEIEKIE
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
public interface BNOLDMEPBDH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LMECGEIEKIE MPMCIHINEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DFDJHAPHEEN
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
			[Cpp2IlInjected.Address(RVA = "0x4E83EF0", Offset = "0x4E828F0", VA = "0x184E83EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E83EE0", Offset = "0x4E828E0", VA = "0x184E83EE0")]
		public Resolution(uint EDIMMNEBDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D4FB0", Offset = "0x6D39B0", VA = "0x1806D4FB0")]
		public Resolution(uint EDIMMNEBDAA, uint MLMOIBACOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E83D90", Offset = "0x4E82790", VA = "0x184E83D90")]
		public static Resolution EIHLNBMPDCE(Resolution[] GDHBDAMECLA, Resolution BHKAIOODIHA, int CNPFMAFDNPP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BOINCALFBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution GBAJJGKAGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? MLJOICPGJMG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint EDIMMNEBDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4E81040", Offset = "0x4E7FA40", VA = "0x184E81040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint MLMOIBACOIG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4E81020", Offset = "0x4E7FA20", VA = "0x184E81020")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution MNHDKNIDFDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E81220", Offset = "0x4E7FC20", VA = "0x184E81220")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E0220", Offset = "0x5DEC20", VA = "0x1805E0220")]
		public BOINCALFBCB(Resolution GBAJJGKAGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E81050", Offset = "0x4E7FA50", VA = "0x184E81050")]
		private static Resolution IAMPKOLPFDD(Resolution MLJOICPGJMG, LMECGEIEKIE FFHDAPABAPC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HICNAOCHBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CJHBCPFNCPG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution FGBLNCMLPCI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution FGFCFMICBOD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GCGAOBJLNPB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GFFFONJCGFB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FBDPIMCDGLF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] NJIHFMGKAPK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JGPPFBKNHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BFHDDNONJFB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution EGAPKAILFJB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KHHMLPPGDDP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HCJMCHKDAAL;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FDJAOMGGCLI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] NJIHFMGKAPK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E82970", Offset = "0x4E81370", VA = "0x184E82970")]
		public static Resolution EGBHHKPIJKD(uint IHCNDPNEGKP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NNPOGLGHEMK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E81440", Offset = "0x4E7FE40", VA = "0x184E81440")]
	public static bool KJAOGLKPBCF(uint LNDGKDFBCJM)
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
		public enum CAIJKEPNLLI : byte
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
		private class BJAFGLMIKHJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JMIBJFINBJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IMCMPNCJCBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CAIJKEPNLLI IPKPLKCCCHC;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4E80FD0", Offset = "0x4E7F9D0", VA = "0x184E80FD0")]
			public BJAFGLMIKHJ(string JMIBJFINBJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7645E0", Offset = "0x762FE0", VA = "0x1807645E0")]
			public BJAFGLMIKHJ(string JMIBJFINBJD, Texture2D HLKODLEBFAC, CAIJKEPNLLI KPHFDLIMCKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4E80F90", Offset = "0x4E7F990", VA = "0x184E80F90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JNCFPJINKAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CAIJKEPNLLI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public JNCFPJINKAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4E82D10", Offset = "0x4E81710", VA = "0x184E82D10")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FPDFEFDDDON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public FPDFEFDDDON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4E81680", Offset = "0x4E80080", VA = "0x184E81680")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LBAJKEDDEFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public LBAJKEDDEFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4E82D50", Offset = "0x4E81750", VA = "0x184E82D50")]
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
		private global::HJGFLNHHJHD<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BJAFGLMIKHJ _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HJGFLNHHJHD<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HJGFLNHHJHD<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5B33E0", Offset = "0x5B1DE0", VA = "0x1805B33E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BJAFGLMIKHJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4E83CF0", Offset = "0x4E826F0", VA = "0x184E83CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E83C40", Offset = "0x4E82640", VA = "0x184E83C40")]
		public ManagedTexture(string JMIBJFINBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E83C90", Offset = "0x4E82690", VA = "0x184E83C90")]
		public ManagedTexture(string JMIBJFINBJD, bool EJELEHCFOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E83160", Offset = "0x4E81B60", VA = "0x184E83160")]
		public void FHLCBJIFJJP(RenderTexture CAPOKNNNMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E83990", Offset = "0x4E82390", VA = "0x184E83990")]
		public global::HJGFLNHHJHD<byte[]> MEKKFNDNIBC(bool NGKPDPDAEIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E839B0", Offset = "0x4E823B0", VA = "0x184E839B0")]
		public global::HJGFLNHHJHD<Texture2D> OFAJNGLOHKG(CAIJKEPNLLI KPHFDLIMCKF, bool JAIPKDKFBGO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E83250", Offset = "0x4E81C50", VA = "0x184E83250")]
		public global::HJGFLNHHJHD<byte[]> HNLAOHGCAPJ(bool JAIPKDKFBGO = false, int DCFINGKKEDC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4E82FC0", Offset = "0x4E819C0", VA = "0x184E82FC0")]
		public global::HJGFLNHHJHD<byte[]> CKCDCGIAMGF(bool JAIPKDKFBGO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4E834A0", Offset = "0x4E81EA0", VA = "0x184E834A0")]
		private static global::HJGFLNHHJHD<Texture2D> MCNDEOKNNKH(string JMIBJFINBJD, RenderTexture CAPOKNNNMHJ, ref Texture2D JCBCFBLAELE, bool JAIPKDKFBGO, CAIJKEPNLLI MFIEGCCLDND = CAIJKEPNLLI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4E83190", Offset = "0x4E81B90", VA = "0x184E83190")]
		public void FKAMBOKFIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E83150", Offset = "0x4E81B50", VA = "0x184E83150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4E83400", Offset = "0x4E81E00", VA = "0x184E83400")]
		[CompilerGenerated]
		private global::HJGFLNHHJHD<byte[]> LOOLJKAKDGN(Texture2D MNDNDFDFOJP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LCDNNDEJLAF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E82E50", Offset = "0x4E81850", VA = "0x184E82E50")]
	public static RenderTexture KMHJPINPLKD(int IHCNDPNEGKP, int CNICIJGDLJM, int FBHGCDEDLKH, Camera DCPNDANMLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E82DE0", Offset = "0x4E817E0", VA = "0x184E82DE0")]
	public static void GHOAIOOEHPE(RenderTexture CAPOKNNNMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HMACDMFLFIO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CDIIOECAALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FPGEEBEFGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OLBLGDADAAO;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AECE0", Offset = "0x6AD6E0", VA = "0x1806AECE0")]
		public CDIIOECAALI(int GMKEBMDCCCF, int OIFFLJDLBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum DNPFHBIELAF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] AJIKGFHFMOM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] EJDCALJCEDH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DECECNMMIBM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float CLNAOONOEPK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BMCICLIDKCF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int NGNKNKFFFGM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int EPDICLIHFNA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex NONMMIMLLKD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E81910", Offset = "0x4E80310", VA = "0x184E81910")]
	public static void JKBGONKHGGE(Texture2D CGDNDGHCIHP, int MKPNLAJDBBL, int BGLOAGOOKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E81B10", Offset = "0x4E80510", VA = "0x184E81B10")]
	private static void KIGGFBPMOHB(Texture2D CGDNDGHCIHP, int MKPNLAJDBBL, int BGLOAGOOKGF, DNPFHBIELAF EKIPPGBDPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E81FC0", Offset = "0x4E809C0", VA = "0x184E81FC0")]
	public static void LOGOFCAJPIG(object FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E826A0", Offset = "0x4E810A0", VA = "0x184E826A0")]
	public static void NEGMOHELDJF(object FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E824E0", Offset = "0x4E80EE0", VA = "0x184E824E0")]
	private static Color MKFEMDHNGIG(int EDIMMNEBDAA, int MLMOIBACOIG, float CLNAOONOEPK, float BMCICLIDKCF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E81930", Offset = "0x4E80330", VA = "0x184E81930")]
	public static void JLGPCFFKPJM(object FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E82880", Offset = "0x4E81280", VA = "0x184E82880")]
	private static Color PLNHMGEFEIP(Color KCNPEAFMLMP, Color ELGJFAHEPLD, float HPIAFNBPEPC)
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
