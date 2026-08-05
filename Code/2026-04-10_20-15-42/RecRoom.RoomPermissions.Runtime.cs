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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B58E0", Offset = "0xA2B48E0", VA = "0x18A2B58E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2BBD00", Offset = "0xA2BAD00", VA = "0x18A2BBD00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
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
	public delegate void OnRoomRoleUpdated(DDFOJMMWCEL player);
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
	public interface LFQSUHAXMTX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool STRGXCRARMS
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool WOQJOOUAJPS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool AAEVTZEMAQK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool PPIFGHRJKTL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool QRYYPOYRMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool UFCEYXHYYTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool NVJXFWGUZYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class DVPICUSSITS
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
		public static readonly Guid LKAGCQXDGQY;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid ZNZRMULPYSV;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid OWJLMCKDBFA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid WTJPOMGXJYC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid QQNZWUGJTDH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid NJMWMRBQVIA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly UDCQNYGWPIZ<AccountRoleType, Guid> XVNCMYCPIFX;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> OQLPRJNCGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD0F0", Offset = "0xA2AC0F0", VA = "0x18A2AD0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA2ACF90", Offset = "0xA2ABF90", VA = "0x18A2ACF90")]
		public static AccountRoleType HRZLFHTVGNN(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA2ACEF0", Offset = "0xA2ABEF0", VA = "0x18A2ACEF0")]
		public static Guid HAJYIJWZLKP(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD060", Offset = "0xA2AC060", VA = "0x18A2AD060")]
		public static bool OXVZSIRZSII(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD170", Offset = "0xA2AC170", VA = "0x18A2AD170")]
		public static bool URKLWLHJKSU(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD020", Offset = "0xA2AC020", VA = "0x18A2AD020")]
		public static AccountRoleType MNTGHJCVECP(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA2ACE40", Offset = "0xA2ABE40", VA = "0x18A2ACE40")]
		public static DEPRECATED_RoomRoleId GFGWGMPGHZI(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD210", Offset = "0xA2AC210", VA = "0x18A2AD210")]
		internal static AccountRoleType UXDVVAQDEWZ(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ANEFOEYOSMZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance IFGUGUYVJYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO PYNPSDJLGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> FSWFJAUJBZO;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action TBTGENUNGHA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType DQRSLEUYSJG(DDFOJMMWCEL a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> ETEDXTCMOOB(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task AGYTFKMTRUZ(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task UYZPLFREYNN(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<DDFOJMMWCEL> LPAWHNXKPAK();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class PTNSOUBGWNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA2B86D0", Offset = "0xA2B76D0", VA = "0x18A2B86D0")]
		public static AccountRoleType WVIYWMGGQDT(this ANEFOEYOSMZ a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface JCHLPLHZJDB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		EGWJMZZTVOA GNEFLGTUYRA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated LRYRUISSQJY;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<DDQCPPNADSE> DYVSUVCYSOW(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DDQCPPNADSE UCQSXHYSAKE(DDFOJMMWCEL a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NCMWWKHGMWR(DDFOJMMWCEL a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<DDQCPPNADSE> UTKXWWTCOAC(DDFOJMMWCEL a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool RUFOIWMBCZQ(DDFOJMMWCEL a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DDQCPPNADSE XLTGWMFPAMH(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ZQJJOPBFHJH<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string OAXJWUQBMZR(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool PDXBLUWZQQH(DDFOJMMWCEL a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LQDKMWEKOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task LBKWLIWNRHJ(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface TBSZWBRZMYC<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> OVZYERGOJEB;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? QKDOCUQHNZV;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? WPHEUIVWWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA2B8730", Offset = "0xA2B7730", VA = "0x18A2B8730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA2B8800", Offset = "0xA2B7800", VA = "0x18A2B8800")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B8900", Offset = "0xA2B7900", VA = "0x18A2B8900")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool LELFZVOHOWV(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> IIGNZKHBXFN;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7530970", Offset = "0x752F970", VA = "0x187530970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75314A0", Offset = "0x75304A0", VA = "0x1875314A0", Slot = "4")]
		public override bool LELFZVOHOWV(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7530E20", Offset = "0x752FE20", VA = "0x187530E20")]
		public bool KGLXYERKGVT(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75319F0", Offset = "0x75309F0", VA = "0x1875319F0")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class OZKWMFBOIAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> ZSLMRCQUJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> HSOUIVCSCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly PSJXVZZYHQF ABMLQWESGPD;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA2B61D0", Offset = "0xA2B51D0", VA = "0x18A2B61D0")]
		public OZKWMFBOIAS(PSJXVZZYHQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5C40", Offset = "0xA2B4C40", VA = "0x18A2B5C40")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1220", Offset = "0x3DA0220", VA = "0x183DA1220")]
		public bool VDRHDQWUOTR<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DA19E0", Offset = "0x3DA09E0", VA = "0x183DA19E0")]
		public (bool, a?) ZRTAPSIHEVZ<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5F60", Offset = "0xA2B4F60", VA = "0x18A2B5F60")]
		public bool VDRHDQWUOTR(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA2B6040", Offset = "0xA2B5040", VA = "0x18A2B6040")]
		public (bool, object) ZRTAPSIHEVZ(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1140", Offset = "0x3DA0140", VA = "0x183DA1140")]
		private void DDJHGADVOSI<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5E90", Offset = "0xA2B4E90", VA = "0x18A2B5E90")]
		private Permission UUOBZZYHGHY(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5CB0", Offset = "0xA2B4CB0", VA = "0x18A2B5CB0")]
		public void TLBGGUJKMNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class BNWZPGWGICZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string XPLVRGXLMTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type IHVXZLNANOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType SMKXIJYUMTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission QTVPXGYQFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet ZCDDLNBZYSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue GYXRXIVYHUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission JIGXMFSVVIG;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA2AC970", Offset = "0xA2AB970", VA = "0x18A2AC970")]
		public BNWZPGWGICZ(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA2AC920", Offset = "0xA2AB920", VA = "0x18A2AC920")]
		public object MGPXJVHDYTN(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x373E9E0", Offset = "0x373D9E0", VA = "0x18373E9E0")]
		public void DDJHGADVOSI<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA2AC870", Offset = "0xA2AB870", VA = "0x18A2AC870")]
		public void DDJHGADVOSI(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class XYQMYWQYIZY<a> : BNWZPGWGICZ where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet DJNCWCQOLTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue RHYZEYWIHQP;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7E98840", Offset = "0x7E97840", VA = "0x187E98840")]
			internal string HULOWDNKMXU(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7E98EA0", Offset = "0x7E97EA0", VA = "0x187E98EA0")]
			internal object HUQVTKHHWJD(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5159FE0", Offset = "0x5158FE0", VA = "0x185159FE0")]
		public XYQMYWQYIZY(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x51588D0", Offset = "0x51578D0", VA = "0x1851588D0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x51595C0", Offset = "0x51585C0", VA = "0x1851595C0")]
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
	internal class PSJXVZZYHQF
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class CLPBJVFRXYX : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static CLPBJVFRXYX UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA2ACA10", Offset = "0xA2ABA10", VA = "0x18A2ACA10", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA2ACB60", Offset = "0xA2ABB60", VA = "0x18A2ACB60", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public CLPBJVFRXYX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class OSKNSDZFWHP : NVNXNDGEDVG<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA2B5960", Offset = "0xA2B4960", VA = "0x18A2B5960", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA2B5A50", Offset = "0xA2B4A50", VA = "0x18A2B5A50", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B5C00", Offset = "0xA2B4C00", VA = "0x18A2B5C00")]
			public OSKNSDZFWHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly QTMIWDUSKCO MEZNVFNXVHY;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly OSKNSDZFWHP MODLUAJRBZP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<BNWZPGWGICZ> TXSRVRUMRWM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> PRVGXWLZTMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, BNWZPGWGICZ> DAUJMFFDUQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA2B83A0", Offset = "0xA2B73A0", VA = "0x18A2B83A0")]
		public PSJXVZZYHQF([Optional] IList<BNWZPGWGICZ>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA2B6460", Offset = "0xA2B5460", VA = "0x18A2B6460")]
		public BNWZPGWGICZ UMQFQOOMDFS(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface EGWJMZZTVOA
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		DDQCPPNADSE SIASPIFCRFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class QRSGYZECUIB : EGWJMZZTVOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static QRSGYZECUIB KKZBSKKGTNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly ERZBIHVWMVV XPUHSJHXGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<ERZBIHVWMVV> LJTTBSOPLJS;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public DDQCPPNADSE SIASPIFCRFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA2B9B00", Offset = "0xA2B8B00", VA = "0x18A2B9B00")]
		public QRSGYZECUIB(ERZBIHVWMVV a, IReadOnlyList<ERZBIHVWMVV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B8A00", Offset = "0xA2B7A00", VA = "0x18A2B8A00")]
		private static QRSGYZECUIB TBBLBRZSIIW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class VDBFHVOKNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA2BB870", Offset = "0xA2BA870", VA = "0x18A2BB870")]
		public static VCTAQBGDELJ BSQUZSCGHZR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class RJHDJGPWBCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> MHIWMNMJHEL;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B9C00", Offset = "0xA2B8C00", VA = "0x18A2B9C00")]
		public static bool EJQSKHOBYWH(this DDFOJMMWCEL a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B9CE0", Offset = "0xA2B8CE0", VA = "0x18A2B9CE0")]
		public static bool SPZLWZMSNRS(this DDFOJMMWCEL a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface HGDEGKHVXTT
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> XQDIZWONORU
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType CDGIACTUVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface DDQCPPNADSE : HGDEGKHVXTT, LFQSUHAXMTX, TBSZWBRZMYC<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string WAPNOKRPSVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType VXWOIKETKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) ZVZDOENPGUJ<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ERZBIHVWMVV : DDQCPPNADSE, HGDEGKHVXTT, LFQSUHAXMTX, TBSZWBRZMYC<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly PSJXVZZYHQF PSJXVZZYHQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly OZKWMFBOIAS LDESTCCHTWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? QYFALSWEDIX;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool PRERCGZLLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEC30", Offset = "0xA2ADC30", VA = "0x18A2AEC30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool WGFRDZMDUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA2AE8F0", Offset = "0xA2AD8F0", VA = "0x18A2AE8F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool FWCNGUCIHAY
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEDE0", Offset = "0xA2ADDE0", VA = "0x18A2AEDE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool DLMRNTHNWAT
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD570", Offset = "0xA2AC570", VA = "0x18A2AD570", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool VSFETXQIJRF
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA2ADAF0", Offset = "0xA2ACAF0", VA = "0x18A2ADAF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool OLTSPRVYCKS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA2AE850", Offset = "0xA2AD850", VA = "0x18A2AE850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool ZTETNVUZRGU
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD640", Offset = "0xA2AC640", VA = "0x18A2AD640", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType VXWOIKETKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A64220", Offset = "0x8A63220", VA = "0x188A64220", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string WAPNOKRPSVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A64220", Offset = "0x8A63220", VA = "0x188A64220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool VFGWJDAPSLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD6A4F0", Offset = "0xD694F0", VA = "0x180D6A4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType CDGIACTUVLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEC80", Offset = "0xA2ADC80", VA = "0x18A2AEC80", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> XQDIZWONORU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA2AED80", Offset = "0xA2ADD80", VA = "0x18A2AED80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool CVEGJJOEXMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEC30", Offset = "0xA2ADC30", VA = "0x18A2AEC30", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool KVZACNJCLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA2ADAF0", Offset = "0xA2ACAF0", VA = "0x18A2ADAF0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool MFKUSJSZFOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA2AE8F0", Offset = "0xA2AD8F0", VA = "0x18A2AE8F0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool DFDSGAIWJES
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEDE0", Offset = "0xA2ADDE0", VA = "0x18A2AEDE0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DEMJYSRPKPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD570", Offset = "0xA2AC570", VA = "0x18A2AD570", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DALXNPWHUKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA2AE850", Offset = "0xA2AD850", VA = "0x18A2AE850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool RKNXZNNNJQK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD640", Offset = "0xA2AC640", VA = "0x18A2AD640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> OVZYERGOJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA2AD690", Offset = "0xA2AC690", VA = "0x18A2AD690", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA2AEE30", Offset = "0xA2ADE30", VA = "0x18A2AEE30", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x39528F0", Offset = "0x39518F0", VA = "0x1839528F0", Slot = "6")]
		public (bool, a?) ZVZDOENPGUJ<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x39526B0", Offset = "0x39516B0", VA = "0x1839526B0")]
		public ERZBIHVWMVV JGVBSPMBCKB<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF100", Offset = "0xA2AE100", VA = "0x18A2AF100")]
		public ERZBIHVWMVV(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA2AEF60", Offset = "0xA2ADF60", VA = "0x18A2AEF60")]
		public ERZBIHVWMVV(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF0B0", Offset = "0xA2AE0B0", VA = "0x18A2AF0B0")]
		public ERZBIHVWMVV(ERZBIHVWMVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA2AEF80", Offset = "0xA2ADF80", VA = "0x18A2AEF80")]
		internal ERZBIHVWMVV(AccountRoleType a, [Optional] string? b, [Optional] ERZBIHVWMVV? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD5C0", Offset = "0xA2AC5C0", VA = "0x18A2AD5C0")]
		public static RolePermissionType BDUWYGBDPAX(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA2AED60", Offset = "0xA2ADD60", VA = "0x18A2AED60")]
		public void TLBGGUJKMNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE940", Offset = "0xA2AD940", VA = "0x18A2AE940")]
		internal ERZBIHVWMVV LYAFYBHAPAB(ERZBIHVWMVV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD740", Offset = "0xA2AC740", VA = "0x18A2AD740")]
		internal IReadOnlyCollection<RolePermission> Copy(ERZBIHVWMVV roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE5A0", Offset = "0xA2AD5A0", VA = "0x18A2AE5A0")]
		public bool HVUNTSIXBCE(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA2ADB40", Offset = "0xA2ACB40", VA = "0x18A2ADB40")]
		public (bool, string) FWKYMMAMGCV(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE8A0", Offset = "0xA2AD8A0", VA = "0x18A2AE8A0")]
		internal void KLFQJHWAWNM(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE680", Offset = "0xA2AD680", VA = "0x18A2AE680")]
		public VVNGLURJUNA IVMPZKUQYMA(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2ADC40", Offset = "0xA2ACC40", VA = "0x18A2ADC40")]
		public void HHVNGZBQZPG(VVNGLURJUNA a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA2AECD0", Offset = "0xA2ADCD0", VA = "0x18A2AECD0")]
		[CompilerGenerated]
		private void OPROXRQPBYE(RolePermission a, SPLWKDKGHFP b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class NLLNFECAOLG : LQDKMWEKOMI, JCHLPLHZJDB, IDisposable, YYGOMMBAADJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class HYHHLZFIJXM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ERZBIHVWMVV TQYTBXSYDIK;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public HYHHLZFIJXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF120", Offset = "0xA2AE120", VA = "0x18A2AF120")]
			internal bool AKRRNFLBXEO(ERZBIHVWMVV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class NSPBPFWQIHX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType NCZJGQLIKKU;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public NSPBPFWQIHX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EF6BB0", Offset = "0x1EF5BB0", VA = "0x181EF6BB0")]
			internal bool VFILQTYRXBW(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class ZREJSMQIMLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder VAWGGSGBPXY;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ZREJSMQIMLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA2BBC20", Offset = "0xA2BAC20", VA = "0x18A2BBC20")]
			internal void KZLMKDWDOKN(VVNGLURJUNA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA2BBB20", Offset = "0xA2BAB20", VA = "0x18A2BBB20")]
			internal void KZGFMXCGEZE(VVNGLURJUNA a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct <>c__DisplayClass35_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PersistedRoomData roomData;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class MLYOGFJNLZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<VVNGLURJUNA, SPLWKDKGHFP> OIDRSBRLOVM;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MLYOGFJNLZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF9E0", Offset = "0xA2AE9E0", VA = "0x18A2AF9E0")]
			internal void KWINKDUBZUS(VVNGLURJUNA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF9B0", Offset = "0xA2AE9B0", VA = "0x18A2AF9B0")]
			internal void KWDGMXAEQJJ(VVNGLURJUNA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF980", Offset = "0xA2AE980", VA = "0x18A2AF980")]
			internal void KVXZPQGHGYA(VVNGLURJUNA a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class QJVYJGVDSOP<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000032")]
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
				public QJVYJGVDSOP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x41E9110", Offset = "0x41E8110", VA = "0x1841E9110", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD6E050", Offset = "0xD6D050", VA = "0x180D6E050", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission NXVSXEBWZYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType KYRGMDMUBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool LZBLXUXTAIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType XBUEQXCTJZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string CUXMXVNUJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public NLLNFECAOLG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action KMHLMNPHOZM;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QJVYJGVDSOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x777B360", Offset = "0x777A360", VA = "0x18777B360")]
			[AsyncStateMachine(typeof(QJVYJGVDSOP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void TWXPXKGSFGA()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <>c__DisplayClass51_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public IReadOnlyList<RolePermissionDTO> newPermissionOverrides;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
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
			public ANEFOEYOSMZ rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, ERZBIHVWMVV> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public GEPMWXDIONU debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA2B9F00", Offset = "0xA2B8F00", VA = "0x18A2B9F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA2BAA00", Offset = "0xA2B9A00", VA = "0x18A2BAA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
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
			public NLLNFECAOLG <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA2BAA60", Offset = "0xA2B9A60", VA = "0x18A2BAA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA2BB0D0", Offset = "0xA2BA0D0", VA = "0x18A2BB0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly ANEFOEYOSMZ BGNNKHYHHKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly QRSGYZECUIB VTZDLGCIHYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly GEPMWXDIONU DGULWQDXUNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IAWSSEFWJDK? HDRLDCSQRSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> QXQXRYIPJQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, ERZBIHVWMVV> XLJQHXZBPTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, ERZBIHVWMVV> QPMEFBSXRLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, ERZBIHVWMVV> PBBDNQVCNDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<ERZBIHVWMVV> XTRZFBARRCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool VLTCZXXNSLC;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] OPZDHOMCYLG;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public EGWJMZZTVOA GNEFLGTUYRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated LRYRUISSQJY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA2AFE20", Offset = "0xA2AEE20", VA = "0x18A2AFE20", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA2B2B30", Offset = "0xA2B1B30", VA = "0x18A2B2B30", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B07C0", Offset = "0xA2AF7C0", VA = "0x18A2B07C0")]
		[GEPWJNEAFDW.Room]
		internal static void GEPWJNEAFDW(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5630", Offset = "0xA2B4630", VA = "0x18A2B5630")]
		[UnityEngine.Scripting.Preserve]
		internal NLLNFECAOLG([Inject(null)] ANEFOEYOSMZ roleDataProvider, [Inject(null)] QRSGYZECUIB roleManagerDefaults, [Inject(null)] GEPMWXDIONU debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFF40", Offset = "0xA2AEF40", VA = "0x18A2AFF40", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B1720", Offset = "0xA2B0720", VA = "0x18A2B1720")]
		private void MSDHQZZYDJO(IEnumerable<ERZBIHVWMVV> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA2B1F90", Offset = "0xA2B0F90", VA = "0x18A2B1F90", Slot = "10")]
		public bool NCMWWKHGMWR(DDFOJMMWCEL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2B20", Offset = "0xA2B1B20", VA = "0x18A2B2B20")]
		private void TBTGENUNGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B52A0", Offset = "0xA2B42A0", VA = "0x18A2B52A0", Slot = "19")]
		public void YXHSSGCBEOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFEC0", Offset = "0xA2AEEC0", VA = "0x18A2AFEC0", Slot = "8")]
		public IReadOnlyList<DDQCPPNADSE> DYVSUVCYSOW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B3370", Offset = "0xA2B2370", VA = "0x18A2B3370", Slot = "9")]
		public DDQCPPNADSE UCQSXHYSAKE(DDFOJMMWCEL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFA10", Offset = "0xA2AEA10", VA = "0x18A2AFA10")]
		private AccountRoleType CHECZDOYLUU(DDFOJMMWCEL a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2890", Offset = "0xA2B1890", VA = "0x18A2B2890", Slot = "12")]
		public bool RUFOIWMBCZQ(DDFOJMMWCEL a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2B4F70", Offset = "0xA2B3F70", VA = "0x18A2B4F70", Slot = "13")]
		public DDQCPPNADSE XLTGWMFPAMH(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0AB0", Offset = "0xA2AFAB0", VA = "0x18A2B0AB0")]
		private static bool HSZKPNNKHVK(VCTAQBGDELJ a, AccountRoleType b, [Out] VVNGLURJUNA? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA2B22F0", Offset = "0xA2B12F0", VA = "0x18A2B22F0")]
		private static void PVSTYNZTWOO(VCTAQBGDELJ a, Action<VVNGLURJUNA> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B23E0", Offset = "0xA2B13E0", VA = "0x18A2B23E0")]
		private static void PVSTYNZTWOO(VCTAQBGDELJ a, Action<VVNGLURJUNA> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B16B0", Offset = "0xA2B06B0", VA = "0x18A2B16B0")]
		private void LDFONDJPUID(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B1590", Offset = "0xA2B0590", VA = "0x18A2B1590", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task LBKWLIWNRHJ([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B37C0", Offset = "0xA2B27C0", VA = "0x18A2B37C0")]
		private void UXSVIESYARR(VCTAQBGDELJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0F20", Offset = "0xA2AFF20", VA = "0x18A2B0F20")]
		internal static string HYHUHLEPOJT(ANEFOEYOSMZ a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, ERZBIHVWMVV> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B3AF0", Offset = "0xA2B2AF0", VA = "0x18A2B3AF0")]
		private static void WJZSOROAICJ(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFAE0", Offset = "0xA2AEAE0", VA = "0x18A2AFAE0")]
		private static void CNCSQZGBLAG(VCTAQBGDELJ a, IReadOnlyDictionary<AccountRoleType, ERZBIHVWMVV> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2A10", Offset = "0xA2B1A10", VA = "0x18A2B2A10")]
		private static bool SGADNKRDGRD(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2C50", Offset = "0xA2B1C50", VA = "0x18A2B2C50")]
		private static void TUNTUOBZKZA(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D67330", Offset = "0x3D66330", VA = "0x183D67330", Slot = "14")]
		public bool ZQJJOPBFHJH<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2060", Offset = "0xA2B1060", VA = "0x18A2B2060", Slot = "15")]
		public string OAXJWUQBMZR(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA2B20E0", Offset = "0xA2B10E0", VA = "0x18A2B20E0", Slot = "16")]
		public bool PDXBLUWZQQH(DDFOJMMWCEL a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2950", Offset = "0xA2B1950", VA = "0x18A2B2950", Slot = "18")]
		public bool SFSWCOQRXBZ(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2690", Offset = "0xA2B1690", VA = "0x18A2B2690")]
		private void RGMGNYEJIUV(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2670", Offset = "0xA2B1670", VA = "0x18A2B2670")]
		private bool PlayerHasRole(DDFOJMMWCEL player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2B4A60", Offset = "0xA2B3A60", VA = "0x18A2B4A60")]
		private ERZBIHVWMVV XGFNIDIZNPV(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B4CF0", Offset = "0xA2B3CF0", VA = "0x18A2B4CF0")]
		internal AccountRoleType XHIRNCMSLOB(DDFOJMMWCEL a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0970", Offset = "0xA2AF970", VA = "0x18A2B0970")]
		private void GUNKQRFYDFH(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2BD0", Offset = "0xA2B1BD0", VA = "0x18A2B2BD0", Slot = "11")]
		public IReadOnlyList<DDQCPPNADSE> UTKXWWTCOAC(DDFOJMMWCEL a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2BD0", Offset = "0xA2B1BD0", VA = "0x18A2B2BD0")]
		internal IReadOnlyList<ERZBIHVWMVV> TLKYCWEJPHN(DDFOJMMWCEL a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2B4890", Offset = "0xA2B3890", VA = "0x18A2B4890")]
		internal IReadOnlyList<ERZBIHVWMVV> WNFFTHINYOH(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0040", Offset = "0xA2AF040", VA = "0x18A2B0040")]
		private void FUXFJEBEFGQ(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2B34D0", Offset = "0xA2B24D0", VA = "0x18A2B34D0")]
		private static bool UXNUVPNHYPO(ERZBIHVWMVV a, IReadOnlyDictionary<AccountRoleType, ERZBIHVWMVV> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0DE0", Offset = "0xA2AFDE0", VA = "0x18A2B0DE0")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task HWVEVCOTYRM(ANEFOEYOSMZ a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, ERZBIHVWMVV> c, GEPMWXDIONU d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5010", Offset = "0xA2B4010", VA = "0x18A2B5010")]
		[CompilerGenerated]
		internal static void XNGPCGCBZLF(Func<VVNGLURJUNA, SPLWKDKGHFP> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B1220", Offset = "0xA2B0220", VA = "0x18A2B1220")]
		[CompilerGenerated]
		internal static bool JDULDMIXXUQ(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface AWCAXKYHTCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZDUCTPADDWA(DDFOJMMWCEL a, DDFOJMMWCEL b, IEnumerable<DDFOJMMWCEL> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string NTKDXBLTGLD(VotekickFailReason a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
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
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal class KDFQZRFQAFE : AWCAXKYHTCZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly JCHLPLHZJDB NMMFJNLZBFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly XWOLRWFCTJS SUISZHRDVPU;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public KDFQZRFQAFE([Inject(null)] JCHLPLHZJDB roomRoleManager, [Inject(null)] XWOLRWFCTJS gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF150", Offset = "0xA2AE150", VA = "0x18A2AF150")]
		private static PlayerEvent? DLQXFKMIXIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF880", Offset = "0xA2AE880", VA = "0x18A2AF880", Slot = "4")]
		public bool ZDUCTPADDWA(DDFOJMMWCEL a, DDFOJMMWCEL b, IEnumerable<DDFOJMMWCEL> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF190", Offset = "0xA2AE190", VA = "0x18A2AF190", Slot = "5")]
		public string NTKDXBLTGLD(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF290", Offset = "0xA2AE290", VA = "0x18A2AF290")]
		internal bool PCDLCRATOMZ(DDFOJMMWCEL a, DDFOJMMWCEL b, IEnumerable<DDFOJMMWCEL> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
