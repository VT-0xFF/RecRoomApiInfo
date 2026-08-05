using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73F95D0", Offset = "0x73F89D0", VA = "0x1873F95D0", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73FA040", Offset = "0x73F9440", VA = "0x1873FA040", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GBEIDFJGEKF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? NPGNMGPENCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDKLEHKIIAF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PPGBICFIODH : GBEIDFJGEKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string GIOBPACCIMA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string DNANKEDLDLG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly string LBFGFCCPEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private KOFDFCJMCJL AOMFJFJFKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int? DDGEDNAJAPO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? NPGNMGPENCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	[UnityEngine.Scripting.Preserve]
	public PPGBICFIODH([NDMEANGLJKD(null)][NotNull] KOFDFCJMCJL JDHBFLHENJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73F9660", Offset = "0x73F8A60", VA = "0x1873F9660", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73F9E00", Offset = "0x73F9200", VA = "0x1873F9E00")]
	[GOEIKLHOLGG.IBEFHGHGJKH.OGEIPBLEMDG]
	[UsedImplicitly]
	public static void KOPJDJKMNMG(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73F9760", Offset = "0x73F8B60", VA = "0x1873F9760", Slot = "5")]
	public void FDKLEHKIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73F9940", Offset = "0x73F8D40", VA = "0x1873F9940")]
	private void IENDEABNHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73F9860", Offset = "0x73F8C60", VA = "0x1873F9860")]
	private bool HOEGAHMODNI(string DFGPGGDCCCM, [Out] NPKPIDLHIHG KFOEKLFHELF)
	{
		return default(bool);
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
