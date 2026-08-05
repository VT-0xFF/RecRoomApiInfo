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
public interface GMMILPDDGJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GKOONABBAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KKEBJBPJFNK> JEALDIANDGA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KKEBJBPJFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BHHKKMMCCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PIDLLKJEFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PLAAGNBKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHCHGJOKCKG BDKEFEKOHMM(Action<ArraySegment<float>> AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFAFAMHHKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HHCHGJOKCKG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LOCCBGPFNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OGGMEHJHKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2550DE0", Offset = "0x254FDE0", VA = "0x182550DE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D54330", Offset = "0x5D53330", VA = "0x185D54330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72C05F0", Offset = "0x72BF5F0", VA = "0x1872C05F0")]
	public HHCHGJOKCKG(int NPAKCDEDCID, int COAKKGMLKJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AJKJKCLFPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GMMILPDDGJJ IHNJICMAIFN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GKOONABBAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72BFFE0", Offset = "0x72BEFE0", VA = "0x1872BFFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72C0150", Offset = "0x72BF150", VA = "0x1872C0150")]
	static AJKJKCLFPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72C0060", Offset = "0x72BF060", VA = "0x1872C0060")]
	public static IReadOnlyList<KKEBJBPJFNK> JEALDIANDGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FHNNFEHGBGE : GMMILPDDGJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HMNGMEDLMLD : KKEBJBPJFNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NOOHDIIKAJG
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public NOOHDIIKAJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72C0AE0", Offset = "0x72BFAE0", VA = "0x1872C0AE0")]
			internal void PHGFMKFLFOK(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LCJGLKLKDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ECANINHCKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DIBFPIBIHKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BHHKKMMCCDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72C09F0", Offset = "0x72BF9F0", VA = "0x1872C09F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PIDLLKJEFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA7BEE0", Offset = "0xA7AEE0", VA = "0x180A7BEE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4F8C0", VA = "0x180B508C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PLAAGNBKOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEC1F20", Offset = "0xEC0F20", VA = "0x180EC1F20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72C09C0", Offset = "0x72BF9C0", VA = "0x1872C09C0", Slot = "7")]
		public HHCHGJOKCKG BDKEFEKOHMM(Action<ArraySegment<float>> AHJILKLLLDE)
		{
			return default(HHCHGJOKCKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72C0600", Offset = "0x72BF600", VA = "0x1872C0600")]
		private HHCHGJOKCKG BDKEFEKOHMM(int NPAKCDEDCID, int ONOBHMMOHMG, int COAKKGMLKJB, Action<ArraySegment<float>> AHJILKLLLDE)
		{
			return default(HHCHGJOKCKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72C0A10", Offset = "0x72BFA10", VA = "0x1872C0A10", Slot = "8")]
		public void OFAFAMHHKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72C0A90", Offset = "0x72BFA90", VA = "0x1872C0A90")]
		public HMNGMEDLMLD(MMDevice LCJGLKLKDGO, bool GOGKGKOFCDA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HMNGMEDLMLD> HHJNLHNKALB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GKOONABBAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72C0240", Offset = "0x72BF240", VA = "0x1872C0240", Slot = "5")]
	public IReadOnlyList<KKEBJBPJFNK> JEALDIANDGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72C0560", Offset = "0x72BF560", VA = "0x1872C0560")]
	public FHNNFEHGBGE()
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
