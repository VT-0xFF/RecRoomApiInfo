using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FJFKFCKFAIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LKKJDCJIBEF OBPFBAINAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LKKJDCJIBEF GKJIJIDACKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LKKJDCJIBEF GFKNEGOCIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OBEFIFFNNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AJNFKIBCOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JBHCACLLONB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DIFOGFDGGIP.JJAOFAKCOIJ OCDGKJFBFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DDOAHOABLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCIBAJBDKFK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PKJBHHBEOKI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBHCACLLONB KLDCNDCNIBK(DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBHCACLLONB EHAIMNGNEBO(float LEGFMECKOED, DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP = DIFOGFDGGIP.JJAOFAKCOIJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBHCACLLONB ENNFIGEBHBI(float LEGFMECKOED);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBHCACLLONB HPMIHPKGIJL(Func<bool> HLGLPNKFAOI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KFEGEFDGHAD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AJNFKIBCOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIOIEKMKHHG Run(IEnumerator<JBHCACLLONB> KLOPBJNBMFC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OIOIEKMKHHG Run(Behaviour MILHAHGHJGA, IEnumerator<JBHCACLLONB> KLOPBJNBMFC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OIOIEKMKHHG : BGKJFFOOBBF, PCDEFPAPNCL, IEnumerator, JBHCACLLONB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KEKLNPALAGC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CMFJIOJHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float GNAJIMFFENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KCDEFJIFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DIFOGFDGGIP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CMAEFFKLIDH]
	public enum JJAOFAKCOIJ
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
	private sealed class LLNJGCMPHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PCDEFPAPNCL promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public LLNJGCMPHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1100", Offset = "0x4BBFF00", VA = "0x184BC1100")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static PKJBHHBEOKI PNDHCMOHBIC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<PKJBHHBEOKI> CCPLGNDMING;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KEKLNPALAGC JIKAKABAEIN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<KEKLNPALAGC> ABDCPJEBCFL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static PKJBHHBEOKI ALLEDOFHFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4BC08B0", Offset = "0x4BBF6B0", VA = "0x184BC08B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KEKLNPALAGC IACIGCMODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0370", Offset = "0x4BBF170", VA = "0x184BC0370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JBHCACLLONB KLDCNDCNIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0100", Offset = "0x4BBEF00", VA = "0x184BC0100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0910", Offset = "0x4BBF710", VA = "0x184BC0910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static JBHCACLLONB IGLNIDIFBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0980", Offset = "0x4BBF780", VA = "0x184BC0980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0840", Offset = "0x4BBF640", VA = "0x184BC0840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static JBHCACLLONB AFLGMMAIPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4BC01D0", Offset = "0x4BBEFD0", VA = "0x184BC01D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0160", Offset = "0x4BBEF60", VA = "0x184BC0160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JBHCACLLONB INOILBKIPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4BC00A0", Offset = "0x4BBEEA0", VA = "0x184BC00A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0730", Offset = "0x4BBF530", VA = "0x184BC0730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JBHCACLLONB OELPJNIAAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0500", Offset = "0x4BBF300", VA = "0x184BC0500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4BBFE70", Offset = "0x4BBEC70", VA = "0x184BBFE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BC07A0", Offset = "0x4BBF5A0", VA = "0x184BC07A0")]
	public static void KAPFDHMFNKM(PKJBHHBEOKI DODMLGDAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BC0560", Offset = "0x4BBF360", VA = "0x184BC0560")]
	public static void GDODFALPEIO(KEKLNPALAGC HDNEMFCIODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BC09E0", Offset = "0x4BBF7E0", VA = "0x184BC09E0")]
	private static void PNJMFBMAIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BC0230", Offset = "0x4BBF030", VA = "0x184BC0230")]
	public static JBHCACLLONB EHAIMNGNEBO(float LEGFMECKOED, JJAOFAKCOIJ JIINJIBJJBP = JJAOFAKCOIJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4BC03D0", Offset = "0x4BBF1D0", VA = "0x184BC03D0")]
	public static JBHCACLLONB ENNFIGEBHBI(float LEGFMECKOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BC0600", Offset = "0x4BBF400", VA = "0x184BC0600")]
	public static JBHCACLLONB HPMIHPKGIJL(Func<bool> HLGLPNKFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4BBFEE0", Offset = "0x4BBECE0", VA = "0x184BBFEE0")]
	public static JBHCACLLONB BHEEIBNGKDB(PCDEFPAPNCL ONDLHLPELBB)
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
