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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xA26F5B0", Offset = "0xA26E5B0", VA = "0x18A26F5B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2784F0", Offset = "0xA2774F0", VA = "0x18A2784F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
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
	public delegate void OnRoomRoleUpdated(QCTMRFTYWMB player);
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
	public interface OEHIOOAOIUL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool NXYEAHSRWUU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool SIVKMKAWWQC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool HPXCRANUREQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool RNPLTACITHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool JAQBBJSZFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool RYVKYFMQWTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool LFXSHONNANK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class RPGZWQNSINI
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
		public static readonly Guid STYTAAEOSPY;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid PCIZSZYWIGH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid HJVINVQITCI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid JUVOQUHMCVS;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid ZELPEXDIWDZ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid AEBOQTFDDHE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly OMBBVYGPDKX<AccountRoleType, Guid> NNDYQTSGTJZ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> UOIBCSTIBTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA271610", Offset = "0xA270610", VA = "0x18A271610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA271770", Offset = "0xA270770", VA = "0x18A271770")]
		public static AccountRoleType TETRGGOXRGR(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA2718B0", Offset = "0xA2708B0", VA = "0x18A2718B0")]
		public static Guid VPKLMSNHABX(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA271580", Offset = "0xA270580", VA = "0x18A271580")]
		public static bool DWXADQRVYJQ(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2716D0", Offset = "0xA2706D0", VA = "0x18A2716D0")]
		public static bool QPRRGKIXUWO(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA271540", Offset = "0xA270540", VA = "0x18A271540")]
		public static AccountRoleType ADNOQHLLLSN(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA271800", Offset = "0xA270800", VA = "0x18A271800")]
		public static DEPRECATED_RoomRoleId VNPOWDPFXOE(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA271690", Offset = "0xA270690", VA = "0x18A271690")]
		internal static AccountRoleType NMZDQLONNBF(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IASBTZSKWNB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance XHBJHTAAICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO LYDYEKJHUMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> NNKRIQIZGKK;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action KWUYLANYOBG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType ZZVUVXWZPJY(QCTMRFTYWMB a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> DPNSDVQXYPZ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task UAILVHQRSGT(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task JNJPJWGRGOB(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<QCTMRFTYWMB> ZNPSSWRWSSE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class XPQFZBHDUBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA2767C0", Offset = "0xA2757C0", VA = "0x18A2767C0")]
		public static AccountRoleType AJLLUSHFHFV(this IASBTZSKWNB a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface SJUXGADTLKJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		WYKTUXCMSMS MBVQBQKEDFS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated YHWHSRAUSZS;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<OYFHCPQSFJM> XCUCFYRDBEQ(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OYFHCPQSFJM XHOYGWPJPKS(QCTMRFTYWMB a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ETPGNZILYQL(QCTMRFTYWMB a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<OYFHCPQSFJM> PUSKHOQILKQ(QCTMRFTYWMB a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PXJZBDBXXXO(QCTMRFTYWMB a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		OYFHCPQSFJM YPUFAYIVMKR(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NOQUHGSLOKL<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string RHMEIOGZDSN(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool BCTPRMMXJXP(QCTMRFTYWMB a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface EYZZFDQGSSC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task OLRFPTXGQQF(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GBXBEEHKNAA<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> MQOVLPRUDPB;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? SZYJJYRUDMV;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? CHOCQHOWTJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA26F630", Offset = "0xA26E630", VA = "0x18A26F630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA26F700", Offset = "0xA26E700", VA = "0x18A26F700")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA26F800", Offset = "0xA26E800", VA = "0x18A26F800")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool GJEXCVGSWDB(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> QYWPGCXOWON;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T WZVCBEIJRSP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x756EAC0", Offset = "0x756DAC0", VA = "0x18756EAC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x756E450", Offset = "0x756D450", VA = "0x18756E450", Slot = "4")]
		public override bool GJEXCVGSWDB(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x756EFF0", Offset = "0x756DFF0", VA = "0x18756EFF0")]
		public bool KOVIVEIXATB(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x756F690", Offset = "0x756E690", VA = "0x18756F690")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ZUGLLFXBMPS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> HPDXOKDLOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> AKYHIQDAYJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly SVTAJBXBVQP FWUKCWQNSNZ;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA278260", Offset = "0xA277260", VA = "0x18A278260")]
		public ZUGLLFXBMPS(SVTAJBXBVQP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA277EB0", Offset = "0xA276EB0", VA = "0x18A277EB0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41246F0", Offset = "0x41236F0", VA = "0x1841246F0")]
		public bool PEMXCQUMSTD<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4124EB0", Offset = "0x4123EB0", VA = "0x184124EB0")]
		public (bool, a?) TKUMCFAEYHH<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA277F20", Offset = "0xA276F20", VA = "0x18A277F20")]
		public bool PEMXCQUMSTD(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA2780D0", Offset = "0xA2770D0", VA = "0x18A2780D0")]
		public (bool, object) TKUMCFAEYHH(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4124610", Offset = "0x4123610", VA = "0x184124610")]
		private void JDXAEDODMIO<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA278000", Offset = "0xA277000", VA = "0x18A278000")]
		private Permission SFHUNVNHVDG(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA277CD0", Offset = "0xA276CD0", VA = "0x18A277CD0")]
		public void GTVVYWSDFBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class BXGQLRBBQGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string JNNLUASEFCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type SYHWQZYWCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType DLMLEHZYXDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission MVNHYFDERSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet UQTUEMKYRWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue RENHJTGPKGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission LXYCEZXIYOM;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA269160", Offset = "0xA268160", VA = "0x18A269160")]
		public BXGQLRBBQGL(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA269060", Offset = "0xA268060", VA = "0x18A269060")]
		public object AGITDAIJPUV(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x372E500", Offset = "0x372D500", VA = "0x18372E500")]
		public void JDXAEDODMIO<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA2690B0", Offset = "0xA2680B0", VA = "0x18A2690B0")]
		public void JDXAEDODMIO(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ZJESSNULTWU<a> : BXGQLRBBQGL where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet QGEMIFHWPFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue QSDIDQIFRQF;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6970100", Offset = "0x696F100", VA = "0x186970100")]
			internal string HJGUBTNFJMI(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6970470", Offset = "0x696F470", VA = "0x186970470")]
			internal object HJMAZAHCSXR(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x513B870", Offset = "0x513A870", VA = "0x18513B870")]
		public ZJESSNULTWU(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x513A560", Offset = "0x5139560", VA = "0x18513A560")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x513AA40", Offset = "0x5139A40", VA = "0x18513AA40")]
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
	internal class SVTAJBXBVQP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class WGLDCRDZKBL : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static WGLDCRDZKBL CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA2760B0", Offset = "0xA2750B0", VA = "0x18A2760B0", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA276200", Offset = "0xA275200", VA = "0x18A276200", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WGLDCRDZKBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class WPFGEQBBKGP : JAIVNHEPHYK<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA2764E0", Offset = "0xA2754E0", VA = "0x18A2764E0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA2765D0", Offset = "0xA2755D0", VA = "0x18A2765D0", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA276780", Offset = "0xA275780", VA = "0x18A276780")]
			public WPFGEQBBKGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly WUUEZHOGXTS GKBEAIWJNME;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly WPFGEQBBKGP GDZZLWMHTST;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<BXGQLRBBQGL> JEEBRHUPTJQ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> ZVQVFGCHTYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, BXGQLRBBQGL> ENWLIKVWTKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA273BB0", Offset = "0xA272BB0", VA = "0x18A273BB0")]
		public SVTAJBXBVQP([Optional] IList<BXGQLRBBQGL>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA271C70", Offset = "0xA270C70", VA = "0x18A271C70")]
		public BXGQLRBBQGL DDZUCFRIDLU(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface WYKTUXCMSMS
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		OYFHCPQSFJM IDDDVXGZUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class ZHXQPQWCJUL : WYKTUXCMSMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static ZHXQPQWCJUL SADIZTGPJFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly RHBUJHNDRCZ MMTFYUENEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<RHBUJHNDRCZ> DTGVUQRIREO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public OYFHCPQSFJM IDDDVXGZUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA277BD0", Offset = "0xA276BD0", VA = "0x18A277BD0")]
		public ZHXQPQWCJUL(RHBUJHNDRCZ a, IReadOnlyList<RHBUJHNDRCZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA276AD0", Offset = "0xA275AD0", VA = "0x18A276AD0")]
		private static ZHXQPQWCJUL HVJXOEDIKEE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class YVFIGMCFBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA276820", Offset = "0xA275820", VA = "0x18A276820")]
		public static ZRBMARSLXCF CDUVEVRPJBT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EEFQNNTWUWK
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> KNLHXIRNHZX;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA269280", Offset = "0xA268280", VA = "0x18A269280")]
		public static bool HUNLLYWHXUB(this QCTMRFTYWMB a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA269200", Offset = "0xA268200", VA = "0x18A269200")]
		public static bool EKDGOJBWAPA(this QCTMRFTYWMB a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface MOSKYPASMKL
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> DEKWYLMCFXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType VSGQLWVSABZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface OYFHCPQSFJM : MOSKYPASMKL, OEHIOOAOIUL, GBXBEEHKNAA<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string TQJSQYOXAFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType VVIWDIGMBUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) FYHTGIWPCJF<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class RHBUJHNDRCZ : OYFHCPQSFJM, MOSKYPASMKL, OEHIOOAOIUL, GBXBEEHKNAA<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly SVTAJBXBVQP SVTAJBXBVQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly ZUGLLFXBMPS HYOQMPEJNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? KWJBQNVFIZT;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool LYAWOEGPYHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA26F990", Offset = "0xA26E990", VA = "0x18A26F990", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool MJCDXABGOAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA2705D0", Offset = "0xA26F5D0", VA = "0x18A2705D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool GHOWLGAUVFY
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA2703D0", Offset = "0xA26F3D0", VA = "0x18A2703D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool PPWDKLBHZBD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA2701B0", Offset = "0xA26F1B0", VA = "0x18A2701B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool XHITOFSUZXL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA270160", Offset = "0xA26F160", VA = "0x18A270160", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool UACFDCYZIYM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA270520", Offset = "0xA26F520", VA = "0x18A270520", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool MHGHHDFILSW
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA270420", Offset = "0xA26F420", VA = "0x18A270420", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType VVIWDIGMBUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCFDEE0", Offset = "0xCFCEE0", VA = "0x180CFDEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A215E0", Offset = "0x8A205E0", VA = "0x188A215E0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string TQJSQYOXAFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A215E0", Offset = "0x8A205E0", VA = "0x188A215E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool KIVEGFWQKXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD4F620", Offset = "0xD4E620", VA = "0x180D4F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType VSGQLWVSABZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA270110", Offset = "0xA26F110", VA = "0x18A270110", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> DEKWYLMCFXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA270570", Offset = "0xA26F570", VA = "0x18A270570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OJZUVYQSJWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA26F990", Offset = "0xA26E990", VA = "0x18A26F990", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool FROWNFWORYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA270160", Offset = "0xA26F160", VA = "0x18A270160", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IRUNEFRICHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA2705D0", Offset = "0xA26F5D0", VA = "0x18A2705D0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool SLEIIFXWUIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA2703D0", Offset = "0xA26F3D0", VA = "0x18A2703D0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool XYWQGOUOHJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA2701B0", Offset = "0xA26F1B0", VA = "0x18A2701B0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool TRTXLLUMISO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA270520", Offset = "0xA26F520", VA = "0x18A270520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UDQMKIDERCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA270420", Offset = "0xA26F420", VA = "0x18A270420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> MQOVLPRUDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA270470", Offset = "0xA26F470", VA = "0x18A270470", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA270300", Offset = "0xA26F300", VA = "0x18A270300", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3E19380", Offset = "0x3E18380", VA = "0x183E19380", Slot = "6")]
		public (bool, a?) FYHTGIWPCJF<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3E19850", Offset = "0x3E18850", VA = "0x183E19850")]
		public RHBUJHNDRCZ IUTMBCXLNWD<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA271520", Offset = "0xA270520", VA = "0x18A271520")]
		public RHBUJHNDRCZ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA271500", Offset = "0xA270500", VA = "0x18A271500")]
		public RHBUJHNDRCZ(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA2714B0", Offset = "0xA2704B0", VA = "0x18A2714B0")]
		public RHBUJHNDRCZ(RHBUJHNDRCZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA271380", Offset = "0xA270380", VA = "0x18A271380")]
		internal RHBUJHNDRCZ(AccountRoleType a, [Optional] string? b, [Optional] RHBUJHNDRCZ? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2707F0", Offset = "0xA26F7F0", VA = "0x18A2707F0")]
		public static RolePermissionType QYBTVQSIWUV(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA2703B0", Offset = "0xA26F3B0", VA = "0x18A2703B0")]
		public void GTVVYWSDFBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA26F9E0", Offset = "0xA26E9E0", VA = "0x18A26F9E0")]
		internal RHBUJHNDRCZ AEFWIUARJWL(RHBUJHNDRCZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA26FD60", Offset = "0xA26ED60", VA = "0x18A26FD60")]
		internal IReadOnlyCollection<RolePermission> Copy(RHBUJHNDRCZ roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA271220", Offset = "0xA270220", VA = "0x18A271220")]
		public bool ZBSRDFYWIRE(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA270200", Offset = "0xA26F200", VA = "0x18A270200")]
		public (bool, string) FLLBHPETHUD(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA270870", Offset = "0xA26F870", VA = "0x18A270870")]
		internal void WAMHELAEZDS(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA270620", Offset = "0xA26F620", VA = "0x18A270620")]
		public JOAFFMPAQWM OYVJFFPQBVA(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2708C0", Offset = "0xA26F8C0", VA = "0x18A2708C0")]
		public void YCZWDKRZUNE(JOAFFMPAQWM a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA26FCD0", Offset = "0xA26ECD0", VA = "0x18A26FCD0")]
		[CompilerGenerated]
		private void CRJKCEBHFFU(RolePermission a, NPSALNPWJFR b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class FKLHVFVBAEG : EYZZFDQGSSC, SJUXGADTLKJ, IDisposable, TBJSVUWVJKZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class UUTSZHQDVWE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public RHBUJHNDRCZ FLSIDFOGLZC;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UUTSZHQDVWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA276080", Offset = "0xA275080", VA = "0x18A276080")]
			internal bool ISNCMVMPVMY(RHBUJHNDRCZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class LXFDTAXQBQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType OOZZXSLCBPQ;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LXFDTAXQBQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EF83C0", Offset = "0x1EF73C0", VA = "0x181EF83C0")]
			internal bool AVNEXXTMKTE(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class MKRBZEZPJBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder VZQTPGKVLQE;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public MKRBZEZPJBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA26F4D0", Offset = "0xA26E4D0", VA = "0x18A26F4D0")]
			internal void AJIRUTOXYKH(JOAFFMPAQWM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA26F3D0", Offset = "0xA26E3D0", VA = "0x18A26F3D0")]
			internal void AJDKXMVAOYY(JOAFFMPAQWM a)
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
		private sealed class REIFCQLAYLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<JOAFFMPAQWM, NPSALNPWJFR> YXSQOPCRDQU;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public REIFCQLAYLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA26F900", Offset = "0xA26E900", VA = "0x18A26F900")]
			internal void DNJQWYVCBGA(JOAFFMPAQWM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA26F960", Offset = "0xA26E960", VA = "0x18A26F960")]
			internal void DNZLOTCUDOB(JOAFFMPAQWM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA26F930", Offset = "0xA26E930", VA = "0x18A26F930")]
			internal void DNUERMIWUCS(JOAFFMPAQWM a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class QMPAUMOWZBP<a> where a : notnull
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
				public QMPAUMOWZBP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x41BD970", Offset = "0x41BC970", VA = "0x1841BD970", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission TPURDIYKLOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType XRJYDULQJIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool POZCFLXIYXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType ICQEEFPTVJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string KUPAHXAYFRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public FKLHVFVBAEG NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action CIKKUPFVKYU;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QMPAUMOWZBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x778C300", Offset = "0x778B300", VA = "0x18778C300")]
			[AsyncStateMachine(typeof(QMPAUMOWZBP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void PCKFRBDBXIS()
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
			public IASBTZSKWNB rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, RHBUJHNDRCZ> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TUCWBQMUOGY debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA273EE0", Offset = "0xA272EE0", VA = "0x18A273EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA2749E0", Offset = "0xA2739E0", VA = "0x18A2749E0", Slot = "5")]
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
			public FKLHVFVBAEG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA274A40", Offset = "0xA273A40", VA = "0x18A274A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA2750B0", Offset = "0xA2740B0", VA = "0x18A2750B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly IASBTZSKWNB WVIZGXUMPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly ZHXQPQWCJUL BWFTMLBWKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly TUCWBQMUOGY FTOEQKCILFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PEZZOGSLIBU? PYGBFQTSDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> IFBJNQUEFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, RHBUJHNDRCZ> TTKUNRVWOZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, RHBUJHNDRCZ> EOICSQSLMVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, RHBUJHNDRCZ> TBDNGZOTMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<RHBUJHNDRCZ> PFMTGYIUTJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool LHXHPZAEEWC;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] UCVVCXAFKLI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public WYKTUXCMSMS MBVQBQKEDFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated YHWHSRAUSZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA26B960", Offset = "0xA26A960", VA = "0x18A26B960", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA26BC10", Offset = "0xA26AC10", VA = "0x18A26BC10", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA26A450", Offset = "0xA269450", VA = "0x18A26A450")]
		[GQJUYEPYYUG.Room]
		internal static void GQJUYEPYYUG(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA26F120", Offset = "0xA26E120", VA = "0x18A26F120")]
		[UnityEngine.Scripting.Preserve]
		internal FKLHVFVBAEG([Inject(null)] IASBTZSKWNB roleDataProvider, [Inject(null)] ZHXQPQWCJUL roleManagerDefaults, [Inject(null)] TUCWBQMUOGY debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA269F00", Offset = "0xA268F00", VA = "0x18A269F00", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA26C730", Offset = "0xA26B730", VA = "0x18A26C730")]
		private void OPZFSTWJTCG(IEnumerable<RHBUJHNDRCZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA26A380", Offset = "0xA269380", VA = "0x18A26A380", Slot = "10")]
		public bool ETPGNZILYQL(QCTMRFTYWMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA26BA00", Offset = "0xA26AA00", VA = "0x18A26BA00")]
		private void KWUYLANYOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA26C2F0", Offset = "0xA26B2F0", VA = "0x18A26C2F0", Slot = "19")]
		public void NQZXMQAQZWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA26EB20", Offset = "0xA26DB20", VA = "0x18A26EB20", Slot = "8")]
		public IReadOnlyList<OYFHCPQSFJM> XCUCFYRDBEQ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA26EBA0", Offset = "0xA26DBA0", VA = "0x18A26EBA0", Slot = "9")]
		public OYFHCPQSFJM XHOYGWPJPKS(QCTMRFTYWMB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA269500", Offset = "0xA268500", VA = "0x18A269500")]
		private AccountRoleType ARZRFOXWVFI(QCTMRFTYWMB a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA26D7A0", Offset = "0xA26C7A0", VA = "0x18A26D7A0", Slot = "12")]
		public bool PXJZBDBXXXO(QCTMRFTYWMB a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA26EED0", Offset = "0xA26DED0", VA = "0x18A26EED0", Slot = "13")]
		public OYFHCPQSFJM YPUFAYIVMKR(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA26E7F0", Offset = "0xA26D7F0", VA = "0x18A26E7F0")]
		private static bool VGLOCWXDJLE(ZRBMARSLXCF a, AccountRoleType b, [Out] JOAFFMPAQWM? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA26A290", Offset = "0xA269290", VA = "0x18A26A290")]
		private static void EJJLOCTHDGY(ZRBMARSLXCF a, Action<JOAFFMPAQWM> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA26A000", Offset = "0xA269000", VA = "0x18A26A000")]
		private static void EJJLOCTHDGY(ZRBMARSLXCF a, Action<JOAFFMPAQWM> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA26E780", Offset = "0xA26D780", VA = "0x18A26E780")]
		private void UZPMJBACVHH(QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA26C610", Offset = "0xA26B610", VA = "0x18A26C610", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task OLRFPTXGQQF([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA26A890", Offset = "0xA269890", VA = "0x18A26A890")]
		private void JDHUOGMVLAR(ZRBMARSLXCF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA26BCB0", Offset = "0xA26ACB0", VA = "0x18A26BCB0")]
		internal static string MQEFJHTXDJJ(IASBTZSKWNB a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, RHBUJHNDRCZ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA26ABC0", Offset = "0xA269BC0", VA = "0x18A26ABC0")]
		private static void JEUVPRDFYOD(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA26BFB0", Offset = "0xA26AFB0", VA = "0x18A26BFB0")]
		private static void NIBSMPTBYEI(ZRBMARSLXCF a, IReadOnlyDictionary<AccountRoleType, RHBUJHNDRCZ> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA26E670", Offset = "0xA26D670", VA = "0x18A26E670")]
		private static bool UHGNVMQUXGD(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA26D880", Offset = "0xA26C880", VA = "0x18A26D880")]
		private static void QOOHTHKWSBK(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AC03C0", Offset = "0x3ABF3C0", VA = "0x183AC03C0", Slot = "14")]
		public bool NOQUHGSLOKL<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA26DFA0", Offset = "0xA26CFA0", VA = "0x18A26DFA0", Slot = "15")]
		public string RHMEIOGZDSN(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA2695D0", Offset = "0xA2685D0", VA = "0x18A2695D0", Slot = "16")]
		public bool BCTPRMMXJXP(QCTMRFTYWMB a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA269E40", Offset = "0xA268E40", VA = "0x18A269E40", Slot = "18")]
		public bool DTKFVQKSUNX(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA26BA10", Offset = "0xA26AA10", VA = "0x18A26BA10")]
		private void LCZCKQNWZGD(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA26D860", Offset = "0xA26C860", VA = "0x18A26D860")]
		private bool PlayerHasRole(QCTMRFTYWMB player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA26A600", Offset = "0xA269600", VA = "0x18A26A600")]
		private RHBUJHNDRCZ HMKZTAPCBYZ(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA26E3F0", Offset = "0xA26D3F0", VA = "0x18A26E3F0")]
		internal AccountRoleType TZKDMHLZZEX(QCTMRFTYWMB a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA26E2B0", Offset = "0xA26D2B0", VA = "0x18A26E2B0")]
		private void SVAYDEEBKEH(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA26D720", Offset = "0xA26C720", VA = "0x18A26D720", Slot = "11")]
		public IReadOnlyList<OYFHCPQSFJM> PUSKHOQILKQ(QCTMRFTYWMB a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA26D720", Offset = "0xA26C720", VA = "0x18A26D720")]
		internal IReadOnlyList<RHBUJHNDRCZ> XELGFCFILGJ(QCTMRFTYWMB a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA26ED00", Offset = "0xA26DD00", VA = "0x18A26ED00")]
		internal IReadOnlyList<RHBUJHNDRCZ> XZORGZAKTZH(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA26CFA0", Offset = "0xA26BFA0", VA = "0x18A26CFA0")]
		private void PMGNHPSTGQO(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA269B50", Offset = "0xA268B50", VA = "0x18A269B50")]
		private static bool DGHPDVWZXDA(RHBUJHNDRCZ a, IReadOnlyDictionary<AccountRoleType, RHBUJHNDRCZ> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA26C4D0", Offset = "0xA26B4D0", VA = "0x18A26C4D0")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task NVOEAXWXBEM(IASBTZSKWNB a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, RHBUJHNDRCZ> c, TUCWBQMUOGY d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA26E020", Offset = "0xA26D020", VA = "0x18A26E020")]
		[CompilerGenerated]
		internal static void SADGYTGROQR(Func<JOAFFMPAQWM, NPSALNPWJFR> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2697E0", Offset = "0xA2687E0", VA = "0x18A2697E0")]
		[CompilerGenerated]
		internal static bool CXYSNIMYKJI(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface YIIYEAEPRXZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PXWTPUGGPIK(QCTMRFTYWMB a, QCTMRFTYWMB b, IEnumerable<QCTMRFTYWMB> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GQAYRSDJFSD(VotekickFailReason a);
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
	internal class UFVSLFMNMLO : YIIYEAEPRXZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SJUXGADTLKJ KIZNDHYRAGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly SMTSCQMYOKS IDDGCDCNRLW;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public UFVSLFMNMLO([Inject(null)] SJUXGADTLKJ roomRoleManager, [Inject(null)] SMTSCQMYOKS gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA275A50", Offset = "0xA274A50", VA = "0x18A275A50")]
		private static PlayerEvent? SYJEGLTWJUH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA275950", Offset = "0xA274950", VA = "0x18A275950", Slot = "4")]
		public bool PXWTPUGGPIK(QCTMRFTYWMB a, QCTMRFTYWMB b, IEnumerable<QCTMRFTYWMB> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA275850", Offset = "0xA274850", VA = "0x18A275850", Slot = "5")]
		public string GQAYRSDJFSD(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA275A90", Offset = "0xA274A90", VA = "0x18A275A90")]
		internal bool VULHPXQJMYT(QCTMRFTYWMB a, QCTMRFTYWMB b, IEnumerable<QCTMRFTYWMB> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
