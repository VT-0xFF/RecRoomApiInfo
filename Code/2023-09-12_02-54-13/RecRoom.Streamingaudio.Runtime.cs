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
public class EOHKMMBDFPG : NIAAACCHGED
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class MBJJPCJNPKI : JJBNDDMCOHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class MKGFBCOIJPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public MKGFBCOIJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7223D00", Offset = "0x7223100", VA = "0x187223D00")]
			internal void BCNHDJFPPPD(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice KKIFHAGNHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture PADMCHBINFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource IMAONHNHNCI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string MODHFGFBPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7223C10", Offset = "0x7223010", VA = "0x187223C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool OMIHODEGGDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C78B0", VA = "0x1808C84B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KOGIOPKIHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB93430", Offset = "0xB92830", VA = "0x180B93430", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7223BE0", Offset = "0x7222FE0", VA = "0x187223BE0", Slot = "7")]
		public PHHODOMNGJO BENMMHNNJEE(Action<ArraySegment<float>> IPDGCBIIEII)
		{
			return default(PHHODOMNGJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7223840", Offset = "0x7222C40", VA = "0x187223840")]
		private PHHODOMNGJO BENMMHNNJEE(int ODIBJLIPICN, int EMIMOFFOLBA, int KKHDADKIDIF, Action<ArraySegment<float>> IPDGCBIIEII)
		{
			return default(PHHODOMNGJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7223C30", Offset = "0x7223030", VA = "0x187223C30", Slot = "8")]
		public void JADPMFJMBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7223CB0", Offset = "0x72230B0", VA = "0x187223CB0")]
		public MBJJPCJNPKI(MMDevice KKIFHAGNHJA, bool CNPFNOBLMHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<MBJJPCJNPKI> FIDKKOEJCHB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DIHDFJCFIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72232B0", Offset = "0x72226B0", VA = "0x1872232B0", Slot = "5")]
	public IReadOnlyList<JJBNDDMCOHG> MEGIPNAJFDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7223580", Offset = "0x7222980", VA = "0x187223580")]
	public EOHKMMBDFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NIAAACCHGED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DIHDFJCFIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JJBNDDMCOHG> MEGIPNAJFDD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JJBNDDMCOHG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MODHFGFBPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OMIHODEGGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KOGIOPKIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHHODOMNGJO BENMMHNNJEE(Action<ArraySegment<float>> IPDGCBIIEII);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JADPMFJMBIE();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PHHODOMNGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GAIODLGKMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EMHHDCLICIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7223E90", Offset = "0x7223290", VA = "0x187223E90")]
	public PHHODOMNGJO(int ODIBJLIPICN, int KKHDADKIDIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EOIAKFBFMFG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static NIAAACCHGED HBKPHPNEIAN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool DIHDFJCFIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72236F0", Offset = "0x7222AF0", VA = "0x1872236F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7223770", Offset = "0x7222B70", VA = "0x187223770")]
	static EOIAKFBFMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7223600", Offset = "0x7222A00", VA = "0x187223600")]
	public static IReadOnlyList<JJBNDDMCOHG> MEGIPNAJFDD()
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
