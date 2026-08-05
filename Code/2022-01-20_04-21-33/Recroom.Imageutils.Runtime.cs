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
		[Cpp2IlInjected.Address(RVA = "0x44D6A10", Offset = "0x44D5210", VA = "0x1844D6A10")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GFNGPAHMDBL
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
public interface HBCDCKIFLFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GFNGPAHMDBL MLCMFNFLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LIBGJLGGMMH
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
			[Cpp2IlInjected.Address(RVA = "0x44D88A0", Offset = "0x44D70A0", VA = "0x1844D88A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x44D8890", Offset = "0x44D7090", VA = "0x1844D8890")]
		public Resolution(uint MMPPHFIGGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x739020", Offset = "0x737820", VA = "0x180739020")]
		public Resolution(uint MMPPHFIGGJG, uint CJNFJPHGPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x44D8740", Offset = "0x44D6F40", VA = "0x1844D8740")]
		public static Resolution CDPBFLJKAAO(Resolution[] HKEIPLLDANC, Resolution INPHPINABAA, int GNNHFFPAGKJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KDFIEAJEPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution IIOJJJLHJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? NADCFFMCGEI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint MMPPHFIGGJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x44D7040", Offset = "0x44D5840", VA = "0x1844D7040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint CJNFJPHGPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x44D6C50", Offset = "0x44D5450", VA = "0x1844D6C50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution IABHFLBMDBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x44D6C70", Offset = "0x44D5470", VA = "0x1844D6C70")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21387F0", Offset = "0x2136FF0", VA = "0x1821387F0")]
		public KDFIEAJEPGN(Resolution IIOJJJLHJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x44D6E70", Offset = "0x44D5670", VA = "0x1844D6E70")]
		private static Resolution NAIAHKELKAE(Resolution NADCFFMCGEI, GFNGPAHMDBL AJEPMEDFBMC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LMCOPMOPECA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HCMFBNBIMJJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JJGPIJPLOEP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BKLIFEDBODG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NBIKJMPEBNC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GGGLMHLFHGN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CNLIPAEMPJH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] AKDPLGODOIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LAHNMIMHIDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IGNGKHMOILG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DJMKCPJNNKG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution MMOMBLLKMJA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MDCAEMMCCDD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution NDOODBJFBFF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] AKDPLGODOIH;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x44D7050", Offset = "0x44D5850", VA = "0x1844D7050")]
		public static Resolution PDNEIJJFOBO(uint GPJFLMMLAIK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution KPEJMNIFPII;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x44D73E0", Offset = "0x44D5BE0", VA = "0x1844D73E0")]
	public static bool HBHCENANCKO(uint CMNGBHJHMJP)
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
		public enum NDHADLCKPAK : byte
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
		private class BJOPKCKEOFK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JKIKPMPMGPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D AFGDOAJHOME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NDHADLCKPAK CAKGGCDMLDB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x44D69D0", Offset = "0x44D51D0", VA = "0x1844D69D0")]
			public BJOPKCKEOFK(string JKIKPMPMGPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x197F690", Offset = "0x197DE90", VA = "0x18197F690")]
			public BJOPKCKEOFK(string JKIKPMPMGPL, Texture2D KAEOHNALHBP, NDHADLCKPAK CLOEIOGDMLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x44D69A0", Offset = "0x44D51A0", VA = "0x1844D69A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class INFGPBPEGCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NDHADLCKPAK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public INFGPBPEGCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44D6C10", Offset = "0x44D5410", VA = "0x1844D6C10")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NEPFLIOBGAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public NEPFLIOBGAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x44D8720", Offset = "0x44D6F20", VA = "0x1844D8720")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ACKJFFIBCCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public ACKJFFIBCCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x44D58E0", Offset = "0x44D40E0", VA = "0x1844D58E0")]
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
		private global::GHMNNNIJAKN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BJOPKCKEOFK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GHMNNNIJAKN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GHMNNNIJAKN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4DD850", Offset = "0x4DC050", VA = "0x1804DD850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BJOPKCKEOFK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x44D86A0", Offset = "0x44D6EA0", VA = "0x1844D86A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x44D8650", Offset = "0x44D6E50", VA = "0x1844D8650")]
		public ManagedTexture(string JKIKPMPMGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x44D8600", Offset = "0x44D6E00", VA = "0x1844D8600")]
		public ManagedTexture(string JKIKPMPMGPL, bool KBEOALIOEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44D81D0", Offset = "0x44D69D0", VA = "0x1844D81D0")]
		public void LJHJOJDDBCC(RenderTexture LAKBKEJJLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x44D7880", Offset = "0x44D6080", VA = "0x1844D7880")]
		public global::GHMNNNIJAKN<byte[]> CKFOIBGGCON(bool HKHMIPOGIPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44D7A10", Offset = "0x44D6210", VA = "0x1844D7A10")]
		public global::GHMNNNIJAKN<Texture2D> DNPJNPCHAHD(NDHADLCKPAK CLOEIOGDMLE, bool FBKCGECGKJO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44D8250", Offset = "0x44D6A50", VA = "0x1844D8250")]
		public global::GHMNNNIJAKN<byte[]> LNPELMKLJEM(bool FBKCGECGKJO = false, int MOKHIDICAKH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x44D83F0", Offset = "0x44D6BF0", VA = "0x1844D83F0")]
		public global::GHMNNNIJAKN<byte[]> NBNJHGJGHGE(bool FBKCGECGKJO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44D7D00", Offset = "0x44D6500", VA = "0x1844D7D00")]
		private static global::GHMNNNIJAKN<Texture2D> ENGMBHLHEON(string JKIKPMPMGPL, RenderTexture LAKBKEJJLMM, ref Texture2D AFNKHFLGAKE, bool FBKCGECGKJO, NDHADLCKPAK GGMOJGEBJKC = NDHADLCKPAK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x44D7C90", Offset = "0x44D6490", VA = "0x1844D7C90")]
		public void MDNNBKJANHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x44D7C90", Offset = "0x44D6490", VA = "0x1844D7C90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x44D8560", Offset = "0x44D6D60", VA = "0x1844D8560")]
		[CompilerGenerated]
		private global::GHMNNNIJAKN<byte[]> NFKAHBBPELL(Texture2D AAAFICHEHAO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ILHAJIOMENM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44D6AA0", Offset = "0x44D52A0", VA = "0x1844D6AA0")]
	public static RenderTexture JPDNOPLHMBD(int GPJFLMMLAIK, int DIEMBMHKCJB, int AMPIGIOMCIP, Camera LAPMKILKMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44D6A30", Offset = "0x44D5230", VA = "0x1844D6A30")]
	public static void AIDFEIONEBA(RenderTexture LAKBKEJJLMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AKOKCKMLGMG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LPHBBGAEFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int GMAAPIOBNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int FCNLKLHOGIB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x191C0C0", Offset = "0x191A8C0", VA = "0x18191C0C0")]
		public LPHBBGAEFHN(int FEGLBGKJJGM, int LKMCNIANCPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum BBMIOBFEJMK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] PBFLCAMNCCC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] PCMCOLMKKOI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int MBFPBJEPPGO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PEMCLDEDOGA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BOAOKEPFGBC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int IHFCPDFADPJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int NIOMACDLAKK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex PPIDLIMLDFF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x44D6980", Offset = "0x44D5180", VA = "0x1844D6980")]
	public static void MJPELJJDJKI(Texture2D EGADAGJNCGL, int HLOBFEFDOJM, int INKIHJIFFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44D6040", Offset = "0x44D4840", VA = "0x1844D6040")]
	private static void DIILLDFKBPL(Texture2D EGADAGJNCGL, int HLOBFEFDOJM, int INKIHJIFFFF, BBMIOBFEJMK GDPMFOOHFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44D5960", Offset = "0x44D4160", VA = "0x1844D5960")]
	public static void AIJIGLJGNNM(object ANEGDOBGOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44D64D0", Offset = "0x44D4CD0", VA = "0x1844D64D0")]
	public static void GIIHABLKINN(object ANEGDOBGOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44D5E80", Offset = "0x44D4680", VA = "0x1844D5E80")]
	private static Color BHKDJOIBPKD(int MMPPHFIGGJG, int CJNFJPHGPCE, float PEMCLDEDOGA, float BOAOKEPFGBC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44D67A0", Offset = "0x44D4FA0", VA = "0x1844D67A0")]
	public static void LBBBELBDDPN(object ANEGDOBGOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44D66B0", Offset = "0x44D4EB0", VA = "0x1844D66B0")]
	private static Color LAOEBGPJFOI(Color JCMJPNBCHJM, Color HDODOEFBAOD, float IJBLIGDNDKF)
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
