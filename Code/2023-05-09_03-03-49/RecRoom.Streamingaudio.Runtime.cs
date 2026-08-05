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
public interface GIOPLDGDMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PPAENFOMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KIIHALMOLMG> OOLGDFJDGPI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KIIHALMOLMG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ADHOEHCIAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LGOAKAPFBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EFHKPGFDOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDKLABFLDEI EGOEAGBEMHG(Action<ArraySegment<float>> KFICNKMCGGK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMKDICCLKDE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PDKLABFLDEI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KCDDGLJBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DBKHOHLAOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E68990", Offset = "0x1E67390", VA = "0x181E68990")]
	public PDKLABFLDEI(int PAOIHIKMHNO, int OFCDBEMCIBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GEOBLLMNGPH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GIOPLDGDMBE HFLLMJOKBNB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PPAENFOMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E68740", Offset = "0x1E67140", VA = "0x181E68740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E688C0", Offset = "0x1E672C0", VA = "0x181E688C0")]
	static GEOBLLMNGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E687C0", Offset = "0x1E671C0", VA = "0x181E687C0")]
	public static IReadOnlyList<KIIHALMOLMG> OOLGDFJDGPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EDLHHAMOGNO : GIOPLDGDMBE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CPBGAABOPLE : KIIHALMOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FADKJHIPPHJ
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
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public FADKJHIPPHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1E685B0", Offset = "0x1E66FB0", VA = "0x181E685B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BMNEPBGOICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DLNAODMDHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EDEILACGLBE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ADHOEHCIAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1E681E0", Offset = "0x1E66BE0", VA = "0x181E681E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LGOAKAPFBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EFHKPGFDOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA8FF20", Offset = "0xA8E920", VA = "0x180A8FF20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E67E10", Offset = "0x1E66810", VA = "0x181E67E10", Slot = "7")]
		public PDKLABFLDEI EGOEAGBEMHG(Action<ArraySegment<float>> KFICNKMCGGK)
		{
			return default(PDKLABFLDEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E67E40", Offset = "0x1E66840", VA = "0x181E67E40")]
		private PDKLABFLDEI EGOEAGBEMHG(int PAOIHIKMHNO, int CPGNEAPGBPB, int OFCDBEMCIBD, Action<ArraySegment<float>> KFICNKMCGGK)
		{
			return default(PDKLABFLDEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E67D90", Offset = "0x1E66790", VA = "0x181E67D90", Slot = "8")]
		public void BMKDICCLKDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E68200", Offset = "0x1E66C00", VA = "0x181E68200")]
		public CPBGAABOPLE(MMDevice BMNEPBGOICM, bool AAOOANPPCNG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CPBGAABOPLE> FLANOHCFMPI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PPAENFOMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E68250", Offset = "0x1E66C50", VA = "0x181E68250", Slot = "5")]
	public IReadOnlyList<KIIHALMOLMG> OOLGDFJDGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E68530", Offset = "0x1E66F30", VA = "0x181E68530")]
	public EDLHHAMOGNO()
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
