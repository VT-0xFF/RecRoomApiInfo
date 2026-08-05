using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ABDNJMOLOMI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JAEOJMMDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ACJCOKCBOND> FCBHFDNGDMI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACJCOKCBOND
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string IMLAMDBADPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NBPNDKGPDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GMNANMACJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDJCJEBHGAF PMOBODHKPOA(Action<ArraySegment<float>> NEDFJOJDIHF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJLMKNCJAGG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DDJCJEBHGAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OAAFHFMDCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC8A120", Offset = "0xC89520", VA = "0x180C8A120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JAKCKNKNAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x283D840", Offset = "0x283CC40", VA = "0x18283D840")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60E85D0", Offset = "0x60E79D0", VA = "0x1860E85D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CB60", Offset = "0x6D9BF60", VA = "0x186D9CB60")]
	public DDJCJEBHGAF(int BJLOGCPKCDD, int CPPOIFDJJMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FANPPNMOHPL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ABDNJMOLOMI ECINNEDPLHN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool JAEOJMMDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76F9F00", Offset = "0x76F9300", VA = "0x1876F9F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76F9F80", Offset = "0x76F9380", VA = "0x1876F9F80")]
	static FANPPNMOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76F9E10", Offset = "0x76F9210", VA = "0x1876F9E10")]
	public static IReadOnlyList<ACJCOKCBOND> FCBHFDNGDMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JNJILFEDFBJ : ABDNJMOLOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JEDNMOPKMKP : ACJCOKCBOND
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OKKOBJDFBBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public OKKOBJDFBBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x76FA900", Offset = "0x76F9D00", VA = "0x1876FA900")]
			internal void LBEHNJIHKDH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DEKHJDOLHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture IMFOAHIPHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MDNEABDMLKP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IMLAMDBADPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x76FA0F0", Offset = "0x76F94F0", VA = "0x1876FA0F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NBPNDKGPDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x983FC0", Offset = "0x9833C0", VA = "0x180983FC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x983EB0", Offset = "0x9832B0", VA = "0x180983EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GMNANMACJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x92B3A0", Offset = "0x92A7A0", VA = "0x18092B3A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76FA4D0", Offset = "0x76F98D0", VA = "0x1876FA4D0", Slot = "7")]
		public DDJCJEBHGAF PMOBODHKPOA(Action<ArraySegment<float>> NEDFJOJDIHF)
		{
			return default(DDJCJEBHGAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76FA110", Offset = "0x76F9510", VA = "0x1876FA110")]
		private DDJCJEBHGAF PMOBODHKPOA(int BJLOGCPKCDD, int COFHFMPLCMB, int CPPOIFDJJMB, Action<ArraySegment<float>> NEDFJOJDIHF)
		{
			return default(DDJCJEBHGAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76FA070", Offset = "0x76F9470", VA = "0x1876FA070", Slot = "8")]
		public void KJLMKNCJAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76FA500", Offset = "0x76F9900", VA = "0x1876FA500")]
		public JEDNMOPKMKP(MMDevice DEKHJDOLHMH, bool FCIKGHIJIGC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JEDNMOPKMKP> HKCHLEOJEIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JAEOJMMDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76FA550", Offset = "0x76F9950", VA = "0x1876FA550", Slot = "5")]
	public IReadOnlyList<ACJCOKCBOND> FCBHFDNGDMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76FA870", Offset = "0x76F9C70", VA = "0x1876FA870")]
	public JNJILFEDFBJ()
	{
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
