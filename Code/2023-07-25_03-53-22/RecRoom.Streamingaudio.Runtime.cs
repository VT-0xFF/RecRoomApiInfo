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
public class NGHAHBLAHIA : IIGGBLCPPAI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class IJIGLGDHGNJ : OBIGGFJIKNM
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FJODFEOAABG
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
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public FJODFEOAABG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72F9D50", Offset = "0x72F8D50", VA = "0x1872F9D50")]
			internal void DAMHKBGDLJO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice GJKCAJEGCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture AGGBDCDACND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource HEKNJNBOOPD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string NLMFJPMHDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72F9F60", Offset = "0x72F8F60", VA = "0x1872F9F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool AKEAHCJMGCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x967960", Offset = "0x966960", VA = "0x180967960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LFBFOBNDHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1209F00", Offset = "0x1208F00", VA = "0x181209F00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72FA320", Offset = "0x72F9320", VA = "0x1872FA320", Slot = "7")]
		public IJLDJFKKCLF JPOFMLBHIEO(Action<ArraySegment<float>> ELHFOIEJAFO)
		{
			return default(IJLDJFKKCLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72F9F80", Offset = "0x72F8F80", VA = "0x1872F9F80")]
		private IJLDJFKKCLF JPOFMLBHIEO(int PGMCAJOGKKO, int MFAGJGJCDKP, int BCFAHOHGDLN, Action<ArraySegment<float>> ELHFOIEJAFO)
		{
			return default(IJLDJFKKCLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72F9EE0", Offset = "0x72F8EE0", VA = "0x1872F9EE0", Slot = "8")]
		public void APIEEIHLFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72FA350", Offset = "0x72F9350", VA = "0x1872FA350")]
		public IJIGLGDHGNJ(MMDevice GJKCAJEGCEM, bool LPGMPGNIKLF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<IJIGLGDHGNJ> PKIDCFHMGEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OJJHHJOIBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5F0", Offset = "0x72F95F0", VA = "0x1872FA5F0", Slot = "5")]
	public IReadOnlyList<OBIGGFJIKNM> JEJHOPLACCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72FA8C0", Offset = "0x72F98C0", VA = "0x1872FA8C0")]
	public NGHAHBLAHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IIGGBLCPPAI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OJJHHJOIBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OBIGGFJIKNM> JEJHOPLACCM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OBIGGFJIKNM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string NLMFJPMHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AKEAHCJMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LFBFOBNDHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJLDJFKKCLF JPOFMLBHIEO(Action<ArraySegment<float>> ELHFOIEJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APIEEIHLFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IJLDJFKKCLF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GCALCKMHMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FGJMAHNBFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72FA3A0", Offset = "0x72F93A0", VA = "0x1872FA3A0")]
	public IJLDJFKKCLF(int PGMCAJOGKKO, int BCFAHOHGDLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KPFOIDAIGAO
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static IIGGBLCPPAI CAKIIDPHAGE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool OJJHHJOIBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72FA4A0", Offset = "0x72F94A0", VA = "0x1872FA4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72FA520", Offset = "0x72F9520", VA = "0x1872FA520")]
	static KPFOIDAIGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72FA3B0", Offset = "0x72F93B0", VA = "0x1872FA3B0")]
	public static IReadOnlyList<OBIGGFJIKNM> JEJHOPLACCM()
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
