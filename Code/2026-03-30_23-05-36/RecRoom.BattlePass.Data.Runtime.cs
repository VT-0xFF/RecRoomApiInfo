using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.Econ.BattlePass;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83E1DC0", Offset = "0x83E0BC0", VA = "0x1883E1DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.BattlePass.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct BattlePassProgressWrapper : IEquatable<BattlePassProgressWrapper>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly BattlePassAccountProgressDTO _accountProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int CurrentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int TotalXpEarned;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BattlePassWrapper ENQGNSLLJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x164ABA0", Offset = "0x16499A0", VA = "0x18164ABA0")]
			get
			{
				return default(BattlePassWrapper);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool SKDSKTQGDMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x83E1320", Offset = "0x83E0120", VA = "0x1883E1320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime? XECISQZMRAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83E1030", Offset = "0x83DFE30", VA = "0x1883E1030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SSDCFWIWMNK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83E1140", Offset = "0x83DFF40", VA = "0x1883E1140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int KHNSVHFKHQW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83E11A0", Offset = "0x83DFFA0", VA = "0x1883E11A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DateTime QWDCOQOQDDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x83E1180", Offset = "0x83DFF80", VA = "0x1883E1180")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AKPYEPNPEFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83E1340", Offset = "0x83E0140", VA = "0x1883E1340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83E13B0", Offset = "0x83E01B0", VA = "0x1883E13B0")]
		private BattlePassProgressWrapper(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress, int currentLevel, int totalXpEarned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E11C0", Offset = "0x83DFFC0", VA = "0x1883E11C0")]
		public static BattlePassProgressWrapper New(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress)
		{
			return default(BattlePassProgressWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83E1100", Offset = "0x83DFF00", VA = "0x1883E1100")]
		public float HUFOCBOMIBN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83E0ED0", Offset = "0x83DFCD0", VA = "0x1883E0ED0", Slot = "4")]
		public bool Equals(BattlePassProgressWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83E0F90", Offset = "0x83DFD90", VA = "0x1883E0F90", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83E1060", Offset = "0x83DFE60", VA = "0x1883E1060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct BattlePassSessionWrapper : IEquatable<BattlePassSessionWrapper>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ReportBattlePassSessionResponseDTO _session;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int YRQEMPXZOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2935130", Offset = "0x2933F30", VA = "0x182935130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int AHFKXZKSANR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83E1580", Offset = "0x83E0380", VA = "0x1883E1580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LNZKZZSAFCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83E1670", Offset = "0x83E0470", VA = "0x1883E1670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ZRDFFPJVJVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83E1400", Offset = "0x83E0200", VA = "0x1883E1400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GHNCKSBBMNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83E1650", Offset = "0x83E0450", VA = "0x1883E1650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private int LSFLVRBJYPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x83E15A0", Offset = "0x83E03A0", VA = "0x1883E15A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int WHOGYJHAHEX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83E15C0", Offset = "0x83E03C0", VA = "0x1883E15C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int RKJQZUTBULC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83E1420", Offset = "0x83E0220", VA = "0x1883E1420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		private BattlePassSessionWrapper(ReportBattlePassSessionResponseDTO session)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE9EE40", Offset = "0xE9DC40", VA = "0x180E9EE40")]
		public static BattlePassSessionWrapper New(ReportBattlePassSessionResponseDTO session)
		{
			return default(BattlePassSessionWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83E14B0", Offset = "0x83E02B0", VA = "0x1883E14B0", Slot = "4")]
		public bool Equals(BattlePassSessionWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83E14E0", Offset = "0x83E02E0", VA = "0x1883E14E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1275950", Offset = "0x1274750", VA = "0x181275950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct BattlePassWrapper : IEquatable<BattlePassWrapper>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DRLFUGSKICJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IReadOnlyList<BattlePassLevelDTO> XYIUHQNUPJB;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DRLFUGSKICJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83E1CE0", Offset = "0x83E0AE0", VA = "0x1883E1CE0")]
			internal BattlePassLevelDTO ZWZCBCFLSOZ(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int WYWOVXPEUTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x83E19A0", Offset = "0x83E07A0", VA = "0x1883E19A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		private BattlePassWrapper(BattlePassDTO battlePass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE9EE40", Offset = "0xE9DC40", VA = "0x180E9EE40")]
		public static BattlePassWrapper New(BattlePassDTO battlePass)
		{
			return default(BattlePassWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83E1690", Offset = "0x83E0490", VA = "0x1883E1690")]
		public int EHYCWONLSII(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83E1AA0", Offset = "0x83E08A0", VA = "0x1883E1AA0")]
		public int OKXCOAXQCWF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83E1870", Offset = "0x83E0670", VA = "0x1883E1870")]
		public float HUFOCBOMIBN(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83E19F0", Offset = "0x83E07F0", VA = "0x1883E19F0")]
		public bool LJYVYGYCVPC(PaintballBattlePassIteration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83E14B0", Offset = "0x83E02B0", VA = "0x1883E14B0", Slot = "4")]
		public bool Equals(BattlePassWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83E17D0", Offset = "0x83E05D0", VA = "0x1883E17D0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1275950", Offset = "0x1274750", VA = "0x181275950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PaintballBattlePassIteration : uint
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		MerryMidway2025,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		FriendFest2026
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EEQZUQPGPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83E1D40", Offset = "0x83E0B40", VA = "0x1883E1D40")]
		public static string CWRKGRCAKQO(this PaintballBattlePassIteration a)
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
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
}
