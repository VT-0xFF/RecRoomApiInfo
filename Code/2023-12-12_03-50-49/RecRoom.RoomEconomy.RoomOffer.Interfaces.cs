using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IKFEDODLPLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LJECGABKDKN KJFDFDGNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x22EE8E893252B8", Offset = "0x0", VA = "0x22EE90093252B8", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x92429068022EEB5", Offset = "0x0", VA = "0x92429080022EEB5", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LBEDKEAJHCP<KLGGOIJEPPO> MIMPDELCMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x22EF5C8022EEB5", Offset = "0x0", VA = "0x22EF5E0022EEB5", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22EF5C89323D5C", Offset = "0x0", VA = "0x22EF5E09323D5C", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LBEDKEAJHCP<Guid> JNDNNPCGIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9323D768022EFAF", Offset = "0x0", VA = "0x9323D780022EFAF", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22EFB38022EFAF", Offset = "0x0", VA = "0x22EFB50022EFAF", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22EFB389323D88", Offset = "0x0", VA = "0x22EFB509323D88", Slot = "6")]
	Task<LBFOJMHFNLD<KLGGOIJEPPO, string>> CLOFGDBHOFJ(long AKDANPAICOC, string PMDCAPIFBIP, string MMOFPMCDOKA, string KMHKMMMDMNC, int EGOEDAGBFEN, EHNNEHDFEGA PNFOOELGEDK, [Optional] Dictionary<Guid, int> FDGOKDLDJDK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9323D768022F006", Offset = "0x0", VA = "0x9323D780022F006", Slot = "7")]
	Task<LBFOJMHFNLD<KLGGOIJEPPO, string>> OCCKPDFHDGL(Guid FMBAMPIOFGD, string PMDCAPIFBIP, string MMOFPMCDOKA, string KMHKMMMDMNC, int EGOEDAGBFEN, EHNNEHDFEGA PNFOOELGEDK, [Optional] Dictionary<Guid, int> FDGOKDLDJDK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22F0388022F010", Offset = "0x0", VA = "0x22F03A0022F010", Slot = "8")]
	Task<LBFOJMHFNLD<bool, string>> DIAMLHKDEOJ(Guid FMBAMPIOFGD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22F038891F3888", Offset = "0x0", VA = "0x22F03A091F3888", Slot = "9")]
	IEnumerable<KLGGOIJEPPO> MJKCJJFPDBI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x93255DA8022F10B", Offset = "0x0", VA = "0x93255DC0022F10B", Slot = "10")]
	bool JINMAIGDKMC(Guid FMBAMPIOFGD, [Out] KLGGOIJEPPO KPDMHNNACOL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22F15A8022F10B", Offset = "0x0", VA = "0x22F15C0022F10B", Slot = "11")]
	bool HFLIHDLDBNH(Guid FMBAMPIOFGD, int HHJHDHELCBC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22F15A893255F8", Offset = "0x0", VA = "0x22F15C093255F8", Slot = "12")]
	void PEDIIPMAEKH(PDJKNJCPPID DDADADFKCOE, Guid FMBAMPIOFGD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x93256068022F162", Offset = "0x0", VA = "0x93256080022F162", Slot = "13")]
	bool IBPIDHKAAAM();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22F1B18022F162", Offset = "0x0", VA = "0x22F1B30022F162", Slot = "14")]
	bool OBALFIMKLOE(Guid ECJOFIKMMDJ, [Out] List<string> JBOFGFEGELD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22F1BE893255F8", Offset = "0x0", VA = "0x22F1C0093255F8", Slot = "15")]
	Task<LBFOJMHFNLD<bool, string>> BHJGALEAPJH(KLGGOIJEPPO KPDMHNNACOL, long JLDABFDNMLP, int AAEHEHHJFMP, [Optional] string JJDCFJKBOEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OAGFHKPEKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x92FD1B28022F1E7", Offset = "0x0", VA = "0x92FD1B40022F1E7", Slot = "0")]
	void MJLFIDLNAHK(Guid JFDGGNKIOHM, string JJDCFJKBOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22F2A38022F1E7", Offset = "0x0", VA = "0x22F2A50022F1E7", Slot = "1")]
	void OMFJAIICILH(Guid JFDGGNKIOHM, string JJDCFJKBOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22F2A389324B9C", Offset = "0x0", VA = "0x22F2A509324B9C", Slot = "2")]
	void JNENBPJOPGM(Guid JFDGGNKIOHM, int AAEHEHHJFMP);
}
namespace Cpp2IlInjected;

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
