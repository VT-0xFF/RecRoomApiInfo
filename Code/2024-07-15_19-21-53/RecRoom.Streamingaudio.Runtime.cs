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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DMFBBJIGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x722F280", Offset = "0x722DA80", VA = "0x18722F280")]
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
		[Cpp2IlInjected.Address(RVA = "0x722E700", Offset = "0x722CF00", VA = "0x18722E700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x722E780", Offset = "0x722CF80", VA = "0x18722E780")]
	static AOMICLPMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x722E610", Offset = "0x722CE10", VA = "0x18722E610")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public KACBJNKNDBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x722F100", Offset = "0x722D900", VA = "0x18722F100")]
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
			[Cpp2IlInjected.Address(RVA = "0x722E870", Offset = "0x722D070", VA = "0x18722E870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BMOBFIANEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BD60", VA = "0x180A6D560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB42340", Offset = "0xB40B40", VA = "0x180B42340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PDBDELLHKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEABF20", Offset = "0xEAA720", VA = "0x180EABF20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x722E890", Offset = "0x722D090", VA = "0x18722E890", Slot = "7")]
		public OAIMJDNDPKC KFFHNKNOKEI(Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x722E8C0", Offset = "0x722D0C0", VA = "0x18722E8C0")]
		private OAIMJDNDPKC KFFHNKNOKEI(int GFBMBHGLBKJ, int KPFHCEAAIKA, int PFCPOIMGOAD, Action<ArraySegment<float>> HBBMMHKOEKK)
		{
			return default(OAIMJDNDPKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x722EC80", Offset = "0x722D480", VA = "0x18722EC80", Slot = "8")]
		public void NOHFADIABOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x722ED00", Offset = "0x722D500", VA = "0x18722ED00")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x722ED50", Offset = "0x722D550", VA = "0x18722ED50", Slot = "5")]
	public IReadOnlyList<AIFBOHHBOHL> BMNMNFMEHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x722F070", Offset = "0x722D870", VA = "0x18722F070")]
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
