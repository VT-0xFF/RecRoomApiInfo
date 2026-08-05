using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GABCFCMPFNP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class JHHAIGOFDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OCPAIIEJKGM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JHHAIGOFDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22C2860", Offset = "0x22C1060", VA = "0x1822C2860")]
		internal bool MOJNMAHFDPJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22C2700", Offset = "0x22C0F00", VA = "0x1822C2700")]
		internal void KLMMLDIBIDF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22C28B0", Offset = "0x22C10B0", VA = "0x1822C28B0")]
		internal bool OCOLCDGMKNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22C27B0", Offset = "0x22C0FB0", VA = "0x1822C27B0")]
		internal void LKAKHJCGEMJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22C2960", Offset = "0x22C1160", VA = "0x1822C2960")]
		internal bool OJJBNDEBFOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22C2650", Offset = "0x22C0E50", VA = "0x1822C2650")]
		internal void EOBIDIGAJCC(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CGHKELIOAKN ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22C21C0", Offset = "0x22C09C0", VA = "0x1822C21C0")]
	private static DHCDPFIGGBN MDAFKDAPGGH(OCPAIIEJKGM HBENNMPFAIF)
	{
		return default(DHCDPFIGGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22C18C0", Offset = "0x22C00C0", VA = "0x1822C18C0")]
	private static CGHKELIOAKN HIDGDLMKHHI()
	{
		return default(CGHKELIOAKN);
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
