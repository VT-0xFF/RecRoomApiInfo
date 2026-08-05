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
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA882B0", Offset = "0xA868B0", VA = "0x180A882B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OGGMEHJHKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x25421D0", Offset = "0x25407D0", VA = "0x1825421D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D29D20", VA = "0x185D2B720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72891A0", Offset = "0x72877A0", VA = "0x1872891A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7288B90", Offset = "0x7287190", VA = "0x187288B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7288D00", Offset = "0x7287300", VA = "0x187288D00")]
	static AJKJKCLFPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7288C10", Offset = "0x7287210", VA = "0x187288C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public NOOHDIIKAJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7289690", Offset = "0x7287C90", VA = "0x187289690")]
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
			[Cpp2IlInjected.Address(RVA = "0x72895A0", Offset = "0x7287BA0", VA = "0x1872895A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PIDLLKJEFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA774A0", Offset = "0xA75AA0", VA = "0x180A774A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB50", Offset = "0xB49150", VA = "0x180B4AB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PLAAGNBKOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEBA740", Offset = "0xEB8D40", VA = "0x180EBA740", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7289570", Offset = "0x7287B70", VA = "0x187289570", Slot = "7")]
		public HHCHGJOKCKG BDKEFEKOHMM(Action<ArraySegment<float>> AHJILKLLLDE)
		{
			return default(HHCHGJOKCKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72891B0", Offset = "0x72877B0", VA = "0x1872891B0")]
		private HHCHGJOKCKG BDKEFEKOHMM(int NPAKCDEDCID, int ONOBHMMOHMG, int COAKKGMLKJB, Action<ArraySegment<float>> AHJILKLLLDE)
		{
			return default(HHCHGJOKCKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72895C0", Offset = "0x7287BC0", VA = "0x1872895C0", Slot = "8")]
		public void OFAFAMHHKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7289640", Offset = "0x7287C40", VA = "0x187289640")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7288DF0", Offset = "0x72873F0", VA = "0x187288DF0", Slot = "5")]
	public IReadOnlyList<KKEBJBPJFNK> JEALDIANDGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7289110", Offset = "0x7287710", VA = "0x187289110")]
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
