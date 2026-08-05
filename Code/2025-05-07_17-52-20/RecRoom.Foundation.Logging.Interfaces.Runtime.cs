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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public JNDLLKHHMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class FJAFHFLNDKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B330", Offset = "0x7C7A330", VA = "0x187C7B330")]
	public FJAFHFLNDKE(int CFNMLMNHCMF, int IAFEPKCBHEP, int DFDEPGDGEAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class EEIFCJHAMOH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
	public EEIFCJHAMOH(bool PNNPBNPDKML = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class DIEDLJGNPNM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B2E0", Offset = "0x7C7A2E0", VA = "0x187C7B2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x213E640", Offset = "0x213D640", VA = "0x18213E640")]
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
	[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
	protected GCKMGCFCFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MILENPJOEBI<T> : IKNGKOEDHIJ<T>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x533A0F0", Offset = "0x53390F0", VA = "0x18533A0F0")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected MILENPJOEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x533A1D0", Offset = "0x53391D0", VA = "0x18533A1D0", Slot = "4")]
	private void NFBPBLHIPPA([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class BHFNOAEEMPI<T> : IKNGKOEDHIJ<NativeArray<T>>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63A6FC0", Offset = "0x63A5FC0", VA = "0x1863A6FC0")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, NativeArray<T> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x399E580", Offset = "0x399D580", VA = "0x18399E580")]
	public static ReadOnlySpan<T> FBBAPDPHGJN<T>(NativeArray<T> NBBLCIBNPBK) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected BHFNOAEEMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63A6F70", Offset = "0x63A5F70", VA = "0x1863A6F70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, JIEAPNEBEIH OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public CJIPNEPLFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C7BA00", Offset = "0x7C7AA00", VA = "0x187C7BA00")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KODHKICDACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BD50", Offset = "0x7C7AD50", VA = "0x187C7BD50", Slot = "4")]
	private void LFKILNPCNDL([In] HHFCBOBDKHP CCPLMPHOAIA, string OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class PDFEJEKNOKF<T> : NKNJPFBANIK<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
	protected PDFEJEKNOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NKNJPFBANIK<T> : IKNGKOEDHIJ<T>, ECEEMCLCJBM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x53EE030", Offset = "0x53ED030", VA = "0x1853EE030")]
	public void GMMIEDFPKGO([In] HHFCBOBDKHP CCPLMPHOAIA, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected NKNJPFBANIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x533A1D0", Offset = "0x53391D0", VA = "0x18533A1D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C77960", Offset = "0x5C76960", VA = "0x185C77960")]
		public OHOOIPCBAHM(HHFCBOBDKHP CCPLMPHOAIA, int OBBAMBBDKFB, int EEOLJBCLFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BDE0", Offset = "0x7C7ADE0", VA = "0x187C7BDE0")]
		public OHOOIPCBAHM BOHPLGCODAJ(ReadOnlySpan<byte> APDBNIMCPID)
		{
			return default(OHOOIPCBAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDE40", Offset = "0x3EDCE40", VA = "0x183EDDE40")]
		public OHOOIPCBAHM BOHPLGCODAJ<T>(T APDBNIMCPID) where T : struct
		{
			return default(OHOOIPCBAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BE40", Offset = "0x7C7AE40", VA = "0x187C7BE40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C7B830", Offset = "0x7C7A830", VA = "0x187C7B830")]
	public HHFCBOBDKHP(CGELPFKAHKM NPLGNNPICKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B620", Offset = "0x7C7A620", VA = "0x187C7B620")]
	public int FAGBIJGPMLK(ECEEMCLCJBM AKEPDIDIPNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B420", Offset = "0x7C7A420", VA = "0x187C7B420")]
	public OHOOIPCBAHM CHNNPIOIFNL(ECEEMCLCJBM AKEPDIDIPNP)
	{
		return default(OHOOIPCBAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B510", Offset = "0x7C7A510", VA = "0x187C7B510")]
	public OHOOIPCBAHM CHNNPIOIFNL(int FGLOIFGDDND)
	{
		return default(OHOOIPCBAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B700", Offset = "0x7C7A700", VA = "0x187C7B700")]
	public void KJNJFNLADEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B380", Offset = "0x7C7A380", VA = "0x187C7B380")]
	public HHFCBOBDKHP AKBKNLLCFBD()
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B5C0", Offset = "0x7C7A5C0", VA = "0x187C7B5C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HKNLMPHEPOI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x386A1C0", Offset = "0x38691C0", VA = "0x18386A1C0")]
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
