using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CEAICJOAMPB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JFFHBKMMKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BACPBEMFOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> ICACOOGKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> PKCMHKGDALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> LKNNNAMAFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> EMKOCNNPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MHMOKEALFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> IEJHCBJNOPE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AEDCJAOOCKF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AACODNKIBHM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MOIKAMEBPFG([Optional] List<string> OALEMGOCFNP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	global::OOLBMJPBBIG<Guid> KKELJNHHDEA(JHAAPFBDNOG LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PONAFBMJJFC EOEPMPKCGLD(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PONAFBMJJFC EIHFJDNHADD(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ECFLCEHKMLE(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MAAJHHOEKOM(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CJEKBCIIEEE(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NDKEBALBHLA(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PKEKNDNEOAE(JHAAPFBDNOG LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OKDNBOJIGBE(Guid PGDCMKGLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int KODOCMHGMDJ();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	global::OOLBMJPBBIG<int> FGHOKOMBJMF(long GJDNMGJBIPD, long IHEMHLGHIIK, [Optional] JHAAPFBDNOG? LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	global::OOLBMJPBBIG<int> MFFJJHOOJPD(long GJDNMGJBIPD, long IHEMHLGHIIK, [Optional] JHAAPFBDNOG? LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> MNHBGJGHLOM(long GJDNMGJBIPD, long IHEMHLGHIIK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> DFOOMCFAOKB(long GJDNMGJBIPD, long IHEMHLGHIIK);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	global::OOLBMJPBBIG<IEnumerable<Guid>> KLMEJFKFEAF(long GJDNMGJBIPD, long IHEMHLGHIIK, [Optional] JHAAPFBDNOG? LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	global::OOLBMJPBBIG<IEnumerable<Guid>> EEEIOOKHPLF(long GJDNMGJBIPD, long IHEMHLGHIIK, [Optional] JHAAPFBDNOG? LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string BHPOCPGLJMC(JHAAPFBDNOG LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string DIKMBNEJAIF(JHAAPFBDNOG LFNDIBOEPAC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<JHAAPFBDNOG> JBPPJGCGEDA();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<JHAAPFBDNOG> BIEPALPIEJD();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IDDDNGOPIEC(long GJDNMGJBIPD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool PGJJIADAFNI(long GJDNMGJBIPD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PKPLAGIPOAC(long EEDCFAKJGAB, out DateTime HMDEFDDFNJK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long GPHKCJMFDJN(long EEDCFAKJGAB);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long KLNLNFMGOIB(long KNIHJJEMMPP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int JLGFDNCMDPN(long EEDCFAKJGAB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool NDHLBDNKDLO();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool FJOFDIOPJGF(long EEDCFAKJGAB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> DCNKDJEJLLH(long EEDCFAKJGAB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int BFNBBPBKBIG(long EEDCFAKJGAB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string MAKCOEKKDNA(DDGBENLIFAA NJPFEJKAJPI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string HIICOIOHDEF(DDGBENLIFAA NJPFEJKAJPI, int GPIHLDMPDBJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string FAPEDFBGOII(DDGBENLIFAA NJPFEJKAJPI, long GJDNMGJBIPD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long BNKAGOHCPAE(long KHANNPILMEJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	JHAAPFBDNOG FCEMBGNJJEO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AAOOHAPONFN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum OHAICGHBPGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool ELDPPFKOAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public OHAICGHBPGN? FPPOHIEMNAK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xF0C980", Offset = "0xF0B780", VA = "0x180F0C980")]
	public AAOOHAPONFN(bool MJCJFLCFONE, [Optional] OHAICGHBPGN? FFLOPHGPFOD)
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
