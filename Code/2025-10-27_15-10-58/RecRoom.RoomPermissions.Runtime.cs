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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FD68E0", Offset = "0x8FD58E0", VA = "0x188FD68E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FDA720", Offset = "0x8FD9720", VA = "0x188FDA720", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
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
	public delegate void OnRoomRoleUpdated(XLYBIIWOHJI player);
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
	public interface YSUZLOYWWAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool WQEPFYYOEVD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LLTRMUFRMJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool VPWIMGWJTHX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool SHJLQIMFEYY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool BHQPRGBSFAT
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool SOSCRHNPGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool BIZFBTOHJQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class BSGKFTIPOTN
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
		public static readonly Guid UYONWIHHQHX;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid GPEMWSUBZGC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid DOWPMHYJDMB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid HIHJGDOBRBP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid JJZPWOIAKMM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid SEEJGHSVEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly BGCYITCKJUS<AccountRoleType, Guid> QDJLAUFZVZQ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> RVLTRPETSDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE290", Offset = "0x8FCD290", VA = "0x188FCE290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE350", Offset = "0x8FCD350", VA = "0x188FCE350")]
		public static AccountRoleType TDDRZPXFWTC(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE3E0", Offset = "0x8FCD3E0", VA = "0x188FCE3E0")]
		public static Guid VIMSUVPPGPK(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE070", Offset = "0x8FCD070", VA = "0x188FCE070")]
		public static bool FJLNEEUHUYV(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE140", Offset = "0x8FCD140", VA = "0x188FCE140")]
		public static bool HGYUDWMTZGV(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE310", Offset = "0x8FCD310", VA = "0x188FCE310")]
		public static AccountRoleType PBIPAGZNZWG(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE1E0", Offset = "0x8FCD1E0", VA = "0x188FCE1E0")]
		public static DEPRECATED_RoomRoleId LVDPOGFNRCJ(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE100", Offset = "0x8FCD100", VA = "0x188FCE100")]
		internal static AccountRoleType GUHXOJQJLAI(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface HJXCNNISMJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		XLYBIIWOHJI QQRSSROVZZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance EBNHHKDACNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO FGADPZJBLIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> KECMEIQXSFL;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action FTACDCXOHVB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType ZNYYVANRJFH(XLYBIIWOHJI a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> LJRHSNXTXSQ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task ZPOUVMSJIXI(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task JPTOKJIFMDA(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<XLYBIIWOHJI> UKHPNROFNKD();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class JERAMRSEHBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FCF2E0", Offset = "0x8FCE2E0", VA = "0x188FCF2E0")]
		public static AccountRoleType XCAHLJXYIXI(this HJXCNNISMJO a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface SWFYPLFEJBY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ZVAZEEORZWB FYBQMDIEGTN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated ZCSBQHFYWVJ;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<LYNSMBPRVDV> JHHFHRVKKNX(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LYNSMBPRVDV DOZHTSJDNDJ(XLYBIIWOHJI a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool XROAOQJBXWM(XLYBIIWOHJI a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<LYNSMBPRVDV> ZPVBJTBYMCB(XLYBIIWOHJI a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool SYDMIBNPEUF(XLYBIIWOHJI a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LYNSMBPRVDV UPREKKPMHME(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HDLAQIBGLBK<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string SKHAGIZHCEM(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ASKNLCOSNKA(XLYBIIWOHJI a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GPODLLWNQBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PCNKFYBAOTY(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KUCVGNDDFYB<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> ZWQJZGJUEFI;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? NWNPMZSECAW;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? DKMKXIAIOXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6A60", Offset = "0x8FD5A60", VA = "0x188FD6A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6960", Offset = "0x8FD5960", VA = "0x188FD6960")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6B30", Offset = "0x8FD5B30", VA = "0x188FD6B30")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool DXOIUIGRXFW(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> ZKHODEOUFFE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3A20", Offset = "0x5DE2A20", VA = "0x185DE3A20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3860", Offset = "0x5DE2860", VA = "0x185DE3860", Slot = "4")]
		public override bool DXOIUIGRXFW(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE30E0", Offset = "0x5DE20E0", VA = "0x185DE30E0")]
		public bool AJIKNWOVXVI(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3FB0", Offset = "0x5DE2FB0", VA = "0x185DE3FB0")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class BDUKXSMYZFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> SDCJSRXOHXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> ELBMTRSEYIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly BKRMAAPRLHO AFZZZBUSKOE;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8FCBB30", Offset = "0x8FCAB30", VA = "0x188FCBB30")]
		public BDUKXSMYZFB(BKRMAAPRLHO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB850", Offset = "0x8FCA850", VA = "0x188FCB850")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x36A0550", Offset = "0x369F550", VA = "0x1836A0550")]
		public bool PLNXVDHRCPS<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36A0D00", Offset = "0x369FD00", VA = "0x1836A0D00")]
		public (bool, a?) SELPOKSKHPC<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB8C0", Offset = "0x8FCA8C0", VA = "0x188FCB8C0")]
		public bool PLNXVDHRCPS(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB9A0", Offset = "0x8FCA9A0", VA = "0x188FCB9A0")]
		public (bool, object) SELPOKSKHPC(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36A1410", Offset = "0x36A0410", VA = "0x1836A1410")]
		private void VUTOUFYPAUL<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB590", Offset = "0x8FCA590", VA = "0x188FCB590")]
		private Permission BPMXHFUDXKR(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB660", Offset = "0x8FCA660", VA = "0x188FCB660")]
		public void CBXYJLBSLBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class VRGCMPUWNDY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string LPMQZOFBKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type ZLDLXVYJAMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType KOZKDBWTOMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission HKTZUZMYMSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet HVTQCWPQTPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue TLIVSKWNHQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission LMEJNIFVWQB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA250", Offset = "0x8FD9250", VA = "0x188FDA250")]
		public VRGCMPUWNDY(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA150", Offset = "0x8FD9150", VA = "0x188FDA150")]
		public object NJVBVGKRURI(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2FAE0", Offset = "0x3F2EAE0", VA = "0x183F2FAE0")]
		public void VUTOUFYPAUL<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA1A0", Offset = "0x8FD91A0", VA = "0x188FDA1A0")]
		public void VUTOUFYPAUL(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class BLDYNNVPVLD<a> : VRGCMPUWNDY where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet XZITWYBPTBX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue QWAJCWANKTW;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x415B7B0", Offset = "0x415A7B0", VA = "0x18415B7B0")]
			internal string XYEFNLVLBTP(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x415B650", Offset = "0x415A650", VA = "0x18415B650")]
			internal object XXYYQFBNSIG(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74AC000", Offset = "0x74AB000", VA = "0x1874AC000")]
		public BLDYNNVPVLD(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74AACE0", Offset = "0x74A9CE0", VA = "0x1874AACE0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74AB3F0", Offset = "0x74AA3F0", VA = "0x1874AB3F0")]
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
	internal class BKRMAAPRLHO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class YCHVUIUSKEO : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static YCHVUIUSKEO HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA2F0", Offset = "0x8FD92F0", VA = "0x188FDA2F0", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA440", Offset = "0x8FD9440", VA = "0x188FDA440", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YCHVUIUSKEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class KWZOEAZFGZK : YCZMMYZLALT<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0540", Offset = "0x8FCF540", VA = "0x188FD0540", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0630", Offset = "0x8FCF630", VA = "0x188FD0630", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8FD07E0", Offset = "0x8FCF7E0", VA = "0x188FD07E0")]
			public KWZOEAZFGZK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly XEZIOSXZXVJ JMZKHXLSDSD;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly KWZOEAZFGZK MUHTFYTSJBG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<VRGCMPUWNDY> AXUMXKKRHKF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> ZJBLTJULWXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, VRGCMPUWNDY> JEGDPIURPOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FCDD40", Offset = "0x8FCCD40", VA = "0x188FCDD40")]
		public BKRMAAPRLHO([Optional] IList<VRGCMPUWNDY>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8FCBE00", Offset = "0x8FCAE00", VA = "0x188FCBE00")]
		public VRGCMPUWNDY HBUATRNVAGZ(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface ZVAZEEORZWB
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		LYNSMBPRVDV JZZLEAPQYWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class JSFVAMVAYEG : ZVAZEEORZWB
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static JSFVAMVAYEG QOPNVDOKBPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly RZKLHPQUCYO VSMAUAFTBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<RZKLHPQUCYO> BWTYRCVJTLP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public LYNSMBPRVDV JZZLEAPQYWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0440", Offset = "0x8FCF440", VA = "0x188FD0440")]
		public JSFVAMVAYEG(RZKLHPQUCYO a, IReadOnlyList<RZKLHPQUCYO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCF340", Offset = "0x8FCE340", VA = "0x188FCF340")]
		private static JSFVAMVAYEG WOSVIAIYGMN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class IVARARGSEHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> RZZFCMKJMJG;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCEFE0", Offset = "0x8FCDFE0", VA = "0x188FCEFE0")]
		public static bool OGYQWJFVMQC(this XLYBIIWOHJI a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCF0C0", Offset = "0x8FCE0C0", VA = "0x188FCF0C0")]
		public static bool ZIMTSSVITZN(this XLYBIIWOHJI a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface QWIQOIAFXMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> VBNGTADTJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType YZBSJJJXQLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface LYNSMBPRVDV : QWIQOIAFXMA, YSUZLOYWWAA, KUCVGNDDFYB<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string ZVTBTJJRLUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType RKAOPXNRVZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) WQKAGPVWXZM<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class RZKLHPQUCYO : LYNSMBPRVDV, QWIQOIAFXMA, YSUZLOYWWAA, KUCVGNDDFYB<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly BKRMAAPRLHO BKRMAAPRLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly BDUKXSMYZFB SVCXZHRHEXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? UDFKTXCFFEK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool DKTKSUMMBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7000", Offset = "0x8FD6000", VA = "0x188FD7000", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool ORERUILEQSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8330", Offset = "0x8FD7330", VA = "0x188FD8330", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool LINCJDURFFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8FD81E0", Offset = "0x8FD71E0", VA = "0x188FD81E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool FGEBKCZFPHS
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7180", Offset = "0x8FD6180", VA = "0x188FD7180", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool ZIOQJYVVJTS
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8FD70E0", Offset = "0x8FD60E0", VA = "0x188FD70E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool PANUCEROWED
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7280", Offset = "0x8FD6280", VA = "0x188FD7280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool STBGXAJKYRB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7130", Offset = "0x8FD6130", VA = "0x188FD7130", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType RKAOPXNRVZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAD5FD0", Offset = "0xAD4FD0", VA = "0x180AD5FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7771680", Offset = "0x7770680", VA = "0x187771680", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ZVTBTJJRLUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7771680", Offset = "0x7770680", VA = "0x187771680", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool JBWGEYWIKQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB31040", Offset = "0xB30040", VA = "0x180B31040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType YZBSJJJXQLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8190", Offset = "0x8FD7190", VA = "0x188FD8190", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> VBNGTADTJEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7E40", Offset = "0x8FD6E40", VA = "0x188FD7E40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool TBZQZTJWTPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7000", Offset = "0x8FD6000", VA = "0x188FD7000", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool VGKGMMGTYSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8FD70E0", Offset = "0x8FD60E0", VA = "0x188FD70E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LNJKNTVEJQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8330", Offset = "0x8FD7330", VA = "0x188FD8330", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool RVITDXLCYQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8FD81E0", Offset = "0x8FD71E0", VA = "0x188FD81E0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool RHOYZAZUZPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7180", Offset = "0x8FD6180", VA = "0x188FD7180", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool LZYHAPFISKV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7280", Offset = "0x8FD6280", VA = "0x188FD7280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool WJCJNNOMIKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7130", Offset = "0x8FD6130", VA = "0x188FD7130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> ZWQJZGJUEFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8FD71D0", Offset = "0x8FD61D0", VA = "0x188FD71D0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7C30", Offset = "0x8FD6C30", VA = "0x188FD7C30", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BBA0", Offset = "0x3D4ABA0", VA = "0x183D4BBA0", Slot = "6")]
		public (bool, a?) WQKAGPVWXZM<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B960", Offset = "0x3D4A960", VA = "0x183D4B960")]
		public RZKLHPQUCYO QNPEJCACULI<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8640", Offset = "0x8FD7640", VA = "0x188FD8640")]
		public RZKLHPQUCYO(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8620", Offset = "0x8FD7620", VA = "0x188FD8620")]
		public RZKLHPQUCYO(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8790", Offset = "0x8FD7790", VA = "0x188FD8790")]
		public RZKLHPQUCYO(RZKLHPQUCYO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8660", Offset = "0x8FD7660", VA = "0x188FD8660")]
		internal RZKLHPQUCYO(AccountRoleType a, [Optional] string? b, [Optional] RZKLHPQUCYO? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7CE0", Offset = "0x8FD6CE0", VA = "0x188FD7CE0")]
		public static RolePermissionType KUZPFCRLYUM(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6C30", Offset = "0x8FD5C30", VA = "0x188FD6C30")]
		public void CBXYJLBSLBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7EA0", Offset = "0x8FD6EA0", VA = "0x188FD7EA0")]
		internal RZKLHPQUCYO STAWDZNFXLI(RZKLHPQUCYO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6C50", Offset = "0x8FD5C50", VA = "0x188FD6C50")]
		internal IReadOnlyCollection<RolePermission> Copy(RZKLHPQUCYO roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7D60", Offset = "0x8FD6D60", VA = "0x188FD7D60")]
		public bool KZJOKQTZLYL(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8230", Offset = "0x8FD7230", VA = "0x188FD8230")]
		public (bool, string) VZVBOHJVWKW(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8380", Offset = "0x8FD7380", VA = "0x188FD8380")]
		internal void XGWHHOGPYJD(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FD83D0", Offset = "0x8FD73D0", VA = "0x188FD83D0")]
		public TIUHJEWXKMT YWEMCXFQXZF(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8FD72D0", Offset = "0x8FD62D0", VA = "0x188FD72D0")]
		public void KBYYRIGUSJZ(TIUHJEWXKMT a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7050", Offset = "0x8FD6050", VA = "0x188FD7050")]
		[CompilerGenerated]
		private void GJDQVQWPZLL(RolePermission a, LJWBYGLCZCW b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class NNEPKYCKLET : GPODLLWNQBN, SWFYPLFEJBY, IDisposable, HDYRQLWGVKS
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class BIIQCTJSALH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public RZKLHPQUCYO QBXYNJCFQSF;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BIIQCTJSALH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8FCBDD0", Offset = "0x8FCADD0", VA = "0x188FCBDD0")]
			internal bool RHZNGULLPXN(RZKLHPQUCYO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class DCEYDDAQGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType MKDRGTMUSPX;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DCEYDDAQGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x20203E0", Offset = "0x201F3E0", VA = "0x1820203E0")]
			internal bool ZBZHCYVNNJV(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class MGBCVPXOPLS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder PWBCGCMLGPD;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MGBCVPXOPLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0820", Offset = "0x8FCF820", VA = "0x188FD0820")]
			internal void HHQJYHIUDUA(TIUHJEWXKMT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0900", Offset = "0x8FCF900", VA = "0x188FD0900")]
			internal void HHVQVOCRNFJ(TIUHJEWXKMT a)
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
		private sealed class ALEWVFDKBTS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<TIUHJEWXKMT, LJWBYGLCZCW> VGFUWKVNEJZ;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ALEWVFDKBTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8FCB560", Offset = "0x8FCA560", VA = "0x188FCB560")]
			internal void LIDRBOYKHQZ(TIUHJEWXKMT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8FCB500", Offset = "0x8FCA500", VA = "0x188FCB500")]
			internal void LHNWJUQSFIY(TIUHJEWXKMT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8FCB530", Offset = "0x8FCA530", VA = "0x188FCB530")]
			internal void LHTDHBKPOUH(TIUHJEWXKMT a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class EVGZWVTKRBK<a> where a : notnull
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
				public EVGZWVTKRBK<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x4024940", Offset = "0x4023940", VA = "0x184024940", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission UZJWOPUMIOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType FEPCASFOUBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool IKJFEIHXNPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType KRSHSNAGPPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string ZTLYQMOMCTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public NNEPKYCKLET FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action NSIKHUONSEL;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public EVGZWVTKRBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4A81EB0", Offset = "0x4A80EB0", VA = "0x184A81EB0")]
			[AsyncStateMachine(typeof(EVGZWVTKRBK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void OUSQBCKUSIL()
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
			public HJXCNNISMJO rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, RZKLHPQUCYO> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public NXFOUHCNLLN debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8FD87E0", Offset = "0x8FD77E0", VA = "0x188FD87E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8FD92E0", Offset = "0x8FD82E0", VA = "0x188FD92E0", Slot = "5")]
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
			public NNEPKYCKLET <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8FD9340", Offset = "0x8FD8340", VA = "0x188FD9340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8FD99B0", Offset = "0x8FD89B0", VA = "0x188FD99B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly HJXCNNISMJO LTXYREXXUKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly JSFVAMVAYEG BAFNDHYMLVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly NXFOUHCNLLN KXQVDRNVKRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NWGHRGOXCMP? EDSZKSJALPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> AUPGNFJRXDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, RZKLHPQUCYO> DDISFOPJUPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, RZKLHPQUCYO> EVWSJTFVVFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, RZKLHPQUCYO> ALTRONXMQOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<RZKLHPQUCYO> NMGNUUNZQRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool FUDSLTRVMCD;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] YIDICIGINXJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ZVAZEEORZWB FYBQMDIEGTN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated ZCSBQHFYWVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8FD1710", Offset = "0x8FD0710", VA = "0x188FD1710", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8FD1AF0", Offset = "0x8FD0AF0", VA = "0x188FD1AF0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4CE0", Offset = "0x8FD3CE0", VA = "0x188FD4CE0")]
		[OKVIBKJHYHD.Room]
		internal static void OKVIBKJHYHD(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6630", Offset = "0x8FD5630", VA = "0x188FD6630")]
		[UnityEngine.Scripting.Preserve]
		internal NNEPKYCKLET([Inject(null)] HJXCNNISMJO roleDataProvider, [Inject(null)] JSFVAMVAYEG roleManagerDefaults, [Inject(null)] NXFOUHCNLLN debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1B90", Offset = "0x8FD0B90", VA = "0x188FD1B90", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0EA0", Offset = "0x8FCFEA0", VA = "0x188FD0EA0")]
		private void COGRVYCYMAR(IEnumerable<RZKLHPQUCYO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8FD63B0", Offset = "0x8FD53B0", VA = "0x188FD63B0", Slot = "10")]
		public bool XROAOQJBXWM(XLYBIIWOHJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2380", Offset = "0x8FD1380", VA = "0x188FD2380")]
		private void FTACDCXOHVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FD17B0", Offset = "0x8FD07B0", VA = "0x188FD17B0", Slot = "19")]
		public void DLYFIIEZVIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3AB0", Offset = "0x8FD2AB0", VA = "0x188FD3AB0", Slot = "8")]
		public IReadOnlyList<LYNSMBPRVDV> JHHFHRVKKNX(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1990", Offset = "0x8FD0990", VA = "0x188FD1990", Slot = "9")]
		public LYNSMBPRVDV DOZHTSJDNDJ(XLYBIIWOHJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4E90", Offset = "0x8FD3E90", VA = "0x188FD4E90")]
		private AccountRoleType OWFEYVOLEXL(XLYBIIWOHJI a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5740", Offset = "0x8FD4740", VA = "0x188FD5740", Slot = "12")]
		public bool SYDMIBNPEUF(XLYBIIWOHJI a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5A80", Offset = "0x8FD4A80", VA = "0x188FD5A80", Slot = "13")]
		public LYNSMBPRVDV UPREKKPMHME(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1F90", Offset = "0x8FD0F90", VA = "0x188FD1F90")]
		private static bool FAFXZQMCGLH(JNERXZWMZKW a, AccountRoleType b, [Out] TIUHJEWXKMT? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3130", Offset = "0x8FD2130", VA = "0x188FD3130")]
		private static void HAQVJPHHCJX(JNERXZWMZKW a, Action<TIUHJEWXKMT> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3220", Offset = "0x8FD2220", VA = "0x188FD3220")]
		private static void HAQVJPHHCJX(JNERXZWMZKW a, Action<TIUHJEWXKMT> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5650", Offset = "0x8FD4650", VA = "0x188FD5650")]
		private void RXQGPOAOYNC(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5510", Offset = "0x8FD4510", VA = "0x188FD5510", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task PCNKFYBAOTY([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4F60", Offset = "0x8FD3F60", VA = "0x188FD4F60")]
		private void OYJPQRMPICM(JNERXZWMZKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1C90", Offset = "0x8FD0C90", VA = "0x188FD1C90")]
		internal static string EYONILWVIDW(HJXCNNISMJO a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, RZKLHPQUCYO> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2390", Offset = "0x8FD1390", VA = "0x188FD2390")]
		private static void GQCSLNNBEPA(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3B30", Offset = "0x8FD2B30", VA = "0x188FD3B30")]
		private static void JQGRPOELOJX(JNERXZWMZKW a, IReadOnlyDictionary<AccountRoleType, RZKLHPQUCYO> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5B20", Offset = "0x8FD4B20", VA = "0x188FD5B20")]
		private static bool VORTKXOBWZW(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FD40F0", Offset = "0x8FD30F0", VA = "0x188FD40F0")]
		private static void MSMHEBSSVMJ(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B50460", Offset = "0x3B4F460", VA = "0x183B50460", Slot = "14")]
		public bool HDLAQIBGLBK<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FD56C0", Offset = "0x8FD46C0", VA = "0x188FD56C0", Slot = "15")]
		public string SKHAGIZHCEM(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0A00", Offset = "0x8FCFA00", VA = "0x188FD0A00", Slot = "16")]
		public bool ASKNLCOSNKA(XLYBIIWOHJI a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FD22C0", Offset = "0x8FD12C0", VA = "0x188FD22C0", Slot = "18")]
		public bool FFGKSWKIOGQ(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5800", Offset = "0x8FD4800", VA = "0x188FD5800")]
		private void TBOSUXKBTXE(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5630", Offset = "0x8FD4630", VA = "0x188FD5630")]
		private bool PlayerHasRole(XLYBIIWOHJI player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3820", Offset = "0x8FD2820", VA = "0x188FD3820")]
		private RZKLHPQUCYO HVLFWANEHWQ(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5290", Offset = "0x8FD4290", VA = "0x188FD5290")]
		internal AccountRoleType OYLDAVKKQSA(XLYBIIWOHJI a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3E70", Offset = "0x8FD2E70", VA = "0x188FD3E70")]
		private void LFTTSBCADNQ(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5A00", Offset = "0x8FD4A00", VA = "0x188FD5A00", Slot = "11")]
		public IReadOnlyList<LYNSMBPRVDV> ZPVBJTBYMCB(XLYBIIWOHJI a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5A00", Offset = "0x8FD4A00", VA = "0x188FD5A00")]
		internal IReadOnlyList<RZKLHPQUCYO> UCUDCZOVWOE(XLYBIIWOHJI a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4B10", Offset = "0x8FD3B10", VA = "0x188FD4B10")]
		internal IReadOnlyList<RZKLHPQUCYO> NMUOLNJQQHU(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5C30", Offset = "0x8FD4C30", VA = "0x188FD5C30")]
		private void WLUVQMQXVIR(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4820", Offset = "0x8FD3820", VA = "0x188FD4820")]
		private static bool MSTYLAWYUFB(RZKLHPQUCYO a, IReadOnlyDictionary<AccountRoleType, RZKLHPQUCYO> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3FB0", Offset = "0x8FD2FB0", VA = "0x188FD3FB0")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task MCPZBUVJYDJ(HJXCNNISMJO a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, RZKLHPQUCYO> c, NXFOUHCNLLN d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0C10", Offset = "0x8FCFC10", VA = "0x188FD0C10")]
		[CompilerGenerated]
		internal static void CMAFUJCOTHS(Func<TIUHJEWXKMT, LJWBYGLCZCW> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FD34B0", Offset = "0x8FD24B0", VA = "0x188FD34B0")]
		[CompilerGenerated]
		internal static bool HEMNJCRUHDR(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface KZLBKYPGVNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WFDQRVRMQET(XLYBIIWOHJI a, XLYBIIWOHJI b, IEnumerable<XLYBIIWOHJI> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string WVPCQTTEIXO(VotekickFailReason a);
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
	internal class FPVVNGPSWUP : KZLBKYPGVNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SWFYPLFEJBY URHCSJQVEQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly GIFXIESCMPL EMNWNLWRILB;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		[RecRoom.NoEngine.Common.Preserve]
		public FPVVNGPSWUP([Inject(null)] SWFYPLFEJBY roomRoleManager, [Inject(null)] GIFXIESCMPL gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8FCEDA0", Offset = "0x8FCDDA0", VA = "0x188FCEDA0")]
		private static PlayerEvent? RWSKPHXEFKQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8FCEDE0", Offset = "0x8FCDDE0", VA = "0x188FCEDE0", Slot = "4")]
		public bool WFDQRVRMQET(XLYBIIWOHJI a, XLYBIIWOHJI b, IEnumerable<XLYBIIWOHJI> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCEEE0", Offset = "0x8FCDEE0", VA = "0x188FCEEE0", Slot = "5")]
		public string WVPCQTTEIXO(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE7A0", Offset = "0x8FCD7A0", VA = "0x188FCE7A0")]
		internal bool RSEMDSGFGOO(XLYBIIWOHJI a, XLYBIIWOHJI b, IEnumerable<XLYBIIWOHJI> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
