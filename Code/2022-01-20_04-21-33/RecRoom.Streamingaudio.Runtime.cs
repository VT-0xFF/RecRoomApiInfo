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
public interface AOHNCOEGMEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GAPGLAHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<APJAPGDNAKE> IPHFCHPPJGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface APJAPGDNAKE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BKJKCAEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IOFEJMEAJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IPHDCPIPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEPOKJFDNNC JJINACDMPBM(Action<ArraySegment<float>> DAGCGBINJLM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEIBDLLDEGD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IEPOKJFDNNC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EKEIMGDAOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D3FA0", Offset = "0x5D27A0", VA = "0x1805D3FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60BC90", Offset = "0x60A490", VA = "0x18060BC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GGAFPJMNPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D3F90", Offset = "0x5D2790", VA = "0x1805D3F90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x18BD1D0", Offset = "0x18BB9D0", VA = "0x1818BD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4508810", Offset = "0x4507010", VA = "0x184508810")]
	public IEPOKJFDNNC(int JGLAMFEOHIP, int NHOFNGDCCHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ILGCEJENFDO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static AOHNCOEGMEN BJBKIBIPMLF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GAPGLAHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4508910", Offset = "0x4507110", VA = "0x184508910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4508980", Offset = "0x4507180", VA = "0x184508980")]
	static ILGCEJENFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4508820", Offset = "0x4507020", VA = "0x184508820")]
	public static IReadOnlyList<APJAPGDNAKE> IPHFCHPPJGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KMHPDFAEPMO : AOHNCOEGMEN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MMHDDLNFGAG : APJAPGDNAKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IPICHKNGCMB
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
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public IPICHKNGCMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4508A20", Offset = "0x4507220", VA = "0x184508A20")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice CNMMGMMHDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FKCGCMPOLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IKEGJNLJNIH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BKJKCAEEIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4508EA0", Offset = "0x45076A0", VA = "0x184508EA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IOFEJMEAJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4E11E0", Offset = "0x4DF9E0", VA = "0x1804E11E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x4E11F0", Offset = "0x4DF9F0", VA = "0x1804E11F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IPHDCPIPGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x19F2840", Offset = "0x19F1040", VA = "0x1819F2840", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4508F20", Offset = "0x4507720", VA = "0x184508F20", Slot = "7")]
		public IEPOKJFDNNC JJINACDMPBM(Action<ArraySegment<float>> DAGCGBINJLM)
		{
			return default(IEPOKJFDNNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4508F50", Offset = "0x4507750", VA = "0x184508F50")]
		private IEPOKJFDNNC JJINACDMPBM(int JGLAMFEOHIP, int PFHFFDPHEFL, int NHOFNGDCCHC, Action<ArraySegment<float>> DAGCGBINJLM)
		{
			return default(IEPOKJFDNNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4508EC0", Offset = "0x45076C0", VA = "0x184508EC0", Slot = "8")]
		public void HEIBDLLDEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4509230", Offset = "0x4507A30", VA = "0x184509230")]
		public MMHDDLNFGAG(MMDevice CNMMGMMHDCL, bool GEGJEOLPKHI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MMHDDLNFGAG> CEFJBPOFBLD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GAPGLAHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x53A030", Offset = "0x538830", VA = "0x18053A030", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4508BA0", Offset = "0x45073A0", VA = "0x184508BA0", Slot = "5")]
	public IReadOnlyList<APJAPGDNAKE> IPHFCHPPJGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4508E40", Offset = "0x4507640", VA = "0x184508E40")]
	public KMHPDFAEPMO()
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
