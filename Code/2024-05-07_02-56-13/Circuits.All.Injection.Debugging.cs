using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LPJLKMKCHPF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BOICDMMPOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OEGDLJADJON logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BOICDMMPOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E01BB0", Offset = "0x1E00DB0", VA = "0x181E01BB0")]
		internal bool KHBKMMBCMBK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E01A50", Offset = "0x1E00C50", VA = "0x181E01A50")]
		internal void BFPIKFNMEJC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E019A0", Offset = "0x1E00BA0", VA = "0x181E019A0")]
		internal bool AEIKNFIINMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E01C00", Offset = "0x1E00E00", VA = "0x181E01C00")]
		internal void MOPOAHAAFOA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E01B00", Offset = "0x1E00D00", VA = "0x181E01B00")]
		internal bool DKAKIBHMLLM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E01CB0", Offset = "0x1E00EB0", VA = "0x181E01CB0")]
		internal void OLHMBLJEGJO(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CMDOBBECLML KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E01D60", Offset = "0x1E00F60", VA = "0x181E01D60")]
	private static FCCNDHIDGCJ DCIDKCCCMFJ(OEGDLJADJON KENHJFPOOHH)
	{
		return default(FCCNDHIDGCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E02090", Offset = "0x1E01290", VA = "0x181E02090")]
	private static CMDOBBECLML LHEKNCAANCH()
	{
		return default(CMDOBBECLML);
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
