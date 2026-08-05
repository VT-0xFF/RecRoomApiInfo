using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AODEFOJGBIP<TActionKind, TSerializedAction>
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct MPFCPECOGND<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly global::NNOOEOIDHAJ<TActionKind, TSerializedAction, TRoot, TDeps> BIIDFALPOBC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal sealed class NNOOEOIDHAJ<TActionKind, TSerializedAction, TRoot, TDeps>
{
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
