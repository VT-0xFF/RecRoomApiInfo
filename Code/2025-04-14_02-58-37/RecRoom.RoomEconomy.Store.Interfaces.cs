using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CLNMPOLJIGK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void KHFKIMPAMHC(bool LJGOOCEHGGM);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAHAGCBPEBD();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNBLEKDBICK(List<LJFIFIAEEED> PKPJLNPLLNP, bool KBLDHLMOLAE, bool LILGCLOPDFK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIBGJKNHBLG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<HKMFJDMPEMN> HJLKJEHNIDB(LJFIFIAEEED PJGKBLDPEBG, KHFKIMPAMHC PCKPGHHEKOC, bool AFICIHOKIAI = false, bool MELDKOLONFM = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHAAFGDKCGJ(LJFIFIAEEED PJGKBLDPEBG, [Optional] KHFKIMPAMHC PCKPGHHEKOC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DBLBJNNJBIA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEIHFLNMDKH(IEnumerable<IBDLCAGKBBC> IAMGLFDKFLE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DDGIJFCOHNN EMAEGJFMCEB(IBDLCAGKBBC EMJEDBNDJMP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<IBDLCAGKBBC>> JBJNILAFMIM(string CHFCHOEBOGG, bool? OKBDGFIMAKG, bool? KJLKCIMIKIG, IEnumerable<int> HLCGBPMOHMH, bool CONAKACOALB, bool PHHGALDPNPI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<IBDLCAGKBBC>> BALELKLIHCJ(IReadOnlyList<LMEDGHCCMPL> MIODDMKJIKF, bool PAKDIFFJHJI = true);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> NEKHJKFMOCE(Guid NJBMCDEDLGE, long KEPIKOGFBEN, GiftItemDTO GGAAPHAEIPO, HINNIBAPJEH OGKGDLBBNEL = HINNIBAPJEH.RecCenterTokens, [Optional] long? MPIKGKALMGC, DHELJFMKHFJ OKLCHMDADCD = DHELJFMKHFJ.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> ACDCFLCEOOP(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, int DHIFLABFMOL, long KEPIKOGFBEN, long? MPIKGKALMGC, int NOCPAFBPCKL = 1, bool EPILAHAPPGE = false, bool CHJEPGFMDAF = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> GICOODGOIED(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, int DHIFLABFMOL, long KEPIKOGFBEN, long? MPIKGKALMGC, IReadOnlyCollection<int> IJGBGOMNDBF, string FLPDJFEEMLN, bool ONOODAKPDII, PHLKILLMMMD MHLFEBCHDEB, int NOCPAFBPCKL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> HAEMFNGJMPM(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, IReadOnlyList<int> JCCBLAOJMCN, IReadOnlyList<long> FJPKNCOJJPN, long? MPIKGKALMGC, int DODGOEHCFCL, string FLPDJFEEMLN, bool ONOODAKPDII, PHLKILLMMMD MHLFEBCHDEB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OLIHKFKKBPA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMPJKOAEIIK(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IBDLCAGKBBC> KHLLLDECKEE(FFANFHDCBDL BBOOLDJCPCC, IReadOnlyList<IBDLCAGKBBC> OIBJKKOCOBE);
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
