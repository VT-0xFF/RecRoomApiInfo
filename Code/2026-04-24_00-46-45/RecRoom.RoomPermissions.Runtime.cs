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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA27EF30", Offset = "0xA27D930", VA = "0x18A27EF30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA28BDC0", Offset = "0xA28A7C0", VA = "0x18A28BDC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
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
	public delegate void OnRoomRoleUpdated(KDSOOWCXYNX player);
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
	public interface NIHIHNUPVSD
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IPVZAFDUOUM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JSNOCUYZGMS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool QMGKCESUIAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool EYVVCFOQQET
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ZIMLIFLNUHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool SZDRWSFMFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool AQUCNZDEZLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class GDGKHANGAES
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
		public static readonly Guid PEUNWZUVJKG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid WODCYJDBDKL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid WAKFVZJVVTO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid SBMEVMCQNCE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid YCNUOBRTVUL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid CCOQIFOQCQG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly VXHTUMSVKHZ<AccountRoleType, Guid> IDASXCDAKLJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> AVJJKNTKUTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA27D5D0", Offset = "0xA27BFD0", VA = "0x18A27D5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA27D450", Offset = "0xA27BE50", VA = "0x18A27D450")]
		public static AccountRoleType GKAMZMSTXND(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA27D730", Offset = "0xA27C130", VA = "0x18A27D730")]
		public static Guid WNFOAXMCBDX(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA27D3C0", Offset = "0xA27BDC0", VA = "0x18A27D3C0")]
		public static bool GCJBLGNRHSK(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA27D650", Offset = "0xA27C050", VA = "0x18A27D650")]
		public static bool OXLDPVMADRM(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA27D6F0", Offset = "0xA27C0F0", VA = "0x18A27D6F0")]
		public static AccountRoleType UYGMZNTOKVL(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA27D4E0", Offset = "0xA27BEE0", VA = "0x18A27D4E0")]
		public static DEPRECATED_RoomRoleId GSGJLGYQZDS(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA27D590", Offset = "0xA27BF90", VA = "0x18A27D590")]
		internal static AccountRoleType JWCSKAMTWMT(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface TSKYEDQASOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance BUAGLAOCVBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO USQTIUECTNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> DFBVHJCPLUC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action WBYSSOKFAGE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType FYSLKNNJGCC(KDSOOWCXYNX a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> PDDXIJMNQJF(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task ZHJHNXOKZKH(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task KIVAHSCHQQV(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<KDSOOWCXYNX> GIXKUUZVPUE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class HNDAIUZIBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA27ECF0", Offset = "0xA27D6F0", VA = "0x18A27ECF0")]
		public static AccountRoleType CJCBWZFFSJB(this TSKYEDQASOH a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface CISQPIGMQSN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		WSZXZDAMJMW DHWEIWWNJQU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated WEPKTEXIXFW;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<QLZEAHTGCGW> NMGAAEZRZUA(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QLZEAHTGCGW JPAWCJRSUXE(KDSOOWCXYNX a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PWROFWMFENZ(KDSOOWCXYNX a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<QLZEAHTGCGW> CLRCGMLZTJS(KDSOOWCXYNX a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool WWZFNDAGXHG(KDSOOWCXYNX a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		QLZEAHTGCGW GHNOETBFMMN(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IIPJGPYQIOT<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string HQOWLHFYORT(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool AFWFXKRGQIR(KDSOOWCXYNX a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface HFFOVMCGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task MFHMYIHKCRD(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GBXYRGQQTFG<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> EOINIDBRMIL;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? VICIZWZEUAJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? DOOMFOOTGTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA280B60", Offset = "0xA27F560", VA = "0x18A280B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA280C30", Offset = "0xA27F630", VA = "0x18A280C30")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA280D30", Offset = "0xA27F730", VA = "0x18A280D30")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool DQMVUXBDMYP(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> TJSPAQIMTYV;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x741DF10", Offset = "0x741C910", VA = "0x18741DF10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x741D610", Offset = "0x741C010", VA = "0x18741D610", Slot = "4")]
		public override bool DQMVUXBDMYP(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x741D7D0", Offset = "0x741C1D0", VA = "0x18741D7D0")]
		public bool VUHYEAOKGUX(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x741E3B0", Offset = "0x741CDB0", VA = "0x18741E3B0")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class WUQDJCWNJYE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> GEBSAQOIHEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> OYFITEKWBQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly QXYLOUDGMGP XVHFFXQMNTZ;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA285880", Offset = "0xA284280", VA = "0x18A285880")]
		public WUQDJCWNJYE(QXYLOUDGMGP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA2854D0", Offset = "0xA283ED0", VA = "0x18A2854D0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41191B0", Offset = "0x4117BB0", VA = "0x1841191B0")]
		public bool QMVJFUTSCTD<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41198C0", Offset = "0x41182C0", VA = "0x1841198C0")]
		public (bool, a?) ZYWQGNXDLBP<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA285540", Offset = "0xA283F40", VA = "0x18A285540")]
		public bool QMVJFUTSCTD(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA2856F0", Offset = "0xA2840F0", VA = "0x18A2856F0")]
		public (bool, object) ZYWQGNXDLBP(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41190A0", Offset = "0x4117AA0", VA = "0x1841190A0")]
		private void LBXQQIOQPSW<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA285620", Offset = "0xA284020", VA = "0x18A285620")]
		private Permission TCLPMJICGLK(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA2852E0", Offset = "0xA283CE0", VA = "0x18A2852E0")]
		public void NERJYRLBXIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class WSSEEJUBLHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string ODTXHYIDCUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type POTHCYLKJSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType SQHMOGWQVGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission VJPLOKGHDTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet KMOXYXRIZBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue AOHDEWXXXHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission EBQNVFLJSKE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA285240", Offset = "0xA283C40", VA = "0x18A285240")]
		public WSSEEJUBLHV(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA285140", Offset = "0xA283B40", VA = "0x18A285140")]
		public object AFDKUDCPANX(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4118B10", Offset = "0x4117510", VA = "0x184118B10")]
		public void LBXQQIOQPSW<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA285190", Offset = "0xA283B90", VA = "0x18A285190")]
		public void LBXQQIOQPSW(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class GXTNRFVHHGU<a> : WSSEEJUBLHV where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet IBBUHQEQYDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue JFBKFPEEMAB;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8737DB0", Offset = "0x87367B0", VA = "0x188737DB0")]
			internal string CMTNCYRJJNO(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8738340", Offset = "0x8736D40", VA = "0x188738340")]
			internal object CMYUAFLGSYX(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x647C030", Offset = "0x647AA30", VA = "0x18647C030")]
		public GXTNRFVHHGU(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x647AED0", Offset = "0x64798D0", VA = "0x18647AED0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x647BDF0", Offset = "0x647A7F0", VA = "0x18647BDF0")]
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
	internal class QXYLOUDGMGP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class QTYRNHGYBJX : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static QTYRNHGYBJX UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA280E30", Offset = "0xA27F830", VA = "0x18A280E30", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA280F80", Offset = "0xA27F980", VA = "0x18A280F80", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public QTYRNHGYBJX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class ZQMJXMXNFHJ : UHZRSONWGEO<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA285BB0", Offset = "0xA2845B0", VA = "0x18A285BB0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA285CA0", Offset = "0xA2846A0", VA = "0x18A285CA0", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA285E50", Offset = "0xA284850", VA = "0x18A285E50")]
			public ZQMJXMXNFHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly PEZVSSWXVSM JHJMMXQVUWE;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly ZQMJXMXNFHJ IJPYKNHEREP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<WSSEEJUBLHV> LMRIQDLMHRY;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> QHXPTOTXXLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, WSSEEJUBLHV> VYPCOIVPWSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA2831A0", Offset = "0xA281BA0", VA = "0x18A2831A0")]
		public QXYLOUDGMGP([Optional] IList<WSSEEJUBLHV>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA281260", Offset = "0xA27FC60", VA = "0x18A281260")]
		public WSSEEJUBLHV FFNEXFFUZKW(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface WSZXZDAMJMW
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		QLZEAHTGCGW XEPSYXWUDWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class HHFOSYKAAMP : WSZXZDAMJMW
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static HHFOSYKAAMP BUNZDDCDHSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly OPZRSMRZTSB CZIKAAZFLQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<OPZRSMRZTSB> VZMZPECQPAO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public QLZEAHTGCGW XEPSYXWUDWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA27EBF0", Offset = "0xA27D5F0", VA = "0x18A27EBF0")]
		public HHFOSYKAAMP(OPZRSMRZTSB a, IReadOnlyList<OPZRSMRZTSB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA27DAF0", Offset = "0xA27C4F0", VA = "0x18A27DAF0")]
		private static HHFOSYKAAMP GHUVTGKSBMY()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FSHORPXFJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA27D110", Offset = "0xA27BB10", VA = "0x18A27D110")]
		public static RTOXFLYJUYF SBJQGBSMEBP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class VIYRBGBVKEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> JPFXDVMDLQR;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA284E40", Offset = "0xA283840", VA = "0x18A284E40")]
		public static bool BHJGUMEQZIJ(this KDSOOWCXYNX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA284F20", Offset = "0xA283920", VA = "0x18A284F20")]
		public static bool KYZGVVVMJQS(this KDSOOWCXYNX a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface CEXXDMRDWGT
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> HAFIJILOHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType WMSSAOJKYQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface QLZEAHTGCGW : CEXXDMRDWGT, NIHIHNUPVSD, GBXYRGQQTFG<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string OCSECWAGTNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType LKYURKURAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) EKBPDHHUIRF<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class OPZRSMRZTSB : QLZEAHTGCGW, CEXXDMRDWGT, NIHIHNUPVSD, GBXYRGQQTFG<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly QXYLOUDGMGP QXYLOUDGMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly WUQDJCWNJYE GMSDKXDPDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? UMHTVYMTKCB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool JFMGLWAKIUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA280600", Offset = "0xA27F000", VA = "0x18A280600", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool YCKATAZPDSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA280820", Offset = "0xA27F220", VA = "0x18A280820", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool AMXPMQCAIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA27F770", Offset = "0xA27E170", VA = "0x18A27F770", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool XRIWAXHLGXT
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA27F690", Offset = "0xA27E090", VA = "0x18A27F690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool HQEHDMNMWXH
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA27F540", Offset = "0xA27DF40", VA = "0x18A27F540", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool MSRHTATCYOY
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA27EFB0", Offset = "0xA27D9B0", VA = "0x18A27EFB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool AHXOOOITPTE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA280750", Offset = "0xA27F150", VA = "0x18A280750", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType LKYURKURAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A33D30", Offset = "0x8A32730", VA = "0x188A33D30", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string OCSECWAGTNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A33D30", Offset = "0x8A32730", VA = "0x188A33D30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool UMMLYMBPRDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD70630", Offset = "0xD6F030", VA = "0x180D70630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType WMSSAOJKYQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA280870", Offset = "0xA27F270", VA = "0x18A280870", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> HAFIJILOHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA2808C0", Offset = "0xA27F2C0", VA = "0x18A2808C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool CXRHMJFGPFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA280600", Offset = "0xA27F000", VA = "0x18A280600", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AMIVWRZYEDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA27F540", Offset = "0xA27DF40", VA = "0x18A27F540", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool FJLNVTKOWFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA280820", Offset = "0xA27F220", VA = "0x18A280820", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool SVHGXPJNQWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA27F770", Offset = "0xA27E170", VA = "0x18A27F770", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool RRWKZGYEVBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA27F690", Offset = "0xA27E090", VA = "0x18A27F690", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool QGMWLRILODE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA27EFB0", Offset = "0xA27D9B0", VA = "0x18A27EFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OMSVNVMUSXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA280750", Offset = "0xA27F150", VA = "0x18A280750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> EOINIDBRMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA27F5E0", Offset = "0xA27DFE0", VA = "0x18A27F5E0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA27F3B0", Offset = "0xA27DDB0", VA = "0x18A27F3B0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3D93020", Offset = "0x3D91A20", VA = "0x183D93020", Slot = "6")]
		public (bool, a?) EKBPDHHUIRF<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3D93570", Offset = "0x3D91F70", VA = "0x183D93570")]
		public OPZRSMRZTSB RAVZEGMVHKT<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA280AD0", Offset = "0xA27F4D0", VA = "0x18A280AD0")]
		public OPZRSMRZTSB(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA280B40", Offset = "0xA27F540", VA = "0x18A280B40")]
		public OPZRSMRZTSB(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA280AF0", Offset = "0xA27F4F0", VA = "0x18A280AF0")]
		public OPZRSMRZTSB(OPZRSMRZTSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA2809A0", Offset = "0xA27F3A0", VA = "0x18A2809A0")]
		internal OPZRSMRZTSB(AccountRoleType a, [Optional] string? b, [Optional] OPZRSMRZTSB? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2807A0", Offset = "0xA27F1A0", VA = "0x18A2807A0")]
		public static RolePermissionType RDUCPKMABZH(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA2805E0", Offset = "0xA27EFE0", VA = "0x18A2805E0")]
		public void NERJYRLBXIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA2802F0", Offset = "0xA27ECF0", VA = "0x18A2802F0")]
		internal OPZRSMRZTSB NAMHKDJERPZ(OPZRSMRZTSB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA27F000", Offset = "0xA27DA00", VA = "0x18A27F000")]
		internal IReadOnlyCollection<RolePermission> Copy(OPZRSMRZTSB roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA27F460", Offset = "0xA27DE60", VA = "0x18A27F460")]
		public bool EBPYTGGHXPU(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA280650", Offset = "0xA27F050", VA = "0x18A280650")]
		public (bool, string) PKALKVLHSHZ(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA27F590", Offset = "0xA27DF90", VA = "0x18A27F590")]
		internal void FORIWGHXRNG(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA280120", Offset = "0xA27EB20", VA = "0x18A280120")]
		public OIVAIHOALCY JQEVUKOWYRM(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA27F7C0", Offset = "0xA27E1C0", VA = "0x18A27F7C0")]
		public void JCGVLISLBCO(OIVAIHOALCY a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA27F6E0", Offset = "0xA27E0E0", VA = "0x18A27F6E0")]
		[CompilerGenerated]
		private void GRNXTJTFZYG(RolePermission a, SZVATJHPYQP b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ZZEVTKDLCYG : HFFOVMCGOAG, CISQPIGMQSN, IDisposable, BQDLIVEGPMF
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class BXAAERVMRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public OPZRSMRZTSB PPDFKPZNCVG;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXAAERVMRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA27C8B0", Offset = "0xA27B2B0", VA = "0x18A27C8B0")]
			internal bool KHYSNEFKFHS(OPZRSMRZTSB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class CAKVKJDIRQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType PRBWAWEGQQK;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CAKVKJDIRQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F11B40", Offset = "0x1F10540", VA = "0x181F11B40")]
			internal bool SCGRQXZRHFU(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LXAYWWHORXP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder RKXVQWCBESM;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LXAYWWHORXP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA27EE50", Offset = "0xA27D850", VA = "0x18A27EE50")]
			internal void XKMDXQDEYQT(OIVAIHOALCY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA27ED50", Offset = "0xA27D750", VA = "0x18A27ED50")]
			internal void XKGXAJJHPFK(OIVAIHOALCY a)
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
		private sealed class XYJRNPOMVOR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<OIVAIHOALCY, SZVATJHPYQP> CMMOJZLGJGI;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XYJRNPOMVOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA285B20", Offset = "0xA284520", VA = "0x18A285B20")]
			internal void YPNTGMOYZKY(OIVAIHOALCY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA285B80", Offset = "0xA284580", VA = "0x18A285B80")]
			internal void YQDNYGWRBSZ(OIVAIHOALCY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA285B50", Offset = "0xA284550", VA = "0x18A285B50")]
			internal void YPYHBACTSHQ(OIVAIHOALCY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class WGKYJXFLQGZ<a> where a : notnull
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
				public WGKYJXFLQGZ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x420D5A0", Offset = "0x420BFA0", VA = "0x18420D5A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission MIIXDBHCLHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType UARFOMSXJON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool EKGDSSRYILZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType AVAPRXVLKFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string NJVAJFOJSKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public ZZEVTKDLCYG TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action LWJHMHHZTUY;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WGKYJXFLQGZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8724130", Offset = "0x8722B30", VA = "0x188724130")]
			[AsyncStateMachine(typeof(WGKYJXFLQGZ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void UEBTMDSBQDA()
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
			public TSKYEDQASOH rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, OPZRSMRZTSB> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public VGVBYJSLRZG debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA2834D0", Offset = "0xA281ED0", VA = "0x18A2834D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA283FD0", Offset = "0xA2829D0", VA = "0x18A283FD0", Slot = "5")]
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
			public ZZEVTKDLCYG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA284030", Offset = "0xA282A30", VA = "0x18A284030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA2846A0", Offset = "0xA2830A0", VA = "0x18A2846A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly TSKYEDQASOH BOPFWLJAICS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly HHFOSYKAAMP GNYWFOZSGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly VGVBYJSLRZG XWCKDAZHSDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HIYTDMDLVNY? BFEWSQBVKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> PSZILXBXRIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, OPZRSMRZTSB> TRDXSPFXYOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, OPZRSMRZTSB> SXDDTRYHIGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, OPZRSMRZTSB> NVDUGIDAZTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<OPZRSMRZTSB> TROQRFPMVOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool XTIEQTLGHOG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] ZWHJWCSKTHE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public WSZXZDAMJMW DHWEIWWNJQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated WEPKTEXIXFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA28B2F0", Offset = "0xA289CF0", VA = "0x18A28B2F0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA2860B0", Offset = "0xA284AB0", VA = "0x18A2860B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2866D0", Offset = "0xA2850D0", VA = "0x18A2866D0")]
		[BRMSZAJTATI.Room]
		internal static void BRMSZAJTATI(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA28BB10", Offset = "0xA28A510", VA = "0x18A28BB10")]
		[UnityEngine.Scripting.Preserve]
		internal ZZEVTKDLCYG([Inject(null)] TSKYEDQASOH roleDataProvider, [Inject(null)] HHFOSYKAAMP roleManagerDefaults, [Inject(null)] VGVBYJSLRZG debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA2874F0", Offset = "0xA285EF0", VA = "0x18A2874F0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA28AA60", Offset = "0xA289460", VA = "0x18A28AA60")]
		private void QBAQYSPYCYG(IEnumerable<OPZRSMRZTSB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA28A970", Offset = "0xA289370", VA = "0x18A28A970", Slot = "10")]
		public bool PWROFWMFENZ(KDSOOWCXYNX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA28B390", Offset = "0xA289D90", VA = "0x18A28B390")]
		private void WBYSSOKFAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA28B570", Offset = "0xA289F70", VA = "0x18A28B570", Slot = "19")]
		public void YIOIIFNBIVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA28A170", Offset = "0xA288B70", VA = "0x18A28A170", Slot = "8")]
		public IReadOnlyList<QLZEAHTGCGW> NMGAAEZRZUA(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA289290", Offset = "0xA287C90", VA = "0x18A289290", Slot = "9")]
		public QLZEAHTGCGW JPAWCJRSUXE(KDSOOWCXYNX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2870B0", Offset = "0xA285AB0", VA = "0x18A2870B0")]
		private AccountRoleType CUFAJWUYDZI(KDSOOWCXYNX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA28B4B0", Offset = "0xA289EB0", VA = "0x18A28B4B0", Slot = "12")]
		public bool WWZFNDAGXHG(KDSOOWCXYNX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA288190", Offset = "0xA286B90", VA = "0x18A288190", Slot = "13")]
		public QLZEAHTGCGW GHNOETBFMMN(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2893F0", Offset = "0xA287DF0", VA = "0x18A2893F0")]
		private static bool JQHEXLXUFPE(RTOXFLYJUYF a, AccountRoleType b, [Out] OIVAIHOALCY? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA287880", Offset = "0xA286280", VA = "0x18A287880")]
		private static void EQNFQUYPRZC(RTOXFLYJUYF a, Action<OIVAIHOALCY> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA2875F0", Offset = "0xA285FF0", VA = "0x18A2875F0")]
		private static void EQNFQUYPRZC(RTOXFLYJUYF a, Action<OIVAIHOALCY> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA288230", Offset = "0xA286C30", VA = "0x18A288230")]
		private void HGJQHUOJEEB(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA289E40", Offset = "0xA288840", VA = "0x18A289E40", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task MFHMYIHKCRD([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA286D00", Offset = "0xA285700", VA = "0x18A286D00")]
		private void CEYTZMLTCND(RTOXFLYJUYF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA286150", Offset = "0xA284B50", VA = "0x18A286150")]
		internal static string AKIBTQCRYRF(TSKYEDQASOH a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, OPZRSMRZTSB> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2884F0", Offset = "0xA286EF0", VA = "0x18A2884F0")]
		private static void IPAXPSUKWPZ(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2869C0", Offset = "0xA2853C0", VA = "0x18A2869C0")]
		private static void CAHUNJAWUFG(RTOXFLYJUYF a, IReadOnlyDictionary<AccountRoleType, OPZRSMRZTSB> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA28B3A0", Offset = "0xA289DA0", VA = "0x18A28B3A0")]
		private static bool WFBRCNZUMBB(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA289720", Offset = "0xA288120", VA = "0x18A289720")]
		private static void KQFIYHPSTVO(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x417DD80", Offset = "0x417C780", VA = "0x18417DD80", Slot = "14")]
		public bool IIPJGPYQIOT<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA2882A0", Offset = "0xA286CA0", VA = "0x18A2882A0", Slot = "15")]
		public string HQOWLHFYORT(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA285E90", Offset = "0xA284890", VA = "0x18A285E90", Slot = "16")]
		public bool AFWFXKRGQIR(KDSOOWCXYNX a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA28B760", Offset = "0xA28A160", VA = "0x18A28B760", Slot = "18")]
		public bool YJJFJEBNVJT(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA289F60", Offset = "0xA288960", VA = "0x18A289F60")]
		private void MKYWXDXHHXJ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA28AA40", Offset = "0xA289440", VA = "0x18A28AA40")]
		private bool PlayerHasRole(KDSOOWCXYNX player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA287970", Offset = "0xA286370", VA = "0x18A287970")]
		private OPZRSMRZTSB FGDJXNQDJYB(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA286450", Offset = "0xA284E50", VA = "0x18A286450")]
		internal AccountRoleType AYGNNKZZERZ(KDSOOWCXYNX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA286880", Offset = "0xA285280", VA = "0x18A286880")]
		private void BXJZRKRTRYD(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA287030", Offset = "0xA285A30", VA = "0x18A287030", Slot = "11")]
		public IReadOnlyList<QLZEAHTGCGW> CLRCGMLZTJS(KDSOOWCXYNX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA287030", Offset = "0xA285A30", VA = "0x18A287030")]
		internal IReadOnlyList<OPZRSMRZTSB> OKVFPBPMMJX(KDSOOWCXYNX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA288320", Offset = "0xA286D20", VA = "0x18A288320")]
		internal IReadOnlyList<OPZRSMRZTSB> IOBWIEQLNHL(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA28A1F0", Offset = "0xA288BF0", VA = "0x18A28A1F0")]
		private void OFMVXXYTJMK(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA287EA0", Offset = "0xA2868A0", VA = "0x18A287EA0")]
		private static bool FYUULHBCVNM(OPZRSMRZTSB a, IReadOnlyDictionary<AccountRoleType, OPZRSMRZTSB> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA28B820", Offset = "0xA28A220", VA = "0x18A28B820")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task ZLKWCXBRMFG(TSKYEDQASOH a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, OPZRSMRZTSB> c, VGVBYJSLRZG d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA287C10", Offset = "0xA286610", VA = "0x18A287C10")]
		[CompilerGenerated]
		internal static void FWTMKOKQNMF(Func<OIVAIHOALCY, SZVATJHPYQP> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA287180", Offset = "0xA285B80", VA = "0x18A287180")]
		[CompilerGenerated]
		internal static bool DQLBYSCUJEO(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface XPCZTLXATAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KVBVOIFHMPI(KDSOOWCXYNX a, KDSOOWCXYNX b, IEnumerable<KDSOOWCXYNX> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string ITHPSIQUYRJ(VotekickFailReason a);
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
	internal class EBRPYUZKGVK : XPCZTLXATAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly CISQPIGMQSN RHHAJPFGFRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly VQSPIDBQTAS BXSQBCXHYFW;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		[RecRoom.NoEngine.Common.Preserve]
		public EBRPYUZKGVK([Inject(null)] CISQPIGMQSN roomRoleManager, [Inject(null)] VQSPIDBQTAS gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA27CAE0", Offset = "0xA27B4E0", VA = "0x18A27CAE0")]
		private static PlayerEvent? TFLCOXVSNGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA27C9E0", Offset = "0xA27B3E0", VA = "0x18A27C9E0", Slot = "4")]
		public bool KVBVOIFHMPI(KDSOOWCXYNX a, KDSOOWCXYNX b, IEnumerable<KDSOOWCXYNX> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA27C8E0", Offset = "0xA27B2E0", VA = "0x18A27C8E0", Slot = "5")]
		public string ITHPSIQUYRJ(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA27CB20", Offset = "0xA27B520", VA = "0x18A27CB20")]
		internal bool TUWNNKUOJIX(KDSOOWCXYNX a, KDSOOWCXYNX b, IEnumerable<KDSOOWCXYNX> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
