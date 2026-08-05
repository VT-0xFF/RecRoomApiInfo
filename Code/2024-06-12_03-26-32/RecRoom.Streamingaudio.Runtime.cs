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
public interface JNFMJMNJCOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GKNIAGFIMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HGIINELIPIK> OONJCKMFOLI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HGIINELIPIK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DKCABFIGINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ONNHKMIILFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HIDHLHIBLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJIHDFGFKBI PCPAOELDNGH(Action<ArraySegment<float>> LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEIEEMDEALN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJIHDFGFKBI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GFPFLIJPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KEGPECCLLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x251F470", Offset = "0x251E070", VA = "0x18251F470")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1680", Offset = "0x5CE0280", VA = "0x185CE1680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x721F0F0", Offset = "0x721DCF0", VA = "0x18721F0F0")]
	public NJIHDFGFKBI(int FJMMHKGJBBA, int BKDIDIBHBBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HADEMFNJAEM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JNFMJMNJCOM PDKKBNFMBEC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GKNIAGFIMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x721EAE0", Offset = "0x721D6E0", VA = "0x18721EAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x721EC50", Offset = "0x721D850", VA = "0x18721EC50")]
	static HADEMFNJAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x721EB60", Offset = "0x721D760", VA = "0x18721EB60")]
	public static IReadOnlyList<HGIINELIPIK> OONJCKMFOLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KNKCGEFDJIM : JNFMJMNJCOM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FOCMADFPJEC : HGIINELIPIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NPENMALCFLB
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
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public NPENMALCFLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x721F100", Offset = "0x721DD00", VA = "0x18721F100")]
			internal void BMGCFNMIAFI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OBEDPBPHHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HJCEDKAHGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NAPLHMNDNGH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DKCABFIGINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x721E600", Offset = "0x721D200", VA = "0x18721E600", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ONNHKMIILFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA53410", Offset = "0xA52010", VA = "0x180A53410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB30190", Offset = "0xB2ED90", VA = "0x180B30190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HIDHLHIBLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE81770", Offset = "0xE80370", VA = "0x180E81770", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x721E6A0", Offset = "0x721D2A0", VA = "0x18721E6A0", Slot = "7")]
		public NJIHDFGFKBI PCPAOELDNGH(Action<ArraySegment<float>> LHMNAJJOJLL)
		{
			return default(NJIHDFGFKBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x721E6D0", Offset = "0x721D2D0", VA = "0x18721E6D0")]
		private NJIHDFGFKBI PCPAOELDNGH(int FJMMHKGJBBA, int PINOCFANDPK, int BKDIDIBHBBN, Action<ArraySegment<float>> LHMNAJJOJLL)
		{
			return default(NJIHDFGFKBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x721E620", Offset = "0x721D220", VA = "0x18721E620", Slot = "8")]
		public void LEIEEMDEALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x721EA90", Offset = "0x721D690", VA = "0x18721EA90")]
		public FOCMADFPJEC(MMDevice OBEDPBPHHKG, bool PAOJFDIGCCI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FOCMADFPJEC> IAPCDKKNEEC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GKNIAGFIMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x721ED40", Offset = "0x721D940", VA = "0x18721ED40", Slot = "5")]
	public IReadOnlyList<HGIINELIPIK> OONJCKMFOLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x721F060", Offset = "0x721DC60", VA = "0x18721F060")]
	public KNKCGEFDJIM()
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
