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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class MDIKNHLKOAI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public MDIKNHLKOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class MILPLGPLGDP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8113230", Offset = "0x8111E30", VA = "0x188113230")]
	public MILPLGPLGDP(int PFHGPMHBODB, int EBKNBHKFILG, int OBMOHOEHALH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class ELPOKBPKBEF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
	public ELPOKBPKBEF(bool KBIOBPAIKEF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class MHNKEPEAJGO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81131E0", Offset = "0x8111DE0", VA = "0x1881131E0")]
	public MHNKEPEAJGO(string BKILENEPEEB, string JKEAHMPNEHK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class DOMCMJCDJEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x240C110", Offset = "0x240AD10", VA = "0x18240C110")]
	public DOMCMJCDJEG(int BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum EPIJDMOKDKO
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
public interface ICIBEGIDHCK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HBBKODNPMAI<T> : ICIBEGIDHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, T BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GABMGHNJLAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FCPHBJDNDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LCMGNOMAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LHPFLKNENBE(Type MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMMDAPAPJCI(NativeParallelHashMap<int, FPNBEMALHAC> BNBCBHJAJGO, NativeArray<byte> CBCNBAPLLJM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDFGNJNEIKH
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AMANBLAJKFG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class BHKKIGECKDJ<T> : LNGEEKDNPOK<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4893BE0", Offset = "0x48927E0", VA = "0x184893BE0")]
	protected BHKKIGECKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LNGEEKDNPOK<T> : HBBKODNPMAI<T>, ICIBEGIDHCK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x52CA510", Offset = "0x52C9110", VA = "0x1852CA510")]
	public void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected LNGEEKDNPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x52CA200", Offset = "0x52C8E00", VA = "0x1852CA200", Slot = "4")]
	private void DHOPMIKADDP([In] ADMHFGCBEHD HFCLOLJPAOJ, T BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class AELGMHEIGOA<T> : HBBKODNPMAI<NativeArray<T>>, ICIBEGIDHCK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50916D0", Offset = "0x50902D0", VA = "0x1850916D0")]
	public void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, NativeArray<T> BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x314E460", Offset = "0x314D060", VA = "0x18314E460")]
	public static ReadOnlySpan<T> MABBMOFKENE<T>(NativeArray<T> COJHNLDFDFB) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected AELGMHEIGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50916A0", Offset = "0x50902A0", VA = "0x1850916A0", Slot = "4")]
	private void HDGCICGIIAN([In] ADMHFGCBEHD HFCLOLJPAOJ, NativeArray<T> BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GKJNBPHBFDH : HBBKODNPMAI<GKJNBPHBFDH.JCCNKEGNJAA>, ICIBEGIDHCK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JCCNKEGNJAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, JCCNKEGNJAA BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GKJNBPHBFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	private void NJBGMHOOAKA([In] ADMHFGCBEHD HFCLOLJPAOJ, JCCNKEGNJAA BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GNBNOMGDNEH : HBBKODNPMAI<string>, ICIBEGIDHCK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GNBNOMGDNEH MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8112D10", Offset = "0x8111910", VA = "0x188112D10")]
	public void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GNBNOMGDNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8112D00", Offset = "0x8111900", VA = "0x188112D00", Slot = "4")]
	private void BDFDLGEEBDD([In] ADMHFGCBEHD HFCLOLJPAOJ, string BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BKJJNFPENDP<T> : JGAIJFBGICA<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4893BE0", Offset = "0x48927E0", VA = "0x184893BE0")]
	protected BKJJNFPENDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class JGAIJFBGICA<T> : HBBKODNPMAI<T>, ICIBEGIDHCK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52CA260", Offset = "0x52C8E60", VA = "0x1852CA260")]
	public void MICBJKNKMBP([In] ADMHFGCBEHD HFCLOLJPAOJ, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected JGAIJFBGICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x52CA200", Offset = "0x52C8E00", VA = "0x1852CA200", Slot = "4")]
	private void DHOPMIKADDP([In] ADMHFGCBEHD HFCLOLJPAOJ, T BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ADMHFGCBEHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct INAANJDIIIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ADMHFGCBEHD HFCLOLJPAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int NDIDPIMCABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int JEHDLIBONJC;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x605DF50", Offset = "0x605CB50", VA = "0x18605DF50")]
		public INAANJDIIIB(ADMHFGCBEHD HFCLOLJPAOJ, int NDIDPIMCABM, int JEHDLIBONJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8113180", Offset = "0x8111D80", VA = "0x188113180")]
		public INAANJDIIIB JGIJIDGGEKO(ReadOnlySpan<byte> CBCNBAPLLJM)
		{
			return default(INAANJDIIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4361B50", Offset = "0x4360750", VA = "0x184361B50")]
		public INAANJDIIIB JGIJIDGGEKO<T>(T CBCNBAPLLJM) where T : struct
		{
			return default(INAANJDIIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81130E0", Offset = "0x8111CE0", VA = "0x1881130E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GABMGHNJLAG OAOPBELJGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, FPNBEMALHAC> BNBCBHJAJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> CBCNBAPLLJM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8112B30", Offset = "0x8111730", VA = "0x188112B30")]
	public ADMHFGCBEHD(GABMGHNJLAG OAOPBELJGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81128B0", Offset = "0x81114B0", VA = "0x1881128B0")]
	public int KGHMKPAOLDO(ICIBEGIDHCK JKAPPJFLKGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8112A40", Offset = "0x8111640", VA = "0x188112A40")]
	public INAANJDIIIB OHJOMBEKGFC(ICIBEGIDHCK JKAPPJFLKGP)
	{
		return default(INAANJDIIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8112990", Offset = "0x8111590", VA = "0x188112990")]
	public INAANJDIIIB OHJOMBEKGFC(int OGCNFBAJOKM)
	{
		return default(INAANJDIIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8112680", Offset = "0x8111280", VA = "0x188112680")]
	public void BDGMCGKPGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8112810", Offset = "0x8111410", VA = "0x188112810")]
	public ADMHFGCBEHD JGECLGLABGG()
	{
		return default(ADMHFGCBEHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81127B0", Offset = "0x81113B0", VA = "0x1881127B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AJBIEPBJENB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3192920", Offset = "0x3191520", VA = "0x183192920")]
	public static ADMHFGCBEHD NDGLNAHKHEG<T>([In] this ADMHFGCBEHD HFCLOLJPAOJ, HBBKODNPMAI<T> JKAPPJFLKGP, T BKMPCFIAHIG)
	{
		return default(ADMHFGCBEHD);
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
