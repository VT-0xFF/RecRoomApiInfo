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
public interface OBOEMJGBFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MOJNHDHPCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MBNIKPBOBMA> GHAPLLKIOAC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MBNIKPBOBMA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string EOBMKMINNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MGPFEDAEECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AEIDJBALDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCLHDPBIIAH CDMEBBKBIMP(Action<ArraySegment<float>> PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHDEDLNBGKO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JCLHDPBIIAH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HIDFOECIJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DENCFJOENFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7969080", Offset = "0x7967A80", VA = "0x187969080")]
	public JCLHDPBIIAH(int JCHMNBDCKPH, int MPBLIMDGHKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MEOBAJEDCPI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OBOEMJGBFDI DDDAPFOHBFK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MOJNHDHPCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83A0320", Offset = "0x839ED20", VA = "0x1883A0320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83A0480", Offset = "0x839EE80", VA = "0x1883A0480")]
	static MEOBAJEDCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83A0390", Offset = "0x839ED90", VA = "0x1883A0390")]
	public static IReadOnlyList<MBNIKPBOBMA> GHAPLLKIOAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFDCHFMJOML : OBOEMJGBFDI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ADOGFLPPAJF : MBNIKPBOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EDIFBOADBNK
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
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public EDIFBOADBNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x839FDF0", Offset = "0x839E7F0", VA = "0x18839FDF0")]
			internal void JEKHOOAPJNP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BFJKKJBMABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DIEAAENDKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JDILBPFNHHL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EOBMKMINNFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x839FD80", Offset = "0x839E780", VA = "0x18839FD80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MGPFEDAEECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA31440", Offset = "0xA2FE40", VA = "0x180A31440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AEIDJBALDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11600", Offset = "0xD10000", VA = "0x180D11600", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x839FD50", Offset = "0x839E750", VA = "0x18839FD50", Slot = "7")]
		public JCLHDPBIIAH CDMEBBKBIMP(Action<ArraySegment<float>> PCKPGHHEKOC)
		{
			return default(JCLHDPBIIAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x839F990", Offset = "0x839E390", VA = "0x18839F990")]
		private JCLHDPBIIAH CDMEBBKBIMP(int JCHMNBDCKPH, int NKMDHMLPDLH, int MPBLIMDGHKN, Action<ArraySegment<float>> PCKPGHHEKOC)
		{
			return default(JCLHDPBIIAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x839F910", Offset = "0x839E310", VA = "0x18839F910", Slot = "8")]
		public void AHDEDLNBGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x839FDA0", Offset = "0x839E7A0", VA = "0x18839FDA0")]
		public ADOGFLPPAJF(MMDevice BFJKKJBMABO, bool OIOANLKKCKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ADOGFLPPAJF> DCGFHJOIDIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MOJNHDHPCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x839FF70", Offset = "0x839E970", VA = "0x18839FF70", Slot = "5")]
	public IReadOnlyList<MBNIKPBOBMA> GHAPLLKIOAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83A0290", Offset = "0x839EC90", VA = "0x1883A0290")]
	public KFDCHFMJOML()
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
