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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71E9590", Offset = "0x71E7B90", VA = "0x1871E9590", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71E9620", Offset = "0x71E7C20", VA = "0x1871E9620", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface POHPAPHEFGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? GPAJIHAAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMPFHJOHDJG();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ICPKMHLMEHB : POHPAPHEFGN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string OEBDMBGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string HHIKALOBMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CDCHCDMFJJO FLINMIGDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int? HHMHACDGPEP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? GPAJIHAAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	[UnityEngine.Scripting.Preserve]
	public ICPKMHLMEHB([OLJNBPOCBCJ(null)][NotNull] CDCHCDMFJJO KKMFJEOBINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71E8E10", Offset = "0x71E7410", VA = "0x1871E8E10")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	[UsedImplicitly]
	public static void BMMBAEMGMDH(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71E9390", Offset = "0x71E7990", VA = "0x1871E9390", Slot = "5")]
	public void OMPFHJOHDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71E8FF0", Offset = "0x71E75F0", VA = "0x1871E8FF0")]
	private void NBFFDJHAIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71E8F10", Offset = "0x71E7510", VA = "0x1871E8F10")]
	private bool EPBCFPJCHGN(string JJLAHGFLMCP, [Out] AKIEELGBHCO OELJECLHOHH)
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
