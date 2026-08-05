using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPONONJDOFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GGJPBMMBEKM EOEDFPEGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GGJPBMMBEKM PLEBJGOBHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GGJPBMMBEKM EMDPIGLJPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NLMCILGPMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DELIABLELFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IGHAECBNBLN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OMLFHOPGHOI.MGFJHNGHPDM DOMBNAAAIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float JEHEFNKHFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMCJCEKKJCD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EDLBLENPAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGHAECBNBLN LFKGNOEEOFH(OMLFHOPGHOI.MGFJHNGHPDM IHNNPAOONKC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGHAECBNBLN DBMMDIJHFND(float JIPJBFMHOOP, OMLFHOPGHOI.MGFJHNGHPDM CAKLIIJIGJK = OMLFHOPGHOI.MGFJHNGHPDM.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGHAECBNBLN FKPPEBGOBMH(float JIPJBFMHOOP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IGHAECBNBLN JKDJPPBMHLI(Func<bool> CAFGJLIIDEM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DCEMIECLGDM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DELIABLELFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OLAOJJPOAKP Run(IEnumerator<IGHAECBNBLN> PMKONFGGHMA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLAOJJPOAKP Run(Behaviour EEBJJBKMCLF, IEnumerator<IGHAECBNBLN> PMKONFGGHMA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OLAOJJPOAKP : HJBEFNPPGPM, EPHEJFPBCIA, IEnumerator, IGHAECBNBLN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface APJDOFDJNEM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LFPJGHIFPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float OAKCJENAMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double PMPLIFGBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OMLFHOPGHOI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[LEBEGLKLILK]
	public enum MGFJHNGHPDM
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
	private sealed class NCAKILHFAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EPHEJFPBCIA promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public NCAKILHFAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x17E8630", Offset = "0x17E7230", VA = "0x1817E8630")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static EDLBLENPAKE HIHHKOGDJNF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<EDLBLENPAKE> JIJIENNABLO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static APJDOFDJNEM HNAEKGLBPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<APJDOFDJNEM> FAEEEHNKEJL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EDLBLENPAKE JPHCNGILJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x17E89D0", Offset = "0x17E75D0", VA = "0x1817E89D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static APJDOFDJNEM LAEDIJLDDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x17E8D40", Offset = "0x17E7940", VA = "0x1817E8D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IGHAECBNBLN LFKGNOEEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x17E8B30", Offset = "0x17E7730", VA = "0x1817E8B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x17E8900", Offset = "0x17E7500", VA = "0x1817E8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static IGHAECBNBLN BFKBGDPFBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x17E86E0", Offset = "0x17E72E0", VA = "0x1817E86E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x17E91E0", Offset = "0x17E7DE0", VA = "0x1817E91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static IGHAECBNBLN DDCNPOHLCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x17E8A30", Offset = "0x17E7630", VA = "0x1817E8A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x17E8DA0", Offset = "0x17E79A0", VA = "0x1817E8DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static IGHAECBNBLN EDNKAGJDEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x17E9180", Offset = "0x17E7D80", VA = "0x1817E9180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x17E9110", Offset = "0x17E7D10", VA = "0x1817E9110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static IGHAECBNBLN DCGPEJKNGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x17E8970", Offset = "0x17E7570", VA = "0x1817E8970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x17E8CD0", Offset = "0x17E78D0", VA = "0x1817E8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x17E8A90", Offset = "0x17E7690", VA = "0x1817E8A90")]
	public static void CGLKEMIMHHC(EDLBLENPAKE CMHDFLDNGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x17E8F40", Offset = "0x17E7B40", VA = "0x1817E8F40")]
	public static void HOKKMCNKMGI(APJDOFDJNEM LOADABCFBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x17E9250", Offset = "0x17E7E50", VA = "0x1817E9250")]
	private static void PALKJCLFBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x17E8B90", Offset = "0x17E7790", VA = "0x1817E8B90")]
	public static IGHAECBNBLN DBMMDIJHFND(float JIPJBFMHOOP, MGFJHNGHPDM CAKLIIJIGJK = MGFJHNGHPDM.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x17E8E10", Offset = "0x17E7A10", VA = "0x1817E8E10")]
	public static IGHAECBNBLN FKPPEBGOBMH(float JIPJBFMHOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x17E8FE0", Offset = "0x17E7BE0", VA = "0x1817E8FE0")]
	public static IGHAECBNBLN JKDJPPBMHLI(Func<bool> CAFGJLIIDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x17E8740", Offset = "0x17E7340", VA = "0x1817E8740")]
	public static IGHAECBNBLN AHBFBAEMOOD(EPHEJFPBCIA BBGFFDMJNNM)
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
