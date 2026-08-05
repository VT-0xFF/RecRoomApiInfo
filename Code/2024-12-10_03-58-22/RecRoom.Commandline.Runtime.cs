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
		[Cpp2IlInjected.Address(RVA = "0x6B742E0", Offset = "0x6B72EE0", VA = "0x186B742E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BABFIPKBBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FLHNDOEBNNJ(string KFNONDACKPN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OIHCLHGJLPA(string KFNONDACKPN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OEJGMBOEMFE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class NCINDFBDHMH : BABFIPKBBAH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DNGJLBFACHG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OGJOFLBPHLE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] FPHHDHHFDIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] BPPIFIGJIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B74230", Offset = "0x6B72E30", VA = "0x186B74230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IAMENJLEHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B73EF0", Offset = "0x6B72AF0", VA = "0x186B73EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B74090", Offset = "0x6B72C90", VA = "0x186B74090")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void JDLGENCKOOG(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B73D20", Offset = "0x6B72920", VA = "0x186B73D20")]
	internal static string[] DIBNNIOCHCM(string[] EGGKJNJLGOE, string[] PCPOGPNAKFJ, List<string> AFAGMOHMGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B73C70", Offset = "0x6B72870", VA = "0x186B73C70", Slot = "4")]
	private string AIOCACJAJGP(string KFNONDACKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B73E40", Offset = "0x6B72A40", VA = "0x186B73E40")]
	public static string FLHNDOEBNNJ(string KFNONDACKPN, [Optional] string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B74190", Offset = "0x6B72D90", VA = "0x186B74190", Slot = "5")]
	private bool LPEINDBNJBN(string KFNONDACKPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B74240", Offset = "0x6B72E40", VA = "0x186B74240")]
	public static bool OIHCLHGJLPA(string KFNONDACKPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public NCINDFBDHMH()
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
