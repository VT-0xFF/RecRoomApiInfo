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
public class KOPFJACDLHN : ENPONKMFNHH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class IJLKLIMNEHL : FDCHLFBNPLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class CMEELLNEIMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public CMEELLNEIMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE9350", Offset = "0x6FE7950", VA = "0x186FE9350")]
			internal void FEEIDIEBJKG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice NMHOIHJKDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture OCDIBLCNMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource KCDBECCMLED;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string MMBOIOPABOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6FE9560", Offset = "0x6FE7B60", VA = "0x186FE9560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CCPOBNJMAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C9C20", Offset = "0x9C8220", VA = "0x1809C9C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MCPOFAHBEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA14C60", Offset = "0xA13260", VA = "0x180A14C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9920", Offset = "0x6FE7F20", VA = "0x186FE9920", Slot = "7")]
		public MMHPNGHNKME PNHPLEFHBDJ(Action<ArraySegment<float>> AJNAMFOHMMI)
		{
			return default(MMHPNGHNKME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9580", Offset = "0x6FE7B80", VA = "0x186FE9580")]
		private MMHPNGHNKME PNHPLEFHBDJ(int PJAHJDNFKAN, int GLNDBFDKNFI, int ICCACHPEIKN, Action<ArraySegment<float>> AJNAMFOHMMI)
		{
			return default(MMHPNGHNKME);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE94E0", Offset = "0x6FE7AE0", VA = "0x186FE94E0", Slot = "8")]
		public void EOAPDFKPPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9950", Offset = "0x6FE7F50", VA = "0x186FE9950")]
		public IJLKLIMNEHL(MMDevice NMHOIHJKDBP, bool PHIIOMNBAGA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<IJLKLIMNEHL> EPENAKDPAOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BBGPDBCIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FE99A0", Offset = "0x6FE7FA0", VA = "0x186FE99A0", Slot = "5")]
	public IReadOnlyList<FDCHLFBNPLL> BHNMALMBPIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C70", Offset = "0x6FE8270", VA = "0x186FE9C70")]
	public KOPFJACDLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ENPONKMFNHH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BBGPDBCIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FDCHLFBNPLL> BHNMALMBPIA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FDCHLFBNPLL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MMBOIOPABOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CCPOBNJMAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MCPOFAHBEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMHPNGHNKME PNHPLEFHBDJ(Action<ArraySegment<float>> AJNAMFOHMMI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOAPDFKPPAD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MMHPNGHNKME
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ACGGFLHDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IEMCPEMALEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C00", Offset = "0x2A82200", VA = "0x182A83C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9CF0", Offset = "0x6FE82F0", VA = "0x186FE9CF0")]
	public MMHPNGHNKME(int PJAHJDNFKAN, int ICCACHPEIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BPDIGBEEOBF
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static ENPONKMFNHH AAADIAJNHKL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool BBGPDBCIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9200", Offset = "0x6FE7800", VA = "0x186FE9200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9280", Offset = "0x6FE7880", VA = "0x186FE9280")]
	static BPDIGBEEOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9110", Offset = "0x6FE7710", VA = "0x186FE9110")]
	public static IReadOnlyList<FDCHLFBNPLL> BHNMALMBPIA()
	{
		return null;
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
