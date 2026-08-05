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
public interface BIAEDOOCCKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HDOEEBHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BGPODLMDOOF> JDOKMINBIND();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BGPODLMDOOF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GJBJBGNHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BDPHEGGODDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BFJHMMHEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FPLBKLGNJHP BHCKDDGAKGL(Action<ArraySegment<float>> BKKOCCDDHJN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCLKLBMPNGA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FPLBKLGNJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LLEPPGAHMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4C0", Offset = "0x8AD8C0", VA = "0x1808AE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FNCPPAFNDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4D0", Offset = "0x7FD8D0", VA = "0x1807FE4D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x887D70", Offset = "0x887170", VA = "0x180887D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3BE0", Offset = "0x4DB2FE0", VA = "0x184DB3BE0")]
	public FPLBKLGNJHP(int INJIANAAPMP, int IICHHMDJBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JBABBCKJLKO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BIAEDOOCCKJ MGAGINBJPKB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HDOEEBHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4170", Offset = "0x4DB3570", VA = "0x184DB4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DB41E0", Offset = "0x4DB35E0", VA = "0x184DB41E0")]
	static JBABBCKJLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4080", Offset = "0x4DB3480", VA = "0x184DB4080")]
	public static IReadOnlyList<BGPODLMDOOF> JDOKMINBIND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HOILHBPELNK : BIAEDOOCCKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JFLHDINJOOH : BGPODLMDOOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HIGNAJADDCD
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
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public HIGNAJADDCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4DB3BF0", Offset = "0x4DB2FF0", VA = "0x184DB3BF0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GKCABBAOMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture CAMJLLHOFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource KIOGGPEDGPL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GJBJBGNHOIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4DB4290", Offset = "0x4DB3690", VA = "0x184DB4290", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BDPHEGGODDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5D3990", Offset = "0x5D2D90", VA = "0x1805D3990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x713EB0", Offset = "0x7132B0", VA = "0x180713EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BFJHMMHEDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x66B2C0", Offset = "0x66A6C0", VA = "0x18066B2C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4DB45F0", Offset = "0x4DB39F0", VA = "0x184DB45F0", Slot = "7")]
		public FPLBKLGNJHP BHCKDDGAKGL(Action<ArraySegment<float>> BKKOCCDDHJN)
		{
			return default(FPLBKLGNJHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4DB42B0", Offset = "0x4DB36B0", VA = "0x184DB42B0")]
		private FPLBKLGNJHP BHCKDDGAKGL(int INJIANAAPMP, int PPJDEJKEFOL, int IICHHMDJBBC, Action<ArraySegment<float>> BKKOCCDDHJN)
		{
			return default(FPLBKLGNJHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4620", Offset = "0x4DB3A20", VA = "0x184DB4620", Slot = "8")]
		public void LCLKLBMPNGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB46A0", Offset = "0x4DB3AA0", VA = "0x184DB46A0")]
		public JFLHDINJOOH(MMDevice GKCABBAOMCL, bool MHNIJIIAEEH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JFLHDINJOOH> GIENFEMNMGL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HDOEEBHMKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x552FE0", Offset = "0x5523E0", VA = "0x180552FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3D70", Offset = "0x4DB3170", VA = "0x184DB3D70", Slot = "5")]
	public IReadOnlyList<BGPODLMDOOF> JDOKMINBIND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4010", Offset = "0x4DB3410", VA = "0x184DB4010")]
	public HOILHBPELNK()
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
