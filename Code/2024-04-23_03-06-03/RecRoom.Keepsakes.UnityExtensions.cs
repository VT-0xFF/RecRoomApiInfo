using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GDKAHCNAPMK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62E88D0", Offset = "0x62E78D0", VA = "0x1862E88D0")]
	public static KeepsakeTheme NLJFBLHPOFD(this BJBDBHCONPP PGDDBCEFICD, Guid HACFNNODNBE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62E89C0", Offset = "0x62E79C0", VA = "0x1862E89C0")]
	public static KeepsakeTheme NLJFBLHPOFD(this BJBDBHCONPP PGDDBCEFICD, NNOHEMIGJHE FFEJNAIEJGN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62E8700", Offset = "0x62E7700", VA = "0x1862E8700")]
	public static List<KeepsakeTheme> EGPIMKMIOLL(this BJBDBHCONPP PGDDBCEFICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62E8840", Offset = "0x62E7840", VA = "0x1862E8840")]
	public static NNOHEMIGJHE FHDPEAFDCNC(this BJBDBHCONPP PGDDBCEFICD, Guid HACFNNODNBE)
	{
		return default(NNOHEMIGJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62E87C0", Offset = "0x62E77C0", VA = "0x1862E87C0")]
	public static int FGGNPJKJFCD(this BJBDBHCONPP PGDDBCEFICD, NNOHEMIGJHE MKHICOMBDAH)
	{
		return default(int);
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
