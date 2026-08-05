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
public interface JDJKJPJNBPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BPGAFALDDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EPPKHLBMIDE> FKBKNLAKMDC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EPPKHLBMIDE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NCDEOLGHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EEPPFNPLBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NFEDBLDFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIEBFBMPEAH OLHMABOOJPC(Action<ArraySegment<float>> JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCJCJEONABJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AIEBFBMPEAH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FAKBPBGCFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FBNKEMAEKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E246D0", Offset = "0x6E23AD0", VA = "0x186E246D0")]
	public AIEBFBMPEAH(int FDHJGCGMGHD, int ENGDADOBEGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BABKAGJKIOC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JDJKJPJNBPC JJICPFNLBJH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BPGAFALDDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7770430", Offset = "0x776F830", VA = "0x187770430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77704A0", Offset = "0x776F8A0", VA = "0x1877704A0")]
	static BABKAGJKIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7770340", Offset = "0x776F740", VA = "0x187770340")]
	public static IReadOnlyList<EPPKHLBMIDE> FKBKNLAKMDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DNKJJNEOONN : JDJKJPJNBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ELLELGIOEMH : EPPKHLBMIDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JOEKCKJLCPM
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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JOEKCKJLCPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7770E20", Offset = "0x7770220", VA = "0x187770E20")]
			internal void FCGOGBJBLON(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BAHHBMFPPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OHNOBLNHBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HOCMMIGBECK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NCDEOLGHIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7770940", Offset = "0x776FD40", VA = "0x187770940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EEPPFNPLBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9439B0", Offset = "0x942DB0", VA = "0x1809439B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9438A0", Offset = "0x942CA0", VA = "0x1809438A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NFEDBLDFJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x116FF90", Offset = "0x116F390", VA = "0x18116FF90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7770D20", Offset = "0x7770120", VA = "0x187770D20", Slot = "7")]
		public AIEBFBMPEAH OLHMABOOJPC(Action<ArraySegment<float>> JMKLCPOKHHP)
		{
			return default(AIEBFBMPEAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7770960", Offset = "0x776FD60", VA = "0x187770960")]
		private AIEBFBMPEAH OLHMABOOJPC(int FDHJGCGMGHD, int DELCOODABCL, int ENGDADOBEGK, Action<ArraySegment<float>> JMKLCPOKHHP)
		{
			return default(AIEBFBMPEAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7770D50", Offset = "0x7770150", VA = "0x187770D50", Slot = "8")]
		public void PCJCJEONABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7770DD0", Offset = "0x77701D0", VA = "0x187770DD0")]
		public ELLELGIOEMH(MMDevice BAHHBMFPPBO, bool KLNLGCHLLDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ELLELGIOEMH> MGLPFJPJODA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BPGAFALDDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7770590", Offset = "0x776F990", VA = "0x187770590", Slot = "5")]
	public IReadOnlyList<EPPKHLBMIDE> FKBKNLAKMDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77708B0", Offset = "0x776FCB0", VA = "0x1877708B0")]
	public DNKJJNEOONN()
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
