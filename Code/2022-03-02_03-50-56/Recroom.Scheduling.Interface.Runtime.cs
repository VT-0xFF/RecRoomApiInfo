using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AFIOHBDIBFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CNEELAKGHKO LCEPLPKBION
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CNEELAKGHKO NOMFBLELHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CNEELAKGHKO LGKIKMDBAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CJLGEKDFGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OFLJOBGFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JFAHKOGHLOL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DJHOLNLKCOK.LCFMLIFMCLP CPOKGCKGNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MHBHOENBPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMOMEDEEEDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GBBBOBJGDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFAHKOGHLOL JJFPNOPHMJI(DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFAHKOGHLOL PLIBMHDMNEL(float PNCPGCPDHGE, DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH = DJHOLNLKCOK.LCFMLIFMCLP.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFAHKOGHLOL KBALCGCCPOM(float PNCPGCPDHGE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JFAHKOGHLOL OLLHJOLLBDE(Func<bool> BPDAEPFBCIH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface INDIAJPIODF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OFLJOBGFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBBEAJINNHP Run(IEnumerator<JFAHKOGHLOL> GLFMBPCPFFC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBBEAJINNHP Run(Behaviour JJNBJBEMAKH, IEnumerator<JFAHKOGHLOL> GLFMBPCPFFC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OBBEAJINNHP : LELMHOFHHKK, EJLKCPFELBD, IEnumerator, JFAHKOGHLOL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KBGIOJEMIMH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KIIPAEICGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float ICNAFLMCLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HBLIIPOMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DJHOLNLKCOK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[MPHECAJFGMP]
	public enum LCFMLIFMCLP
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
	private sealed class DDJIOHMMHLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EJLKCPFELBD promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DDJIOHMMHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x49F5300", Offset = "0x49F4300", VA = "0x1849F5300")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static GBBBOBJGDKK NAMAEHMPPNG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<GBBBOBJGDKK> FCJBFOECAKC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KBGIOJEMIMH EBNDOIECIPO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<KBGIOJEMIMH> CDBFOBAAPNG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static GBBBOBJGDKK NFJMIEJJHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49F61C0", Offset = "0x49F51C0", VA = "0x1849F61C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KBGIOJEMIMH PKFHDCNIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x49F5A30", Offset = "0x49F4A30", VA = "0x1849F5A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JFAHKOGHLOL JJFPNOPHMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x49F5B70", Offset = "0x49F4B70", VA = "0x1849F5B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x49F5A90", Offset = "0x49F4A90", VA = "0x1849F5A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static JFAHKOGHLOL JCIMFPDHAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49F6080", Offset = "0x49F5080", VA = "0x1849F6080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x49F6150", Offset = "0x49F5150", VA = "0x1849F6150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static JFAHKOGHLOL FGNEOEDKOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x49F5BD0", Offset = "0x49F4BD0", VA = "0x1849F5BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x49F63F0", Offset = "0x49F53F0", VA = "0x1849F63F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JFAHKOGHLOL OMNPKJPBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49F5C30", Offset = "0x49F4C30", VA = "0x1849F5C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49F5B00", Offset = "0x49F4B00", VA = "0x1849F5B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JFAHKOGHLOL HNOHLPELOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x49F5EF0", Offset = "0x49F4EF0", VA = "0x1849F5EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x49F60E0", Offset = "0x49F50E0", VA = "0x1849F60E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x49F6220", Offset = "0x49F5220", VA = "0x1849F6220")]
	public static void OJADDGEEEBN(GBBBOBJGDKK PEKDFDIFAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x49F5C90", Offset = "0x49F4C90", VA = "0x1849F5C90")]
	public static void HJKEIDAJAPK(KBGIOJEMIMH DHBDHGACBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49F53B0", Offset = "0x49F43B0", VA = "0x1849F53B0")]
	private static void AAOHLPFIAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49F6460", Offset = "0x49F5460", VA = "0x1849F6460")]
	public static JFAHKOGHLOL PLIBMHDMNEL(float PNCPGCPDHGE, LCFMLIFMCLP PGLGKDNEJFH = LCFMLIFMCLP.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49F5F50", Offset = "0x49F4F50", VA = "0x1849F5F50")]
	public static JFAHKOGHLOL KBALCGCCPOM(float PNCPGCPDHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49F62C0", Offset = "0x49F52C0", VA = "0x1849F62C0")]
	public static JFAHKOGHLOL OLLHJOLLBDE(Func<bool> BPDAEPFBCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49F5D30", Offset = "0x49F4D30", VA = "0x1849F5D30")]
	public static JFAHKOGHLOL IHLIEHMNBOI(EJLKCPFELBD BONEIOHHFOL)
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
