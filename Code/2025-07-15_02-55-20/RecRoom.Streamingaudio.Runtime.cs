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
public interface CNJPNMHCKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FHGACLBGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CDIPICALCNJ> NPADBPNOMAF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDIPICALCNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BMCPEJAJHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AAMCKHNCEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IIKGBKAICHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLLDHKHEBCN HFIEGGJMHEC(Action<ArraySegment<float>> HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAFFLGAOGNA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JLLDHKHEBCN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LJLNFPHLBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MEFEAILOFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x815C8D0", Offset = "0x815B4D0", VA = "0x18815C8D0")]
	public JLLDHKHEBCN(int PAJDKCOCDIA, int MLLNAMJEKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBOBCGCEJDB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CNJPNMHCKPI IIELAAKJGNM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FHGACLBGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C72590", Offset = "0x8C71190", VA = "0x188C72590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C72700", Offset = "0x8C71300", VA = "0x188C72700")]
	static CBOBCGCEJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8C72610", Offset = "0x8C71210", VA = "0x188C72610")]
	public static IReadOnlyList<CDIPICALCNJ> NPADBPNOMAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CPIBDFIKAPL : CNJPNMHCKPI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class AKJEALBBEAC : CDIPICALCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ICHDFHJEKAK
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
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public ICHDFHJEKAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C72B90", Offset = "0x8C71790", VA = "0x188C72B90")]
			internal void LFFPCBBFBMJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IAFAJNHHEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DHHCPGNBHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LKNHDAKOHJA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BMCPEJAJHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8C720B0", Offset = "0x8C70CB0", VA = "0x188C720B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AAMCKHNCEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IIKGBKAICHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEA04B0", Offset = "0xE9F0B0", VA = "0x180EA04B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C72510", Offset = "0x8C71110", VA = "0x188C72510", Slot = "7")]
		public JLLDHKHEBCN HFIEGGJMHEC(Action<ArraySegment<float>> HFBNHPDLHHL)
		{
			return default(JLLDHKHEBCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C72150", Offset = "0x8C70D50", VA = "0x188C72150")]
		private JLLDHKHEBCN HFIEGGJMHEC(int PAJDKCOCDIA, int KGEJFFEBABM, int MLLNAMJEKJF, Action<ArraySegment<float>> HFBNHPDLHHL)
		{
			return default(JLLDHKHEBCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C720D0", Offset = "0x8C70CD0", VA = "0x188C720D0", Slot = "8")]
		public void EAFFLGAOGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C72540", Offset = "0x8C71140", VA = "0x188C72540")]
		public AKJEALBBEAC(MMDevice IAFAJNHHEAB, bool PPNKBHBILGL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<AKJEALBBEAC> OANFFHPDHOJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FHGACLBGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8C727F0", Offset = "0x8C713F0", VA = "0x188C727F0", Slot = "5")]
	public IReadOnlyList<CDIPICALCNJ> NPADBPNOMAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8C72B00", Offset = "0x8C71700", VA = "0x188C72B00")]
	public CPIBDFIKAPL()
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
