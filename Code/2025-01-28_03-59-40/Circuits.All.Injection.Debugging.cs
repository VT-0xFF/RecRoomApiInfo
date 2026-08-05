using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KGBLNOEBEAN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FFPFGJBGJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EJJCGEPDLHL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FFPFGJBGJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24B8460", Offset = "0x24B7660", VA = "0x1824B8460")]
		internal bool HKPHKJFEKJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24B8300", Offset = "0x24B7500", VA = "0x1824B8300")]
		internal void CMNJNPPLHOA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24B8610", Offset = "0x24B7810", VA = "0x1824B8610")]
		internal bool OEACDDBBHAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24B84B0", Offset = "0x24B76B0", VA = "0x1824B84B0")]
		internal void MBHKJOPHJIF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24B8560", Offset = "0x24B7760", VA = "0x1824B8560")]
		internal bool NGDAOJOGDPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24B83B0", Offset = "0x24B75B0", VA = "0x1824B83B0")]
		internal void GBHBFMFOLBL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ANBCNPJBLPK CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24B86C0", Offset = "0x24B78C0", VA = "0x1824B86C0")]
	private static JLKKPODDDIL GFJIKJFNICJ(EJJCGEPDLHL KBFPLDFMKJP)
	{
		return default(JLKKPODDDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24B89F0", Offset = "0x24B7BF0", VA = "0x1824B89F0")]
	private static ANBCNPJBLPK NINJGCCHCAK()
	{
		return default(ANBCNPJBLPK);
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
