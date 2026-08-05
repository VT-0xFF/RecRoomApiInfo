using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HIFEHOIDHKN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DKCLAHPHHOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PHIDEHOLELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> GCCLFAHJJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> JFDKFLHKGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> ACPEHIBFMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> GIBANHDJMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DIFHHHIPACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> LABBHGJJJMG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PLOBEDIDLGO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LKCHDLBHGLL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IGFGADCOFJP([Optional] List<string> MHGAAOCAMFA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NNPPFIMPNGB<Guid> GJAJHGFBMCL(JNKBGACMLPG OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GGFPJCKLNCF KIGGPMGFGAP(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GGFPJCKLNCF OJDFIJAFIDO(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MDBMOBDOAHG(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HMBCMOHLIAB(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IEMJHAADMHF(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OCILJLNCPMF(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EGHCLGHAHNP(JNKBGACMLPG OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NFPAHHFGNKA(Guid KOEFBEKPCLL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int MCDFNPCIGHD();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NNPPFIMPNGB<int> CBBBINPJOGL(long NIPGINDOPCB, long AONOECEFMDJ, [Optional] JNKBGACMLPG? OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NNPPFIMPNGB<int> FOIOMLDADLJ(long NIPGINDOPCB, long AONOECEFMDJ, [Optional] JNKBGACMLPG? OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NNPPFIMPNGB<Dictionary<JNKBGACMLPG, int>> KHOKPLELBJI(long NIPGINDOPCB, long AONOECEFMDJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NNPPFIMPNGB<Dictionary<JNKBGACMLPG, int>> EDIKGEGOEML(long NIPGINDOPCB, long AONOECEFMDJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NNPPFIMPNGB<IEnumerable<Guid>> LDGHJAPDCJI(long NIPGINDOPCB, long AONOECEFMDJ, [Optional] JNKBGACMLPG? OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NNPPFIMPNGB<IEnumerable<Guid>> PEPBLHJCGKM(long NIPGINDOPCB, long AONOECEFMDJ, [Optional] JNKBGACMLPG? OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string FFNMIGOBKCI(JNKBGACMLPG OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string KNOFJOIGIPA(JNKBGACMLPG OLJOPAJLGHD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<JNKBGACMLPG> MAPAPPHCDPM();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<JNKBGACMLPG> CICJJJPNNMI();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PCFDBHELIIC(long NIPGINDOPCB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ONLHNIGOKEP(long NIPGINDOPCB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool CEICFIJFPOL(long PGEFBHLAMAN, [Out] DateTime MKCLBLNCKPF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JAPMLLEOHLM(long PGEFBHLAMAN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long DDEELDPDHIO(long IGNIFBJINNO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int CKDHEOFADMN(long PGEFBHLAMAN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool JHKFNGGLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MGMLOMIDMEJ(long PGEFBHLAMAN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> EKENODKMLNE(long PGEFBHLAMAN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int JLCJLDKLFJO(long PGEFBHLAMAN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string BOEGPPHBIGN(PHMNJEDKJPP KLIALIOHHBO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string DFELPDFHDNJ(PHMNJEDKJPP KLIALIOHHBO, int EIGPOLCIEGG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string BPOPOLCMNPL(PHMNJEDKJPP KLIALIOHHBO, long NIPGINDOPCB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long PGFBLCBDJLB(long JOLOANPHHAK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	JNKBGACMLPG ADOLIAEAAMN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IDBBDIGHNMD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum JKMJGPABPFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool GMPPKJBDDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public JKMJGPABPFA? EOPFMOJMGDM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6175AA0", Offset = "0x6174CA0", VA = "0x186175AA0")]
	public IDBBDIGHNMD(bool AFHPJEDJFDN, [Optional] JKMJGPABPFA? GLHDBHJMPBC)
	{
	}
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
