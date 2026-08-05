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
public interface BOOMANNHFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FJDFGOMCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IOMAAAAFKKM> AJGNGNDDCJK();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IOMAAAAFKKM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string POHNNMMDIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IIMDLGLFHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EGCPGPHOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMFCLPBIEJM FJKAOPJPEOG(Action<ArraySegment<float>> HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFJGLIPOFIB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OMFCLPBIEJM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NOGKBOGDHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BNMPJLFMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B370", Offset = "0x6B8A370", VA = "0x186B8B370")]
	public OMFCLPBIEJM(int ELPMGJMIBBL, int BOHNBIABGNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IEPBBGCDDDB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BOOMANNHFOI OCAJNDMMDLD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FJDFGOMCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AD20", Offset = "0x6B89D20", VA = "0x186B8AD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8ADA0", Offset = "0x6B89DA0", VA = "0x186B8ADA0")]
	static IEPBBGCDDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AC30", Offset = "0x6B89C30", VA = "0x186B8AC30")]
	public static IReadOnlyList<IOMAAAAFKKM> AJGNGNDDCJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AAMCFCJDLEF : BOOMANNHFOI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MHDGDLMMBNL : IOMAAAAFKKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AONPEDBJLBF
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
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public AONPEDBJLBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6B8AAB0", Offset = "0x6B89AB0", VA = "0x186B8AAB0")]
			internal void DIIFANKBKMJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NGPKMHMGCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OMAILPODHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PPJIMHICAED;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string POHNNMMDIIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B8B300", Offset = "0x6B8A300", VA = "0x186B8B300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IIMDLGLFHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9057B0", Offset = "0x9047B0", VA = "0x1809057B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F95D0", Offset = "0x9F85D0", VA = "0x1809F95D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EGCPGPHOFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD135A0", Offset = "0xD125A0", VA = "0x180D135A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B2D0", Offset = "0x6B8A2D0", VA = "0x186B8B2D0", Slot = "7")]
		public OMFCLPBIEJM FJKAOPJPEOG(Action<ArraySegment<float>> HLFIKKGGCCK)
		{
			return default(OMFCLPBIEJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AF10", Offset = "0x6B89F10", VA = "0x186B8AF10")]
		private OMFCLPBIEJM FJKAOPJPEOG(int ELPMGJMIBBL, int HGOMNOGOPHE, int BOHNBIABGNN, Action<ArraySegment<float>> HLFIKKGGCCK)
		{
			return default(OMFCLPBIEJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AE90", Offset = "0x6B89E90", VA = "0x186B8AE90", Slot = "8")]
		public void CFJGLIPOFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B320", Offset = "0x6B8A320", VA = "0x186B8B320")]
		public MHDGDLMMBNL(MMDevice NGPKMHMGCEG, bool MMJOLNCFHOJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MHDGDLMMBNL> HLAGDBEBJEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FJDFGOMCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A700", Offset = "0x6B89700", VA = "0x186B8A700", Slot = "5")]
	public IReadOnlyList<IOMAAAAFKKM> AJGNGNDDCJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AA20", Offset = "0x6B89A20", VA = "0x186B8AA20")]
	public AAMCFCJDLEF()
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
