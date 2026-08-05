using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LAKFLIJDBCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GNKFNHJJKGC NLJLALLBHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GNKFNHJJKGC BDFHBCFKFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GNKFNHJJKGC EDGKEFBKEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PNGJMFMKPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GIDDCICOPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EJFBNPFIIDA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LGLLNDHNEFG.JPHGAKGBNOB EMPFAFLONLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HNEDCENGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JGHNDLGFALA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KHNPJPLCJME
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJFBNPFIIDA EIHNHANDIBK(LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJFBNPFIIDA OGJCBFALANN(float PNMIPKLLCIL, LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC = LGLLNDHNEFG.JPHGAKGBNOB.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJFBNPFIIDA NJGGJPACJCB(Func<bool> DAGMGEMNINN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LBKAFKFLEKF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GIDDCICOPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PCKAMDGBNHA Run(IEnumerator<EJFBNPFIIDA> MKBJLJDLNIB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PCKAMDGBNHA Run(Behaviour OEIFFOBMIEM, IEnumerator<EJFBNPFIIDA> MKBJLJDLNIB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PCKAMDGBNHA : CFDBJADAECP, FIIDGPMBKPK, IEnumerator, EJFBNPFIIDA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ACLGOBNDAKI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FGGBNLMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float OEBGNOMHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double CBFKMBIJDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LGLLNDHNEFG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DDLNOCNJIKL]
	public enum JPHGAKGBNOB
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
	private sealed class MCPCKDPPFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FIIDGPMBKPK promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public MCPCKDPPFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D85040", Offset = "0x3D84240", VA = "0x183D85040")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static KHNPJPLCJME HMDAEKENIMA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<KHNPJPLCJME> KBGBLHLLJIE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ACLGOBNDAKI BBCJHKCBGFB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<ACLGOBNDAKI> PGOCDHFHMOF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static KHNPJPLCJME NEHGHOJENGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D848F0", Offset = "0x3D83AF0", VA = "0x183D848F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ACLGOBNDAKI DALAOGJMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D83F90", Offset = "0x3D83190", VA = "0x183D83F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static EJFBNPFIIDA EIHNHANDIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D84890", Offset = "0x3D83A90", VA = "0x183D84890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D84760", Offset = "0x3D83960", VA = "0x183D84760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static EJFBNPFIIDA CLFBMMDBKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D84950", Offset = "0x3D83B50", VA = "0x183D84950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D84F50", Offset = "0x3D84150", VA = "0x183D84F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static EJFBNPFIIDA PHMOGHGDGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D84C90", Offset = "0x3D83E90", VA = "0x183D84C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D84B70", Offset = "0x3D83D70", VA = "0x183D84B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static EJFBNPFIIDA GJBDJBCIGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D84EF0", Offset = "0x3D840F0", VA = "0x183D84EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D84C30", Offset = "0x3D83E30", VA = "0x183D84C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EJFBNPFIIDA KHMAMPCJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D84BD0", Offset = "0x3D83DD0", VA = "0x183D84BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D84670", Offset = "0x3D83870", VA = "0x183D84670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D846D0", Offset = "0x3D838D0", VA = "0x183D846D0")]
	public static void FMDFDIFFNHC(KHNPJPLCJME MNIBIIHMHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D845E0", Offset = "0x3D837E0", VA = "0x183D845E0")]
	public static void FAIGMKDEEMI(ACLGOBNDAKI JINAPPPDJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D83FF0", Offset = "0x3D831F0", VA = "0x183D83FF0")]
	private static void ENELPOCMKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D84E20", Offset = "0x3D84020", VA = "0x183D84E20")]
	public static EJFBNPFIIDA OGJCBFALANN(float PNMIPKLLCIL, JPHGAKGBNOB MCPHJACDEHC = JPHGAKGBNOB.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D847C0", Offset = "0x3D839C0", VA = "0x183D847C0")]
	public static EJFBNPFIIDA HNBFAIAEDCD(float PNMIPKLLCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D84CF0", Offset = "0x3D83EF0", VA = "0x183D84CF0")]
	public static EJFBNPFIIDA NJGGJPACJCB(Func<bool> DAGMGEMNINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D849B0", Offset = "0x3D83BB0", VA = "0x183D849B0")]
	public static EJFBNPFIIDA KPBFFHHLCIA(FIIDGPMBKPK IHBPKCCLLJG)
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
