using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EOBGPKHFACG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OMGLOKENPJB ABKOFGANOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OMGLOKENPJB HPFEICAFBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OMGLOKENPJB JDDHNMMEIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AJEJNOHCJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IJIIADGGDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JHIBAGNJJHH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NAKALFPMBKB.GDPEDIJMPMK IMIDLCOKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float EALHNHFOCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGDGINDOPGM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MEAKEPNJMPP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHIBAGNJJHH ECDGEJKDIIN(NAKALFPMBKB.GDPEDIJMPMK LJKODDGHBFI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JHIBAGNJJHH HKLBNLHOCIG(float DEDMIJGCBAA, NAKALFPMBKB.GDPEDIJMPMK NNMIPKCJLNE = NAKALFPMBKB.GDPEDIJMPMK.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHIBAGNJJHH DLEFHPPAMMF(float DEDMIJGCBAA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHIBAGNJJHH DPJMOKMHCBD(Func<bool> HPPHKJFEINA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ALDDLCIJCBH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IJIIADGGDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FMGMHOFHKCI Run(IEnumerator<JHIBAGNJJHH> LGEKECDKCFI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FMGMHOFHKCI Run(Behaviour EKDIFLKNOLC, IEnumerator<JHIBAGNJJHH> LGEKECDKCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FMGMHOFHKCI : HDLOJCGHFKE, HAKBKGDIMMA, IEnumerator, JHIBAGNJJHH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KLLBPHIFEIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JMJKPLMMDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float ONJOEHIKFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double EPFAGIAOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NAKALFPMBKB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[OALAMDDFBFB]
	public enum GDPEDIJMPMK
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
	private sealed class CIAOHFLHLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HAKBKGDIMMA promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public CIAOHFLHLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AFF0", Offset = "0x4C2A1F0", VA = "0x184C2AFF0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static MEAKEPNJMPP AIOJEDBJGIM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<MEAKEPNJMPP> NHHPEHPNAOC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KLLBPHIFEIJ HKEEHKMHHAF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<KLLBPHIFEIJ> DBDEJLJLKCM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static MEAKEPNJMPP CDEEEMNDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B0A0", Offset = "0x4C2A2A0", VA = "0x184C2B0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KLLBPHIFEIJ PMGGJECFNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B1A0", Offset = "0x4C2A3A0", VA = "0x184C2B1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JHIBAGNJJHH ECDGEJKDIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C1C0", Offset = "0x4C2B3C0", VA = "0x184C2C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B380", Offset = "0x4C2A580", VA = "0x184C2B380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static JHIBAGNJJHH FJDOBJLGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B8C0", Offset = "0x4C2AAC0", VA = "0x184C2B8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C220", Offset = "0x4C2B420", VA = "0x184C2C220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static JHIBAGNJJHH ODAKGCBAIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C160", Offset = "0x4C2B360", VA = "0x184C2C160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B7F0", Offset = "0x4C2A9F0", VA = "0x184C2B7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JHIBAGNJJHH BGIEKHMKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B650", Offset = "0x4C2A850", VA = "0x184C2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B200", Offset = "0x4C2A400", VA = "0x184C2B200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JHIBAGNJJHH ANGLJBHFPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B860", Offset = "0x4C2AA60", VA = "0x184C2B860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B310", Offset = "0x4C2A510", VA = "0x184C2B310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B270", Offset = "0x4C2A470", VA = "0x184C2B270")]
	public static void BDFCEOIAJKJ(MEAKEPNJMPP MMKBCGEMFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B100", Offset = "0x4C2A300", VA = "0x184C2B100")]
	public static void AOJPEFMAABB(KLLBPHIFEIJ DDKCELGGNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B920", Offset = "0x4C2AB20", VA = "0x184C2B920")]
	private static void MONJCNBJGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B6B0", Offset = "0x4C2A8B0", VA = "0x184C2B6B0")]
	public static JHIBAGNJJHH HKLBNLHOCIG(float DEDMIJGCBAA, GDPEDIJMPMK NNMIPKCJLNE = GDPEDIJMPMK.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B3F0", Offset = "0x4C2A5F0", VA = "0x184C2B3F0")]
	public static JHIBAGNJJHH DLEFHPPAMMF(float DEDMIJGCBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B520", Offset = "0x4C2A720", VA = "0x184C2B520")]
	public static JHIBAGNJJHH DPJMOKMHCBD(Func<bool> HPPHKJFEINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4C2BFA0", Offset = "0x4C2B1A0", VA = "0x184C2BFA0")]
	public static JHIBAGNJJHH NGNBKMEBGJA(HAKBKGDIMMA FKBBEAOAIAA)
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
