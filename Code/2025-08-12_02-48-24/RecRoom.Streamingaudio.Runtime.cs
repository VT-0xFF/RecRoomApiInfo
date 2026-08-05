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
public interface CNPJCGPJEDP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DCCCCNPNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FFINJDILCGP> OCLHPLPDIFN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FFINJDILCGP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LPOILJGJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IBIDAJJHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HMPGCPHMEHB CIANCDPNJDO(Action<ArraySegment<float>> GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFIEOMFAEOL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HMPGCPHMEHB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FCDMDGEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BBBMADAGCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84C37F0", Offset = "0x84C1DF0", VA = "0x1884C37F0")]
	public HMPGCPHMEHB(int LGGEJMJANBC, int FPJPLDGHLOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MOJAOCJOPCD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CNPJCGPJEDP DFMENEBFAHK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DCCCCNPNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC010", Offset = "0x8FEA610", VA = "0x188FEC010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8FEC180", Offset = "0x8FEA780", VA = "0x188FEC180")]
	static MOJAOCJOPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8FEC090", Offset = "0x8FEA690", VA = "0x188FEC090")]
	public static IReadOnlyList<FFINJDILCGP> OCLHPLPDIFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NDOJHDBJJHB : CNPJCGPJEDP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EBLEGIANHNN : FFINJDILCGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KICIKMLELFC
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
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public KICIKMLELFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBE90", Offset = "0x8FEA490", VA = "0x188FEBE90")]
			internal void OECLGLIKJHN(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NKPLOAOLDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JHBJMGDDEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MDMMPKFEBEN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KOEPNMMBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBE20", Offset = "0x8FEA420", VA = "0x188FEBE20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LPOILJGJNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IBIDAJJHOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF1A940", Offset = "0xF18F40", VA = "0x180F1A940", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB9B0", Offset = "0x8FE9FB0", VA = "0x188FEB9B0", Slot = "7")]
		public HMPGCPHMEHB CIANCDPNJDO(Action<ArraySegment<float>> GDMDDGECOJI)
		{
			return default(HMPGCPHMEHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB9E0", Offset = "0x8FE9FE0", VA = "0x188FEB9E0")]
		private HMPGCPHMEHB CIANCDPNJDO(int LGGEJMJANBC, int MMBGGFOFBAL, int FPJPLDGHLOG, Action<ArraySegment<float>> GDMDDGECOJI)
		{
			return default(HMPGCPHMEHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBDA0", Offset = "0x8FEA3A0", VA = "0x188FEBDA0", Slot = "8")]
		public void GFIEOMFAEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBE40", Offset = "0x8FEA440", VA = "0x188FEBE40")]
		public EBLEGIANHNN(MMDevice NKPLOAOLDAB, bool AOOELKAKPKI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EBLEGIANHNN> CBHOIFHMFGA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DCCCCNPNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8FEC270", Offset = "0x8FEA870", VA = "0x188FEC270", Slot = "5")]
	public IReadOnlyList<FFINJDILCGP> OCLHPLPDIFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8FEC590", Offset = "0x8FEAB90", VA = "0x188FEC590")]
	public NDOJHDBJJHB()
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
