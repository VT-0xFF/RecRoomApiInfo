using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AMLIOPADNGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(HCOOENIBFNP.MJLPHCKMGON<T1> BKEOAKFHKEK, T1 PHGJHCPHPND);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcPlayer<T1>(CBOIFHFJJAA JKFHKEDOHFP, HCOOENIBFNP.MJLPHCKMGON<T1> BKEOAKFHKEK, T1 PHGJHCPHPND);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcPlayer<T1, T2>(CBOIFHFJJAA JKFHKEDOHFP, HCOOENIBFNP.JKADLEFGBGD<T1, T2> BKEOAKFHKEK, T1 PHGJHCPHPND, T2 MMALIOMFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcPlayer<T1, T2, T3>(CBOIFHFJJAA JKFHKEDOHFP, HCOOENIBFNP.KJOIKALCPJF<T1, T2, T3> BKEOAKFHKEK, T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcPlayer<T1, T2>(CBOIFHFJJAA JKFHKEDOHFP, HCOOENIBFNP.KJOIKALCPJF<T1, T2, DFDMIGAPEDA> BKEOAKFHKEK, T1 PHGJHCPHPND, T2 MMALIOMFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RpcPlayer<T1, T2, T3>(CBOIFHFJJAA JKFHKEDOHFP, HCOOENIBFNP.ACDAIHFPAMN<T1, T2, T3, DFDMIGAPEDA> BKEOAKFHKEK, T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DIILHLGMAJI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HCOOENIBFNP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void BMMAPAMIOMD();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void MJLPHCKMGON<T1>(T1 PHGJHCPHPND);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void JKADLEFGBGD<T1, T2>(T1 PHGJHCPHPND, T2 MMALIOMFPPO);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void KJOIKALCPJF<T1, T2, T3>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void ACDAIHFPAMN<T1, T2, T3, T4>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void GCDECOKPOBA<T1, T2, T3, T4, T5>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void NJCIDICIOPC<T1, T2, T3, T4, T5, T6>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void FLGKNPOFDFI<T1, T2, T3, T4, T5, T6, T7>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void GAIKHIKJEKM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void CLBFPJMMIJE<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void MHEKEJGHADO<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void BAJLDGMOIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN, T11 FEDPEKOMIFN);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void FCBBDEABKPE<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN, T11 FEDPEKOMIFN, T12 CLNHHMODPOH);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void FACMCMEABBH<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN, T11 FEDPEKOMIFN, T12 CLNHHMODPOH, T13 FCMFKOKIFKE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void DPEAALBCDPA<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN, T11 FEDPEKOMIFN, T12 CLNHHMODPOH, T13 FCMFKOKIFKE, T14 CHOOBGLKMLK);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void IMIFKMMECLB<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 PHGJHCPHPND, T2 MMALIOMFPPO, T3 FJFKJDNFBHN, T4 LHJODIGFPCO, T5 PEIIMOAGHIB, T6 MECNBMNDHPK, T7 CEGKJAKCJLO, T8 FKAECNPPKCL, T9 GMLFPPPPHAA, T10 KANNBLPJCCN, T11 FEDPEKOMIFN, T12 CLNHHMODPOH, T13 FCMFKOKIFKE, T14 CHOOBGLKMLK, T15 ILPLDIKFCDK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DFDMIGAPEDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int NFGMPNNNBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CBOIFHFJJAA NMHLBGCCKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int EAGFFNMNMDB;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0E70", Offset = "0x5CF0270", VA = "0x185CF0E70")]
	public DFDMIGAPEDA(int NFGMPNNNBMI, CBOIFHFJJAA IDDPIKCGHBG, int EADIIFNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0D00", Offset = "0x5CF0100", VA = "0x185CF0D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LGNLJMDCGAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class GFJCHJPDLIB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public GFJCHJPDLIB()
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
