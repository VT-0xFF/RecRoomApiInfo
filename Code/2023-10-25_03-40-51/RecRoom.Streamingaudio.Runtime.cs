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
public interface LDPIDBFNBBE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OECBKAMBDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KNNGPNABOKN> ALGKOBEDKGA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KNNGPNABOKN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PHABGLMBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AHPANMIGCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OMAPKJJKPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCAJJKMFKNG GDFDKJBOCEN(Action<ArraySegment<float>> PMOMGAGBHKB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNJGKKFHDHN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LCAJJKMFKNG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HEKOMODHOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FNGIDEOLBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6353030", Offset = "0x6351E30", VA = "0x186353030")]
	public LCAJJKMFKNG(int NPLGCBCPDAP, int MIMMNOGMPIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GBPIGNMFFJK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LDPIDBFNBBE FANAOCMNHML;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OECBKAMBDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6352630", Offset = "0x6351430", VA = "0x186352630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63526B0", Offset = "0x63514B0", VA = "0x1863526B0")]
	static GBPIGNMFFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6352540", Offset = "0x6351340", VA = "0x186352540")]
	public static IReadOnlyList<KNNGPNABOKN> ALGKOBEDKGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KAILLJBJABM : LDPIDBFNBBE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KKJOOGBKCBL : KNNGPNABOKN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LLHGHMBAMDJ
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
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public LLHGHMBAMDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6353040", Offset = "0x6351E40", VA = "0x186353040")]
			internal void FILAJBAHCCL(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DEPAFDNCOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LDPLMGIGFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource KJDKAMDAABE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PHABGLMBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6352FC0", Offset = "0x6351DC0", VA = "0x186352FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AHPANMIGCLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x885DF0", Offset = "0x884BF0", VA = "0x180885DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OMAPKJJKPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB953B0", Offset = "0xB941B0", VA = "0x180B953B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6352B50", Offset = "0x6351950", VA = "0x186352B50", Slot = "7")]
		public LCAJJKMFKNG GDFDKJBOCEN(Action<ArraySegment<float>> PMOMGAGBHKB)
		{
			return default(LCAJJKMFKNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6352B80", Offset = "0x6351980", VA = "0x186352B80")]
		private LCAJJKMFKNG GDFDKJBOCEN(int NPLGCBCPDAP, int HEBBDLMGCFG, int MIMMNOGMPIM, Action<ArraySegment<float>> PMOMGAGBHKB)
		{
			return default(LCAJJKMFKNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6352F40", Offset = "0x6351D40", VA = "0x186352F40", Slot = "8")]
		public void GNJGKKFHDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6352FE0", Offset = "0x6351DE0", VA = "0x186352FE0")]
		public KKJOOGBKCBL(MMDevice DEPAFDNCOKJ, bool GODECPGHDGM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KKJOOGBKCBL> BJKKBGIACDC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OECBKAMBDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63527A0", Offset = "0x63515A0", VA = "0x1863527A0", Slot = "5")]
	public IReadOnlyList<KNNGPNABOKN> ALGKOBEDKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6352AC0", Offset = "0x63518C0", VA = "0x186352AC0")]
	public KAILLJBJABM()
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
