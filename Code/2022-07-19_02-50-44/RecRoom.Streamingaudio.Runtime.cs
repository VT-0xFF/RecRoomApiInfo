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
public interface KHHBBGOMJEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MEJNEGAEHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EIBBJMGEBDJ> HGICBFODDBO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIBBJMGEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JLMGHJFOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DKPHCOCJNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KALEBLNBFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOIBJMIPGGJ NLGJLAADKBL(Action<ArraySegment<float>> ACDPINKOGPO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLJCPHIKMAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OOIBJMIPGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PGJNBGDEGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84B200", Offset = "0x84A200", VA = "0x18084B200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C57C0", Offset = "0x8C47C0", VA = "0x1808C57C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EENLCAHJGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E0", Offset = "0x84A1E0", VA = "0x18084B1E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89EFD0", Offset = "0x89DFD0", VA = "0x18089EFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x520EA90", Offset = "0x520DA90", VA = "0x18520EA90")]
	public OOIBJMIPGGJ(int BEDFJKAENDM, int IJFOFNGEDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HBPFCJGMHLK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KHHBBGOMJEH GIGHNPKJBKA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MEJNEGAEHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x520E700", Offset = "0x520D700", VA = "0x18520E700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x520E860", Offset = "0x520D860", VA = "0x18520E860")]
	static HBPFCJGMHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x520E770", Offset = "0x520D770", VA = "0x18520E770")]
	public static IReadOnlyList<EIBBJMGEBDJ> HGICBFODDBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKMCEKOIALF : KHHBBGOMJEH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ADGGJBJICOJ : EIBBJMGEBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NGBBAOAMPIL
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
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public NGBBAOAMPIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x520E910", Offset = "0x520D910", VA = "0x18520E910")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DKKAFPKGJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MIPOAPOFMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LNMIEFBIAGJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JLMGHJFOEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x520DF90", Offset = "0x520CF90", VA = "0x18520DF90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DKPHCOCJNKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x60D990", Offset = "0x60C990", VA = "0x18060D990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9DAE80", Offset = "0x9D9E80", VA = "0x1809DAE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KALEBLNBFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A54F0", Offset = "0x6A44F0", VA = "0x1806A54F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x520E2F0", Offset = "0x520D2F0", VA = "0x18520E2F0", Slot = "7")]
		public OOIBJMIPGGJ NLGJLAADKBL(Action<ArraySegment<float>> ACDPINKOGPO)
		{
			return default(OOIBJMIPGGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x520DFB0", Offset = "0x520CFB0", VA = "0x18520DFB0")]
		private OOIBJMIPGGJ NLGJLAADKBL(int BEDFJKAENDM, int HFMADAAMDPF, int IJFOFNGEDEB, Action<ArraySegment<float>> ACDPINKOGPO)
		{
			return default(OOIBJMIPGGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x520E320", Offset = "0x520D320", VA = "0x18520E320", Slot = "8")]
		public void NLJCPHIKMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x520E3A0", Offset = "0x520D3A0", VA = "0x18520E3A0")]
		public ADGGJBJICOJ(MMDevice DKKAFPKGJJI, bool JPLGEJEECEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ADGGJBJICOJ> OMBANDMEJLP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MEJNEGAEHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58CFE0", Offset = "0x58BFE0", VA = "0x18058CFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x520E3F0", Offset = "0x520D3F0", VA = "0x18520E3F0", Slot = "5")]
	public IReadOnlyList<EIBBJMGEBDJ> HGICBFODDBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x520E690", Offset = "0x520D690", VA = "0x18520E690")]
	public EKMCEKOIALF()
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
