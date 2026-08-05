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
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DLCDENAGADN
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
public interface KHDMMOCNFED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DLCDENAGADN GAPKHGHONKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LEKGKGNKFKG
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
			[Cpp2IlInjected.Address(RVA = "0x5CABA90", Offset = "0x5CAA290", VA = "0x185CABA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CABA80", Offset = "0x5CAA280", VA = "0x185CABA80")]
		public Resolution(uint GEKAGOANEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
		public Resolution(uint GEKAGOANEHP, uint KFCLHHAJEPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB990", Offset = "0x5CAA190", VA = "0x185CAB990")]
		public static Resolution JKNNNGDNGMC(Resolution[] LCBBKAOBGLA, Resolution EJEECPJPOHE, int DMEOGELKGIN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NINAONNCAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution EMJNEMJMNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? LPOGDMEJDJA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GEKAGOANEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB980", Offset = "0x5CAA180", VA = "0x185CAB980")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint KFCLHHAJEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB960", Offset = "0x5CAA160", VA = "0x185CAB960")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OPGFLMHMPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB4A0", Offset = "0x5CA9CA0", VA = "0x185CAB4A0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x180D900", Offset = "0x180C100", VA = "0x18180D900")]
		public NINAONNCAPM(Resolution EMJNEMJMNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB7E0", Offset = "0x5CA9FE0", VA = "0x185CAB7E0")]
		private static Resolution DJALBECHIBC(Resolution LPOGDMEJDJA, DLCDENAGADN DNGFLHOKKHK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JGFKDIBLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BOLINOECIEI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KEKPANCEHHI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ACOELBCOECK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BBIDILCMIDP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KIHKCPDPCJG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FAKGEEODKBJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] DDHBJAIPKPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class NBGNCGFCDOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MCCOPAPLAAO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution HBKACBGIOLM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution FBHNHLOCPPE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NPCDLLDCAFI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GJMJPGFKLBH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] DDHBJAIPKPB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB150", Offset = "0x5CA9950", VA = "0x185CAB150")]
		public static Resolution CBKGDOMCCFM(uint OENMLNGACGK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution BKEJBEIBEDM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9FE0", Offset = "0x5CA87E0", VA = "0x185CA9FE0")]
	public static bool HMIHBEAFGEJ(uint PLDDONNKOFO)
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
		public enum DOABENKIMIJ : byte
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
		private class GHGOBFEDDNC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string BOBHOMKFHJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D JDOLAAOIGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DOABENKIMIJ KBPIOGOIIGJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9C90", Offset = "0x5CA8490", VA = "0x185CA9C90")]
			public GHGOBFEDDNC(string BOBHOMKFHJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3842D40", Offset = "0x3841540", VA = "0x183842D40")]
			public GHGOBFEDDNC(string BOBHOMKFHJB, Texture2D PNEGHHIDKPD, DOABENKIMIJ NMLIFAPELHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9C50", Offset = "0x5CA8450", VA = "0x185CA9C50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JNNJCMNDCMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DOABENKIMIJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public JNNJCMNDCMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9FA0", Offset = "0x5CA87A0", VA = "0x185CA9FA0")]
			internal void HDDNOJNFEID()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IAHIMOKJLJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public IAHIMOKJLJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9D60", Offset = "0x5CA8560", VA = "0x185CA9D60")]
			internal byte[] HEFGGKGPCPK(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GPFPIGIKEDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public GPFPIGIKEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9CE0", Offset = "0x5CA84E0", VA = "0x185CA9CE0")]
			internal void KCCCEIHOJMH()
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
		private FNFCBJEHDPL<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GHGOBFEDDNC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private FNFCBJEHDPL<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FNFCBJEHDPL<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GHGOBFEDDNC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB0A0", Offset = "0x5CA98A0", VA = "0x185CAB0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAFD0", Offset = "0x5CA97D0", VA = "0x185CAAFD0")]
		public ManagedTexture(string BOBHOMKFHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB030", Offset = "0x5CA9830", VA = "0x185CAB030")]
		public ManagedTexture(string BOBHOMKFHJB, bool DGPPLAHEEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAA60", Offset = "0x5CA9260", VA = "0x185CAAA60")]
		public void EHPOCAJBHMH(RenderTexture OOJLMNMFOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CAADC0", Offset = "0x5CA95C0", VA = "0x185CAADC0")]
		public FNFCBJEHDPL<byte[]> MHJALGLFBNH(bool DALJINNNCIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA210", Offset = "0x5CA8A10", VA = "0x185CAA210")]
		public FNFCBJEHDPL<Texture2D> AOBKHBHKEPD(DOABENKIMIJ NMLIFAPELHP, bool JKLOCEPMLJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CAADE0", Offset = "0x5CA95E0", VA = "0x185CAADE0")]
		public FNFCBJEHDPL<byte[]> OMKKDEHPKOJ(bool JKLOCEPMLJL = false, int EMNEODFNDGC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAAA0", Offset = "0x5CA92A0", VA = "0x185CAAAA0")]
		public FNFCBJEHDPL<byte[]> FAICIFMIAEL(bool JKLOCEPMLJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA500", Offset = "0x5CA8D00", VA = "0x185CAA500")]
		private static FNFCBJEHDPL<Texture2D> DIFEPAFPNMG(string BOBHOMKFHJB, RenderTexture OOJLMNMFOBJ, Texture2D LPOONPLFNJI, bool JKLOCEPMLJL, DOABENKIMIJ ENJMNEEDOJC = DOABENKIMIJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAC60", Offset = "0x5CA9460", VA = "0x185CAAC60")]
		public void FEFAMDAANBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAA50", Offset = "0x5CA9250", VA = "0x185CAAA50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAD20", Offset = "0x5CA9520", VA = "0x185CAAD20")]
		[CompilerGenerated]
		private FNFCBJEHDPL<byte[]> KDKEDJPDEPN(Texture2D OLKIHELIHON)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DCPLMPDCAPO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9AB0", Offset = "0x5CA82B0", VA = "0x185CA9AB0")]
	public static RenderTexture NFFMDHBIDNL(int OENMLNGACGK, int EECPDFLCEFA, int AODOAAEJFFK, Camera HDPEIMBHNEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9A50", Offset = "0x5CA8250", VA = "0x185CA9A50")]
	public static void HKIFONLHJBG(RenderTexture OOJLMNMFOBJ)
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
