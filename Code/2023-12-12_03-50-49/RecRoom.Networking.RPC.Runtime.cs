using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CECMMLIFGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(GHLMKMEIFAO.KGOEDEOBCJC<T1> JFCABJNBFNH, T1 EMCACJCLHII);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcPlayer<T1>(PDJKNJCPPID DDADADFKCOE, GHLMKMEIFAO.KGOEDEOBCJC<T1> JFCABJNBFNH, T1 EMCACJCLHII);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcPlayer<T1, T2>(PDJKNJCPPID DDADADFKCOE, GHLMKMEIFAO.IBHNLGPMPDL<T1, T2> JFCABJNBFNH, T1 EMCACJCLHII, T2 GLJNGBGAFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcPlayer<T1, T2, T3>(PDJKNJCPPID DDADADFKCOE, GHLMKMEIFAO.LOHPOPLKBPJ<T1, T2, T3> JFCABJNBFNH, T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcPlayer<T1, T2>(PDJKNJCPPID DDADADFKCOE, GHLMKMEIFAO.LOHPOPLKBPJ<T1, T2, HHFMOENCGHM> JFCABJNBFNH, T1 EMCACJCLHII, T2 GLJNGBGAFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RpcPlayer<T1, T2, T3>(PDJKNJCPPID DDADADFKCOE, GHLMKMEIFAO.LBNCBHIKONO<T1, T2, T3, HHFMOENCGHM> JFCABJNBFNH, T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EHJLGPCJFGB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GHLMKMEIFAO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void HMBBBKLCLLP();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void KGOEDEOBCJC<T1>(T1 EMCACJCLHII);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void IBHNLGPMPDL<T1, T2>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void LOHPOPLKBPJ<T1, T2, T3>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void LBNCBHIKONO<T1, T2, T3, T4>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void OAMCKINIDKP<T1, T2, T3, T4, T5>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void LAAJJJADICM<T1, T2, T3, T4, T5, T6>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void OHFOHOBMDCM<T1, T2, T3, T4, T5, T6, T7>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void KBLANGGOGEE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void NICCBOAMMLK<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void CDJFNFGGHOA<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void ECCFIDPODDC<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM, T11 AODOEKEADJK);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void MNBLMOLIAGG<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM, T11 AODOEKEADJK, T12 BALDLDIGECB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void POAONIFJFKI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM, T11 AODOEKEADJK, T12 BALDLDIGECB, T13 KGHAMEPGHHJ);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void DLFNAFANMIM<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM, T11 AODOEKEADJK, T12 BALDLDIGECB, T13 KGHAMEPGHHJ, T14 PEKKIPIGEED);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void AGLEEOALMMO<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 EMCACJCLHII, T2 GLJNGBGAFDJ, T3 CDMBCOJNJMK, T4 KMKEKANGCBO, T5 IMLGDDKKGOP, T6 OKAGPNLNBNP, T7 PMLCHOCNOGK, T8 OJFFJPPJFPE, T9 AJNPIODIPHL, T10 IMEMPBMCKAM, T11 AODOEKEADJK, T12 BALDLDIGECB, T13 KGHAMEPGHHJ, T14 PEKKIPIGEED, T15 LJLLFMJHDLN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HHFMOENCGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int KNOBJJMBHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PDJKNJCPPID PGPMCEPCAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int KJALBFBNIEI;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E817E0", Offset = "0x5E7FFE0", VA = "0x185E817E0")]
	public HHFMOENCGHM(int KNOBJJMBHAP, PDJKNJCPPID LABLENKOPIL, int CHLHMHHICLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E81670", Offset = "0x5E7FE70", VA = "0x185E81670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DHDBAGHBHOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class JAAEHDCJLNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public JAAEHDCJLNI()
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
