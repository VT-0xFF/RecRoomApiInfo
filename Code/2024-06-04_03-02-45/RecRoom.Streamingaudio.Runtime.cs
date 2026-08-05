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
public interface ILMKOAMDGJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MDINIBEPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DMCAOIHDOPI> AOABDOGAKMM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DMCAOIHDOPI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DHCMDJCLOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLBKIFHJOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IBPLFDOOKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOHKHCBOHBL PMFEONPBBBK(Action<ArraySegment<float>> GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJDEMHCPOEF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EOHKHCBOHBL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NMOLDINEDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JOOPHCLFCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x248EF50", Offset = "0x248D750", VA = "0x18248EF50")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C84E60", Offset = "0x5C83660", VA = "0x185C84E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x718F9A0", Offset = "0x718E1A0", VA = "0x18718F9A0")]
	public EOHKHCBOHBL(int BOBFAJJEAIP, int PBOIMJJEDDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHGDAGKBNCN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ILMKOAMDGJC PIPIKCMFIBB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MDINIBEPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x718FAA0", Offset = "0x718E2A0", VA = "0x18718FAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x718FB10", Offset = "0x718E310", VA = "0x18718FB10")]
	static JHGDAGKBNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x718F9B0", Offset = "0x718E1B0", VA = "0x18718F9B0")]
	public static IReadOnlyList<DMCAOIHDOPI> AOABDOGAKMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MHMNCMCCBPP : ILMKOAMDGJC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EMLJABAKNNI : DMCAOIHDOPI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class APLABCLGCJF
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
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public APLABCLGCJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x718F340", Offset = "0x718DB40", VA = "0x18718F340")]
			internal void OMAOIOJMLBI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PLIGIFLBOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LLFHKGBFEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FBEFLOLGIDP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DHCMDJCLOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x718F4C0", Offset = "0x718DCC0", VA = "0x18718F4C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CLBKIFHJOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA28750", Offset = "0xA26F50", VA = "0x180A28750", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB02FA0", Offset = "0xB017A0", VA = "0x180B02FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IBPLFDOOKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE53AD0", Offset = "0xE522D0", VA = "0x180E53AD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x718F920", Offset = "0x718E120", VA = "0x18718F920", Slot = "7")]
		public EOHKHCBOHBL PMFEONPBBBK(Action<ArraySegment<float>> GLJPAFELCNE)
		{
			return default(EOHKHCBOHBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x718F560", Offset = "0x718DD60", VA = "0x18718F560")]
		private EOHKHCBOHBL PMFEONPBBBK(int BOBFAJJEAIP, int MLMAGAPACCG, int PBOIMJJEDDD, Action<ArraySegment<float>> GLJPAFELCNE)
		{
			return default(EOHKHCBOHBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x718F4E0", Offset = "0x718DCE0", VA = "0x18718F4E0", Slot = "8")]
		public void LJDEMHCPOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x718F950", Offset = "0x718E150", VA = "0x18718F950")]
		public EMLJABAKNNI(MMDevice PLIGIFLBOHK, bool GNHPIOLLJEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EMLJABAKNNI> HFDMPKIPNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MDINIBEPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x718FC00", Offset = "0x718E400", VA = "0x18718FC00", Slot = "5")]
	public IReadOnlyList<DMCAOIHDOPI> AOABDOGAKMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x718FF20", Offset = "0x718E720", VA = "0x18718FF20")]
	public MHMNCMCCBPP()
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
