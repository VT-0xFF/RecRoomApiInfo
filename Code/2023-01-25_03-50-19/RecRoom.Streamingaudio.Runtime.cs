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
public interface BLDCBADBDCC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AGJJFBALNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PLCFHCNLKCG> MMNAHLBMHIB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PLCFHCNLKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GDINNMGOBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FEBGPBHMBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FIHMLKBPPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBMJAHKMEEH PJDPKLFECCF(Action<ArraySegment<float>> KDDLOKAHKOL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOMMDKIHNIG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NBMJAHKMEEH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IGDMMEODFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HMAICADPLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6116260", Offset = "0x6115260", VA = "0x186116260")]
	public NBMJAHKMEEH(int HGIAIJKONGD, int FJHCHLIJDEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EGCNPNDANNM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BLDCBADBDCC MCDGGGMPFIN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AGJJFBALNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61159C0", Offset = "0x61149C0", VA = "0x1861159C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6115B40", Offset = "0x6114B40", VA = "0x186115B40")]
	static EGCNPNDANNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6115A40", Offset = "0x6114A40", VA = "0x186115A40")]
	public static IReadOnlyList<PLCFHCNLKCG> MMNAHLBMHIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BGFFOHMKJPP : BLDCBADBDCC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KGCIPANLDHM : PLCFHCNLKCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FAIGKECIFLG
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
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public FAIGKECIFLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6115C10", Offset = "0x6114C10", VA = "0x186115C10")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LPMMMDBBKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GAADGPDPPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource APANCBBLAHK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GDINNMGOBPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6115E20", Offset = "0x6114E20", VA = "0x186115E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FEBGPBHMBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x738170", Offset = "0x737170", VA = "0x180738170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FIHMLKBPPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC60", Offset = "0x6BEC60", VA = "0x1806BFC60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61161E0", Offset = "0x61151E0", VA = "0x1861161E0", Slot = "7")]
		public NBMJAHKMEEH PJDPKLFECCF(Action<ArraySegment<float>> KDDLOKAHKOL)
		{
			return default(NBMJAHKMEEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6115E40", Offset = "0x6114E40", VA = "0x186115E40")]
		private NBMJAHKMEEH PJDPKLFECCF(int HGIAIJKONGD, int GEFDGCJIJFA, int FJHCHLIJDEF, Action<ArraySegment<float>> KDDLOKAHKOL)
		{
			return default(NBMJAHKMEEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6115DA0", Offset = "0x6114DA0", VA = "0x186115DA0", Slot = "8")]
		public void DOMMDKIHNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6116210", Offset = "0x6115210", VA = "0x186116210")]
		public KGCIPANLDHM(MMDevice LPMMMDBBKND, bool MHOEDKBGHHP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KGCIPANLDHM> JGCKPPEODKH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AGJJFBALNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6115660", Offset = "0x6114660", VA = "0x186115660", Slot = "5")]
	public IReadOnlyList<PLCFHCNLKCG> MMNAHLBMHIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6115940", Offset = "0x6114940", VA = "0x186115940")]
	public BGFFOHMKJPP()
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
