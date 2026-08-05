using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NBFBGBDKKBG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FAOMOOADJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LBFCEGHGHAH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FAOMOOADJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B260", Offset = "0x6F7A660", VA = "0x186F7B260")]
		internal bool BDIBGGKMGIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B2C0", Offset = "0x6F7A6C0", VA = "0x186F7B2C0")]
		internal void FEEPDEBMAEL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B190", Offset = "0x6F7A590", VA = "0x186F7B190")]
		internal bool ANGPJJPBPCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B370", Offset = "0x6F7A770", VA = "0x186F7B370")]
		internal void LMKMAMIOKPI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B420", Offset = "0x6F7A820", VA = "0x186F7B420")]
		internal bool MDENACFJPFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B4F0", Offset = "0x6F7A8F0", VA = "0x186F7B4F0")]
		internal void OJBHBIBPCBA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly HMLIJFGHLEC HLFGGJBLCBK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE50", Offset = "0x6F7B250", VA = "0x186F7BE50")]
	private static CJHEBKAPNKM NBJMPFFPHID(LBFCEGHGHAH MPCBCNKKGEJ)
	{
		return default(CJHEBKAPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B5A0", Offset = "0x6F7A9A0", VA = "0x186F7B5A0")]
	private static HMLIJFGHLEC JGMOILFCHEG()
	{
		return default(HMLIJFGHLEC);
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
