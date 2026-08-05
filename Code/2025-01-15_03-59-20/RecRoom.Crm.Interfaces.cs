using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CAKLFIDBBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2B47A38AABC798", Offset = "0x0", VA = "0x2B47A50AABC798", Slot = "0")]
	void OCDGJHELDBO(string MMEOEIBNGPI, string IFPHGNGHMCO, bool ANKAOFIKABE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xACF52BE802B486C", Offset = "0x0", VA = "0xACF52C0002B486C", Slot = "1")]
	void MBAMPHLFOBP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B48BB802B486C", Offset = "0x0", VA = "0x2B48BD002B486C", Slot = "2")]
	void CGDNIFDACHG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B48BB8ACF52DC", Offset = "0x0", VA = "0x2B48BD0ACF52DC", Slot = "3")]
	void DPOHGJAJHPN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xACF52EA802B48C3", Offset = "0x0", VA = "0xACF52EC002B48C3", Slot = "4")]
	void LOBNLKDJCDK(string EOJIEKDCDLB, [Optional] string JPKMOHGOIPL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFMJAOBCLEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ELMOCMDBKDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OFKOGMEFDGP IKEBINBIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B4912802B48C3", Offset = "0x0", VA = "0x2B4914002B48C3", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IEGPODMOAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B491E8ACF52DC", Offset = "0x0", VA = "0x2B49200ACF52DC", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GIJFKKAFMDH> PHOOADOPIBA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B49FE8ACF6CE0", Offset = "0x0", VA = "0x2B4A000ACF6CE0", Slot = "4")]
	Task OOJJEJPOBFE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xACF6CFA802B4A51", Offset = "0x0", VA = "0xACF6CFC002B4A51", Slot = "5")]
	void CALNFFOLFJH();
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
