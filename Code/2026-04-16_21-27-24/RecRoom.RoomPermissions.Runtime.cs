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
		[Cpp2IlInjected.Address(RVA = "0xA0FD290", Offset = "0xA0FC090", VA = "0x18A0FD290")]
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
		[Cpp2IlInjected.Address(RVA = "0xA101980", Offset = "0xA100780", VA = "0x18A101980", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
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
	public delegate void OnRoomRoleUpdated(GUPOFWBVNMS player);
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
	public interface EZSNCETWYCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool SWKHZEKYHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool SWQBMHADHYR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool ERHPTQLQAEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool XEASAZSQJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool TJBWHPAWBHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool VSHOUSQUJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool MFJMVZRCJZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class LFUSLWRKQSP
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
		public static readonly Guid PMCFBUOQGOJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid LWXBQQSQENQ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid BSNGYKMLITP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid ERHNLBUSVFH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid ULTEPEFWSXW;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid VWXNEGWTJEL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly FCIQRPBUYVU<AccountRoleType, Guid> JWLJOZKAEHY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> HEDMSOPMOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA0FC4D0", Offset = "0xA0FB2D0", VA = "0x18A0FC4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC5F0", Offset = "0xA0FB3F0", VA = "0x18A0FC5F0")]
		public static AccountRoleType VVCYTQOEDQM(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC430", Offset = "0xA0FB230", VA = "0x18A0FC430")]
		public static Guid MGBZPECFYNO(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC270", Offset = "0xA0FB070", VA = "0x18A0FC270")]
		public static bool DEDBAKAEZJX(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC550", Offset = "0xA0FB350", VA = "0x18A0FC550")]
		public static bool QFGMQLMALDL(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC3B0", Offset = "0xA0FB1B0", VA = "0x18A0FC3B0")]
		public static AccountRoleType JVOQYLIBYNM(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC300", Offset = "0xA0FB100", VA = "0x18A0FC300")]
		public static DEPRECATED_RoomRoleId HWOSBJRIKHD(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC3F0", Offset = "0xA0FB1F0", VA = "0x18A0FC3F0")]
		internal static AccountRoleType KDUVZSOUKGQ(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface GRQRSDUVJTG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance NUJXVFCJWAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO FDLGPYJSFUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> DEXGUSRQYNT;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action HCXHHBGIELJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType BVVWGIQPRVP(GUPOFWBVNMS a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> PRSRRMQELAU(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task RETFLEDISFU(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task IZAEWBHUXGW(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<GUPOFWBVNMS> EXUQSQMWBDZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class VZXVEHBEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA101440", Offset = "0xA100240", VA = "0x18A101440")]
		public static AccountRoleType VBOWTQVVBRA(this GRQRSDUVJTG a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface NFDJDHRZNUK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		CNPFTKSUTDH BFHFACHFVWT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated WOSUXJTFWRB;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TMYZXMFTYPJ> GPSVTBFJIKN(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TMYZXMFTYPJ XKLCXWFNXDZ(GUPOFWBVNMS a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ACEOLHDKCUE(GUPOFWBVNMS a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<TMYZXMFTYPJ> QIVKUFGVSRD(GUPOFWBVNMS a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OSBZQWTBKHH(GUPOFWBVNMS a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		TMYZXMFTYPJ VSDVTNXPPXG(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool RPRRWPUQSBG<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string ASMGOGOQCPO(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool AOKTAFAGOEA(GUPOFWBVNMS a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface KJCJYXZXUKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ZFOSRTNLMTQ(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface YWPURMAGBYR<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> LJDCBDUQXYW;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? ZLSGPVKCCIO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? WQDQJWXXUOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD410", Offset = "0xA0FC210", VA = "0x18A0FD410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD310", Offset = "0xA0FC110", VA = "0x18A0FD310")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD4E0", Offset = "0xA0FC2E0", VA = "0x18A0FD4E0")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool KEOAWCDQEWI(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> YEOGIWBECFI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x73E0CF0", Offset = "0x73DFAF0", VA = "0x1873E0CF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73E08B0", Offset = "0x73DF6B0", VA = "0x1873E08B0", Slot = "4")]
		public override bool KEOAWCDQEWI(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73DFC80", Offset = "0x73DEA80", VA = "0x1873DFC80")]
		public bool EDSZMHOYBRY(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x73E0FD0", Offset = "0x73DFDD0", VA = "0x1873E0FD0")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class JHNDSYIAYEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> NCUNDRIQETW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> GJKUIPBGMWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly UOQBLTTYPIE ATWYZQCXUKU;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA0FBE40", Offset = "0xA0FAC40", VA = "0x18A0FBE40")]
		public JHNDSYIAYEH(UOQBLTTYPIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA0FBA60", Offset = "0xA0FA860", VA = "0x18A0FBA60")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B41260", Offset = "0x3B40060", VA = "0x183B41260")]
		public bool NQZUSXOOFCY<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B41A00", Offset = "0x3B40800", VA = "0x183B41A00")]
		public (bool, a?) RCPMALRWGQU<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA0FB980", Offset = "0xA0FA780", VA = "0x18A0FB980")]
		public bool NQZUSXOOFCY(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0FBAD0", Offset = "0xA0FA8D0", VA = "0x18A0FBAD0")]
		public (bool, object) RCPMALRWGQU(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B42110", Offset = "0x3B40F10", VA = "0x183B42110")]
		private void WNWTFLIEJUX<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA0FB8B0", Offset = "0xA0FA6B0", VA = "0x18A0FB8B0")]
		private Permission KKTYDOYLUAJ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA0FBC60", Offset = "0xA0FAA60", VA = "0x18A0FBC60")]
		public void SESEFUAZBQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class KNHCLFVJAZQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string VXUBJNZPMVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type KTEMKBYSCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType OVMKCPSBWKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission QFCUGKSUBTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet FFBDUBUDLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue VYNJFMFMYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission ZLXNQXYNGPD;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC1D0", Offset = "0xA0FAFD0", VA = "0x18A0FC1D0")]
		public KNHCLFVJAZQ(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC0D0", Offset = "0xA0FAED0", VA = "0x18A0FC0D0")]
		public object DIPEDTFCQHM(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2000", Offset = "0x3BC0E00", VA = "0x183BC2000")]
		public void WNWTFLIEJUX<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC120", Offset = "0xA0FAF20", VA = "0x18A0FC120")]
		public void WNWTFLIEJUX(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class JLBUMJJMVTT<a> : KNHCLFVJAZQ where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet RAOAABOEMGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue WFBLEDDAPRG;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62AC980", Offset = "0x62AB780", VA = "0x1862AC980")]
			internal string ACZJUZCAUSN(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62AC420", Offset = "0x62AB220", VA = "0x1862AC420")]
			internal object ACUCXSIDLHE(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6659D70", Offset = "0x6658B70", VA = "0x186659D70")]
		public JLBUMJJMVTT(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x66596C0", Offset = "0x66584C0", VA = "0x1866596C0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6659B40", Offset = "0x6658940", VA = "0x186659B40")]
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
	internal class UOQBLTTYPIE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class GDOCOWGGXGO : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static GDOCOWGGXGO GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA0F55C0", Offset = "0xA0F43C0", VA = "0x18A0F55C0", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA0F5710", Offset = "0xA0F4510", VA = "0x18A0F5710", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GDOCOWGGXGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class TZTVJJUQJTK : XSDXOWNJGCN<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD5E0", Offset = "0xA0FC3E0", VA = "0x18A0FD5E0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD6D0", Offset = "0xA0FC4D0", VA = "0x18A0FD6D0", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD880", Offset = "0xA0FC680", VA = "0x18A0FD880")]
			public TZTVJJUQJTK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly KHPEEAEJHHN ATXTBNASVHB;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly TZTVJJUQJTK GLNREYRXPEQ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<KNHCLFVJAZQ> KUFDSJAZRMR;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> OIZBKABFFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, KNHCLFVJAZQ> HJYWRANJQVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA101110", Offset = "0xA0FFF10", VA = "0x18A101110")]
		public UOQBLTTYPIE([Optional] IList<KNHCLFVJAZQ>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0FF230", Offset = "0xA0FE030", VA = "0x18A0FF230")]
		public KNHCLFVJAZQ YDHOXOAKPQZ(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface CNPFTKSUTDH
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		TMYZXMFTYPJ HTSNQTGNIRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class EPKGQSAXJOO : CNPFTKSUTDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static EPKGQSAXJOO MBBGQKHGEXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly DLGFVBYHOUW INOTITWFFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<DLGFVBYHOUW> QWEVZYHBKAZ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public TMYZXMFTYPJ HTSNQTGNIRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA0F54C0", Offset = "0xA0F42C0", VA = "0x18A0F54C0")]
		public EPKGQSAXJOO(DLGFVBYHOUW a, IReadOnlyList<DLGFVBYHOUW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA0F43D0", Offset = "0xA0F31D0", VA = "0x18A0F43D0")]
		private static EPKGQSAXJOO QAXRIGYMSWB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class DGKMZVMKLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA0F2570", Offset = "0xA0F1370", VA = "0x18A0F2570")]
		public static GWNYHZGWJFQ ZICEKNFXIXE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class WIJSZBKHWGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> AVFEIJKQBIM;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA1014A0", Offset = "0xA1002A0", VA = "0x18A1014A0")]
		public static bool KTVAYAJRQRA(this GUPOFWBVNMS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA101580", Offset = "0xA100380", VA = "0x18A101580")]
		public static bool VESBAMAMZYH(this GUPOFWBVNMS a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface TYXBMKVSUZK
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> TAPYOBLWWKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType CFBVRPLOFEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface TMYZXMFTYPJ : TYXBMKVSUZK, EZSNCETWYCM, YWPURMAGBYR<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string EBTEFKYMZSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType HQUSLXOLZIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) BMJFSKMZABI<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class DLGFVBYHOUW : TMYZXMFTYPJ, TYXBMKVSUZK, EZSNCETWYCM, YWPURMAGBYR<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly UOQBLTTYPIE UOQBLTTYPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly JHNDSYIAYEH KSWDUZDVJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? AHYVHRACAQW;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool MXQWYRKZTLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA0F28D0", Offset = "0xA0F16D0", VA = "0x18A0F28D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool UCLKCJINTUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2920", Offset = "0xA0F1720", VA = "0x18A0F2920", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool USNIFXKLDKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3460", Offset = "0xA0F2260", VA = "0x18A0F3460", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool RGJIYCUHIQM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3500", Offset = "0xA0F2300", VA = "0x18A0F3500", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool OGYYYJHNEUU
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2F50", Offset = "0xA0F1D50", VA = "0x18A0F2F50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool FAXSLDHGUHF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3620", Offset = "0xA0F2420", VA = "0x18A0F3620", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RYYKVMRHMZB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA0F34B0", Offset = "0xA0F22B0", VA = "0x18A0F34B0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType HQUSLXOLZIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x88ACDD0", Offset = "0x88ABBD0", VA = "0x1888ACDD0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string EBTEFKYMZSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x88ACDD0", Offset = "0x88ABBD0", VA = "0x1888ACDD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ODALIQKTETY
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD44660", Offset = "0xD43460", VA = "0x180D44660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD44D80", Offset = "0xD43B80", VA = "0x180D44D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType CFBVRPLOFEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2970", Offset = "0xA0F1770", VA = "0x18A0F2970", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> TAPYOBLWWKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3570", Offset = "0xA0F2370", VA = "0x18A0F3570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool BHKGWCZFPQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0F28D0", Offset = "0xA0F16D0", VA = "0x18A0F28D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BZXTLQYJXSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2F50", Offset = "0xA0F1D50", VA = "0x18A0F2F50", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool QNLEOGUCHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2920", Offset = "0xA0F1720", VA = "0x18A0F2920", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool BCFWJONKTOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3460", Offset = "0xA0F2260", VA = "0x18A0F3460", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool GDJZFOIOELM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3500", Offset = "0xA0F2300", VA = "0x18A0F3500", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool VGLMAXFEABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3620", Offset = "0xA0F2420", VA = "0x18A0F3620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool HFFLHOBUBQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA0F34B0", Offset = "0xA0F22B0", VA = "0x18A0F34B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> LJDCBDUQXYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA0F3670", Offset = "0xA0F2470", VA = "0x18A0F3670", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA0F2820", Offset = "0xA0F1620", VA = "0x18A0F2820", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x38D55D0", Offset = "0x38D43D0", VA = "0x1838D55D0", Slot = "6")]
		public (bool, a?) BMJFSKMZABI<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x38D5AA0", Offset = "0x38D48A0", VA = "0x1838D5AA0")]
		public DLGFVBYHOUW XPTSQDCQQPY<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4210", Offset = "0xA0F3010", VA = "0x18A0F4210")]
		public DLGFVBYHOUW(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4230", Offset = "0xA0F3030", VA = "0x18A0F4230")]
		public DLGFVBYHOUW(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4380", Offset = "0xA0F3180", VA = "0x18A0F4380")]
		public DLGFVBYHOUW(DLGFVBYHOUW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4250", Offset = "0xA0F3050", VA = "0x18A0F4250")]
		internal DLGFVBYHOUW(AccountRoleType a, [Optional] string? b, [Optional] DLGFVBYHOUW? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4080", Offset = "0xA0F2E80", VA = "0x18A0F4080")]
		public static RolePermissionType YFTQMGWTDTS(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA0F3550", Offset = "0xA0F2350", VA = "0x18A0F3550")]
		public void SESEFUAZBQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0F2FA0", Offset = "0xA0F1DA0", VA = "0x18A0F2FA0")]
		internal DLGFVBYHOUW ETGRVPKBPXI(DLGFVBYHOUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA0F29C0", Offset = "0xA0F17C0", VA = "0x18A0F29C0")]
		internal IReadOnlyCollection<RolePermission> Copy(DLGFVBYHOUW roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0F2E70", Offset = "0xA0F1C70", VA = "0x18A0F2E70")]
		public bool EDMCWBOVHGX(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0F2D70", Offset = "0xA0F1B70", VA = "0x18A0F2D70")]
		public (bool, string) DIBJOOROREW(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0F35D0", Offset = "0xA0F23D0", VA = "0x18A0F35D0")]
		internal void TMUOZBQJNGF(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0F3290", Offset = "0xA0F2090", VA = "0x18A0F3290")]
		public DRBKVPYCJTR FILRXGIWTLZ(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0F3720", Offset = "0xA0F2520", VA = "0x18A0F3720")]
		public void XSSFTEMQXXB(DRBKVPYCJTR a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4100", Offset = "0xA0F2F00", VA = "0x18A0F4100")]
		[CompilerGenerated]
		private void ZOLNEEMQLGV(RolePermission a, YOOUMTQUXPU b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class HXVPVISYGPB : KJCJYXZXUKL, NFDJDHRZNUK, IDisposable, HQRZYLKAOYK
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class LMHYOZGZEPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public DLGFVBYHOUW NHZBRINNGAJ;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LMHYOZGZEPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA0FC9A0", Offset = "0xA0FB7A0", VA = "0x18A0FC9A0")]
			internal bool MFXATXFFMPB(DLGFVBYHOUW a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class FSAELSPRGFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType YCYTGUTOBIJ;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FSAELSPRGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EE9D30", Offset = "0x1EE8B30", VA = "0x181EE9D30")]
			internal bool XLWBJFDHBDZ(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class ZTAPQDVUGTO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder NEOZPBOVTCZ;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZTAPQDVUGTO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA1017A0", Offset = "0xA1005A0", VA = "0x18A1017A0")]
			internal void SKHVBAWBDSE(DRBKVPYCJTR a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA101880", Offset = "0xA100680", VA = "0x18A101880")]
			internal void SKNBYHPYNDN(DRBKVPYCJTR a)
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
		private sealed class NRRWZKOWDCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<DRBKVPYCJTR, YOOUMTQUXPU> LAIRDPOPTJF;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NRRWZKOWDCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD260", Offset = "0xA0FC060", VA = "0x18A0FD260")]
			internal void SMCGFFESEMV(DRBKVPYCJTR a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD200", Offset = "0xA0FC000", VA = "0x18A0FD200")]
			internal void SLMLNKXACEU(DRBKVPYCJTR a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD230", Offset = "0xA0FC030", VA = "0x18A0FD230")]
			internal void SLRSKRQXLQD(DRBKVPYCJTR a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class SBAFNWZQOUA<a> where a : notnull
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
				public SBAFNWZQOUA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x41B3330", Offset = "0x41B2130", VA = "0x1841B3330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission KHGLPVXEWTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType NPNRIXXYEZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool ZAFXISKWRYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType SEVYIPTCNED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string VYEUGLINXTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HXVPVISYGPB XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action DZKWVOLLIML;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SBAFNWZQOUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x78A7F70", Offset = "0x78A6D70", VA = "0x1878A7F70")]
			[AsyncStateMachine(typeof(SBAFNWZQOUA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void ZTYACGONFZV()
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
			public GRQRSDUVJTG rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, DLGFVBYHOUW> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public LPZDEKKDVPV debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD8C0", Offset = "0xA0FC6C0", VA = "0x18A0FD8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA0FE3C0", Offset = "0xA0FD1C0", VA = "0x18A0FE3C0", Slot = "5")]
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
			public HXVPVISYGPB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA0FE420", Offset = "0xA0FD220", VA = "0x18A0FE420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA0FEA90", Offset = "0xA0FD890", VA = "0x18A0FEA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly GRQRSDUVJTG QXARNCRUFHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly EPKGQSAXJOO VXULCOFGDDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly LPZDEKKDVPV ODDJXNRQKTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private RZJBQRBPHRB? EJDSGBOYWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> QNCTRXQGVPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, DLGFVBYHOUW> LBXZKUQHPIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, DLGFVBYHOUW> BBSIKTDNWXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, DLGFVBYHOUW> NPIMDSLAGGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<DLGFVBYHOUW> XEJLPOXPMQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool JHJIMPCMUXR;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] JJJWLXKCNHB;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CNPFTKSUTDH BFHFACHFVWT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated WOSUXJTFWRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA0F6810", Offset = "0xA0F5610", VA = "0x18A0F6810", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0F87B0", Offset = "0xA0F75B0", VA = "0x18A0F87B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6660", Offset = "0xA0F5460", VA = "0x18A0F6660")]
		[CXDXQIFYXBD.Room]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0FB600", Offset = "0xA0FA400", VA = "0x18A0FB600")]
		[UnityEngine.Scripting.Preserve]
		internal HXVPVISYGPB([Inject(null)] GRQRSDUVJTG roleDataProvider, [Inject(null)] EPKGQSAXJOO roleManagerDefaults, [Inject(null)] LPZDEKKDVPV debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6CB0", Offset = "0xA0F5AB0", VA = "0x18A0F6CB0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0F70E0", Offset = "0xA0F5EE0", VA = "0x18A0F70E0")]
		private void EKFKTOIXGYJ(IEnumerable<DLGFVBYHOUW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0F59E0", Offset = "0xA0F47E0", VA = "0x18A0F59E0", Slot = "10")]
		public bool ACEOLHDKCUE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8850", Offset = "0xA0F7650", VA = "0x18A0F8850")]
		private void HCXHHBGIELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8860", Offset = "0xA0F7660", VA = "0x18A0F8860", Slot = "19")]
		public void HFXBSKEZVSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0F7C40", Offset = "0xA0F6A40", VA = "0x18A0F7C40", Slot = "8")]
		public IReadOnlyList<TMYZXMFTYPJ> GPSVTBFJIKN(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0FAAB0", Offset = "0xA0F98B0", VA = "0x18A0FAAB0", Slot = "9")]
		public TMYZXMFTYPJ XKLCXWFNXDZ(GUPOFWBVNMS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA0FA810", Offset = "0xA0F9610", VA = "0x18A0FA810")]
		private AccountRoleType WOBUKKHJGXL(GUPOFWBVNMS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8F50", Offset = "0xA0F7D50", VA = "0x18A0F8F50", Slot = "12")]
		public bool OSBZQWTBKHH(GUPOFWBVNMS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0FA770", Offset = "0xA0F9570", VA = "0x18A0FA770", Slot = "13")]
		public TMYZXMFTYPJ VSDVTNXPPXG(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0F5AB0", Offset = "0xA0F48B0", VA = "0x18A0F5AB0")]
		private static bool ADKOECABGLX(GWNYHZGWJFQ a, AccountRoleType b, [Out] DRBKVPYCJTR? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0F60E0", Offset = "0xA0F4EE0", VA = "0x18A0F60E0")]
		private static void BXQPXNSYZJL(GWNYHZGWJFQ a, Action<DRBKVPYCJTR> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0F61D0", Offset = "0xA0F4FD0", VA = "0x18A0F61D0")]
		private static void BXQPXNSYZJL(GWNYHZGWJFQ a, Action<DRBKVPYCJTR> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6070", Offset = "0xA0F4E70", VA = "0x18A0F6070")]
		private void BHTQGIEJUTG(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0FB330", Offset = "0xA0FA130", VA = "0x18A0FB330", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task ZFOSRTNLMTQ([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6DB0", Offset = "0xA0F5BB0", VA = "0x18A0F6DB0")]
		private void ECFLOBUXALK(GWNYHZGWJFQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA0F92B0", Offset = "0xA0F80B0", VA = "0x18A0F92B0")]
		internal static string QDCFCYYEFUI(GRQRSDUVJTG a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, DLGFVBYHOUW> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0F9630", Offset = "0xA0F8430", VA = "0x18A0F9630")]
		private static void SPSFVPQFXVQ(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6970", Offset = "0xA0F5770", VA = "0x18A0F6970")]
		private static void DWBSQRYPAXL(GWNYHZGWJFQ a, IReadOnlyDictionary<AccountRoleType, DLGFVBYHOUW> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0FA3D0", Offset = "0xA0F91D0", VA = "0x18A0FA3D0")]
		private static bool UKPXVDSOYNW(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA0FAC10", Offset = "0xA0F9A10", VA = "0x18A0FAC10")]
		private static void YSZRYWOLEFD(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3A50", Offset = "0x3AD2850", VA = "0x183AD3A50", Slot = "14")]
		public bool RPRRWPUQSBG<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0F5FF0", Offset = "0xA0F4DF0", VA = "0x18A0F5FF0", Slot = "15")]
		public string ASMGOGOQCPO(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0F5DE0", Offset = "0xA0F4BE0", VA = "0x18A0F5DE0", Slot = "16")]
		public bool AOKTAFAGOEA(GUPOFWBVNMS a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA0F68B0", Offset = "0xA0F56B0", VA = "0x18A0F68B0", Slot = "18")]
		public bool DRYVDJSDYXO(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6460", Offset = "0xA0F5260", VA = "0x18A0F6460")]
		private void CIYXLLIUQBM(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA0F9290", Offset = "0xA0F8090", VA = "0x18A0F9290")]
		private bool PlayerHasRole(GUPOFWBVNMS player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8B80", Offset = "0xA0F7980", VA = "0x18A0F8B80")]
		private DLGFVBYHOUW KPKNTDCITQE(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0F9010", Offset = "0xA0F7E10", VA = "0x18A0F9010")]
		internal AccountRoleType PZPSVSHDVAQ(GUPOFWBVNMS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8E10", Offset = "0xA0F7C10", VA = "0x18A0F8E10")]
		private void LVLGBQZXPQS(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0F95B0", Offset = "0xA0F83B0", VA = "0x18A0F95B0", Slot = "11")]
		public IReadOnlyList<TMYZXMFTYPJ> QIVKUFGVSRD(GUPOFWBVNMS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0F95B0", Offset = "0xA0F83B0", VA = "0x18A0F95B0")]
		internal IReadOnlyList<DLGFVBYHOUW> VWBAFGMIPSY(GUPOFWBVNMS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0FA8E0", Offset = "0xA0F96E0", VA = "0x18A0FA8E0")]
		internal IReadOnlyList<DLGFVBYHOUW> XEAIORIDOOG(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8030", Offset = "0xA0F6E30", VA = "0x18A0F8030")]
		private void GVHCEYGUQKR(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0F7950", Offset = "0xA0F6750", VA = "0x18A0F7950")]
		private static bool GIQWIHYKCFB(DLGFVBYHOUW a, IReadOnlyDictionary<AccountRoleType, DLGFVBYHOUW> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0F8A40", Offset = "0xA0F7840", VA = "0x18A0F8A40")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task JKESOMBWEPB(GRQRSDUVJTG a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, DLGFVBYHOUW> c, LPZDEKKDVPV d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA0FA4E0", Offset = "0xA0F92E0", VA = "0x18A0FA4E0")]
		[CompilerGenerated]
		internal static void UWCOQYCONAI(Func<DRBKVPYCJTR, YOOUMTQUXPU> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0F7CC0", Offset = "0xA0F6AC0", VA = "0x18A0F7CC0")]
		[CompilerGenerated]
		internal static bool GQEXVJABFVF(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface GWNRQQYUXKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LDGIEVLKLQX(GUPOFWBVNMS a, GUPOFWBVNMS b, IEnumerable<GUPOFWBVNMS> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string ROKYSEWWFKU(VotekickFailReason a);
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
	internal class NQZJKLCXEMH : GWNRQQYUXKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly NFDJDHRZNUK UPDSNVCISPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly HBQHGCJQFAF LAORTTTMWDJ;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		[RecRoom.NoEngine.Common.Preserve]
		public NQZJKLCXEMH([Inject(null)] NFDJDHRZNUK roomRoleManager, [Inject(null)] HBQHGCJQFAF gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD1C0", Offset = "0xA0FBFC0", VA = "0x18A0FD1C0")]
		private static PlayerEvent? TYAQLRREALS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC9D0", Offset = "0xA0FB7D0", VA = "0x18A0FC9D0", Slot = "4")]
		public bool LDGIEVLKLQX(GUPOFWBVNMS a, GUPOFWBVNMS b, IEnumerable<GUPOFWBVNMS> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD0C0", Offset = "0xA0FBEC0", VA = "0x18A0FD0C0", Slot = "5")]
		public string ROKYSEWWFKU(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA0FCAD0", Offset = "0xA0FB8D0", VA = "0x18A0FCAD0")]
		internal bool RMGGNZRCLQG(GUPOFWBVNMS a, GUPOFWBVNMS b, IEnumerable<GUPOFWBVNMS> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
