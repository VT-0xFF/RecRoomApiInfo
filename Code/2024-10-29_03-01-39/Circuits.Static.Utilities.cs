using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OGPGPFHMJFP<TData> : DCDJFOHHJCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CKGGEHCOAJK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B11DE0", Offset = "0x4B10DE0", VA = "0x184B11DE0")]
	internal OGPGPFHMJFP(string ABHPFCOODAJ, [In] TData CONAFKKIHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKHEEIFLING
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2364440", Offset = "0x2363440", VA = "0x182364440")]
	public static OGPGPFHMJFP<MKHCENILMPB> EJLELCHFLID(string ABHPFCOODAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6380", Offset = "0x2DB5380", VA = "0x182DB6380")]
	public static OGPGPFHMJFP<TData> EJLELCHFLID<TData>(string ABHPFCOODAJ, [In] TData CONAFKKIHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MKLCBBKLEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30895B0", Offset = "0x30885B0", VA = "0x1830895B0")]
	public static OBFFLKDLIBJ<TOk, FGHJECBDJBN> IPJFJGNIEHF<TOk>([In] this OBFFLKDLIBJ<TOk, FGHJECBDJBN> GFJPFDOHONG, string ABHPFCOODAJ)
	{
		return default(OBFFLKDLIBJ<TOk, FGHJECBDJBN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DCDJFOHHJCP : PPOILIOPEKP, FGHJECBDJBN, HJOFKELFHOB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2325610", Offset = "0x2324610", VA = "0x182325610")]
	protected DCDJFOHHJCP()
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
