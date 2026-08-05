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
public interface PHEHBLGKMLI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GCLHIPBAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NOHJACCKGKJ> CGAHIFGMJIL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NOHJACCKGKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MBOLGOCFBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BIJILIEPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NEBGPCNLMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLFLAHDGPIE EDEFNKGHKAI(Action<ArraySegment<float>> AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MELPFIPJFGE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OLFLAHDGPIE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MAFDLLMGCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KLGPKLAJNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDECA0", Offset = "0x6BDD6A0", VA = "0x186BDECA0")]
	public OLFLAHDGPIE(int AOABILAGAGO, int EKHLINFMGKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KCCFFNDBCPL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PHEHBLGKMLI EEGCGGPDNON;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GCLHIPBAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7514E50", Offset = "0x7513850", VA = "0x187514E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7514EC0", Offset = "0x75138C0", VA = "0x187514EC0")]
	static KCCFFNDBCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7514D60", Offset = "0x7513760", VA = "0x187514D60")]
	public static IReadOnlyList<NOHJACCKGKJ> CGAHIFGMJIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AJOLCNNFAAK : PHEHBLGKMLI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NEFFNNFBCGO : NOHJACCKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class INNIAADBEKI
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
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public INNIAADBEKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7514BE0", Offset = "0x75135E0", VA = "0x187514BE0")]
			internal void AOFDMJFPMAO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LEMOECOAKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EMFPNOIFJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource KNFGHGKHNFN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MBOLGOCFBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7515420", Offset = "0x7513E20", VA = "0x187515420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BIJILIEPMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDA7090", Offset = "0xDA5A90", VA = "0x180DA7090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NEBGPCNLMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x10E3540", Offset = "0x10E1F40", VA = "0x1810E3540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7515370", Offset = "0x7513D70", VA = "0x187515370", Slot = "7")]
		public OLFLAHDGPIE EDEFNKGHKAI(Action<ArraySegment<float>> AGMLFHLAIFJ)
		{
			return default(OLFLAHDGPIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7514FB0", Offset = "0x75139B0", VA = "0x187514FB0")]
		private OLFLAHDGPIE EDEFNKGHKAI(int AOABILAGAGO, int LFIJHNLKHDD, int EKHLINFMGKJ, Action<ArraySegment<float>> AGMLFHLAIFJ)
		{
			return default(OLFLAHDGPIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75153A0", Offset = "0x7513DA0", VA = "0x1875153A0", Slot = "8")]
		public void MELPFIPJFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7515440", Offset = "0x7513E40", VA = "0x187515440")]
		public NEFFNNFBCGO(MMDevice LEMOECOAKFD, bool DBGDGBILCKE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NEFFNNFBCGO> DALHNFPIIJE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GCLHIPBAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7514830", Offset = "0x7513230", VA = "0x187514830", Slot = "5")]
	public IReadOnlyList<NOHJACCKGKJ> CGAHIFGMJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7514B50", Offset = "0x7513550", VA = "0x187514B50")]
	public AJOLCNNFAAK()
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
