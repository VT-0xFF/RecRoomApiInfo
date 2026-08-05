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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7544870", Offset = "0x7543870", VA = "0x187544870", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7544900", Offset = "0x7543900", VA = "0x187544900", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MMOOGOFFCNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? IPAGKGBFPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKPKDMCDHFL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KMOOLJIEOHN : MMOOGOFFCNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string IEBKCDFLBFO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string NMGLPHGKMCG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly string GGLBGPODAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NIFDEMPMOFN BBHLLFNPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int? MFMJOABOAEO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? IPAGKGBFPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	[UnityEngine.Scripting.Preserve]
	public KMOOLJIEOHN([GAHPILLNNBL(null)][NotNull] NIFDEMPMOFN AKBOKMCLEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7543F90", Offset = "0x7542F90", VA = "0x187543F90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7544090", Offset = "0x7543090", VA = "0x187544090")]
	[AEDCCIMPEFD.AFLCBBLFINA.JIBIFIAGKAD]
	[UsedImplicitly]
	public static void GKMHHENJLEC(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7543E90", Offset = "0x7542E90", VA = "0x187543E90", Slot = "5")]
	public void AKPKDMCDHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7544270", Offset = "0x7543270", VA = "0x187544270")]
	private void JALBNJAEGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7544190", Offset = "0x7543190", VA = "0x187544190")]
	private bool IADPMMLGECA(string MPNDJDOFJJI, [Out] BPPCCOJCCBL IFFHAGBHNPG)
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
