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
public interface MFPEDKCBAOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OLPDCIICENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MLBHDFBBNIJ> OCAPONDKKLG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MLBHDFBBNIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string CDPBNEAFHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NBPHDDIPODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GEGPNOODIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFMDNLIDLGB NLGBMGJGMHK(Action<ArraySegment<float>> IOKENELNCLP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFBCEBMJGKK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LFMDNLIDLGB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GHDHLAFANKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EFBCGHPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51828C0", Offset = "0x5181CC0", VA = "0x1851828C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6351630", Offset = "0x6350A30", VA = "0x186351630")]
	public LFMDNLIDLGB(int LEHBEEJJBNA, int CBLJMPFDHMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HAEBLAMHGBI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MFPEDKCBAOI CHFMKNBCPND;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OLPDCIICENH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6350D70", Offset = "0x6350170", VA = "0x186350D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6350EE0", Offset = "0x63502E0", VA = "0x186350EE0")]
	static HAEBLAMHGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6350DF0", Offset = "0x63501F0", VA = "0x186350DF0")]
	public static IReadOnlyList<MLBHDFBBNIJ> OCAPONDKKLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GGHCCGCOAIA : MFPEDKCBAOI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JNPFFAGNAGE : MLBHDFBBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KJCDIGMIHJL
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
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public KJCDIGMIHJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63514B0", Offset = "0x63508B0", VA = "0x1863514B0")]
			internal void CJDIGGGGNIO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LHGIHBEADAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HJHNJGNLMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JJFIKEFFEIA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CDPBNEAFHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6350FD0", Offset = "0x63503D0", VA = "0x186350FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NBPHDDIPODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x882360", Offset = "0x881760", VA = "0x180882360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GEGPNOODIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB8FFB0", Offset = "0xB8F3B0", VA = "0x180B8FFB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6351430", Offset = "0x6350830", VA = "0x186351430", Slot = "7")]
		public LFMDNLIDLGB NLGBMGJGMHK(Action<ArraySegment<float>> IOKENELNCLP)
		{
			return default(LFMDNLIDLGB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6351070", Offset = "0x6350470", VA = "0x186351070")]
		private LFMDNLIDLGB NLGBMGJGMHK(int LEHBEEJJBNA, int EIKBEBCCKJJ, int CBLJMPFDHMF, Action<ArraySegment<float>> IOKENELNCLP)
		{
			return default(LFMDNLIDLGB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6350FF0", Offset = "0x63503F0", VA = "0x186350FF0", Slot = "8")]
		public void KFBCEBMJGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6351460", Offset = "0x6350860", VA = "0x186351460")]
		public JNPFFAGNAGE(MMDevice LHGIHBEADAK, bool JDEKBGAACKD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JNPFFAGNAGE> OKDNEDKMFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OLPDCIICENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63509C0", Offset = "0x634FDC0", VA = "0x1863509C0", Slot = "5")]
	public IReadOnlyList<MLBHDFBBNIJ> OCAPONDKKLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6350CE0", Offset = "0x63500E0", VA = "0x186350CE0")]
	public GGHCCGCOAIA()
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
