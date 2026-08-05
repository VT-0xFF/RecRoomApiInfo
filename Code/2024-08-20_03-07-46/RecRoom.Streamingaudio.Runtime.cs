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
public interface BGKOLOGLHIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NJBNNOEDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BOIAGAKPIIJ> AJNKOKPCNMN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BOIAGAKPIIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AFJILKDEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GDNBJJHMGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AGHKKJCJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ILNBJHADKJI CLKJHLELMKA(Action<ArraySegment<float>> IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJDMLGABMNG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ILNBJHADKJI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CHMMLLNLFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NINPJIEPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x25ADC50", Offset = "0x25ACC50", VA = "0x1825ADC50")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D41F50", Offset = "0x5D40F50", VA = "0x185D41F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72E4450", Offset = "0x72E3450", VA = "0x1872E4450")]
	public ILNBJHADKJI(int BAEINIOONDM, int MCDADJKGKEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCCOPBMIMOB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BGKOLOGLHIC GCPNEJOPCKM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NJBNNOEDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72E3E00", Offset = "0x72E2E00", VA = "0x1872E3E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72E3E80", Offset = "0x72E2E80", VA = "0x1872E3E80")]
	static BCCOPBMIMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72E3D10", Offset = "0x72E2D10", VA = "0x1872E3D10")]
	public static IReadOnlyList<BOIAGAKPIIJ> AJNKOKPCNMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OHGPJOIMKHJ : BGKOLOGLHIC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HPKJPOICJAH : BOIAGAKPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OFMHABCBPCI
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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public OFMHABCBPCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72E4460", Offset = "0x72E3460", VA = "0x1872E4460")]
			internal void GJHLAOFJDKD(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AJDFIEPENGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BGLIIKIHCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource OLPHLAOFMMG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AFJILKDEOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72E43E0", Offset = "0x72E33E0", VA = "0x1872E43E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GDNBJJHMGHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC42BC0", Offset = "0xC41BC0", VA = "0x180C42BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AGHKKJCJHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF83DF0", Offset = "0xF82DF0", VA = "0x180F83DF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72E3FF0", Offset = "0x72E2FF0", VA = "0x1872E3FF0", Slot = "7")]
		public ILNBJHADKJI CLKJHLELMKA(Action<ArraySegment<float>> IPCEAEAAIHH)
		{
			return default(ILNBJHADKJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72E4020", Offset = "0x72E3020", VA = "0x1872E4020")]
		private ILNBJHADKJI CLKJHLELMKA(int BAEINIOONDM, int FBIHFGPKLHN, int MCDADJKGKEB, Action<ArraySegment<float>> IPCEAEAAIHH)
		{
			return default(ILNBJHADKJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72E3F70", Offset = "0x72E2F70", VA = "0x1872E3F70", Slot = "8")]
		public void BJDMLGABMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72E4400", Offset = "0x72E3400", VA = "0x1872E4400")]
		public HPKJPOICJAH(MMDevice AJDFIEPENGB, bool IOIJOEPFIHP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HPKJPOICJAH> PDPFIKBNACF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NJBNNOEDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72E45E0", Offset = "0x72E35E0", VA = "0x1872E45E0", Slot = "5")]
	public IReadOnlyList<BOIAGAKPIIJ> AJNKOKPCNMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72E4900", Offset = "0x72E3900", VA = "0x1872E4900")]
	public OHGPJOIMKHJ()
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
