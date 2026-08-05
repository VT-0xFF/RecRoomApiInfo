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
public interface NIFDHKDMKBE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IKGDPKFCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DFFHNMPPDPM> FDIELFLEELA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DFFHNMPPDPM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NEGLGEGOBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PAHDHOBFGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FNEJHKHLCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JAKKPBODJBA LLGPAMBOAME(Action<ArraySegment<float>> FPMNHFJNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLNKNOIDDPL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JAKKPBODJBA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JNGLCNMDMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x912370", Offset = "0x911570", VA = "0x180912370")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LMIKFANPLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2262750", Offset = "0x2261950", VA = "0x182262750")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x559D3B0", Offset = "0x559C5B0", VA = "0x18559D3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69B7420", Offset = "0x69B6620", VA = "0x1869B7420")]
	public JAKKPBODJBA(int OOOCGBIFJLB, int FMGKHCBNHBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IJKPDIODKNK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NIFDHKDMKBE KLIPKGBJMNF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IKGDPKFCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69B6E10", Offset = "0x69B6010", VA = "0x1869B6E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69B6F80", Offset = "0x69B6180", VA = "0x1869B6F80")]
	static IJKPDIODKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69B6E90", Offset = "0x69B6090", VA = "0x1869B6E90")]
	public static IReadOnlyList<DFFHNMPPDPM> FDIELFLEELA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IKDHPNMFJHD : NIFDHKDMKBE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MOABIAMIKME : DFFHNMPPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OLFBOKHLCKN
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
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public OLFBOKHLCKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69B7910", Offset = "0x69B6B10", VA = "0x1869B7910")]
			internal void CKHAJJNCIBH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice JPHIEEJFCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JBMHFLDAAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NCDJFIOHGCJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NEGLGEGOBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69B74B0", Offset = "0x69B66B0", VA = "0x1869B74B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PAHDHOBFGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x901D10", Offset = "0x900F10", VA = "0x180901D10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F15C0", Offset = "0x9F07C0", VA = "0x1809F15C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FNEJHKHLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD0C190", Offset = "0xD0B390", VA = "0x180D0C190", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69B7890", Offset = "0x69B6A90", VA = "0x1869B7890", Slot = "7")]
		public JAKKPBODJBA LLGPAMBOAME(Action<ArraySegment<float>> FPMNHFJNBFL)
		{
			return default(JAKKPBODJBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69B74D0", Offset = "0x69B66D0", VA = "0x1869B74D0")]
		private JAKKPBODJBA LLGPAMBOAME(int OOOCGBIFJLB, int FPEEMANCPEB, int FMGKHCBNHBE, Action<ArraySegment<float>> FPMNHFJNBFL)
		{
			return default(JAKKPBODJBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69B7430", Offset = "0x69B6630", VA = "0x1869B7430", Slot = "8")]
		public void FLNKNOIDDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69B78C0", Offset = "0x69B6AC0", VA = "0x1869B78C0")]
		public MOABIAMIKME(MMDevice JPHIEEJFCLA, bool JJLHBDDIFDK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MOABIAMIKME> BNOHJCBIOEN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IKGDPKFCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69B7070", Offset = "0x69B6270", VA = "0x1869B7070", Slot = "5")]
	public IReadOnlyList<DFFHNMPPDPM> FDIELFLEELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69B7390", Offset = "0x69B6590", VA = "0x1869B7390")]
	public IKDHPNMFJHD()
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
