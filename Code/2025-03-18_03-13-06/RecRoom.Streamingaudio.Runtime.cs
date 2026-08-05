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
public interface IDBFFANELJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NBIJHOJOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PNADFCLEHNO> IBLCOKEAPDE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PNADFCLEHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HEIDAHJIDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CIPNOLKBGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GCKKGHBGNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DEFBPLLBJNK BKHALCEMKMD(Action<ArraySegment<float>> GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MICIMJIMLJN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DEFBPLLBJNK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NGONDGJPJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CLFEEOKJOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76515D0", Offset = "0x76507D0", VA = "0x1876515D0")]
	public DEFBPLLBJNK(int PONHEDHHKOM, int IBCJCPLFJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFOAMPODEOC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IDBFFANELJL GGLDLKCKPAH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NBIJHOJOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x807DF90", Offset = "0x807D190", VA = "0x18807DF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x807E000", Offset = "0x807D200", VA = "0x18807E000")]
	static IFOAMPODEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x807DEA0", Offset = "0x807D0A0", VA = "0x18807DEA0")]
	public static IReadOnlyList<PNADFCLEHNO> IBLCOKEAPDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FJHKJDFHIEF : IDBFFANELJL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HBHDGHCKPMB : PNADFCLEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EBNIKEFCKAE
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
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public EBNIKEFCKAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x807D490", Offset = "0x807C690", VA = "0x18807D490")]
			internal void LHCEAGFPODJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FMEFAADNEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EAPMIMNCGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BDEJKCNEPOP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HEIDAHJIDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x807DDB0", Offset = "0x807CFB0", VA = "0x18807DDB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CIPNOLKBGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCE50A0", Offset = "0xCE42A0", VA = "0x180CE50A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GCKKGHBGNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCA3320", Offset = "0xCA2520", VA = "0x180CA3320", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x807D9C0", Offset = "0x807CBC0", VA = "0x18807D9C0", Slot = "7")]
		public DEFBPLLBJNK BKHALCEMKMD(Action<ArraySegment<float>> GIIPLELNBKP)
		{
			return default(DEFBPLLBJNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x807D9F0", Offset = "0x807CBF0", VA = "0x18807D9F0")]
		private DEFBPLLBJNK BKHALCEMKMD(int PONHEDHHKOM, int ECGLHHKAFMA, int IBCJCPLFJED, Action<ArraySegment<float>> GIIPLELNBKP)
		{
			return default(DEFBPLLBJNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x807DDD0", Offset = "0x807CFD0", VA = "0x18807DDD0", Slot = "8")]
		public void MICIMJIMLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x807DE50", Offset = "0x807D050", VA = "0x18807DE50")]
		public HBHDGHCKPMB(MMDevice FMEFAADNEGI, bool AHCOLGFAEFF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HBHDGHCKPMB> JABBCJKFNGF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NBIJHOJOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x807D610", Offset = "0x807C810", VA = "0x18807D610", Slot = "5")]
	public IReadOnlyList<PNADFCLEHNO> IBLCOKEAPDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x807D930", Offset = "0x807CB30", VA = "0x18807D930")]
	public FJHKJDFHIEF()
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
