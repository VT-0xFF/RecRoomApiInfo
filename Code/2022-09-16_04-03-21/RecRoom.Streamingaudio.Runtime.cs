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
public interface OACANOLLFNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JCBILFDCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CAMGIKHPCMN> AMIHNEOKEGH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CAMGIKHPCMN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OKPLMMNJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MKOGEPDFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MFLLKELCBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IKEMGAKONAM CPLPOBGJKOD(Action<ArraySegment<float>> LABDBOEIJFO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBIMBGIAPJG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IKEMGAKONAM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PFKELGOIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KDKEBONEJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x420DCF0", Offset = "0x420C4F0", VA = "0x18420DCF0")]
	public IKEMGAKONAM(int NFHMGGJOJOL, int EEMFAKKJBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FNLGGOGKLJD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OACANOLLFNM OIBGEKDPIEC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool JCBILFDCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x420D8C0", Offset = "0x420C0C0", VA = "0x18420D8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x420D930", Offset = "0x420C130", VA = "0x18420D930")]
	static FNLGGOGKLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x420D7D0", Offset = "0x420BFD0", VA = "0x18420D7D0")]
	public static IReadOnlyList<CAMGIKHPCMN> AMIHNEOKEGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IGLMOEKJKJJ : OACANOLLFNM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NBBILBLILJJ : CAMGIKHPCMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JAABBFFLGNJ
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
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public JAABBFFLGNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x420DD00", Offset = "0x420C500", VA = "0x18420DD00")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HMCCIPEMLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NFHIBMJNOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DEHKLAPCLGK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OKPLMMNJHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x420DE80", Offset = "0x420C680", VA = "0x18420DE80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MKOGEPDFPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7294F0", Offset = "0x727CF0", VA = "0x1807294F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x729510", Offset = "0x727D10", VA = "0x180729510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MFLLKELCBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D9540", Offset = "0x8D7D40", VA = "0x1808D9540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x420DEA0", Offset = "0x420C6A0", VA = "0x18420DEA0", Slot = "7")]
		public IKEMGAKONAM CPLPOBGJKOD(Action<ArraySegment<float>> LABDBOEIJFO)
		{
			return default(IKEMGAKONAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x420DED0", Offset = "0x420C6D0", VA = "0x18420DED0")]
		private IKEMGAKONAM CPLPOBGJKOD(int NFHMGGJOJOL, int OKBGKBPHLLK, int EEMFAKKJBMF, Action<ArraySegment<float>> LABDBOEIJFO)
		{
			return default(IKEMGAKONAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x420E210", Offset = "0x420CA10", VA = "0x18420E210", Slot = "8")]
		public void LBIMBGIAPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x420E290", Offset = "0x420CA90", VA = "0x18420E290")]
		public NBBILBLILJJ(MMDevice HMCCIPEMLON, bool DCBPGIMNNAO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NBBILBLILJJ> GACNBGMPNLB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JCBILFDCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x420D9E0", Offset = "0x420C1E0", VA = "0x18420D9E0", Slot = "5")]
	public IReadOnlyList<CAMGIKHPCMN> AMIHNEOKEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x420DC80", Offset = "0x420C480", VA = "0x18420DC80")]
	public IGLMOEKJKJJ()
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
