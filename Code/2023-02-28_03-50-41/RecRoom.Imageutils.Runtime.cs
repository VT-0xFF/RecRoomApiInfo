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
		[Cpp2IlInjected.Address(RVA = "0x6475430", Offset = "0x6473E30", VA = "0x186475430")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CFJLDOAHPHA
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
public interface AHJPDJFKGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CFJLDOAHPHA PDIDJAIGLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IKHHHDGDMKD
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
			[Cpp2IlInjected.Address(RVA = "0x6477E30", Offset = "0x6476830", VA = "0x186477E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6477E20", Offset = "0x6476820", VA = "0x186477E20")]
		public Resolution(uint MEALLDFELFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
		public Resolution(uint MEALLDFELFM, uint LOIOEMHMDAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6477D30", Offset = "0x6476730", VA = "0x186477D30")]
		public static Resolution ABJFFOGCBFB(Resolution[] KNNPANGLJLF, Resolution DPBNENNPDEB, int DKPILEBECNA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BIOMOLGDGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution GHIGIFMNJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GGCGMJKKFIE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint MEALLDFELFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6475000", Offset = "0x6473A00", VA = "0x186475000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint LOIOEMHMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x64751F0", Offset = "0x6473BF0", VA = "0x1864751F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution LCJIFDMNDEC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6475010", Offset = "0x6473A10", VA = "0x186475010")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E4C0", Offset = "0x1E2CEC0", VA = "0x181E2E4C0")]
		public BIOMOLGDGIH(Resolution GHIGIFMNJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6474E60", Offset = "0x6473860", VA = "0x186474E60")]
		private static Resolution DFAGNMNFOKE(Resolution GGCGMJKKFIE, CFJLDOAHPHA HKODEMIPDEL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IOGPGKKOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution NINNGBOMGMA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution FOOMOIEHJEK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BLOAKPHOCIP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution HGGLBGKEIFO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KILEKDHAKKP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HPKDONHGNGI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MMFGEFBKEEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class DCPGOJIOKLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BNGDKOKJGBN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution OOHBINGMPNE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IJLEEHHAGPP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NIOLEPBPJNE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GIMPOOMBFOL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MMFGEFBKEEF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6475450", Offset = "0x6473E50", VA = "0x186475450")]
		public static Resolution HDMFCBJPIDL(uint BPPJIBCDENC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution MFJONMOFJFD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64758A0", Offset = "0x64742A0", VA = "0x1864758A0")]
	public static bool DICNFOFJENI(uint DGGLLKFFEGP)
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
		public enum KIIMABFPAAA : byte
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
		private class PIEDDMHCGLG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string ANJJEPIBAGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D COHDHLLLKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KIIMABFPAAA PNCMGCPJCHF;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6476D30", Offset = "0x6475730", VA = "0x186476D30")]
			public PIEDDMHCGLG(string ANJJEPIBAGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C7750", Offset = "0x6C6150", VA = "0x1806C7750")]
			public PIEDDMHCGLG(string ANJJEPIBAGI, Texture2D NDIDBNMHFLO, KIIMABFPAAA NKCJGHIPDAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6476CF0", Offset = "0x64756F0", VA = "0x186476CF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AFIBCGGHCLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KIIMABFPAAA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public AFIBCGGHCLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6474E20", Offset = "0x6473820", VA = "0x186474E20")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LHMOPPJGMOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public LHMOPPJGMOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6475D80", Offset = "0x6474780", VA = "0x186475D80")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FNFOEDDIMCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public FNFOEDDIMCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6475810", Offset = "0x6474210", VA = "0x186475810")]
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
		private global::OHPLDOPGNGG<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PIEDDMHCGLG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::OHPLDOPGNGG<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::OHPLDOPGNGG<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6C5250", Offset = "0x6C3C50", VA = "0x1806C5250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PIEDDMHCGLG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6476C50", Offset = "0x6475650", VA = "0x186476C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6476C00", Offset = "0x6475600", VA = "0x186476C00")]
		public ManagedTexture(string ANJJEPIBAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6476BA0", Offset = "0x64755A0", VA = "0x186476BA0")]
		public ManagedTexture(string ANJJEPIBAGI, bool POCCBOOPOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64768F0", Offset = "0x64752F0", VA = "0x1864768F0")]
		public void JIEJPCEOMNF(RenderTexture BJJLINOJGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6475DB0", Offset = "0x64747B0", VA = "0x186475DB0")]
		public global::OHPLDOPGNGG<byte[]> FPDNMENLGMN(bool PLKKGDJMNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6475DD0", Offset = "0x64747D0", VA = "0x186475DD0")]
		public global::OHPLDOPGNGG<Texture2D> HMCJOMHBJBO(KIIMABFPAAA NKCJGHIPDAH, bool EEDNCNABAGA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6476640", Offset = "0x6475040", VA = "0x186476640")]
		public global::OHPLDOPGNGG<byte[]> HPEAFIONHCE(bool EEDNCNABAGA = false, int IBEPAHDFJOC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64769E0", Offset = "0x64753E0", VA = "0x1864769E0")]
		public global::OHPLDOPGNGG<byte[]> OLNAABBDDDL(bool EEDNCNABAGA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64760C0", Offset = "0x6474AC0", VA = "0x1864760C0")]
		private static global::OHPLDOPGNGG<Texture2D> HMHIPICLNND(string ANJJEPIBAGI, RenderTexture BJJLINOJGLF, ref Texture2D INHABGIDBJN, bool EEDNCNABAGA, KIIMABFPAAA DHFKPIKJLIC = KIIMABFPAAA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6476920", Offset = "0x6475320", VA = "0x186476920")]
		public void LAKIAPHOJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6475DA0", Offset = "0x64747A0", VA = "0x186475DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6476840", Offset = "0x6475240", VA = "0x186476840")]
		[CompilerGenerated]
		private global::OHPLDOPGNGG<byte[]> IBDEMHECOIH(Texture2D EEDBNBAONLM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BJANFCIEGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6475210", Offset = "0x6473C10", VA = "0x186475210")]
	public static RenderTexture FFCNJJLHFKH(int BPPJIBCDENC, int GKJBEJDBHAL, int GLPDCHNEBJK, Camera KOGINMHNNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x64753C0", Offset = "0x6473DC0", VA = "0x1864753C0")]
	public static void MDMIOLHBAGE(RenderTexture BJJLINOJGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PPBIIIHAKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KPFMGLOOANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int AGNHLFMCFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int PGDLDMBJJEP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x894920", Offset = "0x893320", VA = "0x180894920")]
		public KPFMGLOOANP(int GECCBCJHLMG, int NJOLKOHDHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum IINGLOOGAAN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] DIAEDBHCOIP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] JPJMDLNMPCD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int FJOCGIOEKMK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float AHEMCKAGMBN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float FABLKNAGPMD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MJIJNEKOPIP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int GPNIBKGPDPO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex GFBLGOKDOFG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6477680", Offset = "0x6476080", VA = "0x186477680")]
	public static void EBIDKJCFFCH(Texture2D JBOCBHCEPOA, int JPEKCBEDPFK, int HBOIDAIEPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6477840", Offset = "0x6476240", VA = "0x186477840")]
	private static void IOEIALFBEDE(Texture2D JBOCBHCEPOA, int JPEKCBEDPFK, int HBOIDAIEPBD, IINGLOOGAAN IHAILABECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6476D80", Offset = "0x6475780", VA = "0x186476D80")]
	public static void AAPMMIKKEEB(object LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64774B0", Offset = "0x6475EB0", VA = "0x1864774B0")]
	public static void CPKDOIDDKEA(object LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64776A0", Offset = "0x64760A0", VA = "0x1864776A0")]
	private static Color GOIOPNDDHFA(int MEALLDFELFM, int LOIOEMHMDAP, float AHEMCKAGMBN, float FABLKNAGPMD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x64772E0", Offset = "0x6475CE0", VA = "0x1864772E0")]
	public static void CAMMEFOBFHB(object LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6477200", Offset = "0x6475C00", VA = "0x186477200")]
	private static Color ABOPFHBILCI(Color BILOAAAPPMG, Color PLBMJGJLOGO, float MNIAGKNOHEJ)
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
