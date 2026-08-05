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
public interface BLHAOIDEIAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OMIKPIOILNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BDGKLIPFKCG> DBDFKDNLBJF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BDGKLIPFKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BMEHLGDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LAOMDIFLIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LJJHNKKJBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DEJMHLCIKGD LHCIAOCPFGL(Action<ArraySegment<float>> JNDJHGKPENH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENDJFCENDKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DEJMHLCIKGD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GBNPHEOFLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OIKHPADDIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C168B0", Offset = "0x6C152B0", VA = "0x186C168B0")]
	public DEJMHLCIKGD(int EEOLDANGEIL, int PIMGBEKHBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IMLIPBKHCPM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BLHAOIDEIAJ NDOHCFNDAAO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OMIKPIOILNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C16C60", Offset = "0x6C15660", VA = "0x186C16C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C16DD0", Offset = "0x6C157D0", VA = "0x186C16DD0")]
	static IMLIPBKHCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C16CE0", Offset = "0x6C156E0", VA = "0x186C16CE0")]
	public static IReadOnlyList<BDGKLIPFKCG> DBDFKDNLBJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GNNBEFCOOJM : BLHAOIDEIAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MFINKBGPKKP : BDGKLIPFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JOGBFCMPMIA
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
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public JOGBFCMPMIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C16EC0", Offset = "0x6C158C0", VA = "0x186C16EC0")]
			internal void LOKMABFJNAL(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FECJHOBPNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DMFPOHHGNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LPDPKOLACHE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BMEHLGDELKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C170C0", Offset = "0x6C15AC0", VA = "0x186C170C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LAOMDIFLIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9184F0", Offset = "0x916EF0", VA = "0x1809184F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA0DBE0", Offset = "0xA0C5E0", VA = "0x180A0DBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LJJHNKKJBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD39550", Offset = "0xD37F50", VA = "0x180D39550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C174A0", Offset = "0x6C15EA0", VA = "0x186C174A0", Slot = "7")]
		public DEJMHLCIKGD LHCIAOCPFGL(Action<ArraySegment<float>> JNDJHGKPENH)
		{
			return default(DEJMHLCIKGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C170E0", Offset = "0x6C15AE0", VA = "0x186C170E0")]
		private DEJMHLCIKGD LHCIAOCPFGL(int EEOLDANGEIL, int CONHMCEDNLI, int PIMGBEKHBDP, Action<ArraySegment<float>> JNDJHGKPENH)
		{
			return default(DEJMHLCIKGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C17040", Offset = "0x6C15A40", VA = "0x186C17040", Slot = "8")]
		public void ENDJFCENDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C174D0", Offset = "0x6C15ED0", VA = "0x186C174D0")]
		public MFINKBGPKKP(MMDevice FECJHOBPNBO, bool JJFBJOCEBBF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MFINKBGPKKP> IDCECHOHOLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OMIKPIOILNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C168C0", Offset = "0x6C152C0", VA = "0x186C168C0", Slot = "5")]
	public IReadOnlyList<BDGKLIPFKCG> DBDFKDNLBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C16BD0", Offset = "0x6C155D0", VA = "0x186C16BD0")]
	public GNNBEFCOOJM()
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
