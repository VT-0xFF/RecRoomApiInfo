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
public interface MCCDODODAAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MDFLCFDOBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PBNHCOLFHKK> CMNALFFAEAB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PBNHCOLFHKK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MDADLGCDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LDDBNEIDCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OCPNAKNPJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJMMBMANNNL MDLLAHNENHP(Action<ArraySegment<float>> NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBPAPLCPBNK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJMMBMANNNL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PMNNBKADPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGPCIGFFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C96110", Offset = "0x6C94D10", VA = "0x186C96110")]
	public NJMMBMANNNL(int BDMEBODCMBJ, int CDECBBKFDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DAGPDPFLHII
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MCCDODODAAM BJLEJGMIJDA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MDFLCFDOBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x760AA40", Offset = "0x7609640", VA = "0x18760AA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x760ABA0", Offset = "0x76097A0", VA = "0x18760ABA0")]
	static DAGPDPFLHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x760AAB0", Offset = "0x76096B0", VA = "0x18760AAB0")]
	public static IReadOnlyList<PBNHCOLFHKK> CMNALFFAEAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DEKBLKMEAIH : MCCDODODAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DEJMBLAEGEF : PBNHCOLFHKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CGFODFEBPMB
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
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CGFODFEBPMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x760A8C0", Offset = "0x76094C0", VA = "0x18760A8C0")]
			internal void NLIFGMAHKBI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IMPNBHGKOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OCJLCGHJKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JLIPMNCDODJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MDADLGCDEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x760AC90", Offset = "0x7609890", VA = "0x18760AC90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LDDBNEIDCJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OCPNAKNPJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x108C5B0", Offset = "0x108B1B0", VA = "0x18108C5B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x760B070", Offset = "0x7609C70", VA = "0x18760B070", Slot = "7")]
		public NJMMBMANNNL MDLLAHNENHP(Action<ArraySegment<float>> NNGDIBHFMBF)
		{
			return default(NJMMBMANNNL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x760ACB0", Offset = "0x76098B0", VA = "0x18760ACB0")]
		private NJMMBMANNNL MDLLAHNENHP(int BDMEBODCMBJ, int HBMFPOCOEJG, int CDECBBKFDMP, Action<ArraySegment<float>> NNGDIBHFMBF)
		{
			return default(NJMMBMANNNL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x760B0A0", Offset = "0x7609CA0", VA = "0x18760B0A0", Slot = "8")]
		public void OBPAPLCPBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x760B120", Offset = "0x7609D20", VA = "0x18760B120")]
		public DEJMBLAEGEF(MMDevice IMPNBHGKOFC, bool AOENOGELONA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DEJMBLAEGEF> DLCDJEIKNGD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MDFLCFDOBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x760B170", Offset = "0x7609D70", VA = "0x18760B170", Slot = "5")]
	public IReadOnlyList<PBNHCOLFHKK> CMNALFFAEAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x760B490", Offset = "0x760A090", VA = "0x18760B490")]
	public DEKBLKMEAIH()
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
