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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4BB0", Offset = "0x6DD3BB0", VA = "0x186DD4BB0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KLHCKOBFHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KFHBMCMIAON(string NHMAPAIFDPB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LOIABPJJFHJ(string NHMAPAIFDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LKIAJKHJBPO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class ABGEIDCKJPN : KLHCKOBFHCD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> HBGMBIABKPA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DNGLJHCMLJO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HFIDKIAOGFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OLLJJAEHGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DD48A0", Offset = "0x6DD38A0", VA = "0x186DD48A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] LLHBFFECNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DD45E0", Offset = "0x6DD35E0", VA = "0x186DD45E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4AB0", Offset = "0x6DD3AB0", VA = "0x186DD4AB0")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void LPMGDCHBOCO(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4780", Offset = "0x6DD3780", VA = "0x186DD4780")]
	internal static string[] BFFLJDJPHHK(string[] BGIAHPFKGAO, string[] DPPOKAKLBGL, List<string> AFFJDBFFNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4960", Offset = "0x6DD3960", VA = "0x186DD4960", Slot = "4")]
	private string LMLJINIMCJE(string NHMAPAIFDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD48B0", Offset = "0x6DD38B0", VA = "0x186DD48B0")]
	public static string KFHBMCMIAON(string NHMAPAIFDPB, [Optional] string MJBMFFMBOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4540", Offset = "0x6DD3540", VA = "0x186DD4540", Slot = "5")]
	private bool ALDPMHJDENF(string NHMAPAIFDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4A10", Offset = "0x6DD3A10", VA = "0x186DD4A10")]
	public static bool LOIABPJJFHJ(string NHMAPAIFDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public ABGEIDCKJPN()
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
