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
public interface DGFGPAOGJIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOGDHKNLMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ALPFACGIBJO> CLADNBBHMKB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ALPFACGIBJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BHEJFIMICEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EKEOMNNPGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GIBGPFMEGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFKMNFEOGNK OPBPCODAFHM(Action<ArraySegment<float>> JHEAOCMILMA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDFCDLJLKCN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LFKMNFEOGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KHFAICODBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C3830", Offset = "0x5C2A30", VA = "0x1805C3830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7E0", Offset = "0x5E99E0", VA = "0x1805EA7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MGMPIGLLBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C3810", Offset = "0x5C2A10", VA = "0x1805C3810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEE6600", Offset = "0xEE5800", VA = "0x180EE6600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40BEC60", Offset = "0x40BDE60", VA = "0x1840BEC60")]
	public LFKMNFEOGNK(int DLHBOFAFJGP, int CAIGNJCKCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LENJCCNAHIF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DGFGPAOGJIE EPAMHEBGBOM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AOGDHKNLMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x40BEB50", Offset = "0x40BDD50", VA = "0x1840BEB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40BEBC0", Offset = "0x40BDDC0", VA = "0x1840BEBC0")]
	static LENJCCNAHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40BEA60", Offset = "0x40BDC60", VA = "0x1840BEA60")]
	public static IReadOnlyList<ALPFACGIBJO> CLADNBBHMKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JBMIKHLNDMJ : DGFGPAOGJIE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MHGPFKAEEOD : ALPFACGIBJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HBIKFPMLFKG
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
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public HBIKFPMLFKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x40BE5E0", Offset = "0x40BD7E0", VA = "0x1840BE5E0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice CBFHOBELKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NDAOLHIGECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FHHHHJEFJII;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BHEJFIMICEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x40BECD0", Offset = "0x40BDED0", VA = "0x1840BECD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EKEOMNNPGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x589D70", Offset = "0x588F70", VA = "0x180589D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6A04E0", Offset = "0x69F6E0", VA = "0x1806A04E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GIBGPFMEGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D50", Offset = "0x7F4F50", VA = "0x1807F5D50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40BEFD0", Offset = "0x40BE1D0", VA = "0x1840BEFD0", Slot = "7")]
		public LFKMNFEOGNK OPBPCODAFHM(Action<ArraySegment<float>> JHEAOCMILMA)
		{
			return default(LFKMNFEOGNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x40BECF0", Offset = "0x40BDEF0", VA = "0x1840BECF0")]
		private LFKMNFEOGNK OPBPCODAFHM(int DLHBOFAFJGP, int NHJHKPOOOEI, int CAIGNJCKCDG, Action<ArraySegment<float>> JHEAOCMILMA)
		{
			return default(LFKMNFEOGNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x40BEC70", Offset = "0x40BDE70", VA = "0x1840BEC70", Slot = "8")]
		public void EDFCDLJLKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x40BF000", Offset = "0x40BE200", VA = "0x1840BF000")]
		public MHGPFKAEEOD(MMDevice CBFHOBELKHD, bool HBNGKKKONOI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MHGPFKAEEOD> AGFNONAHALI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AOGDHKNLMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x449F60", Offset = "0x449160", VA = "0x180449F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x40BE760", Offset = "0x40BD960", VA = "0x1840BE760", Slot = "5")]
	public IReadOnlyList<ALPFACGIBJO> CLADNBBHMKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40BEA00", Offset = "0x40BDC00", VA = "0x1840BEA00")]
	public JBMIKHLNDMJ()
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
