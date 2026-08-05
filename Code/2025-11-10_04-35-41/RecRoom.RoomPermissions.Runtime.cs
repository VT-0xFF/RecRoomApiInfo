using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logger;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.Utils.PrefParsers;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B2EE10", Offset = "0x8B2E210", VA = "0x188B2EE10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum VotekickType
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B33C80", Offset = "0x8B33080", VA = "0x188B33C80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Systems.PlayerRoles
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void OnRolePermissionUpdated<TPermission>(TPermission rolePermission);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void OnRoomRoleUpdated(JCSDFORPEFX player);
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DEPRECATED_HostPermission
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Hosts,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Everyone
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LBFDPWILYET
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool NCCEUEITIZK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool YHKESMOIKEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool LYMTTBHVJCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool OTBAMZTYLMX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool OYPSFIWFHFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool WWVRCLLRKCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool FXBNIPBGMGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class QUKRWTAAGWW
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[Flags]
		public enum DEPRECATED_RoomRoleId
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			AG_EVERYONE = 0,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			AG_CREATOR = 0x200000,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			AG_COOWNER = 0x400000,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			AG_HOST = 0x800000,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			AG_MODERATOR = 0x1000000
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Guid IPKVTLFODJQ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid AWVQCTBSKJR;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid CTMHRQMRCYY;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid YPOCZXYRGCI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid KMTJPUWZBTF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid WVQDVBUWYJE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly CAHJYGUWIMH<AccountRoleType, Guid> MMNBNYSDITJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> PTDOBPLIDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F4C0", Offset = "0x8B2E8C0", VA = "0x188B2F4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F530", Offset = "0x8B2E930", VA = "0x188B2F530")]
		public static AccountRoleType FGSHMZSEWXL(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F420", Offset = "0x8B2E820", VA = "0x188B2F420")]
		public static Guid ACRJYIUWPDP(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F5C0", Offset = "0x8B2E9C0", VA = "0x188B2F5C0")]
		public static bool FKSITDAUPBM(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F650", Offset = "0x8B2EA50", VA = "0x188B2F650")]
		public static bool LYDQWGRLLJE(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F7E0", Offset = "0x8B2EBE0", VA = "0x188B2F7E0")]
		public static AccountRoleType XFAYFYMDLAB(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F730", Offset = "0x8B2EB30", VA = "0x188B2F730")]
		public static DEPRECATED_RoomRoleId PTEFHDYCESA(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F6F0", Offset = "0x8B2EAF0", VA = "0x188B2F6F0")]
		internal static AccountRoleType MPOYNZJBFUX(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QOESEBVKVAX
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance VKSERIDBURD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO JWXGJGTWNSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> SFWMWFQZTQK;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action ZESERDNCSAQ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType XAONGICDSYG(JCSDFORPEFX a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> GPTAYNZKFNB(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task IIFPKFDCPNB(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task HHWKPVOMOXP(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<JCSDFORPEFX> JIPYWDHYMYA();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class LAHWKWJULUB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E280", Offset = "0x8B2D680", VA = "0x188B2E280")]
		public static AccountRoleType TPTEOUJFXLJ(this QOESEBVKVAX a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface ZQXUCSITBOJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		PKFJKRUXERA GLYINPOTQII
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated HJKJQGZVXHK;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<OMAVDDSSABA> FQIIPLYMFDS(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OMAVDDSSABA MOFDEVMZQAS(JCSDFORPEFX a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RCMBXYRPKZZ(JCSDFORPEFX a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<OMAVDDSSABA> VZIEDLQHXCI(JCSDFORPEFX a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HWYYVHUQXUU(JCSDFORPEFX a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		OMAVDDSSABA DPFPQVUKGIF(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IWZLRAZWJJB<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string VVEZUJSXZAJ(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool BYPGDRMALMN(JCSDFORPEFX a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface EXHSTGKFMVE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task LKBKGRNUQKB(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface UFAXMROCRAQ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> GKZZWOPJBSD;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? JFQFDZCDRWB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? GATNWYBTRZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F170", Offset = "0x8B2E570", VA = "0x188B2F170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F240", Offset = "0x8B2E640", VA = "0x188B2F240")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F330", Offset = "0x8B2E730", VA = "0x188B2F330")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool WVRERNDGVJJ(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> AFOXCYDPAER;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5A82020", Offset = "0x5A81420", VA = "0x185A82020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5A82580", Offset = "0x5A81980", VA = "0x185A82580", Slot = "4")]
		public override bool WVRERNDGVJJ(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5A82CA0", Offset = "0x5A820A0", VA = "0x185A82CA0")]
		public bool YWXUJFIINCP(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5A82F20", Offset = "0x5A82320", VA = "0x185A82F20")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class MSZLPLAGISM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> ITOBDRENLER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> QNRXZXDWSHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly RWEFGBLHCFZ OQHDBIKUNXB;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B2EB70", Offset = "0x8B2DF70", VA = "0x188B2EB70")]
		public MSZLPLAGISM(RWEFGBLHCFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E910", Offset = "0x8B2DD10", VA = "0x188B2E910")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37809B0", Offset = "0x377FDB0", VA = "0x1837809B0")]
		public bool LOGPZDTCKXL<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3780280", Offset = "0x377F680", VA = "0x183780280")]
		public (bool, a?) EQLMVSQHIDH<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E830", Offset = "0x8B2DC30", VA = "0x188B2E830")]
		public bool LOGPZDTCKXL(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E6B0", Offset = "0x8B2DAB0", VA = "0x188B2E6B0")]
		public (bool, object) EQLMVSQHIDH(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3781170", Offset = "0x3780570", VA = "0x183781170")]
		private void PXXSLUPFFGO<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E5E0", Offset = "0x8B2D9E0", VA = "0x188B2E5E0")]
		private Permission CQXDXSUHMZO(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E980", Offset = "0x8B2DD80", VA = "0x188B2E980")]
		public void TTXGPYXKEOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class YNRSDAGEYDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string AMXDXJEJKJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type SNYMXFMEGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType RDIYEKXDRKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission MNHVOEJAQMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet ABICWUAXAYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue YTTJXKQMRCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission SUFBMGIXAOU;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B33BE0", Offset = "0x8B32FE0", VA = "0x188B33BE0")]
		public YNRSDAGEYDB(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B33AE0", Offset = "0x8B32EE0", VA = "0x188B33AE0")]
		public object GOQICMSZOEJ(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C206D0", Offset = "0x3C1FAD0", VA = "0x183C206D0")]
		public void PXXSLUPFFGO<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B33B30", Offset = "0x8B32F30", VA = "0x188B33B30")]
		public void PXXSLUPFFGO(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class XUNDRAWLYXW<a> : YNRSDAGEYDB where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet PPYVXFAPOCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue LQONFRUUNCZ;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x59877A0", Offset = "0x5986BA0", VA = "0x1859877A0")]
			internal string SUKNQOTQISI(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5987DF0", Offset = "0x59871F0", VA = "0x185987DF0")]
			internal object SUPUNVNNSDR(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF200", Offset = "0x3DBE600", VA = "0x183DBF200")]
		public XUNDRAWLYXW(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3DBDEE0", Offset = "0x3DBD2E0", VA = "0x183DBDEE0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEC40", Offset = "0x3DBE040", VA = "0x183DBEC40")]
		private static string Serialize(SerializeValueForRecNet? serializeValueForRecNet, object? value)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal delegate string SerializeValueForRecNet(object? value);
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal delegate object DeserializeRecNetValue(string? serializedValue, [Optional] object defaultValue);
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal delegate Permission ConstructPermission();
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class RWEFGBLHCFZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class RLMMWGRAJRH : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static RLMMWGRAJRH LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8B2FB10", Offset = "0x8B2EF10", VA = "0x188B2FB10", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B2FC60", Offset = "0x8B2F060", VA = "0x188B2FC60", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RLMMWGRAJRH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class OLRRISBBKPV : ACNPEQLTMWK<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B2EE90", Offset = "0x8B2E290", VA = "0x188B2EE90", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8B2EF80", Offset = "0x8B2E380", VA = "0x188B2EF80", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F130", Offset = "0x8B2E530", VA = "0x188B2F130")]
			public OLRRISBBKPV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly YJUAMZCDDYI ZHNFHTGBSEQ;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly OLRRISBBKPV CNFALXGMSJJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<YNRSDAGEYDB> IKBTVSIIZLM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> UOOPZDJYGSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, YNRSDAGEYDB> AYVRJLNASJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B31DD0", Offset = "0x8B311D0", VA = "0x188B31DD0")]
		public RWEFGBLHCFZ([Optional] IList<YNRSDAGEYDB>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FF20", Offset = "0x8B2F320", VA = "0x188B2FF20")]
		public YNRSDAGEYDB OMAMBAIWNKW(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface PKFJKRUXERA
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		OMAVDDSSABA XBCVBZJMITJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class KGHNRFVYIIX : PKFJKRUXERA
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static KGHNRFVYIIX FCHIVKOQIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly IQMOCMYAFWZ UCMZYXDZCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<IQMOCMYAFWZ> ZANNQFAXEOG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public OMAVDDSSABA XBCVBZJMITJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E180", Offset = "0x8B2D580", VA = "0x188B2E180")]
		public KGHNRFVYIIX(IQMOCMYAFWZ a, IReadOnlyList<IQMOCMYAFWZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2D0A0", Offset = "0x8B2C4A0", VA = "0x188B2D0A0")]
		private static KGHNRFVYIIX HSLZTUECZYQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class LQUQDHQEGUG
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> HFYEAMJNDQB;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E2E0", Offset = "0x8B2D6E0", VA = "0x188B2E2E0")]
		public static bool AGCYECVOMSJ(this JCSDFORPEFX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E3C0", Offset = "0x8B2D7C0", VA = "0x188B2E3C0")]
		public static bool GXINPBICHEC(this JCSDFORPEFX a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface GGGRBLJEQUH
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> TOSEOVCKIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType TCRRAFNYMNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface OMAVDDSSABA : GGGRBLJEQUH, LBFDPWILYET, UFAXMROCRAQ<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string RVWEJEUPOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType CYTCMGGHVXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) NXHDSIMYDLV<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class IQMOCMYAFWZ : OMAVDDSSABA, GGGRBLJEQUH, LBFDPWILYET, UFAXMROCRAQ<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly RWEFGBLHCFZ RWEFGBLHCFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly MSZLPLAGISM TCGXTPLTJVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? COAMICSPKGJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool MPGYBIJLNBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC70", Offset = "0x8B2B070", VA = "0x188B2BC70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool VRAVQTNEJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C2B0", Offset = "0x8B2B6B0", VA = "0x188B2C2B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool RACCWOKEZDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BE70", Offset = "0x8B2B270", VA = "0x188B2BE70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool NQXKXUNAZMN
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BB80", Offset = "0x8B2AF80", VA = "0x188B2BB80", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool JOIOUCFLILP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BF70", Offset = "0x8B2B370", VA = "0x188B2BF70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool YWUYIXNWZYA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BEC0", Offset = "0x8B2B2C0", VA = "0x188B2BEC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool ZEDZFJRTKRM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC20", Offset = "0x8B2B020", VA = "0x188B2BC20", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType CYTCMGGHVXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x72DF0B0", Offset = "0x72DE4B0", VA = "0x1872DF0B0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string RVWEJEUPOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x72DF0B0", Offset = "0x72DE4B0", VA = "0x1872DF0B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool QVTAUPWCZWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType TCRRAFNYMNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BBD0", Offset = "0x8B2AFD0", VA = "0x188B2BBD0", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> TOSEOVCKIGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BF10", Offset = "0x8B2B310", VA = "0x188B2BF10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool SGOCMLYJNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC70", Offset = "0x8B2B070", VA = "0x188B2BC70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BDUGZZWFGQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BF70", Offset = "0x8B2B370", VA = "0x188B2BF70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KKBGLBFRUMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C2B0", Offset = "0x8B2B6B0", VA = "0x188B2C2B0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FMLPPERYYQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BE70", Offset = "0x8B2B270", VA = "0x188B2BE70", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool TYWZNSCNFHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BB80", Offset = "0x8B2AF80", VA = "0x188B2BB80", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool FXBBWOIDPOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BEC0", Offset = "0x8B2B2C0", VA = "0x188B2BEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool EOXCGMXXXXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC20", Offset = "0x8B2B020", VA = "0x188B2BC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> GKZZWOPJBSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8B2CDD0", Offset = "0x8B2C1D0", VA = "0x188B2CDD0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BDC0", Offset = "0x8B2B1C0", VA = "0x188B2BDC0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x36A11C0", Offset = "0x36A05C0", VA = "0x1836A11C0", Slot = "6")]
		public (bool, a?) NXHDSIMYDLV<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x36A16A0", Offset = "0x36A0AA0", VA = "0x1836A16A0")]
		public IQMOCMYAFWZ QZWCQHRUDHZ<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CEF0", Offset = "0x8B2C2F0", VA = "0x188B2CEF0")]
		public IQMOCMYAFWZ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2D030", Offset = "0x8B2C430", VA = "0x188B2D030")]
		public IQMOCMYAFWZ(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2D050", Offset = "0x8B2C450", VA = "0x188B2D050")]
		public IQMOCMYAFWZ(IQMOCMYAFWZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CF10", Offset = "0x8B2C310", VA = "0x188B2CF10")]
		internal IQMOCMYAFWZ(AccountRoleType a, [Optional] string? b, [Optional] IQMOCMYAFWZ? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C3B0", Offset = "0x8B2B7B0", VA = "0x188B2C3B0")]
		public static RolePermissionType VPVGUTFWBSN(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C300", Offset = "0x8B2B700", VA = "0x188B2C300")]
		public void TTXGPYXKEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BFC0", Offset = "0x8B2B3C0", VA = "0x188B2BFC0")]
		internal IQMOCMYAFWZ QXHOJTKIJTR(IQMOCMYAFWZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B610", Offset = "0x8B2AA10", VA = "0x188B2B610")]
		internal IReadOnlyCollection<RolePermission> Copy(IQMOCMYAFWZ roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B530", Offset = "0x8B2A930", VA = "0x188B2B530")]
		public bool BABOBSJGHIS(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BCC0", Offset = "0x8B2B0C0", VA = "0x188B2BCC0")]
		public (bool, string) INKRXFQJZYT(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C420", Offset = "0x8B2B820", VA = "0x188B2C420")]
		internal void VZMWTSOOEOI(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B9C0", Offset = "0x8B2ADC0", VA = "0x188B2B9C0")]
		public SGQEIBBOKDS DOUEZUALEDQ(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C470", Offset = "0x8B2B870", VA = "0x188B2C470")]
		public void WKSJLJFRHOO(SGQEIBBOKDS a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C320", Offset = "0x8B2B720", VA = "0x188B2C320")]
		[CompilerGenerated]
		private void UIJKABGNXBE(RolePermission a, NOBOWDLHDAT b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AADUUZAKQGK : EXHSTGKFMVE, ZQXUCSITBOJ, IDisposable, HPKCKZYQHUV
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class BFYWEHFHLQI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public IQMOCMYAFWZ GFQCRCZLOKU;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public BFYWEHFHLQI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B320", Offset = "0x8B2A720", VA = "0x188B2B320")]
			internal bool MAGOBDMQAUE(IQMOCMYAFWZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class YMJEHRLXYVF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType RQLAZWFMAES;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YMJEHRLXYVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1C8BFA0", Offset = "0x1C8B3A0", VA = "0x181C8BFA0")]
			internal bool CMGIBBWHLSC(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class IIZHUEQDZCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder CKXAZJTVVKY;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public IIZHUEQDZCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B450", Offset = "0x8B2A850", VA = "0x188B2B450")]
			internal void FVNGEDJNCLV(SGQEIBBOKDS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B350", Offset = "0x8B2A750", VA = "0x188B2B350")]
			internal void FVHZGWPPTAM(SGQEIBBOKDS a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <>c__DisplayClass35_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PersistedRoomData roomData;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class UKIAKXXCCTL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<SGQEIBBOKDS, NOBOWDLHDAT> CFFDBZBKJQU;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UKIAKXXCCTL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B33A50", Offset = "0x8B32E50", VA = "0x188B33A50")]
			internal void JTTOXDLUYNO(SGQEIBBOKDS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8B33AB0", Offset = "0x8B32EB0", VA = "0x188B33AB0")]
			internal void JUJJOXTNAVP(SGQEIBBOKDS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8B33A80", Offset = "0x8B32E80", VA = "0x188B33A80")]
			internal void JUECRQZPRKG(SGQEIBBOKDS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class TWMKJEDYDQR<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public TWMKJEDYDQR<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x3CBC190", Offset = "0x3CBB590", VA = "0x183CBC190", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission BJJOHHJHRRD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType BMUUOGABBKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool FUJQAXAJLJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType LZWUBTKTJFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string HJUUSRYRHOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AADUUZAKQGK MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action DFLGUKYZHBW;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public TWMKJEDYDQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5F55B30", Offset = "0x5F54F30", VA = "0x185F55B30")]
			[AsyncStateMachine(typeof(TWMKJEDYDQR<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void RGSFXVIDOAW()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct <>c__DisplayClass51_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public IReadOnlyList<RolePermissionDTO> newPermissionOverrides;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <CoOwnerMigrateLegacyProtobufToRecNet>d__53 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public QOESEBVKVAX rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, IQMOCMYAFWZ> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EDWRYMDTWRC debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8B320E0", Offset = "0x8B314E0", VA = "0x188B320E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B32BE0", Offset = "0x8B31FE0", VA = "0x188B32BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <LEGACY_DeserializeFrom>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AADUUZAKQGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private bool <isOffline>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8B32C40", Offset = "0x8B32040", VA = "0x188B32C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8B332B0", Offset = "0x8B326B0", VA = "0x188B332B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly QOESEBVKVAX YGSFUWZSTNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly KGHNRFVYIIX MOZOCKHMTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly EDWRYMDTWRC XACFLBBGEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private SLQKGPCLNXU? JUNNUVUYUCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> LEWGISZXSGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, IQMOCMYAFWZ> ETWTQYHDIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, IQMOCMYAFWZ> WLLZULLFLTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, IQMOCMYAFWZ> QFNSKJCCBVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<IQMOCMYAFWZ> PSCEYENJAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool XHWMHJXKVKG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] LJLXALPQYKS;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public PKFJKRUXERA GLYINPOTQII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated HJKJQGZVXHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8B261A0", Offset = "0x8B255A0", VA = "0x188B261A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B2A370", Offset = "0x8B29770", VA = "0x188B2A370", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B252C0", Offset = "0x8B246C0", VA = "0x188B252C0")]
		[CVOOPLRRRUK.Room]
		internal static void CVOOPLRRRUK(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A830", Offset = "0x8B29C30", VA = "0x188B2A830")]
		[UnityEngine.Scripting.Preserve]
		internal AADUUZAKQGK([Inject(null)] QOESEBVKVAX roleDataProvider, [Inject(null)] KGHNRFVYIIX roleManagerDefaults, [Inject(null)] EDWRYMDTWRC debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B25510", Offset = "0x8B24910", VA = "0x188B25510", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B25940", Offset = "0x8B24D40", VA = "0x188B25940")]
		private void EJCRXTJKUDA(IEnumerable<IQMOCMYAFWZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B297D0", Offset = "0x8B28BD0", VA = "0x188B297D0", Slot = "10")]
		public bool RCMBXYRPKZZ(JCSDFORPEFX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A5C0", Offset = "0x8B299C0", VA = "0x188B2A5C0")]
		private void ZESERDNCSAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A120", Offset = "0x8B29520", VA = "0x188B2A120", Slot = "19")]
		public void VCUEEEODJYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B26240", Offset = "0x8B25640", VA = "0x188B26240", Slot = "8")]
		public IReadOnlyList<OMAVDDSSABA> FQIIPLYMFDS(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B29020", Offset = "0x8B28420", VA = "0x188B29020", Slot = "9")]
		public OMAVDDSSABA MOFDEVMZQAS(JCSDFORPEFX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B28300", Offset = "0x8B27700", VA = "0x188B28300")]
		private AccountRoleType JLAIZGWXHZQ(JCSDFORPEFX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B281C0", Offset = "0x8B275C0", VA = "0x188B281C0", Slot = "12")]
		public bool HWYYVHUQXUU(JCSDFORPEFX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B25470", Offset = "0x8B24870", VA = "0x188B25470", Slot = "13")]
		public OMAVDDSSABA DPFPQVUKGIF(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B29480", Offset = "0x8B28880", VA = "0x188B29480")]
		private static bool OVZZIWKWBXU(LAOUVNXPLEB a, AccountRoleType b, [Out] SGQEIBBOKDS? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B251D0", Offset = "0x8B245D0", VA = "0x188B251D0")]
		private static void CTSUNEFSEMQ(LAOUVNXPLEB a, Action<SGQEIBBOKDS> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B24F40", Offset = "0x8B24340", VA = "0x188B24F40")]
		private static void CTSUNEFSEMQ(LAOUVNXPLEB a, Action<SGQEIBBOKDS> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A550", Offset = "0x8B29950", VA = "0x188B2A550")]
		private void XVLXTXEJYYZ(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B28910", Offset = "0x8B27D10", VA = "0x188B28910", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task LKBKGRNUQKB([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B25610", Offset = "0x8B24A10", VA = "0x188B25610")]
		private void ECFHBFENMOR(LAOUVNXPLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B29180", Offset = "0x8B28580", VA = "0x188B29180")]
		internal static string NNCSWFMKJBJ(QOESEBVKVAX a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IQMOCMYAFWZ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B262C0", Offset = "0x8B256C0", VA = "0x188B262C0")]
		private static void FSJJOUJSPUT(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B283D0", Offset = "0x8B277D0", VA = "0x188B283D0")]
		private static void JPCIOADEWVO(LAOUVNXPLEB a, IReadOnlyDictionary<AccountRoleType, IQMOCMYAFWZ> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B26FA0", Offset = "0x8B263A0", VA = "0x188B26FA0")]
		private static bool GOERFNULZFN(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B270B0", Offset = "0x8B264B0", VA = "0x188B270B0")]
		private static void GTHGYXPPBNO(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3021900", Offset = "0x3020D00", VA = "0x183021900", Slot = "14")]
		public bool IWZLRAZWJJB<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A300", Offset = "0x8B29700", VA = "0x188B2A300", Slot = "15")]
		public string VVEZUJSXZAJ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B24D30", Offset = "0x8B24130", VA = "0x188B24D30", Slot = "16")]
		public bool BYPGDRMALMN(JCSDFORPEFX a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A5D0", Offset = "0x8B299D0", VA = "0x188B2A5D0", Slot = "18")]
		public bool ZTUOGOFHYPL(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B28710", Offset = "0x8B27B10", VA = "0x188B28710")]
		private void KCBSDWDFXBF(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B297B0", Offset = "0x8B28BB0", VA = "0x188B297B0")]
		private bool PlayerHasRole(JCSDFORPEFX player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B29E90", Offset = "0x8B29290", VA = "0x188B29E90")]
		private IQMOCMYAFWZ UXTUOAWRIZL(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B277D0", Offset = "0x8B26BD0", VA = "0x188B277D0")]
		internal AccountRoleType GYVRSHCGXGD(JCSDFORPEFX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A410", Offset = "0x8B29810", VA = "0x188B2A410")]
		private void VXGDJQJHHVJ(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B28280", Offset = "0x8B27680", VA = "0x188B28280", Slot = "11")]
		public IReadOnlyList<OMAVDDSSABA> VZIEDLQHXCI(JCSDFORPEFX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B28280", Offset = "0x8B27680", VA = "0x188B28280")]
		internal IReadOnlyList<IQMOCMYAFWZ> HXBBQWJAHFD(JCSDFORPEFX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B28D10", Offset = "0x8B28110", VA = "0x188B28D10")]
		internal IReadOnlyList<IQMOCMYAFWZ> MDKLBHWMUQN(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B27A50", Offset = "0x8B26E50", VA = "0x188B27A50")]
		private void HHKJAQQHHVY(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B28A30", Offset = "0x8B27E30", VA = "0x188B28A30")]
		private static bool MACORPKWUNQ(IQMOCMYAFWZ a, IReadOnlyDictionary<AccountRoleType, IQMOCMYAFWZ> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B28EE0", Offset = "0x8B282E0", VA = "0x188B28EE0")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task MFQNMYTIBWQ(QOESEBVKVAX a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IQMOCMYAFWZ> c, EDWRYMDTWRC d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B29C10", Offset = "0x8B29010", VA = "0x188B29C10")]
		[CompilerGenerated]
		internal static void TAHBATHTGAB(Func<SGQEIBBOKDS, NOBOWDLHDAT> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B298A0", Offset = "0x8B28CA0", VA = "0x188B298A0")]
		[CompilerGenerated]
		internal static bool SETPLKQYIWO(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface UVQTEMNWTUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WOUANDTCMRM(JCSDFORPEFX a, JCSDFORPEFX b, IEnumerable<JCSDFORPEFX> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string JTFJVAUKVXZ(VotekickFailReason a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public enum VotekickFailReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		InsufficientPermission,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		DisabledByRoom,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		CantKickEventOrganizer,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Broadcaster,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		GameInProgress,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		OpponentGameInProgress
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class AEPAKITBPEY : UVQTEMNWTUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly ZQXUCSITBOJ OALGPGWXJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly RSGDQKICTLE GYGQVBZOCXS;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		[RecRoom.NoEngine.Common.Preserve]
		public AEPAKITBPEY([Inject(null)] ZQXUCSITBOJ roomRoleManager, [Inject(null)] RSGDQKICTLE gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B2AAE0", Offset = "0x8B29EE0", VA = "0x188B2AAE0")]
		private static PlayerEvent? AXOYROKLVTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B220", Offset = "0x8B2A620", VA = "0x188B2B220", Slot = "4")]
		public bool WOUANDTCMRM(JCSDFORPEFX a, JCSDFORPEFX b, IEnumerable<JCSDFORPEFX> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B120", Offset = "0x8B2A520", VA = "0x188B2B120", Slot = "5")]
		public string JTFJVAUKVXZ(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2AB20", Offset = "0x8B29F20", VA = "0x188B2AB20")]
		internal bool BJJDUUYKMRR(JCSDFORPEFX a, JCSDFORPEFX b, IEnumerable<JCSDFORPEFX> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
		{
			return default(bool);
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
