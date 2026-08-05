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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public LGMGBCFFGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class EBEPPGENFGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x789B680", Offset = "0x789AA80", VA = "0x18789B680")]
	public EBEPPGENFGL(int MNDMOIHIBEI, int NBFHFMMCLLA, int EIGKGPGMJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class JDJFGPGCFPE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
	public JDJFGPGCFPE(bool DCHJLMIONEB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class LPBDGIFBLDN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x789BAB0", Offset = "0x789AEB0", VA = "0x18789BAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2034710", Offset = "0x2033B10", VA = "0x182034710")]
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
	[Cpp2IlInjected.Address(RVA = "0x423D1B0", Offset = "0x423C5B0", VA = "0x18423D1B0")]
	protected ILLPNGPJCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PHCBLPAGPGN<T> : APJDJNIKLAL<T>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48CE090", Offset = "0x48CD490", VA = "0x1848CE090")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected PHCBLPAGPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48CE420", Offset = "0x48CD820", VA = "0x1848CE420", Slot = "4")]
	private void PIKNBEJBPBI([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KBADLACJOFM<T> : APJDJNIKLAL<NativeArray<T>>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D4FEA0", Offset = "0x4D4F2A0", VA = "0x184D4FEA0")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, NativeArray<T> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37D7300", Offset = "0x37D6700", VA = "0x1837D7300")]
	public static ReadOnlySpan<T> DHLFIIHGBON<T>(NativeArray<T> LLPLHOOOAEB) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected KBADLACJOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D50010", Offset = "0x4D4F410", VA = "0x184D50010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, GMMIGCFDDLD FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public JDJGDBHCEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x789B6D0", Offset = "0x789AAD0", VA = "0x18789B6D0")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public HOFAJEDACBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x789BA20", Offset = "0x789AE20", VA = "0x18789BA20", Slot = "4")]
	private void HLGADHKELOG([In] CHDCIFBPLEM KJNIJICLPAL, string FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BDEIJBKIFHJ<T> : HEMLHKJOJCN<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x423D1B0", Offset = "0x423C5B0", VA = "0x18423D1B0")]
	protected BDEIJBKIFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HEMLHKJOJCN<T> : APJDJNIKLAL<T>, DOFHNJLOHFL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48CDFB0", Offset = "0x48CD3B0", VA = "0x1848CDFB0")]
	public void CGDPMOMAHNG([In] CHDCIFBPLEM KJNIJICLPAL, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected HEMLHKJOJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x48CE420", Offset = "0x48CD820", VA = "0x1848CE420", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5908F40", Offset = "0x5908340", VA = "0x185908F40")]
		public APOOAPDCHLC(CHDCIFBPLEM KJNIJICLPAL, int DGNOMHFBEPC, int AGJNJEBDECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x789AF70", Offset = "0x789A370", VA = "0x18789AF70")]
		public APOOAPDCHLC HJEHBEOOJOH(ReadOnlySpan<byte> HPMNBNLACCC)
		{
			return default(APOOAPDCHLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9FF0", Offset = "0x3CF93F0", VA = "0x183CF9FF0")]
		public APOOAPDCHLC HJEHBEOOJOH<T>(T HPMNBNLACCC) where T : struct
		{
			return default(APOOAPDCHLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x789AED0", Offset = "0x789A2D0", VA = "0x18789AED0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x789B490", Offset = "0x789A890", VA = "0x18789B490")]
	public CHDCIFBPLEM(KOIAGPPENMN MOLGLAGNGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x789B160", Offset = "0x789A560", VA = "0x18789B160")]
	public int FBBIPPDHMED(DOFHNJLOHFL ILLAJGPAKHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x789B3A0", Offset = "0x789A7A0", VA = "0x18789B3A0")]
	public APOOAPDCHLC ODKBCMEGPAE(DOFHNJLOHFL ILLAJGPAKHA)
	{
		return default(APOOAPDCHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x789B2F0", Offset = "0x789A6F0", VA = "0x18789B2F0")]
	public APOOAPDCHLC ODKBCMEGPAE(int NGIFAAHIKKJ)
	{
		return default(APOOAPDCHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x789AFD0", Offset = "0x789A3D0", VA = "0x18789AFD0")]
	public void CBLPHADFEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x789B250", Offset = "0x789A650", VA = "0x18789B250")]
	public CHDCIFBPLEM OAALHNMPGBB()
	{
		return default(CHDCIFBPLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x789B100", Offset = "0x789A500", VA = "0x18789B100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BDGBIBMIGHH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3375170", Offset = "0x3374570", VA = "0x183375170")]
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
