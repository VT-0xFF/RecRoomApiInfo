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
		[Cpp2IlInjected.Address(RVA = "0x7C64BB0", Offset = "0x7C635B0", VA = "0x187C64BB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AGOOMDFKBHO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FHIHAEODGFI(string IOFCDGOOFLO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MNIKEFJGJFB(string IOFCDGOOFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DILHEJOGFHH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class JLLHAJOAKDF : AGOOMDFKBHO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CAAPLDIPLJG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MBOJNDLGMAG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PNLHBLJHOBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] JGJGKEAHNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C64BA0", Offset = "0x7C635A0", VA = "0x187C64BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HEFKCPKOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C64600", Offset = "0x7C63000", VA = "0x187C64600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C647A0", Offset = "0x7C631A0", VA = "0x187C647A0")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C649E0", Offset = "0x7C633E0", VA = "0x187C649E0")]
	internal static string[] HLEGHICFLDC(string[] LNIHNBEDBAN, string[] ABIMDMNFNEE, List<string> JJNJAHOJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C64550", Offset = "0x7C62F50", VA = "0x187C64550", Slot = "4")]
	private string APDKPNPBNLE(string IOFCDGOOFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C64890", Offset = "0x7C63290", VA = "0x187C64890")]
	public static string FHIHAEODGFI(string IOFCDGOOFLO, [Optional] string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C64940", Offset = "0x7C63340", VA = "0x187C64940", Slot = "5")]
	private bool HGFKLFOLJHM(string IOFCDGOOFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C64B00", Offset = "0x7C63500", VA = "0x187C64B00")]
	public static bool MNIKEFJGJFB(string IOFCDGOOFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JLLHAJOAKDF()
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
