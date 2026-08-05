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
public interface FIKFHLONABH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BJCMCABNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LBKKEMINEIL> PALDBACEGGC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LBKKEMINEIL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MAKKOEHPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KOIKFLHGDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FOJOPIKAPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HJCOIPGAEDM JNBFKDALDKF(Action<ArraySegment<float>> HGFJMMOGKFF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPNMADMIEPM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HJCOIPGAEDM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DLOHAEOGJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LNHJKKCJLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x583FFC0", Offset = "0x583EBC0", VA = "0x18583FFC0")]
	public HJCOIPGAEDM(int CGMMFDEDENE, int NNDFGKBGIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MJJNPJBFAOK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FIKFHLONABH KDOKABBAHJL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BJCMCABNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x583FFD0", Offset = "0x583EBD0", VA = "0x18583FFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5840130", Offset = "0x583ED30", VA = "0x185840130")]
	static MJJNPJBFAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5840040", Offset = "0x583EC40", VA = "0x185840040")]
	public static IReadOnlyList<LBKKEMINEIL> PALDBACEGGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CLGPCDEDCDB : FIKFHLONABH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FAFNHOGCMPN : LBKKEMINEIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DCAMIJFDODP
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
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public DCAMIJFDODP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x583F9E0", Offset = "0x583E5E0", VA = "0x18583F9E0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GEKONBEGCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HBJODLJBKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource KMJHBIFPKIJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MAKKOEHPJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x583FED0", Offset = "0x583EAD0", VA = "0x18583FED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KOIKFLHGDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x665990", Offset = "0x664590", VA = "0x180665990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA33180", Offset = "0xA31D80", VA = "0x180A33180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FOJOPIKAPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC70", Offset = "0x6FC870", VA = "0x1806FDC70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x583FEA0", Offset = "0x583EAA0", VA = "0x18583FEA0", Slot = "7")]
		public HJCOIPGAEDM JNBFKDALDKF(Action<ArraySegment<float>> HGFJMMOGKFF)
		{
			return default(HJCOIPGAEDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x583FB60", Offset = "0x583E760", VA = "0x18583FB60")]
		private HJCOIPGAEDM JNBFKDALDKF(int CGMMFDEDENE, int AMLFHPODKAJ, int NNDFGKBGIOE, Action<ArraySegment<float>> HGFJMMOGKFF)
		{
			return default(HJCOIPGAEDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x583FEF0", Offset = "0x583EAF0", VA = "0x18583FEF0", Slot = "8")]
		public void MPNMADMIEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x583FF70", Offset = "0x583EB70", VA = "0x18583FF70")]
		public FAFNHOGCMPN(MMDevice GEKONBEGCBA, bool JCNBIJGNDPH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FAFNHOGCMPN> IFAGMMEKOHE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BJCMCABNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x583F6D0", Offset = "0x583E2D0", VA = "0x18583F6D0", Slot = "5")]
	public IReadOnlyList<LBKKEMINEIL> PALDBACEGGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x583F970", Offset = "0x583E570", VA = "0x18583F970")]
	public CLGPCDEDCDB()
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
