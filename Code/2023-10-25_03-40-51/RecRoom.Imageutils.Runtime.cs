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
		[Cpp2IlInjected.Address(RVA = "0x5C89A70", Offset = "0x5C88870", VA = "0x185C89A70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FCABDCHGCFM
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
public interface BLPIGLLFILA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FCABDCHGCFM KEDFJEBKHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BBNALBLNOEK
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
			[Cpp2IlInjected.Address(RVA = "0x5C8B190", Offset = "0x5C89F90", VA = "0x185C8B190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B180", Offset = "0x5C89F80", VA = "0x185C8B180")]
		public Resolution(uint NPDPLEIHBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
		public Resolution(uint NPDPLEIHBMM, uint CINKHPOEGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B090", Offset = "0x5C89E90", VA = "0x185C8B090")]
		public static Resolution BBHHOKIKMIE(Resolution[] IPHFHMOKOMP, Resolution NBLLNBPCECA, int EBPPNKDAKLG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AKHGANLKNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MNIFFJHMPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? LCGHDPDICMI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NPDPLEIHBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5C89470", Offset = "0x5C88270", VA = "0x185C89470")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint CINKHPOEGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5C89600", Offset = "0x5C88400", VA = "0x185C89600")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution JBECEGECDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5C89130", Offset = "0x5C87F30", VA = "0x185C89130")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x18287D0", Offset = "0x18275D0", VA = "0x1818287D0")]
		public AKHGANLKNFO(Resolution MNIFFJHMPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C89480", Offset = "0x5C88280", VA = "0x185C89480")]
		private static Resolution GBBNHALJPPO(Resolution LCGHDPDICMI, FCABDCHGCFM DEMHHNHOAJE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BOMFGPOFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GMHKBIGLNBJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IPLNGGHLPKB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JHILIFHHAKA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution EPGNEBFGINF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FOBMMAEOBOM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LFMAPEPMGJE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] LBDLFAKHCEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IAMOFDOHJAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution INCGEKAFOAE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution ELOLAAHGHGJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution GCLGCAOEMJB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution OBNEMLGFMBA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution JKHDMFBDIAD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] LBDLFAKHCEC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C89D50", Offset = "0x5C88B50", VA = "0x185C89D50")]
		public static Resolution KJCMFPCBFJA(uint IDHAPBPJELB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution EILIKJHLPHD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C89620", Offset = "0x5C88420", VA = "0x185C89620")]
	public static bool BBDANALFPLN(uint OMFPEJBIBBO)
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
		public enum FEPNHDGFOLC : byte
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
		private class KKLMEMMEHJA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MEBBBIMBIJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D CKIBKHHMOCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FEPNHDGFOLC GKKODAIEKIM;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A0E0", Offset = "0x5C88EE0", VA = "0x185C8A0E0")]
			public KKLMEMMEHJA(string MEBBBIMBIJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x35E2A10", Offset = "0x35E1810", VA = "0x1835E2A10")]
			public KKLMEMMEHJA(string MEBBBIMBIJO, Texture2D CDDHIOBHLIK, FEPNHDGFOLC CBJGCFBKMLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A0A0", Offset = "0x5C88EA0", VA = "0x185C8A0A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GLBOCMNEDPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FEPNHDGFOLC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public GLBOCMNEDPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C89C90", Offset = "0x5C88A90", VA = "0x185C89C90")]
			internal void PBFPAEOBPGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MPOHDNKFKJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public MPOHDNKFKJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A130", Offset = "0x5C88F30", VA = "0x185C8A130")]
			internal byte[] JKLMDLOGNKK(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HOMLOPGCIJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public HOMLOPGCIJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C89CD0", Offset = "0x5C88AD0", VA = "0x185C89CD0")]
			internal void GFFOOAPEHEA()
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
		private MIDEJKJPMAF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KKLMEMMEHJA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MIDEJKJPMAF<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MIDEJKJPMAF<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KKLMEMMEHJA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5C8AFE0", Offset = "0x5C89DE0", VA = "0x185C8AFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AF10", Offset = "0x5C89D10", VA = "0x185C8AF10")]
		public ManagedTexture(string MEBBBIMBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AF70", Offset = "0x5C89D70", VA = "0x185C8AF70")]
		public ManagedTexture(string MEBBBIMBIJO, bool JHEBPEFMDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A530", Offset = "0x5C89330", VA = "0x185C8A530")]
		public void HNICPGKJAGA(RenderTexture GABLAMGMIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A150", Offset = "0x5C88F50", VA = "0x185C8A150")]
		public MIDEJKJPMAF<byte[]> AAONLHFJLKC(bool PDAFCJDHMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A230", Offset = "0x5C89030", VA = "0x185C8A230")]
		public MIDEJKJPMAF<Texture2D> CKICOOFPKJJ(FEPNHDGFOLC CBJGCFBKMLH, bool NNNKGJINBBB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AAC0", Offset = "0x5C898C0", VA = "0x185C8AAC0")]
		public MIDEJKJPMAF<byte[]> MCFKAMLLFHG(bool NNNKGJINBBB = false, int JKDILHLOCCG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AD50", Offset = "0x5C89B50", VA = "0x185C8AD50")]
		public MIDEJKJPMAF<byte[]> PHAMLMDODMF(bool NNNKGJINBBB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A570", Offset = "0x5C89370", VA = "0x185C8A570")]
		private static MIDEJKJPMAF<Texture2D> IKMDMAKBEHA(string MEBBBIMBIJO, RenderTexture GABLAMGMIAK, Texture2D IJDHJMJBMCE, bool NNNKGJINBBB, FEPNHDGFOLC CLMCOKBKEGJ = FEPNHDGFOLC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A170", Offset = "0x5C88F70", VA = "0x185C8A170")]
		public void CFBFFKCIHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A520", Offset = "0x5C89320", VA = "0x185C8A520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C8ACB0", Offset = "0x5C89AB0", VA = "0x185C8ACB0")]
		[CompilerGenerated]
		private MIDEJKJPMAF<byte[]> NAFFLOOBIIP(Texture2D NKHNBGDHFED)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GBEADECKHPK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C89AF0", Offset = "0x5C888F0", VA = "0x185C89AF0")]
	public static RenderTexture MICLBIFPBEM(int IDHAPBPJELB, int EBEJFDNBBNK, int OBEANJHCKOF, Camera JPEMCJCPIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C89A90", Offset = "0x5C88890", VA = "0x185C89A90")]
	public static void EKOAPJGHFDF(RenderTexture GABLAMGMIAK)
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
