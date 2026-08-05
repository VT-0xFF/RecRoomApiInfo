using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MICEHOHCFLH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA1F0", Offset = "0x6EF89F0", VA = "0x186EFA1F0")]
	public static RenderTexture KDPIADJOKPB(int JHBGPLBIFPC, int AJHBENNHBJK, int HKIFENONMMH, Camera JIFCMIMIGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA3A0", Offset = "0x6EF8BA0", VA = "0x186EFA3A0")]
	public static void PDGHNGMJLDO(RenderTexture DLDEBMKDNDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ILIJFGKLCOD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JEHPHBLDHGE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ILIJFGKLCOD IBLMEMAHNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IEKOHNFHMBL
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6EFB550", Offset = "0x6EF9D50", VA = "0x186EFB550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB540", Offset = "0x6EF9D40", VA = "0x186EFB540")]
		public Resolution(uint FBGKLELIKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
		public Resolution(uint FBGKLELIKCG, uint LFJEFFKGLOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB450", Offset = "0x6EF9C50", VA = "0x186EFB450")]
		public static Resolution CCPPFNMIKFD(Resolution[] LFCKIHDGDIE, Resolution BMOFAOBIPGI, int NFLCJEEAHGI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class IFHPPJGMHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Resolution ONFPAACJFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Resolution? NKNLOKJJABA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FBGKLELIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BA0", Offset = "0x6EF83A0", VA = "0x186EF9BA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint LFJEFFKGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BB0", Offset = "0x6EF83B0", VA = "0x186EF9BB0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KJOLCEPLNHA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BD0", Offset = "0x6EF83D0", VA = "0x186EF9BD0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x123A710", Offset = "0x1238F10", VA = "0x18123A710")]
		public IFHPPJGMHCK(Resolution ONFPAACJFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9DB0", Offset = "0x6EF85B0", VA = "0x186EF9DB0")]
		private static Resolution LLOLOBELMFA(Resolution NKNLOKJJABA, ILIJFGKLCOD LOLNPLEADJO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IFLEEEPGEPG
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution DLCGGGLNHLI;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution KBDGCKJHMDA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution PHHACFAOCAA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KPDIBABOJFP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IMFINFCIOPH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BDPIMKCLMIA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static readonly Resolution[] PKHOMMDBAPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FIDLJFPMGPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FNCLHJEHADL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NPCOPDIINIE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution COCFKEJEBCM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FGMPPODGNBL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution PBPHMLPJMDA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static readonly Resolution[] PKHOMMDBAPL;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9580", Offset = "0x6EF7D80", VA = "0x186EF9580")]
		public static Resolution PEENIJMJJCP(uint JHBGPLBIFPC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Resolution EOKIAGKFCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9940", Offset = "0x6EF8140", VA = "0x186EF9940")]
	public static bool MIHALOOINHI(uint HMPEOAEGKMA)
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
		public enum LAJBCIIJACG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class DCFDBIJDEFD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private string MDOAADHDBMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Texture2D CPGCECOMONC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LAJBCIIJACG NAJHDFENPBK;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9460", Offset = "0x6EF7C60", VA = "0x186EF9460")]
			public DCFDBIJDEFD(string MDOAADHDBMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2F7D080", Offset = "0x2F7B880", VA = "0x182F7D080")]
			public DCFDBIJDEFD(string MDOAADHDBMA, Texture2D PBPDIAHBBFE, LAJBCIIJACG HJGIOADKCBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9420", Offset = "0x6EF7C20", VA = "0x186EF9420", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DEMGBMAPCDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LAJBCIIJACG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public DEMGBMAPCDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6EF94B0", Offset = "0x6EF7CB0", VA = "0x186EF94B0")]
			internal void GPOEAIEIHHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JFGIKIOEDEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public JFGIKIOEDEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6EFA1D0", Offset = "0x6EF89D0", VA = "0x186EFA1D0")]
			internal byte[] JDCKNPCOPFP(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ELBKADABLMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public ELBKADABLMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6EF94F0", Offset = "0x6EF7CF0", VA = "0x186EF94F0")]
			internal void PABCLBGPNDE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JJMNNLLBAJO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private DCFDBIJDEFD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JJMNNLLBAJO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JJMNNLLBAJO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DCFDBIJDEFD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6EFB3B0", Offset = "0x6EF9BB0", VA = "0x186EFB3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB300", Offset = "0x6EF9B00", VA = "0x186EFB300")]
		public ManagedTexture(string MDOAADHDBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB240", Offset = "0x6EF9A40", VA = "0x186EFB240")]
		public ManagedTexture(string MDOAADHDBMA, bool JGGBNGDLAJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB050", Offset = "0x6EF9850", VA = "0x186EFB050")]
		public void MLMMBMBNJNF(RenderTexture DLDEBMKDNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB020", Offset = "0x6EF9820", VA = "0x186EFB020")]
		public JJMNNLLBAJO<byte[]> LNKDBFABOBM(bool PDPHPEPPGHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA410", Offset = "0x6EF8C10", VA = "0x186EFA410")]
		public JJMNNLLBAJO<Texture2D> BHAFFIEKBDJ(LAJBCIIJACG HJGIOADKCBI, bool DKACKHGMCOG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA6F0", Offset = "0x6EF8EF0", VA = "0x186EFA6F0")]
		public JJMNNLLBAJO<byte[]> BLHOACPDNOI(bool DKACKHGMCOG = false, int DPDOHFFBJEJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB080", Offset = "0x6EF9880", VA = "0x186EFB080")]
		public JJMNNLLBAJO<byte[]> OILIFEBNOOB(bool DKACKHGMCOG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAA70", Offset = "0x6EF9270", VA = "0x186EFAA70")]
		private static JJMNNLLBAJO<Texture2D> HIDNMCAEOOL(string MDOAADHDBMA, RenderTexture DLDEBMKDNDA, ref Texture2D FGJOJJIOHHK, bool DKACKHGMCOG, LAJBCIIJACG HANIKAHKAHE = LAJBCIIJACG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA9B0", Offset = "0x6EF91B0", VA = "0x186EFA9B0")]
		public void HELFNGOENPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA8F0", Offset = "0x6EF90F0", VA = "0x186EFA8F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA900", Offset = "0x6EF9100", VA = "0x186EFA900")]
		[CompilerGenerated]
		private JJMNNLLBAJO<byte[]> EJHBJGJEBPC(Texture2D BFCFNAIHNPD)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9400", Offset = "0x6EF7C00", VA = "0x186EF9400")]
		public CubeMapGenerator()
		{
		}
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
