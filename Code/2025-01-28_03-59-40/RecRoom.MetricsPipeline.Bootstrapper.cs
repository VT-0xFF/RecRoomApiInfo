using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MetricsPipeline_Bootstrapper
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7286610", Offset = "0x7285810", VA = "0x187286610", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_MetricsPipeline_Bootstrapper
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7286840", Offset = "0x7285A40", VA = "0x187286840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class MetricsBootstrapper
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly KJMCEDJMPPA Logger;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72866A0", Offset = "0x72858A0", VA = "0x1872866A0")]
		[NAOGKPPNIGE.PBOHCEMILCE]
		public static void BindPipelines(JBPONICDCIO diContainer)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ODLABCMJMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ODLABCMJMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6597320", Offset = "0x6596520", VA = "0x186597320")]
	public static string DMCIDNLNHGD(byte[] MANFIKLMHPH, byte[] MKPCDIHBHGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
