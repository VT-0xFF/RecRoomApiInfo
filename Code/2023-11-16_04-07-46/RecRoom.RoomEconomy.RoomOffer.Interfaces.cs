using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IBGMJADFFKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JEHDIEPKPPJ<GHBHEBNODNK> DKCOIDFJKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x232A9A802329F5", Offset = "0x0", VA = "0x232A9C002329F5", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x232A9A892FB918", Offset = "0x0", VA = "0x232A9C092FB918", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JEHDIEPKPPJ<Guid> BCAHBMAKJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x92FB93280232AED", Offset = "0x0", VA = "0x92FB93400232AED", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x232AF180232AED", Offset = "0x0", VA = "0x232AF300232AED", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x232AF1892FB944", Offset = "0x0", VA = "0x232AF3092FB944", Slot = "4")]
	Task<CJDJPCEAKND<GHBHEBNODNK, string>> AKJOGLLBGBF(long KAOIBEOBDCN, string JNMEJDHMADI, string BEOAJBBECNO, string GBFFJBCAJEE, int LMGNEIDMDPO, KBNOFAKDMEK GAJFOOPMICH, [Optional] Dictionary<Guid, int> LEIMNOEMAKF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x92FB93280232B44", Offset = "0x0", VA = "0x92FB93400232B44", Slot = "5")]
	Task<CJDJPCEAKND<GHBHEBNODNK, string>> FOJEPOLLFFM(Guid PHPJEFMLELP, string JNMEJDHMADI, string BEOAJBBECNO, string GBFFJBCAJEE, int LMGNEIDMDPO, KBNOFAKDMEK GAJFOOPMICH, [Optional] Dictionary<Guid, int> LEIMNOEMAKF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x232B7380232B50", Offset = "0x0", VA = "0x232B7500232B50", Slot = "6")]
	Task<CJDJPCEAKND<bool, string>> JPOGOHLHNLL(Guid PHPJEFMLELP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x232B7389164DB4", Offset = "0x0", VA = "0x232B7509164DB4", Slot = "7")]
	IEnumerable<GHBHEBNODNK> FIJHJGGBPAD();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x92FB21680232C1C", Offset = "0x0", VA = "0x92FB21800232C1C", Slot = "8")]
	bool ELNMBFCNFIH(Guid PHPJEFMLELP, [Out] GHBHEBNODNK OLGHBOEBBCM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x232C6B80232C1C", Offset = "0x0", VA = "0x232C6D00232C1C", Slot = "9")]
	bool JCLFJCADDMJ(Guid MLKBMJHEECD, [Out] List<string> AJLALAILFFA);
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
