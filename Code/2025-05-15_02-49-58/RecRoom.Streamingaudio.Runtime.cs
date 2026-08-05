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
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CEALBPFJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0910", Offset = "0x2DDEF10", VA = "0x182DE0910")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E50640", Offset = "0x6E4EC40", VA = "0x186E50640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F9B0", Offset = "0x7C8DFB0", VA = "0x187C8F9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8703EF0", Offset = "0x87024F0", VA = "0x188703EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8704050", Offset = "0x8702650", VA = "0x188704050")]
	static EKFALNLDNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8703F60", Offset = "0x8702560", VA = "0x188703F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public BGBDHOOFLAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8703D70", Offset = "0x8702370", VA = "0x188703D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8704140", Offset = "0x8702740", VA = "0x188704140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FCGMJMLIEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BFBMBOEEENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD8EA90", Offset = "0xD8D090", VA = "0x180D8EA90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87045A0", Offset = "0x8702BA0", VA = "0x1887045A0", Slot = "7")]
		public EANJDGECENJ NAPPLAILMEC(Action<ArraySegment<float>> COLEJLDPDCO)
		{
			return default(EANJDGECENJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87041E0", Offset = "0x87027E0", VA = "0x1887041E0")]
		private EANJDGECENJ NAPPLAILMEC(int EENCJIFKBIM, int OKLIOMEPKDG, int MBHMJBOMGML, Action<ArraySegment<float>> COLEJLDPDCO)
		{
			return default(EANJDGECENJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8704160", Offset = "0x8702760", VA = "0x188704160", Slot = "8")]
		public void LMDEPPDAMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87045D0", Offset = "0x8702BD0", VA = "0x1887045D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8704620", Offset = "0x8702C20", VA = "0x188704620", Slot = "5")]
	public IReadOnlyList<HAHPOIBOGEF> MALLACHFOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8704940", Offset = "0x8702F40", VA = "0x188704940")]
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
