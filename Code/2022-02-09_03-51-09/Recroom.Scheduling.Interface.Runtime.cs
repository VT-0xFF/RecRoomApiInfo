using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JHJJCGPNGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MHDMOBBLODF AIFMIHLFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MHDMOBBLODF MKAJNBLFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MHDMOBBLODF COHLOKJONFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HDBGNPFAOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KJCPKAFNBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CNLGKCMJFDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IFDJCGPOIOM.MEJCFHGJGNC KLIOKPLMDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HHDDJLLBFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKHMJBGLGLO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NMCGCKIFCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNLGKCMJFDJ CNKKNEKCIOC(IFDJCGPOIOM.MEJCFHGJGNC IIHHLACOGHF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNLGKCMJFDJ AFKDCPEBECP(float JMDONKAEBNO, IFDJCGPOIOM.MEJCFHGJGNC GHCBHCFOBHL = IFDJCGPOIOM.MEJCFHGJGNC.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNLGKCMJFDJ BPHICOFHAFI(Func<bool> GNAGAPJFADK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JJGCHLNGGNF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KJCPKAFNBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LKIEAODIPPJ Run(IEnumerator<CNLGKCMJFDJ> NINOFJHCELI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LKIEAODIPPJ Run(Behaviour HIKLIFLDMDD, IEnumerator<CNLGKCMJFDJ> NINOFJHCELI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LKIEAODIPPJ : GOOMHOMPGHO, CFGFLPOGNPH, IEnumerator, CNLGKCMJFDJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LFMHCPJIPGL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BJBNDHIJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float LIPPLGAKIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double LCICEIMHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IFDJCGPOIOM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[OEHMMJDFFKL]
	public enum MEJCFHGJGNC
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
	private sealed class NOALJCHOKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CFGFLPOGNPH promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public NOALJCHOKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4710E00", Offset = "0x470FC00", VA = "0x184710E00")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static NMCGCKIFCGH MLCBLAIOJHF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<NMCGCKIFCGH> MNMGEHHPDEA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LFMHCPJIPGL OKACJGOKDOB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<LFMHCPJIPGL> GDIAHJJEPJL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static NMCGCKIFCGH DCHGLAOIOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x47103E0", Offset = "0x470F1E0", VA = "0x1847103E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LFMHCPJIPGL GBLDHLOAGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x47104A0", Offset = "0x470F2A0", VA = "0x1847104A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CNLGKCMJFDJ CNKKNEKCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4710250", Offset = "0x470F050", VA = "0x184710250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x47102B0", Offset = "0x470F0B0", VA = "0x1847102B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CNLGKCMJFDJ DJCBOMNOPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4710320", Offset = "0x470F120", VA = "0x184710320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4710C50", Offset = "0x470FA50", VA = "0x184710C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static CNLGKCMJFDJ DNMDKNAPJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4710380", Offset = "0x470F180", VA = "0x184710380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4710140", Offset = "0x470EF40", VA = "0x184710140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static CNLGKCMJFDJ MHHFJLECGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x470FD80", Offset = "0x470EB80", VA = "0x18470FD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x470FDE0", Offset = "0x470EBE0", VA = "0x18470FDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CNLGKCMJFDJ CGIAINAMCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4710440", Offset = "0x470F240", VA = "0x184710440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x470FD10", Offset = "0x470EB10", VA = "0x18470FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4710CC0", Offset = "0x470FAC0", VA = "0x184710CC0")]
	public static void PMIIJPBMFLI(NMCGCKIFCGH GKOFHFGMCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47101B0", Offset = "0x470EFB0", VA = "0x1847101B0")]
	public static void EIBOMMIKELP(LFMHCPJIPGL KIJLAHCJKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47105D0", Offset = "0x470F3D0", VA = "0x1847105D0")]
	private static void OGGGKKPDJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x470FC40", Offset = "0x470EA40", VA = "0x18470FC40")]
	public static CNLGKCMJFDJ AFKDCPEBECP(float JMDONKAEBNO, MEJCFHGJGNC GHCBHCFOBHL = MEJCFHGJGNC.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4710500", Offset = "0x470F300", VA = "0x184710500")]
	public static CNLGKCMJFDJ NPCKBJCLJNK(float JMDONKAEBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x470FE50", Offset = "0x470EC50", VA = "0x18470FE50")]
	public static CNLGKCMJFDJ BPHICOFHAFI(Func<bool> GNAGAPJFADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x470FF80", Offset = "0x470ED80", VA = "0x18470FF80")]
	public static CNLGKCMJFDJ CJPLLMCKDGB(CFGFLPOGNPH JHMDHJLPMED)
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
