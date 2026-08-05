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
		[Cpp2IlInjected.Address(RVA = "0x5DFA930", Offset = "0x5DF9930", VA = "0x185DFA930")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OBBBKPHGDDG
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
public interface INOFJGIOJFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OBBBKPHGDDG DPOCDONOCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DKJGNKFMELD
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
			[Cpp2IlInjected.Address(RVA = "0x5DFC910", Offset = "0x5DFB910", VA = "0x185DFC910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC900", Offset = "0x5DFB900", VA = "0x185DFC900")]
		public Resolution(uint LNKHMLIBJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9CE1C0", Offset = "0x9CD1C0", VA = "0x1809CE1C0")]
		public Resolution(uint LNKHMLIBJEP, uint DLOPBGEOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC810", Offset = "0x5DFB810", VA = "0x185DFC810")]
		public static Resolution NJKOGBPOPLM(Resolution[] DGHDFHCPCLI, Resolution OOFCCDAMJOD, int JICHDENKHMG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GGLMNAPNAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution ABCKCGEAHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JAMKNNCDLBC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint LNKHMLIBJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5DFAF90", Offset = "0x5DF9F90", VA = "0x185DFAF90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DLOPBGEOAKK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5DFB120", Offset = "0x5DFA120", VA = "0x185DFB120")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OPLDCHKDHLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5DFAC50", Offset = "0x5DF9C50", VA = "0x185DFAC50")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x18D3E00", Offset = "0x18D2E00", VA = "0x1818D3E00")]
		public GGLMNAPNAGH(Resolution ABCKCGEAHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAFA0", Offset = "0x5DF9FA0", VA = "0x185DFAFA0")]
		private static Resolution GCFMHNJBBJP(Resolution JAMKNNCDLBC, OBBBKPHGDDG FAMMDOIHLKM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PBNGGKNBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution EDNIBACFGLL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JEDHLFLGIOC;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KGMIHBKEKKA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OMJENLGHPMK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FBGPDKANKAH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution AKCKNCMPFHL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] CIHIJNECNHM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KEFFGIEOPEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution JOEACKAIJPJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CCHLGJKODAC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution GGCDGNEJAOI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NNNLCIFNKIP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution POJABGDPAIJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] CIHIJNECNHM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB140", Offset = "0x5DFA140", VA = "0x185DFB140")]
		public static Resolution OIEPBFEPPLP(uint MFEOMIOJEPD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution LJGMKJCECOE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA950", Offset = "0x5DF9950", VA = "0x185DFA950")]
	public static bool OFNHDEGFGGL(uint ADFGOAEEEAC)
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
		public enum JPIGAMIDDAD : byte
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
		private class FOKJIEDIAOC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JNMEJDHMADI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DLMBELCNGKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JPIGAMIDDAD PKHCJMCEIBG;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DFAC00", Offset = "0x5DF9C00", VA = "0x185DFAC00")]
			public FOKJIEDIAOC(string JNMEJDHMADI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3605430", Offset = "0x3604430", VA = "0x183605430")]
			public FOKJIEDIAOC(string JNMEJDHMADI, Texture2D ALGCGDPDEAF, JPIGAMIDDAD FDHPNHAPAJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DFABC0", Offset = "0x5DF9BC0", VA = "0x185DFABC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FEEINLJPIHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JPIGAMIDDAD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public FEEINLJPIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DFAB80", Offset = "0x5DF9B80", VA = "0x185DFAB80")]
			internal void GHDHCAEKGFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MHLDBCBCDKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public MHLDBCBCDKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DFB690", Offset = "0x5DFA690", VA = "0x185DFB690")]
			internal byte[] CEFADMPADLN(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BJAFIDGJEPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public BJAFIDGJEPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DFA8B0", Offset = "0x5DF98B0", VA = "0x185DFA8B0")]
			internal void IKBDOOOHJDF()
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
		private FFKFAKMNOMC<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FOKJIEDIAOC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private FFKFAKMNOMC<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FFKFAKMNOMC<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FOKJIEDIAOC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5DFC540", Offset = "0x5DFB540", VA = "0x185DFC540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC470", Offset = "0x5DFB470", VA = "0x185DFC470")]
		public ManagedTexture(string JNMEJDHMADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC4D0", Offset = "0x5DFB4D0", VA = "0x185DFC4D0")]
		public ManagedTexture(string JNMEJDHMADI, bool DMLGAGMKCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBDD0", Offset = "0x5DFADD0", VA = "0x185DFBDD0")]
		public void EBMJJHCCDMP(RenderTexture FOPBKILMOKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC0A0", Offset = "0x5DFB0A0", VA = "0x185DFC0A0")]
		public FFKFAKMNOMC<byte[]> JFIBEBBIMBO(bool GFJKLNKGNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC180", Offset = "0x5DFB180", VA = "0x185DFC180")]
		public FFKFAKMNOMC<Texture2D> NFOMPBIKEBK(JPIGAMIDDAD FDHPNHAPAJP, bool HAFCLJDAPBG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBEB0", Offset = "0x5DFAEB0", VA = "0x185DFBEB0")]
		public FFKFAKMNOMC<byte[]> IFKJDMJGLHK(bool HAFCLJDAPBG = false, int FGOMOPIGKDA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBC00", Offset = "0x5DFAC00", VA = "0x185DFBC00")]
		public FFKFAKMNOMC<byte[]> DEGOMAOFCIM(bool HAFCLJDAPBG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB6B0", Offset = "0x5DFA6B0", VA = "0x185DFB6B0")]
		private static FFKFAKMNOMC<Texture2D> BEENHOIBIEI(string JNMEJDHMADI, RenderTexture FOPBKILMOKB, Texture2D LAOAOMMHBKD, bool HAFCLJDAPBG, JPIGAMIDDAD DPOPAMOAPDA = JPIGAMIDDAD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC0C0", Offset = "0x5DFB0C0", VA = "0x185DFC0C0")]
		public void LCBIGNCIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBDC0", Offset = "0x5DFADC0", VA = "0x185DFBDC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBE10", Offset = "0x5DFAE10", VA = "0x185DFBE10")]
		[CompilerGenerated]
		private FFKFAKMNOMC<byte[]> GLNEJHEPJNP(Texture2D CAPCODKALLI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MENMKJFDFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB4F0", Offset = "0x5DFA4F0", VA = "0x185DFB4F0")]
	public static RenderTexture MNJEFACOGGJ(int MFEOMIOJEPD, int ODOFMKIIGFF, int JAGDEKNJOFJ, Camera LOOKOACIIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB490", Offset = "0x5DFA490", VA = "0x185DFB490")]
	public static void ECNKHGAJNFB(RenderTexture FOPBKILMOKB)
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
