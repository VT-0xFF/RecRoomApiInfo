using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HNHDBGKAENI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EDOMFAGNPKP MPPCHHNFCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EDOMFAGNPKP GDNOFNOEJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EDOMFAGNPKP EACMKAMLKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NGFCHIFHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GJHJIPGLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNMANPNLMCB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LAJDCKMGDCG.OBEBMILFKKJ LHPKAOFBKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BEGKJDCDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHAAENLGFMK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MLDILHIHOOD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNMANPNLMCB GINCCFJEIPA(LAJDCKMGDCG.OBEBMILFKKJ JPPOFAMNEDG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MNMANPNLMCB JIFFKPFLNJH(float CPANMKLOGPE, LAJDCKMGDCG.OBEBMILFKKJ IHPJBOJOCHF = LAJDCKMGDCG.OBEBMILFKKJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNMANPNLMCB MALPEJOEIAJ(float CPANMKLOGPE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNMANPNLMCB NBJEPMKAHKH(Func<bool> LPMGCAFFAMA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EGIJNDAILGG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GJHJIPGLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIKIHPIPFGJ Run(IEnumerator<MNMANPNLMCB> IIHPGCLPKIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIKIHPIPFGJ Run(Behaviour FBKBDIMBGGH, IEnumerator<MNMANPNLMCB> IIHPGCLPKIH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NIKIHPIPFGJ : EEPOMOFHPMH, FDFGBMEHONB, IEnumerator, MNMANPNLMCB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FBCJAPFJCLA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float HCEJFIHMFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float MHGOLOGBIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MELCFPPCJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LAJDCKMGDCG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DAPDKLMJHKL]
	public enum OBEBMILFKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NLPEOHBJFBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FDFGBMEHONB promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public NLPEOHBJFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x207F600", Offset = "0x207DC00", VA = "0x18207F600")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static MLDILHIHOOD MOJCPFAEOFA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<MLDILHIHOOD> KIDIHHHLKDO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FBCJAPFJCLA MDDAEECBDPI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<FBCJAPFJCLA> LMCLCGEKAPN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static MLDILHIHOOD PIBEMFBLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x207EDF0", Offset = "0x207D3F0", VA = "0x18207EDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static FBCJAPFJCLA BAECMNCFOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x207ED90", Offset = "0x207D390", VA = "0x18207ED90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MNMANPNLMCB GINCCFJEIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x207EB30", Offset = "0x207D130", VA = "0x18207EB30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x207F4F0", Offset = "0x207DAF0", VA = "0x18207F4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MNMANPNLMCB HDPOFEMLIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x207EE50", Offset = "0x207D450", VA = "0x18207EE50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x207F3B0", Offset = "0x207D9B0", VA = "0x18207F3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MNMANPNLMCB JNIPIGBNJED
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x207F420", Offset = "0x207DA20", VA = "0x18207F420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x207F1A0", Offset = "0x207D7A0", VA = "0x18207F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MNMANPNLMCB MGJIHALEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x207ED30", Offset = "0x207D330", VA = "0x18207ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x207F480", Offset = "0x207DA80", VA = "0x18207F480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MNMANPNLMCB NILCPNDLOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x207EB90", Offset = "0x207D190", VA = "0x18207EB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x207F340", Offset = "0x207D940", VA = "0x18207F340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x207E410", Offset = "0x207CA10", VA = "0x18207E410")]
	public static void DNIJMGJFCGC(MLDILHIHOOD ABCBPCKENEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x207E370", Offset = "0x207C970", VA = "0x18207E370")]
	public static void CNNNBODHOKA(FBCJAPFJCLA AGCKKHLMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x207E4B0", Offset = "0x207CAB0", VA = "0x18207E4B0")]
	private static void EGBDEKBAEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x207EBF0", Offset = "0x207D1F0", VA = "0x18207EBF0")]
	public static MNMANPNLMCB JIFFKPFLNJH(float CPANMKLOGPE, OBEBMILFKKJ IHPJBOJOCHF = OBEBMILFKKJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x207EEB0", Offset = "0x207D4B0", VA = "0x18207EEB0")]
	public static MNMANPNLMCB MALPEJOEIAJ(float CPANMKLOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x207F210", Offset = "0x207D810", VA = "0x18207F210")]
	public static MNMANPNLMCB NBJEPMKAHKH(Func<bool> LPMGCAFFAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x207EFE0", Offset = "0x207D5E0", VA = "0x18207EFE0")]
	public static MNMANPNLMCB MGMDJJADCOI(FDFGBMEHONB OOLNGCNGGEE)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
