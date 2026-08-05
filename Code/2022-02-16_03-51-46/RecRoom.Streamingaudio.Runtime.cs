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
public interface IBCBJONBKKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GDFOHICGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IHKCPJDDCNB> HLHAFNNAIHN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHKCPJDDCNB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FNKNOPKOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FPILMKDBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EOCLEADJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FMNNAICBDBG AABNKDDFJPD(Action<ArraySegment<float>> HIHNOBNGGBK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POBAMHNBFNE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FMNNAICBDBG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CPFNANBEHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BBBC0", Offset = "0x5BA3C0", VA = "0x1805BBBC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B10", Offset = "0x6D0310", VA = "0x1806D1B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FCOBIHJAEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC44C30", Offset = "0xC43430", VA = "0x180C44C30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD8EBF0", Offset = "0xD8D3F0", VA = "0x180D8EBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1BBD8D0", Offset = "0x1BBC0D0", VA = "0x181BBD8D0")]
	public FMNNAICBDBG(int EIHNEBOBLMN, int MIIAKNMAMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FNEGGFBGJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IBCBJONBKKM APBIGPOLFPF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GDFOHICGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1BBD8E0", Offset = "0x1BBC0E0", VA = "0x181BBD8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1BBDA40", Offset = "0x1BBC240", VA = "0x181BBDA40")]
	static FNEGGFBGJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1BBD950", Offset = "0x1BBC150", VA = "0x181BBD950")]
	public static IReadOnlyList<IHKCPJDDCNB> HLHAFNNAIHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EALILABEJAJ : IBCBJONBKKM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NKPJMFGLEIG : IHKCPJDDCNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JJLFKOOCEBN
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
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public JJLFKOOCEBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1BBDAF0", Offset = "0x1BBC2F0", VA = "0x181BBDAF0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BGNLHBNMHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LFJOFELAJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HGCBNPNKFED;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FNKNOPKOMIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1BBDFE0", Offset = "0x1BBC7E0", VA = "0x181BBDFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FPILMKDBMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5E3200", Offset = "0x5E1A00", VA = "0x1805E3200", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5E3250", Offset = "0x5E1A50", VA = "0x1805E3250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EOCLEADJOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x715DD0", Offset = "0x7145D0", VA = "0x180715DD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1BBDFB0", Offset = "0x1BBC7B0", VA = "0x181BBDFB0", Slot = "7")]
		public FMNNAICBDBG AABNKDDFJPD(Action<ArraySegment<float>> HIHNOBNGGBK)
		{
			return default(FMNNAICBDBG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1BBDC70", Offset = "0x1BBC470", VA = "0x181BBDC70")]
		private FMNNAICBDBG AABNKDDFJPD(int EIHNEBOBLMN, int MPEALNGBKCD, int MIIAKNMAMFI, Action<ArraySegment<float>> HIHNOBNGGBK)
		{
			return default(FMNNAICBDBG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE000", Offset = "0x1BBC800", VA = "0x181BBE000", Slot = "8")]
		public void POBAMHNBFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE080", Offset = "0x1BBC880", VA = "0x181BBE080")]
		public NKPJMFGLEIG(MMDevice BGNLHBNMHEP, bool HDAPAJPOJHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NKPJMFGLEIG> MPLKMOLNLOI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GDFOHICGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x52F9B0", Offset = "0x52E1B0", VA = "0x18052F9B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1BBD5C0", Offset = "0x1BBBDC0", VA = "0x181BBD5C0", Slot = "5")]
	public IReadOnlyList<IHKCPJDDCNB> HLHAFNNAIHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1BBD860", Offset = "0x1BBC060", VA = "0x181BBD860")]
	public EALILABEJAJ()
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
