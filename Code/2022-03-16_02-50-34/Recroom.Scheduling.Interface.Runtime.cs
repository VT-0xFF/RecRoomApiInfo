using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MCGPHHKEIOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NNEOKDILPJM FPDPPBIJCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	NNEOKDILPJM HAEEDBMLMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NNEOKDILPJM OONKOGBNPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ACIMLPIFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FIMOFOMFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DOOLAEBGDFI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OBPCDNFPNDJ.PPKDFONAFGO POKBGOELPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GOODLGOANND
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBDHDHIAEBN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LCCBBIKCNHO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOOLAEBGDFI EPPJDKMIHGD(OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DOOLAEBGDFI AEFEDNKHGFL(float LNMECBMCIPH, OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF = OBPCDNFPNDJ.PPKDFONAFGO.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOOLAEBGDFI LOINLHJLADL(float LNMECBMCIPH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOOLAEBGDFI BJMDHJCLNAA(Func<bool> PHNEOBLDPHG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KINEGGONFKL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FIMOFOMFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOAOHLFJCKG Run(IEnumerator<DOOLAEBGDFI> HPHEAAIDBAO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOAOHLFJCKG Run(Behaviour BKOJMLFMNLI, IEnumerator<DOOLAEBGDFI> HPHEAAIDBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HOAOHLFJCKG : GIFAJKNOCHE, EDDKJIPNMLB, IEnumerator, DOOLAEBGDFI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NOGOMKAGHHC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float GAHDDMNJNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float IHNKGLPMINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double PDNGKOLAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OBPCDNFPNDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[JKMDJPBFIDF]
	public enum PPKDFONAFGO
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
	private sealed class GKIEFHBEAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EDDKJIPNMLB promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public GKIEFHBEAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4AE53B0", Offset = "0x4AE41B0", VA = "0x184AE53B0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LCCBBIKCNHO BFFBNJFBPIN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<LCCBBIKCNHO> EIIGMFGHIDF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NOGOMKAGHHC MPMLJPNKPGF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<NOGOMKAGHHC> KKNOFFDDHEH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static LCCBBIKCNHO HKBFECKECJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5670", Offset = "0x4AE4470", VA = "0x184AE5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NOGOMKAGHHC LLHKFJAMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5610", Offset = "0x4AE4410", VA = "0x184AE5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DOOLAEBGDFI EPPJDKMIHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4AE6580", Offset = "0x4AE5380", VA = "0x184AE6580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5D00", Offset = "0x4AE4B00", VA = "0x184AE5D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static DOOLAEBGDFI LKGIIHGBBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5B30", Offset = "0x4AE4930", VA = "0x184AE5B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4AE65E0", Offset = "0x4AE53E0", VA = "0x184AE65E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static DOOLAEBGDFI LJBOLPAOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5D70", Offset = "0x4AE4B70", VA = "0x184AE5D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5BF0", Offset = "0x4AE49F0", VA = "0x184AE5BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static DOOLAEBGDFI EDCAILFECJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4AE58A0", Offset = "0x4AE46A0", VA = "0x184AE58A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5460", Offset = "0x4AE4260", VA = "0x184AE5460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static DOOLAEBGDFI HBIOMCCDCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5B90", Offset = "0x4AE4990", VA = "0x184AE5B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4AE5900", Offset = "0x4AE4700", VA = "0x184AE5900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AE5C60", Offset = "0x4AE4A60", VA = "0x184AE5C60")]
	public static void KEGABDAFHEG(LCCBBIKCNHO EAFEPHHHLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AE5800", Offset = "0x4AE4600", VA = "0x184AE5800")]
	public static void EAOKAPBACHE(NOGOMKAGHHC GNFFEEFEBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AE5DD0", Offset = "0x4AE4BD0", VA = "0x184AE5DD0")]
	private static void KNLKAKPCIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4AE54D0", Offset = "0x4AE42D0", VA = "0x184AE54D0")]
	public static DOOLAEBGDFI AEFEDNKHGFL(float LNMECBMCIPH, PPKDFONAFGO IONPBNENEGF = PPKDFONAFGO.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4AE6450", Offset = "0x4AE5250", VA = "0x184AE6450")]
	public static DOOLAEBGDFI LOINLHJLADL(float LNMECBMCIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AE56D0", Offset = "0x4AE44D0", VA = "0x184AE56D0")]
	public static DOOLAEBGDFI BJMDHJCLNAA(Func<bool> PHNEOBLDPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4AE5970", Offset = "0x4AE4770", VA = "0x184AE5970")]
	public static DOOLAEBGDFI EMGNAHKBFKO(EDDKJIPNMLB GDJKJKEPKOD)
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
