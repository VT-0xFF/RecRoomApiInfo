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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class JNDLLKHHMEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public JNDLLKHHMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class FJAFHFLNDKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C46AD0", Offset = "0x7C450D0", VA = "0x187C46AD0")]
	public FJAFHFLNDKE(int CFNMLMNHCMF, int IAFEPKCBHEP, int DFDEPGDGEAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class EEIFCJHAMOH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
	public EEIFCJHAMOH(bool PNNPBNPDKML = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class DIEDLJGNPNM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C46A80", Offset = "0x7C45080", VA = "0x187C46A80")]
	public DIEDLJGNPNM(string NFHOBPDKIPM, string HHPFBMBMELN = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class DFHKJCFMIGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2156030", Offset = "0x2154630", VA = "0x182156030")]
	public DFHKJCFMIGH(int OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum DAFDNPPDPPJ
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
public interface ECEEMCLCJBM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IKNGKOEDHIJ<T> : ECEEMCLCJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CGELPFKAHKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JFILDILNBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MBAEENMAMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KMHDLFLFDMH(Type MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAHGCGNIPFD(NativeParallelHashMap<int, EIOEEPICKHB> OOGHBEFHNIB, NativeArray<byte> APDBNIMCPID);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJMKOEHNHFP
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HMALBMAMGLH
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class GCKMGCFCFCH<T> : MILENPJOEBI<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
	protected GCKMGCFCFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MILENPJOEBI<T> : IKNGKOEDHIJ<T>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x535E0C0", Offset = "0x535C6C0", VA = "0x18535E0C0")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected MILENPJOEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x535E1A0", Offset = "0x535C7A0", VA = "0x18535E1A0", Slot = "4")]
	private void NFBPBLHIPPA([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class BHFNOAEEMPI<T> : IKNGKOEDHIJ<NativeArray<T>>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6337720", Offset = "0x6335D20", VA = "0x186337720")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, NativeArray<T> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39BAB30", Offset = "0x39B9130", VA = "0x1839BAB30")]
	public static ReadOnlySpan<T> FBBAPDPHGJN<T>(NativeArray<T> NBBLCIBNPBK) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected BHFNOAEEMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63376D0", Offset = "0x6335CD0", VA = "0x1863376D0", Slot = "4")]
	private void CBGHAIDKDAM([In] HHFCBOBDKHP CCPLMPHOAIA, NativeArray<T> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CJIPNEPLFBK : IKNGKOEDHIJ<CJIPNEPLFBK.JIEAPNEBEIH>, ECEEMCLCJBM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JIEAPNEBEIH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, JIEAPNEBEIH OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public CJIPNEPLFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	private void AGGIOKEILIF([In] HHFCBOBDKHP CCPLMPHOAIA, JIEAPNEBEIH OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KODHKICDACG : IKNGKOEDHIJ<string>, ECEEMCLCJBM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KODHKICDACG MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C471A0", Offset = "0x7C457A0", VA = "0x187C471A0")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KODHKICDACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C474F0", Offset = "0x7C45AF0", VA = "0x187C474F0", Slot = "4")]
	private void LFKILNPCNDL([In] HHFCBOBDKHP CCPLMPHOAIA, string OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class PDFEJEKNOKF<T> : NKNJPFBANIK<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
	protected PDFEJEKNOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NKNJPFBANIK<T> : IKNGKOEDHIJ<T>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x540CB20", Offset = "0x540B120", VA = "0x18540CB20")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected NKNJPFBANIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x535E1A0", Offset = "0x535C7A0", VA = "0x18535E1A0", Slot = "4")]
	private void NFBPBLHIPPA([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HHFCBOBDKHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OHOOIPCBAHM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HHFCBOBDKHP CCPLMPHOAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int OBBAMBBDKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int EEOLJBCLFHJ;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C6E7D0", Offset = "0x5C6CDD0", VA = "0x185C6E7D0")]
		public OHOOIPCBAHM(HHFCBOBDKHP CCPLMPHOAIA, int OBBAMBBDKFB, int EEOLJBCLFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C47570", Offset = "0x7C45B70", VA = "0x187C47570")]
		public OHOOIPCBAHM BOHPLGCODAJ(ReadOnlySpan<byte> APDBNIMCPID)
		{
			return default(OHOOIPCBAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3F41E70", Offset = "0x3F40470", VA = "0x183F41E70")]
		public OHOOIPCBAHM BOHPLGCODAJ<T>(T APDBNIMCPID) where T : struct
		{
			return default(OHOOIPCBAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C475D0", Offset = "0x7C45BD0", VA = "0x187C475D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CGELPFKAHKM NPLGNNPICKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, EIOEEPICKHB> OOGHBEFHNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C46FD0", Offset = "0x7C455D0", VA = "0x187C46FD0")]
	public HHFCBOBDKHP(CGELPFKAHKM NPLGNNPICKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C46DC0", Offset = "0x7C453C0", VA = "0x187C46DC0")]
	public int FAGBIJGPMLK(ECEEMCLCJBM AKEPDIDIPNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C46BC0", Offset = "0x7C451C0", VA = "0x187C46BC0")]
	public OHOOIPCBAHM CHNNPIOIFNL(ECEEMCLCJBM AKEPDIDIPNP)
	{
		return default(OHOOIPCBAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C46CB0", Offset = "0x7C452B0", VA = "0x187C46CB0")]
	public OHOOIPCBAHM CHNNPIOIFNL(int FGLOIFGDDND)
	{
		return default(OHOOIPCBAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C46EA0", Offset = "0x7C454A0", VA = "0x187C46EA0")]
	public void KJNJFNLADEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C46B20", Offset = "0x7C45120", VA = "0x187C46B20")]
	public HHFCBOBDKHP AKBKNLLCFBD()
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C46D60", Offset = "0x7C45360", VA = "0x187C46D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HKNLMPHEPOI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3888340", Offset = "0x3886940", VA = "0x183888340")]
	public static HHFCBOBDKHP IIGLPCDPOEE<T>([In] this HHFCBOBDKHP CCPLMPHOAIA, IKNGKOEDHIJ<T> AKEPDIDIPNP, T OHLIHBDBKCE)
	{
		return default(HHFCBOBDKHP);
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
