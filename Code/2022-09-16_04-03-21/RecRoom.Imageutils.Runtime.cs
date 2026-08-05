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
		[Cpp2IlInjected.Address(RVA = "0x41CE320", Offset = "0x41CCB20", VA = "0x1841CE320")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NBJPHLIMDAG
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
public interface JFEBEFKENBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NBJPHLIMDAG KJGODHAKEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NKMOGBOCMPF
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
			[Cpp2IlInjected.Address(RVA = "0x41D0E80", Offset = "0x41CF680", VA = "0x1841D0E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x41D0E70", Offset = "0x41CF670", VA = "0x1841D0E70")]
		public Resolution(uint FGCAOGJDCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
		public Resolution(uint FGCAOGJDCFC, uint JGCHHJHFEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x41D0D20", Offset = "0x41CF520", VA = "0x1841D0D20")]
		public static Resolution KFIHPKHPHDN(Resolution[] LEFCMJINHPL, Resolution POHAONOHFCK, int OPMBGIJOBGH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BDPEBONGIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution GFIGKKOKDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? AABDHBBPGGI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FGCAOGJDCFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x41CDF90", Offset = "0x41CC790", VA = "0x1841CDF90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JGCHHJHFEGN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x41CE170", Offset = "0x41CC970", VA = "0x1841CE170")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KLKNAGEEGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x41CE190", Offset = "0x41CC990", VA = "0x1841CE190")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1677590", Offset = "0x1675D90", VA = "0x181677590")]
		public BDPEBONGIBD(Resolution GFIGKKOKDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x41CDFA0", Offset = "0x41CC7A0", VA = "0x1841CDFA0")]
		private static Resolution JOCOKFJIDDF(Resolution AABDHBBPGGI, NBJPHLIMDAG JHGJIMAGMNH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OHGELJPGBJF
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution AODANCDNHMI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GEIDEGKDLJO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution EIGAEMDJMNN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GBOCJKMIMHH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EMGCICMPLOL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution KGNBDOJOOEP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] FHKDBHGEGEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OHBJENCEKCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IECFDPOCKMM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NGCPPIOFCEO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IMCJKMAEGGI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NICIJPEAJPA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution BAMIJBENOJJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] FHKDBHGEGEJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41CF6B0", Offset = "0x41CDEB0", VA = "0x1841CF6B0")]
		public static Resolution KCHOCOCJELC(uint AEHBFLGCOBN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution PICIGCHDBJF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x41CF470", Offset = "0x41CDC70", VA = "0x1841CF470")]
	public static bool EALPCMJDGKO(uint FEPMNJJPCCE)
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
		public enum NCKMILHIDLC : byte
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
		private class FFNGOLKEHME : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JNAACNJBHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D MDKJLIDJNFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NCKMILHIDLC MBLLOPOHFGP;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x41CE3A0", Offset = "0x41CCBA0", VA = "0x1841CE3A0")]
			public FFNGOLKEHME(string JNAACNJBHOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1811D70", Offset = "0x1810570", VA = "0x181811D70")]
			public FFNGOLKEHME(string JNAACNJBHOF, Texture2D EKLIOLALOMJ, NCKMILHIDLC HACJCPKCDIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x41CE360", Offset = "0x41CCB60", VA = "0x1841CE360", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JKBILFMEOMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NCKMILHIDLC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public JKBILFMEOMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x41CE3F0", Offset = "0x41CCBF0", VA = "0x1841CE3F0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FBCAMBNELPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public FBCAMBNELPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x41CE340", Offset = "0x41CCB40", VA = "0x1841CE340")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MKNJJODOFHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public MKNJJODOFHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x41CE610", Offset = "0x41CCE10", VA = "0x1841CE610")]
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
		private global::DCBCPMGHAFG<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FFNGOLKEHME _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DCBCPMGHAFG<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DCBCPMGHAFG<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6358A0", Offset = "0x6340A0", VA = "0x1806358A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FFNGOLKEHME memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x41CF3D0", Offset = "0x41CDBD0", VA = "0x1841CF3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x41CF320", Offset = "0x41CDB20", VA = "0x1841CF320")]
		public ManagedTexture(string JNAACNJBHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41CF370", Offset = "0x41CDB70", VA = "0x1841CF370")]
		public ManagedTexture(string JNAACNJBHOF, bool PNGBHKJEPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x41CEA20", Offset = "0x41CD220", VA = "0x1841CEA20")]
		public void LEDFKLGDDGA(RenderTexture MKPDKFFCGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41CEA00", Offset = "0x41CD200", VA = "0x1841CEA00")]
		public global::DCBCPMGHAFG<byte[]> JDEJNIDKEIC(bool AGPHMCMFKKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x41CE6B0", Offset = "0x41CCEB0", VA = "0x1841CE6B0")]
		public global::DCBCPMGHAFG<Texture2D> FDFFMJPCDFH(NCKMILHIDLC HACJCPKCDIP, bool MEMIOHDKCIM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41CEA50", Offset = "0x41CD250", VA = "0x1841CEA50")]
		public global::DCBCPMGHAFG<byte[]> LGMKPPFPPPN(bool MEMIOHDKCIM = false, int LLEBJLFLAPA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41CEC00", Offset = "0x41CD400", VA = "0x1841CEC00")]
		public global::DCBCPMGHAFG<byte[]> LOMBPFABNNI(bool MEMIOHDKCIM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41CED90", Offset = "0x41CD590", VA = "0x1841CED90")]
		private static global::DCBCPMGHAFG<Texture2D> MIIFNOAJPID(string JNAACNJBHOF, RenderTexture MKPDKFFCGAE, ref Texture2D FMBBNOJEBLJ, bool MEMIOHDKCIM, NCKMILHIDLC BKDFBNHCPBH = NCKMILHIDLC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41CE940", Offset = "0x41CD140", VA = "0x1841CE940")]
		public void HBPMOHNKEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41CE6A0", Offset = "0x41CCEA0", VA = "0x1841CE6A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41CF280", Offset = "0x41CDA80", VA = "0x1841CF280")]
		[CompilerGenerated]
		private global::DCBCPMGHAFG<byte[]> PEDIKPELNEB(Texture2D GDDEJOKGHDM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KINHEFOKPAD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41CE4A0", Offset = "0x41CCCA0", VA = "0x1841CE4A0")]
	public static RenderTexture HKEKCHEPADP(int AEHBFLGCOBN, int ELIOJOIGIEI, int MFPEABLOEDH, Camera ACGPANCDGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41CE430", Offset = "0x41CCC30", VA = "0x1841CE430")]
	public static void HHHICEHHKKG(RenderTexture MKPDKFFCGAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class POLNEOHCLAF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LNPFAJNLJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int MMECDMIFJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NOOMMODKENI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xE81930", Offset = "0xE80130", VA = "0x180E81930")]
		public LNPFAJNLJPP(int IEEOBFIBOGP, int HFHIFPILNEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum OEEIJMNBGBF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] KGECGBEOIPL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] OLMDBLBEEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JCMJAPLEPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JLFJNKIEINC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float KOLJNBEIFIN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int BJAKOCKPEEL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int BILPNEIIEDP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex EHMPHBPENPC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41D0170", Offset = "0x41CE970", VA = "0x1841D0170")]
	public static void LGILLOEIJOF(Texture2D KDDEJJMAGKJ, int LKNNJDPPMJB, int EOCPJOELOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41CFCC0", Offset = "0x41CE4C0", VA = "0x1841CFCC0")]
	private static void COHBMJJHLHA(Texture2D KDDEJJMAGKJ, int LKNNJDPPMJB, int EOCPJOELOPD, OEEIJMNBGBF HGELFNKJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41D0800", Offset = "0x41CF000", VA = "0x1841D0800")]
	public static void PJKLGBBIONK(object DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x41D0280", Offset = "0x41CEA80", VA = "0x1841D0280")]
	public static void NKFNKHOABDP(object DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41D0640", Offset = "0x41CEE40", VA = "0x1841D0640")]
	private static Color PIGHCIDIJJD(int FGCAOGJDCFC, int JGCHHJHFEGN, float JLFJNKIEINC, float KOLJNBEIFIN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41D0460", Offset = "0x41CEC60", VA = "0x1841D0460")]
	public static void NMMEDEFEFDJ(object DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41D0190", Offset = "0x41CE990", VA = "0x1841D0190")]
	private static Color NEOJBCOCLBO(Color JIOPFICDKKJ, Color LIICKLLBPAE, float CJMMBFLIBMO)
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
