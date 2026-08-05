using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28DCEF0", Offset = "0x28DB8F0", VA = "0x1828DCEF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BCOPIBOOFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EHLNDDDNIPO<FPKEBAOHCAD> IDHHJDMKILC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28DCE90", Offset = "0x28DB890", VA = "0x1828DCE90")]
	public static BCOPIBOOFPG FMDOFBCLPJB()
	{
		return default(BCOPIBOOFPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28DCEC0", Offset = "0x28DB8C0", VA = "0x1828DCEC0")]
	[CompilerGenerated]
	internal static EHLNDDDNIPO<FPKEBAOHCAD> PEAMLCKCDFO(int PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<FPKEBAOHCAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HALLCOPKFOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MDFFHDOIHHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GKNHMCFOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int IHCNHJFLDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float DHFLBOGFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float ALKCGKKPJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool APFMDOFEKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NDPNEFIAFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MAPAFGLJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetMaxAmmo(APMJKGPCIPB AJLHKIHCGAH, int EOFJEGBKIJO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetCurrentAmmo(APMJKGPCIPB AJLHKIHCGAH, int JHMCKEFMDEL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetADSEnabled(APMJKGPCIPB AJLHKIHCGAH, bool KALBLPGLPEO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetCanReload(APMJKGPCIPB AJLHKIHCGAH, bool OGIGBIPJHBK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetContinuousFire(APMJKGPCIPB AJLHKIHCGAH, bool DHLMHHAFHEI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetRateOfFire(APMJKGPCIPB AJLHKIHCGAH, float BBPCAINDFBK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LIIOLMOHPCD<NOHGHNIBNOG> CV2SetReloadDuration(APMJKGPCIPB AJLHKIHCGAH, float FDFNAMJJMBO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface INMGGNEGDPL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FCCPCFKNGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIIOLMOHPCD<NOHGHNIBNOG> SetHandleControlLabel(APMJKGPCIPB AJLHKIHCGAH, string DCBDCJILPIG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GLLANMFJDMF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(HALLCOPKFOL, HALLCOPKFOL, HALLCOPKFOL, HALLCOPKFOL, HALLCOPKFOL) DGOEDJDKGOP(object KPIDJKLDGJJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object ANDJFCONFPN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBILGBNKLDB(object KPIDJKLDGJJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string JNGFKDOLEIC(object KPIDJKLDGJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GNPJOGGGPAL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EAIKNJDDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NFBGBBGDOEO
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFLIAJHLHOF JKPAACEIMKC(int DHMNNCOFBEA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BAPBIIBNLIK([In] EFLIAJHLHOF KBIDFOLNFAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HDGPNOHEIMN
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIIOLMOHPCD<NOHGHNIBNOG> SetEnabled(APMJKGPCIPB AJLHKIHCGAH, bool ALGEALLNEFI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PIJHLDDHOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BAJOOGCFIJP MIKHEOFADEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NFBGBBGDOEO IKGANBPKFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly GLLANMFJDMF LIFKKGEBKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BCOPIBOOFPG CBMPIPKOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly JIFPBLFFAHD JKIKPCFHELH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28DCF70", Offset = "0x28DB970", VA = "0x1828DCF70")]
	public PIJHLDDHOIA(BAJOOGCFIJP JMADECGBDEH, NFBGBBGDOEO KMOGBPCJIGC, GLLANMFJDMF ABNHCNEKEPA, [In] BCOPIBOOFPG OMIGFIPEAPL, JIFPBLFFAHD GFMHPHBCIJN)
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
