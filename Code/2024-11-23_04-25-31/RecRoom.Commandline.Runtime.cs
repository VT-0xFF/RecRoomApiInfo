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
		[Cpp2IlInjected.Address(RVA = "0x6D20BA0", Offset = "0x6D1F5A0", VA = "0x186D20BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KBMLGIOLFHK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FENCKMFGEFD(string BLBINOCFPJK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHNJNLGKADI(string BLBINOCFPJK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NDEDEDODBPM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class IONIAGFDCFD : KBMLGIOLFHK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DIKBOKHMOHI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] JEMMFHGNKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HFABDGBFGDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] KKLIFDNILOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D20830", Offset = "0x6D1F230", VA = "0x186D20830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] AHBMAADLJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D20960", Offset = "0x6D1F360", VA = "0x186D20960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D205D0", Offset = "0x6D1EFD0", VA = "0x186D205D0")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void EHEFGOAOAHF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D20840", Offset = "0x6D1F240", VA = "0x186D20840")]
	internal static string[] JJEAPFBAKAK(string[] PLAMOEIGHEM, string[] JMALICPGKJD, List<string> IEPHCDBCOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D206D0", Offset = "0x6D1F0D0", VA = "0x186D206D0", Slot = "4")]
	private string FDDMHHBAIPF(string BLBINOCFPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D20780", Offset = "0x6D1F180", VA = "0x186D20780")]
	public static string FENCKMFGEFD(string BLBINOCFPJK, [Optional] string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D20530", Offset = "0x6D1EF30", VA = "0x186D20530", Slot = "5")]
	private bool EFEIKOGBPBD(string BLBINOCFPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D20B00", Offset = "0x6D1F500", VA = "0x186D20B00")]
	public static bool MHNJNLGKADI(string BLBINOCFPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IONIAGFDCFD()
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
