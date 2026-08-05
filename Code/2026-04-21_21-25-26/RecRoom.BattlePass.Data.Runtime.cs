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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9872120", Offset = "0x9870B20", VA = "0x189872120")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
			[Cpp2IlInjected.Address(RVA = "0x18A5690", Offset = "0x18A4090", VA = "0x1818A5690")]
			get
			{
				return default(BattlePassWrapper);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HEYPLGMNOZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x98715E0", Offset = "0x986FFE0", VA = "0x1898715E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime? YBWNSALECVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9871590", Offset = "0x986FF90", VA = "0x189871590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool VNLOFZTUYAR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9871550", Offset = "0x986FF50", VA = "0x189871550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int HGUZPNTMUKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98715C0", Offset = "0x986FFC0", VA = "0x1898715C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DateTime QFDIALQBZAA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9871530", Offset = "0x986FF30", VA = "0x189871530")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int UUOILFGHXYD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9871760", Offset = "0x9870160", VA = "0x189871760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98717D0", Offset = "0x98701D0", VA = "0x1898717D0")]
		private BattlePassProgressWrapper(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress, int currentLevel, int totalXpEarned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9871600", Offset = "0x9870000", VA = "0x189871600")]
		public static BattlePassProgressWrapper New(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress)
		{
			return default(BattlePassProgressWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9871450", Offset = "0x986FE50", VA = "0x189871450")]
		public float FNRJUHFARXM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98712E0", Offset = "0x986FCE0", VA = "0x1898712E0", Slot = "4")]
		public bool Equals(BattlePassProgressWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x98713A0", Offset = "0x986FDA0", VA = "0x1898713A0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9871490", Offset = "0x986FE90", VA = "0x189871490", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BAD7E0", Offset = "0x2BAC1E0", VA = "0x182BAD7E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int PZRFNBZQMBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9871A60", Offset = "0x9870460", VA = "0x189871A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int DUWLOXYPSOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9871AA0", Offset = "0x98704A0", VA = "0x189871AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int YHXQQCZXJSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9871900", Offset = "0x9870300", VA = "0x189871900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AZOZRZZYCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9871A80", Offset = "0x9870480", VA = "0x189871A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private int YHCVHGXOPYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9871A40", Offset = "0x9870440", VA = "0x189871A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int VWPTLQSYOTS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x98719B0", Offset = "0x98703B0", VA = "0x1898719B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int SJWTGTWQHZB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9871920", Offset = "0x9870320", VA = "0x189871920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		private BattlePassSessionWrapper(ReportBattlePassSessionResponseDTO session)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x110DB10", Offset = "0x110C510", VA = "0x18110DB10")]
		public static BattlePassSessionWrapper New(ReportBattlePassSessionResponseDTO session)
		{
			return default(BattlePassSessionWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9871820", Offset = "0x9870220", VA = "0x189871820", Slot = "4")]
		public bool Equals(BattlePassSessionWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9871850", Offset = "0x9870250", VA = "0x189871850", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x14BC6C0", Offset = "0x14BB0C0", VA = "0x1814BC6C0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9872260", Offset = "0x9870C60", VA = "0x189872260")]
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
			[Cpp2IlInjected.Address(RVA = "0x9872020", Offset = "0x9870A20", VA = "0x189872020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		private BattlePassWrapper(BattlePassDTO battlePass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x110DB10", Offset = "0x110C510", VA = "0x18110DB10")]
		public static BattlePassWrapper New(BattlePassDTO battlePass)
		{
			return default(BattlePassWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9871AC0", Offset = "0x98704C0", VA = "0x189871AC0")]
		public int AIKQHAKNTEX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9871C00", Offset = "0x9870600", VA = "0x189871C00")]
		public int EITDWJGLQSO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9871EF0", Offset = "0x98708F0", VA = "0x189871EF0")]
		public float FNRJUHFARXM(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9872070", Offset = "0x9870A70", VA = "0x189872070")]
		public bool NKMJPSJBZTX(PaintballBattlePassIteration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9871820", Offset = "0x9870220", VA = "0x189871820", Slot = "4")]
		public bool Equals(BattlePassWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9871E40", Offset = "0x9870840", VA = "0x189871E40", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x14BC6C0", Offset = "0x14BB0C0", VA = "0x1814BC6C0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9871260", Offset = "0x986FC60", VA = "0x189871260")]
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
