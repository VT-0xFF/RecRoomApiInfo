using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Enum)]
public class OAHDDCMNLOA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string FAEBOBJOGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
	public OAHDDCMNLOA(string HJKJGPMCDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field)]
public class HANFMIBHHBA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HEAFCMINBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1462DC0", Offset = "0x14621C0", VA = "0x181462DC0")]
	public HANFMIBHHBA(string AGLCIEKHLEE, bool DHDAHDINNHM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EJPMHMLKGEF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string MIKEHGLOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string OJJGGLNGEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FCDIJKGBGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
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
