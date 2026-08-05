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
		[Cpp2IlInjected.Address(RVA = "0x5CE1930", Offset = "0x5CE0730", VA = "0x185CE1930")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OBPEEKINLCM
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
public interface DOLAJNKAOCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OBPEEKINLCM FOMLBLGBLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ICAACLMOBJO
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
			[Cpp2IlInjected.Address(RVA = "0x5CE36F0", Offset = "0x5CE24F0", VA = "0x185CE36F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CE36E0", Offset = "0x5CE24E0", VA = "0x185CE36E0")]
		public Resolution(uint HOELCINBFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
		public Resolution(uint HOELCINBFKH, uint JOHINIOFBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CE35F0", Offset = "0x5CE23F0", VA = "0x185CE35F0")]
		public static Resolution FJHDGHOFIPL(Resolution[] DJBANEJKJAN, Resolution IPGIAJKKICI, int DKCJBNDNGKB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KOLJDJOFHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution NEFPGLOHEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GHFCCLDCHJG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint HOELCINBFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1BE0", Offset = "0x5CE09E0", VA = "0x185CE1BE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JOHINIOFBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1F30", Offset = "0x5CE0D30", VA = "0x185CE1F30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OCBFNOOENEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1BF0", Offset = "0x5CE09F0", VA = "0x185CE1BF0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1803890", Offset = "0x1802690", VA = "0x181803890")]
		public KOLJDJOFHNF(Resolution NEFPGLOHEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1F50", Offset = "0x5CE0D50", VA = "0x185CE1F50")]
		private static Resolution KHFNMMOANOC(Resolution GHFCCLDCHJG, OBPEEKINLCM HCKMBBEIKDN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CFEKGELDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DOHFOPCEGHB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IOHCGIEIGLN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BAPMAPADGDM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution JGINIGOHJOD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CKCDADHPJCL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LGNFINHEHKO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MHGCFCMBFJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MFGJCHAELMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution EKDAAMNOGOG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution KNJPOIAPKDM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution EIKNDMNKGDN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PBGMKHIFCFF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution DHPGILNNJBA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MHGCFCMBFJM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE20D0", Offset = "0x5CE0ED0", VA = "0x185CE20D0")]
		public static Resolution GJICKIGHHBB(uint OONLFMDCHML)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution IDCPMBBGDBL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1970", Offset = "0x5CE0770", VA = "0x185CE1970")]
	public static bool NMIELONIGCH(uint PPGPGPICMIO)
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
		public enum IIGIMCPGBNB : byte
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
		private class OECHOCEOAKG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string ONIBECKLJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HNBLFPDIOFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IIGIMCPGBNB LBPCAKODCFD;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CE35A0", Offset = "0x5CE23A0", VA = "0x185CE35A0")]
			public OECHOCEOAKG(string ONIBECKLJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x304CCB0", Offset = "0x304BAB0", VA = "0x18304CCB0")]
			public OECHOCEOAKG(string ONIBECKLJDD, Texture2D DJCEAPNKDHF, IIGIMCPGBNB AJFHFNFOJCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3560", Offset = "0x5CE2360", VA = "0x185CE3560", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KHMFEHGCGDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public IIGIMCPGBNB textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public KHMFEHGCGDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1BA0", Offset = "0x5CE09A0", VA = "0x185CE1BA0")]
			internal void DLIKNODEFOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HELGICAGEFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public HELGICAGEFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1950", Offset = "0x5CE0750", VA = "0x185CE1950")]
			internal byte[] GFHOMCJCFLI(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AIAKHIPPFJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public AIAKHIPPFJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1690", Offset = "0x5CE0490", VA = "0x185CE1690")]
			internal void BEMIADICKMG()
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
		private BOOMHLJDOCA<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OECHOCEOAKG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private BOOMHLJDOCA<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private BOOMHLJDOCA<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OECHOCEOAKG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CE32B0", Offset = "0x5CE20B0", VA = "0x185CE32B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE31E0", Offset = "0x5CE1FE0", VA = "0x185CE31E0")]
		public ManagedTexture(string ONIBECKLJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3240", Offset = "0x5CE2040", VA = "0x185CE3240")]
		public ManagedTexture(string ONIBECKLJDD, bool PPFBBABPDKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2420", Offset = "0x5CE1220", VA = "0x185CE2420")]
		public void ABBEOHONHIJ(RenderTexture FJCMOHCCIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2700", Offset = "0x5CE1500", VA = "0x185CE2700")]
		public BOOMHLJDOCA<byte[]> FKJEOBHMFNL(bool CIKIGDGGEKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2720", Offset = "0x5CE1520", VA = "0x185CE2720")]
		public BOOMHLJDOCA<Texture2D> FOJINIHAINB(IIGIMCPGBNB AJFHFNFOJCJ, bool DDNNOHFDOCH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2500", Offset = "0x5CE1300", VA = "0x185CE2500")]
		public BOOMHLJDOCA<byte[]> CGJIOHAKGCA(bool DDNNOHFDOCH = false, int MCDFHDNFBAD = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2A10", Offset = "0x5CE1810", VA = "0x185CE2A10")]
		public BOOMHLJDOCA<byte[]> NJIBDHGJMKP(bool DDNNOHFDOCH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2C90", Offset = "0x5CE1A90", VA = "0x185CE2C90")]
		private static BOOMHLJDOCA<Texture2D> PLIFJHLFFFB(string ONIBECKLJDD, RenderTexture FJCMOHCCIMC, Texture2D MGMFCLAKMAD, bool DDNNOHFDOCH, IIGIMCPGBNB NNNEPLKMKMM = IIGIMCPGBNB.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2BD0", Offset = "0x5CE19D0", VA = "0x185CE2BD0")]
		public void OAFEGMAGFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE26F0", Offset = "0x5CE14F0", VA = "0x185CE26F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2460", Offset = "0x5CE1260", VA = "0x185CE2460")]
		[CompilerGenerated]
		private BOOMHLJDOCA<byte[]> BOHFOBOJLIM(Texture2D FKNPFIJCAAE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NLLGDNEMGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3360", Offset = "0x5CE2160", VA = "0x185CE3360")]
	public static RenderTexture KPALDJDOFLH(int OONLFMDCHML, int ADIMMNOIADA, int LHFEFLHGBJE, Camera AHMEKLAEGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3500", Offset = "0x5CE2300", VA = "0x185CE3500")]
	public static void OLBIIGDAKIF(RenderTexture FJCMOHCCIMC)
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
