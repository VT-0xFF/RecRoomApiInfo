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
public interface BCIOFLEKCPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MAFIGLIJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HAHPOIBOGEF> MALLACHFOGH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HAHPOIBOGEF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FCGMJMLIEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BFBMBOEEENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EANJDGECENJ NAPPLAILMEC(Action<ArraySegment<float>> COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMDEPPDAMLN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EANJDGECENJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FIMNJFPJCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CEALBPFJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC44D0", Offset = "0x7CC34D0", VA = "0x187CC44D0")]
	public EANJDGECENJ(int EENCJIFKBIM, int MBHMJBOMGML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EKFALNLDNLF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BCIOFLEKCPB PMPECDOGJAL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MAFIGLIJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x871D770", Offset = "0x871C770", VA = "0x18871D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x871D8E0", Offset = "0x871C8E0", VA = "0x18871D8E0")]
	static EKFALNLDNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x871D7F0", Offset = "0x871C7F0", VA = "0x18871D7F0")]
	public static IReadOnlyList<HAHPOIBOGEF> MALLACHFOGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LLHBHDHKLIK : BCIOFLEKCPB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IGGGAFHHCJK : HAHPOIBOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BGBDHOOFLAP
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
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public BGBDHOOFLAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x871D5F0", Offset = "0x871C5F0", VA = "0x18871D5F0")]
			internal void DCLDHBJODBI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ELIEOGDPJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PHJCPDEJPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NEHGOLOJCII;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HKGGJOPMJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x871D9D0", Offset = "0x871C9D0", VA = "0x18871D9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FCGMJMLIEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BFBMBOEEENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD7C200", Offset = "0xD7B200", VA = "0x180D7C200", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x871DE30", Offset = "0x871CE30", VA = "0x18871DE30", Slot = "7")]
		public EANJDGECENJ NAPPLAILMEC(Action<ArraySegment<float>> COLEJLDPDCO)
		{
			return default(EANJDGECENJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x871DA70", Offset = "0x871CA70", VA = "0x18871DA70")]
		private EANJDGECENJ NAPPLAILMEC(int EENCJIFKBIM, int OKLIOMEPKDG, int MBHMJBOMGML, Action<ArraySegment<float>> COLEJLDPDCO)
		{
			return default(EANJDGECENJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x871D9F0", Offset = "0x871C9F0", VA = "0x18871D9F0", Slot = "8")]
		public void LMDEPPDAMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x871DE60", Offset = "0x871CE60", VA = "0x18871DE60")]
		public IGGGAFHHCJK(MMDevice ELIEOGDPJND, bool KHMAKANGLMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<IGGGAFHHCJK> FIPKBLBGJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MAFIGLIJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x871DEB0", Offset = "0x871CEB0", VA = "0x18871DEB0", Slot = "5")]
	public IReadOnlyList<HAHPOIBOGEF> MALLACHFOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x871E1D0", Offset = "0x871D1D0", VA = "0x18871E1D0")]
	public LLHBHDHKLIK()
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
