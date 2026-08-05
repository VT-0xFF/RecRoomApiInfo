using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LCOBOOAPANG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AIPMLCOLGIN GCFMLIIHCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AIPMLCOLGIN FIAECHENKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	AIPMLCOLGIN EOPHKCNCOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AJIMGEMKEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HIKJNCAOHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NJCBPLHFLJK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HNDAOKNLPII.AGGJBCFLNPD AGMNNLDHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KGGDNKIGGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NIOANEPDABM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AKDCDGDPABC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJCBPLHFLJK DGCFNNCCOAF(HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NJCBPLHFLJK HIPJLDEEGOE(float CNEHNHENJMF, HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN = HNDAOKNLPII.AGGJBCFLNPD.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NJCBPLHFLJK ALCMIBLNCFP(float CNEHNHENJMF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJCBPLHFLJK CIOIEOGEMMG(Func<bool> GEPNAANOJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EBNLIKPOLIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HIKJNCAOHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NJIHFLFDJJB Run(IEnumerator<NJCBPLHFLJK> LOAPGNKLBLB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NJIHFLFDJJB Run(Behaviour DAABJFEBLJF, IEnumerator<NJCBPLHFLJK> LOAPGNKLBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NJIHFLFDJJB : GFFCKECKPCB, CDJPJKPGHKC, IEnumerator, NJCBPLHFLJK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AAMKJAPMPEC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FPKBMEIJEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float MMGCKBBJJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double BHCHPDOKCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HNDAOKNLPII
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[EKIGKEJLIKA]
	public enum AGGJBCFLNPD
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
	private sealed class HDPMLNABKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CDJPJKPGHKC promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public HDPMLNABKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B1B980", Offset = "0x4B1A180", VA = "0x184B1B980")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static AKDCDGDPABC IFKOBJONMOD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<AKDCDGDPABC> NFLJAHNIGMP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static AAMKJAPMPEC FMHGCADPHAH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<AAMKJAPMPEC> FHCACNKNJFO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AKDCDGDPABC BCDHJLOLNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BC60", Offset = "0x4B1A460", VA = "0x184B1BC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AAMKJAPMPEC HCIGJIEHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C990", Offset = "0x4B1B190", VA = "0x184B1C990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NJCBPLHFLJK DGCFNNCCOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C5B0", Offset = "0x4B1ADB0", VA = "0x184B1C5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C920", Offset = "0x4B1B120", VA = "0x184B1C920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NJCBPLHFLJK EOKJINMHGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C8C0", Offset = "0x4B1B0C0", VA = "0x184B1C8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C410", Offset = "0x4B1AC10", VA = "0x184B1C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static NJCBPLHFLJK OCEHIGMEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C3B0", Offset = "0x4B1ABB0", VA = "0x184B1C3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C9F0", Offset = "0x4B1B1F0", VA = "0x184B1C9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NJCBPLHFLJK BOJIFCIIDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C610", Offset = "0x4B1AE10", VA = "0x184B1C610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BCC0", Offset = "0x4B1A4C0", VA = "0x184B1BCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NJCBPLHFLJK LHFAHPOBDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BAD0", Offset = "0x4B1A2D0", VA = "0x184B1BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C7B0", Offset = "0x4B1AFB0", VA = "0x184B1C7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C820", Offset = "0x4B1B020", VA = "0x184B1C820")]
	public static void LBLCLCHEGBI(AKDCDGDPABC FALFKAEBNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BA30", Offset = "0x4B1A230", VA = "0x184B1BA30")]
	public static void ACKBHKCPGNN(AAMKJAPMPEC PKLLFPKOKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BD30", Offset = "0x4B1A530", VA = "0x184B1BD30")]
	private static void BDPKIECOCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C670", Offset = "0x4B1AE70", VA = "0x184B1C670")]
	public static NJCBPLHFLJK HIPJLDEEGOE(float CNEHNHENJMF, AGGJBCFLNPD FEPFGCKEPEN = AGGJBCFLNPD.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BB30", Offset = "0x4B1A330", VA = "0x184B1BB30")]
	public static NJCBPLHFLJK ALCMIBLNCFP(float CNEHNHENJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C480", Offset = "0x4B1AC80", VA = "0x184B1C480")]
	public static NJCBPLHFLJK CIOIEOGEMMG(Func<bool> GEPNAANOJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CA60", Offset = "0x4B1B260", VA = "0x184B1CA60")]
	public static NJCBPLHFLJK NCEDKCGLEPC(CDJPJKPGHKC LAPKAMHCPGL)
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
