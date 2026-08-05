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
		[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91DDB0", VA = "0x18091EFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HMAICADPLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9FD200", Offset = "0x9FC000", VA = "0x1809FD200")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9FD210", Offset = "0x9FC010", VA = "0x1809FD210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2263000", Offset = "0x2261E00", VA = "0x182263000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2262760", Offset = "0x2261560", VA = "0x182262760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22628E0", Offset = "0x22616E0", VA = "0x1822628E0")]
	static EGCNPNDANNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22627E0", Offset = "0x22615E0", VA = "0x1822627E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public FAIGKECIFLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x22629B0", Offset = "0x22617B0", VA = "0x1822629B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2262BC0", Offset = "0x22619C0", VA = "0x182262BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FEBGPBHMBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FIHMLKBPPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBEA4C0", Offset = "0xBE92C0", VA = "0x180BEA4C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2262F80", Offset = "0x2261D80", VA = "0x182262F80", Slot = "7")]
		public NBMJAHKMEEH PJDPKLFECCF(Action<ArraySegment<float>> KDDLOKAHKOL)
		{
			return default(NBMJAHKMEEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2262BE0", Offset = "0x22619E0", VA = "0x182262BE0")]
		private NBMJAHKMEEH PJDPKLFECCF(int HGIAIJKONGD, int GEFDGCJIJFA, int FJHCHLIJDEF, Action<ArraySegment<float>> KDDLOKAHKOL)
		{
			return default(NBMJAHKMEEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2262B40", Offset = "0x2261940", VA = "0x182262B40", Slot = "8")]
		public void DOMMDKIHNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2262FB0", Offset = "0x2261DB0", VA = "0x182262FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2262400", Offset = "0x2261200", VA = "0x182262400", Slot = "5")]
	public IReadOnlyList<PLCFHCNLKCG> MMNAHLBMHIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22626E0", Offset = "0x22614E0", VA = "0x1822626E0")]
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
