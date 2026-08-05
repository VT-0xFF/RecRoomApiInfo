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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73010F0", Offset = "0x73002F0", VA = "0x1873010F0", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7301180", Offset = "0x7300380", VA = "0x187301180", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ABJIKONKLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? IKKBOMFDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIACCBACIHI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HBIECPICGOM : ABJIKONKLGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string NDBIGALNOIK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string OONCFNOBEJN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly string HMMMFKBKFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private DEGDDAKEMCN IJKNLAOBLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int? PIIFJCNEFMF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? IKKBOMFDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	[UnityEngine.Scripting.Preserve]
	public HBIECPICGOM([GEFLINBOFNF(null)][NotNull] DEGDDAKEMCN HICAFNEDDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7300820", Offset = "0x72FFA20", VA = "0x187300820", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7300EC0", Offset = "0x73000C0", VA = "0x187300EC0")]
	[NPIOOMADHDK.ICBCOBDLNNE.HFJMLJLJJPC]
	[UsedImplicitly]
	public static void PIAPCNGMBFA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7300720", Offset = "0x72FF920", VA = "0x187300720", Slot = "5")]
	public void AIACCBACIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7300A00", Offset = "0x72FFC00", VA = "0x187300A00")]
	private void JLJLCBGMHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7300920", Offset = "0x72FFB20", VA = "0x187300920")]
	private bool HJHGFELEENN(string PCBDAGDEMPO, [Out] KPIDGIMPLBI GPJJDGFAGFA)
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
