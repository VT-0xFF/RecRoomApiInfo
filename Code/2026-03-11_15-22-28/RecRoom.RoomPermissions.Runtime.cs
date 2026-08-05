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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D3CFB0", Offset = "0x8D3BFB0", VA = "0x188D3CFB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D47E40", Offset = "0x8D46E40", VA = "0x188D47E40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
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
	public delegate void OnRoomRoleUpdated(OVSEBXDBUJS player);
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
	public interface YITJMIYOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool QWBELVYKNXB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool NYDFJBOSFQP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool CDUENMVXSZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IRBWODRAOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool LDJQOEPJPBT
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool VBUIPTBPDJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool VQSNXZWKQIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class OKBLTOTRLAZ
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
		public static readonly Guid OUIXPOFSNQX;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid HGXETWQBHHK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid VKSXQYBLNJZ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid ZMTYMVALBQH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid QLZIMFUTAOO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid QRPJWVPKCNH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly IPPAYEFIIYY<AccountRoleType, Guid> CPBHQBOUXNG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> HOSYISTIIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D320", Offset = "0x8D3C320", VA = "0x188D3D320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D250", Offset = "0x8D3C250", VA = "0x188D3D250")]
		public static AccountRoleType ERVBJFKWWCW(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D390", Offset = "0x8D3C390", VA = "0x188D3D390")]
		public static Guid VWSZEQMOADU(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D1C0", Offset = "0x8D3C1C0", VA = "0x188D3D1C0")]
		public static bool DEZQJYOSTVB(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D030", Offset = "0x8D3C030", VA = "0x188D3D030")]
		public static bool ALSZDRZRMIP(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D180", Offset = "0x8D3C180", VA = "0x188D3D180")]
		public static AccountRoleType COZRKFFSGQA(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0D0", Offset = "0x8D3C0D0", VA = "0x188D3D0D0")]
		public static DEPRECATED_RoomRoleId ALWTRZQYJZR(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D2E0", Offset = "0x8D3C2E0", VA = "0x188D3D2E0")]
		internal static AccountRoleType FKNPMGNRFGC(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IHIFKUDFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		OVSEBXDBUJS UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance GQKZTMJSGTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO FDSLKJERZXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> KTISNARNABF;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action GLUNHDIYCSF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType GJCYNPPIFTJ(OVSEBXDBUJS a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> FYPBBQIZHSC(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task XNNHXBOYQSE(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task WCLOCKMYJKU(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<OVSEBXDBUJS> SYCKDZLBIJL();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class YQHULCVKYXO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D47350", Offset = "0x8D46350", VA = "0x188D47350")]
		public static AccountRoleType IAJZYHJZCTC(this IHIFKUDFMBA a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface GYLRJJBUYBC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		OYBTUXZVMRR CHEQIRKHYEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated ABOUZGOOKSJ;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<RTWPMQRZUMF> EXVPXWRXQLV(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RTWPMQRZUMF ASSIMVWKXFP(OVSEBXDBUJS a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LISXMHZLQFA(OVSEBXDBUJS a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<RTWPMQRZUMF> AXNPNFDYUET(OVSEBXDBUJS a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KECJQIUFWZB(OVSEBXDBUJS a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RTWPMQRZUMF NVEQNNSECJE(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool RGUJJPCNRSK<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string ZMWKICOMWLQ(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool AEJNZLOASLM(OVSEBXDBUJS a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BJBTISPALRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task HGZCQNASIAY(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NFJTXKYKMRN<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> PXZNLLXPVWY;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? OUBAICOHLQA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? BHMZCJWLXKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D720", Offset = "0x8D3C720", VA = "0x188D3D720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D7F0", Offset = "0x8D3C7F0", VA = "0x188D3D7F0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D8E0", Offset = "0x8D3C8E0", VA = "0x188D3D8E0")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool CTSKFDYACCW(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> CYYNOVFERJC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FNDQYUTZTLK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE0F0", Offset = "0x5DED0F0", VA = "0x185DEE0F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5DED150", Offset = "0x5DEC150", VA = "0x185DED150", Slot = "4")]
		public override bool CTSKFDYACCW(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5DED8D0", Offset = "0x5DEC8D0", VA = "0x185DED8D0")]
		public bool OHQTWIEDHSI(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE400", Offset = "0x5DED400", VA = "0x185DEE400")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class UFNKZAHULIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> YUKFRKNTFKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> OSSMJNSJWLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly BXIOUTOPKYS JHCDMRKIXDY;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D46870", Offset = "0x8D45870", VA = "0x188D46870")]
		public UFNKZAHULIR(BXIOUTOPKYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8D465B0", Offset = "0x8D455B0", VA = "0x188D465B0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3C08A40", Offset = "0x3C07A40", VA = "0x183C08A40")]
		public bool LATHEEXQAZA<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C09200", Offset = "0x3C08200", VA = "0x183C09200")]
		public (bool, a?) XPOZQGOYRNY<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8D464D0", Offset = "0x8D454D0", VA = "0x188D464D0")]
		public bool LATHEEXQAZA(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D466F0", Offset = "0x8D456F0", VA = "0x188D466F0")]
		public (bool, object) XPOZQGOYRNY(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C08960", Offset = "0x3C07960", VA = "0x183C08960")]
		private void FKJBZTZZQYF<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D46620", Offset = "0x8D45620", VA = "0x188D46620")]
		private Permission PJYFZQVEMID(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D462E0", Offset = "0x8D452E0", VA = "0x188D462E0")]
		public void GQYYGUJAQPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class GHOEGBDIJZW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string LYINETZRBNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type YGKAIQRVAMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType YQRMISEVHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission DWEHYIYFMWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet LEVLSPTGHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue NCSLLLQUBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission SPBQURGEFEL;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B1C0", Offset = "0x8D3A1C0", VA = "0x188D3B1C0")]
		public GHOEGBDIJZW(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B170", Offset = "0x8D3A170", VA = "0x188D3B170")]
		public object XIBSRPNPICM(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x374A0D0", Offset = "0x37490D0", VA = "0x18374A0D0")]
		public void FKJBZTZZQYF<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B0C0", Offset = "0x8D3A0C0", VA = "0x188D3B0C0")]
		public void FKJBZTZZQYF(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class SRSPYDVRUBV<a> : GHOEGBDIJZW where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet EQWCECXXYSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue PYSLPYZPNTI;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5A8F060", Offset = "0x5A8E060", VA = "0x185A8F060")]
			internal string AVFLGHWIDEH(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5A8EC70", Offset = "0x5A8DC70", VA = "0x185A8EC70")]
			internal object AVAEJBCKTSY(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60ED6F0", Offset = "0x60EC6F0", VA = "0x1860ED6F0")]
		public SRSPYDVRUBV(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60ECC50", Offset = "0x60EBC50", VA = "0x1860ECC50")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60ED4B0", Offset = "0x60EC4B0", VA = "0x1860ED4B0")]
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
	internal class BXIOUTOPKYS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class ZYWGNXLQYMQ : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static ZYWGNXLQYMQ QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D47A20", Offset = "0x8D46A20", VA = "0x188D47A20", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8D47B70", Offset = "0x8D46B70", VA = "0x188D47B70", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZYWGNXLQYMQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class YWEGUXNJGAC : FGOWNLCBRIP<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8D473B0", Offset = "0x8D463B0", VA = "0x188D473B0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8D474A0", Offset = "0x8D464A0", VA = "0x188D474A0", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8D47650", Offset = "0x8D46650", VA = "0x188D47650")]
			public YWEGUXNJGAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly QCJJCUKSOPD DKYQHRTVBLP;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly YWEGUXNJGAC IOOEAZMQLLI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<GHOEGBDIJZW> NXHCRGCFQOD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> PFPXWVCVJKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, GHOEGBDIJZW> UJIHKIKBSJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AD80", Offset = "0x8D39D80", VA = "0x188D3AD80")]
		public BXIOUTOPKYS([Optional] IList<GHOEGBDIJZW>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8D38E70", Offset = "0x8D37E70", VA = "0x188D38E70")]
		public GHOEGBDIJZW BQTLKTKPVSL(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface OYBTUXZVMRR
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		RTWPMQRZUMF WMKAVORORHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class QVRIIWWSKBS : OYBTUXZVMRR
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static QVRIIWWSKBS ELHGKANUGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly HSYEONFURWA MOWJRLPRJAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<HSYEONFURWA> RWFYDVBTVUX;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RTWPMQRZUMF WMKAVORORHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EAC0", Offset = "0x8D3DAC0", VA = "0x188D3EAC0")]
		public QVRIIWWSKBS(HSYEONFURWA a, IReadOnlyList<HSYEONFURWA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D9D0", Offset = "0x8D3C9D0", VA = "0x188D3D9D0")]
		private static QVRIIWWSKBS JDQSIJAHQFZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class YWJBVUGHCYT
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> DDUNSADYLTU;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D47710", Offset = "0x8D46710", VA = "0x188D47710")]
		public static bool QFKAKBPIAXG(this OVSEBXDBUJS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D47690", Offset = "0x8D46690", VA = "0x188D47690")]
		public static bool PVCMZDQAGGV(this OVSEBXDBUJS a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface JGIBOZLSJRA
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> ZSAIPEYMRGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType HLLQDNPGFYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface RTWPMQRZUMF : JGIBOZLSJRA, YITJMIYOFEC, NFJTXKYKMRN<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string KJGCMKBAWJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType YBYMXGIVPOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) UZECIGYTIQQ<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class HSYEONFURWA : RTWPMQRZUMF, JGIBOZLSJRA, YITJMIYOFEC, NFJTXKYKMRN<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly BXIOUTOPKYS BXIOUTOPKYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly UFNKZAHULIR URPXHGDTVXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? GIMHGFSIJRK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool PTEDCOKPXKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B720", Offset = "0x8D3A720", VA = "0x188D3B720", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool JFJTRXIYVLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BB80", Offset = "0x8D3AB80", VA = "0x188D3BB80", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool DXPQPPAYLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B930", Offset = "0x8D3A930", VA = "0x188D3B930", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool BURMDMFTXYW
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BCD0", Offset = "0x8D3ACD0", VA = "0x188D3BCD0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool SHPDOJCKHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BBD0", Offset = "0x8D3ABD0", VA = "0x188D3BBD0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool KRQZBWSOLOR
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BB30", Offset = "0x8D3AB30", VA = "0x188D3BB30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool TZQZWITJWHH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B2D0", Offset = "0x8D3A2D0", VA = "0x188D3B2D0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType YBYMXGIVPOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAD0090", Offset = "0xACF090", VA = "0x180AD0090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7557A80", Offset = "0x7556A80", VA = "0x187557A80", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string KJGCMKBAWJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7557A80", Offset = "0x7556A80", VA = "0x187557A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IBGZZIXUJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType HLLQDNPGFYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B320", Offset = "0x8D3A320", VA = "0x188D3B320", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> ZSAIPEYMRGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BD20", Offset = "0x8D3AD20", VA = "0x188D3BD20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool YEXYAGKACXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B720", Offset = "0x8D3A720", VA = "0x188D3B720", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool SIROPLZMXDW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BBD0", Offset = "0x8D3ABD0", VA = "0x188D3BBD0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GLBITCPMLCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BB80", Offset = "0x8D3AB80", VA = "0x188D3BB80", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool MLSZNCIPQPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B930", Offset = "0x8D3A930", VA = "0x188D3B930", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool PEIKMFWXIIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BCD0", Offset = "0x8D3ACD0", VA = "0x188D3BCD0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JBJDGZOZVWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BB30", Offset = "0x8D3AB30", VA = "0x188D3BB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool GLXMGKDRZYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B2D0", Offset = "0x8D3A2D0", VA = "0x188D3B2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> PXZNLLXPVWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BC20", Offset = "0x8D3AC20", VA = "0x188D3BC20", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8D3BA30", Offset = "0x8D3AA30", VA = "0x188D3BA30", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3763B90", Offset = "0x3762B90", VA = "0x183763B90", Slot = "6")]
		public (bool, a?) UZECIGYTIQQ<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3763950", Offset = "0x3762950", VA = "0x183763950")]
		public HSYEONFURWA QEWKHZXYYFC<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CDB0", Offset = "0x8D3BDB0", VA = "0x188D3CDB0")]
		public HSYEONFURWA(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CC20", Offset = "0x8D3BC20", VA = "0x188D3CC20")]
		public HSYEONFURWA(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CC40", Offset = "0x8D3BC40", VA = "0x188D3CC40")]
		public HSYEONFURWA(HSYEONFURWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CC90", Offset = "0x8D3BC90", VA = "0x188D3CC90")]
		internal HSYEONFURWA(AccountRoleType a, [Optional] string? b, [Optional] HSYEONFURWA? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B260", Offset = "0x8D3A260", VA = "0x188D3B260")]
		public static RolePermissionType AJRBUAAVLSG(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B980", Offset = "0x8D3A980", VA = "0x188D3B980")]
		public void GQYYGUJAQPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C8C0", Offset = "0x8D3B8C0", VA = "0x188D3C8C0")]
		internal HSYEONFURWA ZYEEEANDMIA(HSYEONFURWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B370", Offset = "0x8D3A370", VA = "0x188D3B370")]
		internal IReadOnlyCollection<RolePermission> Copy(HSYEONFURWA roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BE80", Offset = "0x8D3AE80", VA = "0x188D3BE80")]
		public bool XCMJJABTSNP(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BD80", Offset = "0x8D3AD80", VA = "0x188D3BD80")]
		public (bool, string) RGOENSILDHG(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BAE0", Offset = "0x8D3AAE0", VA = "0x188D3BAE0")]
		internal void KWIANZENQEL(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B770", Offset = "0x8D3A770", VA = "0x188D3B770")]
		public NXDFFQCSUBH GDBUNUSVOIJ(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BF60", Offset = "0x8D3AF60", VA = "0x188D3BF60")]
		public void YSEKIMLSAUR(NXDFFQCSUBH a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B9A0", Offset = "0x8D3A9A0", VA = "0x188D3B9A0")]
		[CompilerGenerated]
		private void JOBOWRTDBYD(RolePermission a, HMRFCSNWOEY b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class TPIEWRZMHTX : BJBTISPALRX, GYLRJJBUYBC, IDisposable, SOERHOUXVDC
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class CDVNMSUAISX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HSYEONFURWA INPPUXVQZOD;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CDVNMSUAISX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8D3B090", Offset = "0x8D3A090", VA = "0x188D3B090")]
			internal bool NQNEAMZGDVT(HSYEONFURWA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class EXLFJINJVOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType CSBVAPKVITJ;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EXLFJINJVOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1C690C0", Offset = "0x1C680C0", VA = "0x181C690C0")]
			internal bool PBNEXXBXXZD(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class MEEVMWIDDFQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder GRHDIHSWTUT;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MEEVMWIDDFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8D3CDD0", Offset = "0x8D3BDD0", VA = "0x188D3CDD0")]
			internal void SXLYRHIZLBI(NXDFFQCSUBH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D3CEB0", Offset = "0x8D3BEB0", VA = "0x188D3CEB0")]
			internal void SXRFOOCWUMR(NXDFFQCSUBH a)
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
		private sealed class ZJKQZDOYDRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<NXDFFQCSUBH, HMRFCSNWOEY> QXPYBTKVJYB;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZJKQZDOYDRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D47990", Offset = "0x8D46990", VA = "0x188D47990")]
			internal void GFPLINNUWCL(NXDFFQCSUBH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D479C0", Offset = "0x8D469C0", VA = "0x188D479C0")]
			internal void GFUSFUHSFNU(NXDFFQCSUBH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D479F0", Offset = "0x8D469F0", VA = "0x188D479F0")]
			internal void GFZZDBBPOZD(NXDFFQCSUBH a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class IMXKUICDQBQ<a> where a : notnull
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
				public IMXKUICDQBQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x3D10F20", Offset = "0x3D0FF20", VA = "0x183D10F20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission HYSGPMNUMKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType ATGWVZBUYNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool CMLFWKVFXMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType QSZKTMSXSXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string VUSNXMZHOLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TPIEWRZMHTX SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action RMXSOAAVFUV;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IMXKUICDQBQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x518B9C0", Offset = "0x518A9C0", VA = "0x18518B9C0")]
			[AsyncStateMachine(typeof(IMXKUICDQBQ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void EIGTWUJSJZT()
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
			public IHIFKUDFMBA rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, HSYEONFURWA> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public WXNDSICNZIB debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8D44970", Offset = "0x8D43970", VA = "0x188D44970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8D45470", Offset = "0x8D44470", VA = "0x188D45470", Slot = "5")]
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
			public TPIEWRZMHTX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8D454D0", Offset = "0x8D444D0", VA = "0x188D454D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8D45B40", Offset = "0x8D44B40", VA = "0x188D45B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly IHIFKUDFMBA QFGKXSDSVXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly QVRIIWWSKBS USCXSETDKTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly WXNDSICNZIB IXCTJZYTKZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private VVDCPZGCRCJ? VSEFOHKXSMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> PRGQXDFEOOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, HSYEONFURWA> YNIXFEYZIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, HSYEONFURWA> GJRWYVUVNRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, HSYEONFURWA> DAAMNPJKOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<HSYEONFURWA> JMUWAIRYSPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool NVPUDRVZOHP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] AWHEGKWUZPD;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OYBTUXZVMRR CHEQIRKHYEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated ABOUZGOOKSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D44150", Offset = "0x8D43150", VA = "0x188D44150", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8D431F0", Offset = "0x8D421F0", VA = "0x188D431F0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D43FA0", Offset = "0x8D42FA0", VA = "0x188D43FA0")]
		[WUCJGMLKEDZ.Room]
		internal static void WUCJGMLKEDZ(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D446C0", Offset = "0x8D436C0", VA = "0x188D446C0")]
		[UnityEngine.Scripting.Preserve]
		internal TPIEWRZMHTX([Inject(null)] IHIFKUDFMBA roleDataProvider, [Inject(null)] QVRIIWWSKBS roleManagerDefaults, [Inject(null)] WXNDSICNZIB debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C10", Offset = "0x8D3FC10", VA = "0x188D40C10", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D41810", Offset = "0x8D40810", VA = "0x188D41810")]
		private void IPDQRQFXINZ(IEnumerable<HSYEONFURWA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D42580", Offset = "0x8D41580", VA = "0x188D42580", Slot = "10")]
		public bool LISXMHZLQFA(OVSEBXDBUJS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D416E0", Offset = "0x8D406E0", VA = "0x188D416E0")]
		private void GLUNHDIYCSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D40D90", Offset = "0x8D3FD90", VA = "0x188D40D90", Slot = "19")]
		public void GCWHYWIIIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D40D10", Offset = "0x8D3FD10", VA = "0x188D40D10", Slot = "8")]
		public IReadOnlyList<RTWPMQRZUMF> EXVPXWRXQLV(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FAB0", Offset = "0x8D3EAB0", VA = "0x188D3FAB0", Slot = "9")]
		public RTWPMQRZUMF ASSIMVWKXFP(OVSEBXDBUJS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D424B0", Offset = "0x8D414B0", VA = "0x188D424B0")]
		private AccountRoleType KUAUVWXQAHZ(OVSEBXDBUJS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D423F0", Offset = "0x8D413F0", VA = "0x188D423F0", Slot = "12")]
		public bool KECJQIUFWZB(OVSEBXDBUJS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D42E30", Offset = "0x8D41E30", VA = "0x188D42E30", Slot = "13")]
		public RTWPMQRZUMF NVEQNNSECJE(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D40690", Offset = "0x8D3F690", VA = "0x188D40690")]
		private static bool CHVEQMINYXN(RZOYUQCIPUQ a, AccountRoleType b, [Out] NXDFFQCSUBH? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D42070", Offset = "0x8D41070", VA = "0x188D42070")]
		private static void JZCXSUBJABV(RZOYUQCIPUQ a, Action<NXDFFQCSUBH> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D42160", Offset = "0x8D41160", VA = "0x188D42160")]
		private static void JZCXSUBJABV(RZOYUQCIPUQ a, Action<NXDFFQCSUBH> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D436F0", Offset = "0x8D426F0", VA = "0x188D436F0")]
		private void SBYDWOQTOTM(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D416F0", Offset = "0x8D406F0", VA = "0x188D416F0", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task HGZCQNASIAY([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D42650", Offset = "0x8D41650", VA = "0x188D42650")]
		private void LLRJPANRNFM(RZOYUQCIPUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D42EF0", Offset = "0x8D41EF0", VA = "0x188D42EF0")]
		internal static string QBBMKOBNFTU(IHIFKUDFMBA a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, HSYEONFURWA> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EBC0", Offset = "0x8D3DBC0", VA = "0x188D3EBC0")]
		private static void ACNIKFWXVHW(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D43C60", Offset = "0x8D42C60", VA = "0x188D43C60")]
		private static void UXSRZRPCTPF(RZOYUQCIPUQ a, IReadOnlyDictionary<AccountRoleType, HSYEONFURWA> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D40B00", Offset = "0x8D3FB00", VA = "0x188D40B00")]
		private static bool DRBGGUSATCW(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FF70", Offset = "0x8D3EF70", VA = "0x188D3FF70")]
		private static void BRMWFRBIUFF(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFF90", Offset = "0x3AFEF90", VA = "0x183AFFF90", Slot = "14")]
		public bool RGUJJPCNRSK<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D444B0", Offset = "0x8D434B0", VA = "0x188D444B0", Slot = "15")]
		public string ZMWKICOMWLQ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F8A0", Offset = "0x8D3E8A0", VA = "0x188D3F8A0", Slot = "16")]
		public bool AEJNZLOASLM(OVSEBXDBUJS a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D443F0", Offset = "0x8D433F0", VA = "0x188D443F0", Slot = "18")]
		public bool YERNZAJCMEG(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D441F0", Offset = "0x8D431F0", VA = "0x188D441F0")]
		private void XZIQGLCVTII(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D42ED0", Offset = "0x8D41ED0", VA = "0x188D42ED0")]
		private bool PlayerHasRole(OVSEBXDBUJS player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D43460", Offset = "0x8D42460", VA = "0x188D43460")]
		private HSYEONFURWA RQZCACTSWPA(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D43760", Offset = "0x8D42760", VA = "0x188D43760")]
		internal AccountRoleType SXDNQXZKARE(OVSEBXDBUJS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D409C0", Offset = "0x8D3F9C0", VA = "0x188D409C0")]
		private void DFOGGCIDQIQ(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC10", Offset = "0x8D3EC10", VA = "0x188D3FC10", Slot = "11")]
		public IReadOnlyList<RTWPMQRZUMF> AXNPNFDYUET(OVSEBXDBUJS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC10", Offset = "0x8D3EC10", VA = "0x188D3FC10")]
		internal IReadOnlyList<HSYEONFURWA> ZIBVHXMCJDI(OVSEBXDBUJS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D43290", Offset = "0x8D42290", VA = "0x188D43290")]
		internal IReadOnlyList<HSYEONFURWA> RIMEUCBYGEU(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D40F70", Offset = "0x8D3FF70", VA = "0x188D40F70")]
		private void GLLBQHOBGJZ(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC90", Offset = "0x8D3EC90", VA = "0x188D3FC90")]
		private static bool BEVVRHJNNXH(HSYEONFURWA a, IReadOnlyDictionary<AccountRoleType, HSYEONFURWA> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D42CF0", Offset = "0x8D41CF0", VA = "0x188D42CF0")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task MGTSKVSQAYR(IHIFKUDFMBA a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, HSYEONFURWA> c, WXNDSICNZIB d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D439E0", Offset = "0x8D429E0", VA = "0x188D439E0")]
		[CompilerGenerated]
		internal static void URKSXJFEYKS(Func<NXDFFQCSUBH, HMRFCSNWOEY> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D42980", Offset = "0x8D41980", VA = "0x188D42980")]
		[CompilerGenerated]
		internal static bool MDWHXUPGTQV(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface ALOEFQCMITK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QOFKJCOCSYZ(OVSEBXDBUJS a, OVSEBXDBUJS b, IEnumerable<OVSEBXDBUJS> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string MJIHLJBAEXI(VotekickFailReason a);
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
	internal class XBXIXDWQWCZ : ALOEFQCMITK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GYLRJJBUYBC DJHHYDOCGCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly NSINVZPOBCP SGCKAFNOFUV;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		[RecRoom.NoEngine.Common.Preserve]
		public XBXIXDWQWCZ([Inject(null)] GYLRJJBUYBC roomRoleManager, [Inject(null)] NSINVZPOBCP gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8D47310", Offset = "0x8D46310", VA = "0x188D47310")]
		private static PlayerEvent? RLITARDWIKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8D47210", Offset = "0x8D46210", VA = "0x188D47210", Slot = "4")]
		public bool QOFKJCOCSYZ(OVSEBXDBUJS a, OVSEBXDBUJS b, IEnumerable<OVSEBXDBUJS> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8D47110", Offset = "0x8D46110", VA = "0x188D47110", Slot = "5")]
		public string MJIHLJBAEXI(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8D46B10", Offset = "0x8D45B10", VA = "0x188D46B10")]
		internal bool LCOMNRGCUXO(OVSEBXDBUJS a, OVSEBXDBUJS b, IEnumerable<OVSEBXDBUJS> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
