using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class POLLHGKAHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class JPEHDBMENKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public ACPBANEOEIP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JPEHDBMENKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x263E220", Offset = "0x263CC20", VA = "0x18263E220")]
		internal bool JKMDPIJEFMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x263E270", Offset = "0x263CC70", VA = "0x18263E270")]
		internal void KELOOPDPKNN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x263E170", Offset = "0x263CB70", VA = "0x18263E170")]
		internal bool JCLEANLINLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x263E320", Offset = "0x263CD20", VA = "0x18263E320")]
		internal void PFLNHBKIAGE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x263E010", Offset = "0x263CA10", VA = "0x18263E010")]
		internal bool ABGBJMHPHPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x263E0C0", Offset = "0x263CAC0", VA = "0x18263E0C0")]
		internal void HAIEJKMBGHP(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BFDAMFFBOEP LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x263EC90", Offset = "0x263D690", VA = "0x18263EC90")]
	private static EPPLEODGPIB FAHGBPKMJCA(ACPBANEOEIP GMEDEMELDAA)
	{
		return default(EPPLEODGPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x263E3D0", Offset = "0x263CDD0", VA = "0x18263E3D0")]
	private static BFDAMFFBOEP AGFJBPDFJOG()
	{
		return default(BFDAMFFBOEP);
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
