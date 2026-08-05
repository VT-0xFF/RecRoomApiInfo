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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7219080", Offset = "0x7217A80", VA = "0x187219080", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7219110", Offset = "0x7217B10", VA = "0x187219110", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CNGDHBIKKGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? DIEOFDKMKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHDHBGOJACD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JKAEMEOJGNH : CNGDHBIKKGN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string AFJDNMDIBIF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string KLHMBOPAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DGMMCJOACNP DFDDCJILNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int? IOGBLDLHDAP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? DIEOFDKMKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	[UnityEngine.Scripting.Preserve]
	public JKAEMEOJGNH([LKKACOOMNBP(null)][NotNull] DGMMCJOACNP DAHEHAAEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7218D80", Offset = "0x7217780", VA = "0x187218D80")]
	[MDINNNLEANF.KEEBDGCHOPC.PPGDDFHJFHO]
	[UsedImplicitly]
	public static void KBFBKJIPGJI(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7218E80", Offset = "0x7217880", VA = "0x187218E80", Slot = "5")]
	public void LHDHBGOJACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72189E0", Offset = "0x72173E0", VA = "0x1872189E0")]
	private void EHNCKKEMPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7218900", Offset = "0x7217300", VA = "0x187218900")]
	private bool EGIEABAJLMG(string IFAKLLPNKID, [Out] DJNLDFPFJHM PIFFAAIBNEO)
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
