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
		[Cpp2IlInjected.Address(RVA = "0x1E2ED70", Offset = "0x1E2D770", VA = "0x181E2ED70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum COJELDBHJEH
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
public interface MCNKEDJOELP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	COJELDBHJEH BGPAAOPBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KEHBOFJIDGL
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
			[Cpp2IlInjected.Address(RVA = "0x1E31CD0", Offset = "0x1E306D0", VA = "0x181E31CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E31CC0", Offset = "0x1E306C0", VA = "0x181E31CC0")]
		public Resolution(uint KCAHJOFJKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
		public Resolution(uint KCAHJOFJKBP, uint NBBBAMBDAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E31BD0", Offset = "0x1E305D0", VA = "0x181E31BD0")]
		public static Resolution BJKLJBGJKDK(Resolution[] GFLJMAGGCPJ, Resolution LJGFPKBDLCJ, int AFPBJPKNKPF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MELJFPAAIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution LDJCBIJLHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GOFKHDFJINA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint KCAHJOFJKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F2B0", Offset = "0x1E2DCB0", VA = "0x181E2F2B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint NBBBAMBDAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F2C0", Offset = "0x1E2DCC0", VA = "0x181E2F2C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution PKBPONAENGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F2E0", Offset = "0x1E2DCE0", VA = "0x181E2F2E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6AB0", Offset = "0x1BB54B0", VA = "0x181BB6AB0")]
		public MELJFPAAIGF(Resolution LDJCBIJLHGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F4C0", Offset = "0x1E2DEC0", VA = "0x181E2F4C0")]
		private static Resolution HLGLFGAIBFB(Resolution GOFKHDFJINA, COJELDBHJEH CDFICABEJBF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ICJFKGGBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OADEFIDBCBA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KPNADABBOKP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OFALLHKDAHK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OIEFCBIMFFF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PCICAHIIJEL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OJHKMHDGLII;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OJFOKNEBOLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PMFJJDHCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HMCGMJDCIKI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution BIKMENEAECG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution PEPDFAJOCCE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BILGBLDMOHB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KKGIIGLNNJB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OJFOKNEBOLL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E30860", Offset = "0x1E2F260", VA = "0x181E30860")]
		public static Resolution GFLNHKAMKAF(uint ALOPIDFKKAE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution OHLKIHCPPDO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F010", Offset = "0x1E2DA10", VA = "0x181E2F010")]
	public static bool DDCANOFEFFE(uint KAEOGOIHKNN)
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
		public enum LIAADKFMDEN : byte
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
		private class CBDJKAIPJAE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string KMEGKECOLPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D OMDJHBKHLPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LIAADKFMDEN NAIKAKOBMNH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E2ED20", Offset = "0x1E2D720", VA = "0x181E2ED20")]
			public CBDJKAIPJAE(string KMEGKECOLPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x937B60", Offset = "0x936560", VA = "0x180937B60")]
			public CBDJKAIPJAE(string KMEGKECOLPJ, Texture2D FFPBBECLOCP, LIAADKFMDEN DHKEBCOIOFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E2ECE0", Offset = "0x1E2D6E0", VA = "0x181E2ECE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LONHGIJHJJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LIAADKFMDEN textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public LONHGIJHJJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F270", Offset = "0x1E2DC70", VA = "0x181E2F270")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ACOBBIBKIIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public ACOBBIBKIIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E2ECC0", Offset = "0x1E2D6C0", VA = "0x181E2ECC0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MOCNNJBBBJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public MOCNNJBBBJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F660", Offset = "0x1E2E060", VA = "0x181E2F660")]
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
		private global::DJAOLOOILHN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CBDJKAIPJAE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DJAOLOOILHN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DJAOLOOILHN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CBDJKAIPJAE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1E305A0", Offset = "0x1E2EFA0", VA = "0x181E305A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E30550", Offset = "0x1E2EF50", VA = "0x181E30550")]
		public ManagedTexture(string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1E304F0", Offset = "0x1E2EEF0", VA = "0x181E304F0")]
		public ManagedTexture(string KMEGKECOLPJ, bool IIKBNHANDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F7D0", Offset = "0x1E2E1D0", VA = "0x181E2F7D0")]
		public void DBNGDHDNKHC(RenderTexture HLPCLJNMDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F6F0", Offset = "0x1E2E0F0", VA = "0x181E2F6F0")]
		public global::DJAOLOOILHN<byte[]> AHKIEHKMCII(bool BEJMGAEMECI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E30200", Offset = "0x1E2EC00", VA = "0x181E30200")]
		public global::DJAOLOOILHN<Texture2D> POHJOLBLKAP(LIAADKFMDEN DHKEBCOIOFA, bool EPAKEBIJCFB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F810", Offset = "0x1E2E210", VA = "0x181E2F810")]
		public global::DJAOLOOILHN<byte[]> GFGHNICDLPF(bool EPAKEBIJCFB = false, int OEONPGLKNNL = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FF90", Offset = "0x1E2E990", VA = "0x181E2FF90")]
		public global::DJAOLOOILHN<byte[]> KGKIMKOAHLG(bool EPAKEBIJCFB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FA10", Offset = "0x1E2E410", VA = "0x181E2FA10")]
		private static global::DJAOLOOILHN<Texture2D> HDHGPEIEFFL(string KMEGKECOLPJ, RenderTexture HLPCLJNMDJF, ref Texture2D GBAHLHKIANC, bool EPAKEBIJCFB, LIAADKFMDEN MPINAAMFPPO = LIAADKFMDEN.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F710", Offset = "0x1E2E110", VA = "0x181E2F710")]
		public void BIMBACDFKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F800", Offset = "0x1E2E200", VA = "0x181E2F800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E30150", Offset = "0x1E2EB50", VA = "0x181E30150")]
		[CompilerGenerated]
		private global::DJAOLOOILHN<byte[]> NENBGBBPDDJ(Texture2D FHIMFAOFBKP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PJIDLKGGPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E30640", Offset = "0x1E2F040", VA = "0x181E30640")]
	public static RenderTexture FDFDBMLGMFH(int ALOPIDFKKAE, int NKGGLAGGPGJ, int DJANDDPCBEN, Camera GDMBDAHFDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E307F0", Offset = "0x1E2F1F0", VA = "0x181E307F0")]
	public static void GGBJMOKEIDL(RenderTexture HLPCLJNMDJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PPFEACMMBGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class MNFPCNKIFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int ONAOKOFPGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int PCPMBKDCIED;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA74E0", VA = "0x180AA8AE0")]
		public MNFPCNKIFFA(int LLLCELNKBJD, int GMPDCLNOOMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum FKMEBIOHMID
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] LDLKIACHELB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] OKPDNLMGKAK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int IEKEOJNEALB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float OMBPGLLFPIL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float DLBOEJCPMJL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MBDOOELLJFD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PAJCLHEOLLE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex FGPDJIBLCEH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E312B0", Offset = "0x1E2FCB0", VA = "0x181E312B0")]
	public static void DHEKBIIOPNE(Texture2D DCFNCEJDDGN, int AMFPAFINNHM, int EBCCMKKLHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E30C20", Offset = "0x1E2F620", VA = "0x181E30C20")]
	private static void AOOKGKNHMBN(Texture2D DCFNCEJDDGN, int AMFPAFINNHM, int EBCCMKKLHGF, FKMEBIOHMID MOLJJKBPMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E31580", Offset = "0x1E2FF80", VA = "0x181E31580")]
	public static void KNJIMEEAMND(object OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E313B0", Offset = "0x1E2FDB0", VA = "0x181E313B0")]
	public static void ICFDCAEBKMJ(object OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E31110", Offset = "0x1E2FB10", VA = "0x181E31110")]
	private static Color CCLLAPICCBE(int KCAHJOFJKBP, int NBBBAMBDAJJ, float OMBPGLLFPIL, float DLBOEJCPMJL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1E31A00", Offset = "0x1E30400", VA = "0x181E31A00")]
	public static void MIMOBHDOLAG(object OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E312D0", Offset = "0x1E2FCD0", VA = "0x181E312D0")]
	private static Color HGPPOOFNPAI(Color FPKOFBPANEP, Color NPLPBLCHEHA, float MFBGAMJDOKA)
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
