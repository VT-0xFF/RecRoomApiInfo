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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7482C80", Offset = "0x7482080", VA = "0x187482C80", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74836F0", Offset = "0x7482AF0", VA = "0x1874836F0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JAFJBLIIAHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? NDPNFGFJBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NONIHMEEOPP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PEKBKHGPDPB : JAFJBLIIAHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string GOCMHAJJEPP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string EEIKDCPDEKN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly string IEPCKGMCJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ENFDNHEGPKN ECOLIEHDPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int? EFFGIAAFFCJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? NDPNFGFJBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	[UnityEngine.Scripting.Preserve]
	public PEKBKHGPDPB([ACGOIOBGIEE(null)][NotNull] ENFDNHEGPKN OPPHLCMFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7482D10", Offset = "0x7482110", VA = "0x187482D10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7482EF0", Offset = "0x74822F0", VA = "0x187482EF0")]
	[FHFMOACGLML.LJNENKAOIID.CBBLLNOFCJC]
	[UsedImplicitly]
	public static void NMEAIKFKCJD(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7482FF0", Offset = "0x74823F0", VA = "0x187482FF0", Slot = "5")]
	public void NONIHMEEOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74830F0", Offset = "0x74824F0", VA = "0x1874830F0")]
	private void PEFHDNMPDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7482E10", Offset = "0x7482210", VA = "0x187482E10")]
	private bool GEINPBFNLLJ(string LIADINFKMPO, [Out] HBDKIMKHBOJ NBOCFLDELGK)
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
