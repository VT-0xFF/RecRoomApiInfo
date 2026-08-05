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
public interface OFEJCLEBCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AJDLECKNMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KMKODJHKIAP> JAMJFPCFBGM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KMKODJHKIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BBAOPMPDOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HMGNCOEDAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KBHJLIFIAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KFMEIGDPCIH DGAGIJCKBMJ(Action<ArraySegment<float>> BHKFHJNIBAC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDDKCPBDEOP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KFMEIGDPCIH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HKLMDHPMELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FGDCEBEPJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7218AE0", Offset = "0x72174E0", VA = "0x187218AE0")]
	public KFMEIGDPCIH(int JNADGCEMJLF, int NGIBJHCCHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MELBHNJNLOI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OFEJCLEBCIG BELHHBONLKF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AJDLECKNMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7218F90", Offset = "0x7217990", VA = "0x187218F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7219010", Offset = "0x7217A10", VA = "0x187219010")]
	static MELBHNJNLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7218EA0", Offset = "0x72178A0", VA = "0x187218EA0")]
	public static IReadOnlyList<KMKODJHKIAP> JAMJFPCFBGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LBPLBLOEBPH : OFEJCLEBCIG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HMDLEDEFAEP : KMKODJHKIAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DJHJGHEHKKJ
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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public DJHJGHEHKKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7218480", Offset = "0x7216E80", VA = "0x187218480")]
			internal void BIBKHEFEODK(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EGGCHGMDJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LOEMHINFNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MBJHLGDFMDO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BBAOPMPDOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72189F0", Offset = "0x72173F0", VA = "0x1872189F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HMGNCOEDAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA659B0", Offset = "0xA643B0", VA = "0x180A659B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB36070", Offset = "0xB34A70", VA = "0x180B36070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KBHJLIFIAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE9A1D0", Offset = "0xE98BD0", VA = "0x180E9A1D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7218600", Offset = "0x7217000", VA = "0x187218600", Slot = "7")]
		public KFMEIGDPCIH DGAGIJCKBMJ(Action<ArraySegment<float>> BHKFHJNIBAC)
		{
			return default(KFMEIGDPCIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7218630", Offset = "0x7217030", VA = "0x187218630")]
		private KFMEIGDPCIH DGAGIJCKBMJ(int JNADGCEMJLF, int BLHHKLJABNN, int NGIBJHCCHLG, Action<ArraySegment<float>> BHKFHJNIBAC)
		{
			return default(KFMEIGDPCIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7218A10", Offset = "0x7217410", VA = "0x187218A10", Slot = "8")]
		public void NDDKCPBDEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7218A90", Offset = "0x7217490", VA = "0x187218A90")]
		public HMDLEDEFAEP(MMDevice EGGCHGMDJGK, bool FOKNFGBDPCP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HMDLEDEFAEP> HBGMBDNAGIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AJDLECKNMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7218AF0", Offset = "0x72174F0", VA = "0x187218AF0", Slot = "5")]
	public IReadOnlyList<KMKODJHKIAP> JAMJFPCFBGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7218E10", Offset = "0x7217810", VA = "0x187218E10")]
	public LBPLBLOEBPH()
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
