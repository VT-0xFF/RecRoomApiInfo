using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IANOFGNHACF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(CNEFDBKGIOK.NDBELBGLMKJ<T1> KLGJKLPJJAN, T1 IPMEBNHLNMN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcPlayer<T1>(KCMOAPDBFGB PENGDIMNCLF, CNEFDBKGIOK.NDBELBGLMKJ<T1> KLGJKLPJJAN, T1 IPMEBNHLNMN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcPlayer<T1, T2>(KCMOAPDBFGB PENGDIMNCLF, CNEFDBKGIOK.HFGCMOPDIOE<T1, T2> KLGJKLPJJAN, T1 IPMEBNHLNMN, T2 CCICHOEHGAG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcPlayer<T1, T2, T3>(KCMOAPDBFGB PENGDIMNCLF, CNEFDBKGIOK.FCHBJHEBCPE<T1, T2, T3> KLGJKLPJJAN, T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcPlayer<T1, T2>(KCMOAPDBFGB PENGDIMNCLF, CNEFDBKGIOK.FCHBJHEBCPE<T1, T2, DDNPDAPPBBN> KLGJKLPJJAN, T1 IPMEBNHLNMN, T2 CCICHOEHGAG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RpcPlayer<T1, T2, T3>(KCMOAPDBFGB PENGDIMNCLF, CNEFDBKGIOK.JNFGFJGGKHE<T1, T2, T3, DDNPDAPPBBN> KLGJKLPJJAN, T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KLLHABIPIPM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CNEFDBKGIOK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void HMHJPHHBHBF();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void NDBELBGLMKJ<T1>(T1 IPMEBNHLNMN);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void HFGCMOPDIOE<T1, T2>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void FCHBJHEBCPE<T1, T2, T3>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void JNFGFJGGKHE<T1, T2, T3, T4>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void EKGDEJBKDPM<T1, T2, T3, T4, T5>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void MLGHGHPIOEE<T1, T2, T3, T4, T5, T6>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void APACBEFNLND<T1, T2, T3, T4, T5, T6, T7>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void OCPGLKNMBEA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void HMLHDFHCFPI<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void DALNAGGABDN<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void NMPCEKPMDDN<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM, T11 AKFPPEEKNLL);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void PGCLEMNNOFN<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM, T11 AKFPPEEKNLL, T12 DHEKAOOPMOD);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void BDDEMFODBKH<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM, T11 AKFPPEEKNLL, T12 DHEKAOOPMOD, T13 EELLDIEINKI);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void BOKJFDDFDPI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM, T11 AKFPPEEKNLL, T12 DHEKAOOPMOD, T13 EELLDIEINKI, T14 IHOPLPHGLBG);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void BDIFIBLFJPF<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 IPMEBNHLNMN, T2 CCICHOEHGAG, T3 JNNOMNIMBNN, T4 AMNILEEJFOF, T5 MKJNBAOCKLB, T6 HNNHNGFHLLP, T7 HJPLPJEPGGB, T8 BBABCGJJMCP, T9 NDEIJNJLPCN, T10 FMBIFJABMIM, T11 AKFPPEEKNLL, T12 DHEKAOOPMOD, T13 EELLDIEINKI, T14 IHOPLPHGLBG, T15 CBAEGIMIAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DDNPDAPPBBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int MAAJMEHNEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KCMOAPDBFGB OJLOKEOIJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int FIHEGGIOLLP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6912500", Offset = "0x6910D00", VA = "0x186912500")]
	public DDNPDAPPBBN(int MAAJMEHNEJP, KCMOAPDBFGB PFBKDLOKJDO, int EDOBGOMOABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6912390", Offset = "0x6910B90", VA = "0x186912390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JBNKFNADDAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class FHMGIGGGGML : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
	public FHMGIGGGGML()
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
