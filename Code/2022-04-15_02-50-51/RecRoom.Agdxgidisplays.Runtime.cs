using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IPOEEMNEPDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PIDILCOALHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NHOFGKIKHAC(IntPtr PAHHEBOMPLG, int NEPCFDJCABD, int NJMHLGHHGKJ);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BGGCNMCDKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7420", Offset = "0x1AC6220", VA = "0x181AC7420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7A80", Offset = "0x1AC6880", VA = "0x181AC7A80")]
	private static extern void OGMDNFKNBJN(NHOFGKIKHAC NIBAGIPBILN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7500", Offset = "0x1AC6300", VA = "0x181AC7500")]
	[MonoPInvokeCallback(typeof(NHOFGKIKHAC))]
	private static void EGFKOOIBLGA(IntPtr PAHHEBOMPLG, int NEPCFDJCABD, int NJMHLGHHGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7A10", Offset = "0x1AC6810", VA = "0x181AC7A10")]
	private static extern void OGICEOHIGPL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7490", Offset = "0x1AC6290", VA = "0x181AC7490")]
	private static extern void EIMNEJCCJKK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7420", Offset = "0x1AC6220", VA = "0x181AC7420")]
	private static extern int IJICCBDHOAF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7910", Offset = "0x1AC6710", VA = "0x181AC7910")]
	private static extern int NCCFJGGLIBJ(int AACOJDLCGDD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7990", Offset = "0x1AC6790", VA = "0x181AC7990")]
	private static extern int NIJMGPJNECG(int AACOJDLCGDD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7890", Offset = "0x1AC6690", VA = "0x181AC7890")]
	private static extern int LOKDIGPMJDC(int AACOJDLCGDD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7810", Offset = "0x1AC6610", VA = "0x181AC7810")]
	private static extern int LANBKKAGMDO(int AACOJDLCGDD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7B10", Offset = "0x1AC6910", VA = "0x181AC7B10")]
	public IPOEEMNEPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7490", Offset = "0x1AC6290", VA = "0x181AC7490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1AC7620", Offset = "0x1AC6420", VA = "0x181AC7620")]
	public Rect IIODMPJIHJG(int BMNFIDIIFGG)
	{
		return default(Rect);
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
