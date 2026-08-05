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
		[Cpp2IlInjected.Address(RVA = "0x5E19050", Offset = "0x5E17C50", VA = "0x185E19050")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LNLICOBIHIK
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
public interface PEFPEDBEKLD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LNLICOBIHIK MCBHPIHPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LMNLICOOLDE
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
			[Cpp2IlInjected.Address(RVA = "0x5E1AE70", Offset = "0x5E19A70", VA = "0x185E1AE70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AE60", Offset = "0x5E19A60", VA = "0x185E1AE60")]
		public Resolution(uint HPIMCNPJDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0F810", Offset = "0xA0E410", VA = "0x180A0F810")]
		public Resolution(uint HPIMCNPJDMN, uint BKLHNKCOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD70", Offset = "0x5E19970", VA = "0x185E1AD70")]
		public static Resolution IJNFDKDLLMD(Resolution[] MCIMANHECMC, Resolution KFOLOOGJNJI, int AOGLJEFBKKK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FGDJAOOILCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution ALEDKKIGOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PAGDIBLJAKC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint HPIMCNPJDMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E19570", Offset = "0x5E18170", VA = "0x185E19570")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint BKLHNKCOAIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E19210", Offset = "0x5E17E10", VA = "0x185E19210")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HIDGJNIKHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E19230", Offset = "0x5E17E30", VA = "0x185E19230")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19094D0", Offset = "0x19080D0", VA = "0x1819094D0")]
		public FGDJAOOILCA(Resolution ALEDKKIGOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E19090", Offset = "0x5E17C90", VA = "0x185E19090")]
		private static Resolution AJOJADCPACO(Resolution PAGDIBLJAKC, LNLICOBIHIK LKJJAOKAIHH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PMIEPPCPIJO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OKMCMJLDKIP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BEEILNJPCNK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution DDIPOFNMDCG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution EIPHCJFPMNK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JEACMLBPMDB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FKEGPEKIJDL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OLHJJOJMEBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LPAPADENIHH
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OEJKJENLBHG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DLDDCCKOMPJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IENGEFGNGIP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution IIPCGJAGBBA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution DIILPECJDGN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OLHJJOJMEBP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E197B0", Offset = "0x5E183B0", VA = "0x185E197B0")]
		public static Resolution HAOPMKCCFOJ(uint JKPMEJIBHBK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DDILMBFBJGD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E19580", Offset = "0x5E18180", VA = "0x185E19580")]
	public static bool IMALJFHPMAL(uint PCDCHCDOLKO)
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
		public enum LDFGINNPKLP : byte
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
		private class OMCDNOCFMKF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JEICAPDKHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HJCPBLKHPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LDFGINNPKLP IABDPLDHFDA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E1AB00", Offset = "0x5E19700", VA = "0x185E1AB00")]
			public OMCDNOCFMKF(string JEICAPDKHKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x357D170", Offset = "0x357BD70", VA = "0x18357D170")]
			public OMCDNOCFMKF(string JEICAPDKHKI, Texture2D IOEECDIDCEO, LDFGINNPKLP OMLGLGFNEGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E1AAC0", Offset = "0x5E196C0", VA = "0x185E1AAC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BIMFJKNGBGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LDFGINNPKLP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public BIMFJKNGBGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E19010", Offset = "0x5E17C10", VA = "0x185E19010")]
			internal void BJIJOHLBFLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ECHKBKGMNPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public ECHKBKGMNPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E19070", Offset = "0x5E17C70", VA = "0x185E19070")]
			internal byte[] AIBBOALDCCD(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OFPHFBGODKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public OFPHFBGODKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E1AA40", Offset = "0x5E19640", VA = "0x185E1AA40")]
			internal void IODDMNFBLDA()
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
		private HPJLJGHAIKN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OMCDNOCFMKF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HPJLJGHAIKN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HPJLJGHAIKN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C4240", Offset = "0x7C2E40", VA = "0x1807C4240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OMCDNOCFMKF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E1A990", Offset = "0x5E19590", VA = "0x185E1A990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A8C0", Offset = "0x5E194C0", VA = "0x185E1A8C0")]
		public ManagedTexture(string JEICAPDKHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A920", Offset = "0x5E19520", VA = "0x185E1A920")]
		public ManagedTexture(string JEICAPDKHKI, bool MIOJMLMNDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E19DF0", Offset = "0x5E189F0", VA = "0x185E19DF0")]
		public void BCNHAJDFFAJ(RenderTexture MLJGDIBLHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E19EE0", Offset = "0x5E18AE0", VA = "0x185E19EE0")]
		public HPJLJGHAIKN<byte[]> FCMNOCDIGAD(bool CDCMPNLMECH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E19B00", Offset = "0x5E18700", VA = "0x185E19B00")]
		public HPJLJGHAIKN<Texture2D> ALNMOPMEGMJ(LDFGINNPKLP OMLGLGFNEGJ, bool MKOFAANKIFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A510", Offset = "0x5E19110", VA = "0x185E1A510")]
		public HPJLJGHAIKN<byte[]> KFNPIKJENEL(bool MKOFAANKIFK = false, int MINAFBLJCBM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A700", Offset = "0x5E19300", VA = "0x185E1A700")]
		public HPJLJGHAIKN<byte[]> PKBCGNDCNDK(bool MKOFAANKIFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E19F00", Offset = "0x5E18B00", VA = "0x185E19F00")]
		private static HPJLJGHAIKN<Texture2D> ICGOJLCJMDL(string JEICAPDKHKI, RenderTexture MLJGDIBLHMK, Texture2D IJJNHOKBLNH, bool MKOFAANKIFK, LDFGINNPKLP JNAGCIJDDKJ = LDFGINNPKLP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A450", Offset = "0x5E19050", VA = "0x185E1A450")]
		public void JJLMNIELMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E19ED0", Offset = "0x5E18AD0", VA = "0x185E19ED0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E19E30", Offset = "0x5E18A30", VA = "0x185E19E30")]
		[CompilerGenerated]
		private HPJLJGHAIKN<byte[]> DGNCHMNCJOP(Texture2D MFOGMJLNOKM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AHONNOKJFFO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E18E10", Offset = "0x5E17A10", VA = "0x185E18E10")]
	public static RenderTexture CFJGBJKMKHE(int JKPMEJIBHBK, int ANJHOEIDHKI, int OLLFIMGHMEJ, Camera IIGLMGEKEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E18FB0", Offset = "0x5E17BB0", VA = "0x185E18FB0")]
	public static void MOJCNIEEDKK(RenderTexture MLJGDIBLHMK)
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
