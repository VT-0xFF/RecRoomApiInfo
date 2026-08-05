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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A910", VA = "0x180A7BF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DMFBBJIGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A490", VA = "0x18255BA90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B30", Offset = "0x5CA8530", VA = "0x185CA9B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x722FC90", Offset = "0x722E690", VA = "0x18722FC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x722F110", Offset = "0x722DB10", VA = "0x18722F110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x722F190", Offset = "0x722DB90", VA = "0x18722F190")]
	static AOMICLPMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x722F020", Offset = "0x722DA20", VA = "0x18722F020")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public KACBJNKNDBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x722FB10", Offset = "0x722E510", VA = "0x18722FB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x722F280", Offset = "0x722DC80", VA = "0x18722F280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BMOBFIANEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BF60", VA = "0x180A6D560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB42340", Offset = "0xB40D40", VA = "0x180B42340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PDBDELLHKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEABF20", Offset = "0xEAA920", VA = "0x180EABF20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x722F2A0", Offset = "0x722DCA0", VA = "0x18722F2A0", Slot = "7")]
		public OAIMJDNDPKC KFFHNKNOKEI(Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x722F2D0", Offset = "0x722DCD0", VA = "0x18722F2D0")]
		private OAIMJDNDPKC KFFHNKNOKEI(int GFBMBHGLBKJ, int KPFHCEAAIKA, int PFCPOIMGOAD, Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x722F690", Offset = "0x722E090", VA = "0x18722F690", Slot = "8")]
		public void NOHFADIABOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x722F710", Offset = "0x722E110", VA = "0x18722F710")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x722F760", Offset = "0x722E160", VA = "0x18722F760", Slot = "5")]
	public IReadOnlyList<AIFBOHHBOHL> BMNMNFMEHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x722FA80", Offset = "0x722E480", VA = "0x18722FA80")]
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
