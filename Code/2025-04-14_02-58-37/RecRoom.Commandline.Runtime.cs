using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7828E40", Offset = "0x7827840", VA = "0x187828E40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFIGKFLMNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HMOALFDIKAB(string FMDFMHFHDKP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KEBEMLDFCPH(string FMDFMHFHDKP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JBPFOEEPANJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class NJADCKDOLGM : EFIGKFLMNFA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> OBDBJKOIIIC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] KIEDHLCDBJM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] CMEPABAFMBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] LCPLJILKKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78288D0", Offset = "0x78272D0", VA = "0x1878288D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OOFNILLMPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7828AE0", Offset = "0x78274E0", VA = "0x187828AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78287E0", Offset = "0x78271E0", VA = "0x1878287E0")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void DKLGFMPPBPK(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7828C80", Offset = "0x7827680", VA = "0x187828C80")]
	internal static string[] PCHIBJEPJCO(string[] AKDANCLJFAG, string[] LEJIIOBLNBJ, List<string> IGCLDNBDOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7828990", Offset = "0x7827390", VA = "0x187828990", Slot = "4")]
	private string JNECDEHPLOB(string FMDFMHFHDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78288E0", Offset = "0x78272E0", VA = "0x1878288E0")]
	public static string HMOALFDIKAB(string FMDFMHFHDKP, [Optional] string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7828DA0", Offset = "0x78277A0", VA = "0x187828DA0", Slot = "5")]
	private bool PHELOJBBDDL(string FMDFMHFHDKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7828A40", Offset = "0x7827440", VA = "0x187828A40")]
	public static bool KEBEMLDFCPH(string FMDFMHFHDKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NJADCKDOLGM()
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
