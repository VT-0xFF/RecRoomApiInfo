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
public interface CNJDGFAEGAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KNBKOACPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<AOBHABCJPIK> COKEEAEEIKH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AOBHABCJPIK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NKHBLCNKPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HBEMDLEBMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NJNAPEFGBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GECLCLGBNKG LMJFIIHGMEM(Action<ArraySegment<float>> JKHIBJGOJLH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDIBBDJMKGO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GECLCLGBNKG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DHOLPFLAIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4F0", Offset = "0x7CE4F0", VA = "0x1807CF4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E4C0", VA = "0x18087F4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KJABBFKIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4D0", Offset = "0x7CE4D0", VA = "0x1807CF4D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x858D70", Offset = "0x857D70", VA = "0x180858D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9470", Offset = "0x4BF8470", VA = "0x184BF9470")]
	public GECLCLGBNKG(int MNOCNEMKGKF, int MPINDELFGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ICBHNBIIGMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CNJDGFAEGAE MFGLOEDMIHJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KNBKOACPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9570", Offset = "0x4BF8570", VA = "0x184BF9570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BF95E0", Offset = "0x4BF85E0", VA = "0x184BF95E0")]
	static ICBHNBIIGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9480", Offset = "0x4BF8480", VA = "0x184BF9480")]
	public static IReadOnlyList<AOBHABCJPIK> COKEEAEEIKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GDKAKAEPIEL : CNJDGFAEGAE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EEGAGKDJGAL : AOBHABCJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CCGIILEHLKL
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
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public CCGIILEHLKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4BF8B80", Offset = "0x4BF7B80", VA = "0x184BF8B80")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice JGIIIDHEPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DFFANPIKIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FJFCKILELGA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NKHBLCNKPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4BF90F0", Offset = "0x4BF80F0", VA = "0x184BF90F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HBEMDLEBMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5A4990", Offset = "0x5A3990", VA = "0x1805A4990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E4EB0", Offset = "0x6E3EB0", VA = "0x1806E4EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NJNAPEFGBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63B2C0", VA = "0x18063C2C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4BF90C0", Offset = "0x4BF80C0", VA = "0x184BF90C0", Slot = "7")]
		public GECLCLGBNKG LMJFIIHGMEM(Action<ArraySegment<float>> JKHIBJGOJLH)
		{
			return default(GECLCLGBNKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8D80", Offset = "0x4BF7D80", VA = "0x184BF8D80")]
		private GECLCLGBNKG LMJFIIHGMEM(int MNOCNEMKGKF, int PLECEPMCENP, int MPINDELFGAM, Action<ArraySegment<float>> JKHIBJGOJLH)
		{
			return default(GECLCLGBNKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8D00", Offset = "0x4BF7D00", VA = "0x184BF8D00", Slot = "8")]
		public void EDIBBDJMKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9110", Offset = "0x4BF8110", VA = "0x184BF9110")]
		public EEGAGKDJGAL(MMDevice JGIIIDHEPEJ, bool KNJAEOPAGFH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EEGAGKDJGAL> NKHAOCEJIBE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KNBKOACPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x523FE0", Offset = "0x522FE0", VA = "0x180523FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9160", Offset = "0x4BF8160", VA = "0x184BF9160", Slot = "5")]
	public IReadOnlyList<AOBHABCJPIK> COKEEAEEIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9400", Offset = "0x4BF8400", VA = "0x184BF9400")]
	public GDKAKAEPIEL()
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
