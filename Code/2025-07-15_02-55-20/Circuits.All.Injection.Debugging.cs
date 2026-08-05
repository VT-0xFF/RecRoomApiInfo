using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LOGFODIFIPF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PBCIGKPKELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DJNMDIOGPGN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PBCIGKPKELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2982BD0", Offset = "0x29817D0", VA = "0x182982BD0")]
		internal bool ELOOINFKFGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2982E30", Offset = "0x2981A30", VA = "0x182982E30")]
		internal void KBAJKKFPMGN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2982C20", Offset = "0x2981820", VA = "0x182982C20")]
		internal bool EPOEFLONNBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2982D80", Offset = "0x2981980", VA = "0x182982D80")]
		internal void GPFAIHDHPOA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2982CD0", Offset = "0x29818D0", VA = "0x182982CD0")]
		internal bool FPKPEJDGJAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2982B20", Offset = "0x2981720", VA = "0x182982B20")]
		internal void AGIMGJMJIMH(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ODKHEIJEINF MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2981D90", Offset = "0x2980990", VA = "0x182981D90")]
	private static IGBHOHAIHHI MNDEKLAOPPE(DJNMDIOGPGN DFILDCOEJEH)
	{
		return default(IGBHOHAIHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29820C0", Offset = "0x2980CC0", VA = "0x1829820C0")]
	private static ODKHEIJEINF OBLAJGPCKBE()
	{
		return default(ODKHEIJEINF);
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
