using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C77070", Offset = "0x6C76470", VA = "0x186C77070", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKAKJHHACGG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PAIFONKBNNO(string PKIPCCDIHFG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLOECOEGFBC(string PKIPCCDIHFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FLOAEBKDPPO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class LEIALHINAIC : IKAKJHHACGG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FECBHNLGNBK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DHPAAPAMPLP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HCJKONELCLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IDLPNNAHCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C76E00", Offset = "0x6C76200", VA = "0x186C76E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] MEIGKGLIMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C76E10", Offset = "0x6C76210", VA = "0x186C76E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C76C60", Offset = "0x6C76060", VA = "0x186C76C60")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void LHFLNIJFEKK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C76AA0", Offset = "0x6C75EA0", VA = "0x186C76AA0")]
	internal static string[] HEDKCHBNBIG(string[] HIOHBEMIDIK, string[] HDBCAOPFPLF, List<string> CAODLELAGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C76D50", Offset = "0x6C76150", VA = "0x186C76D50", Slot = "4")]
	private string LHHMAPIGNKH(string PKIPCCDIHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C76FC0", Offset = "0x6C763C0", VA = "0x186C76FC0")]
	public static string PAIFONKBNNO(string PKIPCCDIHFG, [Optional] string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76A00", Offset = "0x6C75E00", VA = "0x186C76A00", Slot = "5")]
	private bool BGHMELIGEKK(string PKIPCCDIHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C76BC0", Offset = "0x6C75FC0", VA = "0x186C76BC0")]
	public static bool JLOECOEGFBC(string PKIPCCDIHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LEIALHINAIC()
	{
	}
}
namespace Cpp2IlInjected
{
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
}
