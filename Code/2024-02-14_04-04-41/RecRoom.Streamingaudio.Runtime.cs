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
public interface FCADPBHGBKI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LPAJIBNIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EOILCCKDDLM> CMPLKLKBNBK();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EOILCCKDDLM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MIDBIBPCHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FLGOLGAPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NCDIDPAGKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MPMDGMGCBPB KDPIEAFFAAP(Action<ArraySegment<float>> DBIEPHLOFKD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFAMBGAADBF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MPMDGMGCBPB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CMFDDBINNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JFELEKEONEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21C5940", Offset = "0x21C4D40", VA = "0x1821C5940")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x53B9360", Offset = "0x53B8760", VA = "0x1853B9360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x663E940", Offset = "0x663DD40", VA = "0x18663E940")]
	public MPMDGMGCBPB(int GBBAMCDMFOE, int BHECBANMAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JMIFBJBOJJC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FCADPBHGBKI DCHMPFMFNBP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LPAJIBNIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x663E7D0", Offset = "0x663DBD0", VA = "0x18663E7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x663E850", Offset = "0x663DC50", VA = "0x18663E850")]
	static JMIFBJBOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x663E6E0", Offset = "0x663DAE0", VA = "0x18663E6E0")]
	public static IReadOnlyList<EOILCCKDDLM> CMPLKLKBNBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CAIKDEFIBLC : FCADPBHGBKI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BHFCINEAHOI : EOILCCKDDLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FDMMPMCKGIP
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
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public FDMMPMCKGIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x663E560", Offset = "0x663D960", VA = "0x18663E560")]
			internal void KBBFBKKIAMF(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PAMKCOALEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NOHMLINOIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BHHFDEOGLPI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MIDBIBPCHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x663DCD0", Offset = "0x663D0D0", VA = "0x18663DCD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FLGOLGAPODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87A940", Offset = "0x879D40", VA = "0x18087A940", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x934E80", Offset = "0x934280", VA = "0x180934E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NCDIDPAGKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC8D770", Offset = "0xC8CB70", VA = "0x180C8D770", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x663E130", Offset = "0x663D530", VA = "0x18663E130", Slot = "7")]
		public MPMDGMGCBPB KDPIEAFFAAP(Action<ArraySegment<float>> DBIEPHLOFKD)
		{
			return default(MPMDGMGCBPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x663DD70", Offset = "0x663D170", VA = "0x18663DD70")]
		private MPMDGMGCBPB KDPIEAFFAAP(int GBBAMCDMFOE, int GGAIKCNLCGP, int BHECBANMAPL, Action<ArraySegment<float>> DBIEPHLOFKD)
		{
			return default(MPMDGMGCBPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x663DCF0", Offset = "0x663D0F0", VA = "0x18663DCF0", Slot = "8")]
		public void CFAMBGAADBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x663E160", Offset = "0x663D560", VA = "0x18663E160")]
		public BHFCINEAHOI(MMDevice PAMKCOALEHO, bool GDOIJOPMDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<BHFCINEAHOI> NNHPGBKGHHO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LPAJIBNIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x663E1B0", Offset = "0x663D5B0", VA = "0x18663E1B0", Slot = "5")]
	public IReadOnlyList<EOILCCKDDLM> CMPLKLKBNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x663E4D0", Offset = "0x663D8D0", VA = "0x18663E4D0")]
	public CAIKDEFIBLC()
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
