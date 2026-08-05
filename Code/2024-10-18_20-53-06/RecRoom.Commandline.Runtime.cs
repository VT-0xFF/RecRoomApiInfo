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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CFDB60", Offset = "0x6CFCF60", VA = "0x186CFDB60", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NMNLLAGOKPI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NBGOKMIGJCI(string MPHJCCJMKLK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BFOEDNDEAKE(string MPHJCCJMKLK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HLKCAPJKFLB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class DJCLCFCGCAM : NMNLLAGOKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CDPIONDGOPF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] IIOILMDHOPD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GNCMNKPMBEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] CKDPIOILKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6CFDA00", Offset = "0x6CFCE00", VA = "0x186CFDA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] EKKAKGPILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6CFD500", Offset = "0x6CFC900", VA = "0x186CFD500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD910", Offset = "0x6CFCD10", VA = "0x186CFD910")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void INBAICEHNJG(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD740", Offset = "0x6CFCB40", VA = "0x186CFD740")]
	internal static string[] EEKGCBJDBEJ(string[] MHCNPFPELKI, string[] EEHPEHCIIPE, List<string> AJNOCAMNLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD860", Offset = "0x6CFCC60", VA = "0x186CFD860", Slot = "4")]
	private string ELNNDLFCPBH(string MPHJCCJMKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDA10", Offset = "0x6CFCE10", VA = "0x186CFDA10")]
	public static string NBGOKMIGJCI(string MPHJCCJMKLK, [Optional] string BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDAC0", Offset = "0x6CFCEC0", VA = "0x186CFDAC0", Slot = "5")]
	private bool PDHHMGMGAPF(string MPHJCCJMKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD6A0", Offset = "0x6CFCAA0", VA = "0x186CFD6A0")]
	public static bool BFOEDNDEAKE(string MPHJCCJMKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public DJCLCFCGCAM()
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
