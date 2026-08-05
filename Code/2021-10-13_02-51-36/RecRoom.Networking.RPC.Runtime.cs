using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CDMFINLPMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(LNPGNNONOEL.MOOFMMEPGCO<T1> FPHFGHHJOOA, T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcOthers<T1>(LNPGNNONOEL.MOOFMMEPGCO<T1> FPHFGHHJOOA, T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcMaster<T1>(LNPGNNONOEL.MOOFMMEPGCO<T1> FPHFGHHJOOA, T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcAuthority<T1>(LNPGNNONOEL.MOOFMMEPGCO<T1> FPHFGHHJOOA, T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcAllBuffered<T1>(MLFCAEGEOCK JBBJPHCBILM, LNPGNNONOEL.MOOFMMEPGCO<T1> FPHFGHHJOOA, T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ClearBufferedRPCs();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MLFCAEGEOCK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LNPGNNONOEL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void AKKIDCKIJDF();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void MOOFMMEPGCO<T1>(T1 NFOPALHCBDH);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void NDBEFICKCAC<T1, T2>(T1 NFOPALHCBDH, T2 ODKNNKKBODE);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void KJJAEIFOMMJ<T1, T2, T3>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void DDPJGNFPMGC<T1, T2, T3, T4>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void FMINDILDCIF<T1, T2, T3, T4, T5>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void FFIBKPAEFPA<T1, T2, T3, T4, T5, T6>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void IKGIDNDFEOE<T1, T2, T3, T4, T5, T6, T7>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void KCHEDPHAFEP<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void GKJLNLMPMCN<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void AJHIAJMBKBB<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void EFDLBAHCHLA<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO, T11 HBBODLLIBGO);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void MOKAFLJMANA<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO, T11 HBBODLLIBGO, T12 NMGBBPBGHHE);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void MIKACJBCMPL<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO, T11 HBBODLLIBGO, T12 NMGBBPBGHHE, T13 FOCIFDKBDCE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void CJJCFJCMLFC<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO, T11 HBBODLLIBGO, T12 NMGBBPBGHHE, T13 FOCIFDKBDCE, T14 LMIGAOIHONF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HGNEOCABKMH<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 NFOPALHCBDH, T2 ODKNNKKBODE, T3 EABDHHCKGOB, T4 LCBPANBAPHL, T5 CPFOGMFLPLD, T6 DPIJNFJAOFP, T7 DFPOAOMFKCF, T8 GHBFDDEENMJ, T9 ODCOJJFFHMJ, T10 OEGKMOABDFO, T11 HBBODLLIBGO, T12 NMGBBPBGHHE, T13 FOCIFDKBDCE, T14 LMIGAOIHONF, T15 DNJNLFOFPBD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CGEJGGKJCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int HHFCOOBCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JJIBGPOBCJN CNPPHLBNOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int LMKBJDHBDGN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37CF970", Offset = "0x37CED70", VA = "0x1837CF970")]
	public CGEJGGKJCFJ(int HHFCOOBCJBH, JJIBGPOBCJN BILPJHNADJN, int KLBMGIGPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40918F0", Offset = "0x4090CF0", VA = "0x1840918F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HGENAEOGKHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method)]
public class EMDEECGFMMD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F9460", Offset = "0x4F8860", VA = "0x1804F9460")]
	public EMDEECGFMMD()
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
