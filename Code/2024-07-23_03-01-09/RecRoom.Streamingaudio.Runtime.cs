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
public interface NELHHDIBFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PLJODFONKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<AIFBOHHBOHL> BMNMNFMEHEG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AIFBOHHBOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BKMLLKACEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BMOBFIANEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PDBDELLHKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OAIMJDNDPKC KFFHNKNOKEI(Action<ArraySegment<float>> HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOHFADIABOP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OAIMJDNDPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IPEEHADPODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DMFBBJIGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x256A860", Offset = "0x2569A60", VA = "0x18256A860")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1B20", Offset = "0x5CC0D20", VA = "0x185CC1B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7254D70", Offset = "0x7253F70", VA = "0x187254D70")]
	public OAIMJDNDPKC(int GFBMBHGLBKJ, int PFCPOIMGOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AOMICLPMPDO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NELHHDIBFMC INFEHJIACJG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PLJODFONKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72541F0", Offset = "0x72533F0", VA = "0x1872541F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7254270", Offset = "0x7253470", VA = "0x187254270")]
	static AOMICLPMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7254100", Offset = "0x7253300", VA = "0x187254100")]
	public static IReadOnlyList<AIFBOHHBOHL> BMNMNFMEHEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JMLJIEDJMJC : NELHHDIBFMC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FKOLAPNJLOK : AIFBOHHBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KACBJNKNDBP
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public KACBJNKNDBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7254BF0", Offset = "0x7253DF0", VA = "0x187254BF0")]
			internal void MIJFDFFOBAJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PLFBAPLNFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KNPMGCNGFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource OMKBOOGEKIH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BKMLLKACEBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7254360", Offset = "0x7253560", VA = "0x187254360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BMOBFIANEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA6E540", Offset = "0xA6D740", VA = "0x180A6E540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB43490", Offset = "0xB42690", VA = "0x180B43490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PDBDELLHKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEAD810", Offset = "0xEACA10", VA = "0x180EAD810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7254380", Offset = "0x7253580", VA = "0x187254380", Slot = "7")]
		public OAIMJDNDPKC KFFHNKNOKEI(Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72543B0", Offset = "0x72535B0", VA = "0x1872543B0")]
		private OAIMJDNDPKC KFFHNKNOKEI(int GFBMBHGLBKJ, int KPFHCEAAIKA, int PFCPOIMGOAD, Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7254770", Offset = "0x7253970", VA = "0x187254770", Slot = "8")]
		public void NOHFADIABOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72547F0", Offset = "0x72539F0", VA = "0x1872547F0")]
		public FKOLAPNJLOK(MMDevice PLFBAPLNFGO, bool NJLGOPGOHDF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FKOLAPNJLOK> DFMNKNCECDC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PLJODFONKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7254840", Offset = "0x7253A40", VA = "0x187254840", Slot = "5")]
	public IReadOnlyList<AIFBOHHBOHL> BMNMNFMEHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7254B60", Offset = "0x7253D60", VA = "0x187254B60")]
	public JMLJIEDJMJC()
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
