using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.Common;
using UJect.Injection;
using Unity.Netcode;
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
		[Cpp2IlInjected.Address(RVA = "0x993F4F0", Offset = "0x993E2F0", VA = "0x18993F4F0")]
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
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x993F430", Offset = "0x993E230", VA = "0x18993F430", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ISYPUZZLNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object HKULEBLRJUR(YWDQBEIJOEE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RWCUJOOLKDY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		WABBHQTINSC SBKQLLCVCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task EKXRFZTFJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Disconnect([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<WABBHQTINSC> QBDEUCYUOYM(WABBHQTINSC a, object b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task CCECSFRFXJR([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VKMGEYSOSCK(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface ERCNSIQRTVN
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DYNHRMPGIXT QDBPTYDEQPX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string KXVOIELCUSI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string GRWZMJHKIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> EFJCGNGZDVL(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class HREMTTGMFJG
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ITOQTWBEUPV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> UQKVQPZKLZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public CDPRAJEFKDH OEIUHSTSSRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public MZPAUNRNKBF LMVVDSZGPPF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ITOQTWBEUPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x658B340", Offset = "0x658A140", VA = "0x18658B340")]
			internal void WENYIWCBNQL(DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x658AB30", Offset = "0x6589930", VA = "0x18658AB30")]
			internal void MIZMDAGMUIO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x658AC60", Offset = "0x6589A60", VA = "0x18658AC60")]
			internal void NKGNHAVJMOD(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ZAGAZIDTYHU<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TaskCompletionSource<a> UQKVQPZKLZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public MZPAUNRNKBF LMVVDSZGPPF;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZAGAZIDTYHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x50FA690", Offset = "0x50F9490", VA = "0x1850FA690")]
			internal void FCGCEPAKAWF(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x50FAD40", Offset = "0x50F9B40", VA = "0x1850FAD40")]
			internal void PKJLQOAJIXQ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x50FAB20", Offset = "0x50F9920", VA = "0x1850FAB20")]
			internal void JGVYVWLICVI(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Log ALDXGIVBEKZ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2600", Offset = "0x3AD1400", VA = "0x183AD2600")]
		public static void UOTXMMKBPIT<a>(this MZPAUNRNKBF a, TaskCompletionSource<a> b, [NotNull] CDPRAJEFKDH networkClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2B70", Offset = "0x3AD1970", VA = "0x183AD2B70")]
		public static void ZOWEUWAYPKM<b>(this MZPAUNRNKBF a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface XDTFMJDORLB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task DisconnectHandler(DisconnectCause disconnectCause);
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct VoidType : IEquatable<VoidType>
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly VoidType Default;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9945060", Offset = "0x9943E60", VA = "0x189945060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x993F570", Offset = "0x993E370", VA = "0x18993F570")]
		public PhotonClientException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PhotonFailedToConnectToRegionException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class PhotonFailedToConnectToRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PhotonUnexpectedLeftRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PhotonDisconnectException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly int? LastExceptionStatusCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DisconnectCause DisconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x993F890", Offset = "0x993E690", VA = "0x18993F890")]
		public PhotonDisconnectException(DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x993F5D0", Offset = "0x993E3D0", VA = "0x18993F5D0")]
		public static PhotonDisconnectException QUHWZPNWYZU(DisconnectCause a, CDPRAJEFKDH b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x993F570", Offset = "0x993E370", VA = "0x18993F570")]
		public PhotonAuthException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PhotonRoomJoinException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x993FAB0", Offset = "0x993E8B0", VA = "0x18993FAB0")]
		public PhotonRoomJoinException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PhotonRoomCreateException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x993F9D0", Offset = "0x993E7D0", VA = "0x18993F9D0")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x993F570", Offset = "0x993E370", VA = "0x18993F570")]
		public PhotonInvalidNetworkQueueStateException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PhotonFailedToLeaveRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PhotonTcsTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Dictionary<string, string> AdditionalInfo;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class YWDQBEIJOEE : IEquatable<YWDQBEIJOEE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JGTGNYJONIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string? IHOOAENDQTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly string? GFNTSIGMOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly string? OHYVGHWYNDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string BCEISMZVZVS;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9945800", Offset = "0x9944600", VA = "0x189945800")]
		public YWDQBEIJOEE(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99457A0", Offset = "0x99445A0", VA = "0x1899457A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9945590", Offset = "0x9944390", VA = "0x189945590", Slot = "4")]
		public bool Equals(YWDQBEIJOEE? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9945620", Offset = "0x9944420", VA = "0x189945620", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99456B0", Offset = "0x99444B0", VA = "0x1899456B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WABBHQTINSC : YWDQBEIJOEE, IEquatable<WABBHQTINSC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string LQHSBCNFFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string? KAOCCYWQEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly string? OBIAHZGWXZR;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99453C0", Offset = "0x99441C0", VA = "0x1899453C0")]
		public WABBHQTINSC(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9945360", Offset = "0x9944160", VA = "0x189945360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99450D0", Offset = "0x9943ED0", VA = "0x1899450D0", Slot = "5")]
		public bool Equals(WABBHQTINSC? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9945150", Offset = "0x9943F50", VA = "0x189945150", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9945220", Offset = "0x9944020", VA = "0x189945220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x157E370", Offset = "0x157D170", VA = "0x18157E370")]
		public static bool CYAUITUETAA(WABBHQTINSC? a, WABBHQTINSC? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RecRoom.NoEngine.Common.Preserve]
	public class AuthPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[JsonProperty(PropertyName = "AI", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[JsonProperty(PropertyName = "AT", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[JsonProperty(PropertyName = "VB", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] VerificationBlob
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientKeyA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientIVA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientPublicKey
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public AuthPayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.NoEngine.Common.Preserve]
	public class ConnectionResponsePayload
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[JsonProperty(PropertyName = "DR", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string Reason
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[JsonProperty(PropertyName = "KT", Required = Required.Default)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] SessionKeyB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TachyonClient : RWCUJOOLKDY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Connected
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstance>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder<WABBHQTINSC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public TachyonClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public WABBHQTINSC targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<WABBHQTINSC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9944210", Offset = "0x9943010", VA = "0x189944210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9944E20", Offset = "0x9943C20", VA = "0x189944E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <LogWhileInRoom>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Task<VoidType> whileInRoomTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<VoidType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9944E90", Offset = "0x9943C90", VA = "0x189944E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NetworkManager MIQOOVOMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskCompletionSource<WABBHQTINSC> NAEMLEHAYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly WHWIROLHRQO LMVVDSZGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		protected readonly ISYPUZZLNOB KOKQXLHZDGR;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<DisconnectHandler> QUVCGSOCFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ClientState BIISUWTDTNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private WABBHQTINSC VQRBFULQSUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private RSACryptoServiceProvider BUHIHUENSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RSACryptoServiceProvider NRRCIDSTPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AesCryptoServiceProvider GUREWXYEXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] RZREDMZDMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<VoidType> LLTIIJZELAE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WABBHQTINSC SBKQLLCVCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Task EKXRFZTFJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9943710", Offset = "0x9942510", VA = "0x189943710", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9943A70", Offset = "0x9942870", VA = "0x189943A70", Slot = "8")]
		public void VKMGEYSOSCK(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9942B00", Offset = "0x9941900", VA = "0x189942B00", Slot = "11")]
		public bool PGELOIVUMEU(WABBHQTINSC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9943D20", Offset = "0x9942B20", VA = "0x189943D20")]
		[RecRoom.NoEngine.Common.Preserve]
		public TachyonClient([Inject(null)] WHWIROLHRQO networking, [Inject(null)] ISYPUZZLNOB _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private void UQPDAJIDNWL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private void KPSFJEQMQMK(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9942CA0", Offset = "0x9941AA0", VA = "0x189942CA0")]
		private void QULNCQJQPFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9942140", Offset = "0x9940F40", VA = "0x189942140")]
		private void NXJRQYXFNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99437A0", Offset = "0x99425A0", VA = "0x1899437A0")]
		private void UZMKYTOEXKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9942980", Offset = "0x9941780", VA = "0x189942980")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9942A00", Offset = "0x9941800", VA = "0x189942A00")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9941EB0", Offset = "0x9940CB0", VA = "0x189941EB0")]
		private void EKDVTRNPUCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99422C0", Offset = "0x99410C0", VA = "0x1899422C0")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9942A80", Offset = "0x9941880", VA = "0x189942A80")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99420D0", Offset = "0x9940ED0", VA = "0x1899420D0")]
		private void GKHQUJMMECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9943590", Offset = "0x9942390", VA = "0x189943590")]
		private void SXJIRRGXCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9941AC0", Offset = "0x99408C0", VA = "0x189941AC0")]
		private void DRKEILXACRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9943AD0", Offset = "0x99428D0", VA = "0x189943AD0")]
		private static (IPAddress, ushort) VWMHVGQRWKN(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9942EF0", Offset = "0x9941CF0", VA = "0x189942EF0")]
		private void RVHLBMSVTWG(WABBHQTINSC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9942B40", Offset = "0x9941940", VA = "0x189942B40", Slot = "6")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__42))]
		public Task<WABBHQTINSC> QBDEUCYUOYM(WABBHQTINSC a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9943C00", Offset = "0x9942A00", VA = "0x189943C00")]
		[AsyncStateMachine(typeof(<LogWhileInRoom>d__43))]
		private void YHCYSPFDGAO(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9941D50", Offset = "0x9940B50", VA = "0x189941D50", Slot = "5")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99419D0", Offset = "0x99407D0", VA = "0x1899419D0", Slot = "7")]
		public Task CCECSFRFXJR([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9941E40", Offset = "0x9940C40", VA = "0x189941E40", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9943FE0", Offset = "0x9942DE0", VA = "0x189943FE0")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9944040", Offset = "0x9942E40", VA = "0x189944040")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99440B0", Offset = "0x9942EB0", VA = "0x1899440B0")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9944190", Offset = "0x9942F90", VA = "0x189944190")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9941950", Offset = "0x9940750", VA = "0x189941950")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class FEYNZXUTVAO
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static AesCryptoServiceProvider UTTBHJNSIXM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string QYRAWBECNHZ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string MPDNGAZCAUT;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string BBDYRZSWFQH;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x993F0C0", Offset = "0x993DEC0", VA = "0x18993F0C0")]
		public static string FWXYYVCHBRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x993F110", Offset = "0x993DF10", VA = "0x18993F110")]
		public static string QDIZCNAHUSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x993F160", Offset = "0x993DF60", VA = "0x18993F160")]
		public static AesCryptoServiceProvider XKCIWPZHJCA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SQABOVNBEME : ERCNSIQRTVN
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Connected
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private DYNHRMPGIXT XQBIKLOHMTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NetworkManager MIQOOVOMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly ISYPUZZLNOB KOKQXLHZDGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskCompletionSource<bool> HMVYRKDGMWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ClientState BIISUWTDTNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RSACryptoServiceProvider BUHIHUENSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private RSACryptoServiceProvider NRRCIDSTPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AesCryptoServiceProvider GUREWXYEXBD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DYNHRMPGIXT QDBPTYDEQPX
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string KXVOIELCUSI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string GRWZMJHKIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x993FB90", Offset = "0x993E990", VA = "0x18993FB90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99417B0", Offset = "0x99405B0", VA = "0x1899417B0")]
		[UnityEngine.Scripting.Preserve]
		public SQABOVNBEME([Inject(null)] ISYPUZZLNOB _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9940DA0", Offset = "0x993FBA0", VA = "0x189940DA0")]
		private void QULNCQJQPFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99406F0", Offset = "0x993F4F0", VA = "0x1899406F0")]
		private void NXJRQYXFNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9940970", Offset = "0x993F770", VA = "0x189940970")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9940250", Offset = "0x993F050", VA = "0x189940250")]
		private void LLEMJEODZCK(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9940820", Offset = "0x993F620", VA = "0x189940820")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9940CB0", Offset = "0x993FAB0", VA = "0x189940CB0")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99401E0", Offset = "0x993EFE0", VA = "0x1899401E0")]
		private void GKHQUJMMECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x993FCB0", Offset = "0x993EAB0", VA = "0x18993FCB0")]
		private void DRKEILXACRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9941680", Offset = "0x9940480", VA = "0x189941680")]
		private static (IPAddress, ushort) VWMHVGQRWKN(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9940F90", Offset = "0x993FD90", VA = "0x189940F90")]
		private void RVHLBMSVTWG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x993FE10", Offset = "0x993EC10", VA = "0x18993FE10", Slot = "7")]
		public Task<bool> EFJCGNGZDVL(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x993FD70", Offset = "0x993EB70", VA = "0x18993FD70", Slot = "8")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
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
