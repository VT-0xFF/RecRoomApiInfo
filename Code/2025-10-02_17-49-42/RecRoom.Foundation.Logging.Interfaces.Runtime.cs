using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class LPKDECNGPNE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public LPKDECNGPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class KFNEMNMNCKP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8509790", Offset = "0x8508190", VA = "0x188509790")]
	public KFNEMNMNCKP(int BCAJFCGHDKI, int LPPAHGMNDOJ, int OFAGCDELFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class CLJIJKJILFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
	public CLJIJKJILFF(bool DKEEDEJDKCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class AAMBFDCNHGA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8508FA0", Offset = "0x85079A0", VA = "0x188508FA0")]
	public AAMBFDCNHGA(string IELIBBNCJAC, string GDFPOPIGPDJ = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class MHOKBANHCPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2531F90", Offset = "0x2530990", VA = "0x182531F90")]
	public MHOKBANHCPP(int KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum IFKDCDHMMHL
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JDCEDLJGMFJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CCHNLOGIDOH<T> : JDCEDLJGMFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, T KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MFCPFLBENGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MPNKOANDBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MLCCKADBKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AAEKJEBJAMA(Type DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BEJDOEMMAJO(NativeParallelHashMap<int, JDHBPJJENDI> FBOHMIMNCKO, NativeArray<byte> BLPDDGCLNPE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PMAPIDMDOAH
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IPAJGOPPIIL
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FAMHNFBKLLE<T> : CCNKPGDLNKA<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
	protected FAMHNFBKLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CCNKPGDLNKA<T> : CCHNLOGIDOH<T>, JDCEDLJGMFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5408D60", Offset = "0x5407760", VA = "0x185408D60")]
	public void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected CCNKPGDLNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5408D00", Offset = "0x5407700", VA = "0x185408D00", Slot = "4")]
	private void JMACGJMMCOA([In] HFEMCIEBCBE BLMOFENEBNP, T KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DMJDEFLCJEF<T> : CCHNLOGIDOH<NativeArray<T>>, JDCEDLJGMFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x460BE60", Offset = "0x460A860", VA = "0x18460BE60")]
	public void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, NativeArray<T> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F140E0", Offset = "0x3F12AE0", VA = "0x183F140E0")]
	public static ReadOnlySpan<T> AFPBINKHJJL<T>(NativeArray<T> BHEONMJLANC) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected DMJDEFLCJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x460BE30", Offset = "0x460A830", VA = "0x18460BE30", Slot = "4")]
	private void INMJLIMGDBD([In] HFEMCIEBCBE BLMOFENEBNP, NativeArray<T> KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OMIAGOCEHHB : CCHNLOGIDOH<OMIAGOCEHHB.KJPJCBONDDB>, JDCEDLJGMFJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KJPJCBONDDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, KJPJCBONDDB KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OMIAGOCEHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	private void CJJONHBNLHJ([In] HFEMCIEBCBE BLMOFENEBNP, KJPJCBONDDB KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KGGENEDEPGP : CCHNLOGIDOH<string>, JDCEDLJGMFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KGGENEDEPGP FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85097F0", Offset = "0x85081F0", VA = "0x1885097F0")]
	public void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KGGENEDEPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85097E0", Offset = "0x85081E0", VA = "0x1885097E0", Slot = "4")]
	private void DCCFLABHEFJ([In] HFEMCIEBCBE BLMOFENEBNP, string KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GMIGCPIIKCF<T> : AJLDGCFCOPD<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
	protected GMIGCPIIKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class AJLDGCFCOPD<T> : CCHNLOGIDOH<T>, JDCEDLJGMFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5408E40", Offset = "0x5407840", VA = "0x185408E40")]
	public void PJNIPOMBICM([In] HFEMCIEBCBE BLMOFENEBNP, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected AJLDGCFCOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5408D00", Offset = "0x5407700", VA = "0x185408D00", Slot = "4")]
	private void JMACGJMMCOA([In] HFEMCIEBCBE BLMOFENEBNP, T KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HFEMCIEBCBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GMPPMJIMAHA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HFEMCIEBCBE BLMOFENEBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int HGODIKIKNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int AODAGKGFCGP;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6342150", Offset = "0x6340B50", VA = "0x186342150")]
		public GMPPMJIMAHA(HFEMCIEBCBE BLMOFENEBNP, int HGODIKIKNPK, int AODAGKGFCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8509090", Offset = "0x8507A90", VA = "0x188509090")]
		public GMPPMJIMAHA IJAJDMOJDPG(ReadOnlySpan<byte> BLPDDGCLNPE)
		{
			return default(GMPPMJIMAHA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x44BF3D0", Offset = "0x44BDDD0", VA = "0x1844BF3D0")]
		public GMPPMJIMAHA IJAJDMOJDPG<T>(T BLPDDGCLNPE) where T : struct
		{
			return default(GMPPMJIMAHA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8508FF0", Offset = "0x85079F0", VA = "0x188508FF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MFCPFLBENGI JMMIJOBFAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, JDHBPJJENDI> FBOHMIMNCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85095B0", Offset = "0x8507FB0", VA = "0x1885095B0")]
	public HFEMCIEBCBE(MFCPFLBENGI JMMIJOBFAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85094C0", Offset = "0x8507EC0", VA = "0x1885094C0")]
	public int NEPKGDLKIDP(JDCEDLJGMFJ PKOJFJHILAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8509330", Offset = "0x8507D30", VA = "0x188509330")]
	public GMPPMJIMAHA EBLIIBELPCJ(JDCEDLJGMFJ PKOJFJHILAH)
	{
		return default(GMPPMJIMAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8509280", Offset = "0x8507C80", VA = "0x188509280")]
	public GMPPMJIMAHA EBLIIBELPCJ(int KLLHJJLOHID)
	{
		return default(GMPPMJIMAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85090F0", Offset = "0x8507AF0", VA = "0x1885090F0")]
	public void DNKNDAIHBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8509420", Offset = "0x8507E20", VA = "0x188509420")]
	public HFEMCIEBCBE LFPMCBHAIJL()
	{
		return default(HFEMCIEBCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8509220", Offset = "0x8507C20", VA = "0x188509220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GOKMENIMGOH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA100", Offset = "0x3DB8B00", VA = "0x183DBA100")]
	public static HFEMCIEBCBE HMDNMGBNKIA<T>([In] this HFEMCIEBCBE BLMOFENEBNP, CCHNLOGIDOH<T> PKOJFJHILAH, T KMAFNKGMDCF)
	{
		return default(HFEMCIEBCBE);
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
