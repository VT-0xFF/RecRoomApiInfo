using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Async;
using RecRoom.Core;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logger;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Notifications;
using RecRoom.Persistence;
using RecRoom.ProgressionEvents;
using RecRoom.RoomLoad.Protobuf;
using RecRoom.RoomLoading;
using RecRoom.Storefronts;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
		[Cpp2IlInjected.Address(RVA = "0x8574BF0", Offset = "0x85739F0", VA = "0x188574BF0")]
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
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8584360", Offset = "0x8583160", VA = "0x188584360", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CEJBPQJQJNQ : IComparer<KeepsakeCategory>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KeepsakeCategory OBRHVKFEPLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KeepsakeCategory OBWOSQZBYWP;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC50210", Offset = "0xC4F010", VA = "0x180C50210")]
			internal bool FFKKSVMIAUH(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1DE7AF0", Offset = "0x1DE68F0", VA = "0x181DE7AF0")]
			internal bool FFFDVOSKRIY(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC50210", Offset = "0xC4F010", VA = "0x180C50210")]
			internal bool FFUYNJACTQZ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1DE7AF0", Offset = "0x1DE68F0", VA = "0x181DE7AF0")]
			internal bool FFPRQCGFKFQ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<KeepsakeCategoryThemePair> OEUIYCZAPKB;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public CEJBPQJQJNQ(List<KeepsakeCategoryThemePair> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8573BF0", Offset = "0x85729F0", VA = "0x188573BF0", Slot = "4")]
		public int Compare(KeepsakeCategory x, KeepsakeCategory y)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public KeepsakeCategory KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KeepsakeTheme KeepsakeTheme;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Tested]
	public class XQKXXVTUUOA : ZVFBHISGWDP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DWEIKEQEGYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public KeepsakeTheme NRWDVRRKUWR;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DWEIKEQEGYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1E3C8D0", Offset = "0x1E3B6D0", VA = "0x181E3C8D0")]
			internal bool VMXAPYETNOJ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HZUKRYKUWGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public long VNBDEBSPOHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KeepsakeCategory? MBDGOBCBNUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> VQKPPJRPCHC;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HZUKRYKUWGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85745B0", Offset = "0x85733B0", VA = "0x1885745B0")]
			internal void HOFBSVDBTQL(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8574580", Offset = "0x8573380", VA = "0x188574580")]
			internal void HNZUVOJEKFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8574640", Offset = "0x8573440", VA = "0x188574640")]
			internal YHTYBMEYRGD<IEnumerable<Guid>> HOPPNIQWMND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7FCBAA0", Offset = "0x7FCA8A0", VA = "0x187FCBAA0")]
			internal bool HOKIQBWZDBU(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HZPDURQXMUW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KeepsakeRoomInstanceIdsDTO YUENLRXXUNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HZUKRYKUWGF CNVJRMTDZSZ;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HZPDURQXMUW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8574450", Offset = "0x8573250", VA = "0x188574450")]
			internal YHTYBMEYRGD<IEnumerable<Guid>> HNKADUBMHXB(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HZJWXKXADJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KeepsakeRoomInstancesDTO ODMQAOSDTEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HZPDURQXMUW CNFOZSLLXKY;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HZJWXKXADJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8574330", Offset = "0x8573130", VA = "0x188574330")]
			internal bool HNETGNHOYLS(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HZEQAEDCTYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Guid SLJHRROPJFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HZJWXKXADJN CNKVWZFJGWH;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HZEQAEDCTYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8574280", Offset = "0x8573080", VA = "0x188574280")]
			internal bool HNUNYHPHATT(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class TXJNRXAODCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public TXJNRXAODCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8575840", Offset = "0x8574640", VA = "0x188575840")]
			internal YHTYBMEYRGD<IEnumerable<Guid>> QEAJQMDXJLO(IEnumerable<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8573E80", Offset = "0x8572C80", VA = "0x188573E80")]
			internal bool QEFQNSXUSWX(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ZNVEOPBQSHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long VNBDEBSPOHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> VQKPPJRPCHC;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZNVEOPBQSHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8583DD0", Offset = "0x8582BD0", VA = "0x188583DD0")]
			internal void RKGUAIUJUYY(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8574580", Offset = "0x8573380", VA = "0x188574580")]
			internal void RKMAXPOHEKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8583E60", Offset = "0x8582C60", VA = "0x188583E60")]
			internal YHTYBMEYRGD<Dictionary<Guid, KeepsakeCategory>> RKRHUWIENVQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7FCBAA0", Offset = "0x7FCA8A0", VA = "0x187FCBAA0")]
			internal bool RKWOSDCBXGZ(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZNPXRIHTIWM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public KeepsakeRoomInstanceIdsDTO YUENLRXXUNO;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZNPXRIHTIWM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8583C30", Offset = "0x8582A30", VA = "0x188583C30")]
			internal YHTYBMEYRGD<Dictionary<Guid, KeepsakeCategory>> RLBVPJVZGSI(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ZOFSJCPLLEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public KeepsakeRoomInstancesDTO ODMQAOSDTEO;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZOFSJCPLLEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8584130", Offset = "0x8582F30", VA = "0x188584130")]
			internal bool RLHCMQPWQDR(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8584210", Offset = "0x8583010", VA = "0x188584210")]
			internal KeyValuePair<Guid, KeepsakeCategory> RLMJJXJTZPA(Guid a)
			{
				return default(KeyValuePair<Guid, KeepsakeCategory>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZOALLVVOBTE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Guid SLJHRROPJFA;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZOALLVVOBTE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xE10850", Offset = "0xE0F650", VA = "0x180E10850")]
			internal bool RLRQHEDRJAJ(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ZOQGDQDGEBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Guid SLJHRROPJFA;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZOQGDQDGEBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xE10850", Offset = "0xE0F650", VA = "0x180E10850")]
			internal bool RLWXEKXOSLS(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DCZKESFNIPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DCZKESFNIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8573EA0", Offset = "0x8572CA0", VA = "0x188573EA0")]
			internal YHTYBMEYRGD<Dictionary<Guid, KeepsakeCategory>> XFQBYKSSKMN(Dictionary<Guid, KeepsakeCategory> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8573E80", Offset = "0x8572C80", VA = "0x188573E80")]
			internal bool XFKVBDYVBBE(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DDERBYZKSAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public KeepsakeRoomInstanceIdsDTO TJFQKTUSTZM;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DDERBYZKSAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8574090", Offset = "0x8572E90", VA = "0x188574090")]
			internal bool XFFODXEXRPV(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class AIHVSOUAECD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Dictionary<Guid, KeepsakeCategory> HTHKTIJYVAI;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public AIHVSOUAECD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x85739E0", Offset = "0x85727E0", VA = "0x1885739E0")]
			internal KeyValuePair<KeepsakeCategory, int> IFRGYOEHYUQ(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class AICOVIACUQU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public KeepsakeCategory VEDAGKYYHBK;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public AICOVIACUQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD750A0", Offset = "0xD73EA0", VA = "0x180D750A0")]
			internal bool IGHBQIMABCR(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ORDOKIWXUJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Dictionary<Guid, KeepsakeCategory> HTHKTIJYVAI;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ORDOKIWXUJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8574D30", Offset = "0x8573B30", VA = "0x188574D30")]
			internal KeyValuePair<KeepsakeCategory, int> ZQAEFFVAAMU(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OQYHNCDAKXW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public KeepsakeCategory VEDAGKYYHBK;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public OQYHNCDAKXW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD750A0", Offset = "0xD73EA0", VA = "0x180D750A0")]
			internal bool ZQPYXACSCUV(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class WTHDQIFPAQD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<KeepsakeRoomDTO, bool> VQKPPJRPCHC;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public WTHDQIFPAQD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8576500", Offset = "0x8575300", VA = "0x188576500")]
			internal bool XDFLKYZQJWM(DateTime a, DateTime b, int c, TimeSpan d, TimeSpan e, int f)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8576440", Offset = "0x8575240", VA = "0x188576440")]
			internal bool PTBDLXZCWLH(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8576420", Offset = "0x8575220", VA = "0x188576420")]
			internal bool PSQPRKLIDOP(KeepsakeRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8576420", Offset = "0x8575220", VA = "0x188576420")]
			internal bool PSLIUDRKUDG(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OHHXMYWKWRT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public long QYNGCWJVSVJ;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public OHHXMYWKWRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x113A790", Offset = "0x1139590", VA = "0x18113A790")]
			internal bool LSAPWLHTXFF(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ODTOTKZDJID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public long IKSZFJIPIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Func<KeepsakeRoomDTO, bool> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ODTOTKZDJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8574C70", Offset = "0x8573A70", VA = "0x188574C70")]
			internal bool FQFSAZOBJLD(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x24DD7F0", Offset = "0x24DC5F0", VA = "0x1824DD7F0")]
			internal bool FQALDSUDZZU(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class RWMDDCAHMZC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public long QYNGCWJVSVJ;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public RWMDDCAHMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8574E80", Offset = "0x8573C80", VA = "0x188574E80")]
			internal bool PFNCSVGBBDW(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MXXKVNMZCZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public long QYNGCWJVSVJ;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public MXXKVNMZCZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x113A790", Offset = "0x1139590", VA = "0x18113A790")]
			internal bool ZXSUNHIKBDD(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class CMPHQONGCHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public KeepsakeCategory MBDGOBCBNUN;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public CMPHQONGCHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x205EE60", Offset = "0x205DC60", VA = "0x18205EE60")]
			internal bool MTQPFRWKQJF(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class KIURLYITOCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Guid HRPNQIXRGHZ;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public KIURLYITOCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8574950", Offset = "0x8573750", VA = "0x188574950")]
			internal bool RRUYKONQPSK(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class BWVLIOZPKDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public KeepsakeCategory MBDGOBCBNUN;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public BWVLIOZPKDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8573BB0", Offset = "0x85729B0", VA = "0x188573BB0")]
			internal bool HLWGLQXTYGL(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class BNHPJKSWEPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public long KRUKSBLUTWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public long? YGGVRKBIRRR;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public BNHPJKSWEPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8573B30", Offset = "0x8572930", VA = "0x188573B30")]
			internal bool ORAFMWZRWUM(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class DWXTRTXLCOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IReadOnlyList<KeepsakeRoomListDTO> WUAWXLMHYZB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public long QYNGCWJVSVJ;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DWXTRTXLCOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8574190", Offset = "0x8572F90", VA = "0x188574190")]
			internal bool XZGXPFQHOJV(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class DWSMUNDNTDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public KeepsakeRoomDTO XDDGPWVGNFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DWXTRTXLCOP CNVJRMTDZSZ;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DWSMUNDNTDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8574110", Offset = "0x8572F10", VA = "0x188574110")]
			internal bool XZMEMMKEXVE(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class TKTSAVFGLVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KeepsakeCategory MBDGOBCBNUN;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public TKTSAVFGLVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8575420", Offset = "0x8574220", VA = "0x188575420")]
			internal YHTYBMEYRGD<Guid> NEJMTWUIQSJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8575810", Offset = "0x8574610", VA = "0x188575810")]
			internal void SPOWUAVHWTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x85753C0", Offset = "0x85741C0", VA = "0x1885753C0")]
			internal void EFRBNOXRFTI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8575560", Offset = "0x8574360", VA = "0x188575560")]
			internal void SPEIZNHNDWO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x85757E0", Offset = "0x85745E0", VA = "0x1885757E0")]
			internal void SPJPWUBKNHX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class TAYBDLETODU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public XQKXXVTUUOA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string FHBQJHEOIVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int YVQGNGZVYDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int AIMLTIQPTSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Guid HRPNQIXRGHZ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public TAYBDLETODU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8575020", Offset = "0x8573E20", VA = "0x188575020")]
			internal void KZHCURHELJP(KeepsakeCollectInstanceResponse a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8574EE0", Offset = "0x8573CE0", VA = "0x188574EE0")]
			internal void IAYPXDDHDCZ(string a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct <OnRunMigrations>d__182 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public XQKXXVTUUOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AIZYZLRFHFX args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x85759B0", Offset = "0x85747B0", VA = "0x1885759B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8575EC0", Offset = "0x8574CC0", VA = "0x188575EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <PeriodicLog>d__184 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public TimeSpan delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public XQKXXVTUUOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8575F20", Offset = "0x8574D20", VA = "0x188575F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85761B0", Offset = "0x8574FB0", VA = "0x1885761B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DateTime LEUDIDCQVRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HGWKCUPKFMH OFRPMIHZJXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly YTHDJSKOPGO BCTOOKIDSJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly UFORJNBWLEO HJVNEPOSPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BDRDTAOLVKG WLMVIEXVXLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BPKCFRLPRRV ULFEOCUXIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KQQOEUUAXSK EMSCLUIBIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly GCKWFACHXRI SGKMLKHENCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OLPMYWFCPDT XFCAIILTWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OVISDNWKQAW EUPXXESEIUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BZYMZXBTMKI ZXTYVTATVVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MQDSKNLIASK PCCHTWLGDVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly LQHCQABMFCP GFFASCQDZHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly DCEOPVAKPUR WCCWAPZCBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly PYRNSQYJVFT KGHSXDWOKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly DUOTNOGUQNU LBYUJWRPUTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LLDYIDIAOAE<KeepsakesConfig.KeepsakesOptions> JFYJGRCEPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MNPPKFJRFBH AAHYVDZJSGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<Guid, KeepsakeInstanceDTO> DJMYCUVLUOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HashSet<Guid> VSPUATSWSPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<long> FECTQWMWAMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<KeepsakeCategory, int> JNHMWHWCMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HashSet<Guid> JRLVEDSELXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IDisposable SNUMSQBKLUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task XVAWIIWDAVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private YHTYBMEYRGD<Guid> CRZFKJQDGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long? KHEMVEEFXGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KeepsakeProgressionEventInstancesDTO ARPYGXAAEOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private YHTYBMEYRGD<KeepsakeProgressionEventInstancesDTO> ERLVWKSHAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> VHMKRJHNKXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KeepsakeGlobalConfigDTO ZIPZNAFBMRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<long> DLIJDLCEYXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HashSet<long> YUELQZMVSPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private List<KeepsakeRoomListDTO> SJADRVXUYHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<KeepsakeRoomListDTO> AIYDWGZGSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private List<KeepsakeRoomListDTO> HDLIDXBVLSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<long, string> UNXYOVVHAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<long, string> MKZTDTISIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<long, DateTime> CMNRYPNHQZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Dictionary<long, List<KeepsakeRoomDTO>> WUYQOLMETTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Dictionary<long, List<KeepsakeRoomDTO>> JWOYTXBMHQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Dictionary<long, long> RFLQACWJFAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<string> VHWGLZICLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DateTime GPIODHIIOSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IDisposable VGAVGYLUXOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<Guid, KeepsakeCategory> FNCJFPTPXNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<KeepsakeCategory, int> KJLMILESPWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<KeepsakeCategoryThemePair> HYKQMMOEOSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CEJBPQJQJNQ WSXTELUFOVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool MDPRHZRTGTS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JZPEPKQGLTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB20690", Offset = "0xB1F490", VA = "0x180B20690", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB21030", Offset = "0xB1FE30", VA = "0x180B21030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LRPFUYXIVEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8576F10", Offset = "0x8575D10", VA = "0x188576F10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EAPUFGSUVUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8577E10", Offset = "0x8576C10", VA = "0x188577E10", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private long QZRPQRZDYCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8581D40", Offset = "0x8580B40", VA = "0x188581D40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private long? BHLYMRDGYYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x857F840", Offset = "0x857E640", VA = "0x18857F840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool IVDCXUYZLXY
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8576C40", Offset = "0x8575A40", VA = "0x188576C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<KeepsakeRoomListDTO> DTGYJOFVGLY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB7C6A0", Offset = "0xB7B4A0", VA = "0x180B7C6A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<KeepsakeRoomListDTO> SYKIOMDFMXO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB7C510", Offset = "0xB7B310", VA = "0x180B7C510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<KeepsakeRoomListDTO> VJPVAVOMGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB7C970", Offset = "0xB7B770", VA = "0x180B7C970", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<long, string> DHONMGAJNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB7C690", Offset = "0xB7B490", VA = "0x180B7C690", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal bool KHXMSXOBQVW
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x12465C0", Offset = "0x12453C0", VA = "0x1812465C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid?> PNBMMLFINSF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85825B0", Offset = "0x85813B0", VA = "0x1885825B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x857B950", Offset = "0x857A750", VA = "0x18857B950", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ZPKZBHFQTXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x857FE50", Offset = "0x857EC50", VA = "0x18857FE50", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x857BC90", Offset = "0x857AA90", VA = "0x18857BC90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action HDCITCKJSPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x857E540", Offset = "0x857D340", VA = "0x18857E540", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8578AC0", Offset = "0x85778C0", VA = "0x188578AC0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8582750", Offset = "0x8581550", VA = "0x188582750")]
		[RecRoom.NoEngine.Common.Preserve]
		internal XQKXXVTUUOA([Inject(null)][NotNull] HGWKCUPKFMH notificationManager, [Inject(null)][NotNull] EBAPHQXPFML roomLoader, [Inject(null)][NotNull] YTHDJSKOPGO creationHelper, [Inject(null)][NotNull] UFORJNBWLEO roomPersistenceManager, [Inject(null)][NotNull] BDRDTAOLVKG progressionEventsManager, [Inject(null)][NotNull] BPKCFRLPRRV roomManager, [Inject(null)][NotNull] KQQOEUUAXSK storefrontManager, [Inject(null)][NotNull] GCKWFACHXRI roomSaveValidation, [Inject(null)][NotNull] OLPMYWFCPDT networking, [Inject(null)][NotNull] CNHKWPYWVGW scheduledUpdateService, [Inject(null)][NotNull] OVISDNWKQAW recNetMatchmaking, [Inject(null)][NotNull] BZYMZXBTMKI recNetKeepsakes, [Inject(null)][NotNull] MQDSKNLIASK recNetAccounts, [Inject(null)][NotNull] LQHCQABMFCP recNetStorefronts, [Inject(null)][NotNull] DCEOPVAKPUR recNetGifts, [Inject(null)][NotNull] PYRNSQYJVFT timeService, [Inject(null)][NotNull] DUOTNOGUQNU debugLogger, [Inject(null)][NotNull] LLDYIDIAOAE<KeepsakesConfig.KeepsakesOptions> options, [Inject(null)][NotNull] MNPPKFJRFBH gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x857C000", Offset = "0x857AE00", VA = "0x18857C000", Slot = "15")]
		public bool MMHLODASEZJ(List<string> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85795E0", Offset = "0x85783E0", VA = "0x1885795E0", Slot = "16")]
		public YHTYBMEYRGD<Guid> HTYVIMGDELI(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x857A0B0", Offset = "0x8578EB0", VA = "0x18857A0B0", Slot = "17")]
		public ILWLFVTHXJS IPUETWSBOIB(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8580FD0", Offset = "0x857FDD0", VA = "0x188580FD0", Slot = "18")]
		public ILWLFVTHXJS XZHCXZDFZPW(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8576610", Offset = "0x8575410", VA = "0x188576610", Slot = "19")]
		public bool AQJECOFXKTW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8576F60", Offset = "0x8575D60", VA = "0x188576F60", Slot = "20")]
		public bool CQGLIFDBZOU(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8576F90", Offset = "0x8575D90", VA = "0x188576F90")]
		public KeepsakeTheme CWQFSLPTVWG(Guid a)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85786B0", Offset = "0x85774B0", VA = "0x1885786B0")]
		public bool GIXDWHHHVOK(KeepsakeCategory a, [Out] KeepsakeTheme b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x857C670", Offset = "0x857B470", VA = "0x18857C670")]
		public List<KeepsakeTheme> NAHVWEHJZWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85817B0", Offset = "0x85805B0", VA = "0x1885817B0")]
		public int YFEFMHVYVCT(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8577710", Offset = "0x8576510", VA = "0x188577710")]
		public KeepsakeCategory DWBURKATDGV(Guid a)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x857E400", Offset = "0x857D200", VA = "0x18857E400", Slot = "34")]
		public List<KeepsakeCategory> QYZCNGJVOFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8576770", Offset = "0x8575570", VA = "0x188576770", Slot = "35")]
		public IComparer<KeepsakeCategory> ATNQNKZXRIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85781E0", Offset = "0x8576FE0", VA = "0x1885781E0", Slot = "32")]
		public string FPHJDWBJNAN(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x857D460", Offset = "0x857C260", VA = "0x18857D460", Slot = "33")]
		public string OKITBRXVTUR(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x857E5E0", Offset = "0x857D3E0", VA = "0x18857E5E0", Slot = "21")]
		public bool RZYDNVCOLIG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8582040", Offset = "0x8580E40", VA = "0x188582040", Slot = "22")]
		public void ZHNHYKTPNVS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8576E00", Offset = "0x8575C00", VA = "0x188576E00", Slot = "23")]
		public void BRPIFADSHCU(KeepsakeCategory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8578890", Offset = "0x8577690", VA = "0x188578890", Slot = "24")]
		public void GKGSTQMITNK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x857B030", Offset = "0x8579E30", VA = "0x18857B030", Slot = "25")]
		public int LARFUVISNBM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x857C2B0", Offset = "0x857B0B0", VA = "0x18857C2B0", Slot = "31")]
		public YHTYBMEYRGD<IEnumerable<Guid>> MQMGRSOMMBN(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8576C50", Offset = "0x8575A50", VA = "0x188576C50", Slot = "30")]
		public YHTYBMEYRGD<IEnumerable<Guid>> BRGBCSVMMZM(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8581330", Offset = "0x8580130", VA = "0x188581330", Slot = "54")]
		public YHTYBMEYRGD<Dictionary<Guid, KeepsakeCategory>> YDBJWPCOBZY(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x857D5E0", Offset = "0x857C3E0", VA = "0x18857D5E0", Slot = "55")]
		public YHTYBMEYRGD<Dictionary<Guid, KeepsakeCategory>> OKQUSSTAJEV(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x857D1D0", Offset = "0x857BFD0", VA = "0x18857D1D0", Slot = "26")]
		public YHTYBMEYRGD<int> OIBUHQZNEZM(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x857B7F0", Offset = "0x857A5F0", VA = "0x18857B7F0", Slot = "27")]
		public YHTYBMEYRGD<int> LPBFQWRWZMG(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8577ED0", Offset = "0x8576CD0", VA = "0x188577ED0", Slot = "28")]
		public YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> EUNNKVCKMSX(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8576E50", Offset = "0x8575C50", VA = "0x188576E50", Slot = "29")]
		public YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> CJVPXDYUBYL(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85776B0", Offset = "0x85764B0", VA = "0x1885776B0", Slot = "37")]
		public bool DVLPSGWNOWP(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x857E1D0", Offset = "0x857CFD0", VA = "0x18857E1D0", Slot = "56")]
		public bool QHYPUOCPOCD(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x857FEF0", Offset = "0x857ECF0", VA = "0x18857FEF0", Slot = "38")]
		public bool VOTKFMENZXA(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x857A310", Offset = "0x8579110", VA = "0x18857A310", Slot = "57")]
		public bool IZUTWTZSSAM(long a, [Out] KeepsakeRoomLockStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8581DA0", Offset = "0x8580BA0", VA = "0x188581DA0", Slot = "39")]
		public bool YSQKXNMTRUN(long a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x857F8D0", Offset = "0x857E6D0", VA = "0x18857F8D0", Slot = "40")]
		public long USBSYOHCJHZ(long a, bool b = false)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x857F730", Offset = "0x857E530", VA = "0x18857F730", Slot = "41")]
		public long TLMFIYQCNGJ(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8577280", Offset = "0x8576080", VA = "0x188577280", Slot = "42")]
		public int DBLYQKYBIHA(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8578360", Offset = "0x8577160", VA = "0x188578360", Slot = "43")]
		public bool FZJMDGBHYID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8580E50", Offset = "0x857FC50", VA = "0x188580E50", Slot = "44")]
		public bool XURSAWDKEAJ(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8578440", Offset = "0x8577240", VA = "0x188578440", Slot = "45")]
		public IReadOnlyList<long> GBIZHJGMUDM(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85805A0", Offset = "0x857F3A0", VA = "0x1885805A0", Slot = "46")]
		public int VVCOUIGSPNJ(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x857AD80", Offset = "0x8579B80", VA = "0x18857AD80", Slot = "50")]
		public long KJERKIYXTOW(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8581930", Offset = "0x8580730", VA = "0x188581930", Slot = "51")]
		public KeepsakeCategory YGKZCBJZFFM()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8579BB0", Offset = "0x85789B0", VA = "0x188579BB0")]
		private void HVEXDVAAHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x857CAF0", Offset = "0x857B8F0", VA = "0x18857CAF0")]
		private void NUWJUXGWDRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x857D760", Offset = "0x857C560", VA = "0x18857D760")]
		private int OODBQTAXHWJ(KeepsakeRoomListDTO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8576B40", Offset = "0x8575940", VA = "0x188576B40")]
		private int BHCORVKICPU(DateTime a, DateTime b, TimeSpan c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x857BA00", Offset = "0x857A800", VA = "0x18857BA00")]
		private void LSILRYXTYUH(IEnumerable<KeepsakeInstanceDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x857A8D0", Offset = "0x85796D0", VA = "0x18857A8D0")]
		private void KFIUQZAFRKZ(IEnumerable<KeepsakeCollectionRecordDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x857B450", Offset = "0x857A250", VA = "0x18857B450")]
		private void LBHHHFKAHME(IEnumerable<long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB410E0", Offset = "0xB3FEE0", VA = "0x180B410E0")]
		private void LVFGAWBVVDK(KeepsakeGlobalConfigDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x857AB20", Offset = "0x8579920", VA = "0x18857AB20")]
		private bool KHLNZKFIMPZ(KeepsakeCategory a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x857D130", Offset = "0x857BF30", VA = "0x18857D130")]
		private bool OHUCNYDEFML([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8580830", Offset = "0x857F630", VA = "0x188580830")]
		private bool XCFIAQUOIMK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8580650", Offset = "0x857F450", VA = "0x188580650")]
		private IEnumerable<Guid> WKHLDBQLULS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85816F0", Offset = "0x85804F0", VA = "0x1885816F0")]
		private IEnumerable<KeepsakeInstanceDTO> YEBIPWEMYDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85807A0", Offset = "0x857F5A0", VA = "0x1885807A0")]
		private void WVMGIGETDLW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8578B60", Offset = "0x8577960", VA = "0x188578B60")]
		private bool HLJBVTYVXNA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x857FF90", Offset = "0x857ED90", VA = "0x18857FF90")]
		private void VRKPNWWRYJS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8581EE0", Offset = "0x8580CE0", VA = "0x188581EE0")]
		private void YTJGIANZMJR(KeepsakeCategory a, int b, Dictionary<KeepsakeCategory, int> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x857DE20", Offset = "0x857CC20", VA = "0x18857DE20")]
		private int PHCEXOJYNID(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x857A6B0", Offset = "0x85794B0", VA = "0x18857A6B0")]
		private void JWGMZRMKEWW(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8577460", Offset = "0x8576260", VA = "0x188577460")]
		private void DLYMJAMDZUQ(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8582660", Offset = "0x8581460", VA = "0x188582660")]
		private void ZYKHKAVPLFN(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x857DF10", Offset = "0x857CD10", VA = "0x18857DF10")]
		private void PXDOTVEFMCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85765F0", Offset = "0x85753F0", VA = "0x1885765F0")]
		private void AKSKCVOHBXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x857B780", Offset = "0x857A580", VA = "0x18857B780")]
		private void LILJRHFUDBB(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x857DF10", Offset = "0x857CD10", VA = "0x18857DF10")]
		private void QBGSQORHMMG(GiftPackageReceivedArgs a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x857DF10", Offset = "0x857CD10", VA = "0x18857DF10")]
		private void POUBRWZIRLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8582210", Offset = "0x8581010", VA = "0x188582210")]
		private void ZPDVKAZHMVI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8579010", Offset = "0x8577E10", VA = "0x188579010")]
		private void HTBCEFIOZYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x857DF60", Offset = "0x857CD60", VA = "0x18857DF60")]
		private bool PTVDFENGQRX(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8576810", Offset = "0x8575610", VA = "0x188576810")]
		private bool AUBMJPBLSCU(Guid a, [Out] KeepsakeCategoryConfigDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x857BD30", Offset = "0x857AB30", VA = "0x18857BD30")]
		private void LYSKMGRCMIA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x857BE10", Offset = "0x857AC10", VA = "0x18857BE10")]
		private bool MGCRSZZJQMR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85802E0", Offset = "0x857F0E0", VA = "0x1885802E0")]
		private List<long> VTDZVRBKNLN(IEnumerable<KeepsakeRoomDTO> a, IReadOnlyList<KeepsakeRoomListDTO> b, long c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8580A80", Offset = "0x857F880", VA = "0x188580A80")]
		private bool XRSDAXKSSVZ(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85769E0", Offset = "0x85757E0", VA = "0x1885769E0", Slot = "47")]
		public string AWBYJAXIXIC(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8578C10", Offset = "0x8577A10", VA = "0x188578C10", Slot = "49")]
		public string HSIIZNBHECR(ProgressionEventConfigurableTextType a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x857CA20", Offset = "0x857B820", VA = "0x18857CA20", Slot = "48")]
		public string NIEDVPXCSOO(ProgressionEventConfigurableTextType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x857E880", Offset = "0x857D680", VA = "0x18857E880")]
		private void TKAEEZQBMKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8577C80", Offset = "0x8576A80", VA = "0x188577C80")]
		private void EBDLRMZRJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8576DE0", Offset = "0x8575BE0", VA = "0x188576DE0")]
		private ProgressionEventConfigurableTextType BRGIKZHDTTK(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x857C290", Offset = "0x857B090", VA = "0x18857C290")]
		private ProgressionEventConfigurableTextType MQGAVYYEWDW(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x857E230", Offset = "0x857D030", VA = "0x18857E230")]
		internal static string QPTTUDHMCOI(KeepsakeCollectInstanceResponse a, string b, bool c, int d, int e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8577870", Offset = "0x8576670", VA = "0x188577870", Slot = "52")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8581FC0", Offset = "0x8580DC0", VA = "0x188581FC0")]
		private DWEOFEGXEUS YVDUURGHGWA(VPDKWOIWOKH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85770D0", Offset = "0x8575ED0", VA = "0x1885770D0")]
		private EAHOQLWZENR CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x857D900", Offset = "0x857C700", VA = "0x18857D900")]
		private Task OnRoomLoadStarted(AIZYZLRFHFX args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85780D0", Offset = "0x8576ED0", VA = "0x1885780D0")]
		[AsyncStateMachine(typeof(<OnRunMigrations>d__182))]
		private Task EYNWMAQCEYH(AIZYZLRFHFX a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x857BF20", Offset = "0x857AD20", VA = "0x18857BF20")]
		private Task MKIJYQQFUWU(AIZYZLRFHFX a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x857DCF0", Offset = "0x857CAF0", VA = "0x18857DCF0")]
		[AsyncStateMachine(typeof(<PeriodicLog>d__184))]
		private Task PFBKPLLUQDH(string a, TimeSpan b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB413B0", Offset = "0xB401B0", VA = "0x180B413B0")]
		[CompilerGenerated]
		private void MPSCFTPHDZF(IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x857E1B0", Offset = "0x857CFB0", VA = "0x18857E1B0")]
		[CompilerGenerated]
		private void PVFZJHWXREB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x857E160", Offset = "0x857CF60", VA = "0x18857E160")]
		[CompilerGenerated]
		private void PVASMBDAHSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8576A40", Offset = "0x8575840", VA = "0x188576A40")]
		[CompilerGenerated]
		private bool BFTIFIHCAWV(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85820B0", Offset = "0x8580EB0", VA = "0x1885820B0")]
		[CompilerGenerated]
		private YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> ZHVKUZSZAYB(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x857B4B0", Offset = "0x857A2B0", VA = "0x18857B4B0")]
		[CompilerGenerated]
		private YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> LBVZGYMRDOJ(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x857DF40", Offset = "0x857CD40", VA = "0x18857DF40")]
		[CompilerGenerated]
		private bool PTBDHGDCPAQ(KeepsakeRoomListDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x857B610", Offset = "0x857A410", VA = "0x18857B610")]
		[CompilerGenerated]
		private bool LHSOXUQFSZP(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8580890", Offset = "0x857F690", VA = "0x188580890")]
		[CompilerGenerated]
		private void XMHBLIGRGYI(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8580A20", Offset = "0x857F820", VA = "0x188580A20")]
		[CompilerGenerated]
		private void XMMIIPAOQJR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8580120", Offset = "0x857EF20", VA = "0x188580120")]
		[CompilerGenerated]
		private Task VTDGQTJSIGB(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KeepsakesConfig : ScriptableObject, LLDYIDIAOAE<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class IOBBVAODQCE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public string SSLBGVYXFBC;

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
				public IOBBVAODQCE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x8574920", Offset = "0x8573720", VA = "0x188574920")]
				internal bool XZCGXYMJFTN(KeepsakeTheme a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8574920", Offset = "0x8573720", VA = "0x188574920")]
				internal bool XYXAARSLWIE(KeepsakeTheme a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8574A30", Offset = "0x8573830", VA = "0x188574A30")]
			public bool SBPJGPFKXOH(string a, [Out] KeepsakeTheme b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85749B0", Offset = "0x85737B0", VA = "0x1885749B0")]
		[AUEAKLYJEMA.Root.GameOnly]
		internal static void UUQSMFQOYUN(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB611A0", Offset = "0xB5FFA0", VA = "0x180B611A0")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float LoopingSfxVolume;
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
