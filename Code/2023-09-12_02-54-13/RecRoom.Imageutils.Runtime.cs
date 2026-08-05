using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EEEILMNFNCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71F9D60", Offset = "0x71F9160", VA = "0x1871F9D60")]
	public static RenderTexture IJFFBKIIJKN(int PPNABNHFNMB, int DPJCAKENMMD, int NGPIKDPNLGJ, Camera JENKOCBDGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71F9CF0", Offset = "0x71F90F0", VA = "0x1871F9CF0")]
	public static void HCDCJHLNAFL(RenderTexture KGGGPIHPNOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MKPJJOBPBMC
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
public interface OBHDDLHFAEC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MKPJJOBPBMC OMMBNOKADIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LNFAFCFDDCA
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
			[Cpp2IlInjected.Address(RVA = "0x71FBAF0", Offset = "0x71FAEF0", VA = "0x1871FBAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71FBAE0", Offset = "0x71FAEE0", VA = "0x1871FBAE0")]
		public Resolution(uint EOMIKPKMCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
		public Resolution(uint EOMIKPKMCAG, uint PPNFDCNFKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71FB9F0", Offset = "0x71FADF0", VA = "0x1871FB9F0")]
		public static Resolution AMDCEGFLCBN(Resolution[] PPHPNENEJCI, Resolution KAJOOKBICFE, int BMODOMNKLOB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JBEJGIHINKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Resolution ELAENGNLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Resolution? AJFGGJIHHKB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint EOMIKPKMCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x71FA150", Offset = "0x71F9550", VA = "0x1871FA150")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint PPNFDCNFKFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x71FA130", Offset = "0x71F9530", VA = "0x1871FA130")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EKLAOPAFKEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x71F9F50", Offset = "0x71F9350", VA = "0x1871F9F50")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E04030", Offset = "0x1E03430", VA = "0x181E04030")]
		public JBEJGIHINKL(Resolution ELAENGNLAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71FA160", Offset = "0x71F9560", VA = "0x1871FA160")]
		private static Resolution MHGBFMAOLKL(Resolution AJFGGJIHHKB, MKPJJOBPBMC FOHGKCJBOIC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class AJNKNDKIGCC
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution BMHDKMMBGFB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution DFKDKMKLHCO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FIPFEFEOPMA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution MEOHGDMJJFN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LKIPJDLGOIL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution ONHPPDMDLDF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static readonly Resolution[] ADBDBPGIAHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class NNOBFPLKBIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DHEIFFIBKEL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution CNDLGFILLHE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution EMJBKLMGPNJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution LJFMGCPHHAL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution APPAGMBPMCB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static readonly Resolution[] ADBDBPGIAHA;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71FB5A0", Offset = "0x71FA9A0", VA = "0x1871FB5A0")]
		public static Resolution KFPHFJNICAI(uint PPNABNHFNMB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Resolution BNKOGMCIIAG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71FA300", Offset = "0x71F9700", VA = "0x1871FA300")]
	public static bool EMKAHHDGGNL(uint BGBIHFNHMOM)
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
		public enum IKDPFEEPIDK : byte
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
		private class BGHHPHAICBM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private string GDKOBCHHFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Texture2D HLGBNMPMDDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public IKDPFEEPIDK LHMFOGIELKL;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71F9C60", Offset = "0x71F9060", VA = "0x1871F9C60")]
			public BGHHPHAICBM(string GDKOBCHHFLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30837D0", Offset = "0x3082BD0", VA = "0x1830837D0")]
			public BGHHPHAICBM(string GDKOBCHHFLB, Texture2D FFBJCPPFNGH, IKDPFEEPIDK OMKANACCHPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x71F9C20", Offset = "0x71F9020", VA = "0x1871F9C20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HJJLOOPGNEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IKDPFEEPIDK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public HJJLOOPGNEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71F9F10", Offset = "0x71F9310", VA = "0x1871F9F10")]
			internal void MHNGDOAOPOC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EAEGJMGDOAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public EAEGJMGDOAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71F9CD0", Offset = "0x71F90D0", VA = "0x1871F9CD0")]
			internal byte[] ALBMKLBAHGC(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OOHIKLLLIDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public OOHIKLLLIDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x71FB960", Offset = "0x71FAD60", VA = "0x1871FB960")]
			internal void KGBMMKDFHDI()
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
		private KDCMFGDLEKL<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private BGHHPHAICBM _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KDCMFGDLEKL<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KDCMFGDLEKL<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BGHHPHAICBM memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71FB500", Offset = "0x71FA900", VA = "0x1871FB500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71FB450", Offset = "0x71FA850", VA = "0x1871FB450")]
		public ManagedTexture(string GDKOBCHHFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71FB390", Offset = "0x71FA790", VA = "0x1871FB390")]
		public ManagedTexture(string GDKOBCHHFLB, bool NNFNABLGMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71FAFD0", Offset = "0x71FA3D0", VA = "0x1871FAFD0")]
		public void MAIGNGECLCO(RenderTexture KGGGPIHPNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71FA770", Offset = "0x71F9B70", VA = "0x1871FA770")]
		public KDCMFGDLEKL<byte[]> EPAADJIGCDN(bool ODPJPDKKLIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71FB000", Offset = "0x71FA400", VA = "0x1871FB000")]
		public KDCMFGDLEKL<Texture2D> MEGIAMJKPKE(IKDPFEEPIDK OMKANACCHPJ, bool EDHLGACGJBN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71FA560", Offset = "0x71F9960", VA = "0x1871FA560")]
		public KDCMFGDLEKL<byte[]> DMABJELCLEJ(bool EDHLGACGJBN = false, int EGCEEFPGNME = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71FAD50", Offset = "0x71FA150", VA = "0x1871FAD50")]
		public KDCMFGDLEKL<byte[]> IDECICHHONL(bool EDHLGACGJBN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71FA7A0", Offset = "0x71F9BA0", VA = "0x1871FA7A0")]
		private static KDCMFGDLEKL<Texture2D> HBBMEGODNDG(string GDKOBCHHFLB, RenderTexture KGGGPIHPNOJ, ref Texture2D NBAPFGHCGNG, bool EDHLGACGJBN, IKDPFEEPIDK HBKHBHGLLGG = IKDPFEEPIDK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71FAF10", Offset = "0x71FA310", VA = "0x1871FAF10")]
		public void IMDFNMPKPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71FA760", Offset = "0x71F9B60", VA = "0x1871FA760", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71FB2E0", Offset = "0x71FA6E0", VA = "0x1871FB2E0")]
		[CompilerGenerated]
		private KDCMFGDLEKL<byte[]> OCGNJPJHIEA(Texture2D COIJKJHKPOE)
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
		[Cpp2IlInjected.Address(RVA = "0x71F9CB0", Offset = "0x71F90B0", VA = "0x1871F9CB0")]
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
