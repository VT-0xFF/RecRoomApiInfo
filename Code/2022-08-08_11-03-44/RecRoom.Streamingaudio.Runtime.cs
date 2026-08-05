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
public interface JDKOHHBNEPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool POLJKKPCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LBFDNDPANBO> DJOFFALPGAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LBFDNDPANBO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LKNMDAGAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGBAALCDFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KGBAEKFCCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OEJFIDHIEHN JPAMLGMHABL(Action<ArraySegment<float>> PCMFICPIFCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMCKOPDCIGF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OEJFIDHIEHN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AGHMDLKFENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AOIBIHLCLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5853740", Offset = "0x5852740", VA = "0x185853740")]
	public OEJFIDHIEHN(int FCADNCNJAKA, int JGMLMKDCPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DOLKIPKAFKF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JDKOHHBNEPK PKAFFGONICD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool POLJKKPCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5853190", Offset = "0x5852190", VA = "0x185853190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5853200", Offset = "0x5852200", VA = "0x185853200")]
	static DOLKIPKAFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58530A0", Offset = "0x58520A0", VA = "0x1858530A0")]
	public static IReadOnlyList<LBFDNDPANBO> DJOFFALPGAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NBAPAPOGCPN : JDKOHHBNEPK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PMBCFEFCDAL : LBFDNDPANBO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EPKGJFPDAPH
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
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public EPKGJFPDAPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x58532B0", Offset = "0x58522B0", VA = "0x1858532B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BHCHKMLDFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KFOAPIDAMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DKOAKHKMBLO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LKNMDAGAHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5853B40", Offset = "0x5852B40", VA = "0x185853B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AGBAALCDFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x666990", Offset = "0x665990", VA = "0x180666990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA34180", Offset = "0xA33180", VA = "0x180A34180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KGBAEKFCCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC70", Offset = "0x6FDC70", VA = "0x1806FEC70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5853B10", Offset = "0x5852B10", VA = "0x185853B10", Slot = "7")]
		public OEJFIDHIEHN JPAMLGMHABL(Action<ArraySegment<float>> PCMFICPIFCD)
		{
			return default(OEJFIDHIEHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x58537D0", Offset = "0x58527D0", VA = "0x1858537D0")]
		private OEJFIDHIEHN JPAMLGMHABL(int FCADNCNJAKA, int KBEGEFKACKC, int JGMLMKDCPNG, Action<ArraySegment<float>> PCMFICPIFCD)
		{
			return default(OEJFIDHIEHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5853750", Offset = "0x5852750", VA = "0x185853750", Slot = "8")]
		public void EMCKOPDCIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5853B60", Offset = "0x5852B60", VA = "0x185853B60")]
		public PMBCFEFCDAL(MMDevice BHCHKMLDFEF, bool JDOEACBCMAG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PMBCFEFCDAL> PIMKGDIADGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool POLJKKPCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5853430", Offset = "0x5852430", VA = "0x185853430", Slot = "5")]
	public IReadOnlyList<LBFDNDPANBO> DJOFFALPGAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58536D0", Offset = "0x58526D0", VA = "0x1858536D0")]
	public NBAPAPOGCPN()
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
