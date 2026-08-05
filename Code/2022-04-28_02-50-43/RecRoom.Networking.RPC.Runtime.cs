using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LPJIOIPCADM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(EIBBMCMDAMA.COFHLKHALCH<T1> JIJOLLBGIHH, T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcOthers<T1>(EIBBMCMDAMA.COFHLKHALCH<T1> JIJOLLBGIHH, T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcMaster<T1>(EIBBMCMDAMA.COFHLKHALCH<T1> JIJOLLBGIHH, T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcAuthority<T1>(EIBBMCMDAMA.COFHLKHALCH<T1> JIJOLLBGIHH, T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcAllBuffered<T1>(JNEEFOFPBKG HJEGBDCLGOJ, EIBBMCMDAMA.COFHLKHALCH<T1> JIJOLLBGIHH, T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ClearBufferedRPCs();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JNEEFOFPBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EIBBMCMDAMA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void EGKBEPELDOB();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void COFHLKHALCH<T1>(T1 COFNGBDHPHL);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void OBBBLELDODN<T1, T2>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void OBOEENLJKJP<T1, T2, T3>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void FBJLLBHHMJJ<T1, T2, T3, T4>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void IGINKDNGCAK<T1, T2, T3, T4, T5>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void DAADLFPNNDN<T1, T2, T3, T4, T5, T6>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void ANLBIMALBIC<T1, T2, T3, T4, T5, T6, T7>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void GENMLKOAJFG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void LHODLBDJKOE<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void NGKKAFBDMOG<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void NNAGAECBMHC<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP, T11 JEOELEGHCGP);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void ELEJMFKLIIG<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP, T11 JEOELEGHCGP, T12 HAAGHLBPODB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void MPPGDJDDNMH<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP, T11 JEOELEGHCGP, T12 HAAGHLBPODB, T13 AJJLMHGCFHI);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void GKKFJFBCIBM<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP, T11 JEOELEGHCGP, T12 HAAGHLBPODB, T13 AJJLMHGCFHI, T14 JMEGADBPHAI);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void CLFJABJICIJ<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 COFNGBDHPHL, T2 BKMKJPPEPLD, T3 GEIGNHAHGGF, T4 PCLBGNOACKL, T5 JIEBEFLNBHI, T6 GNPILOCCOOE, T7 LMLENKDOIGJ, T8 CPAJPMOBCNO, T9 KJEFCAFMEFG, T10 MOAGECFKKBP, T11 JEOELEGHCGP, T12 HAAGHLBPODB, T13 AJJLMHGCFHI, T14 JMEGADBPHAI, T15 DDAIFENOACF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CAENDPGPPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int NMPDAGBIMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LFJNMMGBOMJ MFPGKDPAPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int APHNLAMHAMJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CE20", Offset = "0x4C2C020", VA = "0x184C2CE20")]
	public CAENDPGPPKB(int NMPDAGBIMGE, LFJNMMGBOMJ HKFGPBCLENO, int NDECGGEPDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CCE0", Offset = "0x4C2BEE0", VA = "0x184C2CCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EFJKMDIPNAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method)]
public class GDEJACMCHKK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526680", VA = "0x180527480")]
	public GDEJACMCHKK()
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
