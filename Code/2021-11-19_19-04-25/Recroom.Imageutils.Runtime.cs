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
		[Cpp2IlInjected.Address(RVA = "0x3D7AFE0", Offset = "0x3D79FE0", VA = "0x183D7AFE0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LCLKAMJFDLC
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
public interface NLAHCIBEAGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LCLKAMJFDLC DBILLBKKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BHHJBOHBCMH
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
			[Cpp2IlInjected.Address(RVA = "0x3D7DDF0", Offset = "0x3D7CDF0", VA = "0x183D7DDF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DDE0", Offset = "0x3D7CDE0", VA = "0x183D7DDE0")]
		public Resolution(uint OAEOFMJBBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x566A50", Offset = "0x565A50", VA = "0x180566A50")]
		public Resolution(uint OAEOFMJBBBF, uint ICAAGKKPPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DC90", Offset = "0x3D7CC90", VA = "0x183D7DC90")]
		public static Resolution GJLPKOPCHGO(Resolution[] EJCLAKHKNKL, Resolution OLGGMHFGNHI, int JIKMJGFMHPO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MMCNPADKIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution OMCAEAJMIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? FGMLDHJODJA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint OAEOFMJBBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C950", Offset = "0x3D7B950", VA = "0x183D7C950")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ICAAGKKPPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C760", Offset = "0x3D7B760", VA = "0x183D7C760")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution LDIOAAHPENE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C960", Offset = "0x3D7B960", VA = "0x183D7C960")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x24186A0", Offset = "0x24176A0", VA = "0x1824186A0")]
		public MMCNPADKIDB(Resolution OMCAEAJMIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C780", Offset = "0x3D7B780", VA = "0x183D7C780")]
		private static Resolution DFBCNAKFCDK(Resolution FGMLDHJODJA, LCLKAMJFDLC KEMGMMMKAJA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ILGBCMHOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution NCILOAPIGFC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution CHLINGDHEOO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BBJBNOHOIMH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GKAJFLGBGND;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PDGIAHNMHMJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DGBGLCGFKEJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] BKKHMJJPGFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MCPFIMGDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution DFLEEOIPLJL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FDNNHPCNGBI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OCPDAKHBGOC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution EELNPGIAMPP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution EFDMJFAKEDH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] BKKHMJJPGFE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C3D0", Offset = "0x3D7B3D0", VA = "0x183D7C3D0")]
		public static Resolution BFELIJNJOOK(uint DFGDNDKBCDL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution CKHPGOLCGIH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D7ADA0", Offset = "0x3D79DA0", VA = "0x183D7ADA0")]
	public static bool MEKCINEPKBD(uint FCHBCEMBDLP)
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
		public enum KGBNLBBCPMJ : byte
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
		private class EKADHAHKOMN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string PNEIKPKKABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DPDGOGDEFPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KGBNLBBCPMJ CMDBPGHAIOD;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B070", Offset = "0x3D7A070", VA = "0x183D7B070")]
			public EKADHAHKOMN(string PNEIKPKKABO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x79C510", Offset = "0x79B510", VA = "0x18079C510")]
			public EKADHAHKOMN(string PNEIKPKKABO, Texture2D PJPNNHHBPHG, KGBNLBBCPMJ DLLPKCCIJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B040", Offset = "0x3D7A040", VA = "0x183D7B040", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DKMNFFGEOGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KGBNLBBCPMJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public DKMNFFGEOGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B000", Offset = "0x3D7A000", VA = "0x183D7B000")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BBAPEBOOPJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public BBAPEBOOPJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D7AD80", Offset = "0x3D79D80", VA = "0x183D7AD80")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GBEHCCJEBHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public GBEHCCJEBHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B0B0", Offset = "0x3D7A0B0", VA = "0x183D7B0B0")]
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
		private global::CFGAGIADBID<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EKADHAHKOMN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::CFGAGIADBID<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::CFGAGIADBID<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x452180", Offset = "0x451180", VA = "0x180452180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x42ACF0", Offset = "0x429CF0", VA = "0x18042ACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4517D0", Offset = "0x4507D0", VA = "0x1804517D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EKADHAHKOMN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3D7DA30", Offset = "0x3D7CA30", VA = "0x183D7DA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D9E0", Offset = "0x3D7C9E0", VA = "0x183D7D9E0")]
		public ManagedTexture(string PNEIKPKKABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D990", Offset = "0x3D7C990", VA = "0x183D7D990")]
		public ManagedTexture(string PNEIKPKKABO, bool DLHGFNHLEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D910", Offset = "0x3D7C910", VA = "0x183D7D910")]
		public void PPNILDALANB(RenderTexture IKPLIDAIDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CBD0", Offset = "0x3D7BBD0", VA = "0x183D7CBD0")]
		public global::CFGAGIADBID<byte[]> FGKNLKCHFAE(bool OJOAODFAAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CD60", Offset = "0x3D7BD60", VA = "0x183D7CD60")]
		public Texture2D FOJOHNHKMFA(KGBNLBBCPMJ DLLPKCCIJOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D690", Offset = "0x3D7C690", VA = "0x183D7D690")]
		public global::CFGAGIADBID<Texture2D> OFPNNENDBGA(KGBNLBBCPMJ DLLPKCCIJOF, bool JIHCKLJFCGB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CEB0", Offset = "0x3D7BEB0", VA = "0x183D7CEB0")]
		public global::CFGAGIADBID<byte[]> KHJCBHPBOEO(bool JIHCKLJFCGB = false, int JCNMCFKINCH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D520", Offset = "0x3D7C520", VA = "0x183D7D520")]
		public global::CFGAGIADBID<byte[]> OEEPCGJLAID(bool JIHCKLJFCGB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D050", Offset = "0x3D7C050", VA = "0x183D7D050")]
		private static global::CFGAGIADBID<Texture2D> LEEKHNEJIAF(string PNEIKPKKABO, RenderTexture IKPLIDAIDCF, ref Texture2D DHLCFAFJLFP, bool JIHCKLJFCGB, KGBNLBBCPMJ JFFBEBPNNBE = KGBNLBBCPMJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CB60", Offset = "0x3D7BB60", VA = "0x183D7CB60")]
		public void LAGKHGBBBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CB60", Offset = "0x3D7BB60", VA = "0x183D7CB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CE10", Offset = "0x3D7BE10", VA = "0x183D7CE10")]
		[CompilerGenerated]
		private global::CFGAGIADBID<byte[]> JINLJIMCELC(Texture2D LHELMIOKBAJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OKOJAIJEACF
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DAB0", Offset = "0x3D7CAB0", VA = "0x183D7DAB0")]
	public static RenderTexture HDFDMNGBIEE(int DFGDNDKBCDL, int OMNNOEDBGGO, int PEAJNJDBLJK, Camera FKONCFMMAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DC20", Offset = "0x3D7CC20", VA = "0x183D7DC20")]
	public static void KPHMAPPBHMA(RenderTexture IKPLIDAIDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HNPFMIDLJLL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ADIGGJLCBNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int BONAJLLGINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BBNEPPEJIHH;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x93ED30", Offset = "0x93DD30", VA = "0x18093ED30")]
		public ADIGGJLCBNA(int NDJOILBCAAM, int GNHMBININJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum KFKAFANEBPG
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] NCLOMONGDEN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BKBODCEONBM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JMBFFBABLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float NFPGIHMEBDA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float MOGIDEIPKJI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EBGKIEDCNFM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int GEDNHFPHDKA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex LNOCIHIMNAE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B220", Offset = "0x3D7A220", VA = "0x183D7B220")]
	public static void GGCEDIJNPOM(Texture2D COPKOJBNMLI, int KCONMIGKCNG, int OEECAPFCGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B760", Offset = "0x3D7A760", VA = "0x183D7B760")]
	private static void ICIMLHJNIHN(Texture2D COPKOJBNMLI, int KCONMIGKCNG, int OEECAPFCGEL, KFKAFANEBPG JOPEPDKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B240", Offset = "0x3D7A240", VA = "0x183D7B240")]
	public static void HBADKKJGLEI(object KFEIKGNAKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BBF0", Offset = "0x3D7ABF0", VA = "0x183D7BBF0")]
	public static void IEEDOLPKDHG(object KFEIKGNAKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BDD0", Offset = "0x3D7ADD0", VA = "0x183D7BDD0")]
	private static Color JOLBAFBOPFJ(int OAEOFMJBBBF, int ICAAGKKPPGJ, float NFPGIHMEBDA, float MOGIDEIPKJI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BF90", Offset = "0x3D7AF90", VA = "0x183D7BF90")]
	public static void KEAIMNPIFDH(object KFEIKGNAKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B130", Offset = "0x3D7A130", VA = "0x183D7B130")]
	private static Color BGEIAJGONKL(Color FAGLIODJBMM, Color PEONGJFFCLF, float DAPPHEJJLEB)
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
