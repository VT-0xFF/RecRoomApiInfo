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
public interface FALEIHJPPMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HPIOKMNGKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MNGGJPFKDCL> LAPNDCOJOHP();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNGGJPFKDCL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GICPKDKGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EJCHENCLDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NBAKFOPCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LPNBMGLMJDG DJHDPOLPDPA(Action<ArraySegment<float>> IDFHKFHMFGD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIPMMIGEDBI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LPNBMGLMJDG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BDFOFGMNEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IFDDEOBMBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x685C3A0", Offset = "0x685B1A0", VA = "0x18685C3A0")]
	public LPNBMGLMJDG(int CCDJMNCOFOC, int DCJEJNNMBBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DCJFDFJNKCF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FALEIHJPPMK IIGBGDHIPDB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HPIOKMNGKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x685B730", Offset = "0x685A530", VA = "0x18685B730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x685B8A0", Offset = "0x685A6A0", VA = "0x18685B8A0")]
	static DCJFDFJNKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x685B7B0", Offset = "0x685A5B0", VA = "0x18685B7B0")]
	public static IReadOnlyList<MNGGJPFKDCL> LAPNDCOJOHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EBPOMIMGMCP : FALEIHJPPMK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FGHIJOJBPAO : MNGGJPFKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JKNIKAAIEIK
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
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public JKNIKAAIEIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x685C220", Offset = "0x685B020", VA = "0x18685C220")]
			internal void KFBICPFDIAB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ALDBOABPEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EDGJJBKJINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource OLCHJNCLONO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GICPKDKGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x685BD40", Offset = "0x685AB40", VA = "0x18685BD40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EJCHENCLDNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E7F0", VA = "0x18088F9F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x949130", Offset = "0x947F30", VA = "0x180949130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NBAKFOPCPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCA0530", Offset = "0xC9F330", VA = "0x180CA0530", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x685C1A0", Offset = "0x685AFA0", VA = "0x18685C1A0", Slot = "7")]
		public LPNBMGLMJDG DJHDPOLPDPA(Action<ArraySegment<float>> IDFHKFHMFGD)
		{
			return default(LPNBMGLMJDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x685BDE0", Offset = "0x685ABE0", VA = "0x18685BDE0")]
		private LPNBMGLMJDG DJHDPOLPDPA(int CCDJMNCOFOC, int DGPDMGIPDBF, int DCJEJNNMBBH, Action<ArraySegment<float>> IDFHKFHMFGD)
		{
			return default(LPNBMGLMJDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x685BD60", Offset = "0x685AB60", VA = "0x18685BD60", Slot = "8")]
		public void DIPMMIGEDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x685C1D0", Offset = "0x685AFD0", VA = "0x18685C1D0")]
		public FGHIJOJBPAO(MMDevice ALDBOABPEAJ, bool DDFFFKGOLFD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FGHIJOJBPAO> DFACGAOBFGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HPIOKMNGKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x685B990", Offset = "0x685A790", VA = "0x18685B990", Slot = "5")]
	public IReadOnlyList<MNGGJPFKDCL> LAPNDCOJOHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x685BCB0", Offset = "0x685AAB0", VA = "0x18685BCB0")]
	public EBPOMIMGMCP()
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
