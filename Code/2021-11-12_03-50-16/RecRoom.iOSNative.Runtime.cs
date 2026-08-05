using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INJNDDMPKMM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum JAKEKCGBBAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		SwitchBetweenCurrentToolAndEraser,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SwitchBetweenCurrentToolAndLastUsed,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ShowColorPalette
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum ABDBINDDBMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool OAFCMGGOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void EBLDNECDEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40")]
	public static bool OENGCAEBPCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D86470", Offset = "0x3D85670", VA = "0x183D86470")]
	public static bool FHBHCDBCFJK(Action<double> NEECAFENDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x451960", Offset = "0x450B60", VA = "0x180451960")]
	public static JAKEKCGBBAO DNDDFIOIHDC()
	{
		return default(JAKEKCGBBAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x568A80", Offset = "0x567C80", VA = "0x180568A80")]
	public static int FDFIOOILPJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1031810", Offset = "0x1030A10", VA = "0x181031810")]
	public static int BIIKHEELLKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1031810", Offset = "0x1030A10", VA = "0x181031810")]
	public static int HBKLNFGGLLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void MGEKMONKCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void IJOLMEFPKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void KLHDLCMJMEA(bool NNOCJKLLEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void HNDDECNNFKK(ABDBINDDBMH OHMJJBDBJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public static void LNJHDHJHOEA(bool CPALNLADACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x102F9A0", Offset = "0x102EBA0", VA = "0x18102F9A0")]
	public static float PJNLHMBHBMM()
	{
		return default(float);
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
