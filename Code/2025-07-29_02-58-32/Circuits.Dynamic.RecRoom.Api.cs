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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A53F10", Offset = "0x2A52910", VA = "0x182A53F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KKCAPMJIHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public COBPPOBACAG<AFPCAKGJDAH> DEKCOFIKEMI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A53EE0", Offset = "0x2A528E0", VA = "0x182A53EE0")]
	public static KKCAPMJIHHB MDDJOGPLAFO()
	{
		return default(KKCAPMJIHHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A53EB0", Offset = "0x2A528B0", VA = "0x182A53EB0")]
	[CompilerGenerated]
	internal static COBPPOBACAG<AFPCAKGJDAH> GJMHBLABMNL(int PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<AFPCAKGJDAH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DKJLHOEKKGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MJIAGIEOGAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EDKBPKHIPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int EEPNDGFLPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float PBKBKIJBGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AFMBBICIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EAPMGOAIIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HBLLGOOIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HPAJBGNGBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetMaxAmmo(MDIDHGPGJOH KOFGEHMDLMC, int HJDOALAIPGL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetCurrentAmmo(MDIDHGPGJOH KOFGEHMDLMC, int DLHGOHOFAFO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetADSEnabled(MDIDHGPGJOH KOFGEHMDLMC, bool DKBBOMHPGKC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetCanReload(MDIDHGPGJOH KOFGEHMDLMC, bool GFDLEJGMBIL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetContinuousFire(MDIDHGPGJOH KOFGEHMDLMC, bool FPKHPLGPJGB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetRateOfFire(MDIDHGPGJOH KOFGEHMDLMC, float MPOEOGOGFNG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IINGCGDABFK<FAIGCFGAAKD> CV2SetReloadDuration(MDIDHGPGJOH KOFGEHMDLMC, float FPIFKAOGCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EFNPBPEIJGC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string OKPGMNCLCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IINGCGDABFK<FAIGCFGAAKD> SetHandleControlLabel(MDIDHGPGJOH KOFGEHMDLMC, string HJIKHCCLFIK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKMJKLEIDAD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(DKJLHOEKKGD, DKJLHOEKKGD, DKJLHOEKKGD, DKJLHOEKKGD, DKJLHOEKKGD) OPGJHHOALPK(object JGGGINODJOB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object ODIEGOIMPNG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKCDJFPCHCL(object JGGGINODJOB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string EDKNHJEKAHL(object JGGGINODJOB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MJMJCIHKPLD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LOCHKFKKJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CGJCIPHEJOG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMMDFPJOCEM AJBEIBCIFCJ(int CCFPHLHMPKA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MHPCKKMKMOJ([In] MMMDFPJOCEM HCFBOOBGOJF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LIAMGIFEMAM
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IINGCGDABFK<FAIGCFGAAKD> SetEnabled(MDIDHGPGJOH KOFGEHMDLMC, bool PLODKGKGKCL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HAIDHFFBAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OEKLACBAABO PKCFFNAILEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CGJCIPHEJOG ABACFMCHMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly AKMJKLEIDAD KHLPCHJKEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KKCAPMJIHHB MHEIKFFNEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DJJJGCMPILH NKLIKJDPGDI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2A53E40", Offset = "0x2A52840", VA = "0x182A53E40")]
	public HAIDHFFBAFD(OEKLACBAABO FAOJFHMNBDD, CGJCIPHEJOG LMMBHNKGKJF, AKMJKLEIDAD JEJKAANIENF, [In] KKCAPMJIHHB MDIFJAAFPDP, DJJJGCMPILH LDLFFNMOMMO)
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
