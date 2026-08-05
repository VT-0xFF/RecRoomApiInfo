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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7472A70", Offset = "0x7471E70", VA = "0x187472A70", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74734D0", Offset = "0x74728D0", VA = "0x1874734D0", Slot = "8")]
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
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JAPDHLNBLIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? LPIMBOKMFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGBCAAJJJIK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ODELCPMLPHE : JAPDHLNBLIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string AHFAFFIJHLG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string OMJOIIBPFAB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly string FCDOCJEGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private GCDLIECIJNL GIOMMIBBKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int? FEEMCGOJPEA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? LPIMBOKMFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	[UnityEngine.Scripting.Preserve]
	public ODELCPMLPHE([CCLHMIDBCEM(null)][NotNull] GCDLIECIJNL LKEOMLAGJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7472B00", Offset = "0x7471F00", VA = "0x187472B00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74732A0", Offset = "0x74726A0", VA = "0x1874732A0")]
	[OAJAKDHKADM.AEINFAPCLKL.DIAOGFPHJAA]
	[UsedImplicitly]
	public static void OMNIGNNLKEG(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74731A0", Offset = "0x74725A0", VA = "0x1874731A0", Slot = "5")]
	public void IGBCAAJJJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7472C00", Offset = "0x7472000", VA = "0x187472C00")]
	private void IBDMPFKODMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74730C0", Offset = "0x74724C0", VA = "0x1874730C0")]
	private bool IBPFKKMPPGK(string KEBJGMHPIHI, [Out] FHDLHAMFPEO BEDJGNLENHH)
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
