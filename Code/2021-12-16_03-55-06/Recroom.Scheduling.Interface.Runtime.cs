using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBOIEHAOIPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LGMCBKMFAFH FKDDGCHBICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LGMCBKMFAFH BMJBLLJMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LGMCBKMFAFH NGGGNCPEGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ABHNJHMBMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KNJODHEFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KDLPPIDBMCA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KKHGNODELBK.DDIFOGHFLLJ JENDMOJGOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GOKJGHDLOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GELHDFHGKCF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CDMBAOHOIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDLPPIDBMCA JINPJBLJNNJ(KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KDLPPIDBMCA OOFPHKNMFLH(float PLKFKGOGHOD, KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP = KKHGNODELBK.DDIFOGHFLLJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDLPPIDBMCA FAHODBKONPO(Func<bool> JEOAHEFPBHD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NJBPIFCCCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KNJODHEFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNAKCFLNFIA Run(IEnumerator<KDLPPIDBMCA> DHAIKBDOKCB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNAKCFLNFIA Run(Behaviour FEHFBAFOKDE, IEnumerator<KDLPPIDBMCA> DHAIKBDOKCB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HNAKCFLNFIA : NFPFIMOODJO, BJPFHFGNMKO, IEnumerator, KDLPPIDBMCA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ELJNHDJAIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float IJODHMBEPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float EHBNJPAJEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FJHFFJNABNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KKHGNODELBK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[IAHFHAGFKBM]
	public enum DDIFOGHFLLJ
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
	private sealed class IJKFKLHBJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BJPFHFGNMKO promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public IJKFKLHBJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43EEDB0", Offset = "0x43EE1B0", VA = "0x1843EEDB0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static CDMBAOHOIBE OJCHJIOKKDL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<CDMBAOHOIBE> BDGLNGIEEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ELJNHDJAIEJ IPKHPFLDDLL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<ELJNHDJAIEJ> CCGBKEDCPJM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CDMBAOHOIBE OPJCKAGEOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43EFE20", Offset = "0x43EF220", VA = "0x1843EFE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ELJNHDJAIEJ CGOIHLPLNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43EFCF0", Offset = "0x43EF0F0", VA = "0x1843EFCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KDLPPIDBMCA JINPJBLJNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43EF9B0", Offset = "0x43EEDB0", VA = "0x1843EF9B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43EFC30", Offset = "0x43EF030", VA = "0x1843EFC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static KDLPPIDBMCA CNIEKCMNIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43EFBD0", Offset = "0x43EEFD0", VA = "0x1843EFBD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43EEEF0", Offset = "0x43EE2F0", VA = "0x1843EEEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static KDLPPIDBMCA EMNEAGDFDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43EFC90", Offset = "0x43EF090", VA = "0x1843EFC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43EF950", Offset = "0x43EED50", VA = "0x1843EF950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static KDLPPIDBMCA ODOKPNMGMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43EFAE0", Offset = "0x43EEEE0", VA = "0x1843EFAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43EF890", Offset = "0x43EEC90", VA = "0x1843EF890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KDLPPIDBMCA PCFGMCCOGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43EF110", Offset = "0x43EE510", VA = "0x1843EF110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x43EF8F0", Offset = "0x43EECF0", VA = "0x1843EF8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x43EFB40", Offset = "0x43EEF40", VA = "0x1843EFB40")]
	public static void KCGKLOHLDEO(CDMBAOHOIBE FIADONDEACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43EEE60", Offset = "0x43EE260", VA = "0x1843EEE60")]
	public static void CGEENCEHOIO(ELJNHDJAIEJ CLALCCOHECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43EF170", Offset = "0x43EE570", VA = "0x1843EF170")]
	private static void EDMHLEPOHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43EFD50", Offset = "0x43EF150", VA = "0x1843EFD50")]
	public static KDLPPIDBMCA OOFPHKNMFLH(float PLKFKGOGHOD, DDIFOGHFLLJ OLPGAJOLKFP = DDIFOGHFLLJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43EFA10", Offset = "0x43EEE10", VA = "0x1843EFA10")]
	public static KDLPPIDBMCA IIENIIIEFEH(float PLKFKGOGHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43EF760", Offset = "0x43EEB60", VA = "0x1843EF760")]
	public static KDLPPIDBMCA FAHODBKONPO(Func<bool> JEOAHEFPBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x43EEF50", Offset = "0x43EE350", VA = "0x1843EEF50")]
	public static KDLPPIDBMCA DGNGHDNDDPD(BJPFHFGNMKO DNJEDGDMLBC)
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
