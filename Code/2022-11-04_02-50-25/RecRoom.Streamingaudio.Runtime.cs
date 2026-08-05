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
public interface MMFPCCMAKIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BEBDDCAHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<INDAEJPMPGF> CPDKCPCKDKN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface INDAEJPMPGF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ACAFDBBHNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLAAEOIPGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FLFFBDJOFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHFMBPNCPAO LKHGPJMMAJF(Action<ArraySegment<float>> EGLKIOCIBPB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEJCPJMIMLK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IHFMBPNCPAO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FDBIOOLDFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HEIAKBEBION
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60062A0", Offset = "0x60056A0", VA = "0x1860062A0")]
	public IHFMBPNCPAO(int EHLOBFJMCAD, int OEHFHDACCFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JKKDKFCLIIN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MMFPCCMAKIJ EDOLNFCKPLC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BEBDDCAHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60063B0", Offset = "0x60057B0", VA = "0x1860063B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6006430", Offset = "0x6005830", VA = "0x186006430")]
	static JKKDKFCLIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60062B0", Offset = "0x60056B0", VA = "0x1860062B0")]
	public static IReadOnlyList<INDAEJPMPGF> CPDKCPCKDKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DOJJFMEACMJ : MMFPCCMAKIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NLLEGOFBEHI : INDAEJPMPGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HOLGHNDCPFA
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
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public HOLGHNDCPFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6006110", Offset = "0x6005510", VA = "0x186006110")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EKFJJNBCGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture CHOJDEACKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IFBPJMIPBCC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ACAFDBBHNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6006500", Offset = "0x6005900", VA = "0x186006500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CLAAEOIPGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x726570", VA = "0x180727170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FLFFBDJOFGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC60", Offset = "0x6AE060", VA = "0x1806AEC60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60065A0", Offset = "0x60059A0", VA = "0x1860065A0", Slot = "7")]
		public IHFMBPNCPAO LKHGPJMMAJF(Action<ArraySegment<float>> EGLKIOCIBPB)
		{
			return default(IHFMBPNCPAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60065D0", Offset = "0x60059D0", VA = "0x1860065D0")]
		private IHFMBPNCPAO LKHGPJMMAJF(int EHLOBFJMCAD, int CDCHOOHICDK, int OEHFHDACCFE, Action<ArraySegment<float>> EGLKIOCIBPB)
		{
			return default(IHFMBPNCPAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6006520", Offset = "0x6005920", VA = "0x186006520", Slot = "8")]
		public void HEJCPJMIMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6006970", Offset = "0x6005D70", VA = "0x186006970")]
		public NLLEGOFBEHI(MMDevice EKFJJNBCGBD, bool NNNPPDFAAII)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NLLEGOFBEHI> BEBGFIMBPAP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BEBDDCAHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6005DB0", Offset = "0x60051B0", VA = "0x186005DB0", Slot = "5")]
	public IReadOnlyList<INDAEJPMPGF> CPDKCPCKDKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6006090", Offset = "0x6005490", VA = "0x186006090")]
	public DOJJFMEACMJ()
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
