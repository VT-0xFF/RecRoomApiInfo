using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JFKBKJNNMNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCAOFJPKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OOEHIGLENDP<Texture2D> GFCBIGKJIHD(NativeArray<byte> KCGCNAOFHJA, bool MJBDKDGGBJE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IPFCKOGAIGB : JFKBKJNNMNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FCAOFJPKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A0E30", Offset = "0x609FA30", VA = "0x1860A0E30")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	private static void AKPBJPOJHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	[Preserve]
	public IPFCKOGAIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A0F30", Offset = "0x609FB30", VA = "0x1860A0F30", Slot = "5")]
	public global::OOEHIGLENDP<Texture2D> GFCBIGKJIHD(NativeArray<byte> KCGCNAOFHJA, bool MJBDKDGGBJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "6")]
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
