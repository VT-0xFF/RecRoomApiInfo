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
		[Cpp2IlInjected.Address(RVA = "0x5C88040", Offset = "0x5C87440", VA = "0x185C88040")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FLEKLLCNBFI
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
public interface EFHGCHPILJO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FLEKLLCNBFI IMABODGCEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AEOLEBJAMJB
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
			[Cpp2IlInjected.Address(RVA = "0x5C89630", Offset = "0x5C88A30", VA = "0x185C89630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C89620", Offset = "0x5C88A20", VA = "0x185C89620")]
		public Resolution(uint MHJJOHHKIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
		public Resolution(uint MHJJOHHKIPH, uint DFACBIDGKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C89530", Offset = "0x5C88930", VA = "0x185C89530")]
		public static Resolution HJPIADCIHGJ(Resolution[] PHAIIGMLKHM, Resolution HEHGOFCGPIL, int AANMKFIFADA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CKLDLCIOJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution OABJHCPPJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JNEFLCNOOLC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint MHJJOHHKIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5C88030", Offset = "0x5C87430", VA = "0x185C88030")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DFACBIDGKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5C87E90", Offset = "0x5C87290", VA = "0x185C87E90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FHJIBGMBCFB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5C87B50", Offset = "0x5C86F50", VA = "0x185C87B50")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1821A90", Offset = "0x1820E90", VA = "0x181821A90")]
		public CKLDLCIOJEJ(Resolution OABJHCPPJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C87EB0", Offset = "0x5C872B0", VA = "0x185C87EB0")]
		private static Resolution NDNMCMMNKPH(Resolution JNEFLCNOOLC, FLEKLLCNBFI AFEFDEEJMPF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NJNPNJOPHGD
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HMEPIEKPMGM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution PADJAIMMPHG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IKACPDAMEAM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DIBFIABDGGH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GPIPIGJFIMB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution MBEMEPOFDFG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] ONFFNBNCFMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class AGMLBGMDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KDGGIIPLLGP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NKPMGOLEFPC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution JMCEOCLCMAF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DLJDDADPAKO;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OGMGDCIPGHG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] ONFFNBNCFMM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C87800", Offset = "0x5C86C00", VA = "0x185C87800")]
		public static Resolution NCCJHDICLGH(uint DFFLJOMMBKP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution CLHNEIHACNN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C875D0", Offset = "0x5C869D0", VA = "0x185C875D0")]
	public static bool GAAEFEEHJMP(uint JDDICPAINPC)
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
		public enum NNODEFDIDDA : byte
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
		private class KMBFAIBCAAG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LFAIHEECJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IFJDJOICJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NNODEFDIDDA NNEKPNILJGC;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C88380", Offset = "0x5C87780", VA = "0x185C88380")]
			public KMBFAIBCAAG(string LFAIHEECJFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7560", Offset = "0x3DE6960", VA = "0x183DE7560")]
			public KMBFAIBCAAG(string LFAIHEECJFK, Texture2D NKMJMDLAGMO, NNODEFDIDDA MGHIKAIONCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C88340", Offset = "0x5C87740", VA = "0x185C88340", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GDJEACCNGJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NNODEFDIDDA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public GDJEACCNGJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C880E0", Offset = "0x5C874E0", VA = "0x185C880E0")]
			internal void PBDGCLOEEJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JECDKIDBABC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public JECDKIDBABC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5C88120", Offset = "0x5C87520", VA = "0x185C88120")]
			internal byte[] LMALNCPFHBL(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DBCEKEILGFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public DBCEKEILGFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C88060", Offset = "0x5C87460", VA = "0x185C88060")]
			internal void DAEELHCPGJF()
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
		private OCKEEDNGMLO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KMBFAIBCAAG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OCKEEDNGMLO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private OCKEEDNGMLO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KMBFAIBCAAG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5C89260", Offset = "0x5C88660", VA = "0x185C89260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C89190", Offset = "0x5C88590", VA = "0x185C89190")]
		public ManagedTexture(string LFAIHEECJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C891F0", Offset = "0x5C885F0", VA = "0x185C891F0")]
		public ManagedTexture(string LFAIHEECJFK, bool EGMNHIMAHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C883F0", Offset = "0x5C877F0", VA = "0x185C883F0")]
		public void CFPIICMMAFE(RenderTexture INJOMBFGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C883D0", Offset = "0x5C877D0", VA = "0x185C883D0")]
		public OCKEEDNGMLO<byte[]> CAJPPHHODKG(bool JDNKNDGHHPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C88440", Offset = "0x5C87840", VA = "0x185C88440")]
		public OCKEEDNGMLO<Texture2D> GABKDHGFOGL(NNODEFDIDDA MGHIKAIONCG, bool KLFICIHIBGP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5C88730", Offset = "0x5C87B30", VA = "0x185C88730")]
		public OCKEEDNGMLO<byte[]> GFNCJJCLDOH(bool KLFICIHIBGP = false, int BIKFPLHGLDI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5C88A80", Offset = "0x5C87E80", VA = "0x185C88A80")]
		public OCKEEDNGMLO<byte[]> LOGBNGJDCHP(bool KLFICIHIBGP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5C88C40", Offset = "0x5C88040", VA = "0x185C88C40")]
		private static OCKEEDNGMLO<Texture2D> OHKIMNDFHBA(string LFAIHEECJFK, RenderTexture INJOMBFGBPI, Texture2D MECHALINDNE, bool KLFICIHIBGP, NNODEFDIDDA HPILFLBFGAJ = NNODEFDIDDA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5C88920", Offset = "0x5C87D20", VA = "0x185C88920")]
		public void LFGAFLPOLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5C88430", Offset = "0x5C87830", VA = "0x185C88430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C889E0", Offset = "0x5C87DE0", VA = "0x185C889E0")]
		[CompilerGenerated]
		private OCKEEDNGMLO<byte[]> LGCIIAFDAJP(Texture2D JNLPMDBFFIF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JFDFLCFNAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C881A0", Offset = "0x5C875A0", VA = "0x185C881A0")]
	public static RenderTexture DGMBDGKFPCM(int DFFLJOMMBKP, int JLHCJGALPIM, int MOLHCHBGJAP, Camera CHBPBGPILJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C88140", Offset = "0x5C87540", VA = "0x185C88140")]
	public static void BGBDDLAMMPD(RenderTexture INJOMBFGBPI)
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
