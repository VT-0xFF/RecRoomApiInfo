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
public interface OFKLDNIJFJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PHNLCFACHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PBLHAHKJEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IJICKIMCCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EMGHMGNHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIJCIJJDLPB ODJMCKFLDMG(Action<ArraySegment<float>> PDECDCHNHMC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAALCMDJKKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OIJCIJJDLPB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEBBGKMOCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86A070", Offset = "0x869470", VA = "0x18086A070")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x869F80", Offset = "0x869380", VA = "0x180869F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KAIINFAFBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20A07C0", Offset = "0x209FBC0", VA = "0x1820A07C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5304080", Offset = "0x5303480", VA = "0x185304080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x652DED0", Offset = "0x652D2D0", VA = "0x18652DED0")]
	public OIJCIJJDLPB(int LEMOLEBOFBD, int IDHPMFCMABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAJFMILPDMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OFKLDNIJFJP CJKMCELIAHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x652D790", Offset = "0x652CB90", VA = "0x18652D790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x652D900", Offset = "0x652CD00", VA = "0x18652D900")]
	static NAJFMILPDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x652D810", Offset = "0x652CC10", VA = "0x18652D810")]
	public static IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFAFDMBPFCH : OFKLDNIJFJP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OGJLEJKMBPG : PHNLCFACHBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IAHBGNOKLIF
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
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public IAHBGNOKLIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x652D260", Offset = "0x652C660", VA = "0x18652D260")]
			internal void CHFMHLKHMMK(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NDEHNPGLDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MJANIEAPNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BDAJFJCALHA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PBLHAHKJEEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x652DE60", Offset = "0x652D260", VA = "0x18652DE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IJICKIMCCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x857210", Offset = "0x856610", VA = "0x180857210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90CBE0", Offset = "0x90BFE0", VA = "0x18090CBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EMGHMGNHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC47210", Offset = "0xC46610", VA = "0x180C47210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x652DA70", Offset = "0x652CE70", VA = "0x18652DA70", Slot = "7")]
		public OIJCIJJDLPB ODJMCKFLDMG(Action<ArraySegment<float>> PDECDCHNHMC)
		{
			return default(OIJCIJJDLPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x652DAA0", Offset = "0x652CEA0", VA = "0x18652DAA0")]
		private OIJCIJJDLPB ODJMCKFLDMG(int LEMOLEBOFBD, int PCNCBONBEOO, int IDHPMFCMABO, Action<ArraySegment<float>> PDECDCHNHMC)
		{
			return default(OIJCIJJDLPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x652D9F0", Offset = "0x652CDF0", VA = "0x18652D9F0", Slot = "8")]
		public void KAALCMDJKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x652DE80", Offset = "0x652D280", VA = "0x18652DE80")]
		public OGJLEJKMBPG(MMDevice NDEHNPGLDKG, bool BGPCOHMIPJP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OGJLEJKMBPG> EKPFHFKMDLO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x652D3E0", Offset = "0x652C7E0", VA = "0x18652D3E0", Slot = "5")]
	public IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x652D700", Offset = "0x652CB00", VA = "0x18652D700")]
	public KFAFDMBPFCH()
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
