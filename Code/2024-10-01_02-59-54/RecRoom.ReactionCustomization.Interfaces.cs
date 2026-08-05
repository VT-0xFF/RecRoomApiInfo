using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBNMKIKPHEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJMANNDLDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA79D946802A3CC5", Offset = "0x0", VA = "0xA79D948002A3CC5", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LKILNMKOKHH EKEDGHJJIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D74802A3CC5", Offset = "0x0", VA = "0x2A3D76002A3CC5", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LKILNMKOKHH PIFKBGCJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D748A9AB330", Offset = "0x0", VA = "0x2A3D760A9AB330", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> BLKMEFCLAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB34A802A3DC7", Offset = "0x0", VA = "0xA9AB34C002A3DC7", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DCB802A3DC7", Offset = "0x0", VA = "0x2A3DCD002A3DC7", Slot = "4")]
	void BCCOMGGFOBO(List<(string, PEOJDONHEPO)> BFINFFPCGFI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DCB8A9AB35C", Offset = "0x0", VA = "0x2A3DCD0A9AB35C", Slot = "5")]
	string[] NKPNCEPIDLF(string IANADAFGAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB34A802A3E1E", Offset = "0x0", VA = "0xA9AB34C002A3E1E", Slot = "6")]
	bool AGCAGHJBGDG(string IANADAFGAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E43802A3E20", Offset = "0x0", VA = "0x2A3E45002A3E20", Slot = "7")]
	string HFGFDPBBIEF(string IANADAFGAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E438A945F20", Offset = "0x0", VA = "0x2A3E450A945F20", Slot = "8")]
	PEOJDONHEPO JKCPGNKFPCD(string IANADAFGAJJ);
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
