using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ODBPINNLJME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHDCMHCCFCG(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, BNFABCHNBCL NLIBDKKPKLB, DFOLGABGJMH NNHBIDDPDEK, params object[] AJLJPILGNIP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHDCMHCCFCG(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, EIDEGPMEPAM LBPEJPMBIKP, DFOLGABGJMH NNHBIDDPDEK, params object[] AJLJPILGNIP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCNMGHMLAEM(ViewId LIOACKIDDBK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string PJGHMIMDAMN(HIPDGMOFECH ODLIDIMANGE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOECHMNDMCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KGGENHHCLLF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcAll<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcAll<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLFIBMEPEJL.JOJJLNNFJHI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RpcAllViaServer<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RpcOthers<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLFIBMEPEJL.JOJJLNNFJHI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RpcMaster<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RpcPlayer(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RpcPlayer<T1>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RpcPlayer<T1, T2>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RpcPlayer<T1, T2, T3>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void RpcPlayer<T1, T2, T3, T4>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.FOKADDBHABI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void RpcPlayer<T1, T2>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RpcPlayer<T1, T2, T3>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IDHPEHKKLEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	DoNotCache = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AddToRoomCacheGlobal = 5
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HDIEOJDMBNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	(Type, Func<MonoBehaviour, object>)[] AJLAFNGCFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OJDEBPCEDIL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KGGENHHCLLF NDNGELCKJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PLFIBMEPEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void KDJHBMICHHD();

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void JAMCMLIMLGH<T1>(T1 DGDONNHKDHE);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void JLHFHGLHKCK<T1, T2>(T1 DGDONNHKDHE, T2 MKGDONKGCMI);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void IKNMOKALHEO<T1, T2, T3>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void LGFOENKEGMH<T1, T2, T3, T4>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void HEEBAHHJIEC<T1, T2, T3, T4, T5>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void KOMLIFDIAIL<T1, T2, T3, T4, T5, T6>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void JOJJLNNFJHI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void FOKADDBHABI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void DFAFKNHMIPJ<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void DOHBPOHOONN<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void GEBFKAKOJFA<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void ICNEIGCHPGL<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG, T15 PLAKGDOOJOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NIHFGKDLNDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int HGHMNJJEKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly BNFABCHNBCL MJAAKMGHDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int LMKPGOKNJNM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D77CC0", Offset = "0x7D76EC0", VA = "0x187D77CC0")]
	public NIHFGKDLNDI(int HGHMNJJEKDM, BNFABCHNBCL GCPKMNCMKPP, int LIOACKIDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D77B50", Offset = "0x7D76D50", VA = "0x187D77B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class KCNCHMBHOPM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public KCNCHMBHOPM()
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
