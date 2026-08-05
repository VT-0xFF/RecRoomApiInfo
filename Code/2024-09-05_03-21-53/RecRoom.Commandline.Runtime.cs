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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0670", Offset = "0x6ADF070", VA = "0x186AE0670", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EJJBBNEIKGB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LPPGEBDBLJL(string DCPDLABEFAK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEGAMPNDKEH(string DCPDLABEFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GDDCHBMOOJA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class OLFJPGDBCHK : EJJBBNEIKGB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> MGNCNIMLHGP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] ALCDIEGBHPK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LNPGEMGCNBG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] MCKHMJKILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0150", Offset = "0x6ADEB50", VA = "0x186AE0150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] BKGLBCEMAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0280", Offset = "0x6ADEC80", VA = "0x186AE0280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0420", Offset = "0x6ADEE20", VA = "0x186AE0420")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void JIHNHODNBNJ(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0160", Offset = "0x6ADEB60", VA = "0x186AE0160")]
	internal static string[] GLPGJKGMLAI(string[] NCIEHKAOPEL, string[] HMMEFDFJMGM, List<string> MDLACFOFMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AE00B0", Offset = "0x6ADEAB0", VA = "0x186AE00B0", Slot = "4")]
	private string BLNIDPICJBB(string DCPDLABEFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE05C0", Offset = "0x6ADEFC0", VA = "0x186AE05C0")]
	public static string LPPGEBDBLJL(string DCPDLABEFAK, [Optional] string PEMAOEALEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0010", Offset = "0x6ADEA10", VA = "0x186AE0010", Slot = "5")]
	private bool AEDBNIPLCJG(string DCPDLABEFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0520", Offset = "0x6ADEF20", VA = "0x186AE0520")]
	public static bool LEGAMPNDKEH(string DCPDLABEFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OLFJPGDBCHK()
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
