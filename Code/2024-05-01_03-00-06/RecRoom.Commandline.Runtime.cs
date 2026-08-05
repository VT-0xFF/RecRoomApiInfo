using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EDMGNAABAHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GNMEIIEEBNG(string NLGJAGOIBCG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPKCKLAKAPC(string NLGJAGOIBCG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GNEPIBFDEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class MLMLABBLLJM : EDMGNAABAHL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JIDCHMACFJE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] FDIHJMCCAKL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GIBKEIADPJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] MBBFEHJMNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x615B5F0", Offset = "0x615A3F0", VA = "0x18615B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] FDOBKAPCJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x615B790", Offset = "0x615A590", VA = "0x18615B790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x615B6A0", Offset = "0x615A4A0", VA = "0x18615B6A0")]
	[DPHBJKOLDBD(FMOBJKPMAGC.Root, OHNOEEJKPCM.GameOnly)]
	private static void LLBAHKJCIHJ(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x615B390", Offset = "0x615A190", VA = "0x18615B390")]
	internal static string[] FDNDELBKHKD(string[] ANFLDEFEBLL, string[] GPJIFHBKJEG, List<string> GAAELKFCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x615B4B0", Offset = "0x615A2B0", VA = "0x18615B4B0", Slot = "4")]
	private string GABGDCPALPJ(string NLGJAGOIBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x615B550", Offset = "0x615A350", VA = "0x18615B550")]
	public static string GNMEIIEEBNG(string NLGJAGOIBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x615B600", Offset = "0x615A400", VA = "0x18615B600", Slot = "5")]
	private bool JPILLJFGHMN(string NLGJAGOIBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x615B930", Offset = "0x615A730", VA = "0x18615B930")]
	public static bool PPKCKLAKAPC(string NLGJAGOIBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MLMLABBLLJM()
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
