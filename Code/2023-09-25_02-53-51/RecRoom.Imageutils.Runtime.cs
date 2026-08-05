using System;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x5CDBB80", Offset = "0x5CDAF80", VA = "0x185CDBB80")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DFGLHJJNCJG
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
public interface NBFNJAAHIID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DFGLHJJNCJG LAFBGDBBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJPIOIPNIJE
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
			[Cpp2IlInjected.Address(RVA = "0x5CDDB50", Offset = "0x5CDCF50", VA = "0x185CDDB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDB40", Offset = "0x5CDCF40", VA = "0x185CDDB40")]
		public Resolution(uint DCLOFHDPPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
		public Resolution(uint DCLOFHDPPBE, uint JMNKJKLHIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDA50", Offset = "0x5CDCE50", VA = "0x185CDDA50")]
		public static Resolution FMOCGKBELJJ(Resolution[] MJHKFBFAIOB, Resolution CPJNEJJIJLB, int LCIGNEABEBI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DKDNFNKGCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution ALCGALHDCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? LNGCHBMNPBE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint DCLOFHDPPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBF00", Offset = "0x5CDB300", VA = "0x185CDBF00")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JMNKJKLHIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBBA0", Offset = "0x5CDAFA0", VA = "0x185CDBBA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HCCLPBMKIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBBC0", Offset = "0x5CDAFC0", VA = "0x185CDBBC0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17F3640", Offset = "0x17F2A40", VA = "0x1817F3640")]
		public DKDNFNKGCGB(Resolution ALCGALHDCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBF10", Offset = "0x5CDB310", VA = "0x185CDBF10")]
		private static Resolution MLBLDEPPDGP(Resolution LNGCHBMNPBE, DFGLHJJNCJG GLANKFGJPFB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ELKLLCHLMKC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BGGNGBAJONL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution APCMFPOKOKF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KDJIHKOAFOG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LIMMKHBLJIC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NMIPLLFFFOJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BDMIOPFJNFK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MLEIHEMOGDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EIMKOCFGFDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution DNINMCDFMJE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CFPMGBHAIHH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution MGIKOHHBJEM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution AAPJOHMOBOD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KDADNDKLBCI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MLEIHEMOGDE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC090", Offset = "0x5CDB490", VA = "0x185CDC090")]
		public static Resolution BBBCEBDKPLK(uint HAAINFBDEEH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution ENKKKCBJEFN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD820", Offset = "0x5CDCC20", VA = "0x185CDD820")]
	public static bool EPBOJDFFIBJ(uint HLNLIABFHFM)
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
		public enum MJDPBEAMAIE : byte
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
		private class BBKPKPCEIDK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DKFEAPHKBMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D PAMENHACOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MJDPBEAMAIE FDIPFHGCDKN;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBB30", Offset = "0x5CDAF30", VA = "0x185CDBB30")]
			public BBKPKPCEIDK(string DKFEAPHKBMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x35B2DA0", Offset = "0x35B21A0", VA = "0x1835B2DA0")]
			public BBKPKPCEIDK(string DKFEAPHKBMP, Texture2D AMKNJHJDPEF, MJDPBEAMAIE GOPLDFCEEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBAF0", Offset = "0x5CDAEF0", VA = "0x185CDBAF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LIMGCHPLAED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public MJDPBEAMAIE textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public LIMGCHPLAED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CDC820", Offset = "0x5CDBC20", VA = "0x185CDC820")]
			internal void FNLEHBNGPPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GOPCGHDJAKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public GOPCGHDJAKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CDC600", Offset = "0x5CDBA00", VA = "0x185CDC600")]
			internal byte[] ILNPCOPBGPE(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ODPDCHCKCLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public ODPDCHCKCLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CDD7A0", Offset = "0x5CDCBA0", VA = "0x185CDD7A0")]
			internal void MMDGEALFJLD()
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
		private DMGBOCKAFMH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BBKPKPCEIDK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private DMGBOCKAFMH<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DMGBOCKAFMH<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BBKPKPCEIDK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CDD6F0", Offset = "0x5CDCAF0", VA = "0x185CDD6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD620", Offset = "0x5CDCA20", VA = "0x185CDD620")]
		public ManagedTexture(string DKFEAPHKBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD680", Offset = "0x5CDCA80", VA = "0x185CDD680")]
		public ManagedTexture(string DKFEAPHKBMP, bool NHILDBEBMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD2F0", Offset = "0x5CDC6F0", VA = "0x185CDD2F0")]
		public void MIDKFDNBFFE(RenderTexture OLBHHJAPDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC860", Offset = "0x5CDBC60", VA = "0x185CDC860")]
		public DMGBOCKAFMH<byte[]> ANLGMEMIAHP(bool KIOOPPAAGDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD330", Offset = "0x5CDC730", VA = "0x185CDD330")]
		public DMGBOCKAFMH<Texture2D> OOAGLIEDPFH(MJDPBEAMAIE GOPLDFCEEHC, bool OHNPIIIDMBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC880", Offset = "0x5CDBC80", VA = "0x185CDC880")]
		public DMGBOCKAFMH<byte[]> CFBKNHFGBHL(bool OHNPIIIDMBD = false, int LOMCFNIAPOH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCA80", Offset = "0x5CDBE80", VA = "0x185CDCA80")]
		public DMGBOCKAFMH<byte[]> EIJLODCFPBD(bool OHNPIIIDMBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCD00", Offset = "0x5CDC100", VA = "0x185CDCD00")]
		private static DMGBOCKAFMH<Texture2D> JIOLGLOFPOC(string DKFEAPHKBMP, RenderTexture OLBHHJAPDNM, Texture2D PILCJFIGAGA, bool OHNPIIIDMBD, MJDPBEAMAIE NEICHJAAKAA = MJDPBEAMAIE.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCC40", Offset = "0x5CDC040", VA = "0x185CDCC40")]
		public void FCAAGJDKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCA70", Offset = "0x5CDBE70", VA = "0x185CDCA70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD250", Offset = "0x5CDC650", VA = "0x185CDD250")]
		[CompilerGenerated]
		private DMGBOCKAFMH<byte[]> MDHOBGCDBEA(Texture2D IHABFJJHOAA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JEEJLGFKADN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC680", Offset = "0x5CDBA80", VA = "0x185CDC680")]
	public static RenderTexture NFLDCMLDKKA(int HAAINFBDEEH, int FFMDGIGMLOC, int LPDDNEHFNHJ, Camera BCPGONMCDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC620", Offset = "0x5CDBA20", VA = "0x185CDC620")]
	public static void JOFIIKCCGAB(RenderTexture OLBHHJAPDNM)
	{
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
