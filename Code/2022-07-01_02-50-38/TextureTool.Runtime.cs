using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MNGCMFLBMOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CGBFKJAMLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::KCBGCCPGMNM<Texture2D> HBGKKJLEFOF(NativeArray<byte> FIAGLANGAEF, bool MNOIKLHGDDH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KEHBDOLEPEN : MNGCMFLBMOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CGBFKJAMLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x12558E0", Offset = "0x12540E0", VA = "0x1812558E0")]
	[FNEIJLJADIG]
	private static void DFMMHLILBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	[Preserve]
	public KEHBDOLEPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1255A40", Offset = "0x1254240", VA = "0x181255A40", Slot = "5")]
	public global::KCBGCCPGMNM<Texture2D> HBGKKJLEFOF(NativeArray<byte> FIAGLANGAEF, bool MNOIKLHGDDH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "6")]
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
