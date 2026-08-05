using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IHGGHAKDLCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GEMEPDOIBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OKIGMKJIOHJ<Texture2D> DCMFODIHEAA(NativeArray<byte> EPMJGFJHIHC, bool LAEKCMGEODA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HPLKNIMNNAD : IHGGHAKDLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GEMEPDOIBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A3900", Offset = "0x60A2300", VA = "0x1860A3900")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void COABAOIMNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	[Preserve]
	public HPLKNIMNNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A3A00", Offset = "0x60A2400", VA = "0x1860A3A00", Slot = "5")]
	public global::OKIGMKJIOHJ<Texture2D> DCMFODIHEAA(NativeArray<byte> EPMJGFJHIHC, bool LAEKCMGEODA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "6")]
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
