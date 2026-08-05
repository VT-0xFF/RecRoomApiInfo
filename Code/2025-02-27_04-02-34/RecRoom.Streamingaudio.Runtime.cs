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
public interface BHLBCOFEILH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HGMFNKBHOFD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DDMJIJIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JLCLJEGMEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HPGEJCNEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJJNBMHBMAM BNAKLCIPMOI(Action<ArraySegment<float>> IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGMAAAIMJON();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJJNBMHBMAM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MGNNPLKNEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JDDDBJJPCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74BAC80", Offset = "0x74BA080", VA = "0x1874BAC80")]
	public NJJNBMHBMAM(int EFCJBGBKNBH, int MEEBADFJJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AFMOICKCMMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BHLBCOFEILH DGAEKIFLAPH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3410", Offset = "0x7EE2810", VA = "0x187EE3410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3490", Offset = "0x7EE2890", VA = "0x187EE3490")]
	static AFMOICKCMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3320", Offset = "0x7EE2720", VA = "0x187EE3320")]
	public static IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LBOFIPKIBMC : BHLBCOFEILH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BFHADJDMCGJ : HGMFNKBHOFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IBCMMJPOEMP
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public IBCMMJPOEMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7EE3A60", Offset = "0x7EE2E60", VA = "0x187EE3A60")]
			internal void JFONAJJCCGJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DKLNJKBPHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JPBKMINDIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EFICFPHKBJN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DDMJIJIMJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7EE39F0", Offset = "0x7EE2DF0", VA = "0x187EE39F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JLCLJEGMEDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HPGEJCNEGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBFE670", Offset = "0xBFDA70", VA = "0x180BFE670", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3580", Offset = "0x7EE2980", VA = "0x187EE3580", Slot = "7")]
		public NJJNBMHBMAM BNAKLCIPMOI(Action<ArraySegment<float>> IJCKFHFIADK)
		{
			return default(NJJNBMHBMAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7EE35B0", Offset = "0x7EE29B0", VA = "0x187EE35B0")]
		private NJJNBMHBMAM BNAKLCIPMOI(int EFCJBGBKNBH, int AFBNKIHDDLD, int MEEBADFJJMC, Action<ArraySegment<float>> IJCKFHFIADK)
		{
			return default(NJJNBMHBMAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3970", Offset = "0x7EE2D70", VA = "0x187EE3970", Slot = "8")]
		public void CGMAAAIMJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3A10", Offset = "0x7EE2E10", VA = "0x187EE3A10")]
		public BFHADJDMCGJ(MMDevice DKLNJKBPHAL, bool JOAGKDBNICI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<BFHADJDMCGJ> NEDHGNFLEAA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3BE0", Offset = "0x7EE2FE0", VA = "0x187EE3BE0", Slot = "5")]
	public IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3F00", Offset = "0x7EE3300", VA = "0x187EE3F00")]
	public LBOFIPKIBMC()
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
