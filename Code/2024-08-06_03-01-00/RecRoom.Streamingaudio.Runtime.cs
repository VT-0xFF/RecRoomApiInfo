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
public interface AKMPIIBBLCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AIAEBGJKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KCFGKDDFPAP> KBEGGBGIDBB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KCFGKDDFPAP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MOCPHNBJHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DOMLAMOCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LMACIIDHJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMKCIIPOPDD KJADNEIEEAD(Action<ArraySegment<float>> MAPPKFKPMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPFHBNJDDOL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AMKCIIPOPDD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HCPIAPPADJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC10", Offset = "0xB5D210", VA = "0x180B5EC10")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HKGAHHHIBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2587140", Offset = "0x2585740", VA = "0x182587140")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D948D0", Offset = "0x5D92ED0", VA = "0x185D948D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72FFB40", Offset = "0x72FE140", VA = "0x1872FFB40")]
	public AMKCIIPOPDD(int LOJAJKODLKE, int PDMEEDIFIPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ABAPLJDKJLH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static AKMPIIBBLCJ KFPNPFEKAIL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AIAEBGJKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72FF8F0", Offset = "0x72FDEF0", VA = "0x1872FF8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72FFA50", Offset = "0x72FE050", VA = "0x1872FFA50")]
	static ABAPLJDKJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72FF960", Offset = "0x72FDF60", VA = "0x1872FF960")]
	public static IReadOnlyList<KCFGKDDFPAP> KBEGGBGIDBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EMNJFKIPEDA : AKMPIIBBLCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FFPAILOACME : KCFGKDDFPAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DGONNHFKIJN
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
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public DGONNHFKIJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72FFB50", Offset = "0x72FE150", VA = "0x1872FFB50")]
			internal void ICNLPGOEJNK(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GILPFHAMJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ECJCFKCMHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource OKJCKHOELKC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MOCPHNBJHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7300080", Offset = "0x72FE680", VA = "0x187300080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DOMLAMOCCNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB4FA90", Offset = "0xB4E090", VA = "0x180B4FA90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC419D0", Offset = "0xC3FFD0", VA = "0x180C419D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LMACIIDHJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF7E6B0", Offset = "0xF7CCB0", VA = "0x180F7E6B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x73000A0", Offset = "0x72FE6A0", VA = "0x1873000A0", Slot = "7")]
		public AMKCIIPOPDD KJADNEIEEAD(Action<ArraySegment<float>> MAPPKFKPMBJ)
		{
			return default(AMKCIIPOPDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73000D0", Offset = "0x72FE6D0", VA = "0x1873000D0")]
		private AMKCIIPOPDD KJADNEIEEAD(int LOJAJKODLKE, int HDDKADFHLOM, int PDMEEDIFIPG, Action<ArraySegment<float>> MAPPKFKPMBJ)
		{
			return default(AMKCIIPOPDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7300490", Offset = "0x72FEA90", VA = "0x187300490", Slot = "8")]
		public void KPFHBNJDDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7300510", Offset = "0x72FEB10", VA = "0x187300510")]
		public FFPAILOACME(MMDevice GILPFHAMJPE, bool ADLOECEHFHO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FFPAILOACME> GAHOOIEKBPK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AIAEBGJKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72FFCD0", Offset = "0x72FE2D0", VA = "0x1872FFCD0", Slot = "5")]
	public IReadOnlyList<KCFGKDDFPAP> KBEGGBGIDBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72FFFF0", Offset = "0x72FE5F0", VA = "0x1872FFFF0")]
	public EMNJFKIPEDA()
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
