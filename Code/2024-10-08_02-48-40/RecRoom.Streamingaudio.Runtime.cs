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
public interface MGFFLPJABFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HIKDACFBGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PHKKDFFDHNF> LJGDODCAADL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PHKKDFFDHNF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LIBEHGHEMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HHMMDCBNLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JNGLOPMBOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CKGMPDBNGEH CDNPEEMPJMK(Action<ArraySegment<float>> FKNFKAHALGJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKEJAGBFDEN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CKGMPDBNGEH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PFMJMMIAMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD00", Offset = "0x8FAF00", VA = "0x1808FBD00")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC02B40", Offset = "0xC01D40", VA = "0x180C02B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGGLPNHOHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27BA930", Offset = "0x27B9B30", VA = "0x1827BA930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x601C7D0", Offset = "0x601B9D0", VA = "0x18601C7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA1B0", Offset = "0x6CB93B0", VA = "0x186CBA1B0")]
	public CKGMPDBNGEH(int FKKOCPAHMOG, int BNDNBKMBKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JBDJFILLBEO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MGFFLPJABFC PNPDCPGCFPK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HIKDACFBGED
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75FCD40", Offset = "0x75FBF40", VA = "0x1875FCD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75FCEA0", Offset = "0x75FC0A0", VA = "0x1875FCEA0")]
	static JBDJFILLBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75FCDB0", Offset = "0x75FBFB0", VA = "0x1875FCDB0")]
	public static IReadOnlyList<PHKKDFFDHNF> LJGDODCAADL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EEKEJJKFBAG : MGFFLPJABFC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KKGHNDLKKGH : PHKKDFFDHNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IBMIJHMMMJG
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
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public IBMIJHMMMJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x75FCBC0", Offset = "0x75FBDC0", VA = "0x1875FCBC0")]
			internal void NLDOOOEELIJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HGKOGDMPAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PGAKFHBCKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CGFNGOPPHJD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LIBEHGHEMHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x75FD380", Offset = "0x75FC580", VA = "0x1875FD380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HHMMDCBNLEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x931B30", Offset = "0x930D30", VA = "0x180931B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9319F0", Offset = "0x930BF0", VA = "0x1809319F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JNGLOPMBOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x11502B0", Offset = "0x114F4B0", VA = "0x1811502B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75FD350", Offset = "0x75FC550", VA = "0x1875FD350", Slot = "7")]
		public CKGMPDBNGEH CDNPEEMPJMK(Action<ArraySegment<float>> FKNFKAHALGJ)
		{
			return default(CKGMPDBNGEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75FCF90", Offset = "0x75FC190", VA = "0x1875FCF90")]
		private CKGMPDBNGEH CDNPEEMPJMK(int FKKOCPAHMOG, int EENGIDKEMOL, int BNDNBKMBKIL, Action<ArraySegment<float>> FKNFKAHALGJ)
		{
			return default(CKGMPDBNGEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75FD3A0", Offset = "0x75FC5A0", VA = "0x1875FD3A0", Slot = "8")]
		public void GKEJAGBFDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75FD420", Offset = "0x75FC620", VA = "0x1875FD420")]
		public KKGHNDLKKGH(MMDevice HGKOGDMPAKH, bool PFCNBGJNOEP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KKGHNDLKKGH> MPBIKHMHFBO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HIKDACFBGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75FC810", Offset = "0x75FBA10", VA = "0x1875FC810", Slot = "5")]
	public IReadOnlyList<PHKKDFFDHNF> LJGDODCAADL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75FCB30", Offset = "0x75FBD30", VA = "0x1875FCB30")]
	public EEKEJJKFBAG()
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
