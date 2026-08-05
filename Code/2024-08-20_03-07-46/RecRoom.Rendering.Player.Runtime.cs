using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9BA0", Offset = "0x6FE8BA0", VA = "0x186FE9BA0", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KPOFAPKAEOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? MOCKCJDFKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJJPLPEIIJG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MJANFPHKGKP : KPOFAPKAEOM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string PNKJIEMKKFI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string CHABCJMHGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NLFAAHGJLCJ MLDLGAMHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int? JOCJOFOMPGI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? MOCKCJDFKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	[UnityEngine.Scripting.Preserve]
	public MJANFPHKGKP([JONIFKKOOAA(null)][NotNull] NLFAAHGJLCJ AALJIAIGOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA1B0", Offset = "0x6FE91B0", VA = "0x186FEA1B0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Session, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	public static void OKGIPNBFOLK(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0B0", Offset = "0x6FE90B0", VA = "0x186FEA0B0", Slot = "5")]
	public void MJJPLPEIIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9D10", Offset = "0x6FE8D10", VA = "0x186FE9D10")]
	private void IMCGHGAMGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C30", Offset = "0x6FE8C30", VA = "0x186FE9C30")]
	private bool FJLGFBOICPG(string NNHDAOIPFLF, [Out] ADPMCNIDIED KAJHLGCPECE)
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
