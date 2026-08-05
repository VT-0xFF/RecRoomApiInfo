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
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JFELEKEONEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x682BA90", Offset = "0x682A490", VA = "0x18682BA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x682B920", Offset = "0x682A320", VA = "0x18682B920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x682B9A0", Offset = "0x682A3A0", VA = "0x18682B9A0")]
	static JMIFBJBOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x682B830", Offset = "0x682A230", VA = "0x18682B830")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public FDMMPMCKGIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x682B6B0", Offset = "0x682A0B0", VA = "0x18682B6B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x682AE20", Offset = "0x6829820", VA = "0x18682AE20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FLGOLGAPODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x884340", Offset = "0x882D40", VA = "0x180884340", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x940540", Offset = "0x93EF40", VA = "0x180940540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NCDIDPAGKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC99B30", Offset = "0xC98530", VA = "0x180C99B30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x682B280", Offset = "0x6829C80", VA = "0x18682B280", Slot = "7")]
		public MPMDGMGCBPB KDPIEAFFAAP(Action<ArraySegment<float>> DBIEPHLOFKD)
		{
			return default(MPMDGMGCBPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x682AEC0", Offset = "0x68298C0", VA = "0x18682AEC0")]
		private MPMDGMGCBPB KDPIEAFFAAP(int GBBAMCDMFOE, int GGAIKCNLCGP, int BHECBANMAPL, Action<ArraySegment<float>> DBIEPHLOFKD)
		{
			return default(MPMDGMGCBPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x682AE40", Offset = "0x6829840", VA = "0x18682AE40", Slot = "8")]
		public void CFAMBGAADBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x682B2B0", Offset = "0x6829CB0", VA = "0x18682B2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x682B300", Offset = "0x6829D00", VA = "0x18682B300", Slot = "5")]
	public IReadOnlyList<EOILCCKDDLM> CMPLKLKBNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x682B620", Offset = "0x682A020", VA = "0x18682B620")]
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
