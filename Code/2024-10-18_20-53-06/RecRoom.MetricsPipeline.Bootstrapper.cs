using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MetricsPipeline_Bootstrapper
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E37C00", Offset = "0x6E37000", VA = "0x186E37C00", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E37E30", Offset = "0x6E37230", VA = "0x186E37E30", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
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
		private static readonly FLILHMOBPPM Logger;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E37C90", Offset = "0x6E37090", VA = "0x186E37C90")]
		[OAJAKDHKADM.LHNCMMKCKFL]
		public static void BindPipelines(LBNNADLFMIK diContainer)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JHDCDGCMADC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JHDCDGCMADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61BCC70", Offset = "0x61BC070", VA = "0x1861BCC70")]
	public static string LDJGKBPFLPI(byte[] AJPJBGAKCNB, byte[] ODLHKDJMEOI)
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
