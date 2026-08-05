using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DKEGPFNDAPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BFGHJOJBFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EIGPEDODBMN<Texture2D> GHDHIABCCJJ(NativeArray<byte> DAKFGGFELNI, bool LEJODKAHMEL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BLOHNFMGAMC : DKEGPFNDAPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BFGHJOJBFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FB50", Offset = "0x5E9EB50", VA = "0x185E9FB50")]
	[IMCONJMNGLO(KJBNBKOGAAL.None)]
	private static void OHLOIMPCKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	[Preserve]
	public BLOHNFMGAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FB00", Offset = "0x5E9EB00", VA = "0x185E9FB00", Slot = "5")]
	public global::EIGPEDODBMN<Texture2D> GHDHIABCCJJ(NativeArray<byte> DAKFGGFELNI, bool LEJODKAHMEL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "6")]
	public void Dispose()
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
