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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96F0C50", Offset = "0x96EFA50", VA = "0x1896F0C50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		public BattlePassWrapper YJFWMJVTTRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x186CFA0", Offset = "0x186BDA0", VA = "0x18186CFA0")]
			get
			{
				return default(BattlePassWrapper);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HEYPLGMNOZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x96F0110", Offset = "0x96EEF10", VA = "0x1896F0110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime? YBWNSALECVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x96F00C0", Offset = "0x96EEEC0", VA = "0x1896F00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool VNLOFZTUYAR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x96F0080", Offset = "0x96EEE80", VA = "0x1896F0080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int HGUZPNTMUKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x96F00F0", Offset = "0x96EEEF0", VA = "0x1896F00F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DateTime QFDIALQBZAA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x96F0060", Offset = "0x96EEE60", VA = "0x1896F0060")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int UUOILFGHXYD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x96F0290", Offset = "0x96EF090", VA = "0x1896F0290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96F0300", Offset = "0x96EF100", VA = "0x1896F0300")]
		private BattlePassProgressWrapper(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress, int currentLevel, int totalXpEarned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x96F0130", Offset = "0x96EEF30", VA = "0x1896F0130")]
		public static BattlePassProgressWrapper New(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress)
		{
			return default(BattlePassProgressWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96EFF80", Offset = "0x96EED80", VA = "0x1896EFF80")]
		public float FNRJUHFARXM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96EFE10", Offset = "0x96EEC10", VA = "0x1896EFE10", Slot = "4")]
		public bool Equals(BattlePassProgressWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96EFED0", Offset = "0x96EECD0", VA = "0x1896EFED0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96EFFC0", Offset = "0x96EEDC0", VA = "0x1896EFFC0", Slot = "2")]
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
		public int XDALGFDXSWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F7E0", Offset = "0x2B6E5E0", VA = "0x182B6F7E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int PZRFNBZQMBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x96F0590", Offset = "0x96EF390", VA = "0x1896F0590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int DUWLOXYPSOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x96F05D0", Offset = "0x96EF3D0", VA = "0x1896F05D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int YHXQQCZXJSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x96F0430", Offset = "0x96EF230", VA = "0x1896F0430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AZOZRZZYCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x96F05B0", Offset = "0x96EF3B0", VA = "0x1896F05B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private int YHCVHGXOPYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x96F0570", Offset = "0x96EF370", VA = "0x1896F0570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int VWPTLQSYOTS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x96F04E0", Offset = "0x96EF2E0", VA = "0x1896F04E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int SJWTGTWQHZB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x96F0450", Offset = "0x96EF250", VA = "0x1896F0450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private BattlePassSessionWrapper(ReportBattlePassSessionResponseDTO session)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public static BattlePassSessionWrapper New(ReportBattlePassSessionResponseDTO session)
		{
			return default(BattlePassSessionWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x96F0350", Offset = "0x96EF150", VA = "0x1896F0350", Slot = "4")]
		public bool Equals(BattlePassSessionWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96F0380", Offset = "0x96EF180", VA = "0x1896F0380", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1496030", Offset = "0x1494E30", VA = "0x181496030", Slot = "2")]
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
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IReadOnlyList<BattlePassLevelDTO> YUKOLYBCRSO;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x96F0D90", Offset = "0x96EFB90", VA = "0x1896F0D90")]
			internal BattlePassLevelDTO WEINXHKAWLI(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int DLNGMTXMHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x96F0B50", Offset = "0x96EF950", VA = "0x1896F0B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private BattlePassWrapper(BattlePassDTO battlePass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public static BattlePassWrapper New(BattlePassDTO battlePass)
		{
			return default(BattlePassWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96F05F0", Offset = "0x96EF3F0", VA = "0x1896F05F0")]
		public int AIKQHAKNTEX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96F0730", Offset = "0x96EF530", VA = "0x1896F0730")]
		public int EITDWJGLQSO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96F0A20", Offset = "0x96EF820", VA = "0x1896F0A20")]
		public float FNRJUHFARXM(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96F0BA0", Offset = "0x96EF9A0", VA = "0x1896F0BA0")]
		public bool NKMJPSJBZTX(PaintballBattlePassIteration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x96F0350", Offset = "0x96EF150", VA = "0x1896F0350", Slot = "4")]
		public bool Equals(BattlePassWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96F0970", Offset = "0x96EF770", VA = "0x1896F0970", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1496030", Offset = "0x1494E30", VA = "0x181496030", Slot = "2")]
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
	public static class BIXAPLPLGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96EFD90", Offset = "0x96EEB90", VA = "0x1896EFD90")]
		public static string OVGSHSPQLBP(this PaintballBattlePassIteration a)
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
