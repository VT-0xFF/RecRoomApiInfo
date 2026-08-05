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
		[Cpp2IlInjected.Address(RVA = "0x7A1A3C0", Offset = "0x7A197C0", VA = "0x187A1A3C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNNHDDKNOCP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ENPHPGLMBPN(string PBDLCAKDPOA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCKPKFFCDJO(string PBDLCAKDPOA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PKBAKEHFKDL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class EMLGEMNBHGA : MNNHDDKNOCP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FEOKEDFIKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DEANJCKKDFA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] FOPBCNKHOIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] AADEIMCDGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A060", Offset = "0x7A19460", VA = "0x187A1A060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OHENINPCKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A070", Offset = "0x7A19470", VA = "0x187A1A070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A220", Offset = "0x7A19620", VA = "0x187A1A220")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void OFPJHOBLCJH(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A19E90", Offset = "0x7A19290", VA = "0x187A19E90")]
	internal static string[] IHNABILENPM(string[] OJFCBJIFEMD, string[] IDKDFNCECIE, List<string> ADGDFJAKGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A19FB0", Offset = "0x7A193B0", VA = "0x187A19FB0", Slot = "4")]
	private string IJBKOFEBHEM(string PBDLCAKDPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A19DE0", Offset = "0x7A191E0", VA = "0x187A19DE0")]
	public static string ENPHPGLMBPN(string PBDLCAKDPOA, [Optional] string JMBBJHIBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A19D40", Offset = "0x7A19140", VA = "0x187A19D40", Slot = "5")]
	private bool BAGCNPNGCKK(string PBDLCAKDPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A320", Offset = "0x7A19720", VA = "0x187A1A320")]
	public static bool PCKPKFFCDJO(string PBDLCAKDPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public EMLGEMNBHGA()
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
