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
		[Cpp2IlInjected.Address(RVA = "0x56FB50", Offset = "0x56ED50", VA = "0x18056FB50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x56FC70", Offset = "0x56EE70", VA = "0x18056FC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MGMPIGLLBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66FFC0", Offset = "0x66F1C0", VA = "0x18066FFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDCBD70", Offset = "0xDCAF70", VA = "0x180DCBD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xDCBD80", Offset = "0xDCAF80", VA = "0x180DCBD80")]
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
		[Cpp2IlInjected.Address(RVA = "0xDCBC60", Offset = "0xDCAE60", VA = "0x180DCBC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xDCBCD0", Offset = "0xDCAED0", VA = "0x180DCBCD0")]
	static LENJCCNAHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xDCBB70", Offset = "0xDCAD70", VA = "0x180DCBB70")]
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
			[Cpp2IlInjected.Address(RVA = "0xDCB6F0", Offset = "0xDCA8F0", VA = "0x180DCB6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDCBDF0", Offset = "0xDCAFF0", VA = "0x180DCBDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EKEOMNNPGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x641ED0", Offset = "0x6410D0", VA = "0x180641ED0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x641EB0", Offset = "0x6410B0", VA = "0x180641EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GIBGPFMEGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x983E20", Offset = "0x983020", VA = "0x180983E20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDCC0F0", Offset = "0xDCB2F0", VA = "0x180DCC0F0", Slot = "7")]
		public LFKMNFEOGNK OPBPCODAFHM(Action<ArraySegment<float>> JHEAOCMILMA)
		{
			return default(LFKMNFEOGNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDCBE10", Offset = "0xDCB010", VA = "0x180DCBE10")]
		private LFKMNFEOGNK OPBPCODAFHM(int DLHBOFAFJGP, int NHJHKPOOOEI, int CAIGNJCKCDG, Action<ArraySegment<float>> JHEAOCMILMA)
		{
			return default(LFKMNFEOGNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDCBD90", Offset = "0xDCAF90", VA = "0x180DCBD90", Slot = "8")]
		public void EDFCDLJLKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xDCC120", Offset = "0xDCB320", VA = "0x180DCC120")]
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
	[Cpp2IlInjected.Address(RVA = "0xDCB870", Offset = "0xDCAA70", VA = "0x180DCB870", Slot = "5")]
	public IReadOnlyList<ALPFACGIBJO> CLADNBBHMKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xDCBB10", Offset = "0xDCAD10", VA = "0x180DCBB10")]
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
