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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class LGMGBCFFGJP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
	public LGMGBCFFGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class EBEPPGENFGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78E9E00", Offset = "0x78E9200", VA = "0x1878E9E00")]
	public EBEPPGENFGL(int MNDMOIHIBEI, int NBFHFMMCLLA, int EIGKGPGMJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class JDJFGPGCFPE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
	public JDJFGPGCFPE(bool DCHJLMIONEB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class LPBDGIFBLDN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78EA220", Offset = "0x78E9620", VA = "0x1878EA220")]
	public LPBDGIFBLDN(string IGEPDAOOLBO, string ONJHPHOODPK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class DMDMHKDBLBI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x203D8B0", Offset = "0x203CCB0", VA = "0x18203D8B0")]
	public DMDMHKDBLBI(int FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum PNAIBPCCLIN
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
public interface DOFHNJLOHFL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface APJDJNIKLAL<T> : DOFHNJLOHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KOIAGPPENMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NIIELOHFHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CDCPPNHJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CMCAGENDGMF(Type HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHGLEEBBFHA(NativeParallelHashMap<int, GIEALLIDLLC> KEDOGBHAGPB, NativeArray<byte> HPMNBNLACCC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHBBGDCPMOC
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KJBHPIKJMBC
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class ILLPNGPJCPA<T> : PHCBLPAGPGN<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x425AAD0", Offset = "0x4259ED0", VA = "0x18425AAD0")]
	protected ILLPNGPJCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PHCBLPAGPGN<T> : APJDJNIKLAL<T>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48FF270", Offset = "0x48FE670", VA = "0x1848FF270")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected PHCBLPAGPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48FF600", Offset = "0x48FEA00", VA = "0x1848FF600", Slot = "4")]
	private void PIKNBEJBPBI([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KBADLACJOFM<T> : APJDJNIKLAL<NativeArray<T>>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E5E0", Offset = "0x4D6D9E0", VA = "0x184D6E5E0")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, NativeArray<T> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37DFFA0", Offset = "0x37DF3A0", VA = "0x1837DFFA0")]
	public static ReadOnlySpan<T> DHLFIIHGBON<T>(NativeArray<T> LLPLHOOOAEB) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected KBADLACJOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E750", Offset = "0x4D6DB50", VA = "0x184D6E750", Slot = "4")]
	private void JCNLAFCFENK([In] CHDCIFBPLEM KJNIJICLPAL, NativeArray<T> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JDJGDBHCEHM : APJDJNIKLAL<JDJGDBHCEHM.GMMIGCFDDLD>, DOFHNJLOHFL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct GMMIGCFDDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, GMMIGCFDDLD FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public JDJGDBHCEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	private void OKOMOBHJIKG([In] CHDCIFBPLEM KJNIJICLPAL, GMMIGCFDDLD FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HOFAJEDACBB : APJDJNIKLAL<string>, DOFHNJLOHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HOFAJEDACBB DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78E9E50", Offset = "0x78E9250", VA = "0x1878E9E50")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public HOFAJEDACBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78EA1A0", Offset = "0x78E95A0", VA = "0x1878EA1A0", Slot = "4")]
	private void HLGADHKELOG([In] CHDCIFBPLEM KJNIJICLPAL, string FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BDEIJBKIFHJ<T> : HEMLHKJOJCN<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x425AAD0", Offset = "0x4259ED0", VA = "0x18425AAD0")]
	protected BDEIJBKIFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HEMLHKJOJCN<T> : APJDJNIKLAL<T>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48FF190", Offset = "0x48FE590", VA = "0x1848FF190")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected HEMLHKJOJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x48FF600", Offset = "0x48FEA00", VA = "0x1848FF600", Slot = "4")]
	private void PIKNBEJBPBI([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CHDCIFBPLEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct APOOAPDCHLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CHDCIFBPLEM KJNIJICLPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int DGNOMHFBEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int AGJNJEBDECL;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5941BD0", Offset = "0x5940FD0", VA = "0x185941BD0")]
		public APOOAPDCHLC(CHDCIFBPLEM KJNIJICLPAL, int DGNOMHFBEPC, int AGJNJEBDECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78E9700", Offset = "0x78E8B00", VA = "0x1878E9700")]
		public APOOAPDCHLC HJEHBEOOJOH(ReadOnlySpan<byte> HPMNBNLACCC)
		{
			return default(APOOAPDCHLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D08700", Offset = "0x3D07B00", VA = "0x183D08700")]
		public APOOAPDCHLC HJEHBEOOJOH<T>(T HPMNBNLACCC) where T : struct
		{
			return default(APOOAPDCHLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78E9660", Offset = "0x78E8A60", VA = "0x1878E9660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private KOIAGPPENMN MOLGLAGNGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, GIEALLIDLLC> KEDOGBHAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x78E9C20", Offset = "0x78E9020", VA = "0x1878E9C20")]
	public CHDCIFBPLEM(KOIAGPPENMN MOLGLAGNGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78E98F0", Offset = "0x78E8CF0", VA = "0x1878E98F0")]
	public int FBBIPPDHMED(DOFHNJLOHFL ILLAJGPAKHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78E9B30", Offset = "0x78E8F30", VA = "0x1878E9B30")]
	public APOOAPDCHLC ODKBCMEGPAE(DOFHNJLOHFL ILLAJGPAKHA)
	{
		return default(APOOAPDCHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78E9A80", Offset = "0x78E8E80", VA = "0x1878E9A80")]
	public APOOAPDCHLC ODKBCMEGPAE(int NGIFAAHIKKJ)
	{
		return default(APOOAPDCHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x78E9760", Offset = "0x78E8B60", VA = "0x1878E9760")]
	public void CBLPHADFEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78E99E0", Offset = "0x78E8DE0", VA = "0x1878E99E0")]
	public CHDCIFBPLEM OAALHNMPGBB()
	{
		return default(CHDCIFBPLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x78E9890", Offset = "0x78E8C90", VA = "0x1878E9890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BDGBIBMIGHH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x338B330", Offset = "0x338A730", VA = "0x18338B330")]
	public static CHDCIFBPLEM JJBKLNLGAIJ<T>([In] this CHDCIFBPLEM KJNIJICLPAL, APJDJNIKLAL<T> ILLAJGPAKHA, T FFOEEMKIKJO)
	{
		return default(CHDCIFBPLEM);
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
