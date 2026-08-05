using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x20A75B0", Offset = "0x20A5BB0", VA = "0x1820A75B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HPGOOACMEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MJGAEDNBJIL<IACHHKJGKFH> LFJFBBCHMNC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20A7580", Offset = "0x20A5B80", VA = "0x1820A7580")]
	public static HPGOOACMEGN GGBAHLJJLHO()
	{
		return default(HPGOOACMEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20A7550", Offset = "0x20A5B50", VA = "0x1820A7550")]
	[CompilerGenerated]
	internal static MJGAEDNBJIL<IACHHKJGKFH> FFHDDIPBLBJ(int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<IACHHKJGKFH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CIFGKNDMJFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HOIJMMLOCGF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GNIDPFJIBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ICKMFPIDABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float CCAEMOFHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float KKJCFFLENPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KIPIIDGHGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OPPDKDMEDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KBIDCNBADDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetMaxAmmo(GCFHMFIENNC FKDHFMCKMKA, int EMFANHEMBJM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetCurrentAmmo(GCFHMFIENNC FKDHFMCKMKA, int FCOMLCEDOAO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetADSEnabled(GCFHMFIENNC FKDHFMCKMKA, bool GCKGFMHINMG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetCanReload(GCFHMFIENNC FKDHFMCKMKA, bool KJDAJPDGLOE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetContinuousFire(GCFHMFIENNC FKDHFMCKMKA, bool ICMJAHJBPLJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetRateOfFire(GCFHMFIENNC FKDHFMCKMKA, float CAMBGODMJED);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PAOMBAGNFAO<BLGMJKLPHOM> CV2SetReloadDuration(GCFHMFIENNC FKDHFMCKMKA, float IMAGIDBPDMM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JBILKHKFLCB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string NPEMLIALMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PAOMBAGNFAO<BLGMJKLPHOM> SetHandleControlLabel(GCFHMFIENNC FKDHFMCKMKA, string MANKBKONOGI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DKAJGBEBNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(CIFGKNDMJFB, CIFGKNDMJFB, CIFGKNDMJFB, CIFGKNDMJFB, CIFGKNDMJFB) GJIADKLMPPH(object JDDNDMPDAKN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object BPMICPDKIGD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OGCLLAHCFGD(object JDDNDMPDAKN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string MDLPOLGBHOH(object JDDNDMPDAKN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LADDEBDKNNN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KGIOFFLPLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KJFAJABCPMF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKNBGAPNIGA ENCDCFGJHLA(int DCOBFDGAPAO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IHFEGPOCLBF([In] OKNBGAPNIGA GLBALKEIIJP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIMMADGDJOE
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAOMBAGNFAO<BLGMJKLPHOM> SetEnabled(GCFHMFIENNC FKDHFMCKMKA, bool IJMMIMMNFDD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct OAKAMOKNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ENEKCMGGEMN ACOLJILGEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KJFAJABCPMF DICGIKMLIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly DKAJGBEBNLP FBFONFNPBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly HPGOOACMEGN NPLFFOEJMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly IHGGHCJHDFO CKCMLAMGOBK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x20A7630", Offset = "0x20A5C30", VA = "0x1820A7630")]
	public OAKAMOKNCMB(ENEKCMGGEMN AAMELIDLCIB, KJFAJABCPMF APMCJCJMEFN, DKAJGBEBNLP BDHDGGCDDHO, [In] HPGOOACMEGN MBDDAPLNFEH, IHGGHCJHDFO IDDBFFAAPEK)
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
