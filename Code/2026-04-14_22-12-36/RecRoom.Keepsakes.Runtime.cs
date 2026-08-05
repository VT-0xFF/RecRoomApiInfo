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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98BA2D0", Offset = "0x98B8ED0", VA = "0x1898BA2D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x98BB700", Offset = "0x98BA300", VA = "0x1898BB700", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class POIBCHQIMNM : IComparer<KeepsakeCategory>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KeepsakeCategory JWPVTOSARFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KeepsakeCategory JWVCQVLYAQL;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE78E10", Offset = "0xE77A10", VA = "0x180E78E10")]
			internal bool KZNDZTDWKEH(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2024C30", Offset = "0x2023830", VA = "0x182024C30")]
			internal bool KZHXCMJZASY(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE78E10", Offset = "0xE77A10", VA = "0x180E78E10")]
			internal bool KZXRUGRRDAZ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2024C30", Offset = "0x2023830", VA = "0x182024C30")]
			internal bool KZSKWZXTTPQ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<KeepsakeCategoryThemePair> WKQLWFLWEKF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public POIBCHQIMNM(List<KeepsakeCategoryThemePair> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98BA520", Offset = "0x98B9120", VA = "0x1898BA520", Slot = "4")]
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
	public class NMWMOHSVXUI : XZQFVGGJDDL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class APCNSDPWXHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public KeepsakeTheme PONLEWAQVEJ;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public APCNSDPWXHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x20684D0", Offset = "0x20670D0", VA = "0x1820684D0")]
			internal bool WBQIBXKBSJP(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KYCSWOMZFQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public long JPPCEFIESGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KeepsakeCategory? QMMUDRTRJVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KYCSWOMZFQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x98AC6E0", Offset = "0x98AB2E0", VA = "0x1898AC6E0")]
			internal void MKHLLZGJQGD(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x98AAFB0", Offset = "0x98A9BB0", VA = "0x1898AAFB0")]
			internal void MKCEOSMMGUU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x98AC770", Offset = "0x98AB370", VA = "0x1898AC770")]
			internal IMNXFPWKHPJ<IEnumerable<Guid>> MKRZGMUEJCV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x92F5D10", Offset = "0x92F4910", VA = "0x1892F5D10")]
			internal bool MKMSJGAGZRM(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KXXLZHTBWEW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KeepsakeRoomInstanceIdsDTO NRVMBVNEGNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public KYCSWOMZFQF FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXXLZHTBWEW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x98AC5B0", Offset = "0x98AB1B0", VA = "0x1898AC5B0")]
			internal IMNXFPWKHPJ<IEnumerable<Guid>> MJMJWYEUEMT(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KXSFCAZEMTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KeepsakeRoomInstancesDTO IITLHLAYIRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public KXXLZHTBWEW FWJCKDVNEOU;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXSFCAZEMTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x98AC490", Offset = "0x98AB090", VA = "0x1898AC490")]
			internal bool MJHCZRKWVBK(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KXMYEUFHDIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Guid POROITRORFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KXSFCAZEMTN FWOJHKPKOAD;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXMYEUFHDIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x98AC3E0", Offset = "0x98AAFE0", VA = "0x1898AC3E0")]
			internal bool MJWXRLSOXJL(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FYJOMNSFPJS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FYJOMNSFPJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x98AB7F0", Offset = "0x98AA3F0", VA = "0x1898AB7F0")]
			internal IMNXFPWKHPJ<IEnumerable<Guid>> XFSAVVSIMEY(IEnumerable<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x98AB560", Offset = "0x98AA160", VA = "0x1898AB560")]
			internal bool XFXHTCMFVQH(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ALMGJJOKNNV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long JPPCEFIESGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ALMGJJOKNNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x98AAF20", Offset = "0x98A9B20", VA = "0x1898AAF20")]
			internal void JOJIMEOSUFW(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x98AAFB0", Offset = "0x98A9BB0", VA = "0x1898AAFB0")]
			internal void JOOPJLIQDRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x98AAFE0", Offset = "0x98A9BE0", VA = "0x1898AAFE0")]
			internal IMNXFPWKHPJ<Dictionary<Guid, KeepsakeCategory>> JOTWGSCNNCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x92F5D10", Offset = "0x92F4910", VA = "0x1892F5D10")]
			internal bool JOZDDYWKWNX(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ALGZMCUNECM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public KeepsakeRoomInstanceIdsDTO NRVMBVNEGNG;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ALGZMCUNECM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x98AAD80", Offset = "0x98A9980", VA = "0x1898AAD80")]
			internal IMNXFPWKHPJ<Dictionary<Guid, KeepsakeCategory>> JPEKBFQIFZG(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ALWUDXCFGKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public KeepsakeRoomInstancesDTO IITLHLAYIRI;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ALWUDXCFGKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x98AB2B0", Offset = "0x98A9EB0", VA = "0x1898AB2B0")]
			internal bool JPJQYMKFPKP(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x98AB390", Offset = "0x98A9F90", VA = "0x1898AB390")]
			internal KeyValuePair<Guid, KeepsakeCategory> JPOXVTECYVY(Guid a)
			{
				return default(KeyValuePair<Guid, KeepsakeCategory>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ALRNGQIHWZE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Guid POROITRORFQ;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ALRNGQIHWZE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1040710", Offset = "0x103F310", VA = "0x181040710")]
			internal bool JPUESZYAIHH(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class AMHHYKPZZHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Guid POROITRORFQ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public AMHHYKPZZHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1040710", Offset = "0x103F310", VA = "0x181040710")]
			internal bool JMTFICLNWTC(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FBJTWAIRGCW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FBJTWAIRGCW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x98AB580", Offset = "0x98AA180", VA = "0x1898AB580")]
			internal IMNXFPWKHPJ<Dictionary<Guid, KeepsakeCategory>> VMBZNQTTKDX(Dictionary<Guid, KeepsakeCategory> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x98AB560", Offset = "0x98AA160", VA = "0x1898AB560")]
			internal bool VLWSQJZWASO(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FBPATHCOPOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public KeepsakeRoomInstanceIdsDTO IDIAUKOSVXA;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FBPATHCOPOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x98AB770", Offset = "0x98AA370", VA = "0x1898AB770")]
			internal bool VLRLTDFYRHF(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class RVYRMMHYWFV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Dictionary<Guid, KeepsakeCategory> ZBTDONHRKIE;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public RVYRMMHYWFV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x98BA7F0", Offset = "0x98B93F0", VA = "0x1898BA7F0")]
			internal KeyValuePair<KeepsakeCategory, int> UQDHXRSEBNC(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class RVTKPFOBMUM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public KeepsakeCategory BNGFGCSOOBW;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public RVTKPFOBMUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xF9D240", Offset = "0xF9BE40", VA = "0x180F9D240")]
			internal bool UQTCPLZWDVD(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class XYLGVJBZPAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Dictionary<Guid, KeepsakeCategory> ZBTDONHRKIE;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public XYLGVJBZPAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x98BB440", Offset = "0x98BA040", VA = "0x1898BB440")]
			internal KeyValuePair<KeepsakeCategory, int> ZNQJMXKODYY(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class XYFZYCICFPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public KeepsakeCategory BNGFGCSOOBW;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public XYFZYCICFPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xF9D240", Offset = "0xF9BE40", VA = "0x180F9D240")]
			internal bool ZOGEERSGGGZ(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OIEKBYFDVKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<KeepsakeRoomDTO, bool> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public OIEKBYFDVKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x98BA350", Offset = "0x98B8F50", VA = "0x1898BA350")]
			internal bool FALYVYFYNTS(DateTime a, DateTime b, int c, TimeSpan d, TimeSpan e, int f)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x98BA460", Offset = "0x98B9060", VA = "0x1898BA460")]
			internal bool JHPABEXQRUJ(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x98BA440", Offset = "0x98B9040", VA = "0x1898BA440")]
			internal bool JHEMGRJVYXR(KeepsakeRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x98BA440", Offset = "0x98B9040", VA = "0x1898BA440")]
			internal bool JGZFJKPYPMI(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NLEPLKVPMDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public long RBVLNBTJICX;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public NLEPLKVPMDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x135B800", Offset = "0x135A400", VA = "0x18135B800")]
			internal bool BWZCIUYTBST(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HUZLSQCASXZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public long XSGEVCJYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Func<KeepsakeRoomDTO, bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HUZLSQCASXZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x98AB9C0", Offset = "0x98AA5C0", VA = "0x1898AB9C0")]
			internal bool ANEULJBPDMJ(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x271EC80", Offset = "0x271D880", VA = "0x18271EC80")]
			internal bool AMZNOCHRUBA(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class UPOJJCBIJAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public long RBVLNBTJICX;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UPOJJCBIJAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x98BB3E0", Offset = "0x98B9FE0", VA = "0x1898BB3E0")]
			internal bool YXCSEEEFEWU(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class CIIRGYZVOQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public long RBVLNBTJICX;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public CIIRGYZVOQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x135B800", Offset = "0x135A400", VA = "0x18135B800")]
			internal bool VTFZUYMINJP(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class CJAMRDAXVYR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public KeepsakeCategory QMMUDRTRJVL;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public CJAMRDAXVYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x22A1B30", Offset = "0x22A0730", VA = "0x1822A1B30")]
			internal bool CZDZPRUMYGL(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class HBSWTXIMELF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Guid OWKEGZBDWLZ;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HBSWTXIMELF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x98AB960", Offset = "0x98AA560", VA = "0x1898AB960")]
			internal bool LMUTZQKDVPQ(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class QNVFXBAEZXD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public KeepsakeCategory QMMUDRTRJVL;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QNVFXBAEZXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x98BA7B0", Offset = "0x98B93B0", VA = "0x1898BA7B0")]
			internal bool DITFVGYUQBN(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class BOPKLTTVAQC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public long JCDTDCWDSKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public long? RZDLVNSHBRR;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BOPKLTTVAQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x98AB4E0", Offset = "0x98AA0E0", VA = "0x1898AB4E0")]
			internal bool IOFLVBALTUA(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class ZIIKKMCZKJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IReadOnlyList<KeepsakeRoomListDTO> VYYYRIWKFIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public long RBVLNBTJICX;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZIIKKMCZKJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x98BB610", Offset = "0x98BA210", VA = "0x1898BB610")]
			internal bool MYHCRIKSHBB(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class ZIDDNFJCAYA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public KeepsakeRoomDTO COXFQJUBKDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public ZIIKKMCZKJJ FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZIDDNFJCAYA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x98BB590", Offset = "0x98BA190", VA = "0x1898BB590")]
			internal bool MYMJOPEPQMK(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class JLXHRLLXAWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KeepsakeCategory QMMUDRTRJVL;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public JLXHRLLXAWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x98ABF60", Offset = "0x98AAB60", VA = "0x1898ABF60")]
			internal IMNXFPWKHPJ<Guid> EOCAMTMJAKZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x98AC350", Offset = "0x98AAF50", VA = "0x1898AC350")]
			internal void XPNODNPBATW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x98AC380", Offset = "0x98AAF80", VA = "0x1898AC380")]
			internal void ZKASPZZDUOW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x98AC0A0", Offset = "0x98AACA0", VA = "0x1898AC0A0")]
			internal void XPDAJABGHXE(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x98AC320", Offset = "0x98AAF20", VA = "0x1898AC320")]
			internal void XPIHGGVDRIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JIODKJYDTEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public NMWMOHSVXUI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string JPTYZZPJECC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int WENKEYIFJYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int TIQZHZJKFLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Guid OWKEGZBDWLZ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public JIODKJYDTEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x98ABBC0", Offset = "0x98AA7C0", VA = "0x1898ABBC0")]
			internal void ZWORDBYWWWJ(KeepsakeCollectInstanceResponse a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x98ABA80", Offset = "0x98AA680", VA = "0x1898ABA80")]
			internal void OVRUEQXGHKJ(string a)
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
			public NMWMOHSVXUI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public EICHPLWXAPH args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x98BA940", Offset = "0x98B9540", VA = "0x1898BA940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x98BAE50", Offset = "0x98B9A50", VA = "0x1898BAE50", Slot = "5")]
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
			public NMWMOHSVXUI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x98BAEB0", Offset = "0x98B9AB0", VA = "0x1898BAEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x98BB140", Offset = "0x98B9D40", VA = "0x1898BB140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DateTime DACVLFKIHHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HZMQRERDGQL QHOSESITETA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TYUTCDXHZWW SOTMAMEJBXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ELRGTCSJELU KLVUOMEZHRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FXJCVIXFMJM FAIINZXHYSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MBLRPYWQFOT EBLANSETYVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IUSNJLRJLOC SSQZGEVYNJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly RUFAVNSMJJA ZJFDYPREQSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IDLXRUJKSDP ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MACYYLIGCSS WBYGWCZJLHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LEQJXPAMBJO UPJONANUPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly BWOUNMNPOEO HABSBPLZRBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly VFDTTZVTCLB QNHRBUFKAJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly WZPPBMTELYB NEFIWOVBDUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly OLXSVKGLTSR JHWPGRGOPRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly GEPMWXDIONU DGULWQDXUNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly WVKPEZKZXWE<KeepsakesConfig.KeepsakesOptions> TMVYLHGVNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CQTKPAWHYMF YSEFCYENSIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<Guid, KeepsakeInstanceDTO> ZSNVSFIIIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HashSet<Guid> XSMGEOECINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<long> NRJUJNJKRIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<KeepsakeCategory, int> VQXMEGEEXRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HashSet<Guid> SFHFKWRAUVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IDisposable WTIRNIKOXAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task YVYAZKKGCYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IMNXFPWKHPJ<Guid> OGHSJWFUDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long? NJXSHFRRFQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KeepsakeProgressionEventInstancesDTO NWZUPADOBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IMNXFPWKHPJ<KeepsakeProgressionEventInstancesDTO> ASIKXYASFEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> JDHRKWROAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KeepsakeGlobalConfigDTO FVIWZBMHPAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<long> TGJGTDDUBST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HashSet<long> JLAIYPZWKQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private List<KeepsakeRoomListDTO> WGAZWVKUIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<KeepsakeRoomListDTO> PWYMEMMKRYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private List<KeepsakeRoomListDTO> XWWBCSWQUBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<long, string> WYZBJOXDMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<long, string> ZTBZAWPUJXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<long, DateTime> RNPQXBPQWJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Dictionary<long, List<KeepsakeRoomDTO>> FFBJRPYDBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Dictionary<long, List<KeepsakeRoomDTO>> HVKJQEEXCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Dictionary<long, long> GZLYBNIEVLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<string> TBHYQPRQCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DateTime VTWZXLVRNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IDisposable LLIOBOSKNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<Guid, KeepsakeCategory> SKFDVKJHLSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<KeepsakeCategory, int> ICJSEYBZLCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<KeepsakeCategoryThemePair> DMFVYNAVGIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private POIBCHQIMNM XJSGDCZNHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool SYPLBUTGKMI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HFGXYCENBSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DCD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JCAAJTYONIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x98AEDF0", Offset = "0x98AD9F0", VA = "0x1898AEDF0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KPSRULFTCZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98B2760", Offset = "0x98B1360", VA = "0x1898B2760", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private long AHWTHYYNFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x98B4160", Offset = "0x98B2D60", VA = "0x1898B4160")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private long? EKBAYABSZML
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x98B49A0", Offset = "0x98B35A0", VA = "0x1898B49A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool WONAYULEBNU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x98B13F0", Offset = "0x98AFFF0", VA = "0x1898B13F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<KeepsakeRoomListDTO> RZXNWBOZNYC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xDA5B90", Offset = "0xDA4790", VA = "0x180DA5B90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<KeepsakeRoomListDTO> PXFOWAWMXSE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xDA5A00", Offset = "0xDA4600", VA = "0x180DA5A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<KeepsakeRoomListDTO> QXFTQCPGPOY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E60", Offset = "0xDA4A60", VA = "0x180DA5E60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<long, string> QDJBOYEHKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xDA5B80", Offset = "0xDA4780", VA = "0x180DA5B80", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal bool IXTTYEEUIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x146E9A0", Offset = "0x146D5A0", VA = "0x18146E9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid?> FIQONTOGUKR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98AEB40", Offset = "0x98AD740", VA = "0x1898AEB40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x98B4450", Offset = "0x98B3050", VA = "0x1898B4450", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action REBNZRMJNCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x98B6D70", Offset = "0x98B5970", VA = "0x1898B6D70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x98B2D30", Offset = "0x98B1930", VA = "0x1898B2D30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action FOWBOGTEUAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x98AF280", Offset = "0x98ADE80", VA = "0x1898AF280", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x98B22D0", Offset = "0x98B0ED0", VA = "0x1898B22D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98B8DF0", Offset = "0x98B79F0", VA = "0x1898B8DF0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal NMWMOHSVXUI([Inject(null)][NotNull] HZMQRERDGQL notificationManager, [Inject(null)][NotNull] ZJTKXXHCJZZ roomLoader, [Inject(null)][NotNull] TYUTCDXHZWW creationHelper, [Inject(null)][NotNull] ELRGTCSJELU roomPersistenceManager, [Inject(null)][NotNull] FXJCVIXFMJM progressionEventsManager, [Inject(null)][NotNull] MBLRPYWQFOT roomManager, [Inject(null)][NotNull] IUSNJLRJLOC storefrontManager, [Inject(null)][NotNull] RUFAVNSMJJA roomSaveValidation, [Inject(null)][NotNull] IDLXRUJKSDP networking, [Inject(null)][NotNull] ZAWWRGOZLHU scheduledUpdateService, [Inject(null)][NotNull] MACYYLIGCSS recNetMatchmaking, [Inject(null)][NotNull] LEQJXPAMBJO recNetKeepsakes, [Inject(null)][NotNull] BWOUNMNPOEO recNetAccounts, [Inject(null)][NotNull] VFDTTZVTCLB recNetStorefronts, [Inject(null)][NotNull] WZPPBMTELYB recNetGifts, [Inject(null)][NotNull] OLXSVKGLTSR timeService, [Inject(null)][NotNull] GEPMWXDIONU debugLogger, [Inject(null)][NotNull] WVKPEZKZXWE<KeepsakesConfig.KeepsakesOptions> options, [Inject(null)][NotNull] CQTKPAWHYMF gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98B5F70", Offset = "0x98B4B70", VA = "0x1898B5F70", Slot = "15")]
		public bool TFCIXRNDGKH(List<string> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98AD760", Offset = "0x98AC360", VA = "0x1898AD760", Slot = "16")]
		public IMNXFPWKHPJ<Guid> ATRYMYYMDNY(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98B0580", Offset = "0x98AF180", VA = "0x1898B0580", Slot = "17")]
		public GMTKWIVSBCA FJANYORHDYF(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98B07E0", Offset = "0x98AF3E0", VA = "0x1898B07E0", Slot = "18")]
		public GMTKWIVSBCA FKEQAZOIDDG(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98B2BD0", Offset = "0x98B17D0", VA = "0x1898B2BD0", Slot = "19")]
		public bool LSJGMHMCTFO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98B4C90", Offset = "0x98B3890", VA = "0x1898B4C90", Slot = "20")]
		public bool RTTPZLJIAHO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98B36B0", Offset = "0x98B22B0", VA = "0x1898B36B0")]
		public KeepsakeTheme OXXHOJPVQXI(Guid a)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98B82F0", Offset = "0x98B6EF0", VA = "0x1898B82F0")]
		public bool YXTIBBLKQPE(KeepsakeCategory a, [Out] KeepsakeTheme b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98B1CA0", Offset = "0x98B08A0", VA = "0x1898B1CA0")]
		public List<KeepsakeTheme> ILSILLPGKLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98B2050", Offset = "0x98B0C50", VA = "0x1898B2050")]
		public int IQLQJWAUZOD(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98ACF20", Offset = "0x98ABB20", VA = "0x1898ACF20")]
		public KeepsakeCategory AJNARVELKSJ(Guid a)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98B77C0", Offset = "0x98B63C0", VA = "0x1898B77C0", Slot = "34")]
		public List<KeepsakeCategory> XBIALFUUKUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98B0310", Offset = "0x98AEF10", VA = "0x1898B0310", Slot = "35")]
		public IComparer<KeepsakeCategory> FBCFZNOOJEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98B1270", Offset = "0x98AFE70", VA = "0x1898B1270", Slot = "32")]
		public string GPHEIDGAPCR(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98AEC70", Offset = "0x98AD870", VA = "0x1898AEC70", Slot = "33")]
		public string CSJBGLMAMFT(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98B1640", Offset = "0x98B0240", VA = "0x1898B1640", Slot = "21")]
		public bool HFBQPKFBEYC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98B84D0", Offset = "0x98B70D0", VA = "0x1898B84D0", Slot = "22")]
		public void ZCTZHTDAGDS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98AFE40", Offset = "0x98AEA40", VA = "0x1898AFE40", Slot = "23")]
		public void ECFWDUZZEAE(KeepsakeCategory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98ACCF0", Offset = "0x98AB8F0", VA = "0x1898ACCF0", Slot = "24")]
		public void AGMTXFSSCJO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98B7ED0", Offset = "0x98B6AD0", VA = "0x1898B7ED0", Slot = "25")]
		public int YVGFYOBCMYC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98ADE60", Offset = "0x98ACA60", VA = "0x1898ADE60", Slot = "31")]
		public IMNXFPWKHPJ<IEnumerable<Guid>> BBPYEWUESMP(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98B6750", Offset = "0x98B5350", VA = "0x1898B6750", Slot = "30")]
		public IMNXFPWKHPJ<IEnumerable<Guid>> UFLRDAYARKG(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98B69B0", Offset = "0x98B55B0", VA = "0x1898B69B0", Slot = "54")]
		public IMNXFPWKHPJ<Dictionary<Guid, KeepsakeCategory>> VCFKIJGBHGO(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98B4DA0", Offset = "0x98B39A0", VA = "0x1898B4DA0", Slot = "55")]
		public IMNXFPWKHPJ<Dictionary<Guid, KeepsakeCategory>> RXMLUQWIJIV(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98B0FC0", Offset = "0x98AFBC0", VA = "0x1898B0FC0", Slot = "26")]
		public IMNXFPWKHPJ<int> FRSLFBDAQKC(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98B2820", Offset = "0x98B1420", VA = "0x1898B2820", Slot = "27")]
		public IMNXFPWKHPJ<int> LHZCGVOMCPM(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98B7350", Offset = "0x98B5F50", VA = "0x1898B7350", Slot = "28")]
		public IMNXFPWKHPJ<Dictionary<KeepsakeCategory, int>> WOUEPGGETBN(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98B6260", Offset = "0x98B4E60", VA = "0x1898B6260", Slot = "29")]
		public IMNXFPWKHPJ<Dictionary<KeepsakeCategory, int>> TICZNJYVOLJ(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x98B6200", Offset = "0x98B4E00", VA = "0x1898B6200", Slot = "37")]
		public bool THOWTVAGAGX(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98B8890", Offset = "0x98B7490", VA = "0x1898B8890", Slot = "56")]
		public bool ZQIRIZMXBGX(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98ADDC0", Offset = "0x98AC9C0", VA = "0x1898ADDC0", Slot = "38")]
		public bool BAAPEOGQLOC(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98B6FB0", Offset = "0x98B5BB0", VA = "0x1898B6FB0", Slot = "57")]
		public bool WHTSUXFTPCE(long a, [Out] KeepsakeRoomLockStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98B7D90", Offset = "0x98B6990", VA = "0x1898B7D90", Slot = "39")]
		public bool YOGGPSORDYF(long a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98B37F0", Offset = "0x98B23F0", VA = "0x1898B37F0", Slot = "40")]
		public long OYXDOTWHELF(long a, bool b = false)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98AD650", Offset = "0x98AC250", VA = "0x1898AD650", Slot = "41")]
		public long ASNWVHNCZBT(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x98AEEF0", Offset = "0x98ADAF0", VA = "0x1898AEEF0", Slot = "42")]
		public int CYWDFVGRDIS(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x98B6320", Offset = "0x98B4F20", VA = "0x1898B6320", Slot = "43")]
		public bool TSRZQWEUENB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x98AE220", Offset = "0x98ACE20", VA = "0x1898AE220", Slot = "44")]
		public bool BFSRLIMHABP(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x98B7550", Offset = "0x98B6150", VA = "0x1898B7550", Slot = "45")]
		public IReadOnlyList<long> WQWBRXRFPDQ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x98B5010", Offset = "0x98B3C10", VA = "0x1898B5010", Slot = "46")]
		public int SVYNLIAWHAD(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x98B0D10", Offset = "0x98AF910", VA = "0x1898B0D10", Slot = "50")]
		public long FLUTWOSQXZY(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x98B88F0", Offset = "0x98B74F0", VA = "0x1898B88F0", Slot = "51")]
		public KeepsakeCategory ZTUDDYYAMLU()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98B31B0", Offset = "0x98B1DB0", VA = "0x1898B31B0")]
		private void ODGELZRSZZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x98AE490", Offset = "0x98AD090", VA = "0x1898AE490")]
		private void BVICINIJILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x98B6E10", Offset = "0x98B5A10", VA = "0x1898B6E10")]
		private int WGDPWYMIWZP(KeepsakeRoomListDTO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x98B21D0", Offset = "0x98B0DD0", VA = "0x1898B21D0")]
		private int JPIHHXIZYVA(DateTime a, DateTime b, TimeSpan c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x98AFE90", Offset = "0x98AEA90", VA = "0x1898AFE90")]
		private void EISVZVDKCCT(IEnumerable<KeepsakeInstanceDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98B2980", Offset = "0x98B1580", VA = "0x1898B2980")]
		private void LJCFOMZFXUF(IEnumerable<KeepsakeCollectionRecordDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98AEBF0", Offset = "0x98AD7F0", VA = "0x1898AEBF0")]
		private void CMDNUUKSAMY(IEnumerable<long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xD69430", Offset = "0xD68030", VA = "0x180D69430")]
		private void GEAJMSYRLHS(KeepsakeGlobalConfigDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x98B4A30", Offset = "0x98B3630", VA = "0x1898B4A30")]
		private bool RRKVCCCMMPR(KeepsakeCategory a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x98B4900", Offset = "0x98B3500", VA = "0x1898B4900")]
		private bool QJSTFZRQBJR([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98ACC90", Offset = "0x98AB890", VA = "0x1898ACC90")]
		private bool AGGVAEBCVAW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x98B7AE0", Offset = "0x98B66E0", VA = "0x1898B7AE0")]
		private IEnumerable<Guid> XWCYUQCVYGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x98AE3D0", Offset = "0x98ACFD0", VA = "0x1898AE3D0")]
		private IEnumerable<KeepsakeInstanceDTO> BREWEGOKEUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98ADD30", Offset = "0x98AC930", VA = "0x1898ADD30")]
		private void AXZPSTSRTXW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98AEE40", Offset = "0x98ADA40", VA = "0x1898AEE40")]
		private bool CVUZGQRYHSO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98B8700", Offset = "0x98B7300", VA = "0x1898B8700")]
		private void ZQFSNHEWGEM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x98B2F60", Offset = "0x98B1B60", VA = "0x1898B2F60")]
		private void MHYUYUFIZXR(KeepsakeCategory a, int b, Dictionary<KeepsakeCategory, int> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98B4F20", Offset = "0x98B3B20", VA = "0x1898B4F20")]
		private int SCARRLTOTLF(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98B4230", Offset = "0x98B2E30", VA = "0x1898B4230")]
		private void PQOZMKICLYO(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98B6400", Offset = "0x98B5000", VA = "0x1898B6400")]
		private void TTXNJUCPMIE(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x98B8D00", Offset = "0x98B7900", VA = "0x1898B8D00")]
		private void ZWPCTOEZNMH(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x98AE3A0", Offset = "0x98ACFA0", VA = "0x1898AE3A0")]
		private void BHWGLIISOVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x98B1250", Offset = "0x98AFE50", VA = "0x1898B1250")]
		private void GJXFYNXJZDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x98B41C0", Offset = "0x98B2DC0", VA = "0x1898B41C0")]
		private void PHMWTVKQQHZ(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x98AE3A0", Offset = "0x98ACFA0", VA = "0x1898AE3A0")]
		private void HLFITTUJBWG(GiftPackageReceivedArgs a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x98AE3A0", Offset = "0x98ACFA0", VA = "0x1898AE3A0")]
		private void LFKSERFBLNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x98B1900", Offset = "0x98B0500", VA = "0x1898B1900")]
		private void IGIPXZOEVDY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98AD080", Offset = "0x98ABC80", VA = "0x1898AD080")]
		private void AKCUFWTZSAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x98AF570", Offset = "0x98AE170", VA = "0x1898AF570")]
		private bool DUILDACKEON(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x98B03B0", Offset = "0x98AEFB0", VA = "0x1898B03B0")]
		private bool FIEQAPSIEWE(Guid a, [Out] KeepsakeCategoryConfigDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98B4CC0", Offset = "0x98B38C0", VA = "0x1898B4CC0")]
		private void RVBEWZSLMXK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98B1530", Offset = "0x98B0130", VA = "0x1898B1530")]
		private bool GYQAMOCOQMR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98AF770", Offset = "0x98AE370", VA = "0x1898AF770")]
		private List<long> DWPLCXRUTJR(IEnumerable<KeepsakeRoomDTO> a, IReadOnlyList<KeepsakeRoomListDTO> b, long c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98B2370", Offset = "0x98B0F70", VA = "0x1898B2370")]
		private bool JYOMDXSRIYD(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98B3150", Offset = "0x98B1D50", VA = "0x1898B3150", Slot = "47")]
		public string NLMZLSUKENE(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98B4500", Offset = "0x98B3100", VA = "0x1898B4500", Slot = "49")]
		public string PTXUWXNBRGN(ProgressionEventConfigurableTextType a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98B68E0", Offset = "0x98B54E0", VA = "0x1898B68E0", Slot = "48")]
		public string UMTPYQTZAQC(ProgressionEventConfigurableTextType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x98B50C0", Offset = "0x98B3CC0", VA = "0x1898B50C0")]
		private void TABOZBZMCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x98B2DD0", Offset = "0x98B19D0", VA = "0x1898B2DD0")]
		private void MGJEWEXKVFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x98B18E0", Offset = "0x98B04E0", VA = "0x1898B18E0")]
		private ProgressionEventConfigurableTextType IDDIENZSOKY(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x98B2740", Offset = "0x98B1340", VA = "0x1898B2740")]
		private ProgressionEventConfigurableTextType KPYFQJDCVUY(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98B0B40", Offset = "0x98AF740", VA = "0x1898B0B40")]
		internal static string FLFTLCEFVOM(KeepsakeCollectInstanceResponse a, string b, bool c, int d, int e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x98AFA30", Offset = "0x98AE630", VA = "0x1898AFA30", Slot = "52")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98B7900", Offset = "0x98B6500", VA = "0x1898B7900")]
		private WMPSFPJSUNY XJPJPGAICCY(DDFOJMMWCEL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98AF0D0", Offset = "0x98ADCD0", VA = "0x1898AF0D0")]
		private UELIVBOERHZ CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98B3D70", Offset = "0x98B2970", VA = "0x1898B3D70")]
		private Task OnRoomLoadStarted(EICHPLWXAPH args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98B3040", Offset = "0x98B1C40", VA = "0x1898B3040")]
		[AsyncStateMachine(typeof(<OnRunMigrations>d__182))]
		private Task NKKYNYWBBOH(EICHPLWXAPH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98AF490", Offset = "0x98AE090", VA = "0x1898AF490")]
		private Task DUIABZIUVHW(EICHPLWXAPH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98B1400", Offset = "0x98B0000", VA = "0x1898B1400")]
		[AsyncStateMachine(typeof(<PeriodicLog>d__184))]
		private Task GUVVWMIRACB(string a, TimeSpan b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD69470", Offset = "0xD68070", VA = "0x180D69470")]
		[CompilerGenerated]
		private void DCWLBWAALDB(IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x98AEB20", Offset = "0x98AD720", VA = "0x1898AEB20")]
		[CompilerGenerated]
		private void CEBXVYQFBIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x98AEAD0", Offset = "0x98AD6D0", VA = "0x1898AEAD0")]
		[CompilerGenerated]
		private void CDWQYRWHRXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98B6650", Offset = "0x98B5250", VA = "0x1898B6650")]
		[CompilerGenerated]
		private bool UEWBNWVURGJ(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98B7980", Offset = "0x98B6580", VA = "0x1898B7980")]
		[CompilerGenerated]
		private IMNXFPWKHPJ<Dictionary<KeepsakeCategory, int>> XTWPSRHWSQZ(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98B7C30", Offset = "0x98B6830", VA = "0x1898B7C30")]
		[CompilerGenerated]
		private IMNXFPWKHPJ<Dictionary<KeepsakeCategory, int>> YOCHUJJBRHP(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98AEC50", Offset = "0x98AD850", VA = "0x1898AEC50")]
		[CompilerGenerated]
		private bool COVGVNVQXZO(KeepsakeRoomListDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98AF320", Offset = "0x98ADF20", VA = "0x1898AF320")]
		[CompilerGenerated]
		private bool DNUAANVBDJD(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x98B0120", Offset = "0x98AED20", VA = "0x1898B0120")]
		[CompilerGenerated]
		private void EOLEIZSNXSY(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x98B02B0", Offset = "0x98AEEB0", VA = "0x1898B02B0")]
		[CompilerGenerated]
		private void EOQLGGMLHEH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98B8540", Offset = "0x98B7140", VA = "0x1898B8540")]
		[CompilerGenerated]
		private Task ZPLPMVDPSIF(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KeepsakesConfig : ScriptableObject, WVKPEZKZXWE<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class UFMXOEVUXJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public string VAGLMZTKZME;

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFMXOEVUXJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x98BB3B0", Offset = "0x98B9FB0", VA = "0x1898BB3B0")]
				internal bool PTNTWDDODJZ(KeepsakeTheme a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x98BB3B0", Offset = "0x98B9FB0", VA = "0x1898BB3B0")]
				internal bool PTIMYWJQTYQ(KeepsakeTheme a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x98ACAD0", Offset = "0x98AB6D0", VA = "0x1898ACAD0")]
			public bool MIXPSOVBLIT(string a, [Out] KeepsakeTheme b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x98ACA50", Offset = "0x98AB650", VA = "0x1898ACA50")]
		[GEPWJNEAFDW.Root.GameOnly]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
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
