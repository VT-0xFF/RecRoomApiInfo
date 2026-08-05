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
		[Cpp2IlInjected.Address(RVA = "0x4E12630", Offset = "0x4E11230", VA = "0x184E12630")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IKJBDHOKHJG
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
public interface AAGIADMBJIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IKJBDHOKHJG EFLCOCPLBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CPCKBDBONMJ
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
			[Cpp2IlInjected.Address(RVA = "0x4E15350", Offset = "0x4E13F50", VA = "0x184E15350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E15340", Offset = "0x4E13F40", VA = "0x184E15340")]
		public Resolution(uint JJCLMNFFLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F10", Offset = "0x6C1B10", VA = "0x1806C2F10")]
		public Resolution(uint JJCLMNFFLAC, uint ACPGHHFEOII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E151F0", Offset = "0x4E13DF0", VA = "0x184E151F0")]
		public static Resolution CFGAMEJCBMF(Resolution[] MKHBCPHFNPK, Resolution OEFONKMABEH, int AOGJINIBAPD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KPMLEBBJBOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution DBJPPGBDFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? FPEFIDJFCBG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JJCLMNFFLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4E12FA0", Offset = "0x4E11BA0", VA = "0x184E12FA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ACPGHHFEOII
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4E13380", Offset = "0x4E11F80", VA = "0x184E13380")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution AHLHMDGMHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E13180", Offset = "0x4E11D80", VA = "0x184E13180")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x135FB80", Offset = "0x135E780", VA = "0x18135FB80")]
		public KPMLEBBJBOC(Resolution DBJPPGBDFGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E12FB0", Offset = "0x4E11BB0", VA = "0x184E12FB0")]
		private static Resolution HGKLKDELCFC(Resolution FPEFIDJFCBG, IKJBDHOKHJG EHGCMLODJHE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EODEOAGJPCO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LGKEPPEDKDA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution MFIBBEGKLBO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LPEDGGNMFEH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PJOIBNCOBFN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution BGDKJBJNEJF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution AFPMCPCPDPN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HJKBNKHDIJO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IHJMAJOAELK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NIFGENPPCHM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JJLJBFDJNGB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KPAHHKBNJGF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NLGCOIFDKLN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OIDMDFFFNMC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HJKBNKHDIJO;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E12C00", Offset = "0x4E11800", VA = "0x184E12C00")]
		public static Resolution OECCENNMKDH(uint BJKKDBNGOID)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution GCAHFCALNDJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E123F0", Offset = "0x4E10FF0", VA = "0x184E123F0")]
	public static bool DHFIMHPKJEG(uint EDLICPJAHBP)
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
		public enum IKCCHAEBMNL : byte
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
		private class EFNBKKFGJNE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string HBGNDBNJDEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IPOHJCDCEIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IKCCHAEBMNL KDOHNMCMALJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4E126D0", Offset = "0x4E112D0", VA = "0x184E126D0")]
			public EFNBKKFGJNE(string HBGNDBNJDEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x831CA0", Offset = "0x8308A0", VA = "0x180831CA0")]
			public EFNBKKFGJNE(string HBGNDBNJDEC, Texture2D ADCOILNLEDD, IKCCHAEBMNL GCEEFNJELEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4E12690", Offset = "0x4E11290", VA = "0x184E12690", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DDLHJFDOCFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public IKCCHAEBMNL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public DDLHJFDOCFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4E12650", Offset = "0x4E11250", VA = "0x184E12650")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MAAJIDHDJIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public MAAJIDHDJIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4E133A0", Offset = "0x4E11FA0", VA = "0x184E133A0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HAJAOJOBNKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public HAJAOJOBNKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4E12B70", Offset = "0x4E11770", VA = "0x184E12B70")]
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
		private global::KKLFNGHEAIK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EFNBKKFGJNE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::KKLFNGHEAIK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::KKLFNGHEAIK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5877B0", Offset = "0x5863B0", VA = "0x1805877B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EFNBKKFGJNE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4E140F0", Offset = "0x4E12CF0", VA = "0x184E140F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E14040", Offset = "0x4E12C40", VA = "0x184E14040")]
		public ManagedTexture(string HBGNDBNJDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E14090", Offset = "0x4E12C90", VA = "0x184E14090")]
		public ManagedTexture(string HBGNDBNJDEC, bool NBMPGAAODLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E138A0", Offset = "0x4E124A0", VA = "0x184E138A0")]
		public void DMKMPPGKNBB(RenderTexture CHFJABMOHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E138E0", Offset = "0x4E124E0", VA = "0x184E138E0")]
		public global::KKLFNGHEAIK<byte[]> HEPICABBBBJ(bool JAAFAHMEAKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E13480", Offset = "0x4E12080", VA = "0x184E13480")]
		public global::KKLFNGHEAIK<Texture2D> BLPJLKBDIBP(IKCCHAEBMNL GCEEFNJELEN, bool EEJLGGHCCAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E13E90", Offset = "0x4E12A90", VA = "0x184E13E90")]
		public global::KKLFNGHEAIK<byte[]> LGGDNPNACIB(bool EEJLGGHCCAD = false, int NOLDMGFMNKK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4E13710", Offset = "0x4E12310", VA = "0x184E13710")]
		public global::KKLFNGHEAIK<byte[]> DCBOLHCLFDO(bool EEJLGGHCCAD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4E139A0", Offset = "0x4E125A0", VA = "0x184E139A0")]
		private static global::KKLFNGHEAIK<Texture2D> KKOMDFPBCAF(string HBGNDBNJDEC, RenderTexture CHFJABMOHCH, ref Texture2D CIBLDMNPICF, bool EEJLGGHCCAD, IKCCHAEBMNL CHHGFINDCJL = IKCCHAEBMNL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4E133C0", Offset = "0x4E11FC0", VA = "0x184E133C0")]
		public void BKLPIOJBLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E138D0", Offset = "0x4E124D0", VA = "0x184E138D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4E13900", Offset = "0x4E12500", VA = "0x184E13900")]
		[CompilerGenerated]
		private global::KKLFNGHEAIK<byte[]> KGFNMMIEKMO(Texture2D LEOEGNKHOAJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ENCONIDOAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E12790", Offset = "0x4E11390", VA = "0x184E12790")]
	public static RenderTexture OOHOBIABOPA(int BJKKDBNGOID, int HGMHHJIMLEJ, int ELNAPHFJDMH, Camera CEBGBJMCMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E12720", Offset = "0x4E11320", VA = "0x184E12720")]
	public static void EAHJCJOBBCA(RenderTexture CHFJABMOHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PJLKJNGMACE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JGPGDFNGOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int ALJNEIFKIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BBJPFDEKHCM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F5350", Offset = "0x5F3F50", VA = "0x1805F5350")]
		public JGPGDFNGOEO(int KJCBCBPOLJN, int GBDFGDELJEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum DNIFFILCIPB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] INGAHIMILGP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BFHEGAKFHHB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int FOLOKEFNILH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float IPHOENKIHDN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float PCNKBIKFPLE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int HCHKIKANBNG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int FIFOFBLHBNO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex GAPEMAOFMOM;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E150E0", Offset = "0x4E13CE0", VA = "0x184E150E0")]
	public static void KGHIGDMACKP(Texture2D HDCOAJDMBLO, int NOHAKNMOPJC, int EGFDOKLIAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E14370", Offset = "0x4E12F70", VA = "0x184E14370")]
	private static void AKCBLKNNMNN(Texture2D HDCOAJDMBLO, int NOHAKNMOPJC, int EGFDOKLIAIF, DNIFFILCIPB IAONOFEDCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E149E0", Offset = "0x4E135E0", VA = "0x184E149E0")]
	public static void KADPBIFLGMN(object NJBMHJCLPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E14190", Offset = "0x4E12D90", VA = "0x184E14190")]
	public static void ACKBDHENNOG(object NJBMHJCLPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E14820", Offset = "0x4E13420", VA = "0x184E14820")]
	private static Color ILAMENCOOKE(int JJCLMNFFLAC, int ACPGHHFEOII, float IPHOENKIHDN, float PCNKBIKFPLE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E14F00", Offset = "0x4E13B00", VA = "0x184E14F00")]
	public static void KBPOEEALLFO(object NJBMHJCLPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E15100", Offset = "0x4E13D00", VA = "0x184E15100")]
	private static Color NMIIEANJLBE(Color MICODMGFHLB, Color JHFIANBKMNI, float ODCJDJDBONO)
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
