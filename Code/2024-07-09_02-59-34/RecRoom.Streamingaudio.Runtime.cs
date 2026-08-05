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
public interface FPPHLIOAHEI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DCFILOLNOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FCLGFMICBFP> IIFDKEGIMOG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCLGFMICBFP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NGJMKJKOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NCDADKMOIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KGDCKAFMNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GACOJGGMOGD NHGKCPFIMMK(Action<ArraySegment<float>> LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGNFEGBGAKH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GACOJGGMOGD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CADHPAKNOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PHAHNMBEKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x256F310", Offset = "0x256DF10", VA = "0x18256F310")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6600", Offset = "0x5DA5200", VA = "0x185DA6600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7326090", Offset = "0x7324C90", VA = "0x187326090")]
	public GACOJGGMOGD(int JGABBIECLGC, int LDIOKPBGICD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NLJHBCMOMCC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FPPHLIOAHEI MEEPFLLHJMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DCFILOLNOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7326AB0", Offset = "0x73256B0", VA = "0x187326AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7326C20", Offset = "0x7325820", VA = "0x187326C20")]
	static NLJHBCMOMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7326B30", Offset = "0x7325730", VA = "0x187326B30")]
	public static IReadOnlyList<FCLGFMICBFP> IIFDKEGIMOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NFAMLHPIGAG : FPPHLIOAHEI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MMMFHLBMAJH : FCLGFMICBFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JAJEABEIJCJ
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
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public JAJEABEIJCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x73260A0", Offset = "0x7324CA0", VA = "0x1873260A0")]
			internal void IBLJPCLPANO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BCOBLPLLJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GMPGHHKBPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DCMCBEPGFPL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NGJMKJKOLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7326220", Offset = "0x7324E20", VA = "0x187326220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NCDADKMOIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB55D80", Offset = "0xB54980", VA = "0x180B55D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KGDCKAFMNAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEBC5D0", Offset = "0xEBB1D0", VA = "0x180EBC5D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7326680", Offset = "0x7325280", VA = "0x187326680", Slot = "7")]
		public GACOJGGMOGD NHGKCPFIMMK(Action<ArraySegment<float>> LABOKGHKKOB)
		{
			return default(GACOJGGMOGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73262C0", Offset = "0x7324EC0", VA = "0x1873262C0")]
		private GACOJGGMOGD NHGKCPFIMMK(int JGABBIECLGC, int IFNHLNCGCIN, int LDIOKPBGICD, Action<ArraySegment<float>> LABOKGHKKOB)
		{
			return default(GACOJGGMOGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7326240", Offset = "0x7324E40", VA = "0x187326240", Slot = "8")]
		public void MGNFEGBGAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73266B0", Offset = "0x73252B0", VA = "0x1873266B0")]
		public MMMFHLBMAJH(MMDevice BCOBLPLLJFE, bool CFOICPFJJGD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MMMFHLBMAJH> CAOEGHHPKMK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DCFILOLNOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7326700", Offset = "0x7325300", VA = "0x187326700", Slot = "5")]
	public IReadOnlyList<FCLGFMICBFP> IIFDKEGIMOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7326A20", Offset = "0x7325620", VA = "0x187326A20")]
	public NFAMLHPIGAG()
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
