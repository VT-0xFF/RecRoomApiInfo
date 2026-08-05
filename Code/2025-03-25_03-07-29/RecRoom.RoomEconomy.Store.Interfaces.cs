using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HKFMMKHJKKL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void AILKHJMIJHA(bool PMIBMEBDFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJKNCGLDKJF();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCEEAGFHGCG(List<DHHLNLKMNOA> EKADHDABDDD, bool LLHJACDBHON, bool NDCFIMKFAIO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKLHEANGHMC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<OAGIBKDGOAG> BKBHFLLBONH(DHHLNLKMNOA DJFHGKPBFKB, AILKHJMIJHA FJLFOAFFGHE, bool KHBKPAMCJJI = false, bool JFEHFKJBOPB = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLDLCPPAGKA(DHHLNLKMNOA DJFHGKPBFKB, [Optional] AILKHJMIJHA FJLFOAFFGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DJFJBFCGIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMDEEOALGJL(IEnumerable<HECAOJHPFAL> IJIKHLNPMDH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPJMPHJIKLH NKAKELBHCGF(HECAOJHPFAL PBOGFELIJFM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<HECAOJHPFAL>> FCABBOAMPLC(string NJBELPODFFG, bool? BBFLDLLAFFL, bool? LDEFFINNMMH, IEnumerable<int> IIFAEKOJFIO, bool DHOMOCOCMHJ, bool JKBAPIOEMNE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<HECAOJHPFAL>> NPKJOBBLAEL(IReadOnlyList<HFPMMFEHCHI> BCNBMCOKKKD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LBKKCGPPNFD(Guid DIFAHGJHFEP, long LEJKIBGJJLI, GiftItemDTO JIKOCGPFMOG, OHDCEIDAPAG DEABODKOIAD = OHDCEIDAPAG.RecCenterTokens, [Optional] long? PPKAIAHMPMA, KPMNADCIPPD BKKLEKALCJB = KPMNADCIPPD.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LEELJFOFBAM(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, int LKOAJMNGMNC, long LEJKIBGJJLI, long? PPKAIAHMPMA, int BAOAOHHBBCO = 1, bool KPLNNPBFHKE = false, bool GBNCAPHAKJC = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LAOCKMNIAAA(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, int LKOAJMNGMNC, long LEJKIBGJJLI, long? PPKAIAHMPMA, IReadOnlyCollection<int> OHMOFONDLEN, string EIGJGBPHOMK, bool JNMOEGKBLOJ, FNEFDFLLFBO EJJJICAGKBM, int BAOAOHHBBCO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> GKHOAHDFCHL(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, IReadOnlyList<int> DACHFNKEEPD, IReadOnlyList<long> MGFFBIGAIOP, long? PPKAIAHMPMA, int JIMKKBLBBGE, string EIGJGBPHOMK, bool JNMOEGKBLOJ, FNEFDFLLFBO EJJJICAGKBM);
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
